using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalOnscreen : gameJournalEntry
	{
		[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(3)] [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(4)] [RED("iconID")] public TweakDBID IconID { get; set; }

		public gameJournalOnscreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
