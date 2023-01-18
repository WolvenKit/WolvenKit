using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCollisionGroupEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("neRef")] 
		public NodeRef NeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("Reversed")] 
		public CBool Reversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCollisionGroupEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
