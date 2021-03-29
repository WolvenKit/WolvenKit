using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _leftListScrollHolder;
		private inkVirtualCompoundWidgetReference _recipeGrid;
		private inkCompoundWidgetReference _skillWidgetRoot;
		private inkWidgetReference _filterRoot_Crafting;
		private inkWidgetReference _filterGroup_Crafting;
		private inkWidgetReference _sortingButton_Crafting;
		private inkWidgetReference _sortingDropdown_Crafting;
		private inkCompoundWidgetReference _craftingRoot;
		private inkTextWidgetReference _itemName_Crafting;
		private inkTextWidgetReference _itemQuality_Crafting;
		private inkCompoundWidgetReference _ingredientsList_Crafting;
		private inkCompoundWidgetReference _ingredientsListWeapon;
		private inkWidgetReference _itemPreviewContainer;
		private inkWidgetReference _weaponPreviewContainer;
		private inkCompoundWidgetReference _progressBarContainer_Crafting;
		private inkCompoundWidgetReference _progressButtonContainer_Crafting;
		private inkCompoundWidgetReference _tooltipContainer_Crafting;
		private inkWidgetReference _filterRoot_Upgrading;
		private inkWidgetReference _filterGroup_Upgrading;
		private inkWidgetReference _sortingButton_Upgrading;
		private inkWidgetReference _sortingDropdown_Upgrading;
		private inkCompoundWidgetReference _upgradingRoot;
		private inkTextWidgetReference _itemName_Upgrading;
		private inkTextWidgetReference _itemQuality_Upgrading;
		private inkCompoundWidgetReference _ingredientsList_Upgrading;
		private inkCompoundWidgetReference _progressBarContainer_Upgrading;
		private inkCompoundWidgetReference _progressButtonContainer_Upgrading;
		private inkCompoundWidgetReference _tooltipContainer_Upgrading;
		private inkTextWidgetReference _blockedText;
		private inkWidgetReference _perkNotificationContainer;
		private inkTextWidgetReference _perkNotificationText;
		private inkImageWidgetReference _perkIcon;
		private CEnum<UIMenuNotificationType> _notificationType;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<CraftingSystem> _craftingSystem;
		private CHandle<CraftBook> _playerCraftBook;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<CraftingItemTemplateClassifier> _craftingClassifier;
		private CHandle<CraftingDataView> _craftingDataView;
		private CHandle<inkScriptableDataSourceWrapper> _craftingDataSource;
		private CHandle<inkVirtualGridController> _virtualCraftingListController;
		private CHandle<inkScrollController> _leftListScrollController;
		private CHandle<UI_CraftingDef> _craftingDef;
		private CHandle<gameIBlackboard> _craftingBlackboard;
		private CUInt32 _craftingBBID;
		private CArray<wCHandle<IngredientListItemLogicController>> _ingredientsControllerList;
		private CInt32 _maxIngredientCraftingCount;
		private CInt32 _maxIngredientUpgradingCount;
		private CEnum<CraftingMode> _mode;
		private CHandle<RecipeData> _selectedRecipe;
		private InventoryItemData _selectedItemData;
		private CHandle<CraftableItemLogicController> _selectedListItem;
		private CEnum<ItemFilterType> _selectedCategory;
		private CHandle<gameItemData> _dryItemData;
		private InventoryItemData _dryInventoryItemData;
		private CBool _isInitializeOver;
		private CBool _isCraftable;
		private CArray<CInt32> _craftingFilters;
		private CArray<CInt32> _upgradeFilters;
		private CArray<wCHandle<AGenericTooltipController>> _itemTooltipControllers;
		private CEnum<CraftingInfoType> _tooltipType;
		private wCHandle<ProgressBarButton> _progressButtonController;
		private wCHandle<InventoryItemDisplayController> _itemWeaponController;
		private wCHandle<InventoryItemDisplayController> _itemIngredientController;
		private CArray<InventoryItemData> _inventoryQuickhacks;
		private CBool _doPlayFilterSounds;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetProperty(ref _tabRootRef);
			set => SetProperty(ref _tabRootRef, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("leftListScrollHolder")] 
		public inkWidgetReference LeftListScrollHolder
		{
			get => GetProperty(ref _leftListScrollHolder);
			set => SetProperty(ref _leftListScrollHolder, value);
		}

		[Ordinal(7)] 
		[RED("recipeGrid")] 
		public inkVirtualCompoundWidgetReference RecipeGrid
		{
			get => GetProperty(ref _recipeGrid);
			set => SetProperty(ref _recipeGrid, value);
		}

		[Ordinal(8)] 
		[RED("skillWidgetRoot")] 
		public inkCompoundWidgetReference SkillWidgetRoot
		{
			get => GetProperty(ref _skillWidgetRoot);
			set => SetProperty(ref _skillWidgetRoot, value);
		}

		[Ordinal(9)] 
		[RED("filterRoot_Crafting")] 
		public inkWidgetReference FilterRoot_Crafting
		{
			get => GetProperty(ref _filterRoot_Crafting);
			set => SetProperty(ref _filterRoot_Crafting, value);
		}

		[Ordinal(10)] 
		[RED("filterGroup_Crafting")] 
		public inkWidgetReference FilterGroup_Crafting
		{
			get => GetProperty(ref _filterGroup_Crafting);
			set => SetProperty(ref _filterGroup_Crafting, value);
		}

		[Ordinal(11)] 
		[RED("sortingButton_Crafting")] 
		public inkWidgetReference SortingButton_Crafting
		{
			get => GetProperty(ref _sortingButton_Crafting);
			set => SetProperty(ref _sortingButton_Crafting, value);
		}

		[Ordinal(12)] 
		[RED("sortingDropdown_Crafting")] 
		public inkWidgetReference SortingDropdown_Crafting
		{
			get => GetProperty(ref _sortingDropdown_Crafting);
			set => SetProperty(ref _sortingDropdown_Crafting, value);
		}

		[Ordinal(13)] 
		[RED("craftingRoot")] 
		public inkCompoundWidgetReference CraftingRoot
		{
			get => GetProperty(ref _craftingRoot);
			set => SetProperty(ref _craftingRoot, value);
		}

		[Ordinal(14)] 
		[RED("itemName_Crafting")] 
		public inkTextWidgetReference ItemName_Crafting
		{
			get => GetProperty(ref _itemName_Crafting);
			set => SetProperty(ref _itemName_Crafting, value);
		}

		[Ordinal(15)] 
		[RED("itemQuality_Crafting")] 
		public inkTextWidgetReference ItemQuality_Crafting
		{
			get => GetProperty(ref _itemQuality_Crafting);
			set => SetProperty(ref _itemQuality_Crafting, value);
		}

		[Ordinal(16)] 
		[RED("ingredientsList_Crafting")] 
		public inkCompoundWidgetReference IngredientsList_Crafting
		{
			get => GetProperty(ref _ingredientsList_Crafting);
			set => SetProperty(ref _ingredientsList_Crafting, value);
		}

		[Ordinal(17)] 
		[RED("ingredientsListWeapon")] 
		public inkCompoundWidgetReference IngredientsListWeapon
		{
			get => GetProperty(ref _ingredientsListWeapon);
			set => SetProperty(ref _ingredientsListWeapon, value);
		}

		[Ordinal(18)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get => GetProperty(ref _itemPreviewContainer);
			set => SetProperty(ref _itemPreviewContainer, value);
		}

		[Ordinal(19)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get => GetProperty(ref _weaponPreviewContainer);
			set => SetProperty(ref _weaponPreviewContainer, value);
		}

		[Ordinal(20)] 
		[RED("progressBarContainer_Crafting")] 
		public inkCompoundWidgetReference ProgressBarContainer_Crafting
		{
			get => GetProperty(ref _progressBarContainer_Crafting);
			set => SetProperty(ref _progressBarContainer_Crafting, value);
		}

		[Ordinal(21)] 
		[RED("progressButtonContainer_Crafting")] 
		public inkCompoundWidgetReference ProgressButtonContainer_Crafting
		{
			get => GetProperty(ref _progressButtonContainer_Crafting);
			set => SetProperty(ref _progressButtonContainer_Crafting, value);
		}

		[Ordinal(22)] 
		[RED("tooltipContainer_Crafting")] 
		public inkCompoundWidgetReference TooltipContainer_Crafting
		{
			get => GetProperty(ref _tooltipContainer_Crafting);
			set => SetProperty(ref _tooltipContainer_Crafting, value);
		}

		[Ordinal(23)] 
		[RED("filterRoot_Upgrading")] 
		public inkWidgetReference FilterRoot_Upgrading
		{
			get => GetProperty(ref _filterRoot_Upgrading);
			set => SetProperty(ref _filterRoot_Upgrading, value);
		}

		[Ordinal(24)] 
		[RED("filterGroup_Upgrading")] 
		public inkWidgetReference FilterGroup_Upgrading
		{
			get => GetProperty(ref _filterGroup_Upgrading);
			set => SetProperty(ref _filterGroup_Upgrading, value);
		}

		[Ordinal(25)] 
		[RED("sortingButton_Upgrading")] 
		public inkWidgetReference SortingButton_Upgrading
		{
			get => GetProperty(ref _sortingButton_Upgrading);
			set => SetProperty(ref _sortingButton_Upgrading, value);
		}

		[Ordinal(26)] 
		[RED("sortingDropdown_Upgrading")] 
		public inkWidgetReference SortingDropdown_Upgrading
		{
			get => GetProperty(ref _sortingDropdown_Upgrading);
			set => SetProperty(ref _sortingDropdown_Upgrading, value);
		}

		[Ordinal(27)] 
		[RED("upgradingRoot")] 
		public inkCompoundWidgetReference UpgradingRoot
		{
			get => GetProperty(ref _upgradingRoot);
			set => SetProperty(ref _upgradingRoot, value);
		}

		[Ordinal(28)] 
		[RED("itemName_Upgrading")] 
		public inkTextWidgetReference ItemName_Upgrading
		{
			get => GetProperty(ref _itemName_Upgrading);
			set => SetProperty(ref _itemName_Upgrading, value);
		}

		[Ordinal(29)] 
		[RED("itemQuality_Upgrading")] 
		public inkTextWidgetReference ItemQuality_Upgrading
		{
			get => GetProperty(ref _itemQuality_Upgrading);
			set => SetProperty(ref _itemQuality_Upgrading, value);
		}

		[Ordinal(30)] 
		[RED("ingredientsList_Upgrading")] 
		public inkCompoundWidgetReference IngredientsList_Upgrading
		{
			get => GetProperty(ref _ingredientsList_Upgrading);
			set => SetProperty(ref _ingredientsList_Upgrading, value);
		}

		[Ordinal(31)] 
		[RED("progressBarContainer_Upgrading")] 
		public inkCompoundWidgetReference ProgressBarContainer_Upgrading
		{
			get => GetProperty(ref _progressBarContainer_Upgrading);
			set => SetProperty(ref _progressBarContainer_Upgrading, value);
		}

		[Ordinal(32)] 
		[RED("progressButtonContainer_Upgrading")] 
		public inkCompoundWidgetReference ProgressButtonContainer_Upgrading
		{
			get => GetProperty(ref _progressButtonContainer_Upgrading);
			set => SetProperty(ref _progressButtonContainer_Upgrading, value);
		}

		[Ordinal(33)] 
		[RED("tooltipContainer_Upgrading")] 
		public inkCompoundWidgetReference TooltipContainer_Upgrading
		{
			get => GetProperty(ref _tooltipContainer_Upgrading);
			set => SetProperty(ref _tooltipContainer_Upgrading, value);
		}

		[Ordinal(34)] 
		[RED("BlockedText")] 
		public inkTextWidgetReference BlockedText
		{
			get => GetProperty(ref _blockedText);
			set => SetProperty(ref _blockedText, value);
		}

		[Ordinal(35)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get => GetProperty(ref _perkNotificationContainer);
			set => SetProperty(ref _perkNotificationContainer, value);
		}

		[Ordinal(36)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get => GetProperty(ref _perkNotificationText);
			set => SetProperty(ref _perkNotificationText, value);
		}

		[Ordinal(37)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetProperty(ref _perkIcon);
			set => SetProperty(ref _perkIcon, value);
		}

		[Ordinal(38)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(39)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(40)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(41)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(42)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get => GetProperty(ref _craftingSystem);
			set => SetProperty(ref _craftingSystem, value);
		}

		[Ordinal(43)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		[Ordinal(44)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(45)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(46)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(47)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetProperty(ref _weaponAreas);
			set => SetProperty(ref _weaponAreas, value);
		}

		[Ordinal(48)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(49)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(50)] 
		[RED("craftingClassifier")] 
		public CHandle<CraftingItemTemplateClassifier> CraftingClassifier
		{
			get => GetProperty(ref _craftingClassifier);
			set => SetProperty(ref _craftingClassifier, value);
		}

		[Ordinal(51)] 
		[RED("craftingDataView")] 
		public CHandle<CraftingDataView> CraftingDataView
		{
			get => GetProperty(ref _craftingDataView);
			set => SetProperty(ref _craftingDataView, value);
		}

		[Ordinal(52)] 
		[RED("craftingDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> CraftingDataSource
		{
			get => GetProperty(ref _craftingDataSource);
			set => SetProperty(ref _craftingDataSource, value);
		}

		[Ordinal(53)] 
		[RED("virtualCraftingListController")] 
		public CHandle<inkVirtualGridController> VirtualCraftingListController
		{
			get => GetProperty(ref _virtualCraftingListController);
			set => SetProperty(ref _virtualCraftingListController, value);
		}

		[Ordinal(54)] 
		[RED("leftListScrollController")] 
		public CHandle<inkScrollController> LeftListScrollController
		{
			get => GetProperty(ref _leftListScrollController);
			set => SetProperty(ref _leftListScrollController, value);
		}

		[Ordinal(55)] 
		[RED("craftingDef")] 
		public CHandle<UI_CraftingDef> CraftingDef
		{
			get => GetProperty(ref _craftingDef);
			set => SetProperty(ref _craftingDef, value);
		}

		[Ordinal(56)] 
		[RED("craftingBlackboard")] 
		public CHandle<gameIBlackboard> CraftingBlackboard
		{
			get => GetProperty(ref _craftingBlackboard);
			set => SetProperty(ref _craftingBlackboard, value);
		}

		[Ordinal(57)] 
		[RED("craftingBBID")] 
		public CUInt32 CraftingBBID
		{
			get => GetProperty(ref _craftingBBID);
			set => SetProperty(ref _craftingBBID, value);
		}

		[Ordinal(58)] 
		[RED("ingredientsControllerList")] 
		public CArray<wCHandle<IngredientListItemLogicController>> IngredientsControllerList
		{
			get => GetProperty(ref _ingredientsControllerList);
			set => SetProperty(ref _ingredientsControllerList, value);
		}

		[Ordinal(59)] 
		[RED("maxIngredientCraftingCount")] 
		public CInt32 MaxIngredientCraftingCount
		{
			get => GetProperty(ref _maxIngredientCraftingCount);
			set => SetProperty(ref _maxIngredientCraftingCount, value);
		}

		[Ordinal(60)] 
		[RED("maxIngredientUpgradingCount")] 
		public CInt32 MaxIngredientUpgradingCount
		{
			get => GetProperty(ref _maxIngredientUpgradingCount);
			set => SetProperty(ref _maxIngredientUpgradingCount, value);
		}

		[Ordinal(61)] 
		[RED("mode")] 
		public CEnum<CraftingMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(62)] 
		[RED("selectedRecipe")] 
		public CHandle<RecipeData> SelectedRecipe
		{
			get => GetProperty(ref _selectedRecipe);
			set => SetProperty(ref _selectedRecipe, value);
		}

		[Ordinal(63)] 
		[RED("selectedItemData")] 
		public InventoryItemData SelectedItemData
		{
			get => GetProperty(ref _selectedItemData);
			set => SetProperty(ref _selectedItemData, value);
		}

		[Ordinal(64)] 
		[RED("selectedListItem")] 
		public CHandle<CraftableItemLogicController> SelectedListItem
		{
			get => GetProperty(ref _selectedListItem);
			set => SetProperty(ref _selectedListItem, value);
		}

		[Ordinal(65)] 
		[RED("selectedCategory")] 
		public CEnum<ItemFilterType> SelectedCategory
		{
			get => GetProperty(ref _selectedCategory);
			set => SetProperty(ref _selectedCategory, value);
		}

		[Ordinal(66)] 
		[RED("dryItemData")] 
		public CHandle<gameItemData> DryItemData
		{
			get => GetProperty(ref _dryItemData);
			set => SetProperty(ref _dryItemData, value);
		}

		[Ordinal(67)] 
		[RED("dryInventoryItemData")] 
		public InventoryItemData DryInventoryItemData
		{
			get => GetProperty(ref _dryInventoryItemData);
			set => SetProperty(ref _dryInventoryItemData, value);
		}

		[Ordinal(68)] 
		[RED("isInitializeOver")] 
		public CBool IsInitializeOver
		{
			get => GetProperty(ref _isInitializeOver);
			set => SetProperty(ref _isInitializeOver, value);
		}

		[Ordinal(69)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		[Ordinal(70)] 
		[RED("craftingFilters")] 
		public CArray<CInt32> CraftingFilters
		{
			get => GetProperty(ref _craftingFilters);
			set => SetProperty(ref _craftingFilters, value);
		}

		[Ordinal(71)] 
		[RED("upgradeFilters")] 
		public CArray<CInt32> UpgradeFilters
		{
			get => GetProperty(ref _upgradeFilters);
			set => SetProperty(ref _upgradeFilters, value);
		}

		[Ordinal(72)] 
		[RED("itemTooltipControllers")] 
		public CArray<wCHandle<AGenericTooltipController>> ItemTooltipControllers
		{
			get => GetProperty(ref _itemTooltipControllers);
			set => SetProperty(ref _itemTooltipControllers, value);
		}

		[Ordinal(73)] 
		[RED("tooltipType")] 
		public CEnum<CraftingInfoType> TooltipType
		{
			get => GetProperty(ref _tooltipType);
			set => SetProperty(ref _tooltipType, value);
		}

		[Ordinal(74)] 
		[RED("progressButtonController")] 
		public wCHandle<ProgressBarButton> ProgressButtonController
		{
			get => GetProperty(ref _progressButtonController);
			set => SetProperty(ref _progressButtonController, value);
		}

		[Ordinal(75)] 
		[RED("itemWeaponController")] 
		public wCHandle<InventoryItemDisplayController> ItemWeaponController
		{
			get => GetProperty(ref _itemWeaponController);
			set => SetProperty(ref _itemWeaponController, value);
		}

		[Ordinal(76)] 
		[RED("itemIngredientController")] 
		public wCHandle<InventoryItemDisplayController> ItemIngredientController
		{
			get => GetProperty(ref _itemIngredientController);
			set => SetProperty(ref _itemIngredientController, value);
		}

		[Ordinal(77)] 
		[RED("inventoryQuickhacks")] 
		public CArray<InventoryItemData> InventoryQuickhacks
		{
			get => GetProperty(ref _inventoryQuickhacks);
			set => SetProperty(ref _inventoryQuickhacks, value);
		}

		[Ordinal(78)] 
		[RED("doPlayFilterSounds")] 
		public CBool DoPlayFilterSounds
		{
			get => GetProperty(ref _doPlayFilterSounds);
			set => SetProperty(ref _doPlayFilterSounds, value);
		}

		[Ordinal(79)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		public CraftingMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
