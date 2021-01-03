using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(1)]  [RED("interpolationType")] public CEnum<animEAnimGraphMathInterpolation> InterpolationType { get; set; }
		[Ordinal(2)]  [RED("x1")] public CFloat X1 { get; set; }
		[Ordinal(3)]  [RED("x2")] public CFloat X2 { get; set; }
		[Ordinal(4)]  [RED("y1")] public CFloat Y1 { get; set; }
		[Ordinal(5)]  [RED("y2")] public CFloat Y2 { get; set; }

		public animAnimNode_FloatInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
