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
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gamedataStatPoolType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("modifiers", 2)] 
		public CArrayFixedSize<gameStatPoolModifier> Modifiers
		{
			get => GetProperty(ref _modifiers);
			set => SetProperty(ref _modifiers, value);
		}

		[Ordinal(4)] 
		[RED("alternativeModifierRecords", 2)] 
		public CArrayFixedSize<TweakDBID> AlternativeModifierRecords
		{
			get => GetProperty(ref _alternativeModifierRecords);
			set => SetProperty(ref _alternativeModifierRecords, value);
		}

		[Ordinal(5)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(6)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(7)] 
		[RED("customLimitValue")] 
		public CFloat CustomLimitValue
		{
			get => GetProperty(ref _customLimitValue);
			set => SetProperty(ref _customLimitValue, value);
		}

		[Ordinal(8)] 
		[RED("changeMode")] 
		public CEnum<gameStatPoolDataValueChangeMode> ChangeMode
		{
			get => GetProperty(ref _changeMode);
			set => SetProperty(ref _changeMode, value);
		}

		[Ordinal(9)] 
		[RED("bonus")] 
		public CFloat Bonus
		{
			get => GetProperty(ref _bonus);
			set => SetProperty(ref _bonus, value);
		}

		[Ordinal(10)] 
		[RED("bonusType")] 
		public CEnum<gameStatPoolDataBonusType> BonusType
		{
			get => GetProperty(ref _bonusType);
			set => SetProperty(ref _bonusType, value);
		}

		[Ordinal(11)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(12)] 
		[RED("modificationDelay")] 
		public CFloat ModificationDelay
		{
			get => GetProperty(ref _modificationDelay);
			set => SetProperty(ref _modificationDelay, value);
		}

		[Ordinal(13)] 
		[RED("modificationStatus")] 
		public CEnum<gameStatPoolDataStatPoolModificationStatus> ModificationStatus
		{
			get => GetProperty(ref _modificationStatus);
			set => SetProperty(ref _modificationStatus, value);
		}

		public gameStatPoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
