using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questJournalEntry_ConditionType : questIJournalConditionType
	{
		[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<gameJournalEntryUserState> State { get; set; }

		public questJournalEntry_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
