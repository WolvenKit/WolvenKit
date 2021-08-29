using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingLogicController : CraftingMainLogicController
	{
		private inkCompoundWidgetReference _ingredientsWeaponContainer;
		private inkWidgetReference _itemPreviewContainer;
		private inkWidgetReference _weaponPreviewContainer;
		private inkWidgetReference _perkNotificationContainer;
		private inkTextWidgetReference _perkNotificationText;
		private inkImageWidgetReference _perkIcon;
		private CWeakHandle<AGenericTooltipController> _itemTooltipController;
		private CWeakHandle<AGenericTooltipController> _quickHackTooltipController;
		private CHandle<InventoryTooltipData> _tooltipData;
		private CWeakHandle<InventoryWeaponDisplayController> _ingredientWeaponController;
		private CWeakHandle<InventoryWeaponDisplayController> _ingredientClothingController;
		private CHandle<gameItemData> _selectedItemGameData;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private CWeakHandle<CraftBook> _playerCraftBook;

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
		public CWeakHandle<AGenericTooltipController> ItemTooltipController
		{
			get => GetProperty(ref _itemTooltipController);
			set => SetProperty(ref _itemTooltipController, value);
		}

		[Ordinal(46)] 
		[RED("quickHackTooltipController")] 
		public CWeakHandle<AGenericTooltipController> QuickHackTooltipController
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
		public CWeakHandle<InventoryWeaponDisplayController> IngredientWeaponController
		{
			get => GetProperty(ref _ingredientWeaponController);
			set => SetProperty(ref _ingredientWeaponController, value);
		}

		[Ordinal(49)] 
		[RED("ingredientClothingController")] 
		public CWeakHandle<InventoryWeaponDisplayController> IngredientClothingController
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
		public CWeakHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}
	}
}
