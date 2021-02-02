using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2 : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("firstBone")] public animTransformIndex FirstBone { get; set; }
		[Ordinal(1)]  [RED("secondBone")] public animTransformIndex SecondBone { get; set; }
		[Ordinal(2)]  [RED("endBone")] public animTransformIndex EndBone { get; set; }
		[Ordinal(3)]  [RED("hingeAxis")] public CEnum<animAxis> HingeAxis { get; set; }
		[Ordinal(4)]  [RED("minHingeAngleDegrees")] public CFloat MinHingeAngleDegrees { get; set; }
		[Ordinal(5)]  [RED("maxHingeAngleDegrees")] public CFloat MaxHingeAngleDegrees { get; set; }
		[Ordinal(6)]  [RED("firstBoneIkGain")] public CFloat FirstBoneIkGain { get; set; }
		[Ordinal(7)]  [RED("secondBoneIkGain")] public CFloat SecondBoneIkGain { get; set; }
		[Ordinal(8)]  [RED("endBoneIkGain")] public CFloat EndBoneIkGain { get; set; }
		[Ordinal(9)]  [RED("enforceEndPosition")] public CBool EnforceEndPosition { get; set; }
		[Ordinal(10)]  [RED("enforceEndOrientation")] public CBool EnforceEndOrientation { get; set; }
		[Ordinal(11)]  [RED("endBoneOffsetPositionLS")] public Vector4 EndBoneOffsetPositionLS { get; set; }
		[Ordinal(12)]  [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(13)]  [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(14)]  [RED("inputPoseNode")] public animPoseLink InputPoseNode { get; set; }
		[Ordinal(15)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(16)]  [RED("endTargetPositionNode")] public animVectorLink EndTargetPositionNode { get; set; }
		[Ordinal(17)]  [RED("endTargetOrientationNode")] public animQuaternionLink EndTargetOrientationNode { get; set; }

		public animAnimNode_Ik2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
