using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayController : BaseButtonView
	{
		private inkWidgetReference _widgetWrapper;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemPrice;
		private inkWidgetReference _itemRarity;
		private inkCompoundWidgetReference _commonModsRoot;
		private inkImageWidgetReference _itemImage;
		private inkImageWidgetReference _itemFallbackImage;
		private inkImageWidgetReference _itemEmptyImage;
		private inkWidgetReference _itemSelectedArrow;
		private inkWidgetReference _quantintyAmmoIcon;
		private inkCompoundWidgetReference _quantityWrapper;
		private inkTextWidgetReference _quantityText;
		private inkTextWidgetReference _weaponType;
		private CArray<inkWidgetReference> _highlightFrames;
		private CArray<inkWidgetReference> _equippedWidgets;
		private CArray<inkWidgetReference> _hideWhenEquippedWidgets;
		private CArray<inkWidgetReference> _showInEmptyWidgets;
		private CArray<inkWidgetReference> _hideInEmptyWidgets;
		private CArray<inkWidgetReference> _backgroundFrames;
		private inkWidgetReference _requirementsWrapper;
		private inkWidgetReference _iconicTint;
		private inkWidgetReference _rarityWrapper;
		private inkWidgetReference _rarityCommonWrapper;
		private inkImageWidgetReference _weaponTypeImage;
		private inkWidgetReference _questItemMaker;
		private inkWidgetReference _equippedMarker;
		private inkCompoundWidgetReference _labelsContainer;
		private inkWidgetReference _backgroundBlueprint;
		private inkWidgetReference _iconBlueprint;
		private inkImageWidgetReference _fluffBlueprint;
		private inkWidgetReference _lootitemflufficon;
		private inkImageWidgetReference _lootitemtypeicon;
		private inkWidgetReference _slotItemsCountWrapper;
		private inkTextWidgetReference _slotItemsCount;
		private inkWidgetReference _iconErrorIndicator;
		private inkWidgetReference _newItemsWrapper;
		private inkTextWidgetReference _newItemsCounter;
		private inkWidgetReference _lockIcon;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private gameItemID _itemID;
		private CBool _hasRecipe;
		private InventoryItemData _itemData;
		private CHandle<RecipeData> _recipeData;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataItemType> _itemType;
		private CName _emptySlotImage;
		private CString _slotName;
		private CInt32 _slotIndex;
		private CArray<wCHandle<InventoryItemModSlotDisplay>> _attachmentsDisplay;
		private TweakDBID _slotID;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private wCHandle<ItemLabelContainerController> _labelsContainerController;
		private CName _defaultFallbackImage;
		private CName _defaultEmptyImage;
		private CString _defaultEmptyImageAtlas;
		private CName _emptyImage;
		private CString _emptyImageAtlas;
		private CBool _enoughMoney;
		private CBool _owned;
		private CBool _requirementsMet;
		private CHandle<InventoryTooltipData> _tooltipData;
		private CBool _isNew;
		private CArray<gameItemID> _newItemsIDs;
		private CBool _newItemsFetched;
		private CBool _isBuybackStack;
		private wCHandle<gameItemData> _parentItemData;
		private CBool _isLocked;
		private CBool _dEBUG_isIconError;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;
		private CString _dEBUG_resolvedIconName;
		private CString _dEBUG_recordItemName;
		private CString _dEBUG_innerItemName;
		private CBool _dEBUG_isIconManuallySet;
		private CBool _dEBUG_iconsNameResolverIsDebug;
		private wCHandle<WrappedInventoryItemData> _parrentWrappedDataObject;

		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get
			{
				if (_widgetWrapper == null)
				{
					_widgetWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetWrapper", cr2w, this);
				}
				return _widgetWrapper;
			}
			set
			{
				if (_widgetWrapper == value)
				{
					return;
				}
				_widgetWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get
			{
				if (_itemPrice == null)
				{
					_itemPrice = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemPrice", cr2w, this);
				}
				return _itemPrice;
			}
			set
			{
				if (_itemPrice == value)
				{
					return;
				}
				_itemPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get
			{
				if (_itemRarity == null)
				{
					_itemRarity = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRarity", cr2w, this);
				}
				return _itemRarity;
			}
			set
			{
				if (_itemRarity == value)
				{
					return;
				}
				_itemRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("commonModsRoot")] 
		public inkCompoundWidgetReference CommonModsRoot
		{
			get
			{
				if (_commonModsRoot == null)
				{
					_commonModsRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "commonModsRoot", cr2w, this);
				}
				return _commonModsRoot;
			}
			set
			{
				if (_commonModsRoot == value)
				{
					return;
				}
				_commonModsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get
			{
				if (_itemImage == null)
				{
					_itemImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemImage", cr2w, this);
				}
				return _itemImage;
			}
			set
			{
				if (_itemImage == value)
				{
					return;
				}
				_itemImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemFallbackImage")] 
		public inkImageWidgetReference ItemFallbackImage
		{
			get
			{
				if (_itemFallbackImage == null)
				{
					_itemFallbackImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemFallbackImage", cr2w, this);
				}
				return _itemFallbackImage;
			}
			set
			{
				if (_itemFallbackImage == value)
				{
					return;
				}
				_itemFallbackImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemEmptyImage")] 
		public inkImageWidgetReference ItemEmptyImage
		{
			get
			{
				if (_itemEmptyImage == null)
				{
					_itemEmptyImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemEmptyImage", cr2w, this);
				}
				return _itemEmptyImage;
			}
			set
			{
				if (_itemEmptyImage == value)
				{
					return;
				}
				_itemEmptyImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemSelectedArrow")] 
		public inkWidgetReference ItemSelectedArrow
		{
			get
			{
				if (_itemSelectedArrow == null)
				{
					_itemSelectedArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemSelectedArrow", cr2w, this);
				}
				return _itemSelectedArrow;
			}
			set
			{
				if (_itemSelectedArrow == value)
				{
					return;
				}
				_itemSelectedArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("quantintyAmmoIcon")] 
		public inkWidgetReference QuantintyAmmoIcon
		{
			get
			{
				if (_quantintyAmmoIcon == null)
				{
					_quantintyAmmoIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "quantintyAmmoIcon", cr2w, this);
				}
				return _quantintyAmmoIcon;
			}
			set
			{
				if (_quantintyAmmoIcon == value)
				{
					return;
				}
				_quantintyAmmoIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("quantityWrapper")] 
		public inkCompoundWidgetReference QuantityWrapper
		{
			get
			{
				if (_quantityWrapper == null)
				{
					_quantityWrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "quantityWrapper", cr2w, this);
				}
				return _quantityWrapper;
			}
			set
			{
				if (_quantityWrapper == value)
				{
					return;
				}
				_quantityWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get
			{
				if (_quantityText == null)
				{
					_quantityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityText", cr2w, this);
				}
				return _quantityText;
			}
			set
			{
				if (_quantityText == value)
				{
					return;
				}
				_quantityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("weaponType")] 
		public inkTextWidgetReference WeaponType
		{
			get
			{
				if (_weaponType == null)
				{
					_weaponType = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponType", cr2w, this);
				}
				return _weaponType;
			}
			set
			{
				if (_weaponType == value)
				{
					return;
				}
				_weaponType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get
			{
				if (_highlightFrames == null)
				{
					_highlightFrames = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "highlightFrames", cr2w, this);
				}
				return _highlightFrames;
			}
			set
			{
				if (_highlightFrames == value)
				{
					return;
				}
				_highlightFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("equippedWidgets")] 
		public CArray<inkWidgetReference> EquippedWidgets
		{
			get
			{
				if (_equippedWidgets == null)
				{
					_equippedWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "equippedWidgets", cr2w, this);
				}
				return _equippedWidgets;
			}
			set
			{
				if (_equippedWidgets == value)
				{
					return;
				}
				_equippedWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hideWhenEquippedWidgets")] 
		public CArray<inkWidgetReference> HideWhenEquippedWidgets
		{
			get
			{
				if (_hideWhenEquippedWidgets == null)
				{
					_hideWhenEquippedWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "hideWhenEquippedWidgets", cr2w, this);
				}
				return _hideWhenEquippedWidgets;
			}
			set
			{
				if (_hideWhenEquippedWidgets == value)
				{
					return;
				}
				_hideWhenEquippedWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("showInEmptyWidgets")] 
		public CArray<inkWidgetReference> ShowInEmptyWidgets
		{
			get
			{
				if (_showInEmptyWidgets == null)
				{
					_showInEmptyWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "showInEmptyWidgets", cr2w, this);
				}
				return _showInEmptyWidgets;
			}
			set
			{
				if (_showInEmptyWidgets == value)
				{
					return;
				}
				_showInEmptyWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("hideInEmptyWidgets")] 
		public CArray<inkWidgetReference> HideInEmptyWidgets
		{
			get
			{
				if (_hideInEmptyWidgets == null)
				{
					_hideInEmptyWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "hideInEmptyWidgets", cr2w, this);
				}
				return _hideInEmptyWidgets;
			}
			set
			{
				if (_hideInEmptyWidgets == value)
				{
					return;
				}
				_hideInEmptyWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("backgroundFrames")] 
		public CArray<inkWidgetReference> BackgroundFrames
		{
			get
			{
				if (_backgroundFrames == null)
				{
					_backgroundFrames = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "backgroundFrames", cr2w, this);
				}
				return _backgroundFrames;
			}
			set
			{
				if (_backgroundFrames == value)
				{
					return;
				}
				_backgroundFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("requirementsWrapper")] 
		public inkWidgetReference RequirementsWrapper
		{
			get
			{
				if (_requirementsWrapper == null)
				{
					_requirementsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "requirementsWrapper", cr2w, this);
				}
				return _requirementsWrapper;
			}
			set
			{
				if (_requirementsWrapper == value)
				{
					return;
				}
				_requirementsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("iconicTint")] 
		public inkWidgetReference IconicTint
		{
			get
			{
				if (_iconicTint == null)
				{
					_iconicTint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconicTint", cr2w, this);
				}
				return _iconicTint;
			}
			set
			{
				if (_iconicTint == value)
				{
					return;
				}
				_iconicTint = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get
			{
				if (_rarityWrapper == null)
				{
					_rarityWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityWrapper", cr2w, this);
				}
				return _rarityWrapper;
			}
			set
			{
				if (_rarityWrapper == value)
				{
					return;
				}
				_rarityWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("rarityCommonWrapper")] 
		public inkWidgetReference RarityCommonWrapper
		{
			get
			{
				if (_rarityCommonWrapper == null)
				{
					_rarityCommonWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityCommonWrapper", cr2w, this);
				}
				return _rarityCommonWrapper;
			}
			set
			{
				if (_rarityCommonWrapper == value)
				{
					return;
				}
				_rarityCommonWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("weaponTypeImage")] 
		public inkImageWidgetReference WeaponTypeImage
		{
			get
			{
				if (_weaponTypeImage == null)
				{
					_weaponTypeImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "weaponTypeImage", cr2w, this);
				}
				return _weaponTypeImage;
			}
			set
			{
				if (_weaponTypeImage == value)
				{
					return;
				}
				_weaponTypeImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("questItemMaker")] 
		public inkWidgetReference QuestItemMaker
		{
			get
			{
				if (_questItemMaker == null)
				{
					_questItemMaker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questItemMaker", cr2w, this);
				}
				return _questItemMaker;
			}
			set
			{
				if (_questItemMaker == value)
				{
					return;
				}
				_questItemMaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("equippedMarker")] 
		public inkWidgetReference EquippedMarker
		{
			get
			{
				if (_equippedMarker == null)
				{
					_equippedMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equippedMarker", cr2w, this);
				}
				return _equippedMarker;
			}
			set
			{
				if (_equippedMarker == value)
				{
					return;
				}
				_equippedMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("labelsContainer")] 
		public inkCompoundWidgetReference LabelsContainer
		{
			get
			{
				if (_labelsContainer == null)
				{
					_labelsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "labelsContainer", cr2w, this);
				}
				return _labelsContainer;
			}
			set
			{
				if (_labelsContainer == value)
				{
					return;
				}
				_labelsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("backgroundBlueprint")] 
		public inkWidgetReference BackgroundBlueprint
		{
			get
			{
				if (_backgroundBlueprint == null)
				{
					_backgroundBlueprint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backgroundBlueprint", cr2w, this);
				}
				return _backgroundBlueprint;
			}
			set
			{
				if (_backgroundBlueprint == value)
				{
					return;
				}
				_backgroundBlueprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("iconBlueprint")] 
		public inkWidgetReference IconBlueprint
		{
			get
			{
				if (_iconBlueprint == null)
				{
					_iconBlueprint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconBlueprint", cr2w, this);
				}
				return _iconBlueprint;
			}
			set
			{
				if (_iconBlueprint == value)
				{
					return;
				}
				_iconBlueprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("fluffBlueprint")] 
		public inkImageWidgetReference FluffBlueprint
		{
			get
			{
				if (_fluffBlueprint == null)
				{
					_fluffBlueprint = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "fluffBlueprint", cr2w, this);
				}
				return _fluffBlueprint;
			}
			set
			{
				if (_fluffBlueprint == value)
				{
					return;
				}
				_fluffBlueprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("lootitemflufficon")] 
		public inkWidgetReference Lootitemflufficon
		{
			get
			{
				if (_lootitemflufficon == null)
				{
					_lootitemflufficon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lootitemflufficon", cr2w, this);
				}
				return _lootitemflufficon;
			}
			set
			{
				if (_lootitemflufficon == value)
				{
					return;
				}
				_lootitemflufficon = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("lootitemtypeicon")] 
		public inkImageWidgetReference Lootitemtypeicon
		{
			get
			{
				if (_lootitemtypeicon == null)
				{
					_lootitemtypeicon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "lootitemtypeicon", cr2w, this);
				}
				return _lootitemtypeicon;
			}
			set
			{
				if (_lootitemtypeicon == value)
				{
					return;
				}
				_lootitemtypeicon = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("slotItemsCountWrapper")] 
		public inkWidgetReference SlotItemsCountWrapper
		{
			get
			{
				if (_slotItemsCountWrapper == null)
				{
					_slotItemsCountWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotItemsCountWrapper", cr2w, this);
				}
				return _slotItemsCountWrapper;
			}
			set
			{
				if (_slotItemsCountWrapper == value)
				{
					return;
				}
				_slotItemsCountWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("slotItemsCount")] 
		public inkTextWidgetReference SlotItemsCount
		{
			get
			{
				if (_slotItemsCount == null)
				{
					_slotItemsCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "slotItemsCount", cr2w, this);
				}
				return _slotItemsCount;
			}
			set
			{
				if (_slotItemsCount == value)
				{
					return;
				}
				_slotItemsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("iconErrorIndicator")] 
		public inkWidgetReference IconErrorIndicator
		{
			get
			{
				if (_iconErrorIndicator == null)
				{
					_iconErrorIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconErrorIndicator", cr2w, this);
				}
				return _iconErrorIndicator;
			}
			set
			{
				if (_iconErrorIndicator == value)
				{
					return;
				}
				_iconErrorIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get
			{
				if (_newItemsWrapper == null)
				{
					_newItemsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "newItemsWrapper", cr2w, this);
				}
				return _newItemsWrapper;
			}
			set
			{
				if (_newItemsWrapper == value)
				{
					return;
				}
				_newItemsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get
			{
				if (_newItemsCounter == null)
				{
					_newItemsCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "newItemsCounter", cr2w, this);
				}
				return _newItemsCounter;
			}
			set
			{
				if (_newItemsCounter == value)
				{
					return;
				}
				_newItemsCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get
			{
				if (_lockIcon == null)
				{
					_lockIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lockIcon", cr2w, this);
				}
				return _lockIcon;
			}
			set
			{
				if (_lockIcon == value)
				{
					return;
				}
				_lockIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get
			{
				if (_inventoryDataManager == null)
				{
					_inventoryDataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "inventoryDataManager", cr2w, this);
				}
				return _inventoryDataManager;
			}
			set
			{
				if (_inventoryDataManager == value)
				{
					return;
				}
				_inventoryDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
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

		[Ordinal(42)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("hasRecipe")] 
		public CBool HasRecipe
		{
			get
			{
				if (_hasRecipe == null)
				{
					_hasRecipe = (CBool) CR2WTypeManager.Create("Bool", "hasRecipe", cr2w, this);
				}
				return _hasRecipe;
			}
			set
			{
				if (_hasRecipe == value)
				{
					return;
				}
				_hasRecipe = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get
			{
				if (_recipeData == null)
				{
					_recipeData = (CHandle<RecipeData>) CR2WTypeManager.Create("handle:RecipeData", "recipeData", cr2w, this);
				}
				return _recipeData;
			}
			set
			{
				if (_recipeData == value)
				{
					return;
				}
				_recipeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("emptySlotImage")] 
		public CName EmptySlotImage
		{
			get
			{
				if (_emptySlotImage == null)
				{
					_emptySlotImage = (CName) CR2WTypeManager.Create("CName", "emptySlotImage", cr2w, this);
				}
				return _emptySlotImage;
			}
			set
			{
				if (_emptySlotImage == value)
				{
					return;
				}
				_emptySlotImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CString) CR2WTypeManager.Create("String", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("attachmentsDisplay")] 
		public CArray<wCHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay
		{
			get
			{
				if (_attachmentsDisplay == null)
				{
					_attachmentsDisplay = (CArray<wCHandle<InventoryItemModSlotDisplay>>) CR2WTypeManager.Create("array:whandle:InventoryItemModSlotDisplay", "attachmentsDisplay", cr2w, this);
				}
				return _attachmentsDisplay;
			}
			set
			{
				if (_attachmentsDisplay == value)
				{
					return;
				}
				_attachmentsDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get
			{
				if (_itemDisplayContext == null)
				{
					_itemDisplayContext = (CEnum<gameItemDisplayContext>) CR2WTypeManager.Create("gameItemDisplayContext", "itemDisplayContext", cr2w, this);
				}
				return _itemDisplayContext;
			}
			set
			{
				if (_itemDisplayContext == value)
				{
					return;
				}
				_itemDisplayContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("labelsContainerController")] 
		public wCHandle<ItemLabelContainerController> LabelsContainerController
		{
			get
			{
				if (_labelsContainerController == null)
				{
					_labelsContainerController = (wCHandle<ItemLabelContainerController>) CR2WTypeManager.Create("whandle:ItemLabelContainerController", "labelsContainerController", cr2w, this);
				}
				return _labelsContainerController;
			}
			set
			{
				if (_labelsContainerController == value)
				{
					return;
				}
				_labelsContainerController = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("defaultFallbackImage")] 
		public CName DefaultFallbackImage
		{
			get
			{
				if (_defaultFallbackImage == null)
				{
					_defaultFallbackImage = (CName) CR2WTypeManager.Create("CName", "defaultFallbackImage", cr2w, this);
				}
				return _defaultFallbackImage;
			}
			set
			{
				if (_defaultFallbackImage == value)
				{
					return;
				}
				_defaultFallbackImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("defaultEmptyImage")] 
		public CName DefaultEmptyImage
		{
			get
			{
				if (_defaultEmptyImage == null)
				{
					_defaultEmptyImage = (CName) CR2WTypeManager.Create("CName", "defaultEmptyImage", cr2w, this);
				}
				return _defaultEmptyImage;
			}
			set
			{
				if (_defaultEmptyImage == value)
				{
					return;
				}
				_defaultEmptyImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("defaultEmptyImageAtlas")] 
		public CString DefaultEmptyImageAtlas
		{
			get
			{
				if (_defaultEmptyImageAtlas == null)
				{
					_defaultEmptyImageAtlas = (CString) CR2WTypeManager.Create("String", "defaultEmptyImageAtlas", cr2w, this);
				}
				return _defaultEmptyImageAtlas;
			}
			set
			{
				if (_defaultEmptyImageAtlas == value)
				{
					return;
				}
				_defaultEmptyImageAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("emptyImage")] 
		public CName EmptyImage
		{
			get
			{
				if (_emptyImage == null)
				{
					_emptyImage = (CName) CR2WTypeManager.Create("CName", "emptyImage", cr2w, this);
				}
				return _emptyImage;
			}
			set
			{
				if (_emptyImage == value)
				{
					return;
				}
				_emptyImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("emptyImageAtlas")] 
		public CString EmptyImageAtlas
		{
			get
			{
				if (_emptyImageAtlas == null)
				{
					_emptyImageAtlas = (CString) CR2WTypeManager.Create("String", "emptyImageAtlas", cr2w, this);
				}
				return _emptyImageAtlas;
			}
			set
			{
				if (_emptyImageAtlas == value)
				{
					return;
				}
				_emptyImageAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("enoughMoney")] 
		public CBool EnoughMoney
		{
			get
			{
				if (_enoughMoney == null)
				{
					_enoughMoney = (CBool) CR2WTypeManager.Create("Bool", "enoughMoney", cr2w, this);
				}
				return _enoughMoney;
			}
			set
			{
				if (_enoughMoney == value)
				{
					return;
				}
				_enoughMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("owned")] 
		public CBool Owned
		{
			get
			{
				if (_owned == null)
				{
					_owned = (CBool) CR2WTypeManager.Create("Bool", "owned", cr2w, this);
				}
				return _owned;
			}
			set
			{
				if (_owned == value)
				{
					return;
				}
				_owned = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("requirementsMet")] 
		public CBool RequirementsMet
		{
			get
			{
				if (_requirementsMet == null)
				{
					_requirementsMet = (CBool) CR2WTypeManager.Create("Bool", "requirementsMet", cr2w, this);
				}
				return _requirementsMet;
			}
			set
			{
				if (_requirementsMet == value)
				{
					return;
				}
				_requirementsMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get
			{
				if (_tooltipData == null)
				{
					_tooltipData = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "tooltipData", cr2w, this);
				}
				return _tooltipData;
			}
			set
			{
				if (_tooltipData == value)
				{
					return;
				}
				_tooltipData = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "isNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("newItemsIDs")] 
		public CArray<gameItemID> NewItemsIDs
		{
			get
			{
				if (_newItemsIDs == null)
				{
					_newItemsIDs = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "newItemsIDs", cr2w, this);
				}
				return _newItemsIDs;
			}
			set
			{
				if (_newItemsIDs == value)
				{
					return;
				}
				_newItemsIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("newItemsFetched")] 
		public CBool NewItemsFetched
		{
			get
			{
				if (_newItemsFetched == null)
				{
					_newItemsFetched = (CBool) CR2WTypeManager.Create("Bool", "newItemsFetched", cr2w, this);
				}
				return _newItemsFetched;
			}
			set
			{
				if (_newItemsFetched == value)
				{
					return;
				}
				_newItemsFetched = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get
			{
				if (_isBuybackStack == null)
				{
					_isBuybackStack = (CBool) CR2WTypeManager.Create("Bool", "isBuybackStack", cr2w, this);
				}
				return _isBuybackStack;
			}
			set
			{
				if (_isBuybackStack == value)
				{
					return;
				}
				_isBuybackStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("parentItemData")] 
		public wCHandle<gameItemData> ParentItemData
		{
			get
			{
				if (_parentItemData == null)
				{
					_parentItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "parentItemData", cr2w, this);
				}
				return _parentItemData;
			}
			set
			{
				if (_parentItemData == value)
				{
					return;
				}
				_parentItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("DEBUG_isIconError")] 
		public CBool DEBUG_isIconError
		{
			get
			{
				if (_dEBUG_isIconError == null)
				{
					_dEBUG_isIconError = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_isIconError", cr2w, this);
				}
				return _dEBUG_isIconError;
			}
			set
			{
				if (_dEBUG_isIconError == value)
				{
					return;
				}
				_dEBUG_isIconError = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get
			{
				if (_dEBUG_iconErrorInfo == null)
				{
					_dEBUG_iconErrorInfo = (CHandle<DEBUG_IconErrorInfo>) CR2WTypeManager.Create("handle:DEBUG_IconErrorInfo", "DEBUG_iconErrorInfo", cr2w, this);
				}
				return _dEBUG_iconErrorInfo;
			}
			set
			{
				if (_dEBUG_iconErrorInfo == value)
				{
					return;
				}
				_dEBUG_iconErrorInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("DEBUG_resolvedIconName")] 
		public CString DEBUG_resolvedIconName
		{
			get
			{
				if (_dEBUG_resolvedIconName == null)
				{
					_dEBUG_resolvedIconName = (CString) CR2WTypeManager.Create("String", "DEBUG_resolvedIconName", cr2w, this);
				}
				return _dEBUG_resolvedIconName;
			}
			set
			{
				if (_dEBUG_resolvedIconName == value)
				{
					return;
				}
				_dEBUG_resolvedIconName = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("DEBUG_recordItemName")] 
		public CString DEBUG_recordItemName
		{
			get
			{
				if (_dEBUG_recordItemName == null)
				{
					_dEBUG_recordItemName = (CString) CR2WTypeManager.Create("String", "DEBUG_recordItemName", cr2w, this);
				}
				return _dEBUG_recordItemName;
			}
			set
			{
				if (_dEBUG_recordItemName == value)
				{
					return;
				}
				_dEBUG_recordItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("DEBUG_innerItemName")] 
		public CString DEBUG_innerItemName
		{
			get
			{
				if (_dEBUG_innerItemName == null)
				{
					_dEBUG_innerItemName = (CString) CR2WTypeManager.Create("String", "DEBUG_innerItemName", cr2w, this);
				}
				return _dEBUG_innerItemName;
			}
			set
			{
				if (_dEBUG_innerItemName == value)
				{
					return;
				}
				_dEBUG_innerItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("DEBUG_isIconManuallySet")] 
		public CBool DEBUG_isIconManuallySet
		{
			get
			{
				if (_dEBUG_isIconManuallySet == null)
				{
					_dEBUG_isIconManuallySet = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_isIconManuallySet", cr2w, this);
				}
				return _dEBUG_isIconManuallySet;
			}
			set
			{
				if (_dEBUG_isIconManuallySet == value)
				{
					return;
				}
				_dEBUG_isIconManuallySet = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("DEBUG_iconsNameResolverIsDebug")] 
		public CBool DEBUG_iconsNameResolverIsDebug
		{
			get
			{
				if (_dEBUG_iconsNameResolverIsDebug == null)
				{
					_dEBUG_iconsNameResolverIsDebug = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_iconsNameResolverIsDebug", cr2w, this);
				}
				return _dEBUG_iconsNameResolverIsDebug;
			}
			set
			{
				if (_dEBUG_iconsNameResolverIsDebug == value)
				{
					return;
				}
				_dEBUG_iconsNameResolverIsDebug = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("parrentWrappedDataObject")] 
		public wCHandle<WrappedInventoryItemData> ParrentWrappedDataObject
		{
			get
			{
				if (_parrentWrappedDataObject == null)
				{
					_parrentWrappedDataObject = (wCHandle<WrappedInventoryItemData>) CR2WTypeManager.Create("whandle:WrappedInventoryItemData", "parrentWrappedDataObject", cr2w, this);
				}
				return _parrentWrappedDataObject;
			}
			set
			{
				if (_parrentWrappedDataObject == value)
				{
					return;
				}
				_parrentWrappedDataObject = value;
				PropertySet(this);
			}
		}

		public InventoryItemDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
