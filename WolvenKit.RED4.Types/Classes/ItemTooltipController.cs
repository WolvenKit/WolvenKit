using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipController : AGenericTooltipController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemRarityText;
		private inkWidgetReference _progressBar;
		private inkTextWidgetReference _recipeStatsTitle;
		private inkCompoundWidgetReference _categoriesWrapper;
		private inkCompoundWidgetReference _backgroundContainer;
		private inkCompoundWidgetReference _topContainer;
		private inkCompoundWidgetReference _headerContainer;
		private inkCompoundWidgetReference _headerWeaponContainer;
		private inkCompoundWidgetReference _headerItemContainer;
		private inkCompoundWidgetReference _headerGrenadeContainer;
		private inkCompoundWidgetReference _headerArmorContainer;
		private inkCompoundWidgetReference _primmaryStatsContainer;
		private inkCompoundWidgetReference _secondaryStatsContainer;
		private inkCompoundWidgetReference _recipeStatsContainer;
		private inkCompoundWidgetReference _recipeDamageTypesContainer;
		private inkCompoundWidgetReference _modsContainer;
		private inkCompoundWidgetReference _dedicatedModsContainer;
		private inkCompoundWidgetReference _descriptionContainer;
		private inkCompoundWidgetReference _craftedItemContainer;
		private inkCompoundWidgetReference _bottomContainer;
		private inkCompoundWidgetReference _primmaryStatsList;
		private inkCompoundWidgetReference _secondaryStatsList;
		private inkCompoundWidgetReference _recipeStatsTypesList;
		private inkCompoundWidgetReference _recipeDamageTypesList;
		private inkCompoundWidgetReference _modsList;
		private inkCompoundWidgetReference _dedicatedModsList;
		private inkCompoundWidgetReference _requiredLevelContainer;
		private inkCompoundWidgetReference _priceContainer;
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _requireLevelText;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _dpsWrapper;
		private inkImageWidgetReference _dpsArrow;
		private inkTextWidgetReference _dpsText;
		private inkTextWidgetReference _nonLethalText;
		private inkTextWidgetReference _damagePerHitValue;
		private inkTextWidgetReference _attacksPerSecondValue;
		private inkWidgetReference _silencerPartWrapper;
		private inkWidgetReference _scopePartWrapper;
		private inkWidgetReference _craftedItemIcon;
		private inkWidgetReference _grenadeDamageTypeWrapper;
		private inkImageWidgetReference _grenadeDamageTypeIcon;
		private inkTextWidgetReference _grenadeRangeValue;
		private inkTextWidgetReference _grenadeRangeText;
		private inkTextWidgetReference _grenadeDeliveryLabel;
		private inkImageWidgetReference _grenadeDeliveryIcon;
		private inkWidgetReference _grenadeDamageStatWrapper;
		private inkTextWidgetReference _grenadeDamageStatLabel;
		private inkTextWidgetReference _grenadeDamageStatValue;
		private inkImageWidgetReference _armorStatArrow;
		private inkTextWidgetReference _armorStatLabel;
		private inkWidgetReference _quickhackStatWrapper;
		private inkTextWidgetReference _quickhackCostValue;
		private inkTextWidgetReference _quickhackDuration;
		private inkTextWidgetReference _quickhackCooldown;
		private inkTextWidgetReference _quickhackUpload;
		private inkWidgetReference _damageTypeWrapper;
		private inkImageWidgetReference _damageTypeIcon;
		private inkWidgetReference _equipedWrapper;
		private inkTextWidgetReference _itemTypeText;
		private inkWidgetReference _itemPreviewWrapper;
		private inkImageWidgetReference _itemPreviewIcon;
		private inkWidgetReference _itemPreviewIconicLines;
		private inkWidgetReference _itemWeightWrapper;
		private inkTextWidgetReference _itemWeightText;
		private inkWidgetReference _itemAmmoWrapper;
		private inkTextWidgetReference _itemAmmoText;
		private inkWidgetReference _itemRequirements;
		private inkWidgetReference _itemLevelRequirements;
		private inkWidgetReference _itemStrenghtRequirements;
		private inkWidgetReference _itemAttributeRequirements;
		private inkWidgetReference _itemSmartGunLinkRequirements;
		private inkTextWidgetReference _itemLevelRequirementsValue;
		private inkTextWidgetReference _itemStrenghtRequirementsValue;
		private inkTextWidgetReference _itemAttributeRequirementsText;
		private inkWidgetReference _weaponEvolutionWrapper;
		private inkImageWidgetReference _weaponEvolutionIcon;
		private inkTextWidgetReference _weaponEvolutionName;
		private inkTextWidgetReference _weaponEvolutionDescription;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<InventoryTooltipData> _data;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _playAnimation;

		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetProperty(ref _itemRarityText);
			set => SetProperty(ref _itemRarityText, value);
		}

		[Ordinal(4)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(5)] 
		[RED("recipeStatsTitle")] 
		public inkTextWidgetReference RecipeStatsTitle
		{
			get => GetProperty(ref _recipeStatsTitle);
			set => SetProperty(ref _recipeStatsTitle, value);
		}

		[Ordinal(6)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get => GetProperty(ref _categoriesWrapper);
			set => SetProperty(ref _categoriesWrapper, value);
		}

		[Ordinal(7)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get => GetProperty(ref _backgroundContainer);
			set => SetProperty(ref _backgroundContainer, value);
		}

		[Ordinal(8)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get => GetProperty(ref _topContainer);
			set => SetProperty(ref _topContainer, value);
		}

		[Ordinal(9)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get => GetProperty(ref _headerContainer);
			set => SetProperty(ref _headerContainer, value);
		}

		[Ordinal(10)] 
		[RED("headerWeaponContainer")] 
		public inkCompoundWidgetReference HeaderWeaponContainer
		{
			get => GetProperty(ref _headerWeaponContainer);
			set => SetProperty(ref _headerWeaponContainer, value);
		}

		[Ordinal(11)] 
		[RED("headerItemContainer")] 
		public inkCompoundWidgetReference HeaderItemContainer
		{
			get => GetProperty(ref _headerItemContainer);
			set => SetProperty(ref _headerItemContainer, value);
		}

		[Ordinal(12)] 
		[RED("headerGrenadeContainer")] 
		public inkCompoundWidgetReference HeaderGrenadeContainer
		{
			get => GetProperty(ref _headerGrenadeContainer);
			set => SetProperty(ref _headerGrenadeContainer, value);
		}

		[Ordinal(13)] 
		[RED("headerArmorContainer")] 
		public inkCompoundWidgetReference HeaderArmorContainer
		{
			get => GetProperty(ref _headerArmorContainer);
			set => SetProperty(ref _headerArmorContainer, value);
		}

		[Ordinal(14)] 
		[RED("primmaryStatsContainer")] 
		public inkCompoundWidgetReference PrimmaryStatsContainer
		{
			get => GetProperty(ref _primmaryStatsContainer);
			set => SetProperty(ref _primmaryStatsContainer, value);
		}

		[Ordinal(15)] 
		[RED("secondaryStatsContainer")] 
		public inkCompoundWidgetReference SecondaryStatsContainer
		{
			get => GetProperty(ref _secondaryStatsContainer);
			set => SetProperty(ref _secondaryStatsContainer, value);
		}

		[Ordinal(16)] 
		[RED("recipeStatsContainer")] 
		public inkCompoundWidgetReference RecipeStatsContainer
		{
			get => GetProperty(ref _recipeStatsContainer);
			set => SetProperty(ref _recipeStatsContainer, value);
		}

		[Ordinal(17)] 
		[RED("recipeDamageTypesContainer")] 
		public inkCompoundWidgetReference RecipeDamageTypesContainer
		{
			get => GetProperty(ref _recipeDamageTypesContainer);
			set => SetProperty(ref _recipeDamageTypesContainer, value);
		}

		[Ordinal(18)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetProperty(ref _modsContainer);
			set => SetProperty(ref _modsContainer, value);
		}

		[Ordinal(19)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetProperty(ref _dedicatedModsContainer);
			set => SetProperty(ref _dedicatedModsContainer, value);
		}

		[Ordinal(20)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get => GetProperty(ref _descriptionContainer);
			set => SetProperty(ref _descriptionContainer, value);
		}

		[Ordinal(21)] 
		[RED("craftedItemContainer")] 
		public inkCompoundWidgetReference CraftedItemContainer
		{
			get => GetProperty(ref _craftedItemContainer);
			set => SetProperty(ref _craftedItemContainer, value);
		}

		[Ordinal(22)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get => GetProperty(ref _bottomContainer);
			set => SetProperty(ref _bottomContainer, value);
		}

		[Ordinal(23)] 
		[RED("primmaryStatsList")] 
		public inkCompoundWidgetReference PrimmaryStatsList
		{
			get => GetProperty(ref _primmaryStatsList);
			set => SetProperty(ref _primmaryStatsList, value);
		}

		[Ordinal(24)] 
		[RED("secondaryStatsList")] 
		public inkCompoundWidgetReference SecondaryStatsList
		{
			get => GetProperty(ref _secondaryStatsList);
			set => SetProperty(ref _secondaryStatsList, value);
		}

		[Ordinal(25)] 
		[RED("recipeStatsTypesList")] 
		public inkCompoundWidgetReference RecipeStatsTypesList
		{
			get => GetProperty(ref _recipeStatsTypesList);
			set => SetProperty(ref _recipeStatsTypesList, value);
		}

		[Ordinal(26)] 
		[RED("recipeDamageTypesList")] 
		public inkCompoundWidgetReference RecipeDamageTypesList
		{
			get => GetProperty(ref _recipeDamageTypesList);
			set => SetProperty(ref _recipeDamageTypesList, value);
		}

		[Ordinal(27)] 
		[RED("modsList")] 
		public inkCompoundWidgetReference ModsList
		{
			get => GetProperty(ref _modsList);
			set => SetProperty(ref _modsList, value);
		}

		[Ordinal(28)] 
		[RED("dedicatedModsList")] 
		public inkCompoundWidgetReference DedicatedModsList
		{
			get => GetProperty(ref _dedicatedModsList);
			set => SetProperty(ref _dedicatedModsList, value);
		}

		[Ordinal(29)] 
		[RED("requiredLevelContainer")] 
		public inkCompoundWidgetReference RequiredLevelContainer
		{
			get => GetProperty(ref _requiredLevelContainer);
			set => SetProperty(ref _requiredLevelContainer, value);
		}

		[Ordinal(30)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(31)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(32)] 
		[RED("requireLevelText")] 
		public inkTextWidgetReference RequireLevelText
		{
			get => GetProperty(ref _requireLevelText);
			set => SetProperty(ref _requireLevelText, value);
		}

		[Ordinal(33)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(34)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get => GetProperty(ref _dpsWrapper);
			set => SetProperty(ref _dpsWrapper, value);
		}

		[Ordinal(35)] 
		[RED("dpsArrow")] 
		public inkImageWidgetReference DpsArrow
		{
			get => GetProperty(ref _dpsArrow);
			set => SetProperty(ref _dpsArrow, value);
		}

		[Ordinal(36)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetProperty(ref _dpsText);
			set => SetProperty(ref _dpsText, value);
		}

		[Ordinal(37)] 
		[RED("nonLethalText")] 
		public inkTextWidgetReference NonLethalText
		{
			get => GetProperty(ref _nonLethalText);
			set => SetProperty(ref _nonLethalText, value);
		}

		[Ordinal(38)] 
		[RED("damagePerHitValue")] 
		public inkTextWidgetReference DamagePerHitValue
		{
			get => GetProperty(ref _damagePerHitValue);
			set => SetProperty(ref _damagePerHitValue, value);
		}

		[Ordinal(39)] 
		[RED("attacksPerSecondValue")] 
		public inkTextWidgetReference AttacksPerSecondValue
		{
			get => GetProperty(ref _attacksPerSecondValue);
			set => SetProperty(ref _attacksPerSecondValue, value);
		}

		[Ordinal(40)] 
		[RED("silencerPartWrapper")] 
		public inkWidgetReference SilencerPartWrapper
		{
			get => GetProperty(ref _silencerPartWrapper);
			set => SetProperty(ref _silencerPartWrapper, value);
		}

		[Ordinal(41)] 
		[RED("scopePartWrapper")] 
		public inkWidgetReference ScopePartWrapper
		{
			get => GetProperty(ref _scopePartWrapper);
			set => SetProperty(ref _scopePartWrapper, value);
		}

		[Ordinal(42)] 
		[RED("craftedItemIcon")] 
		public inkWidgetReference CraftedItemIcon
		{
			get => GetProperty(ref _craftedItemIcon);
			set => SetProperty(ref _craftedItemIcon, value);
		}

		[Ordinal(43)] 
		[RED("grenadeDamageTypeWrapper")] 
		public inkWidgetReference GrenadeDamageTypeWrapper
		{
			get => GetProperty(ref _grenadeDamageTypeWrapper);
			set => SetProperty(ref _grenadeDamageTypeWrapper, value);
		}

		[Ordinal(44)] 
		[RED("grenadeDamageTypeIcon")] 
		public inkImageWidgetReference GrenadeDamageTypeIcon
		{
			get => GetProperty(ref _grenadeDamageTypeIcon);
			set => SetProperty(ref _grenadeDamageTypeIcon, value);
		}

		[Ordinal(45)] 
		[RED("grenadeRangeValue")] 
		public inkTextWidgetReference GrenadeRangeValue
		{
			get => GetProperty(ref _grenadeRangeValue);
			set => SetProperty(ref _grenadeRangeValue, value);
		}

		[Ordinal(46)] 
		[RED("grenadeRangeText")] 
		public inkTextWidgetReference GrenadeRangeText
		{
			get => GetProperty(ref _grenadeRangeText);
			set => SetProperty(ref _grenadeRangeText, value);
		}

		[Ordinal(47)] 
		[RED("grenadeDeliveryLabel")] 
		public inkTextWidgetReference GrenadeDeliveryLabel
		{
			get => GetProperty(ref _grenadeDeliveryLabel);
			set => SetProperty(ref _grenadeDeliveryLabel, value);
		}

		[Ordinal(48)] 
		[RED("grenadeDeliveryIcon")] 
		public inkImageWidgetReference GrenadeDeliveryIcon
		{
			get => GetProperty(ref _grenadeDeliveryIcon);
			set => SetProperty(ref _grenadeDeliveryIcon, value);
		}

		[Ordinal(49)] 
		[RED("grenadeDamageStatWrapper")] 
		public inkWidgetReference GrenadeDamageStatWrapper
		{
			get => GetProperty(ref _grenadeDamageStatWrapper);
			set => SetProperty(ref _grenadeDamageStatWrapper, value);
		}

		[Ordinal(50)] 
		[RED("grenadeDamageStatLabel")] 
		public inkTextWidgetReference GrenadeDamageStatLabel
		{
			get => GetProperty(ref _grenadeDamageStatLabel);
			set => SetProperty(ref _grenadeDamageStatLabel, value);
		}

		[Ordinal(51)] 
		[RED("grenadeDamageStatValue")] 
		public inkTextWidgetReference GrenadeDamageStatValue
		{
			get => GetProperty(ref _grenadeDamageStatValue);
			set => SetProperty(ref _grenadeDamageStatValue, value);
		}

		[Ordinal(52)] 
		[RED("armorStatArrow")] 
		public inkImageWidgetReference ArmorStatArrow
		{
			get => GetProperty(ref _armorStatArrow);
			set => SetProperty(ref _armorStatArrow, value);
		}

		[Ordinal(53)] 
		[RED("armorStatLabel")] 
		public inkTextWidgetReference ArmorStatLabel
		{
			get => GetProperty(ref _armorStatLabel);
			set => SetProperty(ref _armorStatLabel, value);
		}

		[Ordinal(54)] 
		[RED("quickhackStatWrapper")] 
		public inkWidgetReference QuickhackStatWrapper
		{
			get => GetProperty(ref _quickhackStatWrapper);
			set => SetProperty(ref _quickhackStatWrapper, value);
		}

		[Ordinal(55)] 
		[RED("quickhackCostValue")] 
		public inkTextWidgetReference QuickhackCostValue
		{
			get => GetProperty(ref _quickhackCostValue);
			set => SetProperty(ref _quickhackCostValue, value);
		}

		[Ordinal(56)] 
		[RED("quickhackDuration")] 
		public inkTextWidgetReference QuickhackDuration
		{
			get => GetProperty(ref _quickhackDuration);
			set => SetProperty(ref _quickhackDuration, value);
		}

		[Ordinal(57)] 
		[RED("quickhackCooldown")] 
		public inkTextWidgetReference QuickhackCooldown
		{
			get => GetProperty(ref _quickhackCooldown);
			set => SetProperty(ref _quickhackCooldown, value);
		}

		[Ordinal(58)] 
		[RED("quickhackUpload")] 
		public inkTextWidgetReference QuickhackUpload
		{
			get => GetProperty(ref _quickhackUpload);
			set => SetProperty(ref _quickhackUpload, value);
		}

		[Ordinal(59)] 
		[RED("damageTypeWrapper")] 
		public inkWidgetReference DamageTypeWrapper
		{
			get => GetProperty(ref _damageTypeWrapper);
			set => SetProperty(ref _damageTypeWrapper, value);
		}

		[Ordinal(60)] 
		[RED("damageTypeIcon")] 
		public inkImageWidgetReference DamageTypeIcon
		{
			get => GetProperty(ref _damageTypeIcon);
			set => SetProperty(ref _damageTypeIcon, value);
		}

		[Ordinal(61)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetProperty(ref _equipedWrapper);
			set => SetProperty(ref _equipedWrapper, value);
		}

		[Ordinal(62)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetProperty(ref _itemTypeText);
			set => SetProperty(ref _itemTypeText, value);
		}

		[Ordinal(63)] 
		[RED("itemPreviewWrapper")] 
		public inkWidgetReference ItemPreviewWrapper
		{
			get => GetProperty(ref _itemPreviewWrapper);
			set => SetProperty(ref _itemPreviewWrapper, value);
		}

		[Ordinal(64)] 
		[RED("itemPreviewIcon")] 
		public inkImageWidgetReference ItemPreviewIcon
		{
			get => GetProperty(ref _itemPreviewIcon);
			set => SetProperty(ref _itemPreviewIcon, value);
		}

		[Ordinal(65)] 
		[RED("itemPreviewIconicLines")] 
		public inkWidgetReference ItemPreviewIconicLines
		{
			get => GetProperty(ref _itemPreviewIconicLines);
			set => SetProperty(ref _itemPreviewIconicLines, value);
		}

		[Ordinal(66)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get => GetProperty(ref _itemWeightWrapper);
			set => SetProperty(ref _itemWeightWrapper, value);
		}

		[Ordinal(67)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get => GetProperty(ref _itemWeightText);
			set => SetProperty(ref _itemWeightText, value);
		}

		[Ordinal(68)] 
		[RED("itemAmmoWrapper")] 
		public inkWidgetReference ItemAmmoWrapper
		{
			get => GetProperty(ref _itemAmmoWrapper);
			set => SetProperty(ref _itemAmmoWrapper, value);
		}

		[Ordinal(69)] 
		[RED("itemAmmoText")] 
		public inkTextWidgetReference ItemAmmoText
		{
			get => GetProperty(ref _itemAmmoText);
			set => SetProperty(ref _itemAmmoText, value);
		}

		[Ordinal(70)] 
		[RED("itemRequirements")] 
		public inkWidgetReference ItemRequirements
		{
			get => GetProperty(ref _itemRequirements);
			set => SetProperty(ref _itemRequirements, value);
		}

		[Ordinal(71)] 
		[RED("itemLevelRequirements")] 
		public inkWidgetReference ItemLevelRequirements
		{
			get => GetProperty(ref _itemLevelRequirements);
			set => SetProperty(ref _itemLevelRequirements, value);
		}

		[Ordinal(72)] 
		[RED("itemStrenghtRequirements")] 
		public inkWidgetReference ItemStrenghtRequirements
		{
			get => GetProperty(ref _itemStrenghtRequirements);
			set => SetProperty(ref _itemStrenghtRequirements, value);
		}

		[Ordinal(73)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get => GetProperty(ref _itemAttributeRequirements);
			set => SetProperty(ref _itemAttributeRequirements, value);
		}

		[Ordinal(74)] 
		[RED("itemSmartGunLinkRequirements")] 
		public inkWidgetReference ItemSmartGunLinkRequirements
		{
			get => GetProperty(ref _itemSmartGunLinkRequirements);
			set => SetProperty(ref _itemSmartGunLinkRequirements, value);
		}

		[Ordinal(75)] 
		[RED("itemLevelRequirementsValue")] 
		public inkTextWidgetReference ItemLevelRequirementsValue
		{
			get => GetProperty(ref _itemLevelRequirementsValue);
			set => SetProperty(ref _itemLevelRequirementsValue, value);
		}

		[Ordinal(76)] 
		[RED("itemStrenghtRequirementsValue")] 
		public inkTextWidgetReference ItemStrenghtRequirementsValue
		{
			get => GetProperty(ref _itemStrenghtRequirementsValue);
			set => SetProperty(ref _itemStrenghtRequirementsValue, value);
		}

		[Ordinal(77)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get => GetProperty(ref _itemAttributeRequirementsText);
			set => SetProperty(ref _itemAttributeRequirementsText, value);
		}

		[Ordinal(78)] 
		[RED("weaponEvolutionWrapper")] 
		public inkWidgetReference WeaponEvolutionWrapper
		{
			get => GetProperty(ref _weaponEvolutionWrapper);
			set => SetProperty(ref _weaponEvolutionWrapper, value);
		}

		[Ordinal(79)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get => GetProperty(ref _weaponEvolutionIcon);
			set => SetProperty(ref _weaponEvolutionIcon, value);
		}

		[Ordinal(80)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get => GetProperty(ref _weaponEvolutionName);
			set => SetProperty(ref _weaponEvolutionName, value);
		}

		[Ordinal(81)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get => GetProperty(ref _weaponEvolutionDescription);
			set => SetProperty(ref _weaponEvolutionDescription, value);
		}

		[Ordinal(82)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(83)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(84)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetProperty(ref _dEBUG_showAdditionalInfo);
			set => SetProperty(ref _dEBUG_showAdditionalInfo, value);
		}

		[Ordinal(85)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(86)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(87)] 
		[RED("playAnimation")] 
		public CBool PlayAnimation
		{
			get => GetProperty(ref _playAnimation);
			set => SetProperty(ref _playAnimation, value);
		}
	}
}
