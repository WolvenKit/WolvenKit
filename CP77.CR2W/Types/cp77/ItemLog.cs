using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemLog : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("listRef")] public inkCompoundWidgetReference ListRef { get; set; }
		[Ordinal(4)] [RED("initialPopupDelay")] public CFloat InitialPopupDelay { get; set; }
		[Ordinal(5)] [RED("popupList")] public CArray<CHandle<DisassemblePopupLogicController>> PopupList { get; set; }
		[Ordinal(6)] [RED("listOfAddedInventoryItems")] public CArray<InventoryItemData> ListOfAddedInventoryItems { get; set; }
		[Ordinal(7)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(8)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(9)] [RED("data")] public CHandle<ItemLogUserData> Data { get; set; }
		[Ordinal(10)] [RED("onScreenCount")] public CInt32 OnScreenCount { get; set; }
		[Ordinal(11)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(12)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(13)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }

		public ItemLog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
