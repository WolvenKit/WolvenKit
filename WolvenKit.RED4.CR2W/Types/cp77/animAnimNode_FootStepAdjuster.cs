using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("leftToeName")] public animTransformIndex LeftToeName { get; set; }
		[Ordinal(13)] [RED("rightToeName")] public animTransformIndex RightToeName { get; set; }
		[Ordinal(14)] [RED("leftFootName")] public animTransformIndex LeftFootName { get; set; }
		[Ordinal(15)] [RED("rightFootName")] public animTransformIndex RightFootName { get; set; }
		[Ordinal(16)] [RED("leftCalfName")] public animTransformIndex LeftCalfName { get; set; }
		[Ordinal(17)] [RED("rightCalfName")] public animTransformIndex RightCalfName { get; set; }
		[Ordinal(18)] [RED("leftThighName")] public animTransformIndex LeftThighName { get; set; }
		[Ordinal(19)] [RED("rightThighName")] public animTransformIndex RightThighName { get; set; }
		[Ordinal(20)] [RED("pelvisBoneName")] public animTransformIndex PelvisBoneName { get; set; }
		[Ordinal(21)] [RED("calfHingeAxis")] public Vector4 CalfHingeAxis { get; set; }
		[Ordinal(22)] [RED("IKBlendTime")] public CFloat IKBlendTime { get; set; }
		[Ordinal(23)] [RED("pelvisAdjustmentBlendSpeed")] public CFloat PelvisAdjustmentBlendSpeed { get; set; }
		[Ordinal(24)] [RED("adjustPelvisVertically")] public CBool AdjustPelvisVertically { get; set; }
		[Ordinal(25)] [RED("stepAdjustmentInterval")] public CFloat StepAdjustmentInterval { get; set; }
		[Ordinal(26)] [RED("controlValueNode")] public animFloatLink ControlValueNode { get; set; }
		[Ordinal(27)] [RED("controlVectorNode")] public animVectorLink ControlVectorNode { get; set; }

		public animAnimNode_FootStepAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
