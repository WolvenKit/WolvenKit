using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipCommonController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("backgroundContainer")] 
		public inkWidgetReference BackgroundContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemEquippedContainer")] 
		public inkWidgetReference ItemEquippedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemHeaderContainer")] 
		public inkWidgetReference ItemHeaderContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemIconContainer")] 
		public inkWidgetReference ItemIconContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemWeaponInfoContainer")] 
		public inkWidgetReference ItemWeaponInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemClothingInfoContainer")] 
		public inkWidgetReference ItemClothingInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemGrenadeInfoContainer")] 
		public inkWidgetReference ItemGrenadeInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemRecipeDataContainer")] 
		public inkWidgetReference ItemRecipeDataContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("itemEvolutionContainer")] 
		public inkWidgetReference ItemEvolutionContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("itemCraftedContainer")] 
		public inkWidgetReference ItemCraftedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("itemEquippedController")] 
		public CWeakHandle<ItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipEquippedModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipEquippedModule>>(value);
		}

		[Ordinal(20)] 
		[RED("itemHeaderController")] 
		public CWeakHandle<ItemTooltipHeaderController> ItemHeaderController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipHeaderController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipHeaderController>>(value);
		}

		[Ordinal(21)] 
		[RED("itemIconController")] 
		public CWeakHandle<ItemTooltipIconModule> ItemIconController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipIconModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipIconModule>>(value);
		}

		[Ordinal(22)] 
		[RED("itemWeaponInfoController")] 
		public CWeakHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipWeaponInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipWeaponInfoModule>>(value);
		}

		[Ordinal(23)] 
		[RED("itemClothingInfoController")] 
		public CWeakHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipClothingInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipClothingInfoModule>>(value);
		}

		[Ordinal(24)] 
		[RED("itemGrenadeInfoController")] 
		public CWeakHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipGrenadeInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipGrenadeInfoModule>>(value);
		}

		[Ordinal(25)] 
		[RED("itemRequirementsController")] 
		public CWeakHandle<ItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipRequirementsModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipRequirementsModule>>(value);
		}

		[Ordinal(26)] 
		[RED("itemDetailsController")] 
		public CWeakHandle<ItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipDetailsModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipDetailsModule>>(value);
		}

		[Ordinal(27)] 
		[RED("itemRecipeDataController")] 
		public CWeakHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipRecipeDataModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipRecipeDataModule>>(value);
		}

		[Ordinal(28)] 
		[RED("itemEvolutionController")] 
		public CWeakHandle<ItemTooltipEvolutionModule> ItemEvolutionController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipEvolutionModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipEvolutionModule>>(value);
		}

		[Ordinal(29)] 
		[RED("itemCraftedController")] 
		public CWeakHandle<ItemTooltipCraftedModule> ItemCraftedController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipCraftedModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipCraftedModule>>(value);
		}

		[Ordinal(30)] 
		[RED("itemBottomController")] 
		public CWeakHandle<ItemTooltipBottomModule> ItemBottomController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipBottomModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipBottomModule>>(value);
		}

		[Ordinal(31)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipData>>(value);
		}

		[Ordinal(33)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public ItemTooltipCommonController()
		{
			BackgroundContainer = new();
			ItemEquippedContainer = new();
			ItemHeaderContainer = new();
			ItemIconContainer = new();
			ItemWeaponInfoContainer = new();
			ItemClothingInfoContainer = new();
			ItemGrenadeInfoContainer = new();
			ItemRequirementsContainer = new();
			ItemDetailsContainer = new();
			ItemRecipeDataContainer = new();
			ItemEvolutionContainer = new();
			ItemCraftedContainer = new();
			ItemBottomContainer = new();
			DescriptionWrapper = new();
			DescriptionText = new();
			DEBUG_iconErrorWrapper = new();
			DEBUG_iconErrorText = new();
			RequestedModules = new();
		}
	}
}
