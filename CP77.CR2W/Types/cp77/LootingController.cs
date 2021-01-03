using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LootingController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("actionsListV")] public inkCompoundWidgetReference ActionsListV { get; set; }
		[Ordinal(1)]  [RED("activeWeapon")] public InventoryItemData ActiveWeapon { get; set; }
		[Ordinal(2)]  [RED("bufferedOwnerId")] public entEntityID BufferedOwnerId { get; set; }
		[Ordinal(3)]  [RED("cachedTooltipData")] public CHandle<ATooltipData> CachedTooltipData { get; set; }
		[Ordinal(4)]  [RED("currendData")] public gameinteractionsvisLootData CurrendData { get; set; }
		[Ordinal(5)]  [RED("currentItemOwnerId")] public entEntityID CurrentItemOwnerId { get; set; }
		[Ordinal(6)]  [RED("currentItemRequestVersion")] public CInt32 CurrentItemRequestVersion { get; set; }
		[Ordinal(7)]  [RED("currentTooltipItemId")] public gameItemID CurrentTooltipItemId { get; set; }
		[Ordinal(8)]  [RED("currentTooltipLootingData")] public CHandle<TooltipLootingCachedData> CurrentTooltipLootingData { get; set; }
		[Ordinal(9)]  [RED("currentWidgetRequestVersion")] public CInt32 CurrentWidgetRequestVersion { get; set; }
		[Ordinal(10)]  [RED("dataManager")] public wCHandle<InventoryDataManagerV2> DataManager { get; set; }
		[Ordinal(11)]  [RED("downArrow")] public inkWidgetReference DownArrow { get; set; }
		[Ordinal(12)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(13)]  [RED("introAnimProxy")] public CHandle<inkanimProxy> IntroAnimProxy { get; set; }
		[Ordinal(14)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(15)]  [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(16)]  [RED("itemsListContainer")] public inkCompoundWidgetReference ItemsListContainer { get; set; }
		[Ordinal(17)]  [RED("itemsToCompare")] public CInt32 ItemsToCompare { get; set; }
		[Ordinal(18)]  [RED("lastItemOwnerId")] public entEntityID LastItemOwnerId { get; set; }
		[Ordinal(19)]  [RED("lastListOpenedState")] public CBool LastListOpenedState { get; set; }
		[Ordinal(20)]  [RED("lastTooltipItemId")] public gameItemID LastTooltipItemId { get; set; }
		[Ordinal(21)]  [RED("listWrapper")] public inkWidgetReference ListWrapper { get; set; }
		[Ordinal(22)]  [RED("lockedStatusContainer")] public inkWidgetReference LockedStatusContainer { get; set; }
		[Ordinal(23)]  [RED("lootList")] public CArray<wCHandle<inkWidget>> LootList { get; set; }
		[Ordinal(24)]  [RED("maxItemsNum")] public CInt32 MaxItemsNum { get; set; }
		[Ordinal(25)]  [RED("requestedItemsPoolItems")] public CInt32 RequestedItemsPoolItems { get; set; }
		[Ordinal(26)]  [RED("requestedWidgetsPoolItems")] public CInt32 RequestedWidgetsPoolItems { get; set; }
		[Ordinal(27)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(28)]  [RED("selectedItemIndex")] public CInt32 SelectedItemIndex { get; set; }
		[Ordinal(29)]  [RED("startIndex")] public CInt32 StartIndex { get; set; }
		[Ordinal(30)]  [RED("titleContainer")] public inkCompoundWidgetReference TitleContainer { get; set; }
		[Ordinal(31)]  [RED("tooltipProvider")] public wCHandle<TooltipProvider> TooltipProvider { get; set; }
		[Ordinal(32)]  [RED("upArrow")] public inkWidgetReference UpArrow { get; set; }
		[Ordinal(33)]  [RED("widgetsPoolList")] public CArray<wCHandle<inkWidget>> WidgetsPoolList { get; set; }

		public LootingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
