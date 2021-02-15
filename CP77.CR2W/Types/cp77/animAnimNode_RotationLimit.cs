using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(3)] [RED("limitOnX")] public animSmoothFloatClamp LimitOnX { get; set; }
		[Ordinal(4)] [RED("limitOnY")] public animSmoothFloatClamp LimitOnY { get; set; }
		[Ordinal(5)] [RED("limitOnZ")] public animSmoothFloatClamp LimitOnZ { get; set; }
		[Ordinal(6)] [RED("useEyesLookAtBlendWeight")] public CBool UseEyesLookAtBlendWeight { get; set; }
		[Ordinal(7)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }

		public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
