// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio
{
    public static class GetQueryResult
    {
        public static Task<GetQueryResultResult> InvokeAsync(GetQueryResultArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetQueryResultResult>("honeycombio:index/getQueryResult:getQueryResult", args ?? new GetQueryResultArgs(), options.WithDefaults(), Utilities.PackageParameterization());

        public static Output<GetQueryResultResult> Invoke(GetQueryResultInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetQueryResultResult>("honeycombio:index/getQueryResult:getQueryResult", args ?? new GetQueryResultInvokeArgs(), options.WithDefaults());

        public static Output<GetQueryResultResult> Invoke(GetQueryResultInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetQueryResultResult>("honeycombio:index/getQueryResult:getQueryResult", args ?? new GetQueryResultInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetQueryResultArgs : global::Pulumi.InvokeArgs
    {
        [Input("dataset")]
        public string? Dataset { get; set; }

        [Input("id")]
        public string? Id { get; set; }

        [Input("queryJson", required: true)]
        public string QueryJson { get; set; } = null!;

        public GetQueryResultArgs()
        {
        }
        public static new GetQueryResultArgs Empty => new GetQueryResultArgs();
    }

    public sealed class GetQueryResultInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("dataset")]
        public Input<string>? Dataset { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("queryJson", required: true)]
        public Input<string> QueryJson { get; set; } = null!;

        public GetQueryResultInvokeArgs()
        {
        }
        public static new GetQueryResultInvokeArgs Empty => new GetQueryResultInvokeArgs();
    }


    [OutputType]
    public sealed class GetQueryResultResult
    {
        public readonly string? Dataset;
        public readonly string GraphImageUrl;
        public readonly string Id;
        public readonly string QueryId;
        public readonly string QueryJson;
        public readonly string QueryUrl;
        public readonly ImmutableArray<ImmutableDictionary<string, string>> Results;

        [OutputConstructor]
        private GetQueryResultResult(
            string? dataset,

            string graphImageUrl,

            string id,

            string queryId,

            string queryJson,

            string queryUrl,

            ImmutableArray<ImmutableDictionary<string, string>> results)
        {
            Dataset = dataset;
            GraphImageUrl = graphImageUrl;
            Id = id;
            QueryId = queryId;
            QueryJson = queryJson;
            QueryUrl = queryUrl;
            Results = results;
        }
    }
}
