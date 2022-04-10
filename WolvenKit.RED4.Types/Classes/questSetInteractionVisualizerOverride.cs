using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetInteractionVisualizerOverride : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("applyOverride")] 
		public CBool ApplyOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("removeAfterSingleUse")] 
		public CBool RemoveAfterSingleUse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetInteractionVisualizerOverride()
		{
			ApplyOverride = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
