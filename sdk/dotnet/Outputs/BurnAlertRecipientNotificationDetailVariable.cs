// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio.Outputs
{

    [OutputType]
    public sealed class BurnAlertRecipientNotificationDetailVariable
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The value of the variable
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private BurnAlertRecipientNotificationDetailVariable(
            string name,

            string? value)
        {
            Name = name;
            Value = value;
        }
    }
}
