using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModeLogicController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _itemCategoryList;
		private inkTextWidgetReference _itemCategoryHeader;
		private inkCompoundWidgetReference _mainWrapper;
		private inkTextWidgetReference _emptyInventoryText;
		private inkCompoundWidgetReference _filterButtonsGrid;
		private inkWidgetReference _itemGridContainer;
		private inkWidgetReference _cyberwareGridContainer;
		private inkWidgetReference _itemGridScrollControllerWidget;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<InventoryGenericItemChooser> _itemChooser;
		private CArray<CEnum<gamedataEquipmentArea>> _lastEquipmentAreas;
		private CEnum<gameEHotkey> _currentHotkey;
		private wCHandle<gameuiInventoryGameController> _inventoryController;
		private CHandle<ItemPositionProvider> _itemsPositionProvider;
		private wCHandle<gameIBlackboard> _equipmentBlackboard;
		private wCHandle<gameIBlackboard> _itemModsBlackboard;
		private CUInt32 _equipmentBlackboardCallback;
		private CUInt32 _itemModsBlackboardCallback;
		private CHandle<ItemModeGridClassifier> _itemGridClassifier;
		private CHandle<ItemModeGridView> _itemGridDataView;
		private CHandle<inkScriptableDataSourceWrapper> _itemGridDataSource;
		private CHandle<BackpackFilterButtonController> _activeFilter;
		private CHandle<ItemCategoryFliterManager> _filterManager;
		private CEnum<ItemFilterCategory> _savedFilter;
		private CHandle<InventoryItemDisplayController> _lastSelectedDisplay;
		private CHandle<ItemModeInventoryListenerCallback> _itemModeInventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _itemModeInventoryListener;
		private CBool _itemModeInventoryListenerRegistered;
		private CHandle<ItemModeGridContainer> _itemGridContainerController;
		private CHandle<ItemModeGridContainer> _cyberwareGridContainerController;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CBool _isE3Demo;
		private CBool _isShown;
		private CArray<gameItemModParams> _itemDropQueue;
		private CHandle<ItemDisplayHoverOverEvent> _lastItemHoverOverEvent;
		private CBool _isComparisionDisabled;
		private CHandle<inkGameNotificationToken> _replaceModNotification;
		private CHandle<InstallModConfirmationData> _installModData;
		private CHandle<ItemDisplayClickEvent> _hACK_lastItemDisplayEvent;

		[Ordinal(1)] 
		[RED("itemCategoryList")] 
		public inkCompoundWidgetReference ItemCategoryList
		{
			get => GetProperty(ref _itemCategoryList);
			set => SetProperty(ref _itemCategoryList, value);
		}

		[Ordinal(2)] 
		[RED("itemCategoryHeader")] 
		public inkTextWidgetReference ItemCategoryHeader
		{
			get => GetProperty(ref _itemCategoryHeader);
			set => SetProperty(ref _itemCategoryHeader, value);
		}

		[Ordinal(3)] 
		[RED("mainWrapper")] 
		public inkCompoundWidgetReference MainWrapper
		{
			get => GetProperty(ref _mainWrapper);
			set => SetProperty(ref _mainWrapper, value);
		}

		[Ordinal(4)] 
		[RED("emptyInventoryText")] 
		public inkTextWidgetReference EmptyInventoryText
		{
			get => GetProperty(ref _emptyInventoryText);
			set => SetProperty(ref _emptyInventoryText, value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetProperty(ref _filterButtonsGrid);
			set => SetProperty(ref _filterButtonsGrid, value);
		}

		[Ordinal(6)] 
		[RED("itemGridContainer")] 
		public inkWidgetReference ItemGridContainer
		{
			get => GetProperty(ref _itemGridContainer);
			set => SetProperty(ref _itemGridContainer, value);
		}

		[Ordinal(7)] 
		[RED("cyberwareGridContainer")] 
		public inkWidgetReference CyberwareGridContainer
		{
			get => GetProperty(ref _cyberwareGridContainer);
			set => SetProperty(ref _cyberwareGridContainer, value);
		}

		[Ordinal(8)] 
		[RED("itemGridScrollControllerWidget")] 
		public inkWidgetReference ItemGridScrollControllerWidget
		{
			get => GetProperty(ref _itemGridScrollControllerWidget);
			set => SetProperty(ref _itemGridScrollControllerWidget, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(10)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(11)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(12)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(13)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(14)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(15)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(16)] 
		[RED("itemChooser")] 
		public wCHandle<InventoryGenericItemChooser> ItemChooser
		{
			get => GetProperty(ref _itemChooser);
			set => SetProperty(ref _itemChooser, value);
		}

		[Ordinal(17)] 
		[RED("lastEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas
		{
			get => GetProperty(ref _lastEquipmentAreas);
			set => SetProperty(ref _lastEquipmentAreas, value);
		}

		[Ordinal(18)] 
		[RED("currentHotkey")] 
		public CEnum<gameEHotkey> CurrentHotkey
		{
			get => GetProperty(ref _currentHotkey);
			set => SetProperty(ref _currentHotkey, value);
		}

		[Ordinal(19)] 
		[RED("inventoryController")] 
		public wCHandle<gameuiInventoryGameController> InventoryController
		{
			get => GetProperty(ref _inventoryController);
			set => SetProperty(ref _inventoryController, value);
		}

		[Ordinal(20)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetProperty(ref _itemsPositionProvider);
			set => SetProperty(ref _itemsPositionProvider, value);
		}

		[Ordinal(21)] 
		[RED("equipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("itemModsBlackboard")] 
		public wCHandle<gameIBlackboard> ItemModsBlackboard
		{
			get => GetProperty(ref _itemModsBlackboard);
			set => SetProperty(ref _itemModsBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("equipmentBlackboardCallback")] 
		public CUInt32 EquipmentBlackboardCallback
		{
			get => GetProperty(ref _equipmentBlackboardCallback);
			set => SetProperty(ref _equipmentBlackboardCallback, value);
		}

		[Ordinal(24)] 
		[RED("itemModsBlackboardCallback")] 
		public CUInt32 ItemModsBlackboardCallback
		{
			get => GetProperty(ref _itemModsBlackboardCallback);
			set => SetProperty(ref _itemModsBlackboardCallback, value);
		}

		[Ordinal(25)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetProperty(ref _itemGridClassifier);
			set => SetProperty(ref _itemGridClassifier, value);
		}

		[Ordinal(26)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get => GetProperty(ref _itemGridDataView);
			set => SetProperty(ref _itemGridDataView, value);
		}

		[Ordinal(27)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetProperty(ref _itemGridDataSource);
			set => SetProperty(ref _itemGridDataSource, value);
		}

		[Ordinal(28)] 
		[RED("activeFilter")] 
		public CHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetProperty(ref _activeFilter);
			set => SetProperty(ref _activeFilter, value);
		}

		[Ordinal(29)] 
		[RED("filterManager")] 
		public CHandle<ItemCategoryFliterManager> FilterManager
		{
			get => GetProperty(ref _filterManager);
			set => SetProperty(ref _filterManager, value);
		}

		[Ordinal(30)] 
		[RED("savedFilter")] 
		public CEnum<ItemFilterCategory> SavedFilter
		{
			get => GetProperty(ref _savedFilter);
			set => SetProperty(ref _savedFilter, value);
		}

		[Ordinal(31)] 
		[RED("lastSelectedDisplay")] 
		public CHandle<InventoryItemDisplayController> LastSelectedDisplay
		{
			get => GetProperty(ref _lastSelectedDisplay);
			set => SetProperty(ref _lastSelectedDisplay, value);
		}

		[Ordinal(32)] 
		[RED("itemModeInventoryListenerCallback")] 
		public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback
		{
			get => GetProperty(ref _itemModeInventoryListenerCallback);
			set => SetProperty(ref _itemModeInventoryListenerCallback, value);
		}

		[Ordinal(33)] 
		[RED("itemModeInventoryListener")] 
		public CHandle<gameInventoryScriptListener> ItemModeInventoryListener
		{
			get => GetProperty(ref _itemModeInventoryListener);
			set => SetProperty(ref _itemModeInventoryListener, value);
		}

		[Ordinal(34)] 
		[RED("itemModeInventoryListenerRegistered")] 
		public CBool ItemModeInventoryListenerRegistered
		{
			get => GetProperty(ref _itemModeInventoryListenerRegistered);
			set => SetProperty(ref _itemModeInventoryListenerRegistered, value);
		}

		[Ordinal(35)] 
		[RED("itemGridContainerController")] 
		public CHandle<ItemModeGridContainer> ItemGridContainerController
		{
			get => GetProperty(ref _itemGridContainerController);
			set => SetProperty(ref _itemGridContainerController, value);
		}

		[Ordinal(36)] 
		[RED("cyberwareGridContainerController")] 
		public CHandle<ItemModeGridContainer> CyberwareGridContainerController
		{
			get => GetProperty(ref _cyberwareGridContainerController);
			set => SetProperty(ref _cyberwareGridContainerController, value);
		}

		[Ordinal(37)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(38)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetProperty(ref _isE3Demo);
			set => SetProperty(ref _isE3Demo, value);
		}

		[Ordinal(39)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		[Ordinal(40)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetProperty(ref _itemDropQueue);
			set => SetProperty(ref _itemDropQueue, value);
		}

		[Ordinal(41)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetProperty(ref _lastItemHoverOverEvent);
			set => SetProperty(ref _lastItemHoverOverEvent, value);
		}

		[Ordinal(42)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetProperty(ref _isComparisionDisabled);
			set => SetProperty(ref _isComparisionDisabled, value);
		}

		[Ordinal(43)] 
		[RED("replaceModNotification")] 
		public CHandle<inkGameNotificationToken> ReplaceModNotification
		{
			get => GetProperty(ref _replaceModNotification);
			set => SetProperty(ref _replaceModNotification, value);
		}

		[Ordinal(44)] 
		[RED("installModData")] 
		public CHandle<InstallModConfirmationData> InstallModData
		{
			get => GetProperty(ref _installModData);
			set => SetProperty(ref _installModData, value);
		}

		[Ordinal(45)] 
		[RED("HACK_lastItemDisplayEvent")] 
		public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent
		{
			get => GetProperty(ref _hACK_lastItemDisplayEvent);
			set => SetProperty(ref _hACK_lastItemDisplayEvent, value);
		}

		public InventoryItemModeLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
