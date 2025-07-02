# Pulumi and Honeycomb Workshop

This workshop uses the OpenTelemetry demo application to show how you can deploy an application with Pulumi, and then use the new Pulumi Terraform provider to generate and use the Honeycomb Terraform module.

## Prerequisites

- [Free Pulumi Account](https://app.pulumi.com/?create-organization=1)
- [Free Honeycomb Account](https://cloud.honeycomb.io/signup)
- [Kubernetes Cluster](https://kubernetes.io/docs/setup/)
- [Pulumi CLI](https://www.pulumi.com/docs/get-started/install/)
- [Honeycomb Management API Key](https://docs.honeycomb.io/configure/teams/manage-api-keys/#create-management-api-key)

## Setup

1. Clone this repository
2. Ensure you have a valid Kubernetes context set with `kubectl config current-context`
3. Login to Pulumi with `pulumi login`
4. Create a new stack with `pulumi stack init`
5. Deploy the infrastructure with `pulumi up`
