using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveCombatConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("combatCommandCbId")] 
		public CUInt32 CombatCommandCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("threatCbId")] 
		public CUInt32 ThreatCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("playerCombatCbId")] 
		public CUInt32 PlayerCombatCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("activeCombatConditionCbId")] 
		public CUInt32 ActiveCombatConditionCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveCombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
