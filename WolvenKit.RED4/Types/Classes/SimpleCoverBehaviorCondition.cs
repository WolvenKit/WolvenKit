using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleCoverBehaviorCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isShotgunner")] 
		public CBool IsShotgunner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isHeavyRanged")] 
		public CBool IsHeavyRanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SimpleCoverBehaviorCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
