using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TypeComparableItemsCache : IScriptable
	{
		private CEnum<gamedataItemType> _itemType;
		private CHandle<ItemComparableTypesCache> _cache;
		private CArray<InventoryItemData> _items;

		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cache")] 
		public CHandle<ItemComparableTypesCache> Cache
		{
			get
			{
				if (_cache == null)
				{
					_cache = (CHandle<ItemComparableTypesCache>) CR2WTypeManager.Create("handle:ItemComparableTypesCache", "cache", cr2w, this);
				}
				return _cache;
			}
			set
			{
				if (_cache == value)
				{
					return;
				}
				_cache = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<InventoryItemData> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public TypeComparableItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
