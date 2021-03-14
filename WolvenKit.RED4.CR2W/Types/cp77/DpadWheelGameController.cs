using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _haskMarkContainer;
		private inkCompoundWidgetReference _itemContainer;
		private inkWidgetReference _selectorWrapper;
		private inkWidgetReference _centerIcon;
		private inkWidgetReference _centerGlow;
		private inkTextWidgetReference _itemLabel;
		private inkTextWidgetReference _itemDesc;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkImageWidgetReference _indicator02;
		private inkImageWidgetReference _indicator03;
		private inkImageWidgetReference _indicator04;
		private inkImageWidgetReference _indicator05;
		private inkImageWidgetReference _indicator06;
		private inkImageWidgetReference _indicator07;
		private inkImageWidgetReference _indicator08;
		private CFloat _itemDistance;
		private CFloat _hashMarkDistance;
		private CFloat _minDistance;
		private CHandle<inkWidget> _root;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CArray<CHandle<DpadWheelItemController>> _dpadItemsList;
		private CArray<QuickSlotCommand> _commandsList;
		private wCHandle<DpadWheelItemController> _selectedWheelItem;
		private wCHandle<ButtonHints> _buttonHintsController;
		private inkWidgetReference _selectedIndicator;
		private CFloat _angleInterval;
		private CFloat _previousAmount;
		private CFloat _previousAngle;
		private QuickWheelStartUIStructure _data;
		private CArray<AbilityData> _masterListOfAllCyberware;
		private CArray<AbilityData> _listOfUnassignedCyberware;
		private CBool _dpadWheelOpen;
		private gameDelayID _neutralChoiceDelayId;
		private QuickSlotCommand _previouslySelectedData;
		private CHandle<gameIBlackboard> _uiQuickItemsBlackboard;
		private CHandle<UI_QuickSlotsDataDef> _uiQuickSlotDef;
		private CUInt32 _dPadWheelAngleBBID;
		private CUInt32 _dPadWheelInterationStartedBBID;
		private CUInt32 _dPadWheelInterationEndedBBID;
		private CUInt32 _dpadWheelCyberwareAssignedBBID;

		[Ordinal(3)] 
		[RED("haskMarkContainer")] 
		public inkCompoundWidgetReference HaskMarkContainer
		{
			get
			{
				if (_haskMarkContainer == null)
				{
					_haskMarkContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "haskMarkContainer", cr2w, this);
				}
				return _haskMarkContainer;
			}
			set
			{
				if (_haskMarkContainer == value)
				{
					return;
				}
				_haskMarkContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get
			{
				if (_selectorWrapper == null)
				{
					_selectorWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorWrapper", cr2w, this);
				}
				return _selectorWrapper;
			}
			set
			{
				if (_selectorWrapper == value)
				{
					return;
				}
				_selectorWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("centerIcon")] 
		public inkWidgetReference CenterIcon
		{
			get
			{
				if (_centerIcon == null)
				{
					_centerIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "centerIcon", cr2w, this);
				}
				return _centerIcon;
			}
			set
			{
				if (_centerIcon == value)
				{
					return;
				}
				_centerIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("centerGlow")] 
		public inkWidgetReference CenterGlow
		{
			get
			{
				if (_centerGlow == null)
				{
					_centerGlow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "centerGlow", cr2w, this);
				}
				return _centerGlow;
			}
			set
			{
				if (_centerGlow == value)
				{
					return;
				}
				_centerGlow = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemLabel")] 
		public inkTextWidgetReference ItemLabel
		{
			get
			{
				if (_itemLabel == null)
				{
					_itemLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemLabel", cr2w, this);
				}
				return _itemLabel;
			}
			set
			{
				if (_itemLabel == value)
				{
					return;
				}
				_itemLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemDesc")] 
		public inkTextWidgetReference ItemDesc
		{
			get
			{
				if (_itemDesc == null)
				{
					_itemDesc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemDesc", cr2w, this);
				}
				return _itemDesc;
			}
			set
			{
				if (_itemDesc == value)
				{
					return;
				}
				_itemDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("indicator02")] 
		public inkImageWidgetReference Indicator02
		{
			get
			{
				if (_indicator02 == null)
				{
					_indicator02 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator02", cr2w, this);
				}
				return _indicator02;
			}
			set
			{
				if (_indicator02 == value)
				{
					return;
				}
				_indicator02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("indicator03")] 
		public inkImageWidgetReference Indicator03
		{
			get
			{
				if (_indicator03 == null)
				{
					_indicator03 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator03", cr2w, this);
				}
				return _indicator03;
			}
			set
			{
				if (_indicator03 == value)
				{
					return;
				}
				_indicator03 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("indicator04")] 
		public inkImageWidgetReference Indicator04
		{
			get
			{
				if (_indicator04 == null)
				{
					_indicator04 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator04", cr2w, this);
				}
				return _indicator04;
			}
			set
			{
				if (_indicator04 == value)
				{
					return;
				}
				_indicator04 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("indicator05")] 
		public inkImageWidgetReference Indicator05
		{
			get
			{
				if (_indicator05 == null)
				{
					_indicator05 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator05", cr2w, this);
				}
				return _indicator05;
			}
			set
			{
				if (_indicator05 == value)
				{
					return;
				}
				_indicator05 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("indicator06")] 
		public inkImageWidgetReference Indicator06
		{
			get
			{
				if (_indicator06 == null)
				{
					_indicator06 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator06", cr2w, this);
				}
				return _indicator06;
			}
			set
			{
				if (_indicator06 == value)
				{
					return;
				}
				_indicator06 = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("indicator07")] 
		public inkImageWidgetReference Indicator07
		{
			get
			{
				if (_indicator07 == null)
				{
					_indicator07 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator07", cr2w, this);
				}
				return _indicator07;
			}
			set
			{
				if (_indicator07 == value)
				{
					return;
				}
				_indicator07 = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("indicator08")] 
		public inkImageWidgetReference Indicator08
		{
			get
			{
				if (_indicator08 == null)
				{
					_indicator08 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator08", cr2w, this);
				}
				return _indicator08;
			}
			set
			{
				if (_indicator08 == value)
				{
					return;
				}
				_indicator08 = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("itemDistance")] 
		public CFloat ItemDistance
		{
			get
			{
				if (_itemDistance == null)
				{
					_itemDistance = (CFloat) CR2WTypeManager.Create("Float", "itemDistance", cr2w, this);
				}
				return _itemDistance;
			}
			set
			{
				if (_itemDistance == value)
				{
					return;
				}
				_itemDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("hashMarkDistance")] 
		public CFloat HashMarkDistance
		{
			get
			{
				if (_hashMarkDistance == null)
				{
					_hashMarkDistance = (CFloat) CR2WTypeManager.Create("Float", "hashMarkDistance", cr2w, this);
				}
				return _hashMarkDistance;
			}
			set
			{
				if (_hashMarkDistance == value)
				{
					return;
				}
				_hashMarkDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "minDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
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

		[Ordinal(23)] 
		[RED("QuickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get
			{
				if (_quickSlotsManager == null)
				{
					_quickSlotsManager = (wCHandle<QuickSlotsManager>) CR2WTypeManager.Create("whandle:QuickSlotsManager", "QuickSlotsManager", cr2w, this);
				}
				return _quickSlotsManager;
			}
			set
			{
				if (_quickSlotsManager == value)
				{
					return;
				}
				_quickSlotsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get
			{
				if (_inventoryDataManager == null)
				{
					_inventoryDataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryDataManager", cr2w, this);
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

		[Ordinal(25)] 
		[RED("dpadItemsList")] 
		public CArray<CHandle<DpadWheelItemController>> DpadItemsList
		{
			get
			{
				if (_dpadItemsList == null)
				{
					_dpadItemsList = (CArray<CHandle<DpadWheelItemController>>) CR2WTypeManager.Create("array:handle:DpadWheelItemController", "dpadItemsList", cr2w, this);
				}
				return _dpadItemsList;
			}
			set
			{
				if (_dpadItemsList == value)
				{
					return;
				}
				_dpadItemsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("commandsList")] 
		public CArray<QuickSlotCommand> CommandsList
		{
			get
			{
				if (_commandsList == null)
				{
					_commandsList = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "commandsList", cr2w, this);
				}
				return _commandsList;
			}
			set
			{
				if (_commandsList == value)
				{
					return;
				}
				_commandsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("selectedWheelItem")] 
		public wCHandle<DpadWheelItemController> SelectedWheelItem
		{
			get
			{
				if (_selectedWheelItem == null)
				{
					_selectedWheelItem = (wCHandle<DpadWheelItemController>) CR2WTypeManager.Create("whandle:DpadWheelItemController", "selectedWheelItem", cr2w, this);
				}
				return _selectedWheelItem;
			}
			set
			{
				if (_selectedWheelItem == value)
				{
					return;
				}
				_selectedWheelItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("selectedIndicator")] 
		public inkWidgetReference SelectedIndicator
		{
			get
			{
				if (_selectedIndicator == null)
				{
					_selectedIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectedIndicator", cr2w, this);
				}
				return _selectedIndicator;
			}
			set
			{
				if (_selectedIndicator == value)
				{
					return;
				}
				_selectedIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("angleInterval")] 
		public CFloat AngleInterval
		{
			get
			{
				if (_angleInterval == null)
				{
					_angleInterval = (CFloat) CR2WTypeManager.Create("Float", "angleInterval", cr2w, this);
				}
				return _angleInterval;
			}
			set
			{
				if (_angleInterval == value)
				{
					return;
				}
				_angleInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("previousAmount")] 
		public CFloat PreviousAmount
		{
			get
			{
				if (_previousAmount == null)
				{
					_previousAmount = (CFloat) CR2WTypeManager.Create("Float", "previousAmount", cr2w, this);
				}
				return _previousAmount;
			}
			set
			{
				if (_previousAmount == value)
				{
					return;
				}
				_previousAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("previousAngle")] 
		public CFloat PreviousAngle
		{
			get
			{
				if (_previousAngle == null)
				{
					_previousAngle = (CFloat) CR2WTypeManager.Create("Float", "previousAngle", cr2w, this);
				}
				return _previousAngle;
			}
			set
			{
				if (_previousAngle == value)
				{
					return;
				}
				_previousAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("data")] 
		public QuickWheelStartUIStructure Data
		{
			get
			{
				if (_data == null)
				{
					_data = (QuickWheelStartUIStructure) CR2WTypeManager.Create("QuickWheelStartUIStructure", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("masterListOfAllCyberware")] 
		public CArray<AbilityData> MasterListOfAllCyberware
		{
			get
			{
				if (_masterListOfAllCyberware == null)
				{
					_masterListOfAllCyberware = (CArray<AbilityData>) CR2WTypeManager.Create("array:AbilityData", "masterListOfAllCyberware", cr2w, this);
				}
				return _masterListOfAllCyberware;
			}
			set
			{
				if (_masterListOfAllCyberware == value)
				{
					return;
				}
				_masterListOfAllCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("listOfUnassignedCyberware")] 
		public CArray<AbilityData> ListOfUnassignedCyberware
		{
			get
			{
				if (_listOfUnassignedCyberware == null)
				{
					_listOfUnassignedCyberware = (CArray<AbilityData>) CR2WTypeManager.Create("array:AbilityData", "listOfUnassignedCyberware", cr2w, this);
				}
				return _listOfUnassignedCyberware;
			}
			set
			{
				if (_listOfUnassignedCyberware == value)
				{
					return;
				}
				_listOfUnassignedCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("dpadWheelOpen")] 
		public CBool DpadWheelOpen
		{
			get
			{
				if (_dpadWheelOpen == null)
				{
					_dpadWheelOpen = (CBool) CR2WTypeManager.Create("Bool", "dpadWheelOpen", cr2w, this);
				}
				return _dpadWheelOpen;
			}
			set
			{
				if (_dpadWheelOpen == value)
				{
					return;
				}
				_dpadWheelOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("neutralChoiceDelayId")] 
		public gameDelayID NeutralChoiceDelayId
		{
			get
			{
				if (_neutralChoiceDelayId == null)
				{
					_neutralChoiceDelayId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "neutralChoiceDelayId", cr2w, this);
				}
				return _neutralChoiceDelayId;
			}
			set
			{
				if (_neutralChoiceDelayId == value)
				{
					return;
				}
				_neutralChoiceDelayId = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("previouslySelectedData")] 
		public QuickSlotCommand PreviouslySelectedData
		{
			get
			{
				if (_previouslySelectedData == null)
				{
					_previouslySelectedData = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "previouslySelectedData", cr2w, this);
				}
				return _previouslySelectedData;
			}
			set
			{
				if (_previouslySelectedData == value)
				{
					return;
				}
				_previouslySelectedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("UiQuickItemsBlackboard")] 
		public CHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get
			{
				if (_uiQuickItemsBlackboard == null)
				{
					_uiQuickItemsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "UiQuickItemsBlackboard", cr2w, this);
				}
				return _uiQuickItemsBlackboard;
			}
			set
			{
				if (_uiQuickItemsBlackboard == value)
				{
					return;
				}
				_uiQuickItemsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("UiQuickSlotDef")] 
		public CHandle<UI_QuickSlotsDataDef> UiQuickSlotDef
		{
			get
			{
				if (_uiQuickSlotDef == null)
				{
					_uiQuickSlotDef = (CHandle<UI_QuickSlotsDataDef>) CR2WTypeManager.Create("handle:UI_QuickSlotsDataDef", "UiQuickSlotDef", cr2w, this);
				}
				return _uiQuickSlotDef;
			}
			set
			{
				if (_uiQuickSlotDef == value)
				{
					return;
				}
				_uiQuickSlotDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("DPadWheelAngleBBID")] 
		public CUInt32 DPadWheelAngleBBID
		{
			get
			{
				if (_dPadWheelAngleBBID == null)
				{
					_dPadWheelAngleBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DPadWheelAngleBBID", cr2w, this);
				}
				return _dPadWheelAngleBBID;
			}
			set
			{
				if (_dPadWheelAngleBBID == value)
				{
					return;
				}
				_dPadWheelAngleBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("DPadWheelInterationStartedBBID")] 
		public CUInt32 DPadWheelInterationStartedBBID
		{
			get
			{
				if (_dPadWheelInterationStartedBBID == null)
				{
					_dPadWheelInterationStartedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DPadWheelInterationStartedBBID", cr2w, this);
				}
				return _dPadWheelInterationStartedBBID;
			}
			set
			{
				if (_dPadWheelInterationStartedBBID == value)
				{
					return;
				}
				_dPadWheelInterationStartedBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("DPadWheelInterationEndedBBID")] 
		public CUInt32 DPadWheelInterationEndedBBID
		{
			get
			{
				if (_dPadWheelInterationEndedBBID == null)
				{
					_dPadWheelInterationEndedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DPadWheelInterationEndedBBID", cr2w, this);
				}
				return _dPadWheelInterationEndedBBID;
			}
			set
			{
				if (_dPadWheelInterationEndedBBID == value)
				{
					return;
				}
				_dPadWheelInterationEndedBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("DpadWheelCyberwareAssignedBBID")] 
		public CUInt32 DpadWheelCyberwareAssignedBBID
		{
			get
			{
				if (_dpadWheelCyberwareAssignedBBID == null)
				{
					_dpadWheelCyberwareAssignedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DpadWheelCyberwareAssignedBBID", cr2w, this);
				}
				return _dpadWheelCyberwareAssignedBBID;
			}
			set
			{
				if (_dpadWheelCyberwareAssignedBBID == value)
				{
					return;
				}
				_dpadWheelCyberwareAssignedBBID = value;
				PropertySet(this);
			}
		}

		public DpadWheelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
