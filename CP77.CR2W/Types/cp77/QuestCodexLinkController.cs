using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestCodexLinkController : BaseCodexLinkController
	{
		[Ordinal(4)] [RED("codexEntry")] public CHandle<gameJournalCodexEntry> CodexEntry { get; set; }

		public QuestCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
