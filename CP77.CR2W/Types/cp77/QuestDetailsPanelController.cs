using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsPanelController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("activeObjectives")] public inkCompoundWidgetReference ActiveObjectives { get; set; }
		[Ordinal(1)]  [RED("codexLinksContainer")] public inkCompoundWidgetReference CodexLinksContainer { get; set; }
		[Ordinal(2)]  [RED("completedObjectives")] public inkCompoundWidgetReference CompletedObjectives { get; set; }
		[Ordinal(3)]  [RED("contentContainer")] public inkWidgetReference ContentContainer { get; set; }
		[Ordinal(4)]  [RED("currentQuestData")] public wCHandle<gameJournalQuest> CurrentQuestData { get; set; }
		[Ordinal(5)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(6)]  [RED("mappinSystem")] public wCHandle<gamemappinsMappinSystem> MappinSystem { get; set; }
		[Ordinal(7)]  [RED("noSelectedQuestContainer")] public inkWidgetReference NoSelectedQuestContainer { get; set; }
		[Ordinal(8)]  [RED("optionalObjectives")] public inkCompoundWidgetReference OptionalObjectives { get; set; }
		[Ordinal(9)]  [RED("phoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }
		[Ordinal(10)]  [RED("questDescription")] public inkTextWidgetReference QuestDescription { get; set; }
		[Ordinal(11)]  [RED("questLevel")] public inkTextWidgetReference QuestLevel { get; set; }
		[Ordinal(12)]  [RED("questTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(13)]  [RED("trackedObjective")] public wCHandle<gameJournalQuestObjective> TrackedObjective { get; set; }

		public QuestDetailsPanelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
