using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintCone : animIDyngConstraint
	{
		[Ordinal(1)] [RED("constrainedBone")] public animTransformIndex ConstrainedBone { get; set; }
		[Ordinal(2)] [RED("coneAttachmentBone")] public animTransformIndex ConeAttachmentBone { get; set; }
		[Ordinal(3)] [RED("coneTransformLS")] public QsTransform ConeTransformLS { get; set; }
		[Ordinal(4)] [RED("constraintType")] public CEnum<animPendulumConstraintType> ConstraintType { get; set; }
		[Ordinal(5)] [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
		[Ordinal(6)] [RED("projectionType")] public CEnum<animPendulumProjectionType> ProjectionType { get; set; }
		[Ordinal(7)] [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(8)] [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }

		public animDyngConstraintCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
