using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestCodexLink : gameJournalEntry
	{
		[Ordinal(1)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }

		public gameJournalQuestCodexLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
