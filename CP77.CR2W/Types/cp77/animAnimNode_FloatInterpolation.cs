using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("x1")] public CFloat X1 { get; set; }
		[Ordinal(12)] [RED("x2")] public CFloat X2 { get; set; }
		[Ordinal(13)] [RED("y1")] public CFloat Y1 { get; set; }
		[Ordinal(14)] [RED("y2")] public CFloat Y2 { get; set; }
		[Ordinal(15)] [RED("interpolationType")] public CEnum<animEAnimGraphMathInterpolation> InterpolationType { get; set; }
		[Ordinal(16)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_FloatInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
