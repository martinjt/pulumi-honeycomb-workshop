// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio.Inputs
{

    public sealed class BoardSloGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the SLO.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public BoardSloGetArgs()
        {
        }
        public static new BoardSloGetArgs Empty => new BoardSloGetArgs();
    }
}
