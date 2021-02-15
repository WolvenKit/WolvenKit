using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveCounterData : CVariable
	{
		[Ordinal(0)] [RED("entryPath")] public CHandle<gameJournalPath> EntryPath { get; set; }
		[Ordinal(1)] [RED("oldValue")] public CInt32 OldValue { get; set; }
		[Ordinal(2)] [RED("newValue")] public CInt32 NewValue { get; set; }

		public gameJournalQuestObjectiveCounterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
