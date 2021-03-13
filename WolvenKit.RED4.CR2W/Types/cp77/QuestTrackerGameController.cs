using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("QuestTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(10)] [RED("ObjectiveContainer")] public inkCompoundWidgetReference ObjectiveContainer { get; set; }
		[Ordinal(11)] [RED("TrackedMappinTitle")] public inkTextWidgetReference TrackedMappinTitle { get; set; }
		[Ordinal(12)] [RED("TrackedMappinContainer")] public inkWidgetReference TrackedMappinContainer { get; set; }
		[Ordinal(13)] [RED("TrackedMappinObjectiveContainer")] public inkCompoundWidgetReference TrackedMappinObjectiveContainer { get; set; }
		[Ordinal(14)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(15)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(16)] [RED("bufferedEntry")] public wCHandle<gameJournalQuestObjective> BufferedEntry { get; set; }
		[Ordinal(17)] [RED("bufferedPhase")] public wCHandle<gameJournalQuestPhase> BufferedPhase { get; set; }
		[Ordinal(18)] [RED("bufferedQuest")] public wCHandle<gameJournalQuest> BufferedQuest { get; set; }
		[Ordinal(19)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(20)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(21)] [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(22)] [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }
		[Ordinal(23)] [RED("trackedMappinId")] public CUInt32 TrackedMappinId { get; set; }

		public QuestTrackerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
