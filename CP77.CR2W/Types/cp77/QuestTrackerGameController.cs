using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("QuestTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(8)]  [RED("ObjectiveContainer")] public inkCompoundWidgetReference ObjectiveContainer { get; set; }
		[Ordinal(9)]  [RED("TrackedMappinTitle")] public inkTextWidgetReference TrackedMappinTitle { get; set; }
		[Ordinal(10)]  [RED("TrackedMappinContainer")] public inkWidgetReference TrackedMappinContainer { get; set; }
		[Ordinal(11)]  [RED("TrackedMappinObjectiveContainer")] public inkCompoundWidgetReference TrackedMappinObjectiveContainer { get; set; }
		[Ordinal(12)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(13)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(14)]  [RED("bufferedEntry")] public wCHandle<gameJournalQuestObjective> BufferedEntry { get; set; }
		[Ordinal(15)]  [RED("bufferedPhase")] public wCHandle<gameJournalQuestPhase> BufferedPhase { get; set; }
		[Ordinal(16)]  [RED("bufferedQuest")] public wCHandle<gameJournalQuest> BufferedQuest { get; set; }
		[Ordinal(17)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(18)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(19)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(20)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }
		[Ordinal(21)]  [RED("trackedMappinId")] public CUInt32 TrackedMappinId { get; set; }

		public QuestTrackerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
