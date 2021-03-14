using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBackpackMainGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _commonCraftingMaterialsGrid;
		private inkCompoundWidgetReference _hackingCraftingMaterialsGrid;
		private inkCompoundWidgetReference _filterButtonsGrid;
		private inkVirtualCompoundWidgetReference _virtualItemsGrid;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _itemsListScrollAreaContainer;
		private inkWidgetReference _itemNotificationRoot;
		private wCHandle<inkGridController> _virtualBackpackItemsListController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<CEnum<gamedataItemType>> _itemTypeSorting;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CArray<gameItemModParams> _itemDropQueue;
		private CArray<CHandle<CrafringMaterialItemController>> _craftingMaterialsListItems;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private CHandle<gameIBlackboard> _disassembleBlackboard;
		private CUInt32 _disassembleBBID;
		private CHandle<UI_EquipmentDef> _equippedCallback;
		private CHandle<gameIBlackboard> _equippedBlackboard;
		private CUInt32 _equippedBBID;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<BackpackFilterButtonController> _activeFilter;
		private CHandle<inkScriptableDataSourceWrapper> _backpackItemsDataSource;
		private CHandle<BackpackDataView> _backpackItemsDataView;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CHandle<BackpackInventoryListenerCallback> _backpackInventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _backpackInventoryListener;
		private CHandle<ItemDisplayTemplateClassifier> _backpackItemsClassifier;
		private CHandle<ItemPositionProvider> _backpackItemsPositionProvider;
		private CHandle<inkGameNotificationToken> _equipSlotChooserPopupToken;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private CBool _isE3Demo;
		private CBool _equipRequested;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CEnum<gamePSMVehicle> _playerState;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CHandle<inkGameNotificationToken> _itemPreviewPopupToken;
		private CBool _afterCloseRequest;

		[Ordinal(3)] 
		[RED("commonCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference CommonCraftingMaterialsGrid
		{
			get
			{
				if (_commonCraftingMaterialsGrid == null)
				{
					_commonCraftingMaterialsGrid = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "commonCraftingMaterialsGrid", cr2w, this);
				}
				return _commonCraftingMaterialsGrid;
			}
			set
			{
				if (_commonCraftingMaterialsGrid == value)
				{
					return;
				}
				_commonCraftingMaterialsGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hackingCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference HackingCraftingMaterialsGrid
		{
			get
			{
				if (_hackingCraftingMaterialsGrid == null)
				{
					_hackingCraftingMaterialsGrid = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "hackingCraftingMaterialsGrid", cr2w, this);
				}
				return _hackingCraftingMaterialsGrid;
			}
			set
			{
				if (_hackingCraftingMaterialsGrid == value)
				{
					return;
				}
				_hackingCraftingMaterialsGrid = value;
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
		[RED("virtualItemsGrid")] 
		public inkVirtualCompoundWidgetReference VirtualItemsGrid
		{
			get
			{
				if (_virtualItemsGrid == null)
				{
					_virtualItemsGrid = (inkVirtualCompoundWidgetReference) CR2WTypeManager.Create("inkVirtualCompoundWidgetReference", "virtualItemsGrid", cr2w, this);
				}
				return _virtualItemsGrid;
			}
			set
			{
				if (_virtualItemsGrid == value)
				{
					return;
				}
				_virtualItemsGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get
			{
				if (_itemsListScrollAreaContainer == null)
				{
					_itemsListScrollAreaContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemsListScrollAreaContainer", cr2w, this);
				}
				return _itemsListScrollAreaContainer;
			}
			set
			{
				if (_itemsListScrollAreaContainer == value)
				{
					return;
				}
				_itemsListScrollAreaContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("virtualBackpackItemsListController")] 
		public wCHandle<inkGridController> VirtualBackpackItemsListController
		{
			get
			{
				if (_virtualBackpackItemsListController == null)
				{
					_virtualBackpackItemsListController = (wCHandle<inkGridController>) CR2WTypeManager.Create("whandle:inkGridController", "virtualBackpackItemsListController", cr2w, this);
				}
				return _virtualBackpackItemsListController;
			}
			set
			{
				if (_virtualBackpackItemsListController == value)
				{
					return;
				}
				_virtualBackpackItemsListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get
			{
				if (_itemTypeSorting == null)
				{
					_itemTypeSorting = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "itemTypeSorting", cr2w, this);
				}
				return _itemTypeSorting;
			}
			set
			{
				if (_itemTypeSorting == value)
				{
					return;
				}
				_itemTypeSorting = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<CHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get
			{
				if (_craftingMaterialsListItems == null)
				{
					_craftingMaterialsListItems = (CArray<CHandle<CrafringMaterialItemController>>) CR2WTypeManager.Create("array:handle:CrafringMaterialItemController", "craftingMaterialsListItems", cr2w, this);
				}
				return _craftingMaterialsListItems;
			}
			set
			{
				if (_craftingMaterialsListItems == value)
				{
					return;
				}
				_craftingMaterialsListItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("DisassembleBlackboard")] 
		public CHandle<gameIBlackboard> DisassembleBlackboard
		{
			get
			{
				if (_disassembleBlackboard == null)
				{
					_disassembleBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "DisassembleBlackboard", cr2w, this);
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get
			{
				if (_equippedCallback == null)
				{
					_equippedCallback = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "EquippedCallback", cr2w, this);
				}
				return _equippedCallback;
			}
			set
			{
				if (_equippedCallback == value)
				{
					return;
				}
				_equippedCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("EquippedBlackboard")] 
		public CHandle<gameIBlackboard> EquippedBlackboard
		{
			get
			{
				if (_equippedBlackboard == null)
				{
					_equippedBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "EquippedBlackboard", cr2w, this);
				}
				return _equippedBlackboard;
			}
			set
			{
				if (_equippedBlackboard == value)
				{
					return;
				}
				_equippedBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("EquippedBBID")] 
		public CUInt32 EquippedBBID
		{
			get
			{
				if (_equippedBBID == null)
				{
					_equippedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "EquippedBBID", cr2w, this);
				}
				return _equippedBBID;
			}
			set
			{
				if (_equippedBBID == value)
				{
					return;
				}
				_equippedBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get
			{
				if (_backpackItemsDataSource == null)
				{
					_backpackItemsDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "backpackItemsDataSource", cr2w, this);
				}
				return _backpackItemsDataSource;
			}
			set
			{
				if (_backpackItemsDataSource == value)
				{
					return;
				}
				_backpackItemsDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get
			{
				if (_backpackItemsDataView == null)
				{
					_backpackItemsDataView = (CHandle<BackpackDataView>) CR2WTypeManager.Create("handle:BackpackDataView", "backpackItemsDataView", cr2w, this);
				}
				return _backpackItemsDataView;
			}
			set
			{
				if (_backpackItemsDataView == value)
				{
					return;
				}
				_backpackItemsDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
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

		[Ordinal(32)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get
			{
				if (_backpackInventoryListenerCallback == null)
				{
					_backpackInventoryListenerCallback = (CHandle<BackpackInventoryListenerCallback>) CR2WTypeManager.Create("handle:BackpackInventoryListenerCallback", "backpackInventoryListenerCallback", cr2w, this);
				}
				return _backpackInventoryListenerCallback;
			}
			set
			{
				if (_backpackInventoryListenerCallback == value)
				{
					return;
				}
				_backpackInventoryListenerCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get
			{
				if (_backpackInventoryListener == null)
				{
					_backpackInventoryListener = (CHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("handle:gameInventoryScriptListener", "backpackInventoryListener", cr2w, this);
				}
				return _backpackInventoryListener;
			}
			set
			{
				if (_backpackInventoryListener == value)
				{
					return;
				}
				_backpackInventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get
			{
				if (_backpackItemsClassifier == null)
				{
					_backpackItemsClassifier = (CHandle<ItemDisplayTemplateClassifier>) CR2WTypeManager.Create("handle:ItemDisplayTemplateClassifier", "backpackItemsClassifier", cr2w, this);
				}
				return _backpackItemsClassifier;
			}
			set
			{
				if (_backpackItemsClassifier == value)
				{
					return;
				}
				_backpackItemsClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get
			{
				if (_backpackItemsPositionProvider == null)
				{
					_backpackItemsPositionProvider = (CHandle<ItemPositionProvider>) CR2WTypeManager.Create("handle:ItemPositionProvider", "backpackItemsPositionProvider", cr2w, this);
				}
				return _backpackItemsPositionProvider;
			}
			set
			{
				if (_backpackItemsPositionProvider == value)
				{
					return;
				}
				_backpackItemsPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get
			{
				if (_equipSlotChooserPopupToken == null)
				{
					_equipSlotChooserPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "equipSlotChooserPopupToken", cr2w, this);
				}
				return _equipSlotChooserPopupToken;
			}
			set
			{
				if (_equipSlotChooserPopupToken == value)
				{
					return;
				}
				_equipSlotChooserPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
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
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get
			{
				if (_equipRequested == null)
				{
					_equipRequested = (CBool) CR2WTypeManager.Create("Bool", "equipRequested", cr2w, this);
				}
				return _equipRequested;
			}
			set
			{
				if (_equipRequested == value)
				{
					return;
				}
				_equipRequested = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
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

		[Ordinal(41)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get
			{
				if (_playerState == null)
				{
					_playerState = (CEnum<gamePSMVehicle>) CR2WTypeManager.Create("gamePSMVehicle", "playerState", cr2w, this);
				}
				return _playerState;
			}
			set
			{
				if (_playerState == value)
				{
					return;
				}
				_playerState = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
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

		[Ordinal(43)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get
			{
				if (_itemPreviewPopupToken == null)
				{
					_itemPreviewPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "itemPreviewPopupToken", cr2w, this);
				}
				return _itemPreviewPopupToken;
			}
			set
			{
				if (_itemPreviewPopupToken == value)
				{
					return;
				}
				_itemPreviewPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get
			{
				if (_afterCloseRequest == null)
				{
					_afterCloseRequest = (CBool) CR2WTypeManager.Create("Bool", "afterCloseRequest", cr2w, this);
				}
				return _afterCloseRequest;
			}
			set
			{
				if (_afterCloseRequest == value)
				{
					return;
				}
				_afterCloseRequest = value;
				PropertySet(this);
			}
		}

		public gameuiBackpackMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
