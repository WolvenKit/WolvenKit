using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("tooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(4)] [RED("tabRootRef")] public inkWidgetReference TabRootRef { get; set; }
		[Ordinal(5)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(6)] [RED("leftListScrollHolder")] public inkWidgetReference LeftListScrollHolder { get; set; }
		[Ordinal(7)] [RED("recipeGrid")] public inkVirtualCompoundWidgetReference RecipeGrid { get; set; }
		[Ordinal(8)] [RED("skillWidgetRoot")] public inkCompoundWidgetReference SkillWidgetRoot { get; set; }
		[Ordinal(9)] [RED("filterRoot_Crafting")] public inkWidgetReference FilterRoot_Crafting { get; set; }
		[Ordinal(10)] [RED("filterGroup_Crafting")] public inkWidgetReference FilterGroup_Crafting { get; set; }
		[Ordinal(11)] [RED("sortingButton_Crafting")] public inkWidgetReference SortingButton_Crafting { get; set; }
		[Ordinal(12)] [RED("sortingDropdown_Crafting")] public inkWidgetReference SortingDropdown_Crafting { get; set; }
		[Ordinal(13)] [RED("craftingRoot")] public inkCompoundWidgetReference CraftingRoot { get; set; }
		[Ordinal(14)] [RED("itemName_Crafting")] public inkTextWidgetReference ItemName_Crafting { get; set; }
		[Ordinal(15)] [RED("itemQuality_Crafting")] public inkTextWidgetReference ItemQuality_Crafting { get; set; }
		[Ordinal(16)] [RED("ingredientsList_Crafting")] public inkCompoundWidgetReference IngredientsList_Crafting { get; set; }
		[Ordinal(17)] [RED("ingredientsListWeapon")] public inkCompoundWidgetReference IngredientsListWeapon { get; set; }
		[Ordinal(18)] [RED("itemPreviewContainer")] public inkWidgetReference ItemPreviewContainer { get; set; }
		[Ordinal(19)] [RED("weaponPreviewContainer")] public inkWidgetReference WeaponPreviewContainer { get; set; }
		[Ordinal(20)] [RED("progressBarContainer_Crafting")] public inkCompoundWidgetReference ProgressBarContainer_Crafting { get; set; }
		[Ordinal(21)] [RED("progressButtonContainer_Crafting")] public inkCompoundWidgetReference ProgressButtonContainer_Crafting { get; set; }
		[Ordinal(22)] [RED("tooltipContainer_Crafting")] public inkCompoundWidgetReference TooltipContainer_Crafting { get; set; }
		[Ordinal(23)] [RED("filterRoot_Upgrading")] public inkWidgetReference FilterRoot_Upgrading { get; set; }
		[Ordinal(24)] [RED("filterGroup_Upgrading")] public inkWidgetReference FilterGroup_Upgrading { get; set; }
		[Ordinal(25)] [RED("sortingButton_Upgrading")] public inkWidgetReference SortingButton_Upgrading { get; set; }
		[Ordinal(26)] [RED("sortingDropdown_Upgrading")] public inkWidgetReference SortingDropdown_Upgrading { get; set; }
		[Ordinal(27)] [RED("upgradingRoot")] public inkCompoundWidgetReference UpgradingRoot { get; set; }
		[Ordinal(28)] [RED("itemName_Upgrading")] public inkTextWidgetReference ItemName_Upgrading { get; set; }
		[Ordinal(29)] [RED("itemQuality_Upgrading")] public inkTextWidgetReference ItemQuality_Upgrading { get; set; }
		[Ordinal(30)] [RED("ingredientsList_Upgrading")] public inkCompoundWidgetReference IngredientsList_Upgrading { get; set; }
		[Ordinal(31)] [RED("progressBarContainer_Upgrading")] public inkCompoundWidgetReference ProgressBarContainer_Upgrading { get; set; }
		[Ordinal(32)] [RED("progressButtonContainer_Upgrading")] public inkCompoundWidgetReference ProgressButtonContainer_Upgrading { get; set; }
		[Ordinal(33)] [RED("tooltipContainer_Upgrading")] public inkCompoundWidgetReference TooltipContainer_Upgrading { get; set; }
		[Ordinal(34)] [RED("BlockedText")] public inkTextWidgetReference BlockedText { get; set; }
		[Ordinal(35)] [RED("perkNotificationContainer")] public inkWidgetReference PerkNotificationContainer { get; set; }
		[Ordinal(36)] [RED("perkNotificationText")] public inkTextWidgetReference PerkNotificationText { get; set; }
		[Ordinal(37)] [RED("perkIcon")] public inkImageWidgetReference PerkIcon { get; set; }
		[Ordinal(38)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(39)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(40)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(41)] [RED("craftingSystem")] public CHandle<CraftingSystem> CraftingSystem { get; set; }
		[Ordinal(42)] [RED("playerCraftBook")] public CHandle<CraftBook> PlayerCraftBook { get; set; }
		[Ordinal(43)] [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(44)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(45)] [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(46)] [RED("WeaponAreas")] public CArray<CEnum<gamedataItemType>> WeaponAreas { get; set; }
		[Ordinal(47)] [RED("EquipAreas")] public CArray<CEnum<gamedataEquipmentArea>> EquipAreas { get; set; }
		[Ordinal(48)] [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(49)] [RED("craftingClassifier")] public CHandle<CraftingItemTemplateClassifier> CraftingClassifier { get; set; }
		[Ordinal(50)] [RED("craftingDataView")] public CHandle<CraftingDataView> CraftingDataView { get; set; }
		[Ordinal(51)] [RED("craftingDataSource")] public CHandle<inkScriptableDataSourceWrapper> CraftingDataSource { get; set; }
		[Ordinal(52)] [RED("virtualCraftingListController")] public CHandle<inkVirtualGridController> VirtualCraftingListController { get; set; }
		[Ordinal(53)] [RED("leftListScrollController")] public CHandle<inkScrollController> LeftListScrollController { get; set; }
		[Ordinal(54)] [RED("craftingDef")] public CHandle<UI_CraftingDef> CraftingDef { get; set; }
		[Ordinal(55)] [RED("craftingBlackboard")] public CHandle<gameIBlackboard> CraftingBlackboard { get; set; }
		[Ordinal(56)] [RED("craftingBBID")] public CUInt32 CraftingBBID { get; set; }
		[Ordinal(57)] [RED("ingredientsControllerList")] public CArray<wCHandle<IngredientListItemLogicController>> IngredientsControllerList { get; set; }
		[Ordinal(58)] [RED("maxIngredientCraftingCount")] public CInt32 MaxIngredientCraftingCount { get; set; }
		[Ordinal(59)] [RED("maxIngredientUpgradingCount")] public CInt32 MaxIngredientUpgradingCount { get; set; }
		[Ordinal(60)] [RED("mode")] public CEnum<CraftingMode> Mode { get; set; }
		[Ordinal(61)] [RED("selectedRecipe")] public CHandle<RecipeData> SelectedRecipe { get; set; }
		[Ordinal(62)] [RED("selectedItemData")] public InventoryItemData SelectedItemData { get; set; }
		[Ordinal(63)] [RED("selectedListItem")] public CHandle<CraftableItemLogicController> SelectedListItem { get; set; }
		[Ordinal(64)] [RED("selectedCategory")] public CEnum<ItemFilterType> SelectedCategory { get; set; }
		[Ordinal(65)] [RED("dryItemData")] public CHandle<gameItemData> DryItemData { get; set; }
		[Ordinal(66)] [RED("dryInventoryItemData")] public InventoryItemData DryInventoryItemData { get; set; }
		[Ordinal(67)] [RED("isInitializeOver")] public CBool IsInitializeOver { get; set; }
		[Ordinal(68)] [RED("craftingFilters")] public CArray<CInt32> CraftingFilters { get; set; }
		[Ordinal(69)] [RED("upgradeFilters")] public CArray<CInt32> UpgradeFilters { get; set; }
		[Ordinal(70)] [RED("itemTooltipControllers")] public CArray<wCHandle<AGenericTooltipController>> ItemTooltipControllers { get; set; }
		[Ordinal(71)] [RED("tooltipType")] public CEnum<CraftingInfoType> TooltipType { get; set; }
		[Ordinal(72)] [RED("progressButtonController")] public wCHandle<ProgressBarButton> ProgressButtonController { get; set; }
		[Ordinal(73)] [RED("itemWeaponController")] public wCHandle<InventoryItemDisplayController> ItemWeaponController { get; set; }
		[Ordinal(74)] [RED("itemIngredientController")] public wCHandle<InventoryItemDisplayController> ItemIngredientController { get; set; }

		public CraftingMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
