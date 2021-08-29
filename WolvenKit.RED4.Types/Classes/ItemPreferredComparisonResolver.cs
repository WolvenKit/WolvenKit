using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemPreferredComparisonResolver : IScriptable
	{
		private CArray<CHandle<ItemPreferredAreaItems>> _cacheadAreaItems;
		private CArray<CHandle<ItemComparableTypesCache>> _cachedComparableTypes;
		private CArray<CHandle<TypeComparableItemsCache>> _typeComparableItemsCache;
		private CHandle<InventoryDataManagerV2> _dataManager;
		private InventoryItemData _forcedCompareItem;
		private CBool _useForceCompare;

		[Ordinal(0)] 
		[RED("cacheadAreaItems")] 
		public CArray<CHandle<ItemPreferredAreaItems>> CacheadAreaItems
		{
			get => GetProperty(ref _cacheadAreaItems);
			set => SetProperty(ref _cacheadAreaItems, value);
		}

		[Ordinal(1)] 
		[RED("cachedComparableTypes")] 
		public CArray<CHandle<ItemComparableTypesCache>> CachedComparableTypes
		{
			get => GetProperty(ref _cachedComparableTypes);
			set => SetProperty(ref _cachedComparableTypes, value);
		}

		[Ordinal(2)] 
		[RED("typeComparableItemsCache")] 
		public CArray<CHandle<TypeComparableItemsCache>> TypeComparableItemsCache
		{
			get => GetProperty(ref _typeComparableItemsCache);
			set => SetProperty(ref _typeComparableItemsCache, value);
		}

		[Ordinal(3)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(4)] 
		[RED("forcedCompareItem")] 
		public InventoryItemData ForcedCompareItem
		{
			get => GetProperty(ref _forcedCompareItem);
			set => SetProperty(ref _forcedCompareItem, value);
		}

		[Ordinal(5)] 
		[RED("useForceCompare")] 
		public CBool UseForceCompare
		{
			get => GetProperty(ref _useForceCompare);
			set => SetProperty(ref _useForceCompare, value);
		}
	}
}
