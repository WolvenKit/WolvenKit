using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveNoWeaponCombatConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("onItemAddedToSlotCbId")] 
		public CUInt32 OnItemAddedToSlotCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveNoWeaponCombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
