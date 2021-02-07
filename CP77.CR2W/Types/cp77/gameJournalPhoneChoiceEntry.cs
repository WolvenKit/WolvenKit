using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneChoiceEntry : gameJournalEntry
	{
		[Ordinal(0)]  [RED("text")] public LocalizationString Text { get; set; }
		[Ordinal(1)]  [RED("isQuestImportant")] public CBool IsQuestImportant { get; set; }

		public gameJournalPhoneChoiceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
