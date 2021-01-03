using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLogGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("buttonHints")] public inkWidgetReference ButtonHints { get; set; }
		[Ordinal(1)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(2)]  [RED("buttonTrack")] public inkWidgetReference ButtonTrack { get; set; }
		[Ordinal(3)]  [RED("curreentQuest")] public wCHandle<gameJournalQuest> CurreentQuest { get; set; }
		[Ordinal(4)]  [RED("detailsPanel")] public inkWidgetReference DetailsPanel { get; set; }
		[Ordinal(5)]  [RED("entryAnimProxy")] public CHandle<inkanimProxy> EntryAnimProxy { get; set; }
		[Ordinal(6)]  [RED("externallyOpenedQuestHash")] public CInt32 ExternallyOpenedQuestHash { get; set; }
		[Ordinal(7)]  [RED("game")] public ScriptGameInstance Game { get; set; }
		[Ordinal(8)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(9)]  [RED("listData")] public CArray<CHandle<VirutalNestedListData>> ListData { get; set; }
		[Ordinal(10)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(11)]  [RED("playerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(12)]  [RED("quests")] public CArray<wCHandle<gameJournalEntry>> Quests { get; set; }
		[Ordinal(13)]  [RED("recommendedLevel")] public CInt32 RecommendedLevel { get; set; }
		[Ordinal(14)]  [RED("resolvedQuests")] public CArray<wCHandle<gameJournalEntry>> ResolvedQuests { get; set; }
		[Ordinal(15)]  [RED("trackedQuest")] public wCHandle<gameJournalQuest> TrackedQuest { get; set; }
		[Ordinal(16)]  [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }

		public questLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
