using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemPreferredComparisonResolver : IScriptable
	{
		[Ordinal(0)] 
		[RED("cacheadAreaItems")] 
		public CArray<CHandle<ItemPreferredAreaItems>> CacheadAreaItems
		{
			get => GetPropertyValue<CArray<CHandle<ItemPreferredAreaItems>>>();
			set => SetPropertyValue<CArray<CHandle<ItemPreferredAreaItems>>>(value);
		}

		[Ordinal(1)] 
		[RED("cachedComparableTypes")] 
		public CArray<CHandle<ItemComparableTypesCache>> CachedComparableTypes
		{
			get => GetPropertyValue<CArray<CHandle<ItemComparableTypesCache>>>();
			set => SetPropertyValue<CArray<CHandle<ItemComparableTypesCache>>>(value);
		}

		[Ordinal(2)] 
		[RED("typeComparableItemsCache")] 
		public CArray<CHandle<TypeComparableItemsCache>> TypeComparableItemsCache
		{
			get => GetPropertyValue<CArray<CHandle<TypeComparableItemsCache>>>();
			set => SetPropertyValue<CArray<CHandle<TypeComparableItemsCache>>>(value);
		}

		[Ordinal(3)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(4)] 
		[RED("forcedCompareItem")] 
		public gameInventoryItemData ForcedCompareItem
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(5)] 
		[RED("useForceCompare")] 
		public CBool UseForceCompare
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemPreferredComparisonResolver()
		{
			CacheadAreaItems = new();
			CachedComparableTypes = new();
			TypeComparableItemsCache = new();
			ForcedCompareItem = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
