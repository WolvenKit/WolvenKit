using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectEvents : LocomotionGroundEvents
	{
		private wCHandle<gamedataStatusEffect_Record> _statusEffectRecord;
		private wCHandle<gamedataStatusEffectPlayerData_Record> _playerStatusEffectRecordData;
		private CHandle<AnimFeature_StatusEffect> _animFeatureStatusEffect;

		[Ordinal(0)] 
		[RED("statusEffectRecord")] 
		public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		[Ordinal(1)] 
		[RED("playerStatusEffectRecordData")] 
		public wCHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get => GetProperty(ref _playerStatusEffectRecordData);
			set => SetProperty(ref _playerStatusEffectRecordData, value);
		}

		[Ordinal(2)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetProperty(ref _animFeatureStatusEffect);
			set => SetProperty(ref _animFeatureStatusEffect, value);
		}

		public StatusEffectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
