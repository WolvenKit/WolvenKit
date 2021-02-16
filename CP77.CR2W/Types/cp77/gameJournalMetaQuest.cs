using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuest : gameJournalFileEntry
	{
		[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }

		public gameJournalMetaQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
