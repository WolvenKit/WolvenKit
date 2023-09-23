using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemStatsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("Stats")] 
		public CArray<CHandle<UIInventoryItemStat>> Stats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>(value);
		}

		[Ordinal(1)] 
		[RED("TooltipStats")] 
		public CArray<CHandle<UIInventoryItemStat>> TooltipStats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>(value);
		}

		[Ordinal(2)] 
		[RED("AdditionalStats")] 
		public CArray<CHandle<UIInventoryItemStat>> AdditionalStats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>(value);
		}

		[Ordinal(3)] 
		[RED("AttributeAllocationStats")] 
		public CArray<CHandle<UIInventoryItemStat>> AttributeAllocationStats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>(value);
		}

		[Ordinal(4)] 
		[RED("item")] 
		public CWeakHandle<UIInventoryItem> Item
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(5)] 
		[RED("gameItemData")] 
		public CWeakHandle<gameItemData> GameItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(6)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(7)] 
		[RED("manager")] 
		public CWeakHandle<UIInventoryItemsManager> Manager
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		[Ordinal(8)] 
		[RED("statMap")] 
		public CWeakHandle<gamedataUIStatsMap_Record> StatMap
		{
			get => GetPropertyValue<CWeakHandle<gamedataUIStatsMap_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataUIStatsMap_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("statsFetched")] 
		public CBool StatsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("tooltipStatsFetched")] 
		public CBool TooltipStatsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("weaponBars")] 
		public CHandle<UIInventoryItemWeaponBars> WeaponBars
		{
			get => GetPropertyValue<CHandle<UIInventoryItemWeaponBars>>();
			set => SetPropertyValue<CHandle<UIInventoryItemWeaponBars>>(value);
		}

		[Ordinal(12)] 
		[RED("weaponBarsFetched")] 
		public CBool WeaponBarsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useBareStats")] 
		public CBool UseBareStats
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryItemStatsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
