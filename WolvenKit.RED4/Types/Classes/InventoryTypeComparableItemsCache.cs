using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTypeComparableItemsCache : IScriptable
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
		public CHandle<InventoryItemComparableTypesCache> Cache
		{
			get => GetPropertyValue<CHandle<InventoryItemComparableTypesCache>>();
			set => SetPropertyValue<CHandle<InventoryItemComparableTypesCache>>(value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<CWeakHandle<UIInventoryItem>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<UIInventoryItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<UIInventoryItem>>>(value);
		}

		public InventoryTypeComparableItemsCache()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
