// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio.Inputs
{

    public sealed class GetQuerySpecificationFilterArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The column to filter on.
        /// </summary>
        [Input("column", required: true)]
        public string Column { get; set; } = null!;

        /// <summary>
        /// The operator to apply.
        /// </summary>
        [Input("op", required: true)]
        public string Op { get; set; } = null!;

        /// <summary>
        /// The value used for the filter. Not needed if op is "exists" or "not-exists".
        /// </summary>
        [Input("value")]
        public string? Value { get; set; }

        public GetQuerySpecificationFilterArgs()
        {
        }
        public static new GetQuerySpecificationFilterArgs Empty => new GetQuerySpecificationFilterArgs();
    }
}
