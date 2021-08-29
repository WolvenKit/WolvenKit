using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectEvents : LocomotionGroundEvents
	{
		private CWeakHandle<gamedataStatusEffect_Record> _statusEffectRecord;
		private CWeakHandle<gamedataStatusEffectPlayerData_Record> _playerStatusEffectRecordData;
		private CHandle<AnimFeature_StatusEffect> _animFeatureStatusEffect;

		[Ordinal(3)] 
		[RED("statusEffectRecord")] 
		public CWeakHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		[Ordinal(4)] 
		[RED("playerStatusEffectRecordData")] 
		public CWeakHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get => GetProperty(ref _playerStatusEffectRecordData);
			set => SetProperty(ref _playerStatusEffectRecordData, value);
		}

		[Ordinal(5)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetProperty(ref _animFeatureStatusEffect);
			set => SetProperty(ref _animFeatureStatusEffect, value);
		}
	}
}
