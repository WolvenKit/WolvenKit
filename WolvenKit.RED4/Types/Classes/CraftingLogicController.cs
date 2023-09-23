using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingLogicController : CraftingMainLogicController
	{
		[Ordinal(50)] 
		[RED("ingredientsWeaponContainer")] 
		public inkCompoundWidgetReference IngredientsWeaponContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("garmentPreviewContainer")] 
		public inkWidgetReference GarmentPreviewContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("itemTooltipController")] 
		public CWeakHandle<AGenericTooltipController> ItemTooltipController
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(57)] 
		[RED("quickHackTooltipController")] 
		public CWeakHandle<AGenericTooltipController> QuickHackTooltipController
		{
			get => GetPropertyValue<CWeakHandle<AGenericTooltipController>>();
			set => SetPropertyValue<CWeakHandle<AGenericTooltipController>>(value);
		}

		[Ordinal(58)] 
		[RED("tooltipData")] 
		public CHandle<ATooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}

		[Ordinal(59)] 
		[RED("ingredientWeaponController")] 
		public CWeakHandle<InventoryWeaponDisplayController> IngredientWeaponController
		{
			get => GetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>(value);
		}

		[Ordinal(60)] 
		[RED("ingredientClothingController")] 
		public CWeakHandle<InventoryWeaponDisplayController> IngredientClothingController
		{
			get => GetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryWeaponDisplayController>>(value);
		}

		[Ordinal(61)] 
		[RED("selectedItemGameData")] 
		public CHandle<gameItemData> SelectedItemGameData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(62)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(63)] 
		[RED("playerCraftBook")] 
		public CWeakHandle<CraftBook> PlayerCraftBook
		{
			get => GetPropertyValue<CWeakHandle<CraftBook>>();
			set => SetPropertyValue<CWeakHandle<CraftBook>>(value);
		}

		[Ordinal(64)] 
		[RED("hasSpawnedQuickHackTooltip")] 
		public CBool HasSpawnedQuickHackTooltip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CraftingLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
