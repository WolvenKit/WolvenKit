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
		[RED("virtualBackpackItemsListController")] 
		public CWeakHandle<inkGridController> VirtualBackpackItemsListController
		{
			get => GetPropertyValue<CWeakHandle<inkGridController>>();
			set => SetPropertyValue<CWeakHandle<inkGridController>>(value);
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(15)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(16)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(17)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(18)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(19)] 
		[RED("itemDropQueueItems")] 
		public CArray<gameItemID> ItemDropQueueItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(20)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(21)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<CWeakHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>(value);
		}

		[Ordinal(22)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(23)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(24)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(26)] 
		[RED("EquippedBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquippedBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("EquippedBBID")] 
		public CHandle<redCallbackObject> EquippedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("InventoryCallback")] 
		public CHandle<UI_InventoryDef> InventoryCallback
		{
			get => GetPropertyValue<CHandle<UI_InventoryDef>>();
			set => SetPropertyValue<CHandle<UI_InventoryDef>>(value);
		}

		[Ordinal(29)] 
		[RED("InventoryBlackboard")] 
		public CWeakHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(30)] 
		[RED("InventoryBBID")] 
		public CHandle<redCallbackObject> InventoryBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(32)] 
		[RED("activeFilter")] 
		public CWeakHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<BackpackFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<BackpackFilterButtonController>>(value);
		}

		[Ordinal(33)] 
		[RED("filterSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> FilterSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(34)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(35)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get => GetPropertyValue<CHandle<BackpackDataView>>();
			set => SetPropertyValue<CHandle<BackpackDataView>>(value);
		}

		[Ordinal(36)] 
		[RED("comparisonResolver")] 
		public CHandle<InventoryItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<InventoryItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(37)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<BackpackInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<BackpackInventoryListenerCallback>>(value);
		}

		[Ordinal(38)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(39)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get => GetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>();
			set => SetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>(value);
		}

		[Ordinal(40)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(41)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(42)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(43)] 
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(45)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(46)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(47)] 
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(48)] 
		[RED("itemDisplayContext")] 
		public CHandle<ItemDisplayContextData> ItemDisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(49)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(50)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(51)] 
		[RED("isComparisonDisabled")] 
		public CBool IsComparisonDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("immediateNotificationListener")] 
		public CHandle<BakcpackImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetPropertyValue<CHandle<BakcpackImmediateNotificationListener>>();
			set => SetPropertyValue<CHandle<BakcpackImmediateNotificationListener>>(value);
		}

		[Ordinal(53)] 
		[RED("virtualWidgets")] 
		public CHandle<inkScriptWeakHashMap> VirtualWidgets
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(54)] 
		[RED("allWidgets")] 
		public CHandle<inkScriptWeakHashMap> AllWidgets
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(55)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(56)] 
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
			ItemTypeSorting = new();
			ItemDropQueueItems = new();
			ItemDropQueue = new();
			CraftingMaterialsListItems = new();
			FilterSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
