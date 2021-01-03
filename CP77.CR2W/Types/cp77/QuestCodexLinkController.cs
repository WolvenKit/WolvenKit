using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestCodexLinkController : BaseCodexLinkController
	{
		[Ordinal(0)]  [RED("codexEntry")] public CHandle<gameJournalCodexEntry> CodexEntry { get; set; }

		public QuestCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
