using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingMainLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _root;
		private inkWidgetReference _itemDetailsContainer;
		private inkWidgetReference _leftListScrollHolder;
		private inkVirtualCompoundWidgetReference _virtualListContainer;
		private inkWidgetReference _filterGroup;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _tooltipContainer;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemQuality;
		private inkCompoundWidgetReference _progressBarContainer;
		private inkCompoundWidgetReference _progressButtonContainer;
		private inkTextWidgetReference _blockedText;
		private inkCompoundWidgetReference _ingredientsListContainer;
		private CEnum<UIMenuNotificationType> _notificationType;
		private CHandle<CraftingItemTemplateClassifier> _classifier;
		private CHandle<CraftingDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private wCHandle<inkVirtualGridController> _virtualListController;
		private wCHandle<inkScrollController> _leftListScrollController;
		private CArray<wCHandle<IngredientListItemLogicController>> _ingredientsControllerList;
		private CInt32 _maxIngredientCount;
		private CHandle<RecipeData> _selectedRecipe;
		private InventoryItemData _selectedItemData;
		private CBool _isCraftable;
		private CArray<CInt32> _filters;
		private wCHandle<ProgressBarButton> _progressButtonController;
		private wCHandle<InventoryItemDisplayController> _itemWeaponController;
		private wCHandle<InventoryItemDisplayController> _itemIngredientController;
		private CBool _doPlayFilterSounds;
		private wCHandle<CraftingMainGameController> _craftingGameController;
		private wCHandle<CraftingSystem> _craftingSystem;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<DropdownListController> _sortingController;
		private wCHandle<DropdownButtonController> _sortingButtonController;
		private CBool _isPanelOpen;

		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetProperty(ref _itemDetailsContainer);
			set => SetProperty(ref _itemDetailsContainer, value);
		}

		[Ordinal(3)] 
		[RED("leftListScrollHolder")] 
		public inkWidgetReference LeftListScrollHolder
		{
			get => GetProperty(ref _leftListScrollHolder);
			set => SetProperty(ref _leftListScrollHolder, value);
		}

		[Ordinal(4)] 
		[RED("virtualListContainer")] 
		public inkVirtualCompoundWidgetReference VirtualListContainer
		{
			get => GetProperty(ref _virtualListContainer);
			set => SetProperty(ref _virtualListContainer, value);
		}

		[Ordinal(5)] 
		[RED("filterGroup")] 
		public inkWidgetReference FilterGroup
		{
			get => GetProperty(ref _filterGroup);
			set => SetProperty(ref _filterGroup, value);
		}

		[Ordinal(6)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(7)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(8)] 
		[RED("tooltipContainer")] 
		public inkWidgetReference TooltipContainer
		{
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(9)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(10)] 
		[RED("itemQuality")] 
		public inkTextWidgetReference ItemQuality
		{
			get => GetProperty(ref _itemQuality);
			set => SetProperty(ref _itemQuality, value);
		}

		[Ordinal(11)] 
		[RED("progressBarContainer")] 
		public inkCompoundWidgetReference ProgressBarContainer
		{
			get => GetProperty(ref _progressBarContainer);
			set => SetProperty(ref _progressBarContainer, value);
		}

		[Ordinal(12)] 
		[RED("progressButtonContainer")] 
		public inkCompoundWidgetReference ProgressButtonContainer
		{
			get => GetProperty(ref _progressButtonContainer);
			set => SetProperty(ref _progressButtonContainer, value);
		}

		[Ordinal(13)] 
		[RED("blockedText")] 
		public inkTextWidgetReference BlockedText
		{
			get => GetProperty(ref _blockedText);
			set => SetProperty(ref _blockedText, value);
		}

		[Ordinal(14)] 
		[RED("ingredientsListContainer")] 
		public inkCompoundWidgetReference IngredientsListContainer
		{
			get => GetProperty(ref _ingredientsListContainer);
			set => SetProperty(ref _ingredientsListContainer, value);
		}

		[Ordinal(15)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(16)] 
		[RED("classifier")] 
		public CHandle<CraftingItemTemplateClassifier> Classifier
		{
			get => GetProperty(ref _classifier);
			set => SetProperty(ref _classifier, value);
		}

		[Ordinal(17)] 
		[RED("dataView")] 
		public CHandle<CraftingDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(18)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(19)] 
		[RED("virtualListController")] 
		public wCHandle<inkVirtualGridController> VirtualListController
		{
			get => GetProperty(ref _virtualListController);
			set => SetProperty(ref _virtualListController, value);
		}

		[Ordinal(20)] 
		[RED("leftListScrollController")] 
		public wCHandle<inkScrollController> LeftListScrollController
		{
			get => GetProperty(ref _leftListScrollController);
			set => SetProperty(ref _leftListScrollController, value);
		}

		[Ordinal(21)] 
		[RED("ingredientsControllerList")] 
		public CArray<wCHandle<IngredientListItemLogicController>> IngredientsControllerList
		{
			get => GetProperty(ref _ingredientsControllerList);
			set => SetProperty(ref _ingredientsControllerList, value);
		}

		[Ordinal(22)] 
		[RED("maxIngredientCount")] 
		public CInt32 MaxIngredientCount
		{
			get => GetProperty(ref _maxIngredientCount);
			set => SetProperty(ref _maxIngredientCount, value);
		}

		[Ordinal(23)] 
		[RED("selectedRecipe")] 
		public CHandle<RecipeData> SelectedRecipe
		{
			get => GetProperty(ref _selectedRecipe);
			set => SetProperty(ref _selectedRecipe, value);
		}

		[Ordinal(24)] 
		[RED("selectedItemData")] 
		public InventoryItemData SelectedItemData
		{
			get => GetProperty(ref _selectedItemData);
			set => SetProperty(ref _selectedItemData, value);
		}

		[Ordinal(25)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		[Ordinal(26)] 
		[RED("filters")] 
		public CArray<CInt32> Filters
		{
			get => GetProperty(ref _filters);
			set => SetProperty(ref _filters, value);
		}

		[Ordinal(27)] 
		[RED("progressButtonController")] 
		public wCHandle<ProgressBarButton> ProgressButtonController
		{
			get => GetProperty(ref _progressButtonController);
			set => SetProperty(ref _progressButtonController, value);
		}

		[Ordinal(28)] 
		[RED("itemWeaponController")] 
		public wCHandle<InventoryItemDisplayController> ItemWeaponController
		{
			get => GetProperty(ref _itemWeaponController);
			set => SetProperty(ref _itemWeaponController, value);
		}

		[Ordinal(29)] 
		[RED("itemIngredientController")] 
		public wCHandle<InventoryItemDisplayController> ItemIngredientController
		{
			get => GetProperty(ref _itemIngredientController);
			set => SetProperty(ref _itemIngredientController, value);
		}

		[Ordinal(30)] 
		[RED("doPlayFilterSounds")] 
		public CBool DoPlayFilterSounds
		{
			get => GetProperty(ref _doPlayFilterSounds);
			set => SetProperty(ref _doPlayFilterSounds, value);
		}

		[Ordinal(31)] 
		[RED("craftingGameController")] 
		public wCHandle<CraftingMainGameController> CraftingGameController
		{
			get => GetProperty(ref _craftingGameController);
			set => SetProperty(ref _craftingGameController, value);
		}

		[Ordinal(32)] 
		[RED("craftingSystem")] 
		public wCHandle<CraftingSystem> CraftingSystem
		{
			get => GetProperty(ref _craftingSystem);
			set => SetProperty(ref _craftingSystem, value);
		}

		[Ordinal(33)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(34)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(35)] 
		[RED("inventoryManager")] 
		public wCHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(36)] 
		[RED("sortingController")] 
		public wCHandle<DropdownListController> SortingController
		{
			get => GetProperty(ref _sortingController);
			set => SetProperty(ref _sortingController, value);
		}

		[Ordinal(37)] 
		[RED("sortingButtonController")] 
		public wCHandle<DropdownButtonController> SortingButtonController
		{
			get => GetProperty(ref _sortingButtonController);
			set => SetProperty(ref _sortingButtonController, value);
		}

		[Ordinal(38)] 
		[RED("isPanelOpen")] 
		public CBool IsPanelOpen
		{
			get => GetProperty(ref _isPanelOpen);
			set => SetProperty(ref _isPanelOpen, value);
		}

		public CraftingMainLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
