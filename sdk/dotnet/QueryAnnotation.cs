// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio
{
    [HoneycombioResourceType("honeycombio:index/queryAnnotation:QueryAnnotation")]
    public partial class QueryAnnotation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The dataset this query annotation is added to. If not set, an Environment-wide query annotation will be created.
        /// </summary>
        [Output("dataset")]
        public Output<string?> Dataset { get; private set; } = null!;

        /// <summary>
        /// The description to display as the query annotation.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The name to display as the query annotation.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("queryAnnotationId")]
        public Output<string> QueryAnnotationId { get; private set; } = null!;

        /// <summary>
        /// The ID of the query that the annotation will be created on. Note that a query can have more than one annotation.
        /// </summary>
        [Output("queryId")]
        public Output<string> QueryId { get; private set; } = null!;


        /// <summary>
        /// Create a QueryAnnotation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public QueryAnnotation(string name, QueryAnnotationArgs args, CustomResourceOptions? options = null)
            : base("honeycombio:index/queryAnnotation:QueryAnnotation", name, args ?? new QueryAnnotationArgs(), MakeResourceOptions(options, ""), Utilities.PackageParameterization())
        {
        }

        private QueryAnnotation(string name, Input<string> id, QueryAnnotationState? state = null, CustomResourceOptions? options = null)
            : base("honeycombio:index/queryAnnotation:QueryAnnotation", name, state, MakeResourceOptions(options, id), Utilities.PackageParameterization())
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing QueryAnnotation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static QueryAnnotation Get(string name, Input<string> id, QueryAnnotationState? state = null, CustomResourceOptions? options = null)
        {
            return new QueryAnnotation(name, id, state, options);
        }
    }

    public sealed class QueryAnnotationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The dataset this query annotation is added to. If not set, an Environment-wide query annotation will be created.
        /// </summary>
        [Input("dataset")]
        public Input<string>? Dataset { get; set; }

        /// <summary>
        /// The description to display as the query annotation.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name to display as the query annotation.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("queryAnnotationId")]
        public Input<string>? QueryAnnotationId { get; set; }

        /// <summary>
        /// The ID of the query that the annotation will be created on. Note that a query can have more than one annotation.
        /// </summary>
        [Input("queryId", required: true)]
        public Input<string> QueryId { get; set; } = null!;

        public QueryAnnotationArgs()
        {
        }
        public static new QueryAnnotationArgs Empty => new QueryAnnotationArgs();
    }

    public sealed class QueryAnnotationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The dataset this query annotation is added to. If not set, an Environment-wide query annotation will be created.
        /// </summary>
        [Input("dataset")]
        public Input<string>? Dataset { get; set; }

        /// <summary>
        /// The description to display as the query annotation.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name to display as the query annotation.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("queryAnnotationId")]
        public Input<string>? QueryAnnotationId { get; set; }

        /// <summary>
        /// The ID of the query that the annotation will be created on. Note that a query can have more than one annotation.
        /// </summary>
        [Input("queryId")]
        public Input<string>? QueryId { get; set; }

        public QueryAnnotationState()
        {
        }
        public static new QueryAnnotationState Empty => new QueryAnnotationState();
    }
}
