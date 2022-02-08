using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootContainerBase : gameObject
	{
		[Ordinal(40)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(42)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(43)] 
		[RED("isIllegal")] 
		public CBool IsIllegal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("wasLootInitalized")] 
		public CBool WasLootInitalized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(46)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
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
		}
	}
}
