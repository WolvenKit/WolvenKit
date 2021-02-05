using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionInterpolation : animAnimNode_QuaternionValue
	{
		[Ordinal(0)]  [RED("interpolationType")] public CEnum<animQuaternionInterpolationType> InterpolationType { get; set; }
		[Ordinal(1)]  [RED("firstInput")] public animQuaternionLink FirstInput { get; set; }
		[Ordinal(2)]  [RED("secondInput")] public animQuaternionLink SecondInput { get; set; }
		[Ordinal(3)]  [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_QuaternionInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
