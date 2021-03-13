using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformInterpolation : animAnimNode_TransformValue
	{
		[Ordinal(11)] [RED("interpolationType")] public CEnum<animQuaternionInterpolationType> InterpolationType { get; set; }
		[Ordinal(12)] [RED("firstInput")] public animTransformLink FirstInput { get; set; }
		[Ordinal(13)] [RED("secondInput")] public animTransformLink SecondInput { get; set; }
		[Ordinal(14)] [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_TransformInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
