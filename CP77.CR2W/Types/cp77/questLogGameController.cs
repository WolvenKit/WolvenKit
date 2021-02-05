using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLogGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }
		[Ordinal(2)]  [RED("detailsPanel")] public inkWidgetReference DetailsPanel { get; set; }
		[Ordinal(3)]  [RED("buttonHints")] public inkWidgetReference ButtonHints { get; set; }
		[Ordinal(4)]  [RED("buttonTrack")] public inkWidgetReference ButtonTrack { get; set; }
		[Ordinal(5)]  [RED("game")] public ScriptGameInstance Game { get; set; }
		[Ordinal(6)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(7)]  [RED("quests")] public CArray<wCHandle<gameJournalEntry>> Quests { get; set; }
		[Ordinal(8)]  [RED("resolvedQuests")] public CArray<wCHandle<gameJournalEntry>> ResolvedQuests { get; set; }
		[Ordinal(9)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(10)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(11)]  [RED("trackedQuest")] public wCHandle<gameJournalQuest> TrackedQuest { get; set; }
		[Ordinal(12)]  [RED("curreentQuest")] public wCHandle<gameJournalQuest> CurreentQuest { get; set; }
		[Ordinal(13)]  [RED("externallyOpenedQuestHash")] public CInt32 ExternallyOpenedQuestHash { get; set; }
		[Ordinal(14)]  [RED("playerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(15)]  [RED("recommendedLevel")] public CInt32 RecommendedLevel { get; set; }
		[Ordinal(16)]  [RED("entryAnimProxy")] public CHandle<inkanimProxy> EntryAnimProxy { get; set; }
		[Ordinal(17)]  [RED("listData")] public CArray<CHandle<VirutalNestedListData>> ListData { get; set; }

		public questLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
