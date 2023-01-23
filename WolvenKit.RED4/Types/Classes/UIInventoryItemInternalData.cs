using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemInternalData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("Quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(2)] 
		[RED("ItemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(3)] 
		[RED("Quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("IsQuestItem")] 
		public CBool IsQuestItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("IsRecipeItem")] 
		public CBool IsRecipeItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("IsIconicItem")] 
		public CBool IsIconicItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(10)] 
		[RED("FilterCategory")] 
		public CEnum<ItemFilterCategory> FilterCategory
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(11)] 
		[RED("PrimaryStat")] 
		public CHandle<UIInventoryItemStat> PrimaryStat
		{
			get => GetPropertyValue<CHandle<UIInventoryItemStat>>();
			set => SetPropertyValue<CHandle<UIInventoryItemStat>>(value);
		}

		[Ordinal(12)] 
		[RED("ItemTypeOrder")] 
		public CInt32 ItemTypeOrder
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("Weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("StatsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemStatsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemStatsManager>>(value);
		}

		[Ordinal(15)] 
		[RED("ModsManager")] 
		public CHandle<UIInventoryItemModsManager> ModsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemModsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemModsManager>>(value);
		}

		[Ordinal(16)] 
		[RED("RequirementsManager")] 
		public CHandle<UIInventoryItemRequirementsManager> RequirementsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemRequirementsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemRequirementsManager>>(value);
		}

		[Ordinal(17)] 
		[RED("UIItemCategory")] 
		public CEnum<UIItemCategory> UIItemCategory
		{
			get => GetPropertyValue<CEnum<UIItemCategory>>();
			set => SetPropertyValue<CEnum<UIItemCategory>>(value);
		}

		public UIInventoryItemInternalData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
