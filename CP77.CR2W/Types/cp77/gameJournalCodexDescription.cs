using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexDescription : gameJournalEntry
	{
		[Ordinal(0)]  [RED("subTitle")] public LocalizationString SubTitle { get; set; }
		[Ordinal(1)]  [RED("textContent")] public LocalizationString TextContent { get; set; }

		public gameJournalCodexDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
