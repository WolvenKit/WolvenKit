using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyItemController : GenericHotkeyController
	{
		[Ordinal(26)] 
		[RED("hotkeyItemSlot")] 
		public inkWidgetReference HotkeyItemSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("hotkeyItemWidget")] 
		public CWeakHandle<inkWidget> HotkeyItemWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("hotkeyItemController")] 
		public CWeakHandle<InventoryItemDisplayController> HotkeyItemController_
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(29)] 
		[RED("currentItem")] 
		public gameInventoryItemData CurrentItem
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(30)] 
		[RED("hotkeyBlackboard")] 
		public CWeakHandle<gameIBlackboard> HotkeyBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(31)] 
		[RED("hotkeyCallbackID")] 
		public CHandle<redCallbackObject> HotkeyCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("holocallCallback")] 
		public CHandle<redCallbackObject> HolocallCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(34)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(35)] 
		[RED("dpadAnim")] 
		public CHandle<inkanimProxy> DpadAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public HotkeyItemController()
		{
			HotkeyBackground = new inkImageWidgetReference();
			ButtonHint = new inkWidgetReference();
			Restrictions = new();
			DebugCommands = new();
			HotkeyItemSlot = new inkWidgetReference();
			CurrentItem = new gameInventoryItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
