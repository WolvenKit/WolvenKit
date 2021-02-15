using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTrackedData : CVariable
	{
		[Ordinal(0)] [RED("entryPath")] public CHandle<gameJournalPath> EntryPath { get; set; }
		[Ordinal(1)] [RED("entryType")] public CName EntryType { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }

		public gameJournalQuestTrackedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
