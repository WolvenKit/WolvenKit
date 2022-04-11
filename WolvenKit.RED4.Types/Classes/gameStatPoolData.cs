using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatPoolData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public gameStatsObjectID OwnerID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gamedataStatPoolType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(3)] 
		[RED("modifiers", 2)] 
		public CArrayFixedSize<gameStatPoolModifier> Modifiers
		{
			get => GetPropertyValue<CArrayFixedSize<gameStatPoolModifier>>();
			set => SetPropertyValue<CArrayFixedSize<gameStatPoolModifier>>(value);
		}

		[Ordinal(4)] 
		[RED("alternativeModifierRecords", 2)] 
		public CArrayFixedSize<TweakDBID> AlternativeModifierRecords
		{
			get => GetPropertyValue<CArrayFixedSize<TweakDBID>>();
			set => SetPropertyValue<CArrayFixedSize<TweakDBID>>(value);
		}

		[Ordinal(5)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(6)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("customLimitValue")] 
		public CFloat CustomLimitValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("changeMode")] 
		public CEnum<gameStatPoolDataValueChangeMode> ChangeMode
		{
			get => GetPropertyValue<CEnum<gameStatPoolDataValueChangeMode>>();
			set => SetPropertyValue<CEnum<gameStatPoolDataValueChangeMode>>(value);
		}

		[Ordinal(9)] 
		[RED("bonus")] 
		public CFloat Bonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("bonusType")] 
		public CEnum<gameStatPoolDataBonusType> BonusType
		{
			get => GetPropertyValue<CEnum<gameStatPoolDataBonusType>>();
			set => SetPropertyValue<CEnum<gameStatPoolDataBonusType>>(value);
		}

		[Ordinal(11)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("modificationDelay")] 
		public CFloat ModificationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("modificationStatus")] 
		public CEnum<gameStatPoolDataStatPoolModificationStatus> ModificationStatus
		{
			get => GetPropertyValue<CEnum<gameStatPoolDataStatPoolModificationStatus>>();
			set => SetPropertyValue<CEnum<gameStatPoolDataStatPoolModificationStatus>>(value);
		}

		public gameStatPoolData()
		{
			OwnerID = new() { IdType = Enums.gameStatIDType.Invalid };
			Type = Enums.gamedataStatPoolType.Invalid;
			Modifiers = new(2);
			AlternativeModifierRecords = new(2);
			Stat = Enums.gamedataStatType.Invalid;
			ModificationStatus = Enums.gameStatPoolDataStatPoolModificationStatus.NoModification;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
