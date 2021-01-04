using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackEvent : redEvent
	{
		[Ordinal(0)]  [RED("quickHackName")] public CName QuickHackName { get; set; }
		[Ordinal(1)]  [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }

		public SetQuickHackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
