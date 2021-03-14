using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _leftListScrollHolder;
		private inkVirtualCompoundWidgetReference _recipeGrid;
		private inkCompoundWidgetReference _skillWidgetRoot;
		private inkWidgetReference _filterRoot_Crafting;
		private inkWidgetReference _filterGroup_Crafting;
		private inkWidgetReference _sortingButton_Crafting;
		private inkWidgetReference _sortingDropdown_Crafting;
		private inkCompoundWidgetReference _craftingRoot;
		private inkTextWidgetReference _itemName_Crafting;
		private inkTextWidgetReference _itemQuality_Crafting;
		private inkCompoundWidgetReference _ingredientsList_Crafting;
		private inkCompoundWidgetReference _ingredientsListWeapon;
		private inkWidgetReference _itemPreviewContainer;
		private inkWidgetReference _weaponPreviewContainer;
		private inkCompoundWidgetReference _progressBarContainer_Crafting;
		private inkCompoundWidgetReference _progressButtonContainer_Crafting;
		private inkCompoundWidgetReference _tooltipContainer_Crafting;
		private inkWidgetReference _filterRoot_Upgrading;
		private inkWidgetReference _filterGroup_Upgrading;
		private inkWidgetReference _sortingButton_Upgrading;
		private inkWidgetReference _sortingDropdown_Upgrading;
		private inkCompoundWidgetReference _upgradingRoot;
		private inkTextWidgetReference _itemName_Upgrading;
		private inkTextWidgetReference _itemQuality_Upgrading;
		private inkCompoundWidgetReference _ingredientsList_Upgrading;
		private inkCompoundWidgetReference _progressBarContainer_Upgrading;
		private inkCompoundWidgetReference _progressButtonContainer_Upgrading;
		private inkCompoundWidgetReference _tooltipContainer_Upgrading;
		private inkTextWidgetReference _blockedText;
		private inkWidgetReference _perkNotificationContainer;
		private inkTextWidgetReference _perkNotificationText;
		private inkImageWidgetReference _perkIcon;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<CraftingSystem> _craftingSystem;
		private CHandle<CraftBook> _playerCraftBook;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<CraftingItemTemplateClassifier> _craftingClassifier;
		private CHandle<CraftingDataView> _craftingDataView;
		private CHandle<inkScriptableDataSourceWrapper> _craftingDataSource;
		private CHandle<inkVirtualGridController> _virtualCraftingListController;
		private CHandle<inkScrollController> _leftListScrollController;
		private CHandle<UI_CraftingDef> _craftingDef;
		private CHandle<gameIBlackboard> _craftingBlackboard;
		private CUInt32 _craftingBBID;
		private CArray<wCHandle<IngredientListItemLogicController>> _ingredientsControllerList;
		private CInt32 _maxIngredientCraftingCount;
		private CInt32 _maxIngredientUpgradingCount;
		private CEnum<CraftingMode> _mode;
		private CHandle<RecipeData> _selectedRecipe;
		private InventoryItemData _selectedItemData;
		private CHandle<CraftableItemLogicController> _selectedListItem;
		private CEnum<ItemFilterType> _selectedCategory;
		private CHandle<gameItemData> _dryItemData;
		private InventoryItemData _dryInventoryItemData;
		private CBool _isInitializeOver;
		private CArray<CInt32> _craftingFilters;
		private CArray<CInt32> _upgradeFilters;
		private CArray<wCHandle<AGenericTooltipController>> _itemTooltipControllers;
		private CEnum<CraftingInfoType> _tooltipType;
		private wCHandle<ProgressBarButton> _progressButtonController;
		private wCHandle<InventoryItemDisplayController> _itemWeaponController;
		private wCHandle<InventoryItemDisplayController> _itemIngredientController;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get
			{
				if (_tabRootRef == null)
				{
					_tabRootRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tabRootRef", cr2w, this);
				}
				return _tabRootRef;
			}
			set
			{
				if (_tabRootRef == value)
				{
					return;
				}
				_tabRootRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("leftListScrollHolder")] 
		public inkWidgetReference LeftListScrollHolder
		{
			get
			{
				if (_leftListScrollHolder == null)
				{
					_leftListScrollHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftListScrollHolder", cr2w, this);
				}
				return _leftListScrollHolder;
			}
			set
			{
				if (_leftListScrollHolder == value)
				{
					return;
				}
				_leftListScrollHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("recipeGrid")] 
		public inkVirtualCompoundWidgetReference RecipeGrid
		{
			get
			{
				if (_recipeGrid == null)
				{
					_recipeGrid = (inkVirtualCompoundWidgetReference) CR2WTypeManager.Create("inkVirtualCompoundWidgetReference", "recipeGrid", cr2w, this);
				}
				return _recipeGrid;
			}
			set
			{
				if (_recipeGrid == value)
				{
					return;
				}
				_recipeGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("skillWidgetRoot")] 
		public inkCompoundWidgetReference SkillWidgetRoot
		{
			get
			{
				if (_skillWidgetRoot == null)
				{
					_skillWidgetRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skillWidgetRoot", cr2w, this);
				}
				return _skillWidgetRoot;
			}
			set
			{
				if (_skillWidgetRoot == value)
				{
					return;
				}
				_skillWidgetRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("filterRoot_Crafting")] 
		public inkWidgetReference FilterRoot_Crafting
		{
			get
			{
				if (_filterRoot_Crafting == null)
				{
					_filterRoot_Crafting = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filterRoot_Crafting", cr2w, this);
				}
				return _filterRoot_Crafting;
			}
			set
			{
				if (_filterRoot_Crafting == value)
				{
					return;
				}
				_filterRoot_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("filterGroup_Crafting")] 
		public inkWidgetReference FilterGroup_Crafting
		{
			get
			{
				if (_filterGroup_Crafting == null)
				{
					_filterGroup_Crafting = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filterGroup_Crafting", cr2w, this);
				}
				return _filterGroup_Crafting;
			}
			set
			{
				if (_filterGroup_Crafting == value)
				{
					return;
				}
				_filterGroup_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("sortingButton_Crafting")] 
		public inkWidgetReference SortingButton_Crafting
		{
			get
			{
				if (_sortingButton_Crafting == null)
				{
					_sortingButton_Crafting = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingButton_Crafting", cr2w, this);
				}
				return _sortingButton_Crafting;
			}
			set
			{
				if (_sortingButton_Crafting == value)
				{
					return;
				}
				_sortingButton_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sortingDropdown_Crafting")] 
		public inkWidgetReference SortingDropdown_Crafting
		{
			get
			{
				if (_sortingDropdown_Crafting == null)
				{
					_sortingDropdown_Crafting = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingDropdown_Crafting", cr2w, this);
				}
				return _sortingDropdown_Crafting;
			}
			set
			{
				if (_sortingDropdown_Crafting == value)
				{
					return;
				}
				_sortingDropdown_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("craftingRoot")] 
		public inkCompoundWidgetReference CraftingRoot
		{
			get
			{
				if (_craftingRoot == null)
				{
					_craftingRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "craftingRoot", cr2w, this);
				}
				return _craftingRoot;
			}
			set
			{
				if (_craftingRoot == value)
				{
					return;
				}
				_craftingRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("itemName_Crafting")] 
		public inkTextWidgetReference ItemName_Crafting
		{
			get
			{
				if (_itemName_Crafting == null)
				{
					_itemName_Crafting = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName_Crafting", cr2w, this);
				}
				return _itemName_Crafting;
			}
			set
			{
				if (_itemName_Crafting == value)
				{
					return;
				}
				_itemName_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("itemQuality_Crafting")] 
		public inkTextWidgetReference ItemQuality_Crafting
		{
			get
			{
				if (_itemQuality_Crafting == null)
				{
					_itemQuality_Crafting = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemQuality_Crafting", cr2w, this);
				}
				return _itemQuality_Crafting;
			}
			set
			{
				if (_itemQuality_Crafting == value)
				{
					return;
				}
				_itemQuality_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ingredientsList_Crafting")] 
		public inkCompoundWidgetReference IngredientsList_Crafting
		{
			get
			{
				if (_ingredientsList_Crafting == null)
				{
					_ingredientsList_Crafting = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ingredientsList_Crafting", cr2w, this);
				}
				return _ingredientsList_Crafting;
			}
			set
			{
				if (_ingredientsList_Crafting == value)
				{
					return;
				}
				_ingredientsList_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ingredientsListWeapon")] 
		public inkCompoundWidgetReference IngredientsListWeapon
		{
			get
			{
				if (_ingredientsListWeapon == null)
				{
					_ingredientsListWeapon = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ingredientsListWeapon", cr2w, this);
				}
				return _ingredientsListWeapon;
			}
			set
			{
				if (_ingredientsListWeapon == value)
				{
					return;
				}
				_ingredientsListWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get
			{
				if (_itemPreviewContainer == null)
				{
					_itemPreviewContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemPreviewContainer", cr2w, this);
				}
				return _itemPreviewContainer;
			}
			set
			{
				if (_itemPreviewContainer == value)
				{
					return;
				}
				_itemPreviewContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get
			{
				if (_weaponPreviewContainer == null)
				{
					_weaponPreviewContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "weaponPreviewContainer", cr2w, this);
				}
				return _weaponPreviewContainer;
			}
			set
			{
				if (_weaponPreviewContainer == value)
				{
					return;
				}
				_weaponPreviewContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("progressBarContainer_Crafting")] 
		public inkCompoundWidgetReference ProgressBarContainer_Crafting
		{
			get
			{
				if (_progressBarContainer_Crafting == null)
				{
					_progressBarContainer_Crafting = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "progressBarContainer_Crafting", cr2w, this);
				}
				return _progressBarContainer_Crafting;
			}
			set
			{
				if (_progressBarContainer_Crafting == value)
				{
					return;
				}
				_progressBarContainer_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("progressButtonContainer_Crafting")] 
		public inkCompoundWidgetReference ProgressButtonContainer_Crafting
		{
			get
			{
				if (_progressButtonContainer_Crafting == null)
				{
					_progressButtonContainer_Crafting = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "progressButtonContainer_Crafting", cr2w, this);
				}
				return _progressButtonContainer_Crafting;
			}
			set
			{
				if (_progressButtonContainer_Crafting == value)
				{
					return;
				}
				_progressButtonContainer_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("tooltipContainer_Crafting")] 
		public inkCompoundWidgetReference TooltipContainer_Crafting
		{
			get
			{
				if (_tooltipContainer_Crafting == null)
				{
					_tooltipContainer_Crafting = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tooltipContainer_Crafting", cr2w, this);
				}
				return _tooltipContainer_Crafting;
			}
			set
			{
				if (_tooltipContainer_Crafting == value)
				{
					return;
				}
				_tooltipContainer_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("filterRoot_Upgrading")] 
		public inkWidgetReference FilterRoot_Upgrading
		{
			get
			{
				if (_filterRoot_Upgrading == null)
				{
					_filterRoot_Upgrading = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filterRoot_Upgrading", cr2w, this);
				}
				return _filterRoot_Upgrading;
			}
			set
			{
				if (_filterRoot_Upgrading == value)
				{
					return;
				}
				_filterRoot_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("filterGroup_Upgrading")] 
		public inkWidgetReference FilterGroup_Upgrading
		{
			get
			{
				if (_filterGroup_Upgrading == null)
				{
					_filterGroup_Upgrading = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filterGroup_Upgrading", cr2w, this);
				}
				return _filterGroup_Upgrading;
			}
			set
			{
				if (_filterGroup_Upgrading == value)
				{
					return;
				}
				_filterGroup_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("sortingButton_Upgrading")] 
		public inkWidgetReference SortingButton_Upgrading
		{
			get
			{
				if (_sortingButton_Upgrading == null)
				{
					_sortingButton_Upgrading = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingButton_Upgrading", cr2w, this);
				}
				return _sortingButton_Upgrading;
			}
			set
			{
				if (_sortingButton_Upgrading == value)
				{
					return;
				}
				_sortingButton_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("sortingDropdown_Upgrading")] 
		public inkWidgetReference SortingDropdown_Upgrading
		{
			get
			{
				if (_sortingDropdown_Upgrading == null)
				{
					_sortingDropdown_Upgrading = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sortingDropdown_Upgrading", cr2w, this);
				}
				return _sortingDropdown_Upgrading;
			}
			set
			{
				if (_sortingDropdown_Upgrading == value)
				{
					return;
				}
				_sortingDropdown_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("upgradingRoot")] 
		public inkCompoundWidgetReference UpgradingRoot
		{
			get
			{
				if (_upgradingRoot == null)
				{
					_upgradingRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "upgradingRoot", cr2w, this);
				}
				return _upgradingRoot;
			}
			set
			{
				if (_upgradingRoot == value)
				{
					return;
				}
				_upgradingRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("itemName_Upgrading")] 
		public inkTextWidgetReference ItemName_Upgrading
		{
			get
			{
				if (_itemName_Upgrading == null)
				{
					_itemName_Upgrading = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName_Upgrading", cr2w, this);
				}
				return _itemName_Upgrading;
			}
			set
			{
				if (_itemName_Upgrading == value)
				{
					return;
				}
				_itemName_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("itemQuality_Upgrading")] 
		public inkTextWidgetReference ItemQuality_Upgrading
		{
			get
			{
				if (_itemQuality_Upgrading == null)
				{
					_itemQuality_Upgrading = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemQuality_Upgrading", cr2w, this);
				}
				return _itemQuality_Upgrading;
			}
			set
			{
				if (_itemQuality_Upgrading == value)
				{
					return;
				}
				_itemQuality_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ingredientsList_Upgrading")] 
		public inkCompoundWidgetReference IngredientsList_Upgrading
		{
			get
			{
				if (_ingredientsList_Upgrading == null)
				{
					_ingredientsList_Upgrading = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ingredientsList_Upgrading", cr2w, this);
				}
				return _ingredientsList_Upgrading;
			}
			set
			{
				if (_ingredientsList_Upgrading == value)
				{
					return;
				}
				_ingredientsList_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("progressBarContainer_Upgrading")] 
		public inkCompoundWidgetReference ProgressBarContainer_Upgrading
		{
			get
			{
				if (_progressBarContainer_Upgrading == null)
				{
					_progressBarContainer_Upgrading = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "progressBarContainer_Upgrading", cr2w, this);
				}
				return _progressBarContainer_Upgrading;
			}
			set
			{
				if (_progressBarContainer_Upgrading == value)
				{
					return;
				}
				_progressBarContainer_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("progressButtonContainer_Upgrading")] 
		public inkCompoundWidgetReference ProgressButtonContainer_Upgrading
		{
			get
			{
				if (_progressButtonContainer_Upgrading == null)
				{
					_progressButtonContainer_Upgrading = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "progressButtonContainer_Upgrading", cr2w, this);
				}
				return _progressButtonContainer_Upgrading;
			}
			set
			{
				if (_progressButtonContainer_Upgrading == value)
				{
					return;
				}
				_progressButtonContainer_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("tooltipContainer_Upgrading")] 
		public inkCompoundWidgetReference TooltipContainer_Upgrading
		{
			get
			{
				if (_tooltipContainer_Upgrading == null)
				{
					_tooltipContainer_Upgrading = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tooltipContainer_Upgrading", cr2w, this);
				}
				return _tooltipContainer_Upgrading;
			}
			set
			{
				if (_tooltipContainer_Upgrading == value)
				{
					return;
				}
				_tooltipContainer_Upgrading = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("BlockedText")] 
		public inkTextWidgetReference BlockedText
		{
			get
			{
				if (_blockedText == null)
				{
					_blockedText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "BlockedText", cr2w, this);
				}
				return _blockedText;
			}
			set
			{
				if (_blockedText == value)
				{
					return;
				}
				_blockedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get
			{
				if (_perkNotificationContainer == null)
				{
					_perkNotificationContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "perkNotificationContainer", cr2w, this);
				}
				return _perkNotificationContainer;
			}
			set
			{
				if (_perkNotificationContainer == value)
				{
					return;
				}
				_perkNotificationContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get
			{
				if (_perkNotificationText == null)
				{
					_perkNotificationText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "perkNotificationText", cr2w, this);
				}
				return _perkNotificationText;
			}
			set
			{
				if (_perkNotificationText == value)
				{
					return;
				}
				_perkNotificationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get
			{
				if (_perkIcon == null)
				{
					_perkIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "perkIcon", cr2w, this);
				}
				return _perkIcon;
			}
			set
			{
				if (_perkIcon == value)
				{
					return;
				}
				_perkIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get
			{
				if (_craftingSystem == null)
				{
					_craftingSystem = (CHandle<CraftingSystem>) CR2WTypeManager.Create("handle:CraftingSystem", "craftingSystem", cr2w, this);
				}
				return _craftingSystem;
			}
			set
			{
				if (_craftingSystem == value)
				{
					return;
				}
				_craftingSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get
			{
				if (_playerCraftBook == null)
				{
					_playerCraftBook = (CHandle<CraftBook>) CR2WTypeManager.Create("handle:CraftBook", "playerCraftBook", cr2w, this);
				}
				return _playerCraftBook;
			}
			set
			{
				if (_playerCraftBook == value)
				{
					return;
				}
				_playerCraftBook = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get
			{
				if (_vendorDataManager == null)
				{
					_vendorDataManager = (CHandle<VendorDataManager>) CR2WTypeManager.Create("handle:VendorDataManager", "VendorDataManager", cr2w, this);
				}
				return _vendorDataManager;
			}
			set
			{
				if (_vendorDataManager == value)
				{
					return;
				}
				_vendorDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (wCHandle<UIScriptableSystem>) CR2WTypeManager.Create("whandle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
				}
				return _uiScriptableSystem;
			}
			set
			{
				if (_uiScriptableSystem == value)
				{
					return;
				}
				_uiScriptableSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get
			{
				if (_weaponAreas == null)
				{
					_weaponAreas = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "WeaponAreas", cr2w, this);
				}
				return _weaponAreas;
			}
			set
			{
				if (_weaponAreas == value)
				{
					return;
				}
				_weaponAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get
			{
				if (_equipAreas == null)
				{
					_equipAreas = (CArray<CEnum<gamedataEquipmentArea>>) CR2WTypeManager.Create("array:gamedataEquipmentArea", "EquipAreas", cr2w, this);
				}
				return _equipAreas;
			}
			set
			{
				if (_equipAreas == value)
				{
					return;
				}
				_equipAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("craftingClassifier")] 
		public CHandle<CraftingItemTemplateClassifier> CraftingClassifier
		{
			get
			{
				if (_craftingClassifier == null)
				{
					_craftingClassifier = (CHandle<CraftingItemTemplateClassifier>) CR2WTypeManager.Create("handle:CraftingItemTemplateClassifier", "craftingClassifier", cr2w, this);
				}
				return _craftingClassifier;
			}
			set
			{
				if (_craftingClassifier == value)
				{
					return;
				}
				_craftingClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("craftingDataView")] 
		public CHandle<CraftingDataView> CraftingDataView
		{
			get
			{
				if (_craftingDataView == null)
				{
					_craftingDataView = (CHandle<CraftingDataView>) CR2WTypeManager.Create("handle:CraftingDataView", "craftingDataView", cr2w, this);
				}
				return _craftingDataView;
			}
			set
			{
				if (_craftingDataView == value)
				{
					return;
				}
				_craftingDataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("craftingDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> CraftingDataSource
		{
			get
			{
				if (_craftingDataSource == null)
				{
					_craftingDataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "craftingDataSource", cr2w, this);
				}
				return _craftingDataSource;
			}
			set
			{
				if (_craftingDataSource == value)
				{
					return;
				}
				_craftingDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("virtualCraftingListController")] 
		public CHandle<inkVirtualGridController> VirtualCraftingListController
		{
			get
			{
				if (_virtualCraftingListController == null)
				{
					_virtualCraftingListController = (CHandle<inkVirtualGridController>) CR2WTypeManager.Create("handle:inkVirtualGridController", "virtualCraftingListController", cr2w, this);
				}
				return _virtualCraftingListController;
			}
			set
			{
				if (_virtualCraftingListController == value)
				{
					return;
				}
				_virtualCraftingListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("leftListScrollController")] 
		public CHandle<inkScrollController> LeftListScrollController
		{
			get
			{
				if (_leftListScrollController == null)
				{
					_leftListScrollController = (CHandle<inkScrollController>) CR2WTypeManager.Create("handle:inkScrollController", "leftListScrollController", cr2w, this);
				}
				return _leftListScrollController;
			}
			set
			{
				if (_leftListScrollController == value)
				{
					return;
				}
				_leftListScrollController = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("craftingDef")] 
		public CHandle<UI_CraftingDef> CraftingDef
		{
			get
			{
				if (_craftingDef == null)
				{
					_craftingDef = (CHandle<UI_CraftingDef>) CR2WTypeManager.Create("handle:UI_CraftingDef", "craftingDef", cr2w, this);
				}
				return _craftingDef;
			}
			set
			{
				if (_craftingDef == value)
				{
					return;
				}
				_craftingDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("craftingBlackboard")] 
		public CHandle<gameIBlackboard> CraftingBlackboard
		{
			get
			{
				if (_craftingBlackboard == null)
				{
					_craftingBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "craftingBlackboard", cr2w, this);
				}
				return _craftingBlackboard;
			}
			set
			{
				if (_craftingBlackboard == value)
				{
					return;
				}
				_craftingBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("craftingBBID")] 
		public CUInt32 CraftingBBID
		{
			get
			{
				if (_craftingBBID == null)
				{
					_craftingBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "craftingBBID", cr2w, this);
				}
				return _craftingBBID;
			}
			set
			{
				if (_craftingBBID == value)
				{
					return;
				}
				_craftingBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("ingredientsControllerList")] 
		public CArray<wCHandle<IngredientListItemLogicController>> IngredientsControllerList
		{
			get
			{
				if (_ingredientsControllerList == null)
				{
					_ingredientsControllerList = (CArray<wCHandle<IngredientListItemLogicController>>) CR2WTypeManager.Create("array:whandle:IngredientListItemLogicController", "ingredientsControllerList", cr2w, this);
				}
				return _ingredientsControllerList;
			}
			set
			{
				if (_ingredientsControllerList == value)
				{
					return;
				}
				_ingredientsControllerList = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("maxIngredientCraftingCount")] 
		public CInt32 MaxIngredientCraftingCount
		{
			get
			{
				if (_maxIngredientCraftingCount == null)
				{
					_maxIngredientCraftingCount = (CInt32) CR2WTypeManager.Create("Int32", "maxIngredientCraftingCount", cr2w, this);
				}
				return _maxIngredientCraftingCount;
			}
			set
			{
				if (_maxIngredientCraftingCount == value)
				{
					return;
				}
				_maxIngredientCraftingCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("maxIngredientUpgradingCount")] 
		public CInt32 MaxIngredientUpgradingCount
		{
			get
			{
				if (_maxIngredientUpgradingCount == null)
				{
					_maxIngredientUpgradingCount = (CInt32) CR2WTypeManager.Create("Int32", "maxIngredientUpgradingCount", cr2w, this);
				}
				return _maxIngredientUpgradingCount;
			}
			set
			{
				if (_maxIngredientUpgradingCount == value)
				{
					return;
				}
				_maxIngredientUpgradingCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("mode")] 
		public CEnum<CraftingMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<CraftingMode>) CR2WTypeManager.Create("CraftingMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("selectedRecipe")] 
		public CHandle<RecipeData> SelectedRecipe
		{
			get
			{
				if (_selectedRecipe == null)
				{
					_selectedRecipe = (CHandle<RecipeData>) CR2WTypeManager.Create("handle:RecipeData", "selectedRecipe", cr2w, this);
				}
				return _selectedRecipe;
			}
			set
			{
				if (_selectedRecipe == value)
				{
					return;
				}
				_selectedRecipe = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("selectedItemData")] 
		public InventoryItemData SelectedItemData
		{
			get
			{
				if (_selectedItemData == null)
				{
					_selectedItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "selectedItemData", cr2w, this);
				}
				return _selectedItemData;
			}
			set
			{
				if (_selectedItemData == value)
				{
					return;
				}
				_selectedItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("selectedListItem")] 
		public CHandle<CraftableItemLogicController> SelectedListItem
		{
			get
			{
				if (_selectedListItem == null)
				{
					_selectedListItem = (CHandle<CraftableItemLogicController>) CR2WTypeManager.Create("handle:CraftableItemLogicController", "selectedListItem", cr2w, this);
				}
				return _selectedListItem;
			}
			set
			{
				if (_selectedListItem == value)
				{
					return;
				}
				_selectedListItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("selectedCategory")] 
		public CEnum<ItemFilterType> SelectedCategory
		{
			get
			{
				if (_selectedCategory == null)
				{
					_selectedCategory = (CEnum<ItemFilterType>) CR2WTypeManager.Create("ItemFilterType", "selectedCategory", cr2w, this);
				}
				return _selectedCategory;
			}
			set
			{
				if (_selectedCategory == value)
				{
					return;
				}
				_selectedCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("dryItemData")] 
		public CHandle<gameItemData> DryItemData
		{
			get
			{
				if (_dryItemData == null)
				{
					_dryItemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "dryItemData", cr2w, this);
				}
				return _dryItemData;
			}
			set
			{
				if (_dryItemData == value)
				{
					return;
				}
				_dryItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("dryInventoryItemData")] 
		public InventoryItemData DryInventoryItemData
		{
			get
			{
				if (_dryInventoryItemData == null)
				{
					_dryInventoryItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "dryInventoryItemData", cr2w, this);
				}
				return _dryInventoryItemData;
			}
			set
			{
				if (_dryInventoryItemData == value)
				{
					return;
				}
				_dryInventoryItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("isInitializeOver")] 
		public CBool IsInitializeOver
		{
			get
			{
				if (_isInitializeOver == null)
				{
					_isInitializeOver = (CBool) CR2WTypeManager.Create("Bool", "isInitializeOver", cr2w, this);
				}
				return _isInitializeOver;
			}
			set
			{
				if (_isInitializeOver == value)
				{
					return;
				}
				_isInitializeOver = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("craftingFilters")] 
		public CArray<CInt32> CraftingFilters
		{
			get
			{
				if (_craftingFilters == null)
				{
					_craftingFilters = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "craftingFilters", cr2w, this);
				}
				return _craftingFilters;
			}
			set
			{
				if (_craftingFilters == value)
				{
					return;
				}
				_craftingFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("upgradeFilters")] 
		public CArray<CInt32> UpgradeFilters
		{
			get
			{
				if (_upgradeFilters == null)
				{
					_upgradeFilters = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "upgradeFilters", cr2w, this);
				}
				return _upgradeFilters;
			}
			set
			{
				if (_upgradeFilters == value)
				{
					return;
				}
				_upgradeFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("itemTooltipControllers")] 
		public CArray<wCHandle<AGenericTooltipController>> ItemTooltipControllers
		{
			get
			{
				if (_itemTooltipControllers == null)
				{
					_itemTooltipControllers = (CArray<wCHandle<AGenericTooltipController>>) CR2WTypeManager.Create("array:whandle:AGenericTooltipController", "itemTooltipControllers", cr2w, this);
				}
				return _itemTooltipControllers;
			}
			set
			{
				if (_itemTooltipControllers == value)
				{
					return;
				}
				_itemTooltipControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("tooltipType")] 
		public CEnum<CraftingInfoType> TooltipType
		{
			get
			{
				if (_tooltipType == null)
				{
					_tooltipType = (CEnum<CraftingInfoType>) CR2WTypeManager.Create("CraftingInfoType", "tooltipType", cr2w, this);
				}
				return _tooltipType;
			}
			set
			{
				if (_tooltipType == value)
				{
					return;
				}
				_tooltipType = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("progressButtonController")] 
		public wCHandle<ProgressBarButton> ProgressButtonController
		{
			get
			{
				if (_progressButtonController == null)
				{
					_progressButtonController = (wCHandle<ProgressBarButton>) CR2WTypeManager.Create("whandle:ProgressBarButton", "progressButtonController", cr2w, this);
				}
				return _progressButtonController;
			}
			set
			{
				if (_progressButtonController == value)
				{
					return;
				}
				_progressButtonController = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("itemWeaponController")] 
		public wCHandle<InventoryItemDisplayController> ItemWeaponController
		{
			get
			{
				if (_itemWeaponController == null)
				{
					_itemWeaponController = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "itemWeaponController", cr2w, this);
				}
				return _itemWeaponController;
			}
			set
			{
				if (_itemWeaponController == value)
				{
					return;
				}
				_itemWeaponController = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("itemIngredientController")] 
		public wCHandle<InventoryItemDisplayController> ItemIngredientController
		{
			get
			{
				if (_itemIngredientController == null)
				{
					_itemIngredientController = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "itemIngredientController", cr2w, this);
				}
				return _itemIngredientController;
			}
			set
			{
				if (_itemIngredientController == value)
				{
					return;
				}
				_itemIngredientController = value;
				PropertySet(this);
			}
		}

		public CraftingMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
