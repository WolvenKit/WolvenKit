using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintCone : animIDyngConstraint
	{
		[Ordinal(0)] [RED("constrainedBone")] public animTransformIndex ConstrainedBone { get; set; }
		[Ordinal(1)] [RED("coneAttachmentBone")] public animTransformIndex ConeAttachmentBone { get; set; }
		[Ordinal(2)] [RED("coneTransformLS")] public QsTransform ConeTransformLS { get; set; }
		[Ordinal(3)] [RED("constraintType")] public CEnum<animPendulumConstraintType> ConstraintType { get; set; }
		[Ordinal(4)] [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
		[Ordinal(5)] [RED("projectionType")] public CEnum<animPendulumProjectionType> ProjectionType { get; set; }
		[Ordinal(6)] [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(7)] [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }

		public animDyngConstraintCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
