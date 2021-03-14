using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryGenericItemChooser : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _itemContainer;
		private inkWidgetReference _slotsCategory;
		private inkWidgetReference _slotsRootContainer;
		private inkTextWidgetReference _slotsRootLabel;
		private inkCompoundWidgetReference _slotsContainer;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CHandle<InventoryItemDisplayController> _itemDisplay;
		private CInt32 _slotIndex;
		private CHandle<InventoryItemDisplayController> _selectedItem;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(1)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get
			{
				if (_itemContainer == null)
				{
					_itemContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "itemContainer", cr2w, this);
				}
				return _itemContainer;
			}
			set
			{
				if (_itemContainer == value)
				{
					return;
				}
				_itemContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotsCategory")] 
		public inkWidgetReference SlotsCategory
		{
			get
			{
				if (_slotsCategory == null)
				{
					_slotsCategory = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotsCategory", cr2w, this);
				}
				return _slotsCategory;
			}
			set
			{
				if (_slotsCategory == value)
				{
					return;
				}
				_slotsCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotsRootContainer")] 
		public inkWidgetReference SlotsRootContainer
		{
			get
			{
				if (_slotsRootContainer == null)
				{
					_slotsRootContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotsRootContainer", cr2w, this);
				}
				return _slotsRootContainer;
			}
			set
			{
				if (_slotsRootContainer == value)
				{
					return;
				}
				_slotsRootContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slotsRootLabel")] 
		public inkTextWidgetReference SlotsRootLabel
		{
			get
			{
				if (_slotsRootLabel == null)
				{
					_slotsRootLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "slotsRootLabel", cr2w, this);
				}
				return _slotsRootLabel;
			}
			set
			{
				if (_slotsRootLabel == value)
				{
					return;
				}
				_slotsRootLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("slotsContainer")] 
		public inkCompoundWidgetReference SlotsContainer
		{
			get
			{
				if (_slotsContainer == null)
				{
					_slotsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "slotsContainer", cr2w, this);
				}
				return _slotsContainer;
			}
			set
			{
				if (_slotsContainer == value)
				{
					return;
				}
				_slotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get
			{
				if (_inventoryDataManager == null)
				{
					_inventoryDataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "inventoryDataManager", cr2w, this);
				}
				return _inventoryDataManager;
			}
			set
			{
				if (_inventoryDataManager == value)
				{
					return;
				}
				_inventoryDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemDisplay")] 
		public CHandle<InventoryItemDisplayController> ItemDisplay
		{
			get
			{
				if (_itemDisplay == null)
				{
					_itemDisplay = (CHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("handle:InventoryItemDisplayController", "itemDisplay", cr2w, this);
				}
				return _itemDisplay;
			}
			set
			{
				if (_itemDisplay == value)
				{
					return;
				}
				_itemDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("selectedItem")] 
		public CHandle<InventoryItemDisplayController> SelectedItem
		{
			get
			{
				if (_selectedItem == null)
				{
					_selectedItem = (CHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("handle:InventoryItemDisplayController", "selectedItem", cr2w, this);
				}
				return _selectedItem;
			}
			set
			{
				if (_selectedItem == value)
				{
					return;
				}
				_selectedItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		public InventoryGenericItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
