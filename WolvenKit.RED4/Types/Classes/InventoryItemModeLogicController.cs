using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemModeLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemCategoryList")] 
		public inkCompoundWidgetReference ItemCategoryList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("itemCategoryHeader")] 
		public inkTextWidgetReference ItemCategoryHeader
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("mainWrapper")] 
		public inkCompoundWidgetReference MainWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("emptyInventoryText")] 
		public inkTextWidgetReference EmptyInventoryText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("outfitsFilterInfoText")] 
		public inkTextWidgetReference OutfitsFilterInfoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("prevFilterHint")] 
		public inkWidgetReference PrevFilterHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("nextFilterHint")] 
		public inkWidgetReference NextFilterHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemGridContainer")] 
		public inkWidgetReference ItemGridContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemGridScrollControllerWidget")] 
		public inkWidgetReference ItemGridScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("wardrobeSlotsContainer")] 
		public inkWidgetReference WardrobeSlotsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("wardrobeSlotsLabel")] 
		public inkTextWidgetReference WardrobeSlotsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(15)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(17)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(18)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(19)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(20)] 
		[RED("wardrobeSystem")] 
		public CWeakHandle<gameWardrobeSystem> WardrobeSystem
		{
			get => GetPropertyValue<CWeakHandle<gameWardrobeSystem>>();
			set => SetPropertyValue<CWeakHandle<gameWardrobeSystem>>(value);
		}

		[Ordinal(21)] 
		[RED("itemChooser")] 
		public CWeakHandle<InventoryGenericItemChooser> ItemChooser
		{
			get => GetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>();
			set => SetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>(value);
		}

		[Ordinal(22)] 
		[RED("lastEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(23)] 
		[RED("currentHotkey")] 
		public CEnum<gameEHotkey> CurrentHotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(24)] 
		[RED("inventoryController")] 
		public CWeakHandle<gameuiInventoryGameController> InventoryController
		{
			get => GetPropertyValue<CWeakHandle<gameuiInventoryGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiInventoryGameController>>(value);
		}

		[Ordinal(25)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(26)] 
		[RED("equipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("itemModsBlackboard")] 
		public CWeakHandle<gameIBlackboard> ItemModsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(28)] 
		[RED("disassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(29)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("itemModsBlackboardCallback")] 
		public CHandle<redCallbackObject> ItemModsBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("itemModsUpgradeBlackboardCallback")] 
		public CHandle<redCallbackObject> ItemModsUpgradeBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("disassembleBlackboardCallback")] 
		public CHandle<redCallbackObject> DisassembleBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("equipmentInProgressCallback")] 
		public CHandle<redCallbackObject> EquipmentInProgressCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(35)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetPropertyValue<CHandle<ItemModeGridClassifier>>();
			set => SetPropertyValue<CHandle<ItemModeGridClassifier>>(value);
		}

		[Ordinal(36)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get => GetPropertyValue<CHandle<ItemModeGridView>>();
			set => SetPropertyValue<CHandle<ItemModeGridView>>(value);
		}

		[Ordinal(37)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(38)] 
		[RED("activeFilter")] 
		public CWeakHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<BackpackFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<BackpackFilterButtonController>>(value);
		}

		[Ordinal(39)] 
		[RED("filters")] 
		public CArray<CWeakHandle<BackpackFilterButtonController>> Filters
		{
			get => GetPropertyValue<CArray<CWeakHandle<BackpackFilterButtonController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<BackpackFilterButtonController>>>(value);
		}

		[Ordinal(40)] 
		[RED("filterManager")] 
		public CHandle<ItemCategoryFliterManager> FilterManager
		{
			get => GetPropertyValue<CHandle<ItemCategoryFliterManager>>();
			set => SetPropertyValue<CHandle<ItemCategoryFliterManager>>(value);
		}

		[Ordinal(41)] 
		[RED("currentFilterIndex")] 
		public CInt32 CurrentFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(42)] 
		[RED("savedFilter")] 
		public CEnum<ItemFilterCategory> SavedFilter
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(43)] 
		[RED("lastSelectedDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> LastSelectedDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(44)] 
		[RED("itemModeInventoryListenerCallback")] 
		public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<ItemModeInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<ItemModeInventoryListenerCallback>>(value);
		}

		[Ordinal(45)] 
		[RED("itemModeInventoryListener")] 
		public CHandle<gameInventoryScriptListener> ItemModeInventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(46)] 
		[RED("itemModeInventoryListenerRegistered")] 
		public CBool ItemModeInventoryListenerRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("itemGridContainerController")] 
		public CWeakHandle<ItemModeGridContainer> ItemGridContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemModeGridContainer>>();
			set => SetPropertyValue<CWeakHandle<ItemModeGridContainer>>(value);
		}

		[Ordinal(48)] 
		[RED("cyberwareGridContainerController")] 
		public CWeakHandle<ItemModeGridContainer> CyberwareGridContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemModeGridContainer>>();
			set => SetPropertyValue<CWeakHandle<ItemModeGridContainer>>(value);
		}

		[Ordinal(49)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(50)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(53)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(54)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(55)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(56)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("animContainer")] 
		public CHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CHandle<inGameMenuAnimContainer>>(value);
		}

		[Ordinal(58)] 
		[RED("lastNotificationType")] 
		public CEnum<UIMenuNotificationType> LastNotificationType
		{
			get => GetPropertyValue<CEnum<UIMenuNotificationType>>();
			set => SetPropertyValue<CEnum<UIMenuNotificationType>>(value);
		}

		[Ordinal(59)] 
		[RED("outfitWardrobeSpawned")] 
		public CBool OutfitWardrobeSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("wardrobeOutfitSlotControllers")] 
		public CArray<CWeakHandle<WardrobeOutfitSlotController>> WardrobeOutfitSlotControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<WardrobeOutfitSlotController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<WardrobeOutfitSlotController>>>(value);
		}

		[Ordinal(61)] 
		[RED("delayedItemEquippedRequested")] 
		public CBool DelayedItemEquippedRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("delaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(63)] 
		[RED("delayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(64)] 
		[RED("delayedOutfitCooldownResetCallbackId")] 
		public gameDelayID DelayedOutfitCooldownResetCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(65)] 
		[RED("timeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("outfitInCooldown")] 
		public CBool OutfitInCooldown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("outfitCooldownPeroid")] 
		public CFloat OutfitCooldownPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(68)] 
		[RED("tokenPopup")] 
		public CHandle<inkGameNotificationToken> TokenPopup
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(69)] 
		[RED("refreshRequested")] 
		public CBool RefreshRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("currentFilter")] 
		public CEnum<ItemFilterCategory> CurrentFilter
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(71)] 
		[RED("viewMode")] 
		public CEnum<ItemViewModes> ViewMode
		{
			get => GetPropertyValue<CEnum<ItemViewModes>>();
			set => SetPropertyValue<CEnum<ItemViewModes>>(value);
		}

		[Ordinal(72)] 
		[RED("currentItems")] 
		public CArray<CWeakHandle<WrappedInventoryItemData>> CurrentItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<WrappedInventoryItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<WrappedInventoryItemData>>>(value);
		}

		[Ordinal(73)] 
		[RED("previousSelectedItem")] 
		public CWeakHandle<InventoryItemDisplayController> PreviousSelectedItem
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(74)] 
		[RED("cursorData")] 
		public CHandle<MenuCursorUserData> CursorData
		{
			get => GetPropertyValue<CHandle<MenuCursorUserData>>();
			set => SetPropertyValue<CHandle<MenuCursorUserData>>(value);
		}

		[Ordinal(75)] 
		[RED("pressedItemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> PressedItemDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(76)] 
		[RED("virtualGridInitialized")] 
		public CBool VirtualGridInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("replaceModNotification")] 
		public CHandle<inkGameNotificationToken> ReplaceModNotification
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(78)] 
		[RED("installModData")] 
		public CHandle<InstallModConfirmationData> InstallModData
		{
			get => GetPropertyValue<CHandle<InstallModConfirmationData>>();
			set => SetPropertyValue<CHandle<InstallModConfirmationData>>(value);
		}

		[Ordinal(79)] 
		[RED("HACK_lastItemDisplayEvent")] 
		public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayClickEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayClickEvent>>(value);
		}

		public InventoryItemModeLogicController()
		{
			ItemCategoryList = new inkCompoundWidgetReference();
			ItemCategoryHeader = new inkTextWidgetReference();
			MainWrapper = new inkCompoundWidgetReference();
			EmptyInventoryText = new inkTextWidgetReference();
			FilterButtonsGrid = new inkCompoundWidgetReference();
			OutfitsFilterInfoText = new inkTextWidgetReference();
			PrevFilterHint = new inkWidgetReference();
			NextFilterHint = new inkWidgetReference();
			ItemGridContainer = new inkWidgetReference();
			ItemGridScrollControllerWidget = new inkWidgetReference();
			WardrobeSlotsContainer = new inkWidgetReference();
			WardrobeSlotsLabel = new inkTextWidgetReference();
			LastEquipmentAreas = new();
			CurrentHotkey = Enums.gameEHotkey.INVALID;
			Filters = new();
			ItemDropQueue = new();
			WardrobeOutfitSlotControllers = new();
			DelayedTimeoutCallbackId = new gameDelayID();
			DelayedOutfitCooldownResetCallbackId = new gameDelayID();
			TimeoutPeroid = 0.500000F;
			OutfitCooldownPeroid = 0.400000F;
			CurrentItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
