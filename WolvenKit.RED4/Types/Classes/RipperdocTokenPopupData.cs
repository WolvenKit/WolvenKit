using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTokenPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("costData")] 
		public CyberwareUpgradeCostData CostData
		{
			get => GetPropertyValue<CyberwareUpgradeCostData>();
			set => SetPropertyValue<CyberwareUpgradeCostData>(value);
		}

		[Ordinal(8)] 
		[RED("baseItemData")] 
		public CHandle<UIInventoryItem> BaseItemData
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(9)] 
		[RED("option1InventoryItem")] 
		public CHandle<UIInventoryItem> Option1InventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(10)] 
		[RED("option2InventoryItem")] 
		public CHandle<UIInventoryItem> Option2InventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(11)] 
		[RED("option3InventoryItem")] 
		public CHandle<UIInventoryItem> Option3InventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(12)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>(value);
		}

		[Ordinal(13)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(14)] 
		[RED("option1GameItemData")] 
		public CHandle<gameItemData> Option1GameItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(15)] 
		[RED("option2GameItemData")] 
		public CHandle<gameItemData> Option2GameItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(16)] 
		[RED("option3GameItemData")] 
		public CHandle<gameItemData> Option3GameItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		public RipperdocTokenPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
