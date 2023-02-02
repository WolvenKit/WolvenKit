using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorConditionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		[Ordinal(0)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
