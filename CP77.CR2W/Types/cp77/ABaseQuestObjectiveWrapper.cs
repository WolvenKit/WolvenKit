using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ABaseQuestObjectiveWrapper : AJournalEntryWrapper
	{
		[Ordinal(0)]  [RED("UniqueId")] public CInt32 UniqueId { get; set; }
		[Ordinal(1)]  [RED("questObjective")] public wCHandle<gameJournalQuestObjectiveBase> QuestObjective { get; set; }
		[Ordinal(2)]  [RED("objectiveStatus")] public CEnum<gameJournalEntryState> ObjectiveStatus { get; set; }
		[Ordinal(3)]  [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(4)]  [RED("currentCounter")] public CInt32 CurrentCounter { get; set; }
		[Ordinal(5)]  [RED("totalCounter")] public CInt32 TotalCounter { get; set; }

		public ABaseQuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
