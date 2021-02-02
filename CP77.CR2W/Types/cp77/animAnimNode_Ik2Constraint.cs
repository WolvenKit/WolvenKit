using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2Constraint : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("inputTarget")] public CHandle<animIAnimNodeSourceChannel_Vector> InputTarget { get; set; }
		[Ordinal(1)]  [RED("inputPoleVector")] public CHandle<animIAnimNodeSourceChannel_Vector> InputPoleVector { get; set; }
		[Ordinal(2)]  [RED("inputTargetOrientation")] public CHandle<animAnimNodeSourceChannel_WeightedQuat> InputTargetOrientation { get; set; }
		[Ordinal(3)]  [RED("firstBoneIndex")] public animTransformIndex FirstBoneIndex { get; set; }
		[Ordinal(4)]  [RED("secondBoneIndex")] public animTransformIndex SecondBoneIndex { get; set; }
		[Ordinal(5)]  [RED("endBoneIndex")] public animTransformIndex EndBoneIndex { get; set; }
		[Ordinal(6)]  [RED("hingeAxis")] public CEnum<animAxis> HingeAxis { get; set; }
		[Ordinal(7)]  [RED("twistValue")] public CFloat TwistValue { get; set; }
		[Ordinal(8)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(9)]  [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }
		[Ordinal(10)]  [RED("maxHingeAngle")] public CFloat MaxHingeAngle { get; set; }
		[Ordinal(11)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(12)]  [RED("twistNode")] public animFloatLink TwistNode { get; set; }

		public animAnimNode_Ik2Constraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
