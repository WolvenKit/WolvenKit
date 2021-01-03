using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ABaseQuestObjectiveWrapper : AJournalEntryWrapper
	{
		[Ordinal(0)]  [RED("currentCounter")] public CInt32 CurrentCounter { get; set; }
		[Ordinal(1)]  [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(2)]  [RED("objectiveStatus")] public CEnum<gameJournalEntryState> ObjectiveStatus { get; set; }
		[Ordinal(3)]  [RED("questObjective")] public wCHandle<gameJournalQuestObjectiveBase> QuestObjective { get; set; }
		[Ordinal(4)]  [RED("totalCounter")] public CInt32 TotalCounter { get; set; }

		public ABaseQuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
