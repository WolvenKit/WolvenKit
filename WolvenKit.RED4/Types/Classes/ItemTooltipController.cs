using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("recipeStatsTitle")] 
		public inkTextWidgetReference RecipeStatsTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("headerWeaponContainer")] 
		public inkCompoundWidgetReference HeaderWeaponContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("headerItemContainer")] 
		public inkCompoundWidgetReference HeaderItemContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("headerGrenadeContainer")] 
		public inkCompoundWidgetReference HeaderGrenadeContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("headerArmorContainer")] 
		public inkCompoundWidgetReference HeaderArmorContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("primmaryStatsContainer")] 
		public inkCompoundWidgetReference PrimmaryStatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("secondaryStatsContainer")] 
		public inkCompoundWidgetReference SecondaryStatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("recipeStatsContainer")] 
		public inkCompoundWidgetReference RecipeStatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("recipeDamageTypesContainer")] 
		public inkCompoundWidgetReference RecipeDamageTypesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("craftedItemContainer")] 
		public inkCompoundWidgetReference CraftedItemContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("primmaryStatsList")] 
		public inkCompoundWidgetReference PrimmaryStatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("secondaryStatsList")] 
		public inkCompoundWidgetReference SecondaryStatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("recipeStatsTypesList")] 
		public inkCompoundWidgetReference RecipeStatsTypesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("recipeDamageTypesList")] 
		public inkCompoundWidgetReference RecipeDamageTypesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("modsList")] 
		public inkCompoundWidgetReference ModsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("dedicatedModsList")] 
		public inkCompoundWidgetReference DedicatedModsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("requiredLevelContainer")] 
		public inkCompoundWidgetReference RequiredLevelContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("requireLevelText")] 
		public inkTextWidgetReference RequireLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("dpsArrow")] 
		public inkImageWidgetReference DpsArrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("nonLethalText")] 
		public inkTextWidgetReference NonLethalText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("damagePerHitValue")] 
		public inkTextWidgetReference DamagePerHitValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("attacksPerSecondValue")] 
		public inkTextWidgetReference AttacksPerSecondValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("silencerPartWrapper")] 
		public inkWidgetReference SilencerPartWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("scopePartWrapper")] 
		public inkWidgetReference ScopePartWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("craftedItemIcon")] 
		public inkWidgetReference CraftedItemIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("grenadeDamageTypeWrapper")] 
		public inkWidgetReference GrenadeDamageTypeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("grenadeDamageTypeIcon")] 
		public inkImageWidgetReference GrenadeDamageTypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("grenadeRangeValue")] 
		public inkTextWidgetReference GrenadeRangeValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("grenadeRangeText")] 
		public inkTextWidgetReference GrenadeRangeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("grenadeDeliveryLabel")] 
		public inkTextWidgetReference GrenadeDeliveryLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("grenadeDeliveryIcon")] 
		public inkImageWidgetReference GrenadeDeliveryIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("grenadeDamageStatWrapper")] 
		public inkWidgetReference GrenadeDamageStatWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("grenadeDamageStatLabel")] 
		public inkTextWidgetReference GrenadeDamageStatLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("grenadeDamageStatValue")] 
		public inkTextWidgetReference GrenadeDamageStatValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("armorStatArrow")] 
		public inkImageWidgetReference ArmorStatArrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("armorStatLabel")] 
		public inkTextWidgetReference ArmorStatLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("quickhackStatWrapper")] 
		public inkWidgetReference QuickhackStatWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("quickhackCostValue")] 
		public inkTextWidgetReference QuickhackCostValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("quickhackDuration")] 
		public inkTextWidgetReference QuickhackDuration
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("quickhackCooldown")] 
		public inkTextWidgetReference QuickhackCooldown
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("quickhackUpload")] 
		public inkTextWidgetReference QuickhackUpload
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("damageTypeWrapper")] 
		public inkWidgetReference DamageTypeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(60)] 
		[RED("damageTypeIcon")] 
		public inkImageWidgetReference DamageTypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(61)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(62)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(63)] 
		[RED("itemPreviewWrapper")] 
		public inkWidgetReference ItemPreviewWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(64)] 
		[RED("itemPreviewIcon")] 
		public inkImageWidgetReference ItemPreviewIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(65)] 
		[RED("itemPreviewIconicLines")] 
		public inkWidgetReference ItemPreviewIconicLines
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(66)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(67)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(68)] 
		[RED("itemAmmoWrapper")] 
		public inkWidgetReference ItemAmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(69)] 
		[RED("itemAmmoText")] 
		public inkTextWidgetReference ItemAmmoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(70)] 
		[RED("itemRequirements")] 
		public inkWidgetReference ItemRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(71)] 
		[RED("itemLevelRequirements")] 
		public inkWidgetReference ItemLevelRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(72)] 
		[RED("itemStrenghtRequirements")] 
		public inkWidgetReference ItemStrenghtRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(73)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(74)] 
		[RED("itemSmartGunLinkRequirements")] 
		public inkWidgetReference ItemSmartGunLinkRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(75)] 
		[RED("itemLevelRequirementsValue")] 
		public inkTextWidgetReference ItemLevelRequirementsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(76)] 
		[RED("itemStrenghtRequirementsValue")] 
		public inkTextWidgetReference ItemStrenghtRequirementsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(77)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(78)] 
		[RED("weaponEvolutionWrapper")] 
		public inkWidgetReference WeaponEvolutionWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(79)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(80)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(81)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(82)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(83)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(84)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(86)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(87)] 
		[RED("playAnimation")] 
		public CBool PlayAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemTooltipController()
		{
			ItemNameText = new inkTextWidgetReference();
			ItemRarityText = new inkTextWidgetReference();
			ProgressBar = new inkWidgetReference();
			RecipeStatsTitle = new inkTextWidgetReference();
			CategoriesWrapper = new inkCompoundWidgetReference();
			BackgroundContainer = new inkCompoundWidgetReference();
			TopContainer = new inkCompoundWidgetReference();
			HeaderContainer = new inkCompoundWidgetReference();
			HeaderWeaponContainer = new inkCompoundWidgetReference();
			HeaderItemContainer = new inkCompoundWidgetReference();
			HeaderGrenadeContainer = new inkCompoundWidgetReference();
			HeaderArmorContainer = new inkCompoundWidgetReference();
			PrimmaryStatsContainer = new inkCompoundWidgetReference();
			SecondaryStatsContainer = new inkCompoundWidgetReference();
			RecipeStatsContainer = new inkCompoundWidgetReference();
			RecipeDamageTypesContainer = new inkCompoundWidgetReference();
			ModsContainer = new inkCompoundWidgetReference();
			DedicatedModsContainer = new inkCompoundWidgetReference();
			DescriptionContainer = new inkCompoundWidgetReference();
			CraftedItemContainer = new inkCompoundWidgetReference();
			BottomContainer = new inkCompoundWidgetReference();
			PrimmaryStatsList = new inkCompoundWidgetReference();
			SecondaryStatsList = new inkCompoundWidgetReference();
			RecipeStatsTypesList = new inkCompoundWidgetReference();
			RecipeDamageTypesList = new inkCompoundWidgetReference();
			ModsList = new inkCompoundWidgetReference();
			DedicatedModsList = new inkCompoundWidgetReference();
			RequiredLevelContainer = new inkCompoundWidgetReference();
			PriceContainer = new inkCompoundWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			RequireLevelText = new inkTextWidgetReference();
			PriceText = new inkTextWidgetReference();
			DpsWrapper = new inkWidgetReference();
			DpsArrow = new inkImageWidgetReference();
			DpsText = new inkTextWidgetReference();
			NonLethalText = new inkTextWidgetReference();
			DamagePerHitValue = new inkTextWidgetReference();
			AttacksPerSecondValue = new inkTextWidgetReference();
			SilencerPartWrapper = new inkWidgetReference();
			ScopePartWrapper = new inkWidgetReference();
			CraftedItemIcon = new inkWidgetReference();
			GrenadeDamageTypeWrapper = new inkWidgetReference();
			GrenadeDamageTypeIcon = new inkImageWidgetReference();
			GrenadeRangeValue = new inkTextWidgetReference();
			GrenadeRangeText = new inkTextWidgetReference();
			GrenadeDeliveryLabel = new inkTextWidgetReference();
			GrenadeDeliveryIcon = new inkImageWidgetReference();
			GrenadeDamageStatWrapper = new inkWidgetReference();
			GrenadeDamageStatLabel = new inkTextWidgetReference();
			GrenadeDamageStatValue = new inkTextWidgetReference();
			ArmorStatArrow = new inkImageWidgetReference();
			ArmorStatLabel = new inkTextWidgetReference();
			QuickhackStatWrapper = new inkWidgetReference();
			QuickhackCostValue = new inkTextWidgetReference();
			QuickhackDuration = new inkTextWidgetReference();
			QuickhackCooldown = new inkTextWidgetReference();
			QuickhackUpload = new inkTextWidgetReference();
			DamageTypeWrapper = new inkWidgetReference();
			DamageTypeIcon = new inkImageWidgetReference();
			EquipedWrapper = new inkWidgetReference();
			ItemTypeText = new inkTextWidgetReference();
			ItemPreviewWrapper = new inkWidgetReference();
			ItemPreviewIcon = new inkImageWidgetReference();
			ItemPreviewIconicLines = new inkWidgetReference();
			ItemWeightWrapper = new inkWidgetReference();
			ItemWeightText = new inkTextWidgetReference();
			ItemAmmoWrapper = new inkWidgetReference();
			ItemAmmoText = new inkTextWidgetReference();
			ItemRequirements = new inkWidgetReference();
			ItemLevelRequirements = new inkWidgetReference();
			ItemStrenghtRequirements = new inkWidgetReference();
			ItemAttributeRequirements = new inkWidgetReference();
			ItemSmartGunLinkRequirements = new inkWidgetReference();
			ItemLevelRequirementsValue = new inkTextWidgetReference();
			ItemStrenghtRequirementsValue = new inkTextWidgetReference();
			ItemAttributeRequirementsText = new inkTextWidgetReference();
			WeaponEvolutionWrapper = new inkWidgetReference();
			WeaponEvolutionIcon = new inkImageWidgetReference();
			WeaponEvolutionName = new inkTextWidgetReference();
			WeaponEvolutionDescription = new inkTextWidgetReference();
			DEBUG_iconErrorWrapper = new inkWidgetReference();
			DEBUG_iconErrorText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
