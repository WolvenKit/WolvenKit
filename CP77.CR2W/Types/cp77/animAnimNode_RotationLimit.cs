using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(1)]  [RED("limitOnX")] public animSmoothFloatClamp LimitOnX { get; set; }
		[Ordinal(2)]  [RED("limitOnY")] public animSmoothFloatClamp LimitOnY { get; set; }
		[Ordinal(3)]  [RED("limitOnZ")] public animSmoothFloatClamp LimitOnZ { get; set; }
		[Ordinal(4)]  [RED("useEyesLookAtBlendWeight")] public CBool UseEyesLookAtBlendWeight { get; set; }
		[Ordinal(5)]  [RED("weightLink")] public animFloatLink WeightLink { get; set; }

		public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
