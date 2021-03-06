using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2 : animAnimNode_Base
	{
		[Ordinal(11)] [RED("firstBone")] public animTransformIndex FirstBone { get; set; }
		[Ordinal(12)] [RED("secondBone")] public animTransformIndex SecondBone { get; set; }
		[Ordinal(13)] [RED("endBone")] public animTransformIndex EndBone { get; set; }
		[Ordinal(14)] [RED("hingeAxis")] public CEnum<animAxis> HingeAxis { get; set; }
		[Ordinal(15)] [RED("minHingeAngleDegrees")] public CFloat MinHingeAngleDegrees { get; set; }
		[Ordinal(16)] [RED("maxHingeAngleDegrees")] public CFloat MaxHingeAngleDegrees { get; set; }
		[Ordinal(17)] [RED("firstBoneIkGain")] public CFloat FirstBoneIkGain { get; set; }
		[Ordinal(18)] [RED("secondBoneIkGain")] public CFloat SecondBoneIkGain { get; set; }
		[Ordinal(19)] [RED("endBoneIkGain")] public CFloat EndBoneIkGain { get; set; }
		[Ordinal(20)] [RED("enforceEndPosition")] public CBool EnforceEndPosition { get; set; }
		[Ordinal(21)] [RED("enforceEndOrientation")] public CBool EnforceEndOrientation { get; set; }
		[Ordinal(22)] [RED("endBoneOffsetPositionLS")] public Vector4 EndBoneOffsetPositionLS { get; set; }
		[Ordinal(23)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(24)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(25)] [RED("inputPoseNode")] public animPoseLink InputPoseNode { get; set; }
		[Ordinal(26)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(27)] [RED("endTargetPositionNode")] public animVectorLink EndTargetPositionNode { get; set; }
		[Ordinal(28)] [RED("endTargetOrientationNode")] public animQuaternionLink EndTargetOrientationNode { get; set; }

		public animAnimNode_Ik2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
