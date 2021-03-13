using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRequestPushContextEvent : redEvent
	{
		[Ordinal(0)] [RED("context")] public CEnum<UIGameContext> Context { get; set; }

		public gameuiRequestPushContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
