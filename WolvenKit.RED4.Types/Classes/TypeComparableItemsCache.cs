using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TypeComparableItemsCache : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(1)] 
		[RED("cache")] 
		public CHandle<ItemComparableTypesCache> Cache
		{
			get => GetPropertyValue<CHandle<ItemComparableTypesCache>>();
			set => SetPropertyValue<CHandle<ItemComparableTypesCache>>(value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<InventoryItemData> Items
		{
			get => GetPropertyValue<CArray<InventoryItemData>>();
			set => SetPropertyValue<CArray<InventoryItemData>>(value);
		}

		public TypeComparableItemsCache()
		{
			Items = new();
		}
	}
}
