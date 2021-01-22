using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalNotificationData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)]  [RED("journalEntry")] public wCHandle<gameJournalEntry> JournalEntry { get; set; }
		[Ordinal(2)]  [RED("journalEntryState")] public CEnum<gameJournalEntryState> JournalEntryState { get; set; }
		[Ordinal(3)]  [RED("menuMode")] public CBool MenuMode { get; set; }

		public JournalNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
