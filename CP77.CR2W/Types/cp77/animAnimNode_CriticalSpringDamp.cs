using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("smoothTime")] public CFloat SmoothTime { get; set; }
		[Ordinal(2)] [RED("useRange")] public CBool UseRange { get; set; }
		[Ordinal(3)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(4)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(5)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_CriticalSpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
