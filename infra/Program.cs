using System.Collections.Generic;
using Pulumi;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
using Pulumi.Honeycombio;

return await Deployment.RunAsync(static () =>
{
    // Create the OpenTelemetry Demo namespace
    var otelDemoNamespace = new Pulumi.Kubernetes.Core.V1.Namespace("pulumi-workshop", new()
    {
        Metadata = new Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs
        {
            Name = "pulumi-workshop"
        }
    });

    var honeycombEnvironment = new Environment("workshop-environment", new EnvironmentArgs
    {
        Name = "Pulumi Workshop",
        Description = "Environment for the Pulumi OpenTelemetry workshop"
    });

    // Create a Honeycomb API Key for dataset creation
    var honeycombApiKey = new ApiKey("workshop-api-key", new ApiKeyArgs
    {
        Name = "Pulumi Workshop API Key",
        Type = "ingest",
        EnvironmentId = honeycombEnvironment.Id,
        Permissions = new[]
        {
            new Pulumi.Honeycombio.Inputs.ApiKeyPermissionArgs
            {
                CreateDatasets = true
            }
        }
    });

    // Create a Kubernetes secret with the Honeycomb API key
    var honeycombSecret = new Pulumi.Kubernetes.Core.V1.Secret("honeycomb-api-key", new()
    {
        Metadata = new Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs
        {
            Name = "honeycomb-api-key",
            Namespace = otelDemoNamespace.Metadata.Apply(m => m.Name)
        },
        StringData =
        {
            ["api-key"] = honeycombApiKey.Key
        }
    });

    var otelDemo = new Release("opentelemetry-demo", new ReleaseArgs
    {
        Chart = "opentelemetry-demo",
        RepositoryOpts = new RepositoryOptsArgs
        {
            Repo = "https://open-telemetry.github.io/opentelemetry-helm-charts"
        },
        Namespace = otelDemoNamespace.Metadata.Apply(m => m.Name),
        ValueYamlFiles = new[]
        {
            new FileAsset("values.yaml")
        },
        Values = new Dictionary<string, object>
        {
            ["opentelemetry-collector"] = new Dictionary<string, object>
            {
                ["extraEnvs"] = new[]
                {
                    new Dictionary<string, object>
                    {
                        ["name"] = "HONEYCOMB_API_KEY",
                        ["valueFrom"] = new Dictionary<string, object>
                        {
                            ["secretKeyRef"] = new Dictionary<string, object>
                            {
                                ["name"] = honeycombSecret.Metadata.Apply(m => m.Name),
                                ["key"] = "api-key"
                            }
                        }
                    }
                }
            }
        }
    });

    return new Dictionary<string, object?>
    {
        ["namespace"] = otelDemoNamespace.Metadata.Apply(m => m.Name),
        ["helmReleaseName"] = otelDemo.Name,
        ["honeycombEnvironmentName"] = honeycombEnvironment.Name,
    };
});
