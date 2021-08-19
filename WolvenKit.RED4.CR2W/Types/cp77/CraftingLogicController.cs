using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingLogicController : CraftingMainLogicController
	{
		private inkCompoundWidgetReference _ingredientsWeaponContainer;
		private inkWidgetReference _itemPreviewContainer;
		private inkWidgetReference _weaponPreviewContainer;
		private inkWidgetReference _perkNotificationContainer;
		private inkTextWidgetReference _perkNotificationText;
		private inkImageWidgetReference _perkIcon;
		private wCHandle<AGenericTooltipController> _itemTooltipController;
		private wCHandle<AGenericTooltipController> _quickHackTooltipController;
		private CHandle<InventoryTooltipData> _tooltipData;
		private wCHandle<InventoryWeaponDisplayController> _ingredientWeaponController;
		private wCHandle<InventoryWeaponDisplayController> _ingredientClothingController;
		private CHandle<gameItemData> _selectedItemGameData;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private wCHandle<CraftBook> _playerCraftBook;

		[Ordinal(39)] 
		[RED("ingredientsWeaponContainer")] 
		public inkCompoundWidgetReference IngredientsWeaponContainer
		{
			get => GetProperty(ref _ingredientsWeaponContainer);
			set => SetProperty(ref _ingredientsWeaponContainer, value);
		}

		[Ordinal(40)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get => GetProperty(ref _itemPreviewContainer);
			set => SetProperty(ref _itemPreviewContainer, value);
		}

		[Ordinal(41)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get => GetProperty(ref _weaponPreviewContainer);
			set => SetProperty(ref _weaponPreviewContainer, value);
		}

		[Ordinal(42)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get => GetProperty(ref _perkNotificationContainer);
			set => SetProperty(ref _perkNotificationContainer, value);
		}

		[Ordinal(43)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get => GetProperty(ref _perkNotificationText);
			set => SetProperty(ref _perkNotificationText, value);
		}

		[Ordinal(44)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetProperty(ref _perkIcon);
			set => SetProperty(ref _perkIcon, value);
		}

		[Ordinal(45)] 
		[RED("itemTooltipController")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController
		{
			get => GetProperty(ref _itemTooltipController);
			set => SetProperty(ref _itemTooltipController, value);
		}

		[Ordinal(46)] 
		[RED("quickHackTooltipController")] 
		public wCHandle<AGenericTooltipController> QuickHackTooltipController
		{
			get => GetProperty(ref _quickHackTooltipController);
			set => SetProperty(ref _quickHackTooltipController, value);
		}

		[Ordinal(47)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(48)] 
		[RED("ingredientWeaponController")] 
		public wCHandle<InventoryWeaponDisplayController> IngredientWeaponController
		{
			get => GetProperty(ref _ingredientWeaponController);
			set => SetProperty(ref _ingredientWeaponController, value);
		}

		[Ordinal(49)] 
		[RED("ingredientClothingController")] 
		public wCHandle<InventoryWeaponDisplayController> IngredientClothingController
		{
			get => GetProperty(ref _ingredientClothingController);
			set => SetProperty(ref _ingredientClothingController, value);
		}

		[Ordinal(50)] 
		[RED("selectedItemGameData")] 
		public CHandle<gameItemData> SelectedItemGameData
		{
			get => GetProperty(ref _selectedItemGameData);
			set => SetProperty(ref _selectedItemGameData, value);
		}

		[Ordinal(51)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(52)] 
		[RED("playerCraftBook")] 
		public wCHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		public CraftingLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
