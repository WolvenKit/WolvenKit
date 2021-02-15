using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveCustomMoveEvent : gameActionEvent
	{
		[Ordinal(4)] [RED("test")] public CInt32 Test { get; set; }

		public moveCustomMoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
