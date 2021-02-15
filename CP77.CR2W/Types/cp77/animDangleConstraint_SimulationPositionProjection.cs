using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(9)] [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(10)] [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(11)] [RED("collisionCapsuleAxisLS")] public Vector3 CollisionCapsuleAxisLS { get; set; }
		[Ordinal(12)] [RED("directionReferenceBone")] public animTransformIndex DirectionReferenceBone { get; set; }
		[Ordinal(13)] [RED("projectionType")] public CEnum<animPositionProjectionType> ProjectionType { get; set; }

		public animDangleConstraint_SimulationPositionProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
