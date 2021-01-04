using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("activeData")] public CHandle<CodexListSyncData> ActiveData { get; set; }
		[Ordinal(1)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(2)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(3)]  [RED("characterEntryViewController")] public wCHandle<CodexEntryViewController> CharacterEntryViewController { get; set; }
		[Ordinal(4)]  [RED("characterEntryViewRef")] public inkCompoundWidgetReference CharacterEntryViewRef { get; set; }
		[Ordinal(5)]  [RED("doubleInputPreventionFlag")] public CBool DoubleInputPreventionFlag { get; set; }
		[Ordinal(6)]  [RED("emptyPlaceholderRef")] public inkWidgetReference EmptyPlaceholderRef { get; set; }
		[Ordinal(7)]  [RED("entryViewController")] public wCHandle<CodexEntryViewController> EntryViewController { get; set; }
		[Ordinal(8)]  [RED("entryViewRef")] public inkCompoundWidgetReference EntryViewRef { get; set; }
		[Ordinal(9)]  [RED("filtersContainer")] public inkCompoundWidgetReference FiltersContainer { get; set; }
		[Ordinal(10)]  [RED("filtersControllers")] public CArray<CHandle<CodexFilterButtonController>> FiltersControllers { get; set; }
		[Ordinal(11)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(12)]  [RED("leftBlockControllerRef")] public inkWidgetReference LeftBlockControllerRef { get; set; }
		[Ordinal(13)]  [RED("listController")] public wCHandle<CodexListVirtualNestedListController> ListController { get; set; }
		[Ordinal(14)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(15)]  [RED("noEntrySelectedWidget")] public inkWidgetReference NoEntrySelectedWidget { get; set; }
		[Ordinal(16)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(17)]  [RED("selectedData")] public CHandle<CodexEntryData> SelectedData { get; set; }
		[Ordinal(18)]  [RED("userDataEntry")] public CInt32 UserDataEntry { get; set; }
		[Ordinal(19)]  [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }

		public CodexGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
