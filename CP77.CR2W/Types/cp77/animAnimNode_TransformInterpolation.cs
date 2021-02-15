using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformInterpolation : animAnimNode_TransformValue
	{
		[Ordinal(1)] [RED("interpolationType")] public CEnum<animQuaternionInterpolationType> InterpolationType { get; set; }
		[Ordinal(2)] [RED("firstInput")] public animTransformLink FirstInput { get; set; }
		[Ordinal(3)] [RED("secondInput")] public animTransformLink SecondInput { get; set; }
		[Ordinal(4)] [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_TransformInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
