using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipGameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("inventoryCanvas")] public wCHandle<inkWidget> InventoryCanvas { get; set; }
		[Ordinal(2)]  [RED("inventoryList")] public wCHandle<inkVerticalPanelWidget> InventoryList { get; set; }
		[Ordinal(3)]  [RED("inventory")] public CArray<wCHandle<gameItemData>> Inventory { get; set; }
		[Ordinal(4)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(5)]  [RED("equipmentSystem")] public CHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(6)]  [RED("subCharacterSystem")] public CHandle<SubCharacterSystem> SubCharacterSystem { get; set; }
		[Ordinal(7)]  [RED("transactionSystem")] public CHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(8)]  [RED("craftingSystem")] public CHandle<CraftingSystem> CraftingSystem { get; set; }
		[Ordinal(9)]  [RED("buttonScrollUp")] public wCHandle<inkCanvasWidget> ButtonScrollUp { get; set; }
		[Ordinal(10)]  [RED("buttonScrollDn")] public wCHandle<inkCanvasWidget> ButtonScrollDn { get; set; }
		[Ordinal(11)]  [RED("buttonPlayer")] public wCHandle<inkCanvasWidget> ButtonPlayer { get; set; }
		[Ordinal(12)]  [RED("buttonFlathead")] public wCHandle<inkCanvasWidget> ButtonFlathead { get; set; }
		[Ordinal(13)]  [RED("buttonToolbox")] public wCHandle<inkCanvasWidget> ButtonToolbox { get; set; }
		[Ordinal(14)]  [RED("panelPlayer")] public wCHandle<inkCanvasWidget> PanelPlayer { get; set; }
		[Ordinal(15)]  [RED("panelFlathead")] public wCHandle<inkCanvasWidget> PanelFlathead { get; set; }
		[Ordinal(16)]  [RED("panelToolbox")] public wCHandle<inkCanvasWidget> PanelToolbox { get; set; }
		[Ordinal(17)]  [RED("uiBB_Equipment")] public CHandle<UI_EquipmentDef> UiBB_Equipment { get; set; }
		[Ordinal(18)]  [RED("uiBB_EquipmentBlackboard")] public CHandle<gameIBlackboard> UiBB_EquipmentBlackboard { get; set; }
		[Ordinal(19)]  [RED("backgroundVideo")] public wCHandle<inkVideoWidget> BackgroundVideo { get; set; }
		[Ordinal(20)]  [RED("paperdollVideo")] public wCHandle<inkVideoWidget> PaperdollVideo { get; set; }
		[Ordinal(21)]  [RED("areaTags")] public CArray<CName> AreaTags { get; set; }
		[Ordinal(22)]  [RED("inventoryManager")] public CHandle<InventoryDataManager> InventoryManager { get; set; }
		[Ordinal(23)]  [RED("vendorBlackboard")] public CHandle<gameIBlackboard> VendorBlackboard { get; set; }
		[Ordinal(24)]  [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }
		[Ordinal(25)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(26)]  [RED("recipeItemList")] public CArray<TweakDBID> RecipeItemList { get; set; }
		[Ordinal(27)]  [RED("playerCraftBook")] public CHandle<CraftBook> PlayerCraftBook { get; set; }
		[Ordinal(28)]  [RED("tooltipsLibrary")] public redResourceReferenceScriptToken TooltipsLibrary { get; set; }
		[Ordinal(29)]  [RED("itemTooltipName")] public CName ItemTooltipName { get; set; }
		[Ordinal(30)]  [RED("tooltipStylePath")] public redResourceReferenceScriptToken TooltipStylePath { get; set; }
		[Ordinal(31)]  [RED("tooltipLeft")] public wCHandle<InventorySlotTooltip> TooltipLeft { get; set; }
		[Ordinal(32)]  [RED("tooltipRight")] public wCHandle<InventorySlotTooltip> TooltipRight { get; set; }
		[Ordinal(33)]  [RED("tooltipContainer")] public wCHandle<inkCompoundWidget> TooltipContainer { get; set; }
		[Ordinal(34)]  [RED("paperDollList")] public CArray<CName> PaperDollList { get; set; }
		[Ordinal(35)]  [RED("scrollOffset")] public CInt32 ScrollOffset { get; set; }
		[Ordinal(36)]  [RED("faceTags")] public CArray<CName> FaceTags { get; set; }
		[Ordinal(37)]  [RED("headTags")] public CArray<CName> HeadTags { get; set; }
		[Ordinal(38)]  [RED("chestTags")] public CArray<CName> ChestTags { get; set; }
		[Ordinal(39)]  [RED("legTags")] public CArray<CName> LegTags { get; set; }
		[Ordinal(40)]  [RED("weaponTags")] public CArray<CName> WeaponTags { get; set; }
		[Ordinal(41)]  [RED("consumableTags")] public CArray<CName> ConsumableTags { get; set; }
		[Ordinal(42)]  [RED("modulesTags")] public CArray<CName> ModulesTags { get; set; }
		[Ordinal(43)]  [RED("framesTags")] public CArray<CName> FramesTags { get; set; }
		[Ordinal(44)]  [RED("operationsMode")] public CEnum<operationsMode> OperationsMode { get; set; }

		public ArmorEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
