using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiInventoryGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("ConsumablesAreas")] public CArray<CEnum<gamedataEquipmentArea>> ConsumablesAreas { get; set; }
		[Ordinal(1)]  [RED("ConsumablesList")] public CArray<wCHandle<InventoryItemDisplayController>> ConsumablesList { get; set; }
		[Ordinal(2)]  [RED("CyberwareAreas")] public CArray<CEnum<gamedataEquipmentArea>> CyberwareAreas { get; set; }
		[Ordinal(3)]  [RED("CyberwareList")] public CArray<wCHandle<InventoryItemDisplayController>> CyberwareList { get; set; }
		[Ordinal(4)]  [RED("CyberwareSlotRootRefs")] public inkCompoundWidgetReference CyberwareSlotRootRefs { get; set; }
		[Ordinal(5)]  [RED("DisassembleBBID")] public CUInt32 DisassembleBBID { get; set; }
		[Ordinal(6)]  [RED("DisassembleBlackboard")] public CHandle<gameIBlackboard> DisassembleBlackboard { get; set; }
		[Ordinal(7)]  [RED("DisassembleCallback")] public CHandle<UI_CraftingDef> DisassembleCallback { get; set; }
		[Ordinal(8)]  [RED("EquipAreas")] public CArray<CEnum<gamedataEquipmentArea>> EquipAreas { get; set; }
		[Ordinal(9)]  [RED("EquipmentBBID")] public CUInt32 EquipmentBBID { get; set; }
		[Ordinal(10)]  [RED("EquipmentList")] public CArray<wCHandle<InventoryItemDisplayController>> EquipmentList { get; set; }
		[Ordinal(11)]  [RED("InventoryBBID")] public CUInt32 InventoryBBID { get; set; }
		[Ordinal(12)]  [RED("InventoryList")] public CArray<wCHandle<InventoryItemDisplay>> InventoryList { get; set; }
		[Ordinal(13)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(14)]  [RED("ItemModBBID")] public CUInt32 ItemModBBID { get; set; }
		[Ordinal(15)]  [RED("PocketAreas")] public CArray<CEnum<gamedataEquipmentArea>> PocketAreas { get; set; }
		[Ordinal(16)]  [RED("PocketList")] public CArray<wCHandle<InventoryItemDisplayController>> PocketList { get; set; }
		[Ordinal(17)]  [RED("SubEquipmentBBID")] public CUInt32 SubEquipmentBBID { get; set; }
		[Ordinal(18)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(19)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(20)]  [RED("UIBBEquipment")] public CHandle<UI_EquipmentDef> UIBBEquipment { get; set; }
		[Ordinal(21)]  [RED("UIBBEquipmentBlackboard")] public CHandle<gameIBlackboard> UIBBEquipmentBlackboard { get; set; }
		[Ordinal(22)]  [RED("UIBBItemMod")] public CHandle<UI_ItemModSystemDef> UIBBItemMod { get; set; }
		[Ordinal(23)]  [RED("UIBBItemModBlackbord")] public CHandle<gameIBlackboard> UIBBItemModBlackbord { get; set; }
		[Ordinal(24)]  [RED("WeaponAreas")] public CArray<CEnum<gamedataItemType>> WeaponAreas { get; set; }
		[Ordinal(25)]  [RED("WeaponsList")] public CArray<wCHandle<InventoryItemDisplayController>> WeaponsList { get; set; }
		[Ordinal(26)]  [RED("animDef")] public CHandle<inkanimDefinition> AnimDef { get; set; }
		[Ordinal(27)]  [RED("animationList")] public CArray<wCHandle<InventoryItemDisplayController>> AnimationList { get; set; }
		[Ordinal(28)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(29)]  [RED("btnBackpack")] public inkWidgetReference BtnBackpack { get; set; }
		[Ordinal(30)]  [RED("btnCyberware")] public inkWidgetReference BtnCyberware { get; set; }
		[Ordinal(31)]  [RED("btnStats")] public inkWidgetReference BtnStats { get; set; }
		[Ordinal(32)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(33)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(34)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(35)]  [RED("cyberdeckLinkContainer")] public inkWidgetReference CyberdeckLinkContainer { get; set; }
		[Ordinal(36)]  [RED("cyberdeckLinkItem")] public inkWidgetReference CyberdeckLinkItem { get; set; }
		[Ordinal(37)]  [RED("defaultWrapper")] public inkWidgetReference DefaultWrapper { get; set; }
		[Ordinal(38)]  [RED("equipmentAreaCategories")] public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories { get; set; }
		[Ordinal(39)]  [RED("equipmentAreaCategoryEventQueue")] public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue { get; set; }
		[Ordinal(40)]  [RED("equipmentSystem")] public wCHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(41)]  [RED("inventoryStatsListener")] public CHandle<InventoryStatsListener> InventoryStatsListener { get; set; }
		[Ordinal(42)]  [RED("isE3Demo")] public CBool IsE3Demo { get; set; }
		[Ordinal(43)]  [RED("itemModeControllerRef")] public inkWidgetReference ItemModeControllerRef { get; set; }
		[Ordinal(44)]  [RED("itemModeLogicController")] public wCHandle<InventoryItemModeLogicController> ItemModeLogicController { get; set; }
		[Ordinal(45)]  [RED("itemNotificationRoot")] public inkWidgetReference ItemNotificationRoot { get; set; }
		[Ordinal(46)]  [RED("itemViewMode")] public CEnum<ItemViewModes> ItemViewMode { get; set; }
		[Ordinal(47)]  [RED("itemWrapper")] public inkWidgetReference ItemWrapper { get; set; }
		[Ordinal(48)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(49)]  [RED("mode")] public CEnum<InventoryModes> Mode { get; set; }
		[Ordinal(50)]  [RED("notificationRoot")] public inkWidgetReference NotificationRoot { get; set; }
		[Ordinal(51)]  [RED("openItemMode")] public CBool OpenItemMode { get; set; }
		[Ordinal(52)]  [RED("paperDollWidget")] public inkWidgetReference PaperDollWidget { get; set; }
		[Ordinal(53)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(54)]  [RED("playerStatsWidget")] public inkWidgetReference PlayerStatsWidget { get; set; }
		[Ordinal(55)]  [RED("psmBlackboard")] public wCHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(56)]  [RED("quantityPickerPopupToken")] public CHandle<inkGameNotificationToken> QuantityPickerPopupToken { get; set; }
		[Ordinal(57)]  [RED("selectedEquipmentSlot")] public wCHandle<InventoryItemDisplayController> SelectedEquipmentSlot { get; set; }
		[Ordinal(58)]  [RED("sortingButton")] public inkWidgetReference SortingButton { get; set; }
		[Ordinal(59)]  [RED("sortingDropdown")] public inkWidgetReference SortingDropdown { get; set; }
		[Ordinal(60)]  [RED("telemetrySystem")] public wCHandle<gameTelemetryTelemetrySystem> TelemetrySystem { get; set; }
		[Ordinal(61)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }

		public gameuiInventoryGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
