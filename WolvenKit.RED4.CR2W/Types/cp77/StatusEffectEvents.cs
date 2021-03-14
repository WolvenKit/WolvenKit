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
			get
			{
				if (_statusEffectRecord == null)
				{
					_statusEffectRecord = (wCHandle<gamedataStatusEffect_Record>) CR2WTypeManager.Create("whandle:gamedataStatusEffect_Record", "statusEffectRecord", cr2w, this);
				}
				return _statusEffectRecord;
			}
			set
			{
				if (_statusEffectRecord == value)
				{
					return;
				}
				_statusEffectRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerStatusEffectRecordData")] 
		public wCHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get
			{
				if (_playerStatusEffectRecordData == null)
				{
					_playerStatusEffectRecordData = (wCHandle<gamedataStatusEffectPlayerData_Record>) CR2WTypeManager.Create("whandle:gamedataStatusEffectPlayerData_Record", "playerStatusEffectRecordData", cr2w, this);
				}
				return _playerStatusEffectRecordData;
			}
			set
			{
				if (_playerStatusEffectRecordData == value)
				{
					return;
				}
				_playerStatusEffectRecordData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get
			{
				if (_animFeatureStatusEffect == null)
				{
					_animFeatureStatusEffect = (CHandle<AnimFeature_StatusEffect>) CR2WTypeManager.Create("handle:AnimFeature_StatusEffect", "animFeatureStatusEffect", cr2w, this);
				}
				return _animFeatureStatusEffect;
			}
			set
			{
				if (_animFeatureStatusEffect == value)
				{
					return;
				}
				_animFeatureStatusEffect = value;
				PropertySet(this);
			}
		}

		public StatusEffectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
