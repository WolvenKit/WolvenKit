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
			get
			{
				if (_hotkeyItemSlot == null)
				{
					_hotkeyItemSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hotkeyItemSlot", cr2w, this);
				}
				return _hotkeyItemSlot;
			}
			set
			{
				if (_hotkeyItemSlot == value)
				{
					return;
				}
				_hotkeyItemSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("hotkeyItemController")] 
		public CHandle<InventoryItemDisplayController> HotkeyItemController_
		{
			get
			{
				if (_hotkeyItemController == null)
				{
					_hotkeyItemController = (CHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("handle:InventoryItemDisplayController", "hotkeyItemController", cr2w, this);
				}
				return _hotkeyItemController;
			}
			set
			{
				if (_hotkeyItemController == value)
				{
					return;
				}
				_hotkeyItemController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentItem")] 
		public InventoryItemData CurrentItem
		{
			get
			{
				if (_currentItem == null)
				{
					_currentItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "currentItem", cr2w, this);
				}
				return _currentItem;
			}
			set
			{
				if (_currentItem == value)
				{
					return;
				}
				_currentItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("hotkeyBlackboard")] 
		public CHandle<gameIBlackboard> HotkeyBlackboard
		{
			get
			{
				if (_hotkeyBlackboard == null)
				{
					_hotkeyBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "hotkeyBlackboard", cr2w, this);
				}
				return _hotkeyBlackboard;
			}
			set
			{
				if (_hotkeyBlackboard == value)
				{
					return;
				}
				_hotkeyBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("hotkeyCallbackID")] 
		public CUInt32 HotkeyCallbackID
		{
			get
			{
				if (_hotkeyCallbackID == null)
				{
					_hotkeyCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "hotkeyCallbackID", cr2w, this);
				}
				return _hotkeyCallbackID;
			}
			set
			{
				if (_hotkeyCallbackID == value)
				{
					return;
				}
				_hotkeyCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get
			{
				if (_equipmentSystem == null)
				{
					_equipmentSystem = (wCHandle<EquipmentSystem>) CR2WTypeManager.Create("whandle:EquipmentSystem", "equipmentSystem", cr2w, this);
				}
				return _equipmentSystem;
			}
			set
			{
				if (_equipmentSystem == value)
				{
					return;
				}
				_equipmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "inventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		public HotkeyItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
