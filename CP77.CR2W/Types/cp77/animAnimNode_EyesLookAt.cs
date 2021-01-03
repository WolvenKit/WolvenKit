using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("forwardDirection")] public CEnum<animAxis> ForwardDirection { get; set; }
		[Ordinal(1)]  [RED("head")] public animTransformIndex Head { get; set; }
		[Ordinal(2)]  [RED("leftEye")] public animTransformIndex LeftEye { get; set; }
		[Ordinal(3)]  [RED("rightEye")] public animTransformIndex RightEye { get; set; }
		[Ordinal(4)]  [RED("targetALink")] public animVectorLink TargetALink { get; set; }
		[Ordinal(5)]  [RED("targetBLink")] public animVectorLink TargetBLink { get; set; }
		[Ordinal(6)]  [RED("transitionWeightLink")] public animFloatLink TransitionWeightLink { get; set; }
		[Ordinal(7)]  [RED("weightALink")] public animFloatLink WeightALink { get; set; }
		[Ordinal(8)]  [RED("weightBLink")] public animFloatLink WeightBLink { get; set; }

		public animAnimNode_EyesLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
