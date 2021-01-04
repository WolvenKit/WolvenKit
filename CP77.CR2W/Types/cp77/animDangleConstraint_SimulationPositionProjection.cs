using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(0)]  [RED("collisionCapsuleAxisLS")] public Vector3 CollisionCapsuleAxisLS { get; set; }
		[Ordinal(1)]  [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(2)]  [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(3)]  [RED("directionReferenceBone")] public animTransformIndex DirectionReferenceBone { get; set; }
		[Ordinal(4)]  [RED("projectionType")] public CEnum<animPositionProjectionType> ProjectionType { get; set; }

		public animDangleConstraint_SimulationPositionProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
