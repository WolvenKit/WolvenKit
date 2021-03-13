using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EventValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(12)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }

		public animAnimNode_EventValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
