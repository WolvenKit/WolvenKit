using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questJournalNotification_ConditionType : questIUIConditionType
	{
		[Ordinal(0)]  [RED("journalPath")] public CHandle<gameJournalPath> JournalPath { get; set; }

		public questJournalNotification_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
