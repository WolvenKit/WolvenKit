using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(14)] [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(15)] [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(16)] [RED("collisionCapsuleAxisLS")] public Vector3 CollisionCapsuleAxisLS { get; set; }
		[Ordinal(17)] [RED("directionReferenceBone")] public animTransformIndex DirectionReferenceBone { get; set; }
		[Ordinal(18)] [RED("projectionType")] public CEnum<animPositionProjectionType> ProjectionType { get; set; }

		public animDangleConstraint_SimulationPositionProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
