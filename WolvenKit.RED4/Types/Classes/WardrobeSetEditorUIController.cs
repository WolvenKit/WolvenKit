using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeSetEditorUIController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemsGridWidget")] 
		public inkWidgetReference ItemsGridWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("itemGridText")] 
		public inkTextWidgetReference ItemGridText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hideFaceButton")] 
		public inkWidgetReference HideFaceButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("hideHeadButton")] 
		public inkWidgetReference HideHeadButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("emptyGridText")] 
		public inkWidgetReference EmptyGridText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("wearButton")] 
		public inkWidgetReference WearButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("takeOffButton")] 
		public inkWidgetReference TakeOffButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetPropertyValue<CHandle<ItemModeGridClassifier>>();
			set => SetPropertyValue<CHandle<ItemModeGridClassifier>>(value);
		}

		[Ordinal(12)] 
		[RED("itemGridDataView")] 
		public CHandle<WardrobeItemGridView> ItemGridDataView
		{
			get => GetPropertyValue<CHandle<WardrobeItemGridView>>();
			set => SetPropertyValue<CHandle<WardrobeItemGridView>>(value);
		}

		[Ordinal(13)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(14)] 
		[RED("tooltipsManager")] 
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
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(17)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(18)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(19)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(20)] 
		[RED("wardrobeSystem")] 
		public CWeakHandle<gameWardrobeSystem> WardrobeSystem
		{
			get => GetPropertyValue<CWeakHandle<gameWardrobeSystem>>();
			set => SetPropertyValue<CWeakHandle<gameWardrobeSystem>>(value);
		}

		[Ordinal(21)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>(value);
		}

		[Ordinal(22)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>(value);
		}

		[Ordinal(23)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(24)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(25)] 
		[RED("wardrobeGameController")] 
		public CWeakHandle<WardrobeUIGameController> WardrobeGameController
		{
			get => GetPropertyValue<CWeakHandle<WardrobeUIGameController>>();
			set => SetPropertyValue<CWeakHandle<WardrobeUIGameController>>(value);
		}

		[Ordinal(26)] 
		[RED("areaSlotControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> AreaSlotControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(27)] 
		[RED("hiddenEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> HiddenEquipmentAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(28)] 
		[RED("currentEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentEquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(29)] 
		[RED("currentSet")] 
		public CHandle<gameClothingSet> CurrentSet
		{
			get => GetPropertyValue<CHandle<gameClothingSet>>();
			set => SetPropertyValue<CHandle<gameClothingSet>>(value);
		}

		[Ordinal(30)] 
		[RED("setButtonController")] 
		public CWeakHandle<ClothingSetController> SetButtonController
		{
			get => GetPropertyValue<CWeakHandle<ClothingSetController>>();
			set => SetPropertyValue<CWeakHandle<ClothingSetController>>(value);
		}

		[Ordinal(31)] 
		[RED("previewController")] 
		public CWeakHandle<gameuiWardrobeSetPreviewGameController> PreviewController
		{
			get => GetPropertyValue<CWeakHandle<gameuiWardrobeSetPreviewGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiWardrobeSetPreviewGameController>>(value);
		}

		[Ordinal(32)] 
		[RED("delaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(33)] 
		[RED("delayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(34)] 
		[RED("timeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WardrobeSetEditorUIController()
		{
			ItemsGridWidget = new();
			ItemGridText = new();
			SortingDropdown = new();
			SortingButton = new();
			HideFaceButton = new();
			HideHeadButton = new();
			EmptyGridText = new();
			WearButton = new();
			TakeOffButton = new();
			ResetButton = new();
			EquipmentAreaCategoryEventQueue = new();
			EquipmentAreaCategories = new();
			AreaSlotControllers = new();
			HiddenEquipmentAreas = new();
			DelayedTimeoutCallbackId = new();
			TimeoutPeroid = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
