using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackLockHacks : redEvent
	{
		[Ordinal(0)] [RED("IsLocked")] public CBool IsLocked { get; set; }

		public QuickHackLockHacks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
