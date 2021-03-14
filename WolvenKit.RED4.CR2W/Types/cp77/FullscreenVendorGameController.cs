using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FullscreenVendorGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _playerFiltersContainer;
		private inkWidgetReference _vendorFiltersContainer;
		private inkVirtualCompoundWidgetReference _inventoryGridList;
		private inkCompoundWidgetReference _vendorSpecialOffersInventoryGridList;
		private inkVirtualCompoundWidgetReference _vendorInventoryGridList;
		private inkWidgetReference _specialOffersWrapper;
		private inkWidgetReference _playerInventoryGridScroll;
		private inkWidgetReference _vendorInventoryGridScroll;
		private inkWidgetReference _notificationRoot;
		private inkWidgetReference _emptyStock;
		private inkWidgetReference _buyWrapper;
		private inkTextWidgetReference _vendorMoney;
		private inkTextWidgetReference _vendorName;
		private inkTextWidgetReference _playerMoney;
		private inkWidgetReference _quantityPicker;
		private inkWidgetReference _playerSortingButton;
		private inkWidgetReference _vendorSortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _playerBalance;
		private inkWidgetReference _vendorBalance;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<VendorDataManager> _vendorDataManager;
		private wCHandle<PlayerPuppet> _player;
		private CArray<CEnum<gamedataItemType>> _itemTypeSorting;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CArray<CHandle<InventoryItemDisplayController>> _playerInventoryitemControllers;
		private CArray<CHandle<InventoryItemDisplayController>> _vendorInventoryitemControllers;
		private CArray<CHandle<InventoryItemDisplayController>> _vendorSpecialOfferInventoryitemControllers;
		private CHandle<inkScriptableDataSourceWrapper> _playerDataSource;
		private CHandle<inkVirtualGridController> _virtualPlayerListController;
		private CHandle<inkScriptableDataSourceWrapper> _vendorDataSource;
		private CHandle<inkVirtualGridController> _virtualVendorListController;
		private CHandle<VendorDataView> _playerItemsDataView;
		private CHandle<VendorDataView> _vendorItemsDataView;
		private CHandle<ItemDisplayTemplateClassifier> _itemsClassifier;
		private CFloat _totalBuyCost;
		private CFloat _totalSellCost;
		private wCHandle<inkWidget> _root;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<StorageUserData> _storageUserData;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CHandle<inkGameNotificationToken> _sellJunkPopupToken;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private CHandle<inkGameNotificationToken> _confirmationPopupToken;
		private CHandle<inkGameNotificationToken> _itemPreviewPopupToken;
		private CHandle<gameIBlackboard> _vendorBlackboard;
		private CHandle<UI_VendorDef> _vendorBlackboardDef;
		private CUInt32 _vendorUpdatedCallbackID;
		private CHandle<gameIBlackboard> _craftingBlackboard;
		private CHandle<UI_CraftingDef> _craftingBlackboardDef;
		private CUInt32 _craftingCallbackID;
		private CHandle<ItemCategoryFliterManager> _playerFilterManager;
		private CHandle<ItemCategoryFliterManager> _vendorFilterManager;
		private CEnum<ItemFilterCategory> _lastPlayerFilter;
		private CEnum<ItemFilterCategory> _lastVendorFilter;
		private CHandle<UIScriptableSystem> _uiScriptableSystem;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CHandle<StorageBlackboardDef> _storageDef;
		private CHandle<gameIBlackboard> _storageBlackboard;
		private CArray<gameItemModParams> _itemDropQueue;
		private CHandle<SoldItemsCache> _soldItems;
		private CBool _isActivePanel;
		private CArray<gameItemID> _sellQueue;
		private CArray<gameItemID> _buyQueue;

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
		[RED("playerFiltersContainer")] 
		public inkWidgetReference PlayerFiltersContainer
		{
			get
			{
				if (_playerFiltersContainer == null)
				{
					_playerFiltersContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerFiltersContainer", cr2w, this);
				}
				return _playerFiltersContainer;
			}
			set
			{
				if (_playerFiltersContainer == value)
				{
					return;
				}
				_playerFiltersContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vendorFiltersContainer")] 
		public inkWidgetReference VendorFiltersContainer
		{
			get
			{
				if (_vendorFiltersContainer == null)
				{
					_vendorFiltersContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vendorFiltersContainer", cr2w, this);
				}
				return _vendorFiltersContainer;
			}
			set
			{
				if (_vendorFiltersContainer == value)
				{
					return;
				}
				_vendorFiltersContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inventoryGridList")] 
		public inkVirtualCompoundWidgetReference InventoryGridList
		{
			get
			{
				if (_inventoryGridList == null)
				{
					_inventoryGridList = (inkVirtualCompoundWidgetReference) CR2WTypeManager.Create("inkVirtualCompoundWidgetReference", "inventoryGridList", cr2w, this);
				}
				return _inventoryGridList;
			}
			set
			{
				if (_inventoryGridList == value)
				{
					return;
				}
				_inventoryGridList = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vendorSpecialOffersInventoryGridList")] 
		public inkCompoundWidgetReference VendorSpecialOffersInventoryGridList
		{
			get
			{
				if (_vendorSpecialOffersInventoryGridList == null)
				{
					_vendorSpecialOffersInventoryGridList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "vendorSpecialOffersInventoryGridList", cr2w, this);
				}
				return _vendorSpecialOffersInventoryGridList;
			}
			set
			{
				if (_vendorSpecialOffersInventoryGridList == value)
				{
					return;
				}
				_vendorSpecialOffersInventoryGridList = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vendorInventoryGridList")] 
		public inkVirtualCompoundWidgetReference VendorInventoryGridList
		{
			get
			{
				if (_vendorInventoryGridList == null)
				{
					_vendorInventoryGridList = (inkVirtualCompoundWidgetReference) CR2WTypeManager.Create("inkVirtualCompoundWidgetReference", "vendorInventoryGridList", cr2w, this);
				}
				return _vendorInventoryGridList;
			}
			set
			{
				if (_vendorInventoryGridList == value)
				{
					return;
				}
				_vendorInventoryGridList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("specialOffersWrapper")] 
		public inkWidgetReference SpecialOffersWrapper
		{
			get
			{
				if (_specialOffersWrapper == null)
				{
					_specialOffersWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "specialOffersWrapper", cr2w, this);
				}
				return _specialOffersWrapper;
			}
			set
			{
				if (_specialOffersWrapper == value)
				{
					return;
				}
				_specialOffersWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("playerInventoryGridScroll")] 
		public inkWidgetReference PlayerInventoryGridScroll
		{
			get
			{
				if (_playerInventoryGridScroll == null)
				{
					_playerInventoryGridScroll = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerInventoryGridScroll", cr2w, this);
				}
				return _playerInventoryGridScroll;
			}
			set
			{
				if (_playerInventoryGridScroll == value)
				{
					return;
				}
				_playerInventoryGridScroll = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("vendorInventoryGridScroll")] 
		public inkWidgetReference VendorInventoryGridScroll
		{
			get
			{
				if (_vendorInventoryGridScroll == null)
				{
					_vendorInventoryGridScroll = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vendorInventoryGridScroll", cr2w, this);
				}
				return _vendorInventoryGridScroll;
			}
			set
			{
				if (_vendorInventoryGridScroll == value)
				{
					return;
				}
				_vendorInventoryGridScroll = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("emptyStock")] 
		public inkWidgetReference EmptyStock
		{
			get
			{
				if (_emptyStock == null)
				{
					_emptyStock = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "emptyStock", cr2w, this);
				}
				return _emptyStock;
			}
			set
			{
				if (_emptyStock == value)
				{
					return;
				}
				_emptyStock = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("buyWrapper")] 
		public inkWidgetReference BuyWrapper
		{
			get
			{
				if (_buyWrapper == null)
				{
					_buyWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buyWrapper", cr2w, this);
				}
				return _buyWrapper;
			}
			set
			{
				if (_buyWrapper == value)
				{
					return;
				}
				_buyWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("vendorMoney")] 
		public inkTextWidgetReference VendorMoney
		{
			get
			{
				if (_vendorMoney == null)
				{
					_vendorMoney = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vendorMoney", cr2w, this);
				}
				return _vendorMoney;
			}
			set
			{
				if (_vendorMoney == value)
				{
					return;
				}
				_vendorMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("vendorName")] 
		public inkTextWidgetReference VendorName
		{
			get
			{
				if (_vendorName == null)
				{
					_vendorName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vendorName", cr2w, this);
				}
				return _vendorName;
			}
			set
			{
				if (_vendorName == value)
				{
					return;
				}
				_vendorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get
			{
				if (_playerMoney == null)
				{
					_playerMoney = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerMoney", cr2w, this);
				}
				return _playerMoney;
			}
			set
			{
				if (_playerMoney == value)
				{
					return;
				}
				_playerMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("quantityPicker")] 
		public inkWidgetReference QuantityPicker
		{
			get
			{
				if (_quantityPicker == null)
				{
					_quantityPicker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "quantityPicker", cr2w, this);
				}
				return _quantityPicker;
			}
			set
			{
				if (_quantityPicker == value)
				{
					return;
				}
				_quantityPicker = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("playerSortingButton")] 
		public inkWidgetReference PlayerSortingButton
		{
			get
			{
				if (_playerSortingButton == null)
				{
					_playerSortingButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerSortingButton", cr2w, this);
				}
				return _playerSortingButton;
			}
			set
			{
				if (_playerSortingButton == value)
				{
					return;
				}
				_playerSortingButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("vendorSortingButton")] 
		public inkWidgetReference VendorSortingButton
		{
			get
			{
				if (_vendorSortingButton == null)
				{
					_vendorSortingButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vendorSortingButton", cr2w, this);
				}
				return _vendorSortingButton;
			}
			set
			{
				if (_vendorSortingButton == value)
				{
					return;
				}
				_vendorSortingButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("playerBalance")] 
		public inkWidgetReference PlayerBalance
		{
			get
			{
				if (_playerBalance == null)
				{
					_playerBalance = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "playerBalance", cr2w, this);
				}
				return _playerBalance;
			}
			set
			{
				if (_playerBalance == value)
				{
					return;
				}
				_playerBalance = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("vendorBalance")] 
		public inkWidgetReference VendorBalance
		{
			get
			{
				if (_vendorBalance == null)
				{
					_vendorBalance = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vendorBalance", cr2w, this);
				}
				return _vendorBalance;
			}
			set
			{
				if (_vendorBalance == value)
				{
					return;
				}
				_vendorBalance = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get
			{
				if (_vendorDataManager == null)
				{
					_vendorDataManager = (CHandle<VendorDataManager>) CR2WTypeManager.Create("handle:VendorDataManager", "VendorDataManager", cr2w, this);
				}
				return _vendorDataManager;
			}
			set
			{
				if (_vendorDataManager == value)
				{
					return;
				}
				_vendorDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
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

		[Ordinal(31)] 
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

		[Ordinal(32)] 
		[RED("playerInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> PlayerInventoryitemControllers
		{
			get
			{
				if (_playerInventoryitemControllers == null)
				{
					_playerInventoryitemControllers = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "playerInventoryitemControllers", cr2w, this);
				}
				return _playerInventoryitemControllers;
			}
			set
			{
				if (_playerInventoryitemControllers == value)
				{
					return;
				}
				_playerInventoryitemControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("vendorInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> VendorInventoryitemControllers
		{
			get
			{
				if (_vendorInventoryitemControllers == null)
				{
					_vendorInventoryitemControllers = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "vendorInventoryitemControllers", cr2w, this);
				}
				return _vendorInventoryitemControllers;
			}
			set
			{
				if (_vendorInventoryitemControllers == value)
				{
					return;
				}
				_vendorInventoryitemControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("vendorSpecialOfferInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> VendorSpecialOfferInventoryitemControllers
		{
			get
			{
				if (_vendorSpecialOfferInventoryitemControllers == null)
				{
					_vendorSpecialOfferInventoryitemControllers = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "vendorSpecialOfferInventoryitemControllers", cr2w, this);
				}
				return _vendorSpecialOfferInventoryitemControllers;
			}
			set
			{
				if (_vendorSpecialOfferInventoryitemControllers == value)
				{
					return;
				}
				_vendorSpecialOfferInventoryitemControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("playerDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> PlayerDataSource
		{
			get
			{
				if (_playerDataSource == null)
				{
					_playerDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "playerDataSource", cr2w, this);
				}
				return _playerDataSource;
			}
			set
			{
				if (_playerDataSource == value)
				{
					return;
				}
				_playerDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("virtualPlayerListController")] 
		public CHandle<inkVirtualGridController> VirtualPlayerListController
		{
			get
			{
				if (_virtualPlayerListController == null)
				{
					_virtualPlayerListController = (CHandle<inkVirtualGridController>) CR2WTypeManager.Create("handle:inkVirtualGridController", "virtualPlayerListController", cr2w, this);
				}
				return _virtualPlayerListController;
			}
			set
			{
				if (_virtualPlayerListController == value)
				{
					return;
				}
				_virtualPlayerListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("vendorDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> VendorDataSource
		{
			get
			{
				if (_vendorDataSource == null)
				{
					_vendorDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "vendorDataSource", cr2w, this);
				}
				return _vendorDataSource;
			}
			set
			{
				if (_vendorDataSource == value)
				{
					return;
				}
				_vendorDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("virtualVendorListController")] 
		public CHandle<inkVirtualGridController> VirtualVendorListController
		{
			get
			{
				if (_virtualVendorListController == null)
				{
					_virtualVendorListController = (CHandle<inkVirtualGridController>) CR2WTypeManager.Create("handle:inkVirtualGridController", "virtualVendorListController", cr2w, this);
				}
				return _virtualVendorListController;
			}
			set
			{
				if (_virtualVendorListController == value)
				{
					return;
				}
				_virtualVendorListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("playerItemsDataView")] 
		public CHandle<VendorDataView> PlayerItemsDataView
		{
			get
			{
				if (_playerItemsDataView == null)
				{
					_playerItemsDataView = (CHandle<VendorDataView>) CR2WTypeManager.Create("handle:VendorDataView", "playerItemsDataView", cr2w, this);
				}
				return _playerItemsDataView;
			}
			set
			{
				if (_playerItemsDataView == value)
				{
					return;
				}
				_playerItemsDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("vendorItemsDataView")] 
		public CHandle<VendorDataView> VendorItemsDataView
		{
			get
			{
				if (_vendorItemsDataView == null)
				{
					_vendorItemsDataView = (CHandle<VendorDataView>) CR2WTypeManager.Create("handle:VendorDataView", "vendorItemsDataView", cr2w, this);
				}
				return _vendorItemsDataView;
			}
			set
			{
				if (_vendorItemsDataView == value)
				{
					return;
				}
				_vendorItemsDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("itemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> ItemsClassifier
		{
			get
			{
				if (_itemsClassifier == null)
				{
					_itemsClassifier = (CHandle<ItemDisplayTemplateClassifier>) CR2WTypeManager.Create("handle:ItemDisplayTemplateClassifier", "itemsClassifier", cr2w, this);
				}
				return _itemsClassifier;
			}
			set
			{
				if (_itemsClassifier == value)
				{
					return;
				}
				_itemsClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("totalBuyCost")] 
		public CFloat TotalBuyCost
		{
			get
			{
				if (_totalBuyCost == null)
				{
					_totalBuyCost = (CFloat) CR2WTypeManager.Create("Float", "totalBuyCost", cr2w, this);
				}
				return _totalBuyCost;
			}
			set
			{
				if (_totalBuyCost == value)
				{
					return;
				}
				_totalBuyCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("totalSellCost")] 
		public CFloat TotalSellCost
		{
			get
			{
				if (_totalSellCost == null)
				{
					_totalSellCost = (CFloat) CR2WTypeManager.Create("Float", "totalSellCost", cr2w, this);
				}
				return _totalSellCost;
			}
			set
			{
				if (_totalSellCost == value)
				{
					return;
				}
				_totalSellCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
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

		[Ordinal(45)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get
			{
				if (_vendorUserData == null)
				{
					_vendorUserData = (CHandle<VendorUserData>) CR2WTypeManager.Create("handle:VendorUserData", "vendorUserData", cr2w, this);
				}
				return _vendorUserData;
			}
			set
			{
				if (_vendorUserData == value)
				{
					return;
				}
				_vendorUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get
			{
				if (_storageUserData == null)
				{
					_storageUserData = (CHandle<StorageUserData>) CR2WTypeManager.Create("handle:StorageUserData", "storageUserData", cr2w, this);
				}
				return _storageUserData;
			}
			set
			{
				if (_storageUserData == value)
				{
					return;
				}
				_storageUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
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

		[Ordinal(48)] 
		[RED("sellJunkPopupToken")] 
		public CHandle<inkGameNotificationToken> SellJunkPopupToken
		{
			get
			{
				if (_sellJunkPopupToken == null)
				{
					_sellJunkPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "sellJunkPopupToken", cr2w, this);
				}
				return _sellJunkPopupToken;
			}
			set
			{
				if (_sellJunkPopupToken == value)
				{
					return;
				}
				_sellJunkPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
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

		[Ordinal(50)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get
			{
				if (_confirmationPopupToken == null)
				{
					_confirmationPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "confirmationPopupToken", cr2w, this);
				}
				return _confirmationPopupToken;
			}
			set
			{
				if (_confirmationPopupToken == value)
				{
					return;
				}
				_confirmationPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
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

		[Ordinal(52)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get
			{
				if (_vendorBlackboard == null)
				{
					_vendorBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "VendorBlackboard", cr2w, this);
				}
				return _vendorBlackboard;
			}
			set
			{
				if (_vendorBlackboard == value)
				{
					return;
				}
				_vendorBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get
			{
				if (_vendorBlackboardDef == null)
				{
					_vendorBlackboardDef = (CHandle<UI_VendorDef>) CR2WTypeManager.Create("handle:UI_VendorDef", "VendorBlackboardDef", cr2w, this);
				}
				return _vendorBlackboardDef;
			}
			set
			{
				if (_vendorBlackboardDef == value)
				{
					return;
				}
				_vendorBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("VendorUpdatedCallbackID")] 
		public CUInt32 VendorUpdatedCallbackID
		{
			get
			{
				if (_vendorUpdatedCallbackID == null)
				{
					_vendorUpdatedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "VendorUpdatedCallbackID", cr2w, this);
				}
				return _vendorUpdatedCallbackID;
			}
			set
			{
				if (_vendorUpdatedCallbackID == value)
				{
					return;
				}
				_vendorUpdatedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("craftingBlackboard")] 
		public CHandle<gameIBlackboard> CraftingBlackboard
		{
			get
			{
				if (_craftingBlackboard == null)
				{
					_craftingBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "craftingBlackboard", cr2w, this);
				}
				return _craftingBlackboard;
			}
			set
			{
				if (_craftingBlackboard == value)
				{
					return;
				}
				_craftingBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("craftingBlackboardDef")] 
		public CHandle<UI_CraftingDef> CraftingBlackboardDef
		{
			get
			{
				if (_craftingBlackboardDef == null)
				{
					_craftingBlackboardDef = (CHandle<UI_CraftingDef>) CR2WTypeManager.Create("handle:UI_CraftingDef", "craftingBlackboardDef", cr2w, this);
				}
				return _craftingBlackboardDef;
			}
			set
			{
				if (_craftingBlackboardDef == value)
				{
					return;
				}
				_craftingBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("craftingCallbackID")] 
		public CUInt32 CraftingCallbackID
		{
			get
			{
				if (_craftingCallbackID == null)
				{
					_craftingCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "craftingCallbackID", cr2w, this);
				}
				return _craftingCallbackID;
			}
			set
			{
				if (_craftingCallbackID == value)
				{
					return;
				}
				_craftingCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("playerFilterManager")] 
		public CHandle<ItemCategoryFliterManager> PlayerFilterManager
		{
			get
			{
				if (_playerFilterManager == null)
				{
					_playerFilterManager = (CHandle<ItemCategoryFliterManager>) CR2WTypeManager.Create("handle:ItemCategoryFliterManager", "playerFilterManager", cr2w, this);
				}
				return _playerFilterManager;
			}
			set
			{
				if (_playerFilterManager == value)
				{
					return;
				}
				_playerFilterManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("vendorFilterManager")] 
		public CHandle<ItemCategoryFliterManager> VendorFilterManager
		{
			get
			{
				if (_vendorFilterManager == null)
				{
					_vendorFilterManager = (CHandle<ItemCategoryFliterManager>) CR2WTypeManager.Create("handle:ItemCategoryFliterManager", "vendorFilterManager", cr2w, this);
				}
				return _vendorFilterManager;
			}
			set
			{
				if (_vendorFilterManager == value)
				{
					return;
				}
				_vendorFilterManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("lastPlayerFilter")] 
		public CEnum<ItemFilterCategory> LastPlayerFilter
		{
			get
			{
				if (_lastPlayerFilter == null)
				{
					_lastPlayerFilter = (CEnum<ItemFilterCategory>) CR2WTypeManager.Create("ItemFilterCategory", "lastPlayerFilter", cr2w, this);
				}
				return _lastPlayerFilter;
			}
			set
			{
				if (_lastPlayerFilter == value)
				{
					return;
				}
				_lastPlayerFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("lastVendorFilter")] 
		public CEnum<ItemFilterCategory> LastVendorFilter
		{
			get
			{
				if (_lastVendorFilter == null)
				{
					_lastVendorFilter = (CEnum<ItemFilterCategory>) CR2WTypeManager.Create("ItemFilterCategory", "lastVendorFilter", cr2w, this);
				}
				return _lastVendorFilter;
			}
			set
			{
				if (_lastVendorFilter == value)
				{
					return;
				}
				_lastVendorFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (CHandle<UIScriptableSystem>) CR2WTypeManager.Create("handle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
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

		[Ordinal(63)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get
			{
				if (_uiSystem == null)
				{
					_uiSystem = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "uiSystem", cr2w, this);
				}
				return _uiSystem;
			}
			set
			{
				if (_uiSystem == value)
				{
					return;
				}
				_uiSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get
			{
				if (_storageDef == null)
				{
					_storageDef = (CHandle<StorageBlackboardDef>) CR2WTypeManager.Create("handle:StorageBlackboardDef", "storageDef", cr2w, this);
				}
				return _storageDef;
			}
			set
			{
				if (_storageDef == value)
				{
					return;
				}
				_storageDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("storageBlackboard")] 
		public CHandle<gameIBlackboard> StorageBlackboard
		{
			get
			{
				if (_storageBlackboard == null)
				{
					_storageBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "storageBlackboard", cr2w, this);
				}
				return _storageBlackboard;
			}
			set
			{
				if (_storageBlackboard == value)
				{
					return;
				}
				_storageBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
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

		[Ordinal(67)] 
		[RED("soldItems")] 
		public CHandle<SoldItemsCache> SoldItems
		{
			get
			{
				if (_soldItems == null)
				{
					_soldItems = (CHandle<SoldItemsCache>) CR2WTypeManager.Create("handle:SoldItemsCache", "soldItems", cr2w, this);
				}
				return _soldItems;
			}
			set
			{
				if (_soldItems == value)
				{
					return;
				}
				_soldItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get
			{
				if (_isActivePanel == null)
				{
					_isActivePanel = (CBool) CR2WTypeManager.Create("Bool", "isActivePanel", cr2w, this);
				}
				return _isActivePanel;
			}
			set
			{
				if (_isActivePanel == value)
				{
					return;
				}
				_isActivePanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("sellQueue")] 
		public CArray<gameItemID> SellQueue
		{
			get
			{
				if (_sellQueue == null)
				{
					_sellQueue = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "sellQueue", cr2w, this);
				}
				return _sellQueue;
			}
			set
			{
				if (_sellQueue == value)
				{
					return;
				}
				_sellQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("buyQueue")] 
		public CArray<gameItemID> BuyQueue
		{
			get
			{
				if (_buyQueue == null)
				{
					_buyQueue = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "buyQueue", cr2w, this);
				}
				return _buyQueue;
			}
			set
			{
				if (_buyQueue == value)
				{
					return;
				}
				_buyQueue = value;
				PropertySet(this);
			}
		}

		public FullscreenVendorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
