using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexDescription_ : gameJournalEntry
	{
		[Ordinal(1)] [RED("subTitle")] public LocalizationString SubTitle { get; set; }
		[Ordinal(2)] [RED("textContent")] public LocalizationString TextContent { get; set; }

		public gameJournalCodexDescription_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
