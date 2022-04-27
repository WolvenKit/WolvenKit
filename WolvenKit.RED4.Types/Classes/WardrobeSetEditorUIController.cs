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
		[RED("savebuttonText")] 
		public inkTextWidgetReference SavebuttonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("saveButton")] 
		public inkWidgetReference SaveButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("setSlotWidget")] 
		public inkWidgetReference SetSlotWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("setNameText")] 
		public inkTextWidgetReference SetNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemGridText")] 
		public inkTextWidgetReference ItemGridText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetPropertyValue<CHandle<ItemModeGridClassifier>>();
			set => SetPropertyValue<CHandle<ItemModeGridClassifier>>(value);
		}

		[Ordinal(8)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get => GetPropertyValue<CHandle<ItemModeGridView>>();
			set => SetPropertyValue<CHandle<ItemModeGridView>>(value);
		}

		[Ordinal(9)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(10)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(12)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(13)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(14)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(15)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(16)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategoryCreated>>>(value);
		}

		[Ordinal(17)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaCategory>>>(value);
		}

		[Ordinal(18)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetPropertyValue<CHandle<ItemPositionProvider>>();
			set => SetPropertyValue<CHandle<ItemPositionProvider>>(value);
		}

		[Ordinal(19)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(20)] 
		[RED("equipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("areaSlotControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> AreaSlotControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		[Ordinal(23)] 
		[RED("currentEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentEquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(24)] 
		[RED("currentItemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> CurrentItemDisplay
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(25)] 
		[RED("currentSet")] 
		public ClothingSet CurrentSet
		{
			get => GetPropertyValue<ClothingSet>();
			set => SetPropertyValue<ClothingSet>(value);
		}

		public WardrobeSetEditorUIController()
		{
			ItemsGridWidget = new();
			SavebuttonText = new();
			SaveButton = new();
			SetSlotWidget = new();
			SetNameText = new();
			ItemGridText = new();
			EquipmentAreaCategoryEventQueue = new();
			EquipmentAreaCategories = new();
			AreaSlotControllers = new();
			CurrentSet = new() { SetID = -1, ClothingList = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
