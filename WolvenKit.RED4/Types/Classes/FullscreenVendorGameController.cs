using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FullscreenVendorGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("playerFiltersContainer")] 
		public inkWidgetReference PlayerFiltersContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("vendorFiltersContainer")] 
		public inkWidgetReference VendorFiltersContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("inventoryGridList")] 
		public inkVirtualCompoundWidgetReference InventoryGridList
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("vendorSpecialOffersInventoryGridList")] 
		public inkCompoundWidgetReference VendorSpecialOffersInventoryGridList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("vendorInventoryGridList")] 
		public inkVirtualCompoundWidgetReference VendorInventoryGridList
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("playerInventoryGridScroll")] 
		public inkWidgetReference PlayerInventoryGridScroll
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("vendorInventoryGridScroll")] 
		public inkWidgetReference VendorInventoryGridScroll
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("emptyStock")] 
		public inkWidgetReference EmptyStock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("buyWrapper")] 
		public inkWidgetReference BuyWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("vendorMoney")] 
		public inkTextWidgetReference VendorMoney
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("vendorName")] 
		public inkTextWidgetReference VendorName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("playerMoney")] 
		public inkTextWidgetReference PlayerMoney
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("quantityPicker")] 
		public inkWidgetReference QuantityPicker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("playerSortingButton")] 
		public inkWidgetReference PlayerSortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("vendorSortingButton")] 
		public inkWidgetReference VendorSortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("playerBalance")] 
		public inkWidgetReference PlayerBalance
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("vendorBalance")] 
		public inkWidgetReference VendorBalance
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(25)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(26)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		[Ordinal(27)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(28)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(29)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(30)] 
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(31)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(32)] 
		[RED("playerInventoryitemControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> PlayerInventoryitemControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(33)] 
		[RED("vendorInventoryitemControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> VendorInventoryitemControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(34)] 
		[RED("vendorSpecialOfferInventoryitemControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> VendorSpecialOfferInventoryitemControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(35)] 
		[RED("playerDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> PlayerDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(36)] 
		[RED("virtualPlayerListController")] 
		public CWeakHandle<inkVirtualGridController> VirtualPlayerListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(37)] 
		[RED("vendorDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> VendorDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(38)] 
		[RED("virtualVendorListController")] 
		public CWeakHandle<inkVirtualGridController> VirtualVendorListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(39)] 
		[RED("playerItemsDataView")] 
		public CHandle<VendorDataView> PlayerItemsDataView
		{
			get => GetPropertyValue<CHandle<VendorDataView>>();
			set => SetPropertyValue<CHandle<VendorDataView>>(value);
		}

		[Ordinal(40)] 
		[RED("vendorItemsDataView")] 
		public CHandle<VendorDataView> VendorItemsDataView
		{
			get => GetPropertyValue<CHandle<VendorDataView>>();
			set => SetPropertyValue<CHandle<VendorDataView>>(value);
		}

		[Ordinal(41)] 
		[RED("itemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> ItemsClassifier
		{
			get => GetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>();
			set => SetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>(value);
		}

		[Ordinal(42)] 
		[RED("totalBuyCost")] 
		public CFloat TotalBuyCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("totalSellCost")] 
		public CFloat TotalSellCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(45)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetPropertyValue<CHandle<VendorUserData>>();
			set => SetPropertyValue<CHandle<VendorUserData>>(value);
		}

		[Ordinal(46)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetPropertyValue<CHandle<StorageUserData>>();
			set => SetPropertyValue<CHandle<StorageUserData>>(value);
		}

		[Ordinal(47)] 
		[RED("comparisonResolver")] 
		public CHandle<InventoryItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(48)] 
		[RED("sellJunkPopupToken")] 
		public CHandle<inkGameNotificationToken> SellJunkPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(49)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(50)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(51)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(52)] 
		[RED("VendorBlackboard")] 
		public CWeakHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(53)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_VendorDef>>();
			set => SetPropertyValue<CHandle<UI_VendorDef>>(value);
		}

		[Ordinal(54)] 
		[RED("VendorUpdatedCallbackID")] 
		public CHandle<redCallbackObject> VendorUpdatedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(55)] 
		[RED("craftingBlackboard")] 
		public CWeakHandle<gameIBlackboard> CraftingBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(56)] 
		[RED("craftingBlackboardDef")] 
		public CHandle<UI_CraftingDef> CraftingBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(57)] 
		[RED("craftingCallbackID")] 
		public CHandle<redCallbackObject> CraftingCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("InventoryBlackboard")] 
		public CWeakHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(59)] 
		[RED("InventoryCallback")] 
		public CHandle<UI_InventoryDef> InventoryCallback
		{
			get => GetPropertyValue<CHandle<UI_InventoryDef>>();
			set => SetPropertyValue<CHandle<UI_InventoryDef>>(value);
		}

		[Ordinal(60)] 
		[RED("InventoryAddedBBID")] 
		public CHandle<redCallbackObject> InventoryAddedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(61)] 
		[RED("InventoryRemovedBBID")] 
		public CHandle<redCallbackObject> InventoryRemovedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(62)] 
		[RED("playerFilterManager")] 
		public CHandle<ItemCategoryFliterManager> PlayerFilterManager
		{
			get => GetPropertyValue<CHandle<ItemCategoryFliterManager>>();
			set => SetPropertyValue<CHandle<ItemCategoryFliterManager>>(value);
		}

		[Ordinal(63)] 
		[RED("vendorFilterManager")] 
		public CHandle<ItemCategoryFliterManager> VendorFilterManager
		{
			get => GetPropertyValue<CHandle<ItemCategoryFliterManager>>();
			set => SetPropertyValue<CHandle<ItemCategoryFliterManager>>(value);
		}

		[Ordinal(64)] 
		[RED("lastPlayerFilter")] 
		public CEnum<ItemFilterCategory> LastPlayerFilter
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(65)] 
		[RED("lastVendorFilter")] 
		public CEnum<ItemFilterCategory> LastVendorFilter
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(66)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(67)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(68)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetPropertyValue<CHandle<StorageBlackboardDef>>();
			set => SetPropertyValue<CHandle<StorageBlackboardDef>>(value);
		}

		[Ordinal(69)] 
		[RED("storageBlackboard")] 
		public CWeakHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(70)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(71)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(73)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("lastRequestId")] 
		public CInt32 LastRequestId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(75)] 
		[RED("sellQueue")] 
		public CArray<CHandle<VenodrRequestQueueEntry>> SellQueue
		{
			get => GetPropertyValue<CArray<CHandle<VenodrRequestQueueEntry>>>();
			set => SetPropertyValue<CArray<CHandle<VenodrRequestQueueEntry>>>(value);
		}

		[Ordinal(76)] 
		[RED("buyQueue")] 
		public CArray<CHandle<VenodrRequestQueueEntry>> BuyQueue
		{
			get => GetPropertyValue<CArray<CHandle<VenodrRequestQueueEntry>>>();
			set => SetPropertyValue<CArray<CHandle<VenodrRequestQueueEntry>>>(value);
		}

		[Ordinal(77)] 
		[RED("boughtQuestItems")] 
		public CArray<CHandle<gameItemData>> BoughtQuestItems
		{
			get => GetPropertyValue<CArray<CHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CHandle<gameItemData>>>(value);
		}

		[Ordinal(78)] 
		[RED("vendorSoldItems")] 
		public CHandle<SoldItemsCache> VendorSoldItems
		{
			get => GetPropertyValue<CHandle<SoldItemsCache>>();
			set => SetPropertyValue<CHandle<SoldItemsCache>>(value);
		}

		[Ordinal(79)] 
		[RED("vendorUIInventoryItems")] 
		public CArray<CHandle<UIInventoryItem>> VendorUIInventoryItems
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItem>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItem>>>(value);
		}

		[Ordinal(80)] 
		[RED("playerItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> PlayerItemDisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(81)] 
		[RED("vendorItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> VendorItemDisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(82)] 
		[RED("transactionPending")] 
		public CBool TransactionPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(83)] 
		[RED("screenDisplayContext")] 
		public CEnum<ScreenDisplayContext> ScreenDisplayContext
		{
			get => GetPropertyValue<CEnum<ScreenDisplayContext>>();
			set => SetPropertyValue<CEnum<ScreenDisplayContext>>(value);
		}

		[Ordinal(84)] 
		[RED("globalSellInputPending")] 
		public CBool GlobalSellInputPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("isPopupPending")] 
		public CBool IsPopupPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(86)] 
		[RED("cursorData")] 
		public CHandle<MenuCursorUserData> CursorData
		{
			get => GetPropertyValue<CHandle<MenuCursorUserData>>();
			set => SetPropertyValue<CHandle<MenuCursorUserData>>(value);
		}

		[Ordinal(87)] 
		[RED("pressedItemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> PressedItemDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public FullscreenVendorGameController()
		{
			TooltipsManagerRef = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			PlayerFiltersContainer = new inkWidgetReference();
			VendorFiltersContainer = new inkWidgetReference();
			InventoryGridList = new inkVirtualCompoundWidgetReference();
			VendorSpecialOffersInventoryGridList = new inkCompoundWidgetReference();
			VendorInventoryGridList = new inkVirtualCompoundWidgetReference();
			PlayerInventoryGridScroll = new inkWidgetReference();
			VendorInventoryGridScroll = new inkWidgetReference();
			NotificationRoot = new inkWidgetReference();
			EmptyStock = new inkWidgetReference();
			BuyWrapper = new inkWidgetReference();
			VendorMoney = new inkTextWidgetReference();
			VendorName = new inkTextWidgetReference();
			PlayerMoney = new inkTextWidgetReference();
			QuantityPicker = new inkWidgetReference();
			PlayerSortingButton = new inkWidgetReference();
			VendorSortingButton = new inkWidgetReference();
			SortingDropdown = new inkWidgetReference();
			PlayerBalance = new inkWidgetReference();
			VendorBalance = new inkWidgetReference();
			ItemTypeSorting = new();
			PlayerInventoryitemControllers = new();
			VendorInventoryitemControllers = new();
			VendorSpecialOfferInventoryitemControllers = new();
			ItemDropQueue = new();
			SellQueue = new();
			BuyQueue = new();
			BoughtQuestItems = new();
			VendorUIInventoryItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
