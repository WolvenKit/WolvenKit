using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemDisplayController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("commonModsRoot")] 
		public inkCompoundWidgetReference CommonModsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemFallbackImage")] 
		public inkImageWidgetReference ItemFallbackImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemEmptyImage")] 
		public inkImageWidgetReference ItemEmptyImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemSelectedArrow")] 
		public inkWidgetReference ItemSelectedArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("quantintyAmmoIcon")] 
		public inkWidgetReference QuantintyAmmoIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("quantityWrapper")] 
		public inkCompoundWidgetReference QuantityWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("weaponType")] 
		public inkTextWidgetReference WeaponType
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(16)] 
		[RED("equippedWidgets")] 
		public CArray<inkWidgetReference> EquippedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(17)] 
		[RED("hideWhenEquippedWidgets")] 
		public CArray<inkWidgetReference> HideWhenEquippedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("showInEmptyWidgets")] 
		public CArray<inkWidgetReference> ShowInEmptyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("hideInEmptyWidgets")] 
		public CArray<inkWidgetReference> HideInEmptyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("backgroundFrames")] 
		public CArray<inkWidgetReference> BackgroundFrames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("requirementsWrapper")] 
		public inkWidgetReference RequirementsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("iconicTint")] 
		public inkWidgetReference IconicTint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("transmogContainer")] 
		public inkCompoundWidgetReference TransmogContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("rarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("rarityCommonWrapper")] 
		public inkWidgetReference RarityCommonWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("weaponTypeImage")] 
		public inkImageWidgetReference WeaponTypeImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("questItemMaker")] 
		public inkWidgetReference QuestItemMaker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("equippedMarker")] 
		public inkWidgetReference EquippedMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("labelsContainer")] 
		public inkCompoundWidgetReference LabelsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("backgroundBlueprint")] 
		public inkWidgetReference BackgroundBlueprint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("iconBlueprint")] 
		public inkWidgetReference IconBlueprint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("fluffBlueprint")] 
		public inkImageWidgetReference FluffBlueprint
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("lootitemflufficon")] 
		public inkWidgetReference Lootitemflufficon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("lootitemtypeicon")] 
		public inkImageWidgetReference Lootitemtypeicon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("slotItemsCountWrapper")] 
		public inkWidgetReference SlotItemsCountWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("slotItemsCount")] 
		public inkTextWidgetReference SlotItemsCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("iconErrorIndicator")] 
		public inkWidgetReference IconErrorIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("transmogedIcon")] 
		public inkWidgetReference TransmogedIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("iconWardrobeDisabled")] 
		public inkWidgetReference IconWardrobeDisabled
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("comparisionArrow")] 
		public inkWidgetReference ComparisionArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("iconTransmog")] 
		public inkWidgetReference IconTransmog
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("wardrobeInfoContainer")] 
		public inkWidgetReference WardrobeInfoContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("wardrobeInfoText")] 
		public inkTextWidgetReference WardrobeInfoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(48)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(49)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(50)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(51)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(52)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetPropertyValue<CHandle<RecipeData>>();
			set => SetPropertyValue<CHandle<RecipeData>>(value);
		}

		[Ordinal(53)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(54)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(55)] 
		[RED("emptySlotImage")] 
		public CName EmptySlotImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(56)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(57)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(58)] 
		[RED("attachmentsDisplay")] 
		public CArray<CWeakHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemModSlotDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemModSlotDisplay>>>(value);
		}

		[Ordinal(59)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(60)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(61)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(62)] 
		[RED("labelsContainerController")] 
		public CWeakHandle<ItemLabelContainerController> LabelsContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemLabelContainerController>>();
			set => SetPropertyValue<CWeakHandle<ItemLabelContainerController>>(value);
		}

		[Ordinal(63)] 
		[RED("defaultFallbackImage")] 
		public CName DefaultFallbackImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(64)] 
		[RED("defaultEmptyImage")] 
		public CName DefaultEmptyImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(65)] 
		[RED("defaultEmptyImageAtlas")] 
		public CString DefaultEmptyImageAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(66)] 
		[RED("emptyImage")] 
		public CName EmptyImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(67)] 
		[RED("emptyImageAtlas")] 
		public CString EmptyImageAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(68)] 
		[RED("enoughMoney")] 
		public CBool EnoughMoney
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("owned")] 
		public CBool Owned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("requirementsMet")] 
		public CBool RequirementsMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(72)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("newItemsIDs")] 
		public CArray<gameItemID> NewItemsIDs
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(74)] 
		[RED("newItemsFetched")] 
		public CBool NewItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("isDLCNewItem")] 
		public CBool IsDLCNewItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("parentItemData")] 
		public CWeakHandle<gameItemData> ParentItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(78)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("isTransmoged")] 
		public CBool IsTransmoged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("isWardrobeDisabled")] 
		public CBool IsWardrobeDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("overrideQuantity")] 
		public CInt32 OverrideQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(83)] 
		[RED("hasAvailableItems")] 
		public CBool HasAvailableItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(84)] 
		[RED("isSlotTransmogged")] 
		public CBool IsSlotTransmogged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("wardrobeOutfitIndex")] 
		public CInt32 WardrobeOutfitIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(86)] 
		[RED("delayProxy")] 
		public CHandle<inkanimProxy> DelayProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(87)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(88)] 
		[RED("hoverTarget")] 
		public CWeakHandle<inkWidget> HoverTarget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(89)] 
		[RED("DEBUG_isIconError")] 
		public CBool DEBUG_isIconError
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(90)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		[Ordinal(91)] 
		[RED("DEBUG_resolvedIconName")] 
		public CString DEBUG_resolvedIconName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(92)] 
		[RED("DEBUG_recordItemName")] 
		public CString DEBUG_recordItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(93)] 
		[RED("DEBUG_innerItemName")] 
		public CString DEBUG_innerItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(94)] 
		[RED("DEBUG_isIconManuallySet")] 
		public CBool DEBUG_isIconManuallySet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("DEBUG_iconsNameResolverIsDebug")] 
		public CBool DEBUG_iconsNameResolverIsDebug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("uiInventoryItem")] 
		public CWeakHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(97)] 
		[RED("displayContextData")] 
		public CWeakHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CWeakHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CWeakHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(98)] 
		[RED("parrentWrappedDataObject")] 
		public CWeakHandle<WrappedInventoryItemData> ParrentWrappedDataObject
		{
			get => GetPropertyValue<CWeakHandle<WrappedInventoryItemData>>();
			set => SetPropertyValue<CWeakHandle<WrappedInventoryItemData>>(value);
		}

		public InventoryItemDisplayController()
		{
			WidgetWrapper = new();
			ItemName = new();
			ItemPrice = new();
			ItemRarity = new();
			CommonModsRoot = new();
			ItemImage = new();
			ItemFallbackImage = new();
			ItemEmptyImage = new();
			ItemSelectedArrow = new();
			QuantintyAmmoIcon = new();
			QuantityWrapper = new();
			QuantityText = new();
			WeaponType = new();
			HighlightFrames = new();
			EquippedWidgets = new();
			HideWhenEquippedWidgets = new();
			ShowInEmptyWidgets = new();
			HideInEmptyWidgets = new();
			BackgroundFrames = new();
			RequirementsWrapper = new();
			IconicTint = new();
			TransmogContainer = new();
			RarityWrapper = new();
			RarityCommonWrapper = new();
			WeaponTypeImage = new();
			QuestItemMaker = new();
			EquippedMarker = new();
			LabelsContainer = new();
			BackgroundBlueprint = new();
			IconBlueprint = new();
			FluffBlueprint = new();
			Lootitemflufficon = new();
			Lootitemtypeicon = new();
			SlotItemsCountWrapper = new();
			SlotItemsCount = new();
			IconErrorIndicator = new();
			NewItemsWrapper = new();
			NewItemsCounter = new();
			LockIcon = new();
			TransmogedIcon = new();
			IconWardrobeDisabled = new();
			ComparisionArrow = new();
			IconTransmog = new();
			WardrobeInfoContainer = new();
			WardrobeInfoText = new();
			ItemID = new();
			ItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			EquipmentArea = Enums.gamedataEquipmentArea.Invalid;
			ItemType = Enums.gamedataItemType.Invalid;
			AttachmentsDisplay = new();
			TransmogItem = new();
			DefaultFallbackImage = "undefined";
			DefaultEmptyImage = "icon_add";
			DefaultEmptyImageAtlas = "base\\gameplay\\gui\\fullscreen\\inventory\\inventory4_atlas.inkatlas";
			NewItemsIDs = new();
			HasAvailableItems = true;
			WardrobeOutfitIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
