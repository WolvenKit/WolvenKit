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
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("itemModeControllerRef")] 
		public inkWidgetReference ItemModeControllerRef
		{
			get => GetProperty(ref _itemModeControllerRef);
			set => SetProperty(ref _itemModeControllerRef, value);
		}

		[Ordinal(6)] 
		[RED("defaultWrapper")] 
		public inkWidgetReference DefaultWrapper
		{
			get => GetProperty(ref _defaultWrapper);
			set => SetProperty(ref _defaultWrapper, value);
		}

		[Ordinal(7)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get => GetProperty(ref _itemWrapper);
			set => SetProperty(ref _itemWrapper, value);
		}

		[Ordinal(8)] 
		[RED("CyberwareSlotRootRefs")] 
		public inkCompoundWidgetReference CyberwareSlotRootRefs
		{
			get => GetProperty(ref _cyberwareSlotRootRefs);
			set => SetProperty(ref _cyberwareSlotRootRefs, value);
		}

		[Ordinal(9)] 
		[RED("paperDollWidget")] 
		public inkWidgetReference PaperDollWidget
		{
			get => GetProperty(ref _paperDollWidget);
			set => SetProperty(ref _paperDollWidget, value);
		}

		[Ordinal(10)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(11)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(12)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(13)] 
		[RED("playerStatsWidget")] 
		public inkWidgetReference PlayerStatsWidget
		{
			get => GetProperty(ref _playerStatsWidget);
			set => SetProperty(ref _playerStatsWidget, value);
		}

		[Ordinal(14)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get => GetProperty(ref _btnBackpack);
			set => SetProperty(ref _btnBackpack, value);
		}

		[Ordinal(15)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get => GetProperty(ref _btnCyberware);
			set => SetProperty(ref _btnCyberware, value);
		}

		[Ordinal(16)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get => GetProperty(ref _btnStats);
			set => SetProperty(ref _btnStats, value);
		}

		[Ordinal(17)] 
		[RED("cyberdeckLinkContainer")] 
		public inkWidgetReference CyberdeckLinkContainer
		{
			get => GetProperty(ref _cyberdeckLinkContainer);
			set => SetProperty(ref _cyberdeckLinkContainer, value);
		}

		[Ordinal(18)] 
		[RED("cyberdeckLinkItem")] 
		public inkWidgetReference CyberdeckLinkItem
		{
			get => GetProperty(ref _cyberdeckLinkItem);
			set => SetProperty(ref _cyberdeckLinkItem, value);
		}

		[Ordinal(19)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get => GetProperty(ref _itemNotificationRoot);
			set => SetProperty(ref _itemNotificationRoot, value);
		}

		[Ordinal(20)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(21)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(23)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<InventoryModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(25)] 
		[RED("itemViewMode")] 
		public CEnum<ItemViewModes> ItemViewMode
		{
			get => GetProperty(ref _itemViewMode);
			set => SetProperty(ref _itemViewMode, value);
		}

		[Ordinal(26)] 
		[RED("itemModeLogicController")] 
		public wCHandle<InventoryItemModeLogicController> ItemModeLogicController
		{
			get => GetProperty(ref _itemModeLogicController);
			set => SetProperty(ref _itemModeLogicController, value);
		}

		[Ordinal(27)] 
		[RED("selectedEquipmentSlot")] 
		public wCHandle<InventoryItemDisplayController> SelectedEquipmentSlot
		{
			get => GetProperty(ref _selectedEquipmentSlot);
			set => SetProperty(ref _selectedEquipmentSlot, value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(29)] 
		[RED("animDef")] 
		public CHandle<inkanimDefinition> AnimDef
		{
			get => GetProperty(ref _animDef);
			set => SetProperty(ref _animDef, value);
		}

		[Ordinal(30)] 
		[RED("InventoryList")] 
		public CArray<wCHandle<InventoryItemDisplay>> InventoryList
		{
			get => GetProperty(ref _inventoryList);
			set => SetProperty(ref _inventoryList, value);
		}

		[Ordinal(31)] 
		[RED("WeaponsList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> WeaponsList
		{
			get => GetProperty(ref _weaponsList);
			set => SetProperty(ref _weaponsList, value);
		}

		[Ordinal(32)] 
		[RED("EquipmentList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> EquipmentList
		{
			get => GetProperty(ref _equipmentList);
			set => SetProperty(ref _equipmentList, value);
		}

		[Ordinal(33)] 
		[RED("CyberwareList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> CyberwareList
		{
			get => GetProperty(ref _cyberwareList);
			set => SetProperty(ref _cyberwareList, value);
		}

		[Ordinal(34)] 
		[RED("PocketList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> PocketList
		{
			get => GetProperty(ref _pocketList);
			set => SetProperty(ref _pocketList, value);
		}

		[Ordinal(35)] 
		[RED("ConsumablesList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> ConsumablesList
		{
			get => GetProperty(ref _consumablesList);
			set => SetProperty(ref _consumablesList, value);
		}

		[Ordinal(36)] 
		[RED("animationList")] 
		public CArray<wCHandle<InventoryItemDisplayController>> AnimationList
		{
			get => GetProperty(ref _animationList);
			set => SetProperty(ref _animationList, value);
		}

		[Ordinal(37)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(38)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(39)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(40)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(41)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(42)] 
		[RED("CyberwareAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> CyberwareAreas
		{
			get => GetProperty(ref _cyberwareAreas);
			set => SetProperty(ref _cyberwareAreas, value);
		}

		[Ordinal(43)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetProperty(ref _weaponAreas);
			set => SetProperty(ref _weaponAreas, value);
		}

		[Ordinal(44)] 
		[RED("PocketAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> PocketAreas
		{
			get => GetProperty(ref _pocketAreas);
			set => SetProperty(ref _pocketAreas, value);
		}

		[Ordinal(45)] 
		[RED("ConsumablesAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> ConsumablesAreas
		{
			get => GetProperty(ref _consumablesAreas);
			set => SetProperty(ref _consumablesAreas, value);
		}

		[Ordinal(46)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetProperty(ref _uIBBEquipment);
			set => SetProperty(ref _uIBBEquipment, value);
		}

		[Ordinal(47)] 
		[RED("UIBBItemMod")] 
		public CHandle<UI_ItemModSystemDef> UIBBItemMod
		{
			get => GetProperty(ref _uIBBItemMod);
			set => SetProperty(ref _uIBBItemMod, value);
		}

		[Ordinal(48)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetProperty(ref _disassembleCallback);
			set => SetProperty(ref _disassembleCallback, value);
		}

		[Ordinal(49)] 
		[RED("UIBBEquipmentBlackboard")] 
		public wCHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get => GetProperty(ref _uIBBEquipmentBlackboard);
			set => SetProperty(ref _uIBBEquipmentBlackboard, value);
		}

		[Ordinal(50)] 
		[RED("UIBBItemModBlackbord")] 
		public wCHandle<gameIBlackboard> UIBBItemModBlackbord
		{
			get => GetProperty(ref _uIBBItemModBlackbord);
			set => SetProperty(ref _uIBBItemModBlackbord, value);
		}

		[Ordinal(51)] 
		[RED("DisassembleBlackboard")] 
		public wCHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetProperty(ref _disassembleBlackboard);
			set => SetProperty(ref _disassembleBlackboard, value);
		}

		[Ordinal(52)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get => GetProperty(ref _inventoryBBID);
			set => SetProperty(ref _inventoryBBID, value);
		}

		[Ordinal(53)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get => GetProperty(ref _equipmentBBID);
			set => SetProperty(ref _equipmentBBID, value);
		}

		[Ordinal(54)] 
		[RED("SubEquipmentBBID")] 
		public CUInt32 SubEquipmentBBID
		{
			get => GetProperty(ref _subEquipmentBBID);
			set => SetProperty(ref _subEquipmentBBID, value);
		}

		[Ordinal(55)] 
		[RED("ItemModBBID")] 
		public CUInt32 ItemModBBID
		{
			get => GetProperty(ref _itemModBBID);
			set => SetProperty(ref _itemModBBID, value);
		}

		[Ordinal(56)] 
		[RED("DisassembleBBID")] 
		public CUInt32 DisassembleBBID
		{
			get => GetProperty(ref _disassembleBBID);
			set => SetProperty(ref _disassembleBBID, value);
		}

		[Ordinal(57)] 
		[RED("openItemMode")] 
		public CBool OpenItemMode
		{
			get => GetProperty(ref _openItemMode);
			set => SetProperty(ref _openItemMode, value);
		}

		[Ordinal(58)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetProperty(ref _isE3Demo);
			set => SetProperty(ref _isE3Demo, value);
		}

		[Ordinal(59)] 
		[RED("inventoryStatsListener")] 
		public CHandle<InventoryStatsListener> InventoryStatsListener
		{
			get => GetProperty(ref _inventoryStatsListener);
			set => SetProperty(ref _inventoryStatsListener, value);
		}

		[Ordinal(60)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(61)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(62)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get => GetProperty(ref _equipmentAreaCategoryEventQueue);
			set => SetProperty(ref _equipmentAreaCategoryEventQueue, value);
		}

		[Ordinal(63)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get => GetProperty(ref _equipmentAreaCategories);
			set => SetProperty(ref _equipmentAreaCategories, value);
		}

		[Ordinal(64)] 
		[RED("telemetrySystem")] 
		public wCHandle<gameTelemetryTelemetrySystem> TelemetrySystem
		{
			get => GetProperty(ref _telemetrySystem);
			set => SetProperty(ref _telemetrySystem, value);
		}

		public gameuiInventoryGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
