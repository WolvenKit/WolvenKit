using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModeLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("HACK_lastItemDisplayEvent")] public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent { get; set; }
		[Ordinal(1)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(2)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(3)]  [RED("activeFilter")] public CHandle<BackpackFilterButtonController> ActiveFilter { get; set; }
		[Ordinal(4)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(5)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(6)]  [RED("currentHotkey")] public CEnum<gameEHotkey> CurrentHotkey { get; set; }
		[Ordinal(7)]  [RED("cyberwareGridContainer")] public inkWidgetReference CyberwareGridContainer { get; set; }
		[Ordinal(8)]  [RED("cyberwareGridContainerController")] public CHandle<ItemModeGridContainer> CyberwareGridContainerController { get; set; }
		[Ordinal(9)]  [RED("emptyInventoryText")] public inkTextWidgetReference EmptyInventoryText { get; set; }
		[Ordinal(10)]  [RED("equipmentBlackboard")] public CHandle<gameIBlackboard> EquipmentBlackboard { get; set; }
		[Ordinal(11)]  [RED("equipmentBlackboardCallback")] public CUInt32 EquipmentBlackboardCallback { get; set; }
		[Ordinal(12)]  [RED("equipmentSystem")] public wCHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(13)]  [RED("filterButtonsGrid")] public inkCompoundWidgetReference FilterButtonsGrid { get; set; }
		[Ordinal(14)]  [RED("filterManager")] public CHandle<ItemCategoryFliterManager> FilterManager { get; set; }
		[Ordinal(15)]  [RED("installModData")] public CHandle<InstallModConfirmationData> InstallModData { get; set; }
		[Ordinal(16)]  [RED("inventoryController")] public wCHandle<gameuiInventoryGameController> InventoryController { get; set; }
		[Ordinal(17)]  [RED("isE3Demo")] public CBool IsE3Demo { get; set; }
		[Ordinal(18)]  [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(19)]  [RED("itemCategoryHeader")] public inkTextWidgetReference ItemCategoryHeader { get; set; }
		[Ordinal(20)]  [RED("itemCategoryList")] public inkCompoundWidgetReference ItemCategoryList { get; set; }
		[Ordinal(21)]  [RED("itemChooser")] public CHandle<InventoryGenericItemChooser> ItemChooser { get; set; }
		[Ordinal(22)]  [RED("itemDropQueue")] public CArray<gameItemModParams> ItemDropQueue { get; set; }
		[Ordinal(23)]  [RED("itemGridClassifier")] public CHandle<ItemModeGridClassifier> ItemGridClassifier { get; set; }
		[Ordinal(24)]  [RED("itemGridContainer")] public inkWidgetReference ItemGridContainer { get; set; }
		[Ordinal(25)]  [RED("itemGridContainerController")] public CHandle<ItemModeGridContainer> ItemGridContainerController { get; set; }
		[Ordinal(26)]  [RED("itemGridDataSource")] public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource { get; set; }
		[Ordinal(27)]  [RED("itemGridDataView")] public CHandle<ItemModeGridView> ItemGridDataView { get; set; }
		[Ordinal(28)]  [RED("itemGridScrollControllerWidget")] public inkWidgetReference ItemGridScrollControllerWidget { get; set; }
		[Ordinal(29)]  [RED("itemModeInventoryListener")] public CHandle<gameInventoryScriptListener> ItemModeInventoryListener { get; set; }
		[Ordinal(30)]  [RED("itemModeInventoryListenerCallback")] public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback { get; set; }
		[Ordinal(31)]  [RED("itemModeInventoryListenerRegistered")] public CBool ItemModeInventoryListenerRegistered { get; set; }
		[Ordinal(32)]  [RED("itemModsBlackboard")] public CHandle<gameIBlackboard> ItemModsBlackboard { get; set; }
		[Ordinal(33)]  [RED("itemModsBlackboardCallback")] public CUInt32 ItemModsBlackboardCallback { get; set; }
		[Ordinal(34)]  [RED("itemsPositionProvider")] public CHandle<ItemPositionProvider> ItemsPositionProvider { get; set; }
		[Ordinal(35)]  [RED("lastEquipmentAreas")] public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas { get; set; }
		[Ordinal(36)]  [RED("lastSelectedDisplay")] public CHandle<InventoryItemDisplayController> LastSelectedDisplay { get; set; }
		[Ordinal(37)]  [RED("mainWrapper")] public inkCompoundWidgetReference MainWrapper { get; set; }
		[Ordinal(38)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(39)]  [RED("replaceModNotification")] public CHandle<inkGameNotificationToken> ReplaceModNotification { get; set; }
		[Ordinal(40)]  [RED("savedFilter")] public CEnum<ItemFilterCategory> SavedFilter { get; set; }
		[Ordinal(41)]  [RED("transactionSystem")] public wCHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(42)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }

		public InventoryItemModeLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
