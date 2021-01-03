using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintCone : animIDyngConstraint
	{
		[Ordinal(0)]  [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(1)]  [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(2)]  [RED("coneAttachmentBone")] public animTransformIndex ConeAttachmentBone { get; set; }
		[Ordinal(3)]  [RED("coneTransformLS")] public QsTransform ConeTransformLS { get; set; }
		[Ordinal(4)]  [RED("constrainedBone")] public animTransformIndex ConstrainedBone { get; set; }
		[Ordinal(5)]  [RED("constraintType")] public CEnum<animPendulumConstraintType> ConstraintType { get; set; }
		[Ordinal(6)]  [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
		[Ordinal(7)]  [RED("projectionType")] public CEnum<animPendulumProjectionType> ProjectionType { get; set; }

		public animDyngConstraintCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
