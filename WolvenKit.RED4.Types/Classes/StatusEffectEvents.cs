using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("statusEffectRecord")] 
		public CWeakHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("playerStatusEffectRecordData")] 
		public CWeakHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffectPlayerData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffectPlayerData_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetPropertyValue<CHandle<AnimFeature_StatusEffect>>();
			set => SetPropertyValue<CHandle<AnimFeature_StatusEffect>>(value);
		}

		[Ordinal(9)] 
		[RED("statusEffectEnumName")] 
		public CString StatusEffectEnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public StatusEffectEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
