using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetPropertyValue<CArray<gameItemModParams>>();
			set => SetPropertyValue<CArray<gameItemModParams>>(value);
		}

		[Ordinal(20)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<CWeakHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CrafringMaterialItemController>>>(value);
		}

		[Ordinal(21)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(22)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(23)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(25)] 
		[RED("EquippedBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquippedBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("EquippedBBID")] 
		public CHandle<redCallbackObject> EquippedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(28)] 
		[RED("activeFilter")] 
		public CWeakHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<BackpackFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<BackpackFilterButtonController>>(value);
		}

		[Ordinal(29)] 
		[RED("filterSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> FilterSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(30)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(31)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get => GetPropertyValue<CHandle<BackpackDataView>>();
			set => SetPropertyValue<CHandle<BackpackDataView>>(value);
		}

		[Ordinal(32)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(33)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<BackpackInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<BackpackInventoryListenerCallback>>(value);
		}

		[Ordinal(34)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(35)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get => GetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>();
			set => SetPropertyValue<CHandle<ItemDisplayTemplateClassifier>>(value);
		}

		[Ordinal(36)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(37)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(38)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(39)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(42)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(43)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(44)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(45)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>();
			set => SetPropertyValue<CHandle<ItemDisplayHoverOverEvent>>(value);
		}

		[Ordinal(46)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(48)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiBackpackMainGameController()
		{
			CommonCraftingMaterialsGrid = new();
			HackingCraftingMaterialsGrid = new();
			FilterButtonsGrid = new();
			VirtualItemsGrid = new();
			TooltipsManagerRef = new();
			ButtonHintsManagerRef = new();
			SortingButton = new();
			SortingDropdown = new();
			ItemsListScrollAreaContainer = new();
			ItemNotificationRoot = new();
			ItemTypeSorting = new();
			ItemDropQueue = new();
			CraftingMaterialsListItems = new();
			FilterSpawnRequests = new();
		}
	}
}
