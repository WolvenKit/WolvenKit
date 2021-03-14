using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInventoryGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _itemModeControllerRef;
		private inkWidgetReference _defaultWrapper;
		private inkWidgetReference _itemWrapper;
		private inkCompoundWidgetReference _cyberwareSlotRootRefs;
		private inkWidgetReference _paperDollWidget;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _notificationRoot;
		private inkWidgetReference _playerStatsWidget;
		private inkWidgetReference _btnBackpack;
		private inkWidgetReference _btnCyberware;
		private inkWidgetReference _btnStats;
		private inkWidgetReference _cyberdeckLinkContainer;
		private inkWidgetReference _cyberdeckLinkItem;
		private inkWidgetReference _itemNotificationRoot;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerPuppet> _player;
		private CEnum<InventoryModes> _mode;
		private CEnum<ItemViewModes> _itemViewMode;
		private wCHandle<InventoryItemModeLogicController> _itemModeLogicController;
		private wCHandle<InventoryItemDisplayController> _selectedEquipmentSlot;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimDefinition> _animDef;
		private CArray<wCHandle<InventoryItemDisplay>> _inventoryList;
		private CArray<wCHandle<InventoryItemDisplayController>> _weaponsList;
		private CArray<wCHandle<InventoryItemDisplayController>> _equipmentList;
		private CArray<wCHandle<InventoryItemDisplayController>> _cyberwareList;
		private CArray<wCHandle<InventoryItemDisplayController>> _pocketList;
		private CArray<wCHandle<InventoryItemDisplayController>> _consumablesList;
		private CArray<wCHandle<InventoryItemDisplayController>> _animationList;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _cyberwareAreas;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _pocketAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _consumablesAreas;
		private CHandle<UI_EquipmentDef> _uIBBEquipment;
		private CHandle<UI_ItemModSystemDef> _uIBBItemMod;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private wCHandle<gameIBlackboard> _uIBBEquipmentBlackboard;
		private wCHandle<gameIBlackboard> _uIBBItemModBlackbord;
		private wCHandle<gameIBlackboard> _disassembleBlackboard;
		private CUInt32 _inventoryBBID;
		private CUInt32 _equipmentBBID;
		private CUInt32 _subEquipmentBBID;
		private CUInt32 _itemModBBID;
		private CUInt32 _disassembleBBID;
		private CBool _openItemMode;
		private CBool _isE3Demo;
		private CHandle<InventoryStatsListener> _inventoryStatsListener;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CArray<CHandle<EquipmentAreaCategoryCreated>> _equipmentAreaCategoryEventQueue;
		private CArray<CHandle<EquipmentAreaCategory>> _equipmentAreaCategories;
		private wCHandle<gameTelemetryTelemetrySystem> _telemetrySystem;

		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("itemModeControllerRef")] 
		public inkWidgetReference ItemModeControllerRef
		{
			get
			{
				if (_itemModeControllerRef == null)
				{
					_itemModeControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemModeControllerRef", cr2w, this);
				}
				return _itemModeControllerRef;
			}
			set
			{
				if (_itemModeControllerRef == value)
				{
					return;
				}
				_itemModeControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("defaultWrapper")] 
		public inkWidgetReference DefaultWrapper
		{
			get
			{
				if (_defaultWrapper == null)
				{
					_defaultWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultWrapper", cr2w, this);
				}
				return _defaultWrapper;
			}
			set
			{
				if (_defaultWrapper == value)
				{
					return;
				}
				_defaultWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get
			{
				if (_itemWrapper == null)
				{
					_itemWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemWrapper", cr2w, this);
				}
				return _itemWrapper;
			}
			set
			{
				if (_itemWrapper == value)
				{
					return;
				}
				_itemWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("CyberwareSlotRootRefs")] 
		public inkCompoundWidgetReference CyberwareSlotRootRefs
		{
			get
			{
				if (_cyberwareSlotRootRefs == null)
				{
					_cyberwareSlotRootRefs = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CyberwareSlotRootRefs", cr2w, this);
				}
				return _cyberwareSlotRootRefs;
			}
			set
			{
				if (_cyberwareSlotRootRefs == value)
				{
					return;
				}
				_cyberwareSlotRootRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("paperDollWidget")] 
		public inkWidgetReference PaperDollWidget
		{
			get
			{
				if (_paperDollWidget == null)
				{
					_paperDollWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "paperDollWidget", cr2w, this);
				}
				return _paperDollWidget;
			}
			set
			{
				if (_paperDollWidget == value)
				{
					return;
				}
				_paperDollWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get
			{
				if (_sortingButton == null)
				{
					_sortingButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingButton", cr2w, this);
				}
				return _sortingButton;
			}
			set
			{
				if (_sortingButton == value)
				{
					return;
				}
				_sortingButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get
			{
				if (_sortingDropdown == null)
				{
					_sortingDropdown = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingDropdown", cr2w, this);
				}
				return _sortingDropdown;
			}
			set
			{
				if (_sortingDropdown == value)
				{
					return;
				}
				_sortingDropdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get
			{
				if (_notificationRoot == null)
				{
					_notificationRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "notificationRoot", cr2w, this);
				}
				return _notificationRoot;
			}
			set
			{
				if (_notificationRoot == value)
				{
					return;
				}
				_notificationRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerStatsWidget")] 
		public inkWidgetReference PlayerStatsWidget
		{
			get
			{
				if (_playerStatsWidget == null)
				{
					_playerStatsWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerStatsWidget", cr2w, this);
				}
				return _playerStatsWidget;
			}
			set
			{
				if (_playerStatsWidget == value)
				{
					return;
				}
				_playerStatsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get
			{
				if (_btnBackpack == null)
				{
					_btnBackpack = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnBackpack", cr2w, this);
				}
				return _btnBackpack;
			}
			set
			{
				if (_btnBackpack == value)
				{
					return;
				}
				_btnBackpack = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get
			{
				if (_btnCyberware == null)
				{
					_btnCyberware = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnCyberware", cr2w, this);
				}
				return _btnCyberware;
			}
			set
			{
				if (_btnCyberware == value)
				{
					return;
				}
				_btnCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get
			{
				if (_btnStats == null)
				{
					_btnStats = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnStats", cr2w, this);
				}
				return _btnStats;
			}
			set
			{
				if (_btnStats == value)
				{
					return;
				}
				_btnStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("cyberdeckLinkContainer")] 
		public inkWidgetReference CyberdeckLinkContainer
		{
			get
			{
				if (_cyberdeckLinkContainer == null)
				{
					_cyberdeckLinkContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cyberdeckLinkContainer", cr2w, this);
				}
				return _cyberdeckLinkContainer;
			}
			set
			{
				if (_cyberdeckLinkContainer == value)
				{
					return;
				}
				_cyberdeckLinkContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("cyberdeckLinkItem")] 
		public inkWidgetReference CyberdeckLinkItem
		{
			get
			{
				if (_cyberdeckLinkItem == null)
				{
					_cyberdeckLinkItem = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cyberdeckLinkItem", cr2w, this);
				}
				return _cyberdeckLinkItem;
			}
			set
			{
				if (_cyberdeckLinkItem == value)
				{
					return;
				}
				_cyberdeckLinkItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get
			{
				if (_itemNotificationRoot == null)
				{
					_itemNotificationRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemNotificationRoot", cr2w, this);
				}
				return _itemNotificationRoot;
			}
			set
			{
				if (_itemNotificationRoot == value)
				{
					return;
				}
				_itemNotificationRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
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

		[Ordinal(21)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<InventoryModes> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<InventoryModes>) CR2WTypeManager.Create("InventoryModes", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("itemViewMode")] 
		public CEnum<ItemViewModes> ItemViewMode
		{
			get
			{
				if (_itemViewMode == null)
				{
					_itemViewMode = (CEnum<ItemViewModes>) CR2WTypeManager.Create("ItemViewModes", "itemViewMode", cr2w, this);
				}
				return _itemViewMode;
			}
			set
			{
				if (_itemViewMode == value)
				{
					return;
				}
				_itemViewMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("itemModeLogicController")] 
		public wCHandle<InventoryItemModeLogicController> ItemModeLogicController
		{
			get
			{
				if (_itemModeLogicController == null)
				{
					_itemModeLogicController = (wCHandle<InventoryItemModeLogicController>) CR2WTypeManager.Create("whandle:InventoryItemModeLogicController", "itemModeLogicController", cr2w, this);
				}
				return _itemModeLogicController;
			}
			set
			{
				if (_itemModeLogicController == value)
				{
					return;
				}
				_itemModeLogicController = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("selectedEquipmentSlot")] 
		public wCHandle<InventoryItemDisplayController> SelectedEquipmentSlot
		{
			get
			{
				if (_selectedEquipmentSlot == null)
				{
					_selectedEquipmentSlot = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "selectedEquipmentSlot", cr2w, this);
				}
				return _selectedEquipmentSlot;
			}
			set
			{
				if (_selectedEquipmentSlot == value)
				{
					return;
				}
				_selectedEquipmentSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animDef")] 
		public CHandle<inkanimDefinition> AnimDef
		{
			get
			{
				if (_animDef == null)
				{
					_animDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animDef", cr2w, this);
				}
				return _animDef;
			}
			set
			{
				if (_animDef == value)
				{
					return;
				}
				_animDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("InventoryList")] 
		public CArray<wCHandle<InventoryItemDisplay>> InventoryList
		{
			get
			{
				if (_inventoryList == null)
				{
					_inventoryList = (CArray<wCHandle<InventoryItemDisplay>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplay", "InventoryList", cr2w, this);
				}
				return _inventoryList;
			}
			set
			{
				if (_inventoryList == value)
				{
					return;
				}
				_inventoryList = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("WeaponsList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> WeaponsList
		{
			get
			{
				if (_weaponsList == null)
				{
					_weaponsList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "WeaponsList", cr2w, this);
				}
				return _weaponsList;
			}
			set
			{
				if (_weaponsList == value)
				{
					return;
				}
				_weaponsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("EquipmentList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> EquipmentList
		{
			get
			{
				if (_equipmentList == null)
				{
					_equipmentList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "EquipmentList", cr2w, this);
				}
				return _equipmentList;
			}
			set
			{
				if (_equipmentList == value)
				{
					return;
				}
				_equipmentList = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("CyberwareList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> CyberwareList
		{
			get
			{
				if (_cyberwareList == null)
				{
					_cyberwareList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "CyberwareList", cr2w, this);
				}
				return _cyberwareList;
			}
			set
			{
				if (_cyberwareList == value)
				{
					return;
				}
				_cyberwareList = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("PocketList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> PocketList
		{
			get
			{
				if (_pocketList == null)
				{
					_pocketList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "PocketList", cr2w, this);
				}
				return _pocketList;
			}
			set
			{
				if (_pocketList == value)
				{
					return;
				}
				_pocketList = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("ConsumablesList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> ConsumablesList
		{
			get
			{
				if (_consumablesList == null)
				{
					_consumablesList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "ConsumablesList", cr2w, this);
				}
				return _consumablesList;
			}
			set
			{
				if (_consumablesList == value)
				{
					return;
				}
				_consumablesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("animationList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> AnimationList
		{
			get
			{
				if (_animationList == null)
				{
					_animationList = (CArray<wCHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:whandle:InventoryItemDisplayController", "animationList", cr2w, this);
				}
				return _animationList;
			}
			set
			{
				if (_animationList == value)
				{
					return;
				}
				_animationList = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
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

		[Ordinal(38)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (wCHandle<UIScriptableSystem>) CR2WTypeManager.Create("whandle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
				}
				return _uiScriptableSystem;
			}
			set
			{
				if (_uiScriptableSystem == value)
				{
					return;
				}
				_uiScriptableSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get
			{
				if (_comparisonResolver == null)
				{
					_comparisonResolver = (CHandle<ItemPreferredComparisonResolver>) CR2WTypeManager.Create("handle:ItemPreferredComparisonResolver", "comparisonResolver", cr2w, this);
				}
				return _comparisonResolver;
			}
			set
			{
				if (_comparisonResolver == value)
				{
					return;
				}
				_comparisonResolver = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
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

		[Ordinal(41)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get
			{
				if (_equipAreas == null)
				{
					_equipAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "EquipAreas", cr2w, this);
				}
				return _equipAreas;
			}
			set
			{
				if (_equipAreas == value)
				{
					return;
				}
				_equipAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("CyberwareAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> CyberwareAreas
		{
			get
			{
				if (_cyberwareAreas == null)
				{
					_cyberwareAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "CyberwareAreas", cr2w, this);
				}
				return _cyberwareAreas;
			}
			set
			{
				if (_cyberwareAreas == value)
				{
					return;
				}
				_cyberwareAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get
			{
				if (_weaponAreas == null)
				{
					_weaponAreas = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "WeaponAreas", cr2w, this);
				}
				return _weaponAreas;
			}
			set
			{
				if (_weaponAreas == value)
				{
					return;
				}
				_weaponAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("PocketAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> PocketAreas
		{
			get
			{
				if (_pocketAreas == null)
				{
					_pocketAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "PocketAreas", cr2w, this);
				}
				return _pocketAreas;
			}
			set
			{
				if (_pocketAreas == value)
				{
					return;
				}
				_pocketAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("ConsumablesAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> ConsumablesAreas
		{
			get
			{
				if (_consumablesAreas == null)
				{
					_consumablesAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "ConsumablesAreas", cr2w, this);
				}
				return _consumablesAreas;
			}
			set
			{
				if (_consumablesAreas == value)
				{
					return;
				}
				_consumablesAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get
			{
				if (_uIBBEquipment == null)
				{
					_uIBBEquipment = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "UIBBEquipment", cr2w, this);
				}
				return _uIBBEquipment;
			}
			set
			{
				if (_uIBBEquipment == value)
				{
					return;
				}
				_uIBBEquipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get
			{
				if (_uIBBItemMod == null)
				{
					_uIBBItemMod = (CHandle<UI_ItemModSystemDef>) CR2WTypeManager.Create("handle:UI_ItemModSystemDef", "UIBBItemMod", cr2w, this);
				}
				return _uIBBItemMod;
			}
			set
			{
				if (_uIBBItemMod == value)
				{
					return;
				}
				_uIBBItemMod = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get
			{
				if (_disassembleCallback == null)
				{
					_disassembleCallback = (CHandle<UI_CraftingDef>) CR2WTypeManager.Create("handle:UI_CraftingDef", "DisassembleCallback", cr2w, this);
				}
				return _disassembleCallback;
			}
			set
			{
				if (_disassembleCallback == value)
				{
					return;
				}
				_disassembleCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("UIBBEquipmentBlackboard")] 
		public wCHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get
			{
				if (_uIBBEquipmentBlackboard == null)
				{
					_uIBBEquipmentBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBBEquipmentBlackboard", cr2w, this);
				}
				return _uIBBEquipmentBlackboard;
			}
			set
			{
				if (_uIBBEquipmentBlackboard == value)
				{
					return;
				}
				_uIBBEquipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("UIBBItemModBlackbord")] 
		public wCHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get
			{
				if (_uIBBItemModBlackbord == null)
				{
					_uIBBItemModBlackbord = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBBItemModBlackbord", cr2w, this);
				}
				return _uIBBItemModBlackbord;
			}
			set
			{
				if (_uIBBItemModBlackbord == value)
				{
					return;
				}
				_uIBBItemModBlackbord = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("DisassembleBlackboard")] 
		public wCHandle<gameIBlackboard> DisassembleBlackboard
		{
			get
			{
				if (_disassembleBlackboard == null)
				{
					_disassembleBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "DisassembleBlackboard", cr2w, this);
				}
				return _disassembleBlackboard;
			}
			set
			{
				if (_disassembleBlackboard == value)
				{
					return;
				}
				_disassembleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get
			{
				if (_inventoryBBID == null)
				{
					_inventoryBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "InventoryBBID", cr2w, this);
				}
				return _inventoryBBID;
			}
			set
			{
				if (_inventoryBBID == value)
				{
					return;
				}
				_inventoryBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get
			{
				if (_equipmentBBID == null)
				{
					_equipmentBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "EquipmentBBID", cr2w, this);
				}
				return _equipmentBBID;
			}
			set
			{
				if (_equipmentBBID == value)
				{
					return;
				}
				_equipmentBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("SubEquipmentBBID")] 
		public CUInt32 SubEquipmentBBID
		{
			get
			{
				if (_subEquipmentBBID == null)
				{
					_subEquipmentBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "SubEquipmentBBID", cr2w, this);
				}
				return _subEquipmentBBID;
			}
			set
			{
				if (_subEquipmentBBID == value)
				{
					return;
				}
				_subEquipmentBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("ItemModBBID")] 
		public CUInt32 ItemModBBID
		{
			get
			{
				if (_itemModBBID == null)
				{
					_itemModBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "ItemModBBID", cr2w, this);
				}
				return _itemModBBID;
			}
			set
			{
				if (_itemModBBID == value)
				{
					return;
				}
				_itemModBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("DisassembleBBID")] 
		public CUInt32 DisassembleBBID
		{
			get
			{
				if (_disassembleBBID == null)
				{
					_disassembleBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DisassembleBBID", cr2w, this);
				}
				return _disassembleBBID;
			}
			set
			{
				if (_disassembleBBID == value)
				{
					return;
				}
				_disassembleBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("openItemMode")] 
		public CBool OpenItemMode
		{
			get
			{
				if (_openItemMode == null)
				{
					_openItemMode = (CBool) CR2WTypeManager.Create("Bool", "openItemMode", cr2w, this);
				}
				return _openItemMode;
			}
			set
			{
				if (_openItemMode == value)
				{
					return;
				}
				_openItemMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get
			{
				if (_isE3Demo == null)
				{
					_isE3Demo = (CBool) CR2WTypeManager.Create("Bool", "isE3Demo", cr2w, this);
				}
				return _isE3Demo;
			}
			set
			{
				if (_isE3Demo == value)
				{
					return;
				}
				_isE3Demo = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("inventoryStatsListener")] 
		public CHandle<InventoryStatsListener> InventoryStatsListener
		{
			get
			{
				if (_inventoryStatsListener == null)
				{
					_inventoryStatsListener = (CHandle<InventoryStatsListener>) CR2WTypeManager.Create("handle:InventoryStatsListener", "inventoryStatsListener", cr2w, this);
				}
				return _inventoryStatsListener;
			}
			set
			{
				if (_inventoryStatsListener == value)
				{
					return;
				}
				_inventoryStatsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get
			{
				if (_quantityPickerPopupToken == null)
				{
					_quantityPickerPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "quantityPickerPopupToken", cr2w, this);
				}
				return _quantityPickerPopupToken;
			}
			set
			{
				if (_quantityPickerPopupToken == value)
				{
					return;
				}
				_quantityPickerPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "psmBlackboard", cr2w, this);
				}
				return _psmBlackboard;
			}
			set
			{
				if (_psmBlackboard == value)
				{
					return;
				}
				_psmBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get
			{
				if (_equipmentAreaCategoryEventQueue == null)
				{
					_equipmentAreaCategoryEventQueue = (CArray<CHandle<EquipmentAreaCategoryCreated>>) CR2WTypeManager.Create("array:handle:EquipmentAreaCategoryCreated", "equipmentAreaCategoryEventQueue", cr2w, this);
				}
				return _equipmentAreaCategoryEventQueue;
			}
			set
			{
				if (_equipmentAreaCategoryEventQueue == value)
				{
					return;
				}
				_equipmentAreaCategoryEventQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get
			{
				if (_equipmentAreaCategories == null)
				{
					_equipmentAreaCategories = (CArray<CHandle<EquipmentAreaCategory>>) CR2WTypeManager.Create("array:handle:EquipmentAreaCategory", "equipmentAreaCategories", cr2w, this);
				}
				return _equipmentAreaCategories;
			}
			set
			{
				if (_equipmentAreaCategories == value)
				{
					return;
				}
				_equipmentAreaCategories = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("telemetrySystem")] 
		public wCHandle<gameTelemetryTelemetrySystem> TelemetrySystem
		{
			get
			{
				if (_telemetrySystem == null)
				{
					_telemetrySystem = (wCHandle<gameTelemetryTelemetrySystem>) CR2WTypeManager.Create("whandle:gameTelemetryTelemetrySystem", "telemetrySystem", cr2w, this);
				}
				return _telemetrySystem;
			}
			set
			{
				if (_telemetrySystem == value)
				{
					return;
				}
				_telemetrySystem = value;
				PropertySet(this);
			}
		}

		public gameuiInventoryGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
