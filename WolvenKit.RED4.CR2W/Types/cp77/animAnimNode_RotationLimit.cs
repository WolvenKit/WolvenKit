using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(13)] [RED("limitOnX")] public animSmoothFloatClamp LimitOnX { get; set; }
		[Ordinal(14)] [RED("limitOnY")] public animSmoothFloatClamp LimitOnY { get; set; }
		[Ordinal(15)] [RED("limitOnZ")] public animSmoothFloatClamp LimitOnZ { get; set; }
		[Ordinal(16)] [RED("useEyesLookAtBlendWeight")] public CBool UseEyesLookAtBlendWeight { get; set; }
		[Ordinal(17)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }

		public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
