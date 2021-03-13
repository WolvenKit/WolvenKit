using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(4)] [RED("entryViewRef")] public inkCompoundWidgetReference EntryViewRef { get; set; }
		[Ordinal(5)] [RED("characterEntryViewRef")] public inkCompoundWidgetReference CharacterEntryViewRef { get; set; }
		[Ordinal(6)] [RED("noEntrySelectedWidget")] public inkWidgetReference NoEntrySelectedWidget { get; set; }
		[Ordinal(7)] [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }
		[Ordinal(8)] [RED("emptyPlaceholderRef")] public inkWidgetReference EmptyPlaceholderRef { get; set; }
		[Ordinal(9)] [RED("leftBlockControllerRef")] public inkWidgetReference LeftBlockControllerRef { get; set; }
		[Ordinal(10)] [RED("filtersContainer")] public inkCompoundWidgetReference FiltersContainer { get; set; }
		[Ordinal(11)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(12)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(13)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(14)] [RED("listController")] public wCHandle<CodexListVirtualNestedListController> ListController { get; set; }
		[Ordinal(15)] [RED("entryViewController")] public wCHandle<CodexEntryViewController> EntryViewController { get; set; }
		[Ordinal(16)] [RED("characterEntryViewController")] public wCHandle<CodexEntryViewController> CharacterEntryViewController { get; set; }
		[Ordinal(17)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(18)] [RED("activeData")] public CHandle<CodexListSyncData> ActiveData { get; set; }
		[Ordinal(19)] [RED("selectedData")] public CHandle<CodexEntryData> SelectedData { get; set; }
		[Ordinal(20)] [RED("userDataEntry")] public CInt32 UserDataEntry { get; set; }
		[Ordinal(21)] [RED("doubleInputPreventionFlag")] public CBool DoubleInputPreventionFlag { get; set; }
		[Ordinal(22)] [RED("filtersControllers")] public CArray<CHandle<CodexFilterButtonController>> FiltersControllers { get; set; }

		public CodexGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
