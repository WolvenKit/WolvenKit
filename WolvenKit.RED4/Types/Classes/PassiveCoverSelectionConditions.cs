using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveCoverSelectionConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("statsChangedCbId")] 
		public CUInt32 StatsChangedCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("ability")] 
		public CWeakHandle<gamedataGameplayAbility_Record> Ability
		{
			get => GetPropertyValue<CWeakHandle<gamedataGameplayAbility_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataGameplayAbility_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("statListener")] 
		public CHandle<AIStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<AIStatListener>>();
			set => SetPropertyValue<CHandle<AIStatListener>>(value);
		}

		public PassiveCoverSelectionConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
