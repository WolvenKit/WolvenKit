using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorInterpolation : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("firstInput")] public animVectorLink FirstInput { get; set; }
		[Ordinal(1)]  [RED("secondInput")] public animVectorLink SecondInput { get; set; }
		[Ordinal(2)]  [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_VectorInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
