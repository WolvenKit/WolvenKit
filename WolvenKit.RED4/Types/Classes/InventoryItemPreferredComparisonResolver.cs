using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemPreferredComparisonResolver : IScriptable
	{
		[Ordinal(0)] 
		[RED("cacheadAreaItems")] 
		public CArray<CHandle<InventoryItemPreferredAreaItems>> CacheadAreaItems
		{
			get => GetPropertyValue<CArray<CHandle<InventoryItemPreferredAreaItems>>>();
			set => SetPropertyValue<CArray<CHandle<InventoryItemPreferredAreaItems>>>(value);
		}

		[Ordinal(1)] 
		[RED("cachedComparableTypes")] 
		public CArray<CHandle<InventoryItemComparableTypesCache>> CachedComparableTypes
		{
			get => GetPropertyValue<CArray<CHandle<InventoryItemComparableTypesCache>>>();
			set => SetPropertyValue<CArray<CHandle<InventoryItemComparableTypesCache>>>(value);
		}

		[Ordinal(2)] 
		[RED("typeComparableItemsCache")] 
		public CArray<CHandle<InventoryTypeComparableItemsCache>> TypeComparableItemsCache
		{
			get => GetPropertyValue<CArray<CHandle<InventoryTypeComparableItemsCache>>>();
			set => SetPropertyValue<CArray<CHandle<InventoryTypeComparableItemsCache>>>(value);
		}

		[Ordinal(3)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("forcedCompareItem")] 
		public CWeakHandle<UIInventoryItem> ForcedCompareItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(5)] 
		[RED("useForceCompare")] 
		public CBool UseForceCompare
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryItemPreferredComparisonResolver()
		{
			CacheadAreaItems = new();
			CachedComparableTypes = new();
			TypeComparableItemsCache = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
