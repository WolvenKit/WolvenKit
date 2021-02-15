using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalResource : gameJournalBaseResource
	{
		[Ordinal(1)] [RED("entry")] public CHandle<gameJournalEntry> Entry { get; set; }

		public gameJournalResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
