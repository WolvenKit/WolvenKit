using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingLogicController : CraftingMainLogicController
	{
		[Ordinal(39)] 
		[RED("ingredientsWeaponContainer")] 
		public inkCompoundWidgetReference IngredientsWeaponContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("garmentPreviewContainer")] 
		public inkWidgetReference GarmentPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("itemTooltipController")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(47)] 
		[RED("quickHackTooltipController")] 
		public CWeakHandle<AGenericTooltipController> QuickHackTooltipController
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(48)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(49)] 
		[RED("ingredientWeaponController")] 
		public CWeakHandle<InventoryWeaponDisplayController> IngredientWeaponController
		{
			get => GetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>(value);
		}

		[Ordinal(50)] 
		[RED("ingredientClothingController")] 
		public CWeakHandle<InventoryWeaponDisplayController> IngredientClothingController
		{
			get => GetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>(value);
		}

		[Ordinal(51)] 
		[RED("selectedItemGameData")] 
		public CHandle<gameItemData> SelectedItemGameData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(52)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(53)] 
		[RED("playerCraftBook")] 
		public CWeakHandle<CraftBook> PlayerCraftBook
		{
			get => GetPropertyValue<CWeakHandle<CraftBook>>();
			set => SetPropertyValue<CWeakHandle<CraftBook>>(value);
		}

		public CraftingLogicController()
		{
			MaxIngredientCount = 5;
			IngredientsWeaponContainer = new inkCompoundWidgetReference();
			ItemPreviewContainer = new inkWidgetReference();
			WeaponPreviewContainer = new inkWidgetReference();
			GarmentPreviewContainer = new inkWidgetReference();
			PerkNotificationContainer = new inkWidgetReference();
			PerkNotificationText = new inkTextWidgetReference();
			PerkIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
