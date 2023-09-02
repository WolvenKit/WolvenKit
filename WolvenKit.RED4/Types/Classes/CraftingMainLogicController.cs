using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingMainLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("leftListScrollHolder")] 
		public inkWidgetReference LeftListScrollHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("virtualListContainer")] 
		public inkVirtualCompoundWidgetReference VirtualListContainer
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("filterGroup")] 
		public inkWidgetReference FilterGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("tooltipContainer")] 
		public inkWidgetReference TooltipContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemQuality")] 
		public inkTextWidgetReference ItemQuality
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("progressBarContainer")] 
		public inkCompoundWidgetReference ProgressBarContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("progressButtonContainer")] 
		public inkCompoundWidgetReference ProgressButtonContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("blockedText")] 
		public inkTextWidgetReference BlockedText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("ingredientsListContainer")] 
		public inkCompoundWidgetReference IngredientsListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<UIMenuNotificationType>>();
			set => SetPropertyValue<CEnum<UIMenuNotificationType>>(value);
		}

		[Ordinal(16)] 
		[RED("classifier")] 
		public CHandle<CraftingItemTemplateClassifier> Classifier
		{
			get => GetPropertyValue<CHandle<CraftingItemTemplateClassifier>>();
			set => SetPropertyValue<CHandle<CraftingItemTemplateClassifier>>(value);
		}

		[Ordinal(17)] 
		[RED("dataView")] 
		public CHandle<CraftingDataView> DataView
		{
			get => GetPropertyValue<CHandle<CraftingDataView>>();
			set => SetPropertyValue<CHandle<CraftingDataView>>(value);
		}

		[Ordinal(18)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(19)] 
		[RED("virtualListController")] 
		public CWeakHandle<inkVirtualGridController> VirtualListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(20)] 
		[RED("leftListScrollController")] 
		public CWeakHandle<inkScrollController> LeftListScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(21)] 
		[RED("ingredientsControllerList")] 
		public CArray<CWeakHandle<IngredientListItemLogicController>> IngredientsControllerList
		{
			get => GetPropertyValue<CArray<CWeakHandle<IngredientListItemLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<IngredientListItemLogicController>>>(value);
		}

		[Ordinal(22)] 
		[RED("maxIngredientCount")] 
		public CInt32 MaxIngredientCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("selectedRecipe")] 
		public CHandle<RecipeData> SelectedRecipe
		{
			get => GetPropertyValue<CHandle<RecipeData>>();
			set => SetPropertyValue<CHandle<RecipeData>>(value);
		}

		[Ordinal(24)] 
		[RED("selectedItemData")] 
		public gameInventoryItemData SelectedItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(25)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("filters")] 
		public CArray<CInt32> Filters
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(27)] 
		[RED("progressButtonController")] 
		public CWeakHandle<ProgressBarButton> ProgressButtonController
		{
			get => GetPropertyValue<CWeakHandle<ProgressBarButton>>();
			set => SetPropertyValue<CWeakHandle<ProgressBarButton>>(value);
		}

		[Ordinal(28)] 
		[RED("itemWeaponController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemWeaponController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(29)] 
		[RED("itemIngredientController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemIngredientController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(30)] 
		[RED("doPlayFilterSounds")] 
		public CBool DoPlayFilterSounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("craftingGameController")] 
		public CWeakHandle<CraftingMainGameController> CraftingGameController
		{
			get => GetPropertyValue<CWeakHandle<CraftingMainGameController>>();
			set => SetPropertyValue<CWeakHandle<CraftingMainGameController>>(value);
		}

		[Ordinal(32)] 
		[RED("craftingSystem")] 
		public CWeakHandle<CraftingSystem> CraftingSystem
		{
			get => GetPropertyValue<CWeakHandle<CraftingSystem>>();
			set => SetPropertyValue<CWeakHandle<CraftingSystem>>(value);
		}

		[Ordinal(33)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(34)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(35)] 
		[RED("inventoryManager")] 
		public CWeakHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CWeakHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CWeakHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(36)] 
		[RED("sortingController")] 
		public CWeakHandle<DropdownListController> SortingController
		{
			get => GetPropertyValue<CWeakHandle<DropdownListController>>();
			set => SetPropertyValue<CWeakHandle<DropdownListController>>(value);
		}

		[Ordinal(37)] 
		[RED("sortingButtonController")] 
		public CWeakHandle<DropdownButtonController> SortingButtonController
		{
			get => GetPropertyValue<CWeakHandle<DropdownButtonController>>();
			set => SetPropertyValue<CWeakHandle<DropdownButtonController>>(value);
		}

		[Ordinal(38)] 
		[RED("isPanelOpen")] 
		public CBool IsPanelOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CraftingMainLogicController()
		{
			Root = new inkWidgetReference();
			ItemDetailsContainer = new inkWidgetReference();
			LeftListScrollHolder = new inkWidgetReference();
			VirtualListContainer = new inkVirtualCompoundWidgetReference();
			FilterGroup = new inkWidgetReference();
			SortingButton = new inkWidgetReference();
			SortingDropdown = new inkWidgetReference();
			TooltipContainer = new inkWidgetReference();
			ItemName = new inkTextWidgetReference();
			ItemQuality = new inkTextWidgetReference();
			ProgressBarContainer = new inkCompoundWidgetReference();
			ProgressButtonContainer = new inkCompoundWidgetReference();
			BlockedText = new inkTextWidgetReference();
			IngredientsListContainer = new inkCompoundWidgetReference();
			IngredientsControllerList = new();
			SelectedItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			Filters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
