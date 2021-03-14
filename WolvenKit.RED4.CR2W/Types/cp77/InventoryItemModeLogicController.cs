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
		private CHandle<InventoryGenericItemChooser> _itemChooser;
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
		private CHandle<inkGameNotificationToken> _replaceModNotification;
		private CHandle<InstallModConfirmationData> _installModData;
		private CHandle<ItemDisplayClickEvent> _hACK_lastItemDisplayEvent;

		[Ordinal(1)] 
		[RED("itemCategoryList")] 
		public inkCompoundWidgetReference ItemCategoryList
		{
			get
			{
				if (_itemCategoryList == null)
				{
					_itemCategoryList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "itemCategoryList", cr2w, this);
				}
				return _itemCategoryList;
			}
			set
			{
				if (_itemCategoryList == value)
				{
					return;
				}
				_itemCategoryList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemCategoryHeader")] 
		public inkTextWidgetReference ItemCategoryHeader
		{
			get
			{
				if (_itemCategoryHeader == null)
				{
					_itemCategoryHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemCategoryHeader", cr2w, this);
				}
				return _itemCategoryHeader;
			}
			set
			{
				if (_itemCategoryHeader == value)
				{
					return;
				}
				_itemCategoryHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mainWrapper")] 
		public inkCompoundWidgetReference MainWrapper
		{
			get
			{
				if (_mainWrapper == null)
				{
					_mainWrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "mainWrapper", cr2w, this);
				}
				return _mainWrapper;
			}
			set
			{
				if (_mainWrapper == value)
				{
					return;
				}
				_mainWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emptyInventoryText")] 
		public inkTextWidgetReference EmptyInventoryText
		{
			get
			{
				if (_emptyInventoryText == null)
				{
					_emptyInventoryText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "emptyInventoryText", cr2w, this);
				}
				return _emptyInventoryText;
			}
			set
			{
				if (_emptyInventoryText == value)
				{
					return;
				}
				_emptyInventoryText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get
			{
				if (_filterButtonsGrid == null)
				{
					_filterButtonsGrid = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "filterButtonsGrid", cr2w, this);
				}
				return _filterButtonsGrid;
			}
			set
			{
				if (_filterButtonsGrid == value)
				{
					return;
				}
				_filterButtonsGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemGridContainer")] 
		public inkWidgetReference ItemGridContainer
		{
			get
			{
				if (_itemGridContainer == null)
				{
					_itemGridContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemGridContainer", cr2w, this);
				}
				return _itemGridContainer;
			}
			set
			{
				if (_itemGridContainer == value)
				{
					return;
				}
				_itemGridContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cyberwareGridContainer")] 
		public inkWidgetReference CyberwareGridContainer
		{
			get
			{
				if (_cyberwareGridContainer == null)
				{
					_cyberwareGridContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cyberwareGridContainer", cr2w, this);
				}
				return _cyberwareGridContainer;
			}
			set
			{
				if (_cyberwareGridContainer == value)
				{
					return;
				}
				_cyberwareGridContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemGridScrollControllerWidget")] 
		public inkWidgetReference ItemGridScrollControllerWidget
		{
			get
			{
				if (_itemGridScrollControllerWidget == null)
				{
					_itemGridScrollControllerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemGridScrollControllerWidget", cr2w, this);
				}
				return _itemGridScrollControllerWidget;
			}
			set
			{
				if (_itemGridScrollControllerWidget == value)
				{
					return;
				}
				_itemGridScrollControllerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (wCHandle<gameTransactionSystem>) CR2WTypeManager.Create("whandle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("itemChooser")] 
		public CHandle<InventoryGenericItemChooser> ItemChooser
		{
			get
			{
				if (_itemChooser == null)
				{
					_itemChooser = (CHandle<InventoryGenericItemChooser>) CR2WTypeManager.Create("handle:InventoryGenericItemChooser", "itemChooser", cr2w, this);
				}
				return _itemChooser;
			}
			set
			{
				if (_itemChooser == value)
				{
					return;
				}
				_itemChooser = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lastEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas
		{
			get
			{
				if (_lastEquipmentAreas == null)
				{
					_lastEquipmentAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "lastEquipmentAreas", cr2w, this);
				}
				return _lastEquipmentAreas;
			}
			set
			{
				if (_lastEquipmentAreas == value)
				{
					return;
				}
				_lastEquipmentAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("currentHotkey")] 
		public CEnum<gameEHotkey> CurrentHotkey
		{
			get
			{
				if (_currentHotkey == null)
				{
					_currentHotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "currentHotkey", cr2w, this);
				}
				return _currentHotkey;
			}
			set
			{
				if (_currentHotkey == value)
				{
					return;
				}
				_currentHotkey = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("inventoryController")] 
		public wCHandle<gameuiInventoryGameController> InventoryController
		{
			get
			{
				if (_inventoryController == null)
				{
					_inventoryController = (wCHandle<gameuiInventoryGameController>) CR2WTypeManager.Create("whandle:gameuiInventoryGameController", "inventoryController", cr2w, this);
				}
				return _inventoryController;
			}
			set
			{
				if (_inventoryController == value)
				{
					return;
				}
				_inventoryController = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get
			{
				if (_itemsPositionProvider == null)
				{
					_itemsPositionProvider = (CHandle<ItemPositionProvider>) CR2WTypeManager.Create("handle:ItemPositionProvider", "itemsPositionProvider", cr2w, this);
				}
				return _itemsPositionProvider;
			}
			set
			{
				if (_itemsPositionProvider == value)
				{
					return;
				}
				_itemsPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("equipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get
			{
				if (_equipmentBlackboard == null)
				{
					_equipmentBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "equipmentBlackboard", cr2w, this);
				}
				return _equipmentBlackboard;
			}
			set
			{
				if (_equipmentBlackboard == value)
				{
					return;
				}
				_equipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("itemModsBlackboard")] 
		public wCHandle<gameIBlackboard> ItemModsBlackboard
		{
			get
			{
				if (_itemModsBlackboard == null)
				{
					_itemModsBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "itemModsBlackboard", cr2w, this);
				}
				return _itemModsBlackboard;
			}
			set
			{
				if (_itemModsBlackboard == value)
				{
					return;
				}
				_itemModsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("equipmentBlackboardCallback")] 
		public CUInt32 EquipmentBlackboardCallback
		{
			get
			{
				if (_equipmentBlackboardCallback == null)
				{
					_equipmentBlackboardCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "equipmentBlackboardCallback", cr2w, this);
				}
				return _equipmentBlackboardCallback;
			}
			set
			{
				if (_equipmentBlackboardCallback == value)
				{
					return;
				}
				_equipmentBlackboardCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("itemModsBlackboardCallback")] 
		public CUInt32 ItemModsBlackboardCallback
		{
			get
			{
				if (_itemModsBlackboardCallback == null)
				{
					_itemModsBlackboardCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "itemModsBlackboardCallback", cr2w, this);
				}
				return _itemModsBlackboardCallback;
			}
			set
			{
				if (_itemModsBlackboardCallback == value)
				{
					return;
				}
				_itemModsBlackboardCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get
			{
				if (_itemGridClassifier == null)
				{
					_itemGridClassifier = (CHandle<ItemModeGridClassifier>) CR2WTypeManager.Create("handle:ItemModeGridClassifier", "itemGridClassifier", cr2w, this);
				}
				return _itemGridClassifier;
			}
			set
			{
				if (_itemGridClassifier == value)
				{
					return;
				}
				_itemGridClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get
			{
				if (_itemGridDataView == null)
				{
					_itemGridDataView = (CHandle<ItemModeGridView>) CR2WTypeManager.Create("handle:ItemModeGridView", "itemGridDataView", cr2w, this);
				}
				return _itemGridDataView;
			}
			set
			{
				if (_itemGridDataView == value)
				{
					return;
				}
				_itemGridDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get
			{
				if (_itemGridDataSource == null)
				{
					_itemGridDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "itemGridDataSource", cr2w, this);
				}
				return _itemGridDataSource;
			}
			set
			{
				if (_itemGridDataSource == value)
				{
					return;
				}
				_itemGridDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("activeFilter")] 
		public CHandle<BackpackFilterButtonController> ActiveFilter
		{
			get
			{
				if (_activeFilter == null)
				{
					_activeFilter = (CHandle<BackpackFilterButtonController>) CR2WTypeManager.Create("handle:BackpackFilterButtonController", "activeFilter", cr2w, this);
				}
				return _activeFilter;
			}
			set
			{
				if (_activeFilter == value)
				{
					return;
				}
				_activeFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("filterManager")] 
		public CHandle<ItemCategoryFliterManager> FilterManager
		{
			get
			{
				if (_filterManager == null)
				{
					_filterManager = (CHandle<ItemCategoryFliterManager>) CR2WTypeManager.Create("handle:ItemCategoryFliterManager", "filterManager", cr2w, this);
				}
				return _filterManager;
			}
			set
			{
				if (_filterManager == value)
				{
					return;
				}
				_filterManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("savedFilter")] 
		public CEnum<ItemFilterCategory> SavedFilter
		{
			get
			{
				if (_savedFilter == null)
				{
					_savedFilter = (CEnum<ItemFilterCategory>) CR2WTypeManager.Create("ItemFilterCategory", "savedFilter", cr2w, this);
				}
				return _savedFilter;
			}
			set
			{
				if (_savedFilter == value)
				{
					return;
				}
				_savedFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("lastSelectedDisplay")] 
		public CHandle<InventoryItemDisplayController> LastSelectedDisplay
		{
			get
			{
				if (_lastSelectedDisplay == null)
				{
					_lastSelectedDisplay = (CHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("handle:InventoryItemDisplayController", "lastSelectedDisplay", cr2w, this);
				}
				return _lastSelectedDisplay;
			}
			set
			{
				if (_lastSelectedDisplay == value)
				{
					return;
				}
				_lastSelectedDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("itemModeInventoryListenerCallback")] 
		public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback
		{
			get
			{
				if (_itemModeInventoryListenerCallback == null)
				{
					_itemModeInventoryListenerCallback = (CHandle<ItemModeInventoryListenerCallback>) CR2WTypeManager.Create("handle:ItemModeInventoryListenerCallback", "itemModeInventoryListenerCallback", cr2w, this);
				}
				return _itemModeInventoryListenerCallback;
			}
			set
			{
				if (_itemModeInventoryListenerCallback == value)
				{
					return;
				}
				_itemModeInventoryListenerCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("itemModeInventoryListener")] 
		public CHandle<gameInventoryScriptListener> ItemModeInventoryListener
		{
			get
			{
				if (_itemModeInventoryListener == null)
				{
					_itemModeInventoryListener = (CHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("handle:gameInventoryScriptListener", "itemModeInventoryListener", cr2w, this);
				}
				return _itemModeInventoryListener;
			}
			set
			{
				if (_itemModeInventoryListener == value)
				{
					return;
				}
				_itemModeInventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("itemModeInventoryListenerRegistered")] 
		public CBool ItemModeInventoryListenerRegistered
		{
			get
			{
				if (_itemModeInventoryListenerRegistered == null)
				{
					_itemModeInventoryListenerRegistered = (CBool) CR2WTypeManager.Create("Bool", "itemModeInventoryListenerRegistered", cr2w, this);
				}
				return _itemModeInventoryListenerRegistered;
			}
			set
			{
				if (_itemModeInventoryListenerRegistered == value)
				{
					return;
				}
				_itemModeInventoryListenerRegistered = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("itemGridContainerController")] 
		public CHandle<ItemModeGridContainer> ItemGridContainerController
		{
			get
			{
				if (_itemGridContainerController == null)
				{
					_itemGridContainerController = (CHandle<ItemModeGridContainer>) CR2WTypeManager.Create("handle:ItemModeGridContainer", "itemGridContainerController", cr2w, this);
				}
				return _itemGridContainerController;
			}
			set
			{
				if (_itemGridContainerController == value)
				{
					return;
				}
				_itemGridContainerController = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("cyberwareGridContainerController")] 
		public CHandle<ItemModeGridContainer> CyberwareGridContainerController
		{
			get
			{
				if (_cyberwareGridContainerController == null)
				{
					_cyberwareGridContainerController = (CHandle<ItemModeGridContainer>) CR2WTypeManager.Create("handle:ItemModeGridContainer", "cyberwareGridContainerController", cr2w, this);
				}
				return _cyberwareGridContainerController;
			}
			set
			{
				if (_cyberwareGridContainerController == value)
				{
					return;
				}
				_cyberwareGridContainerController = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
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

		[Ordinal(38)] 
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

		[Ordinal(39)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get
			{
				if (_isShown == null)
				{
					_isShown = (CBool) CR2WTypeManager.Create("Bool", "isShown", cr2w, this);
				}
				return _isShown;
			}
			set
			{
				if (_isShown == value)
				{
					return;
				}
				_isShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get
			{
				if (_itemDropQueue == null)
				{
					_itemDropQueue = (CArray<gameItemModParams>) CR2WTypeManager.Create("array:gameItemModParams", "itemDropQueue", cr2w, this);
				}
				return _itemDropQueue;
			}
			set
			{
				if (_itemDropQueue == value)
				{
					return;
				}
				_itemDropQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("replaceModNotification")] 
		public CHandle<inkGameNotificationToken> ReplaceModNotification
		{
			get
			{
				if (_replaceModNotification == null)
				{
					_replaceModNotification = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "replaceModNotification", cr2w, this);
				}
				return _replaceModNotification;
			}
			set
			{
				if (_replaceModNotification == value)
				{
					return;
				}
				_replaceModNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("installModData")] 
		public CHandle<InstallModConfirmationData> InstallModData
		{
			get
			{
				if (_installModData == null)
				{
					_installModData = (CHandle<InstallModConfirmationData>) CR2WTypeManager.Create("handle:InstallModConfirmationData", "installModData", cr2w, this);
				}
				return _installModData;
			}
			set
			{
				if (_installModData == value)
				{
					return;
				}
				_installModData = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("HACK_lastItemDisplayEvent")] 
		public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent
		{
			get
			{
				if (_hACK_lastItemDisplayEvent == null)
				{
					_hACK_lastItemDisplayEvent = (CHandle<ItemDisplayClickEvent>) CR2WTypeManager.Create("handle:ItemDisplayClickEvent", "HACK_lastItemDisplayEvent", cr2w, this);
				}
				return _hACK_lastItemDisplayEvent;
			}
			set
			{
				if (_hACK_lastItemDisplayEvent == value)
				{
					return;
				}
				_hACK_lastItemDisplayEvent = value;
				PropertySet(this);
			}
		}

		public InventoryItemModeLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
