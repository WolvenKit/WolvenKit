using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBackpackMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("commonCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference CommonCraftingMaterialsGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hackingCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference HackingCraftingMaterialsGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("virtualItemsGrid")] 
		public inkVirtualCompoundWidgetReference VirtualItemsGrid
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("disassembleJunkButton")] 
		public inkWidgetReference DisassembleJunkButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("virtualBackpackItemsListController")] 
		public CWeakHandle<inkGridController> VirtualBackpackItemsListController
		{
			get => GetPropertyValue<CWeakHandle<inkGridController>>();
			set => SetPropertyValue<CWeakHandle<inkGridController>>(value);
		}

		[Ordinal(15)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(17)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(18)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(19)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(20)] 
		[RED("itemDropQueueItems")] 
		public CArray<gameItemID> ItemDropQueueItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(21)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(22)] 
		[RED("junkItems")] 
		public CArray<CHandle<UIInventoryItem>> JunkItems
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItem>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItem>>>(value);
		}

		[Ordinal(23)] 
		[RED("isRefreshUIScheduled")] 
		public CBool IsRefreshUIScheduled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<CWeakHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>(value);
		}

		[Ordinal(25)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(26)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(29)] 
		[RED("EquippedBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquippedBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(30)] 
		[RED("EquippedBBID")] 
		public CHandle<redCallbackObject> EquippedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("InventoryCallback")] 
		public CHandle<UI_InventoryDef> InventoryCallback
		{
			get => GetPropertyValue<CHandle<UI_InventoryDef>>();
			set => SetPropertyValue<CHandle<UI_InventoryDef>>(value);
		}

		[Ordinal(32)] 
		[RED("InventoryBlackboard")] 
		public CWeakHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("InventoryItemAddedBBID")] 
		public CHandle<redCallbackObject> InventoryItemAddedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("InventoryItemRemvoedBBID")] 
		public CHandle<redCallbackObject> InventoryItemRemvoedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("InventoryItemQuantityChangedBBID")] 
		public CHandle<redCallbackObject> InventoryItemQuantityChangedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(37)] 
		[RED("activeFilter")] 
		public CWeakHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<BackpackFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<BackpackFilterButtonController>>(value);
		}

		[Ordinal(38)] 
		[RED("filterSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> FilterSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(39)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(40)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get => GetPropertyValue<CHandle<BackpackDataView>>();
			set => SetPropertyValue<CHandle<BackpackDataView>>(value);
		}

		[Ordinal(41)] 
		[RED("comparisonResolver")] 
		public CHandle<InventoryItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(42)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<BackpackInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<BackpackInventoryListenerCallback>>(value);
		}

		[Ordinal(43)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(44)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get => GetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>();
			set => SetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>(value);
		}

		[Ordinal(45)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(46)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(47)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(48)] 
		[RED("disassembleJunkPopupToken")] 
		public CHandle<inkGameNotificationToken> DisassembleJunkPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(49)] 
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(51)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(52)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(53)] 
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(54)] 
		[RED("itemDisplayContext")] 
		public CHandle<ItemDisplayContextData> ItemDisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(55)] 
		[RED("comparedItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> ComparedItemDisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(56)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(57)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(58)] 
		[RED("isComparisonDisabled")] 
		public CBool IsComparisonDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("immediateNotificationListener")] 
		public CHandle<BakcpackImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetPropertyValue<CHandle<BakcpackImmediateNotificationListener>>();
			set => SetPropertyValue<CHandle<BakcpackImmediateNotificationListener>>(value);
		}

		[Ordinal(60)] 
		[RED("lastDisassembledWidget")] 
		public CWeakHandle<InventoryItemDisplayController> LastDisassembledWidget
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(61)] 
		[RED("cursorData")] 
		public CHandle<MenuCursorUserData> CursorData
		{
			get => GetPropertyValue<CHandle<MenuCursorUserData>>();
			set => SetPropertyValue<CHandle<MenuCursorUserData>>(value);
		}

		[Ordinal(62)] 
		[RED("pressedItemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> PressedItemDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(63)] 
		[RED("delayedOutfitCooldownResetCallbackId")] 
		public gameDelayID DelayedOutfitCooldownResetCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(64)] 
		[RED("outfitInCooldown")] 
		public CBool OutfitInCooldown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("outfitCooldownPeroid")] 
		public CFloat OutfitCooldownPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("virtualWidgets")] 
		public CHandle<inkScriptWeakHashMap> VirtualWidgets
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(67)] 
		[RED("allWidgets")] 
		public CHandle<inkScriptWeakHashMap> AllWidgets
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(68)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(69)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiBackpackMainGameController()
		{
			CommonCraftingMaterialsGrid = new inkCompoundWidgetReference();
			HackingCraftingMaterialsGrid = new inkCompoundWidgetReference();
			FilterButtonsGrid = new inkCompoundWidgetReference();
			VirtualItemsGrid = new inkVirtualCompoundWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			SortingButton = new inkWidgetReference();
			SortingDropdown = new inkWidgetReference();
			ItemsListScrollAreaContainer = new inkWidgetReference();
			ItemNotificationRoot = new inkWidgetReference();
			DisassembleJunkButton = new inkWidgetReference();
			ItemTypeSorting = new();
			ItemDropQueueItems = new();
			ItemDropQueue = new();
			JunkItems = new();
			CraftingMaterialsListItems = new();
			FilterSpawnRequests = new();
			DelayedOutfitCooldownResetCallbackId = new gameDelayID();
			OutfitCooldownPeroid = 0.400000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
