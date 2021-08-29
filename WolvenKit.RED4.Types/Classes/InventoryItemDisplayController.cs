using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDisplayController : BaseButtonView
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
		private inkWidgetReference _comparisionArrow;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CWeakHandle<UIScriptableSystem> _uiScriptableSystem;
		private gameItemID _itemID;
		private InventoryItemData _itemData;
		private CHandle<RecipeData> _recipeData;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataItemType> _itemType;
		private CName _emptySlotImage;
		private CString _slotName;
		private CInt32 _slotIndex;
		private CArray<CWeakHandle<InventoryItemModSlotDisplay>> _attachmentsDisplay;
		private TweakDBID _slotID;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private CWeakHandle<ItemLabelContainerController> _labelsContainerController;
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
		private CWeakHandle<gameItemData> _parentItemData;
		private CBool _isLocked;
		private CBool _isUpgradable;
		private CBool _hasAvailableItems;
		private CBool _dEBUG_isIconError;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;
		private CString _dEBUG_resolvedIconName;
		private CString _dEBUG_recordItemName;
		private CString _dEBUG_innerItemName;
		private CBool _dEBUG_isIconManuallySet;
		private CBool _dEBUG_iconsNameResolverIsDebug;
		private CWeakHandle<WrappedInventoryItemData> _parrentWrappedDataObject;

		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetProperty(ref _widgetWrapper);
			set => SetProperty(ref _widgetWrapper, value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(5)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetProperty(ref _itemRarity);
			set => SetProperty(ref _itemRarity, value);
		}

		[Ordinal(6)] 
		[RED("commonModsRoot")] 
		public inkCompoundWidgetReference CommonModsRoot
		{
			get => GetProperty(ref _commonModsRoot);
			set => SetProperty(ref _commonModsRoot, value);
		}

		[Ordinal(7)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetProperty(ref _itemImage);
			set => SetProperty(ref _itemImage, value);
		}

		[Ordinal(8)] 
		[RED("itemFallbackImage")] 
		public inkImageWidgetReference ItemFallbackImage
		{
			get => GetProperty(ref _itemFallbackImage);
			set => SetProperty(ref _itemFallbackImage, value);
		}

		[Ordinal(9)] 
		[RED("itemEmptyImage")] 
		public inkImageWidgetReference ItemEmptyImage
		{
			get => GetProperty(ref _itemEmptyImage);
			set => SetProperty(ref _itemEmptyImage, value);
		}

		[Ordinal(10)] 
		[RED("itemSelectedArrow")] 
		public inkWidgetReference ItemSelectedArrow
		{
			get => GetProperty(ref _itemSelectedArrow);
			set => SetProperty(ref _itemSelectedArrow, value);
		}

		[Ordinal(11)] 
		[RED("quantintyAmmoIcon")] 
		public inkWidgetReference QuantintyAmmoIcon
		{
			get => GetProperty(ref _quantintyAmmoIcon);
			set => SetProperty(ref _quantintyAmmoIcon, value);
		}

		[Ordinal(12)] 
		[RED("quantityWrapper")] 
		public inkCompoundWidgetReference QuantityWrapper
		{
			get => GetProperty(ref _quantityWrapper);
			set => SetProperty(ref _quantityWrapper, value);
		}

		[Ordinal(13)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetProperty(ref _quantityText);
			set => SetProperty(ref _quantityText, value);
		}

		[Ordinal(14)] 
		[RED("weaponType")] 
		public inkTextWidgetReference WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		[Ordinal(15)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetProperty(ref _highlightFrames);
			set => SetProperty(ref _highlightFrames, value);
		}

		[Ordinal(16)] 
		[RED("equippedWidgets")] 
		public CArray<inkWidgetReference> EquippedWidgets
		{
			get => GetProperty(ref _equippedWidgets);
			set => SetProperty(ref _equippedWidgets, value);
		}

		[Ordinal(17)] 
		[RED("hideWhenEquippedWidgets")] 
		public CArray<inkWidgetReference> HideWhenEquippedWidgets
		{
			get => GetProperty(ref _hideWhenEquippedWidgets);
			set => SetProperty(ref _hideWhenEquippedWidgets, value);
		}

		[Ordinal(18)] 
		[RED("showInEmptyWidgets")] 
		public CArray<inkWidgetReference> ShowInEmptyWidgets
		{
			get => GetProperty(ref _showInEmptyWidgets);
			set => SetProperty(ref _showInEmptyWidgets, value);
		}

		[Ordinal(19)] 
		[RED("hideInEmptyWidgets")] 
		public CArray<inkWidgetReference> HideInEmptyWidgets
		{
			get => GetProperty(ref _hideInEmptyWidgets);
			set => SetProperty(ref _hideInEmptyWidgets, value);
		}

		[Ordinal(20)] 
		[RED("backgroundFrames")] 
		public CArray<inkWidgetReference> BackgroundFrames
		{
			get => GetProperty(ref _backgroundFrames);
			set => SetProperty(ref _backgroundFrames, value);
		}

		[Ordinal(21)] 
		[RED("requirementsWrapper")] 
		public inkWidgetReference RequirementsWrapper
		{
			get => GetProperty(ref _requirementsWrapper);
			set => SetProperty(ref _requirementsWrapper, value);
		}

		[Ordinal(22)] 
		[RED("iconicTint")] 
		public inkWidgetReference IconicTint
		{
			get => GetProperty(ref _iconicTint);
			set => SetProperty(ref _iconicTint, value);
		}

		[Ordinal(23)] 
		[RED("rarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetProperty(ref _rarityWrapper);
			set => SetProperty(ref _rarityWrapper, value);
		}

		[Ordinal(24)] 
		[RED("rarityCommonWrapper")] 
		public inkWidgetReference RarityCommonWrapper
		{
			get => GetProperty(ref _rarityCommonWrapper);
			set => SetProperty(ref _rarityCommonWrapper, value);
		}

		[Ordinal(25)] 
		[RED("weaponTypeImage")] 
		public inkImageWidgetReference WeaponTypeImage
		{
			get => GetProperty(ref _weaponTypeImage);
			set => SetProperty(ref _weaponTypeImage, value);
		}

		[Ordinal(26)] 
		[RED("questItemMaker")] 
		public inkWidgetReference QuestItemMaker
		{
			get => GetProperty(ref _questItemMaker);
			set => SetProperty(ref _questItemMaker, value);
		}

		[Ordinal(27)] 
		[RED("equippedMarker")] 
		public inkWidgetReference EquippedMarker
		{
			get => GetProperty(ref _equippedMarker);
			set => SetProperty(ref _equippedMarker, value);
		}

		[Ordinal(28)] 
		[RED("labelsContainer")] 
		public inkCompoundWidgetReference LabelsContainer
		{
			get => GetProperty(ref _labelsContainer);
			set => SetProperty(ref _labelsContainer, value);
		}

		[Ordinal(29)] 
		[RED("backgroundBlueprint")] 
		public inkWidgetReference BackgroundBlueprint
		{
			get => GetProperty(ref _backgroundBlueprint);
			set => SetProperty(ref _backgroundBlueprint, value);
		}

		[Ordinal(30)] 
		[RED("iconBlueprint")] 
		public inkWidgetReference IconBlueprint
		{
			get => GetProperty(ref _iconBlueprint);
			set => SetProperty(ref _iconBlueprint, value);
		}

		[Ordinal(31)] 
		[RED("fluffBlueprint")] 
		public inkImageWidgetReference FluffBlueprint
		{
			get => GetProperty(ref _fluffBlueprint);
			set => SetProperty(ref _fluffBlueprint, value);
		}

		[Ordinal(32)] 
		[RED("lootitemflufficon")] 
		public inkWidgetReference Lootitemflufficon
		{
			get => GetProperty(ref _lootitemflufficon);
			set => SetProperty(ref _lootitemflufficon, value);
		}

		[Ordinal(33)] 
		[RED("lootitemtypeicon")] 
		public inkImageWidgetReference Lootitemtypeicon
		{
			get => GetProperty(ref _lootitemtypeicon);
			set => SetProperty(ref _lootitemtypeicon, value);
		}

		[Ordinal(34)] 
		[RED("slotItemsCountWrapper")] 
		public inkWidgetReference SlotItemsCountWrapper
		{
			get => GetProperty(ref _slotItemsCountWrapper);
			set => SetProperty(ref _slotItemsCountWrapper, value);
		}

		[Ordinal(35)] 
		[RED("slotItemsCount")] 
		public inkTextWidgetReference SlotItemsCount
		{
			get => GetProperty(ref _slotItemsCount);
			set => SetProperty(ref _slotItemsCount, value);
		}

		[Ordinal(36)] 
		[RED("iconErrorIndicator")] 
		public inkWidgetReference IconErrorIndicator
		{
			get => GetProperty(ref _iconErrorIndicator);
			set => SetProperty(ref _iconErrorIndicator, value);
		}

		[Ordinal(37)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetProperty(ref _newItemsWrapper);
			set => SetProperty(ref _newItemsWrapper, value);
		}

		[Ordinal(38)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetProperty(ref _newItemsCounter);
			set => SetProperty(ref _newItemsCounter, value);
		}

		[Ordinal(39)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetProperty(ref _lockIcon);
			set => SetProperty(ref _lockIcon, value);
		}

		[Ordinal(40)] 
		[RED("comparisionArrow")] 
		public inkWidgetReference ComparisionArrow
		{
			get => GetProperty(ref _comparisionArrow);
			set => SetProperty(ref _comparisionArrow, value);
		}

		[Ordinal(41)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(42)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(43)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(44)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(45)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetProperty(ref _recipeData);
			set => SetProperty(ref _recipeData, value);
		}

		[Ordinal(46)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(47)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(48)] 
		[RED("emptySlotImage")] 
		public CName EmptySlotImage
		{
			get => GetProperty(ref _emptySlotImage);
			set => SetProperty(ref _emptySlotImage, value);
		}

		[Ordinal(49)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(50)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(51)] 
		[RED("attachmentsDisplay")] 
		public CArray<CWeakHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay
		{
			get => GetProperty(ref _attachmentsDisplay);
			set => SetProperty(ref _attachmentsDisplay, value);
		}

		[Ordinal(52)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(53)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(54)] 
		[RED("labelsContainerController")] 
		public CWeakHandle<ItemLabelContainerController> LabelsContainerController
		{
			get => GetProperty(ref _labelsContainerController);
			set => SetProperty(ref _labelsContainerController, value);
		}

		[Ordinal(55)] 
		[RED("defaultFallbackImage")] 
		public CName DefaultFallbackImage
		{
			get => GetProperty(ref _defaultFallbackImage);
			set => SetProperty(ref _defaultFallbackImage, value);
		}

		[Ordinal(56)] 
		[RED("defaultEmptyImage")] 
		public CName DefaultEmptyImage
		{
			get => GetProperty(ref _defaultEmptyImage);
			set => SetProperty(ref _defaultEmptyImage, value);
		}

		[Ordinal(57)] 
		[RED("defaultEmptyImageAtlas")] 
		public CString DefaultEmptyImageAtlas
		{
			get => GetProperty(ref _defaultEmptyImageAtlas);
			set => SetProperty(ref _defaultEmptyImageAtlas, value);
		}

		[Ordinal(58)] 
		[RED("emptyImage")] 
		public CName EmptyImage
		{
			get => GetProperty(ref _emptyImage);
			set => SetProperty(ref _emptyImage, value);
		}

		[Ordinal(59)] 
		[RED("emptyImageAtlas")] 
		public CString EmptyImageAtlas
		{
			get => GetProperty(ref _emptyImageAtlas);
			set => SetProperty(ref _emptyImageAtlas, value);
		}

		[Ordinal(60)] 
		[RED("enoughMoney")] 
		public CBool EnoughMoney
		{
			get => GetProperty(ref _enoughMoney);
			set => SetProperty(ref _enoughMoney, value);
		}

		[Ordinal(61)] 
		[RED("owned")] 
		public CBool Owned
		{
			get => GetProperty(ref _owned);
			set => SetProperty(ref _owned, value);
		}

		[Ordinal(62)] 
		[RED("requirementsMet")] 
		public CBool RequirementsMet
		{
			get => GetProperty(ref _requirementsMet);
			set => SetProperty(ref _requirementsMet, value);
		}

		[Ordinal(63)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(64)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(65)] 
		[RED("newItemsIDs")] 
		public CArray<gameItemID> NewItemsIDs
		{
			get => GetProperty(ref _newItemsIDs);
			set => SetProperty(ref _newItemsIDs, value);
		}

		[Ordinal(66)] 
		[RED("newItemsFetched")] 
		public CBool NewItemsFetched
		{
			get => GetProperty(ref _newItemsFetched);
			set => SetProperty(ref _newItemsFetched, value);
		}

		[Ordinal(67)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(68)] 
		[RED("parentItemData")] 
		public CWeakHandle<gameItemData> ParentItemData
		{
			get => GetProperty(ref _parentItemData);
			set => SetProperty(ref _parentItemData, value);
		}

		[Ordinal(69)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(70)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetProperty(ref _isUpgradable);
			set => SetProperty(ref _isUpgradable, value);
		}

		[Ordinal(71)] 
		[RED("hasAvailableItems")] 
		public CBool HasAvailableItems
		{
			get => GetProperty(ref _hasAvailableItems);
			set => SetProperty(ref _hasAvailableItems, value);
		}

		[Ordinal(72)] 
		[RED("DEBUG_isIconError")] 
		public CBool DEBUG_isIconError
		{
			get => GetProperty(ref _dEBUG_isIconError);
			set => SetProperty(ref _dEBUG_isIconError, value);
		}

		[Ordinal(73)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}

		[Ordinal(74)] 
		[RED("DEBUG_resolvedIconName")] 
		public CString DEBUG_resolvedIconName
		{
			get => GetProperty(ref _dEBUG_resolvedIconName);
			set => SetProperty(ref _dEBUG_resolvedIconName, value);
		}

		[Ordinal(75)] 
		[RED("DEBUG_recordItemName")] 
		public CString DEBUG_recordItemName
		{
			get => GetProperty(ref _dEBUG_recordItemName);
			set => SetProperty(ref _dEBUG_recordItemName, value);
		}

		[Ordinal(76)] 
		[RED("DEBUG_innerItemName")] 
		public CString DEBUG_innerItemName
		{
			get => GetProperty(ref _dEBUG_innerItemName);
			set => SetProperty(ref _dEBUG_innerItemName, value);
		}

		[Ordinal(77)] 
		[RED("DEBUG_isIconManuallySet")] 
		public CBool DEBUG_isIconManuallySet
		{
			get => GetProperty(ref _dEBUG_isIconManuallySet);
			set => SetProperty(ref _dEBUG_isIconManuallySet, value);
		}

		[Ordinal(78)] 
		[RED("DEBUG_iconsNameResolverIsDebug")] 
		public CBool DEBUG_iconsNameResolverIsDebug
		{
			get => GetProperty(ref _dEBUG_iconsNameResolverIsDebug);
			set => SetProperty(ref _dEBUG_iconsNameResolverIsDebug, value);
		}

		[Ordinal(79)] 
		[RED("parrentWrappedDataObject")] 
		public CWeakHandle<WrappedInventoryItemData> ParrentWrappedDataObject
		{
			get => GetProperty(ref _parrentWrappedDataObject);
			set => SetProperty(ref _parrentWrappedDataObject, value);
		}
	}
}
