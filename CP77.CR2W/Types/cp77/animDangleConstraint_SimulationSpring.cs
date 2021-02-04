using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSpring : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(0)]  [RED("constraintSphereRadius")] public CFloat ConstraintSphereRadius { get; set; }
		[Ordinal(1)]  [RED("constraintScale1")] public CFloat ConstraintScale1 { get; set; }
		[Ordinal(2)]  [RED("constraintScale2")] public CFloat ConstraintScale2 { get; set; }
		[Ordinal(3)]  [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(4)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(5)]  [RED("pullForceFactor")] public CFloat PullForceFactor { get; set; }
		[Ordinal(6)]  [RED("externalForceWS")] public Vector3 ExternalForceWS { get; set; }
		[Ordinal(7)]  [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
		[Ordinal(8)]  [RED("collisionSphereRadius")] public CFloat CollisionSphereRadius { get; set; }
		[Ordinal(9)]  [RED("invertedMass")] public CFloat InvertedMass { get; set; }
		[Ordinal(10)]  [RED("simulationFps")] public CFloat SimulationFps { get; set; }
		[Ordinal(11)]  [RED("gravityWS")] public CFloat GravityWS { get; set; }
		[Ordinal(12)]  [RED("pullForceOriginLS")] public Vector3 PullForceOriginLS { get; set; }
		[Ordinal(13)]  [RED("projectionType")] public CEnum<animSpringProjectionType> ProjectionType { get; set; }
		[Ordinal(14)]  [RED("constraintOrientation")] public Vector2 ConstraintOrientation { get; set; }
		[Ordinal(15)]  [RED("cosOfHalfXAngle")] public CFloat CosOfHalfXAngle { get; set; }
		[Ordinal(16)]  [RED("cosOfHalfYAngle")] public CFloat CosOfHalfYAngle { get; set; }
		[Ordinal(17)]  [RED("sinOfHalfXAngle")] public CFloat SinOfHalfXAngle { get; set; }
		[Ordinal(18)]  [RED("sinOfHalfYAngle")] public CFloat SinOfHalfYAngle { get; set; }

		public animDangleConstraint_SimulationSpring(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
