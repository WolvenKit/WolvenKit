using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexDescription : gameJournalEntry
	{
		[Ordinal(0)]  [RED("subTitle")] public LocalizationString SubTitle { get; set; }
		[Ordinal(1)]  [RED("textContent")] public LocalizationString TextContent { get; set; }

		[Ordinal(999)]  [RED("activatedAtStart")] public CBool activatedAtStart { get; set; }

		public gameJournalCodexDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
