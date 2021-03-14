using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipController : AGenericTooltipController
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
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get
			{
				if (_itemRarityText == null)
				{
					_itemRarityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemRarityText", cr2w, this);
				}
				return _itemRarityText;
			}
			set
			{
				if (_itemRarityText == value)
				{
					return;
				}
				_itemRarityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("recipeStatsTitle")] 
		public inkTextWidgetReference RecipeStatsTitle
		{
			get
			{
				if (_recipeStatsTitle == null)
				{
					_recipeStatsTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "recipeStatsTitle", cr2w, this);
				}
				return _recipeStatsTitle;
			}
			set
			{
				if (_recipeStatsTitle == value)
				{
					return;
				}
				_recipeStatsTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get
			{
				if (_categoriesWrapper == null)
				{
					_categoriesWrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "categoriesWrapper", cr2w, this);
				}
				return _categoriesWrapper;
			}
			set
			{
				if (_categoriesWrapper == value)
				{
					return;
				}
				_categoriesWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get
			{
				if (_backgroundContainer == null)
				{
					_backgroundContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "backgroundContainer", cr2w, this);
				}
				return _backgroundContainer;
			}
			set
			{
				if (_backgroundContainer == value)
				{
					return;
				}
				_backgroundContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get
			{
				if (_topContainer == null)
				{
					_topContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "topContainer", cr2w, this);
				}
				return _topContainer;
			}
			set
			{
				if (_topContainer == value)
				{
					return;
				}
				_topContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get
			{
				if (_headerContainer == null)
				{
					_headerContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerContainer", cr2w, this);
				}
				return _headerContainer;
			}
			set
			{
				if (_headerContainer == value)
				{
					return;
				}
				_headerContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("headerWeaponContainer")] 
		public inkCompoundWidgetReference HeaderWeaponContainer
		{
			get
			{
				if (_headerWeaponContainer == null)
				{
					_headerWeaponContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerWeaponContainer", cr2w, this);
				}
				return _headerWeaponContainer;
			}
			set
			{
				if (_headerWeaponContainer == value)
				{
					return;
				}
				_headerWeaponContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("headerItemContainer")] 
		public inkCompoundWidgetReference HeaderItemContainer
		{
			get
			{
				if (_headerItemContainer == null)
				{
					_headerItemContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerItemContainer", cr2w, this);
				}
				return _headerItemContainer;
			}
			set
			{
				if (_headerItemContainer == value)
				{
					return;
				}
				_headerItemContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("headerGrenadeContainer")] 
		public inkCompoundWidgetReference HeaderGrenadeContainer
		{
			get
			{
				if (_headerGrenadeContainer == null)
				{
					_headerGrenadeContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerGrenadeContainer", cr2w, this);
				}
				return _headerGrenadeContainer;
			}
			set
			{
				if (_headerGrenadeContainer == value)
				{
					return;
				}
				_headerGrenadeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("headerArmorContainer")] 
		public inkCompoundWidgetReference HeaderArmorContainer
		{
			get
			{
				if (_headerArmorContainer == null)
				{
					_headerArmorContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerArmorContainer", cr2w, this);
				}
				return _headerArmorContainer;
			}
			set
			{
				if (_headerArmorContainer == value)
				{
					return;
				}
				_headerArmorContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("primmaryStatsContainer")] 
		public inkCompoundWidgetReference PrimmaryStatsContainer
		{
			get
			{
				if (_primmaryStatsContainer == null)
				{
					_primmaryStatsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "primmaryStatsContainer", cr2w, this);
				}
				return _primmaryStatsContainer;
			}
			set
			{
				if (_primmaryStatsContainer == value)
				{
					return;
				}
				_primmaryStatsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("secondaryStatsContainer")] 
		public inkCompoundWidgetReference SecondaryStatsContainer
		{
			get
			{
				if (_secondaryStatsContainer == null)
				{
					_secondaryStatsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "secondaryStatsContainer", cr2w, this);
				}
				return _secondaryStatsContainer;
			}
			set
			{
				if (_secondaryStatsContainer == value)
				{
					return;
				}
				_secondaryStatsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("recipeStatsContainer")] 
		public inkCompoundWidgetReference RecipeStatsContainer
		{
			get
			{
				if (_recipeStatsContainer == null)
				{
					_recipeStatsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "recipeStatsContainer", cr2w, this);
				}
				return _recipeStatsContainer;
			}
			set
			{
				if (_recipeStatsContainer == value)
				{
					return;
				}
				_recipeStatsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("recipeDamageTypesContainer")] 
		public inkCompoundWidgetReference RecipeDamageTypesContainer
		{
			get
			{
				if (_recipeDamageTypesContainer == null)
				{
					_recipeDamageTypesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "recipeDamageTypesContainer", cr2w, this);
				}
				return _recipeDamageTypesContainer;
			}
			set
			{
				if (_recipeDamageTypesContainer == value)
				{
					return;
				}
				_recipeDamageTypesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get
			{
				if (_modsContainer == null)
				{
					_modsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "modsContainer", cr2w, this);
				}
				return _modsContainer;
			}
			set
			{
				if (_modsContainer == value)
				{
					return;
				}
				_modsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get
			{
				if (_dedicatedModsContainer == null)
				{
					_dedicatedModsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "dedicatedModsContainer", cr2w, this);
				}
				return _dedicatedModsContainer;
			}
			set
			{
				if (_dedicatedModsContainer == value)
				{
					return;
				}
				_dedicatedModsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get
			{
				if (_descriptionContainer == null)
				{
					_descriptionContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "descriptionContainer", cr2w, this);
				}
				return _descriptionContainer;
			}
			set
			{
				if (_descriptionContainer == value)
				{
					return;
				}
				_descriptionContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("craftedItemContainer")] 
		public inkCompoundWidgetReference CraftedItemContainer
		{
			get
			{
				if (_craftedItemContainer == null)
				{
					_craftedItemContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "craftedItemContainer", cr2w, this);
				}
				return _craftedItemContainer;
			}
			set
			{
				if (_craftedItemContainer == value)
				{
					return;
				}
				_craftedItemContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get
			{
				if (_bottomContainer == null)
				{
					_bottomContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "bottomContainer", cr2w, this);
				}
				return _bottomContainer;
			}
			set
			{
				if (_bottomContainer == value)
				{
					return;
				}
				_bottomContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("primmaryStatsList")] 
		public inkCompoundWidgetReference PrimmaryStatsList
		{
			get
			{
				if (_primmaryStatsList == null)
				{
					_primmaryStatsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "primmaryStatsList", cr2w, this);
				}
				return _primmaryStatsList;
			}
			set
			{
				if (_primmaryStatsList == value)
				{
					return;
				}
				_primmaryStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("secondaryStatsList")] 
		public inkCompoundWidgetReference SecondaryStatsList
		{
			get
			{
				if (_secondaryStatsList == null)
				{
					_secondaryStatsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "secondaryStatsList", cr2w, this);
				}
				return _secondaryStatsList;
			}
			set
			{
				if (_secondaryStatsList == value)
				{
					return;
				}
				_secondaryStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("recipeStatsTypesList")] 
		public inkCompoundWidgetReference RecipeStatsTypesList
		{
			get
			{
				if (_recipeStatsTypesList == null)
				{
					_recipeStatsTypesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "recipeStatsTypesList", cr2w, this);
				}
				return _recipeStatsTypesList;
			}
			set
			{
				if (_recipeStatsTypesList == value)
				{
					return;
				}
				_recipeStatsTypesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("recipeDamageTypesList")] 
		public inkCompoundWidgetReference RecipeDamageTypesList
		{
			get
			{
				if (_recipeDamageTypesList == null)
				{
					_recipeDamageTypesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "recipeDamageTypesList", cr2w, this);
				}
				return _recipeDamageTypesList;
			}
			set
			{
				if (_recipeDamageTypesList == value)
				{
					return;
				}
				_recipeDamageTypesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("modsList")] 
		public inkCompoundWidgetReference ModsList
		{
			get
			{
				if (_modsList == null)
				{
					_modsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "modsList", cr2w, this);
				}
				return _modsList;
			}
			set
			{
				if (_modsList == value)
				{
					return;
				}
				_modsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("dedicatedModsList")] 
		public inkCompoundWidgetReference DedicatedModsList
		{
			get
			{
				if (_dedicatedModsList == null)
				{
					_dedicatedModsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "dedicatedModsList", cr2w, this);
				}
				return _dedicatedModsList;
			}
			set
			{
				if (_dedicatedModsList == value)
				{
					return;
				}
				_dedicatedModsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("requiredLevelContainer")] 
		public inkCompoundWidgetReference RequiredLevelContainer
		{
			get
			{
				if (_requiredLevelContainer == null)
				{
					_requiredLevelContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "requiredLevelContainer", cr2w, this);
				}
				return _requiredLevelContainer;
			}
			set
			{
				if (_requiredLevelContainer == value)
				{
					return;
				}
				_requiredLevelContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get
			{
				if (_priceContainer == null)
				{
					_priceContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "priceContainer", cr2w, this);
				}
				return _priceContainer;
			}
			set
			{
				if (_priceContainer == value)
				{
					return;
				}
				_priceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("requireLevelText")] 
		public inkTextWidgetReference RequireLevelText
		{
			get
			{
				if (_requireLevelText == null)
				{
					_requireLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requireLevelText", cr2w, this);
				}
				return _requireLevelText;
			}
			set
			{
				if (_requireLevelText == value)
				{
					return;
				}
				_requireLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get
			{
				if (_dpsWrapper == null)
				{
					_dpsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dpsWrapper", cr2w, this);
				}
				return _dpsWrapper;
			}
			set
			{
				if (_dpsWrapper == value)
				{
					return;
				}
				_dpsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("dpsArrow")] 
		public inkImageWidgetReference DpsArrow
		{
			get
			{
				if (_dpsArrow == null)
				{
					_dpsArrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "dpsArrow", cr2w, this);
				}
				return _dpsArrow;
			}
			set
			{
				if (_dpsArrow == value)
				{
					return;
				}
				_dpsArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get
			{
				if (_dpsText == null)
				{
					_dpsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dpsText", cr2w, this);
				}
				return _dpsText;
			}
			set
			{
				if (_dpsText == value)
				{
					return;
				}
				_dpsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("nonLethalText")] 
		public inkTextWidgetReference NonLethalText
		{
			get
			{
				if (_nonLethalText == null)
				{
					_nonLethalText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nonLethalText", cr2w, this);
				}
				return _nonLethalText;
			}
			set
			{
				if (_nonLethalText == value)
				{
					return;
				}
				_nonLethalText = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("damagePerHitValue")] 
		public inkTextWidgetReference DamagePerHitValue
		{
			get
			{
				if (_damagePerHitValue == null)
				{
					_damagePerHitValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damagePerHitValue", cr2w, this);
				}
				return _damagePerHitValue;
			}
			set
			{
				if (_damagePerHitValue == value)
				{
					return;
				}
				_damagePerHitValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("attacksPerSecondValue")] 
		public inkTextWidgetReference AttacksPerSecondValue
		{
			get
			{
				if (_attacksPerSecondValue == null)
				{
					_attacksPerSecondValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attacksPerSecondValue", cr2w, this);
				}
				return _attacksPerSecondValue;
			}
			set
			{
				if (_attacksPerSecondValue == value)
				{
					return;
				}
				_attacksPerSecondValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("silencerPartWrapper")] 
		public inkWidgetReference SilencerPartWrapper
		{
			get
			{
				if (_silencerPartWrapper == null)
				{
					_silencerPartWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "silencerPartWrapper", cr2w, this);
				}
				return _silencerPartWrapper;
			}
			set
			{
				if (_silencerPartWrapper == value)
				{
					return;
				}
				_silencerPartWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("scopePartWrapper")] 
		public inkWidgetReference ScopePartWrapper
		{
			get
			{
				if (_scopePartWrapper == null)
				{
					_scopePartWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scopePartWrapper", cr2w, this);
				}
				return _scopePartWrapper;
			}
			set
			{
				if (_scopePartWrapper == value)
				{
					return;
				}
				_scopePartWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("craftedItemIcon")] 
		public inkWidgetReference CraftedItemIcon
		{
			get
			{
				if (_craftedItemIcon == null)
				{
					_craftedItemIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "craftedItemIcon", cr2w, this);
				}
				return _craftedItemIcon;
			}
			set
			{
				if (_craftedItemIcon == value)
				{
					return;
				}
				_craftedItemIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("grenadeDamageTypeWrapper")] 
		public inkWidgetReference GrenadeDamageTypeWrapper
		{
			get
			{
				if (_grenadeDamageTypeWrapper == null)
				{
					_grenadeDamageTypeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "grenadeDamageTypeWrapper", cr2w, this);
				}
				return _grenadeDamageTypeWrapper;
			}
			set
			{
				if (_grenadeDamageTypeWrapper == value)
				{
					return;
				}
				_grenadeDamageTypeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("grenadeDamageTypeIcon")] 
		public inkImageWidgetReference GrenadeDamageTypeIcon
		{
			get
			{
				if (_grenadeDamageTypeIcon == null)
				{
					_grenadeDamageTypeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "grenadeDamageTypeIcon", cr2w, this);
				}
				return _grenadeDamageTypeIcon;
			}
			set
			{
				if (_grenadeDamageTypeIcon == value)
				{
					return;
				}
				_grenadeDamageTypeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("grenadeRangeValue")] 
		public inkTextWidgetReference GrenadeRangeValue
		{
			get
			{
				if (_grenadeRangeValue == null)
				{
					_grenadeRangeValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "grenadeRangeValue", cr2w, this);
				}
				return _grenadeRangeValue;
			}
			set
			{
				if (_grenadeRangeValue == value)
				{
					return;
				}
				_grenadeRangeValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("grenadeRangeText")] 
		public inkTextWidgetReference GrenadeRangeText
		{
			get
			{
				if (_grenadeRangeText == null)
				{
					_grenadeRangeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "grenadeRangeText", cr2w, this);
				}
				return _grenadeRangeText;
			}
			set
			{
				if (_grenadeRangeText == value)
				{
					return;
				}
				_grenadeRangeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("grenadeDeliveryLabel")] 
		public inkTextWidgetReference GrenadeDeliveryLabel
		{
			get
			{
				if (_grenadeDeliveryLabel == null)
				{
					_grenadeDeliveryLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "grenadeDeliveryLabel", cr2w, this);
				}
				return _grenadeDeliveryLabel;
			}
			set
			{
				if (_grenadeDeliveryLabel == value)
				{
					return;
				}
				_grenadeDeliveryLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("grenadeDeliveryIcon")] 
		public inkImageWidgetReference GrenadeDeliveryIcon
		{
			get
			{
				if (_grenadeDeliveryIcon == null)
				{
					_grenadeDeliveryIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "grenadeDeliveryIcon", cr2w, this);
				}
				return _grenadeDeliveryIcon;
			}
			set
			{
				if (_grenadeDeliveryIcon == value)
				{
					return;
				}
				_grenadeDeliveryIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("grenadeDamageStatWrapper")] 
		public inkWidgetReference GrenadeDamageStatWrapper
		{
			get
			{
				if (_grenadeDamageStatWrapper == null)
				{
					_grenadeDamageStatWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "grenadeDamageStatWrapper", cr2w, this);
				}
				return _grenadeDamageStatWrapper;
			}
			set
			{
				if (_grenadeDamageStatWrapper == value)
				{
					return;
				}
				_grenadeDamageStatWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("grenadeDamageStatLabel")] 
		public inkTextWidgetReference GrenadeDamageStatLabel
		{
			get
			{
				if (_grenadeDamageStatLabel == null)
				{
					_grenadeDamageStatLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "grenadeDamageStatLabel", cr2w, this);
				}
				return _grenadeDamageStatLabel;
			}
			set
			{
				if (_grenadeDamageStatLabel == value)
				{
					return;
				}
				_grenadeDamageStatLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("grenadeDamageStatValue")] 
		public inkTextWidgetReference GrenadeDamageStatValue
		{
			get
			{
				if (_grenadeDamageStatValue == null)
				{
					_grenadeDamageStatValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "grenadeDamageStatValue", cr2w, this);
				}
				return _grenadeDamageStatValue;
			}
			set
			{
				if (_grenadeDamageStatValue == value)
				{
					return;
				}
				_grenadeDamageStatValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("armorStatArrow")] 
		public inkImageWidgetReference ArmorStatArrow
		{
			get
			{
				if (_armorStatArrow == null)
				{
					_armorStatArrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "armorStatArrow", cr2w, this);
				}
				return _armorStatArrow;
			}
			set
			{
				if (_armorStatArrow == value)
				{
					return;
				}
				_armorStatArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("armorStatLabel")] 
		public inkTextWidgetReference ArmorStatLabel
		{
			get
			{
				if (_armorStatLabel == null)
				{
					_armorStatLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "armorStatLabel", cr2w, this);
				}
				return _armorStatLabel;
			}
			set
			{
				if (_armorStatLabel == value)
				{
					return;
				}
				_armorStatLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("quickhackStatWrapper")] 
		public inkWidgetReference QuickhackStatWrapper
		{
			get
			{
				if (_quickhackStatWrapper == null)
				{
					_quickhackStatWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "quickhackStatWrapper", cr2w, this);
				}
				return _quickhackStatWrapper;
			}
			set
			{
				if (_quickhackStatWrapper == value)
				{
					return;
				}
				_quickhackStatWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("quickhackCostValue")] 
		public inkTextWidgetReference QuickhackCostValue
		{
			get
			{
				if (_quickhackCostValue == null)
				{
					_quickhackCostValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quickhackCostValue", cr2w, this);
				}
				return _quickhackCostValue;
			}
			set
			{
				if (_quickhackCostValue == value)
				{
					return;
				}
				_quickhackCostValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("quickhackDuration")] 
		public inkTextWidgetReference QuickhackDuration
		{
			get
			{
				if (_quickhackDuration == null)
				{
					_quickhackDuration = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quickhackDuration", cr2w, this);
				}
				return _quickhackDuration;
			}
			set
			{
				if (_quickhackDuration == value)
				{
					return;
				}
				_quickhackDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("quickhackCooldown")] 
		public inkTextWidgetReference QuickhackCooldown
		{
			get
			{
				if (_quickhackCooldown == null)
				{
					_quickhackCooldown = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quickhackCooldown", cr2w, this);
				}
				return _quickhackCooldown;
			}
			set
			{
				if (_quickhackCooldown == value)
				{
					return;
				}
				_quickhackCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("quickhackUpload")] 
		public inkTextWidgetReference QuickhackUpload
		{
			get
			{
				if (_quickhackUpload == null)
				{
					_quickhackUpload = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quickhackUpload", cr2w, this);
				}
				return _quickhackUpload;
			}
			set
			{
				if (_quickhackUpload == value)
				{
					return;
				}
				_quickhackUpload = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("damageTypeWrapper")] 
		public inkWidgetReference DamageTypeWrapper
		{
			get
			{
				if (_damageTypeWrapper == null)
				{
					_damageTypeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageTypeWrapper", cr2w, this);
				}
				return _damageTypeWrapper;
			}
			set
			{
				if (_damageTypeWrapper == value)
				{
					return;
				}
				_damageTypeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("damageTypeIcon")] 
		public inkImageWidgetReference DamageTypeIcon
		{
			get
			{
				if (_damageTypeIcon == null)
				{
					_damageTypeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "damageTypeIcon", cr2w, this);
				}
				return _damageTypeIcon;
			}
			set
			{
				if (_damageTypeIcon == value)
				{
					return;
				}
				_damageTypeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get
			{
				if (_equipedWrapper == null)
				{
					_equipedWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equipedWrapper", cr2w, this);
				}
				return _equipedWrapper;
			}
			set
			{
				if (_equipedWrapper == value)
				{
					return;
				}
				_equipedWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get
			{
				if (_itemTypeText == null)
				{
					_itemTypeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemTypeText", cr2w, this);
				}
				return _itemTypeText;
			}
			set
			{
				if (_itemTypeText == value)
				{
					return;
				}
				_itemTypeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("itemPreviewWrapper")] 
		public inkWidgetReference ItemPreviewWrapper
		{
			get
			{
				if (_itemPreviewWrapper == null)
				{
					_itemPreviewWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemPreviewWrapper", cr2w, this);
				}
				return _itemPreviewWrapper;
			}
			set
			{
				if (_itemPreviewWrapper == value)
				{
					return;
				}
				_itemPreviewWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("itemPreviewIcon")] 
		public inkImageWidgetReference ItemPreviewIcon
		{
			get
			{
				if (_itemPreviewIcon == null)
				{
					_itemPreviewIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemPreviewIcon", cr2w, this);
				}
				return _itemPreviewIcon;
			}
			set
			{
				if (_itemPreviewIcon == value)
				{
					return;
				}
				_itemPreviewIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("itemPreviewIconicLines")] 
		public inkWidgetReference ItemPreviewIconicLines
		{
			get
			{
				if (_itemPreviewIconicLines == null)
				{
					_itemPreviewIconicLines = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemPreviewIconicLines", cr2w, this);
				}
				return _itemPreviewIconicLines;
			}
			set
			{
				if (_itemPreviewIconicLines == value)
				{
					return;
				}
				_itemPreviewIconicLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get
			{
				if (_itemWeightWrapper == null)
				{
					_itemWeightWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemWeightWrapper", cr2w, this);
				}
				return _itemWeightWrapper;
			}
			set
			{
				if (_itemWeightWrapper == value)
				{
					return;
				}
				_itemWeightWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get
			{
				if (_itemWeightText == null)
				{
					_itemWeightText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemWeightText", cr2w, this);
				}
				return _itemWeightText;
			}
			set
			{
				if (_itemWeightText == value)
				{
					return;
				}
				_itemWeightText = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("itemAmmoWrapper")] 
		public inkWidgetReference ItemAmmoWrapper
		{
			get
			{
				if (_itemAmmoWrapper == null)
				{
					_itemAmmoWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemAmmoWrapper", cr2w, this);
				}
				return _itemAmmoWrapper;
			}
			set
			{
				if (_itemAmmoWrapper == value)
				{
					return;
				}
				_itemAmmoWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("itemAmmoText")] 
		public inkTextWidgetReference ItemAmmoText
		{
			get
			{
				if (_itemAmmoText == null)
				{
					_itemAmmoText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemAmmoText", cr2w, this);
				}
				return _itemAmmoText;
			}
			set
			{
				if (_itemAmmoText == value)
				{
					return;
				}
				_itemAmmoText = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("itemRequirements")] 
		public inkWidgetReference ItemRequirements
		{
			get
			{
				if (_itemRequirements == null)
				{
					_itemRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRequirements", cr2w, this);
				}
				return _itemRequirements;
			}
			set
			{
				if (_itemRequirements == value)
				{
					return;
				}
				_itemRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("itemLevelRequirements")] 
		public inkWidgetReference ItemLevelRequirements
		{
			get
			{
				if (_itemLevelRequirements == null)
				{
					_itemLevelRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemLevelRequirements", cr2w, this);
				}
				return _itemLevelRequirements;
			}
			set
			{
				if (_itemLevelRequirements == value)
				{
					return;
				}
				_itemLevelRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("itemStrenghtRequirements")] 
		public inkWidgetReference ItemStrenghtRequirements
		{
			get
			{
				if (_itemStrenghtRequirements == null)
				{
					_itemStrenghtRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemStrenghtRequirements", cr2w, this);
				}
				return _itemStrenghtRequirements;
			}
			set
			{
				if (_itemStrenghtRequirements == value)
				{
					return;
				}
				_itemStrenghtRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get
			{
				if (_itemAttributeRequirements == null)
				{
					_itemAttributeRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemAttributeRequirements", cr2w, this);
				}
				return _itemAttributeRequirements;
			}
			set
			{
				if (_itemAttributeRequirements == value)
				{
					return;
				}
				_itemAttributeRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("itemSmartGunLinkRequirements")] 
		public inkWidgetReference ItemSmartGunLinkRequirements
		{
			get
			{
				if (_itemSmartGunLinkRequirements == null)
				{
					_itemSmartGunLinkRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemSmartGunLinkRequirements", cr2w, this);
				}
				return _itemSmartGunLinkRequirements;
			}
			set
			{
				if (_itemSmartGunLinkRequirements == value)
				{
					return;
				}
				_itemSmartGunLinkRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("itemLevelRequirementsValue")] 
		public inkTextWidgetReference ItemLevelRequirementsValue
		{
			get
			{
				if (_itemLevelRequirementsValue == null)
				{
					_itemLevelRequirementsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemLevelRequirementsValue", cr2w, this);
				}
				return _itemLevelRequirementsValue;
			}
			set
			{
				if (_itemLevelRequirementsValue == value)
				{
					return;
				}
				_itemLevelRequirementsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("itemStrenghtRequirementsValue")] 
		public inkTextWidgetReference ItemStrenghtRequirementsValue
		{
			get
			{
				if (_itemStrenghtRequirementsValue == null)
				{
					_itemStrenghtRequirementsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemStrenghtRequirementsValue", cr2w, this);
				}
				return _itemStrenghtRequirementsValue;
			}
			set
			{
				if (_itemStrenghtRequirementsValue == value)
				{
					return;
				}
				_itemStrenghtRequirementsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get
			{
				if (_itemAttributeRequirementsText == null)
				{
					_itemAttributeRequirementsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemAttributeRequirementsText", cr2w, this);
				}
				return _itemAttributeRequirementsText;
			}
			set
			{
				if (_itemAttributeRequirementsText == value)
				{
					return;
				}
				_itemAttributeRequirementsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("weaponEvolutionWrapper")] 
		public inkWidgetReference WeaponEvolutionWrapper
		{
			get
			{
				if (_weaponEvolutionWrapper == null)
				{
					_weaponEvolutionWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "weaponEvolutionWrapper", cr2w, this);
				}
				return _weaponEvolutionWrapper;
			}
			set
			{
				if (_weaponEvolutionWrapper == value)
				{
					return;
				}
				_weaponEvolutionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get
			{
				if (_weaponEvolutionIcon == null)
				{
					_weaponEvolutionIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "weaponEvolutionIcon", cr2w, this);
				}
				return _weaponEvolutionIcon;
			}
			set
			{
				if (_weaponEvolutionIcon == value)
				{
					return;
				}
				_weaponEvolutionIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get
			{
				if (_weaponEvolutionName == null)
				{
					_weaponEvolutionName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponEvolutionName", cr2w, this);
				}
				return _weaponEvolutionName;
			}
			set
			{
				if (_weaponEvolutionName == value)
				{
					return;
				}
				_weaponEvolutionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get
			{
				if (_weaponEvolutionDescription == null)
				{
					_weaponEvolutionDescription = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponEvolutionDescription", cr2w, this);
				}
				return _weaponEvolutionDescription;
			}
			set
			{
				if (_weaponEvolutionDescription == value)
				{
					return;
				}
				_weaponEvolutionDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get
			{
				if (_dEBUG_iconErrorWrapper == null)
				{
					_dEBUG_iconErrorWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "DEBUG_iconErrorWrapper", cr2w, this);
				}
				return _dEBUG_iconErrorWrapper;
			}
			set
			{
				if (_dEBUG_iconErrorWrapper == value)
				{
					return;
				}
				_dEBUG_iconErrorWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get
			{
				if (_dEBUG_iconErrorText == null)
				{
					_dEBUG_iconErrorText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DEBUG_iconErrorText", cr2w, this);
				}
				return _dEBUG_iconErrorText;
			}
			set
			{
				if (_dEBUG_iconErrorText == value)
				{
					return;
				}
				_dEBUG_iconErrorText = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get
			{
				if (_dEBUG_showAdditionalInfo == null)
				{
					_dEBUG_showAdditionalInfo = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_showAdditionalInfo", cr2w, this);
				}
				return _dEBUG_showAdditionalInfo;
			}
			set
			{
				if (_dEBUG_showAdditionalInfo == value)
				{
					return;
				}
				_dEBUG_showAdditionalInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("playAnimation")] 
		public CBool PlayAnimation
		{
			get
			{
				if (_playAnimation == null)
				{
					_playAnimation = (CBool) CR2WTypeManager.Create("Bool", "playAnimation", cr2w, this);
				}
				return _playAnimation;
			}
			set
			{
				if (_playAnimation == value)
				{
					return;
				}
				_playAnimation = value;
				PropertySet(this);
			}
		}

		public ItemTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
