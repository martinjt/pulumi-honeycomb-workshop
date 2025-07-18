// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio.Inputs
{

    public sealed class GetAuthMetadataTeamInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Team.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The slug of the Team.
        /// </summary>
        [Input("slug", required: true)]
        public Input<string> Slug { get; set; } = null!;

        public GetAuthMetadataTeamInputArgs()
        {
        }
        public static new GetAuthMetadataTeamInputArgs Empty => new GetAuthMetadataTeamInputArgs();
    }
}
