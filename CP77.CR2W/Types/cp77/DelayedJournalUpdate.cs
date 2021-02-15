using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayedJournalUpdate : redEvent
	{
		[Ordinal(0)] [RED("newMessageSpawned")] public CBool NewMessageSpawned { get; set; }

		public DelayedJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
