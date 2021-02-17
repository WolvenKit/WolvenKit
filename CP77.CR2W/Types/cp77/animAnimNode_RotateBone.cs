using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotateBone : animAnimNode_Base
	{
		[Ordinal(1)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(2)] [RED("angleNode")] public animFloatLink AngleNode { get; set; }
		[Ordinal(3)] [RED("minValueNode")] public animFloatLink MinValueNode { get; set; }
		[Ordinal(4)] [RED("maxValueNode")] public animFloatLink MaxValueNode { get; set; }
		[Ordinal(5)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(6)] [RED("axis")] public CEnum<animETransformAxis> Axis { get; set; }
		[Ordinal(7)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(8)] [RED("biasAngle")] public CFloat BiasAngle { get; set; }
		[Ordinal(9)] [RED("minAngle")] public CFloat MinAngle { get; set; }
		[Ordinal(10)] [RED("maxAngle")] public CFloat MaxAngle { get; set; }
		[Ordinal(11)] [RED("clampRotation")] public CBool ClampRotation { get; set; }
		[Ordinal(12)] [RED("useIncrementalMode")] public CBool UseIncrementalMode { get; set; }
		[Ordinal(13)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(14)] [RED("inModelSpace")] public CBool InModelSpace { get; set; }

		public animAnimNode_RotateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
