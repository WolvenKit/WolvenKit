using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("targetALink")] public animVectorLink TargetALink { get; set; }
		[Ordinal(13)] [RED("weightALink")] public animFloatLink WeightALink { get; set; }
		[Ordinal(14)] [RED("targetBLink")] public animVectorLink TargetBLink { get; set; }
		[Ordinal(15)] [RED("weightBLink")] public animFloatLink WeightBLink { get; set; }
		[Ordinal(16)] [RED("transitionWeightLink")] public animFloatLink TransitionWeightLink { get; set; }
		[Ordinal(17)] [RED("leftEye")] public animTransformIndex LeftEye { get; set; }
		[Ordinal(18)] [RED("rightEye")] public animTransformIndex RightEye { get; set; }
		[Ordinal(19)] [RED("head")] public animTransformIndex Head { get; set; }
		[Ordinal(20)] [RED("forwardDirection")] public CEnum<animAxis> ForwardDirection { get; set; }

		public animAnimNode_EyesLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
