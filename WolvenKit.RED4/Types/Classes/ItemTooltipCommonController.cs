using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("itemActionContainer")] 
		public inkWidgetReference ItemActionContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("spawnedModules")] 
		public CArray<CWeakHandle<ItemTooltipModuleController>> SpawnedModules
		{
			get => GetPropertyValue<CArray<CWeakHandle<ItemTooltipModuleController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ItemTooltipModuleController>>>(value);
		}

		[Ordinal(21)] 
		[RED("itemEquippedController")] 
		public CWeakHandle<ItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipEquippedModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipEquippedModule>>(value);
		}

		[Ordinal(22)] 
		[RED("itemHeaderController")] 
		public CWeakHandle<ItemTooltipHeaderController> ItemHeaderController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipHeaderController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipHeaderController>>(value);
		}

		[Ordinal(23)] 
		[RED("itemIconController")] 
		public CWeakHandle<ItemTooltipIconModule> ItemIconController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipIconModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipIconModule>>(value);
		}

		[Ordinal(24)] 
		[RED("itemWeaponInfoController")] 
		public CWeakHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipWeaponInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipWeaponInfoModule>>(value);
		}

		[Ordinal(25)] 
		[RED("itemClothingInfoController")] 
		public CWeakHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipClothingInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipClothingInfoModule>>(value);
		}

		[Ordinal(26)] 
		[RED("itemGrenadeInfoController")] 
		public CWeakHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipGrenadeInfoModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipGrenadeInfoModule>>(value);
		}

		[Ordinal(27)] 
		[RED("itemRequirementsController")] 
		public CWeakHandle<ItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipRequirementsModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipRequirementsModule>>(value);
		}

		[Ordinal(28)] 
		[RED("itemDetailsController")] 
		public CWeakHandle<ItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipDetailsModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipDetailsModule>>(value);
		}

		[Ordinal(29)] 
		[RED("itemRecipeDataController")] 
		public CWeakHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipRecipeDataModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipRecipeDataModule>>(value);
		}

		[Ordinal(30)] 
		[RED("itemEvolutionController")] 
		public CWeakHandle<ItemTooltipEvolutionModule> ItemEvolutionController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipEvolutionModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipEvolutionModule>>(value);
		}

		[Ordinal(31)] 
		[RED("itemCraftedController")] 
		public CWeakHandle<ItemTooltipCraftedModule> ItemCraftedController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipCraftedModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipCraftedModule>>(value);
		}

		[Ordinal(32)] 
		[RED("itemBottomController")] 
		public CWeakHandle<ItemTooltipBottomModule> ItemBottomController
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipBottomModule>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipBottomModule>>(value);
		}

		[Ordinal(33)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipData>>(value);
		}

		[Ordinal(35)] 
		[RED("itemData")] 
		public CHandle<UIInventoryItem> ItemData
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(36)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemComparisonManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemComparisonManager>>(value);
		}

		[Ordinal(37)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(38)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(39)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(40)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(41)] 
		[RED("priceOverride")] 
		public CInt32 PriceOverride
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ItemTooltipCommonController()
		{
			BackgroundContainer = new inkWidgetReference();
			ItemEquippedContainer = new inkWidgetReference();
			ItemHeaderContainer = new inkWidgetReference();
			ItemIconContainer = new inkWidgetReference();
			ItemWeaponInfoContainer = new inkWidgetReference();
			ItemClothingInfoContainer = new inkWidgetReference();
			ItemGrenadeInfoContainer = new inkWidgetReference();
			ItemRequirementsContainer = new inkWidgetReference();
			ItemDetailsContainer = new inkWidgetReference();
			ItemRecipeDataContainer = new inkWidgetReference();
			ItemEvolutionContainer = new inkWidgetReference();
			ItemCraftedContainer = new inkWidgetReference();
			ItemActionContainer = new inkWidgetReference();
			ItemBottomContainer = new inkWidgetReference();
			DescriptionWrapper = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			DEBUG_iconErrorWrapper = new inkWidgetReference();
			DEBUG_iconErrorText = new inkTextWidgetReference();
			SpawnedModules = new();
			RequestedModules = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
