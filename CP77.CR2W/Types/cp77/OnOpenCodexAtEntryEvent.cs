using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnOpenCodexAtEntryEvent : redEvent
	{
		[Ordinal(0)] [RED("entry")] public wCHandle<gameJournalCodexEntry> Entry { get; set; }

		public OnOpenCodexAtEntryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
