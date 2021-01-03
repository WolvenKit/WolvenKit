using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSpring : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(0)]  [RED("collisionSphereRadius")] public CFloat CollisionSphereRadius { get; set; }
		[Ordinal(1)]  [RED("constraintOrientation")] public Vector2 ConstraintOrientation { get; set; }
		[Ordinal(2)]  [RED("constraintScale1")] public CFloat ConstraintScale1 { get; set; }
		[Ordinal(3)]  [RED("constraintScale2")] public CFloat ConstraintScale2 { get; set; }
		[Ordinal(4)]  [RED("constraintSphereRadius")] public CFloat ConstraintSphereRadius { get; set; }
		[Ordinal(5)]  [RED("cosOfHalfXAngle")] public CFloat CosOfHalfXAngle { get; set; }
		[Ordinal(6)]  [RED("cosOfHalfYAngle")] public CFloat CosOfHalfYAngle { get; set; }
		[Ordinal(7)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(8)]  [RED("externalForceWS")] public Vector3 ExternalForceWS { get; set; }
		[Ordinal(9)]  [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
		[Ordinal(10)]  [RED("gravityWS")] public CFloat GravityWS { get; set; }
		[Ordinal(11)]  [RED("invertedMass")] public CFloat InvertedMass { get; set; }
		[Ordinal(12)]  [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(13)]  [RED("projectionType")] public CEnum<animSpringProjectionType> ProjectionType { get; set; }
		[Ordinal(14)]  [RED("pullForceFactor")] public CFloat PullForceFactor { get; set; }
		[Ordinal(15)]  [RED("pullForceOriginLS")] public Vector3 PullForceOriginLS { get; set; }
		[Ordinal(16)]  [RED("simulationFps")] public CFloat SimulationFps { get; set; }
		[Ordinal(17)]  [RED("sinOfHalfXAngle")] public CFloat SinOfHalfXAngle { get; set; }
		[Ordinal(18)]  [RED("sinOfHalfYAngle")] public CFloat SinOfHalfYAngle { get; set; }

		public animDangleConstraint_SimulationSpring(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
