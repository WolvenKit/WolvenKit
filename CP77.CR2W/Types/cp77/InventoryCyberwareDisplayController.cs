using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(0)]  [RED("DEBUG_isIconError")] public CBool DEBUG_isIconError { get; set; }
		[Ordinal(1)]  [RED("DEBUG_iconErrorInfo")] public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo { get; set; }
		[Ordinal(2)]  [RED("DEBUG_resolvedIconName")] public CString DEBUG_resolvedIconName { get; set; }
		[Ordinal(3)]  [RED("DEBUG_recordItemName")] public CString DEBUG_recordItemName { get; set; }
		[Ordinal(4)]  [RED("DEBUG_innerItemName")] public CString DEBUG_innerItemName { get; set; }
		[Ordinal(5)]  [RED("DEBUG_isIconManuallySet")] public CBool DEBUG_isIconManuallySet { get; set; }
		[Ordinal(6)]  [RED("DEBUG_iconsNameResolverIsDebug")] public CBool DEBUG_iconsNameResolverIsDebug { get; set; }
		[Ordinal(7)]  [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }
		[Ordinal(8)]  [RED("widgetWrapper")] public inkWidgetReference WidgetWrapper { get; set; }
		[Ordinal(9)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(10)]  [RED("itemPrice")] public inkTextWidgetReference ItemPrice { get; set; }
		[Ordinal(11)]  [RED("itemRarity")] public inkWidgetReference ItemRarity { get; set; }
		[Ordinal(12)]  [RED("commonModsRoot")] public inkCompoundWidgetReference CommonModsRoot { get; set; }
		[Ordinal(13)]  [RED("itemImage")] public inkImageWidgetReference ItemImage { get; set; }
		[Ordinal(14)]  [RED("itemFallbackImage")] public inkImageWidgetReference ItemFallbackImage { get; set; }
		[Ordinal(15)]  [RED("itemEmptyImage")] public inkImageWidgetReference ItemEmptyImage { get; set; }
		[Ordinal(16)]  [RED("itemSelectedArrow")] public inkWidgetReference ItemSelectedArrow { get; set; }
		[Ordinal(17)]  [RED("quantintyAmmoIcon")] public inkWidgetReference QuantintyAmmoIcon { get; set; }
		[Ordinal(18)]  [RED("quantityWrapper")] public inkCompoundWidgetReference QuantityWrapper { get; set; }
		[Ordinal(19)]  [RED("quantityText")] public inkTextWidgetReference QuantityText { get; set; }
		[Ordinal(20)]  [RED("weaponType")] public inkTextWidgetReference WeaponType { get; set; }
		[Ordinal(21)]  [RED("highlightFrames")] public CArray<inkWidgetReference> HighlightFrames { get; set; }
		[Ordinal(22)]  [RED("equippedWidgets")] public CArray<inkWidgetReference> EquippedWidgets { get; set; }
		[Ordinal(23)]  [RED("hideWhenEquippedWidgets")] public CArray<inkWidgetReference> HideWhenEquippedWidgets { get; set; }
		[Ordinal(24)]  [RED("showInEmptyWidgets")] public CArray<inkWidgetReference> ShowInEmptyWidgets { get; set; }
		[Ordinal(25)]  [RED("hideInEmptyWidgets")] public CArray<inkWidgetReference> HideInEmptyWidgets { get; set; }
		[Ordinal(26)]  [RED("backgroundFrames")] public CArray<inkWidgetReference> BackgroundFrames { get; set; }
		[Ordinal(27)]  [RED("requirementsWrapper")] public inkWidgetReference RequirementsWrapper { get; set; }
		[Ordinal(28)]  [RED("iconicTint")] public inkWidgetReference IconicTint { get; set; }
		[Ordinal(29)]  [RED("rarityWrapper")] public inkWidgetReference RarityWrapper { get; set; }
		[Ordinal(30)]  [RED("rarityCommonWrapper")] public inkWidgetReference RarityCommonWrapper { get; set; }
		[Ordinal(31)]  [RED("weaponTypeImage")] public inkImageWidgetReference WeaponTypeImage { get; set; }
		[Ordinal(32)]  [RED("questItemMaker")] public inkWidgetReference QuestItemMaker { get; set; }
		[Ordinal(33)]  [RED("equippedMarker")] public inkWidgetReference EquippedMarker { get; set; }
		[Ordinal(34)]  [RED("labelsContainer")] public inkCompoundWidgetReference LabelsContainer { get; set; }
		[Ordinal(35)]  [RED("backgroundBlueprint")] public inkWidgetReference BackgroundBlueprint { get; set; }
		[Ordinal(36)]  [RED("iconBlueprint")] public inkWidgetReference IconBlueprint { get; set; }
		[Ordinal(37)]  [RED("fluffBlueprint")] public inkImageWidgetReference FluffBlueprint { get; set; }
		[Ordinal(38)]  [RED("lootitemflufficon")] public inkWidgetReference Lootitemflufficon { get; set; }
		[Ordinal(39)]  [RED("lootitemtypeicon")] public inkImageWidgetReference Lootitemtypeicon { get; set; }
		[Ordinal(40)]  [RED("slotItemsCountWrapper")] public inkWidgetReference SlotItemsCountWrapper { get; set; }
		[Ordinal(41)]  [RED("slotItemsCount")] public inkTextWidgetReference SlotItemsCount { get; set; }
		[Ordinal(42)]  [RED("iconErrorIndicator")] public inkWidgetReference IconErrorIndicator { get; set; }
		[Ordinal(43)]  [RED("newItemsWrapper")] public inkWidgetReference NewItemsWrapper { get; set; }
		[Ordinal(44)]  [RED("newItemsCounter")] public inkTextWidgetReference NewItemsCounter { get; set; }
		[Ordinal(45)]  [RED("lockIcon")] public inkWidgetReference LockIcon { get; set; }
		[Ordinal(46)]  [RED("inventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(47)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(48)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(49)]  [RED("hasRecipe")] public CBool HasRecipe { get; set; }
		[Ordinal(50)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(51)]  [RED("recipeData")] public CHandle<RecipeData> RecipeData { get; set; }
		[Ordinal(52)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(53)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(54)]  [RED("emptySlotImage")] public CName EmptySlotImage { get; set; }
		[Ordinal(55)]  [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(56)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(57)]  [RED("attachmentsDisplay")] public CArray<wCHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay { get; set; }
		[Ordinal(58)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(59)]  [RED("itemDisplayContext")] public CEnum<gameItemDisplayContext> ItemDisplayContext { get; set; }
		[Ordinal(60)]  [RED("labelsContainerController")] public wCHandle<ItemLabelContainerController> LabelsContainerController { get; set; }
		[Ordinal(61)]  [RED("defaultFallbackImage")] public CName DefaultFallbackImage { get; set; }
		[Ordinal(62)]  [RED("defaultEmptyImage")] public CName DefaultEmptyImage { get; set; }
		[Ordinal(63)]  [RED("defaultEmptyImageAtlas")] public CString DefaultEmptyImageAtlas { get; set; }
		[Ordinal(64)]  [RED("emptyImage")] public CName EmptyImage { get; set; }
		[Ordinal(65)]  [RED("emptyImageAtlas")] public CString EmptyImageAtlas { get; set; }
		[Ordinal(66)]  [RED("enoughMoney")] public CBool EnoughMoney { get; set; }
		[Ordinal(67)]  [RED("owned")] public CBool Owned { get; set; }
		[Ordinal(68)]  [RED("requirementsMet")] public CBool RequirementsMet { get; set; }
		[Ordinal(69)]  [RED("tooltipData")] public CHandle<InventoryTooltipData> TooltipData { get; set; }
		[Ordinal(70)]  [RED("isNew")] public CBool IsNew { get; set; }
		[Ordinal(71)]  [RED("newItemsIDs")] public CArray<gameItemID> NewItemsIDs { get; set; }
		[Ordinal(72)]  [RED("newItemsFetched")] public CBool NewItemsFetched { get; set; }
		[Ordinal(73)]  [RED("isBuybackStack")] public CBool IsBuybackStack { get; set; }
		[Ordinal(74)]  [RED("parentItemData")] public wCHandle<gameItemData> ParentItemData { get; set; }
		[Ordinal(75)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(76)]  [RED("parrentWrappedDataObject")] public wCHandle<WrappedInventoryItemData> ParrentWrappedDataObject { get; set; }
		[Ordinal(77)]  [RED("ownedFrame")] public inkWidgetReference OwnedFrame { get; set; }
		[Ordinal(78)]  [RED("selectedFrame")] public inkWidgetReference SelectedFrame { get; set; }
		[Ordinal(79)]  [RED("amountPanel")] public inkWidgetReference AmountPanel { get; set; }
		[Ordinal(80)]  [RED("amount")] public inkTextWidgetReference Amount { get; set; }

		public InventoryCyberwareDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
