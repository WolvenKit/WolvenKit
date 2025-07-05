using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIsInDesiredRangeConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(3)] 
		[RED("desiredDistance")] 
		public CHandle<AIArgumentMapping> DesiredDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("deadZoneRadius")] 
		public CHandle<AIArgumentMapping> DeadZoneRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorIsInDesiredRangeConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
