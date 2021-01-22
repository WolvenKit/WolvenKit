using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("IKBlendTime")] public CFloat IKBlendTime { get; set; }
		[Ordinal(1)]  [RED("adjustPelvisVertically")] public CBool AdjustPelvisVertically { get; set; }
		[Ordinal(2)]  [RED("calfHingeAxis")] public Vector4 CalfHingeAxis { get; set; }
		[Ordinal(3)]  [RED("controlValueNode")] public animFloatLink ControlValueNode { get; set; }
		[Ordinal(4)]  [RED("controlVectorNode")] public animVectorLink ControlVectorNode { get; set; }
		[Ordinal(5)]  [RED("leftCalfName")] public animTransformIndex LeftCalfName { get; set; }
		[Ordinal(6)]  [RED("leftFootName")] public animTransformIndex LeftFootName { get; set; }
		[Ordinal(7)]  [RED("leftThighName")] public animTransformIndex LeftThighName { get; set; }
		[Ordinal(8)]  [RED("leftToeName")] public animTransformIndex LeftToeName { get; set; }
		[Ordinal(9)]  [RED("pelvisAdjustmentBlendSpeed")] public CFloat PelvisAdjustmentBlendSpeed { get; set; }
		[Ordinal(10)]  [RED("pelvisBoneName")] public animTransformIndex PelvisBoneName { get; set; }
		[Ordinal(11)]  [RED("rightCalfName")] public animTransformIndex RightCalfName { get; set; }
		[Ordinal(12)]  [RED("rightFootName")] public animTransformIndex RightFootName { get; set; }
		[Ordinal(13)]  [RED("rightThighName")] public animTransformIndex RightThighName { get; set; }
		[Ordinal(14)]  [RED("rightToeName")] public animTransformIndex RightToeName { get; set; }
		[Ordinal(15)]  [RED("stepAdjustmentInterval")] public CFloat StepAdjustmentInterval { get; set; }

		public animAnimNode_FootStepAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
