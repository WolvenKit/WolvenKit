using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("ObjectiveContainer")] public inkCompoundWidgetReference ObjectiveContainer { get; set; }
		[Ordinal(1)]  [RED("QuestTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(2)]  [RED("TrackedMappinContainer")] public inkWidgetReference TrackedMappinContainer { get; set; }
		[Ordinal(3)]  [RED("TrackedMappinObjectiveContainer")] public inkCompoundWidgetReference TrackedMappinObjectiveContainer { get; set; }
		[Ordinal(4)]  [RED("TrackedMappinTitle")] public inkTextWidgetReference TrackedMappinTitle { get; set; }
		[Ordinal(5)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(6)]  [RED("bufferedEntry")] public wCHandle<gameJournalQuestObjective> BufferedEntry { get; set; }
		[Ordinal(7)]  [RED("bufferedPhase")] public wCHandle<gameJournalQuestPhase> BufferedPhase { get; set; }
		[Ordinal(8)]  [RED("bufferedQuest")] public wCHandle<gameJournalQuest> BufferedQuest { get; set; }
		[Ordinal(9)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(10)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(11)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(12)]  [RED("trackedMappinId")] public CUInt32 TrackedMappinId { get; set; }
		[Ordinal(13)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(14)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }

		public QuestTrackerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
