using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformInterpolation : animAnimNode_TransformValue
	{
		[Ordinal(0)]  [RED("firstInput")] public animTransformLink FirstInput { get; set; }
		[Ordinal(1)]  [RED("interpolationType")] public CEnum<animQuaternionInterpolationType> InterpolationType { get; set; }
		[Ordinal(2)]  [RED("secondInput")] public animTransformLink SecondInput { get; set; }
		[Ordinal(3)]  [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_TransformInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
