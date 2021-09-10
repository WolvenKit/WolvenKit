using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("statusEffectRecord")] 
		public CWeakHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(4)] 
		[RED("playerStatusEffectRecordData")] 
		public CWeakHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffectPlayerData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffectPlayerData_Record>>(value);
		}

		[Ordinal(5)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetPropertyValue<CHandle<AnimFeature_StatusEffect>>();
			set => SetPropertyValue<CHandle<AnimFeature_StatusEffect>>(value);
		}
	}
}
