using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomNotificationEvent : redEvent
	{
		[Ordinal(0)] [RED("header")] public CString Header { get; set; }
		[Ordinal(1)] [RED("description")] public CString Description { get; set; }
		[Ordinal(2)] [RED("icon")] public CName Icon { get; set; }
		[Ordinal(3)] [RED("fluff_header")] public CString Fluff_header { get; set; }

		public CustomNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
