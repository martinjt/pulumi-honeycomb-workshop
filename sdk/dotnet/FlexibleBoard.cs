// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Honeycombio
{
    [HoneycombioResourceType("honeycombio:index/flexibleBoard:FlexibleBoard")]
    public partial class FlexibleBoard : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The URL of the Board in the Honeycomb UI.
        /// </summary>
        [Output("boardUrl")]
        public Output<string> BoardUrl { get; private set; } = null!;

        /// <summary>
        /// The description of the Board. Supports Markdown.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the Board.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of panels to render on the board.
        /// </summary>
        [Output("panels")]
        public Output<ImmutableArray<Outputs.FlexibleBoardPanel>> Panels { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a FlexibleBoard resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FlexibleBoard(string name, FlexibleBoardArgs? args = null, CustomResourceOptions? options = null)
            : base("honeycombio:index/flexibleBoard:FlexibleBoard", name, args ?? new FlexibleBoardArgs(), MakeResourceOptions(options, ""), Utilities.PackageParameterization())
        {
        }

        private FlexibleBoard(string name, Input<string> id, FlexibleBoardState? state = null, CustomResourceOptions? options = null)
            : base("honeycombio:index/flexibleBoard:FlexibleBoard", name, state, MakeResourceOptions(options, id), Utilities.PackageParameterization())
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
        /// Get an existing FlexibleBoard resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FlexibleBoard Get(string name, Input<string> id, FlexibleBoardState? state = null, CustomResourceOptions? options = null)
        {
            return new FlexibleBoard(name, id, state, options);
        }
    }

    public sealed class FlexibleBoardArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the Board. Supports Markdown.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the Board.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("panels")]
        private InputList<Inputs.FlexibleBoardPanelArgs>? _panels;

        /// <summary>
        /// List of panels to render on the board.
        /// </summary>
        public InputList<Inputs.FlexibleBoardPanelArgs> Panels
        {
            get => _panels ?? (_panels = new InputList<Inputs.FlexibleBoardPanelArgs>());
            set => _panels = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public FlexibleBoardArgs()
        {
        }
        public static new FlexibleBoardArgs Empty => new FlexibleBoardArgs();
    }

    public sealed class FlexibleBoardState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of the Board in the Honeycomb UI.
        /// </summary>
        [Input("boardUrl")]
        public Input<string>? BoardUrl { get; set; }

        /// <summary>
        /// The description of the Board. Supports Markdown.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the Board.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("panels")]
        private InputList<Inputs.FlexibleBoardPanelGetArgs>? _panels;

        /// <summary>
        /// List of panels to render on the board.
        /// </summary>
        public InputList<Inputs.FlexibleBoardPanelGetArgs> Panels
        {
            get => _panels ?? (_panels = new InputList<Inputs.FlexibleBoardPanelGetArgs>());
            set => _panels = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public FlexibleBoardState()
        {
        }
        public static new FlexibleBoardState Empty => new FlexibleBoardState();
    }
}
