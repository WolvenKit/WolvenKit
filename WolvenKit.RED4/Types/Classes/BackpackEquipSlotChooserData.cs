using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackEquipSlotChooserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("item")] 
		public CWeakHandle<UIInventoryItem> Item
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableSystem>>(value);
		}

		public BackpackEquipSlotChooserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
