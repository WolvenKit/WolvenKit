using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveCrowdCombatConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("threatCbId")] 
		public CUInt32 ThreatCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("onItemAddedToSlotCbId")] 
		public CUInt32 OnItemAddedToSlotCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("crowdCombatConditionCbId")] 
		public CUInt32 CrowdCombatConditionCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveCrowdCombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
