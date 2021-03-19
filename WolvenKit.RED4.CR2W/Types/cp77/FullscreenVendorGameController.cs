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
		[RED("playerFiltersContainer")] 
		public inkWidgetReference PlayerFiltersContainer
		{
			get => GetProperty(ref _playerFiltersContainer);
			set => SetProperty(ref _playerFiltersContainer, value);
		}

		[Ordinal(6)] 
		[RED("vendorFiltersContainer")] 
		public inkWidgetReference VendorFiltersContainer
		{
			get => GetProperty(ref _vendorFiltersContainer);
			set => SetProperty(ref _vendorFiltersContainer, value);
		}

		[Ordinal(7)] 
		[RED("inventoryGridList")] 
		public inkVirtualCompoundWidgetReference InventoryGridList
		{
			get => GetProperty(ref _inventoryGridList);
			set => SetProperty(ref _inventoryGridList, value);
		}

		[Ordinal(8)] 
		[RED("vendorSpecialOffersInventoryGridList")] 
		public inkCompoundWidgetReference VendorSpecialOffersInventoryGridList
		{
			get => GetProperty(ref _vendorSpecialOffersInventoryGridList);
			set => SetProperty(ref _vendorSpecialOffersInventoryGridList, value);
		}

		[Ordinal(9)] 
		[RED("vendorInventoryGridList")] 
		public inkVirtualCompoundWidgetReference VendorInventoryGridList
		{
			get => GetProperty(ref _vendorInventoryGridList);
			set => SetProperty(ref _vendorInventoryGridList, value);
		}

		[Ordinal(10)] 
		[RED("specialOffersWrapper")] 
		public inkWidgetReference SpecialOffersWrapper
		{
			get => GetProperty(ref _specialOffersWrapper);
			set => SetProperty(ref _specialOffersWrapper, value);
		}

		[Ordinal(11)] 
		[RED("playerInventoryGridScroll")] 
		public inkWidgetReference PlayerInventoryGridScroll
		{
			get => GetProperty(ref _playerInventoryGridScroll);
			set => SetProperty(ref _playerInventoryGridScroll, value);
		}

		[Ordinal(12)] 
		[RED("vendorInventoryGridScroll")] 
		public inkWidgetReference VendorInventoryGridScroll
		{
			get => GetProperty(ref _vendorInventoryGridScroll);
			set => SetProperty(ref _vendorInventoryGridScroll, value);
		}

		[Ordinal(13)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(14)] 
		[RED("emptyStock")] 
		public inkWidgetReference EmptyStock
		{
			get => GetProperty(ref _emptyStock);
			set => SetProperty(ref _emptyStock, value);
		}

		[Ordinal(15)] 
		[RED("buyWrapper")] 
		public inkWidgetReference BuyWrapper
		{
			get => GetProperty(ref _buyWrapper);
			set => SetProperty(ref _buyWrapper, value);
		}

		[Ordinal(16)] 
		[RED("vendorMoney")] 
		public inkTextWidgetReference VendorMoney
		{
			get => GetProperty(ref _vendorMoney);
			set => SetProperty(ref _vendorMoney, value);
		}

		[Ordinal(17)] 
		[RED("vendorName")] 
		public inkTextWidgetReference VendorName
		{
			get => GetProperty(ref _vendorName);
			set => SetProperty(ref _vendorName, value);
		}

		[Ordinal(18)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get => GetProperty(ref _playerMoney);
			set => SetProperty(ref _playerMoney, value);
		}

		[Ordinal(19)] 
		[RED("quantityPicker")] 
		public inkWidgetReference QuantityPicker
		{
			get => GetProperty(ref _quantityPicker);
			set => SetProperty(ref _quantityPicker, value);
		}

		[Ordinal(20)] 
		[RED("playerSortingButton")] 
		public inkWidgetReference PlayerSortingButton
		{
			get => GetProperty(ref _playerSortingButton);
			set => SetProperty(ref _playerSortingButton, value);
		}

		[Ordinal(21)] 
		[RED("vendorSortingButton")] 
		public inkWidgetReference VendorSortingButton
		{
			get => GetProperty(ref _vendorSortingButton);
			set => SetProperty(ref _vendorSortingButton, value);
		}

		[Ordinal(22)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(23)] 
		[RED("playerBalance")] 
		public inkWidgetReference PlayerBalance
		{
			get => GetProperty(ref _playerBalance);
			set => SetProperty(ref _playerBalance, value);
		}

		[Ordinal(24)] 
		[RED("vendorBalance")] 
		public inkWidgetReference VendorBalance
		{
			get => GetProperty(ref _vendorBalance);
			set => SetProperty(ref _vendorBalance, value);
		}

		[Ordinal(25)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(26)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(27)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(28)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(29)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetProperty(ref _itemTypeSorting);
			set => SetProperty(ref _itemTypeSorting, value);
		}

		[Ordinal(30)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(31)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(32)] 
		[RED("playerInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> PlayerInventoryitemControllers
		{
			get => GetProperty(ref _playerInventoryitemControllers);
			set => SetProperty(ref _playerInventoryitemControllers, value);
		}

		[Ordinal(33)] 
		[RED("vendorInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> VendorInventoryitemControllers
		{
			get => GetProperty(ref _vendorInventoryitemControllers);
			set => SetProperty(ref _vendorInventoryitemControllers, value);
		}

		[Ordinal(34)] 
		[RED("vendorSpecialOfferInventoryitemControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> VendorSpecialOfferInventoryitemControllers
		{
			get => GetProperty(ref _vendorSpecialOfferInventoryitemControllers);
			set => SetProperty(ref _vendorSpecialOfferInventoryitemControllers, value);
		}

		[Ordinal(35)] 
		[RED("playerDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> PlayerDataSource
		{
			get => GetProperty(ref _playerDataSource);
			set => SetProperty(ref _playerDataSource, value);
		}

		[Ordinal(36)] 
		[RED("virtualPlayerListController")] 
		public CHandle<inkVirtualGridController> VirtualPlayerListController
		{
			get => GetProperty(ref _virtualPlayerListController);
			set => SetProperty(ref _virtualPlayerListController, value);
		}

		[Ordinal(37)] 
		[RED("vendorDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> VendorDataSource
		{
			get => GetProperty(ref _vendorDataSource);
			set => SetProperty(ref _vendorDataSource, value);
		}

		[Ordinal(38)] 
		[RED("virtualVendorListController")] 
		public CHandle<inkVirtualGridController> VirtualVendorListController
		{
			get => GetProperty(ref _virtualVendorListController);
			set => SetProperty(ref _virtualVendorListController, value);
		}

		[Ordinal(39)] 
		[RED("playerItemsDataView")] 
		public CHandle<VendorDataView> PlayerItemsDataView
		{
			get => GetProperty(ref _playerItemsDataView);
			set => SetProperty(ref _playerItemsDataView, value);
		}

		[Ordinal(40)] 
		[RED("vendorItemsDataView")] 
		public CHandle<VendorDataView> VendorItemsDataView
		{
			get => GetProperty(ref _vendorItemsDataView);
			set => SetProperty(ref _vendorItemsDataView, value);
		}

		[Ordinal(41)] 
		[RED("itemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> ItemsClassifier
		{
			get => GetProperty(ref _itemsClassifier);
			set => SetProperty(ref _itemsClassifier, value);
		}

		[Ordinal(42)] 
		[RED("totalBuyCost")] 
		public CFloat TotalBuyCost
		{
			get => GetProperty(ref _totalBuyCost);
			set => SetProperty(ref _totalBuyCost, value);
		}

		[Ordinal(43)] 
		[RED("totalSellCost")] 
		public CFloat TotalSellCost
		{
			get => GetProperty(ref _totalSellCost);
			set => SetProperty(ref _totalSellCost, value);
		}

		[Ordinal(44)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(45)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(46)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetProperty(ref _storageUserData);
			set => SetProperty(ref _storageUserData, value);
		}

		[Ordinal(47)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(48)] 
		[RED("sellJunkPopupToken")] 
		public CHandle<inkGameNotificationToken> SellJunkPopupToken
		{
			get => GetProperty(ref _sellJunkPopupToken);
			set => SetProperty(ref _sellJunkPopupToken, value);
		}

		[Ordinal(49)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(50)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetProperty(ref _confirmationPopupToken);
			set => SetProperty(ref _confirmationPopupToken, value);
		}

		[Ordinal(51)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetProperty(ref _itemPreviewPopupToken);
			set => SetProperty(ref _itemPreviewPopupToken, value);
		}

		[Ordinal(52)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(53)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetProperty(ref _vendorBlackboardDef);
			set => SetProperty(ref _vendorBlackboardDef, value);
		}

		[Ordinal(54)] 
		[RED("VendorUpdatedCallbackID")] 
		public CUInt32 VendorUpdatedCallbackID
		{
			get => GetProperty(ref _vendorUpdatedCallbackID);
			set => SetProperty(ref _vendorUpdatedCallbackID, value);
		}

		[Ordinal(55)] 
		[RED("craftingBlackboard")] 
		public CHandle<gameIBlackboard> CraftingBlackboard
		{
			get => GetProperty(ref _craftingBlackboard);
			set => SetProperty(ref _craftingBlackboard, value);
		}

		[Ordinal(56)] 
		[RED("craftingBlackboardDef")] 
		public CHandle<UI_CraftingDef> CraftingBlackboardDef
		{
			get => GetProperty(ref _craftingBlackboardDef);
			set => SetProperty(ref _craftingBlackboardDef, value);
		}

		[Ordinal(57)] 
		[RED("craftingCallbackID")] 
		public CUInt32 CraftingCallbackID
		{
			get => GetProperty(ref _craftingCallbackID);
			set => SetProperty(ref _craftingCallbackID, value);
		}

		[Ordinal(58)] 
		[RED("playerFilterManager")] 
		public CHandle<ItemCategoryFliterManager> PlayerFilterManager
		{
			get => GetProperty(ref _playerFilterManager);
			set => SetProperty(ref _playerFilterManager, value);
		}

		[Ordinal(59)] 
		[RED("vendorFilterManager")] 
		public CHandle<ItemCategoryFliterManager> VendorFilterManager
		{
			get => GetProperty(ref _vendorFilterManager);
			set => SetProperty(ref _vendorFilterManager, value);
		}

		[Ordinal(60)] 
		[RED("lastPlayerFilter")] 
		public CEnum<ItemFilterCategory> LastPlayerFilter
		{
			get => GetProperty(ref _lastPlayerFilter);
			set => SetProperty(ref _lastPlayerFilter, value);
		}

		[Ordinal(61)] 
		[RED("lastVendorFilter")] 
		public CEnum<ItemFilterCategory> LastVendorFilter
		{
			get => GetProperty(ref _lastVendorFilter);
			set => SetProperty(ref _lastVendorFilter, value);
		}

		[Ordinal(62)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(63)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(64)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetProperty(ref _storageDef);
			set => SetProperty(ref _storageDef, value);
		}

		[Ordinal(65)] 
		[RED("storageBlackboard")] 
		public CHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetProperty(ref _storageBlackboard);
			set => SetProperty(ref _storageBlackboard, value);
		}

		[Ordinal(66)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetProperty(ref _itemDropQueue);
			set => SetProperty(ref _itemDropQueue, value);
		}

		[Ordinal(67)] 
		[RED("soldItems")] 
		public CHandle<SoldItemsCache> SoldItems
		{
			get => GetProperty(ref _soldItems);
			set => SetProperty(ref _soldItems, value);
		}

		[Ordinal(68)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get => GetProperty(ref _isActivePanel);
			set => SetProperty(ref _isActivePanel, value);
		}

		[Ordinal(69)] 
		[RED("sellQueue")] 
		public CArray<gameItemID> SellQueue
		{
			get => GetProperty(ref _sellQueue);
			set => SetProperty(ref _sellQueue, value);
		}

		[Ordinal(70)] 
		[RED("buyQueue")] 
		public CArray<gameItemID> BuyQueue
		{
			get => GetProperty(ref _buyQueue);
			set => SetProperty(ref _buyQueue, value);
		}

		public FullscreenVendorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
