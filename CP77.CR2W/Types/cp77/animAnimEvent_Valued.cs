using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Valued : animAnimEvent
	{
		[Ordinal(3)] [RED("value")] public CFloat Value { get; set; }

		public animAnimEvent_Valued(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
