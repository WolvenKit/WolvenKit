using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("x1")] public CFloat X1 { get; set; }
		[Ordinal(1)]  [RED("x2")] public CFloat X2 { get; set; }
		[Ordinal(2)]  [RED("y1")] public CFloat Y1 { get; set; }
		[Ordinal(3)]  [RED("y2")] public CFloat Y2 { get; set; }
		[Ordinal(4)]  [RED("interpolationType")] public CEnum<animEAnimGraphMathInterpolation> InterpolationType { get; set; }
		[Ordinal(5)]  [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_FloatInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
