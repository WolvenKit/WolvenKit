using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("itemGridContainer")] 
		public inkWidgetReference ItemGridContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("cyberwareGridContainer")] 
		public inkWidgetReference CyberwareGridContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemGridScrollControllerWidget")] 
		public inkWidgetReference ItemGridScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(10)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(11)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(12)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(13)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(15)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(16)] 
		[RED("itemChooser")] 
		public CWeakHandle<InventoryGenericItemChooser> ItemChooser
		{
			get => GetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>();
			set => SetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>(value);
		}

		[Ordinal(17)] 
		[RED("lastEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(18)] 
		[RED("currentHotkey")] 
		public CEnum<gameEHotkey> CurrentHotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(19)] 
		[RED("inventoryController")] 
		public CWeakHandle<gameuiInventoryGameController> InventoryController
		{
			get => GetPropertyValue<CWeakHandle<gameuiInventoryGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiInventoryGameController>>(value);
		}

		[Ordinal(20)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(21)] 
		[RED("equipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("itemModsBlackboard")] 
		public CWeakHandle<gameIBlackboard> ItemModsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(23)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("itemModsBlackboardCallback")] 
		public CHandle<redCallbackObject> ItemModsBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetPropertyValue<CHandle<ItemModeGridClassifier>>();
			set => SetPropertyValue<CHandle<ItemModeGridClassifier>>(value);
		}

		[Ordinal(26)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get => GetPropertyValue<CHandle<ItemModeGridView>>();
			set => SetPropertyValue<CHandle<ItemModeGridView>>(value);
		}

		[Ordinal(27)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(28)] 
		[RED("activeFilter")] 
		public CWeakHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<BackpackFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<BackpackFilterButtonController>>(value);
		}

		[Ordinal(29)] 
		[RED("filterManager")] 
		public CHandle<ItemCategoryFliterManager> FilterManager
		{
			get => GetPropertyValue<CHandle<ItemCategoryFliterManager>>();
			set => SetPropertyValue<CHandle<ItemCategoryFliterManager>>(value);
		}

		[Ordinal(30)] 
		[RED("savedFilter")] 
		public CEnum<ItemFilterCategory> SavedFilter
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(31)] 
		[RED("lastSelectedDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> LastSelectedDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(32)] 
		[RED("itemModeInventoryListenerCallback")] 
		public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<ItemModeInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<ItemModeInventoryListenerCallback>>(value);
		}

		[Ordinal(33)] 
		[RED("itemModeInventoryListener")] 
		public CHandle<gameInventoryScriptListener> ItemModeInventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(34)] 
		[RED("itemModeInventoryListenerRegistered")] 
		public CBool ItemModeInventoryListenerRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("itemGridContainerController")] 
		public CWeakHandle<ItemModeGridContainer> ItemGridContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemModeGridContainer>>();
			set => SetPropertyValue<CWeakHandle<ItemModeGridContainer>>(value);
		}

		[Ordinal(36)] 
		[RED("cyberwareGridContainerController")] 
		public CWeakHandle<ItemModeGridContainer> CyberwareGridContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemModeGridContainer>>();
			set => SetPropertyValue<CWeakHandle<ItemModeGridContainer>>(value);
		}

		[Ordinal(37)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(38)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(41)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(42)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(43)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("replaceModNotification")] 
		public CHandle<inkGameNotificationToken> ReplaceModNotification
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(45)] 
		[RED("installModData")] 
		public CHandle<InstallModConfirmationData> InstallModData
		{
			get => GetPropertyValue<CHandle<InstallModConfirmationData>>();
			set => SetPropertyValue<CHandle<InstallModConfirmationData>>(value);
		}

		[Ordinal(46)] 
		[RED("HACK_lastItemDisplayEvent")] 
		public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayClickEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayClickEvent>>(value);
		}

		public InventoryItemModeLogicController()
		{
			ItemCategoryList = new();
			ItemCategoryHeader = new();
			MainWrapper = new();
			EmptyInventoryText = new();
			FilterButtonsGrid = new();
			ItemGridContainer = new();
			CyberwareGridContainer = new();
			ItemGridScrollControllerWidget = new();
			LastEquipmentAreas = new();
			CurrentHotkey = Enums.gameEHotkey.INVALID;
			ItemDropQueue = new();
		}
	}
}
