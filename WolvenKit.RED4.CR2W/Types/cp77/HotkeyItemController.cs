using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyItemController : GenericHotkeyController
	{
		private inkWidgetReference _hotkeyItemSlot;
		private CHandle<InventoryItemDisplayController> _hotkeyItemController;
		private InventoryItemData _currentItem;
		private CHandle<gameIBlackboard> _hotkeyBlackboard;
		private CUInt32 _hotkeyCallbackID;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(19)] 
		[RED("hotkeyItemSlot")] 
		public inkWidgetReference HotkeyItemSlot
		{
			get => GetProperty(ref _hotkeyItemSlot);
			set => SetProperty(ref _hotkeyItemSlot, value);
		}

		[Ordinal(20)] 
		[RED("hotkeyItemController")] 
		public CHandle<InventoryItemDisplayController> HotkeyItemController_
		{
			get => GetProperty(ref _hotkeyItemController);
			set => SetProperty(ref _hotkeyItemController, value);
		}

		[Ordinal(21)] 
		[RED("currentItem")] 
		public InventoryItemData CurrentItem
		{
			get => GetProperty(ref _currentItem);
			set => SetProperty(ref _currentItem, value);
		}

		[Ordinal(22)] 
		[RED("hotkeyBlackboard")] 
		public CHandle<gameIBlackboard> HotkeyBlackboard
		{
			get => GetProperty(ref _hotkeyBlackboard);
			set => SetProperty(ref _hotkeyBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("hotkeyCallbackID")] 
		public CUInt32 HotkeyCallbackID
		{
			get => GetProperty(ref _hotkeyCallbackID);
			set => SetProperty(ref _hotkeyCallbackID, value);
		}

		[Ordinal(24)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(25)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		public HotkeyItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
