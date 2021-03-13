using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorInterpolation : animAnimNode_VectorValue
	{
		[Ordinal(11)] [RED("firstInput")] public animVectorLink FirstInput { get; set; }
		[Ordinal(12)] [RED("secondInput")] public animVectorLink SecondInput { get; set; }
		[Ordinal(13)] [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_VectorInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
