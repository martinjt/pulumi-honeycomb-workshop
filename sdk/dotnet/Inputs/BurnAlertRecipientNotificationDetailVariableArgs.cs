// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio.Inputs
{

    public sealed class BurnAlertRecipientNotificationDetailVariableArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The value of the variable
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public BurnAlertRecipientNotificationDetailVariableArgs()
        {
        }
        public static new BurnAlertRecipientNotificationDetailVariableArgs Empty => new BurnAlertRecipientNotificationDetailVariableArgs();
    }
}
