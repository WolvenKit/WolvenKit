using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootContainerBase : gameObject
	{
		[Ordinal(36)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(38)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(39)] 
		[RED("isIllegal")] 
		public CBool IsIllegal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("wasLootInitalized")] 
		public CBool WasLootInitalized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("containerType")] 
		public CEnum<gamedataContainerType> ContainerType
		{
			get => GetPropertyValue<CEnum<gamedataContainerType>>();
			set => SetPropertyValue<CEnum<gamedataContainerType>>(value);
		}

		[Ordinal(42)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(43)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameLootContainerBase()
		{
			UseAreaLoot = true;
			LootTables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
