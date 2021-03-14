using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemPreferredComparisonResolver : IScriptable
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
			get
			{
				if (_cacheadAreaItems == null)
				{
					_cacheadAreaItems = (CArray<CHandle<ItemPreferredAreaItems>>) CR2WTypeManager.Create("array:handle:ItemPreferredAreaItems", "cacheadAreaItems", cr2w, this);
				}
				return _cacheadAreaItems;
			}
			set
			{
				if (_cacheadAreaItems == value)
				{
					return;
				}
				_cacheadAreaItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cachedComparableTypes")] 
		public CArray<CHandle<ItemComparableTypesCache>> CachedComparableTypes
		{
			get
			{
				if (_cachedComparableTypes == null)
				{
					_cachedComparableTypes = (CArray<CHandle<ItemComparableTypesCache>>) CR2WTypeManager.Create("array:handle:ItemComparableTypesCache", "cachedComparableTypes", cr2w, this);
				}
				return _cachedComparableTypes;
			}
			set
			{
				if (_cachedComparableTypes == value)
				{
					return;
				}
				_cachedComparableTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("typeComparableItemsCache")] 
		public CArray<CHandle<TypeComparableItemsCache>> TypeComparableItemsCache
		{
			get
			{
				if (_typeComparableItemsCache == null)
				{
					_typeComparableItemsCache = (CArray<CHandle<TypeComparableItemsCache>>) CR2WTypeManager.Create("array:handle:TypeComparableItemsCache", "typeComparableItemsCache", cr2w, this);
				}
				return _typeComparableItemsCache;
			}
			set
			{
				if (_typeComparableItemsCache == value)
				{
					return;
				}
				_typeComparableItemsCache = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forcedCompareItem")] 
		public InventoryItemData ForcedCompareItem
		{
			get
			{
				if (_forcedCompareItem == null)
				{
					_forcedCompareItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "forcedCompareItem", cr2w, this);
				}
				return _forcedCompareItem;
			}
			set
			{
				if (_forcedCompareItem == value)
				{
					return;
				}
				_forcedCompareItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useForceCompare")] 
		public CBool UseForceCompare
		{
			get
			{
				if (_useForceCompare == null)
				{
					_useForceCompare = (CBool) CR2WTypeManager.Create("Bool", "useForceCompare", cr2w, this);
				}
				return _useForceCompare;
			}
			set
			{
				if (_useForceCompare == value)
				{
					return;
				}
				_useForceCompare = value;
				PropertySet(this);
			}
		}

		public ItemPreferredComparisonResolver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
