using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolData : CVariable
	{
		private gameStatsObjectID _ownerID;
		private TweakDBID _recordID;
		private CEnum<gamedataStatPoolType> _type;
		private CArrayFixedSize<gameStatPoolModifier> _modifiers;
		private CArrayFixedSize<TweakDBID> _alternativeModifierRecords;
		private CEnum<gamedataStatType> _stat;
		private CFloat _maxValue;
		private CFloat _customLimitValue;
		private CEnum<gameStatPoolDataValueChangeMode> _changeMode;
		private CFloat _bonus;
		private CEnum<gameStatPoolDataBonusType> _bonusType;
		private CFloat _currentValue;
		private CFloat _modificationDelay;
		private CEnum<gameStatPoolDataStatPoolModificationStatus> _modificationStatus;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public gameStatsObjectID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gamedataStatPoolType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("modifiers", 2)] 
		public CArrayFixedSize<gameStatPoolModifier> Modifiers
		{
			get
			{
				if (_modifiers == null)
				{
					_modifiers = (CArrayFixedSize<gameStatPoolModifier>) CR2WTypeManager.Create("[2]gameStatPoolModifier", "modifiers", cr2w, this);
				}
				return _modifiers;
			}
			set
			{
				if (_modifiers == value)
				{
					return;
				}
				_modifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("alternativeModifierRecords", 2)] 
		public CArrayFixedSize<TweakDBID> AlternativeModifierRecords
		{
			get
			{
				if (_alternativeModifierRecords == null)
				{
					_alternativeModifierRecords = (CArrayFixedSize<TweakDBID>) CR2WTypeManager.Create("[2]TweakDBID", "alternativeModifierRecords", cr2w, this);
				}
				return _alternativeModifierRecords;
			}
			set
			{
				if (_alternativeModifierRecords == value)
				{
					return;
				}
				_alternativeModifierRecords = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get
			{
				if (_stat == null)
				{
					_stat = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "stat", cr2w, this);
				}
				return _stat;
			}
			set
			{
				if (_stat == value)
				{
					return;
				}
				_stat = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CFloat) CR2WTypeManager.Create("Float", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("customLimitValue")] 
		public CFloat CustomLimitValue
		{
			get
			{
				if (_customLimitValue == null)
				{
					_customLimitValue = (CFloat) CR2WTypeManager.Create("Float", "customLimitValue", cr2w, this);
				}
				return _customLimitValue;
			}
			set
			{
				if (_customLimitValue == value)
				{
					return;
				}
				_customLimitValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("changeMode")] 
		public CEnum<gameStatPoolDataValueChangeMode> ChangeMode
		{
			get
			{
				if (_changeMode == null)
				{
					_changeMode = (CEnum<gameStatPoolDataValueChangeMode>) CR2WTypeManager.Create("gameStatPoolDataValueChangeMode", "changeMode", cr2w, this);
				}
				return _changeMode;
			}
			set
			{
				if (_changeMode == value)
				{
					return;
				}
				_changeMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bonus")] 
		public CFloat Bonus
		{
			get
			{
				if (_bonus == null)
				{
					_bonus = (CFloat) CR2WTypeManager.Create("Float", "bonus", cr2w, this);
				}
				return _bonus;
			}
			set
			{
				if (_bonus == value)
				{
					return;
				}
				_bonus = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bonusType")] 
		public CEnum<gameStatPoolDataBonusType> BonusType
		{
			get
			{
				if (_bonusType == null)
				{
					_bonusType = (CEnum<gameStatPoolDataBonusType>) CR2WTypeManager.Create("gameStatPoolDataBonusType", "bonusType", cr2w, this);
				}
				return _bonusType;
			}
			set
			{
				if (_bonusType == value)
				{
					return;
				}
				_bonusType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CFloat) CR2WTypeManager.Create("Float", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("modificationDelay")] 
		public CFloat ModificationDelay
		{
			get
			{
				if (_modificationDelay == null)
				{
					_modificationDelay = (CFloat) CR2WTypeManager.Create("Float", "modificationDelay", cr2w, this);
				}
				return _modificationDelay;
			}
			set
			{
				if (_modificationDelay == value)
				{
					return;
				}
				_modificationDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("modificationStatus")] 
		public CEnum<gameStatPoolDataStatPoolModificationStatus> ModificationStatus
		{
			get
			{
				if (_modificationStatus == null)
				{
					_modificationStatus = (CEnum<gameStatPoolDataStatPoolModificationStatus>) CR2WTypeManager.Create("gameStatPoolDataStatPoolModificationStatus", "modificationStatus", cr2w, this);
				}
				return _modificationStatus;
			}
			set
			{
				if (_modificationStatus == value)
				{
					return;
				}
				_modificationStatus = value;
				PropertySet(this);
			}
		}

		public gameStatPoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
