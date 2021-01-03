using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationPendulum : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(0)]  [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(1)]  [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(2)]  [RED("constraintOrientation")] public Vector3 ConstraintOrientation { get; set; }
		[Ordinal(3)]  [RED("constraintType")] public CEnum<animPendulumConstraintType> ConstraintType { get; set; }
		[Ordinal(4)]  [RED("cosOfHalfMaxApertureAngle")] public CFloat CosOfHalfMaxApertureAngle { get; set; }
		[Ordinal(5)]  [RED("cosOfHalfOfHalfMaxApertureAngle")] public CFloat CosOfHalfOfHalfMaxApertureAngle { get; set; }
		[Ordinal(6)]  [RED("cosOfHalfXAngle")] public CFloat CosOfHalfXAngle { get; set; }
		[Ordinal(7)]  [RED("cosOfHalfYAngle")] public CFloat CosOfHalfYAngle { get; set; }
		[Ordinal(8)]  [RED("cosOfHalfZAngle")] public CFloat CosOfHalfZAngle { get; set; }
		[Ordinal(9)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(10)]  [RED("externalForceWS")] public Vector3 ExternalForceWS { get; set; }
		[Ordinal(11)]  [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
		[Ordinal(12)]  [RED("gravityWS")] public CFloat GravityWS { get; set; }
		[Ordinal(13)]  [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
		[Ordinal(14)]  [RED("invertedMass")] public CFloat InvertedMass { get; set; }
		[Ordinal(15)]  [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(16)]  [RED("projectionType")] public CEnum<animPendulumProjectionType> ProjectionType { get; set; }
		[Ordinal(17)]  [RED("pullForceDirectionLS")] public Vector3 PullForceDirectionLS { get; set; }
		[Ordinal(18)]  [RED("pullForceFactor")] public CFloat PullForceFactor { get; set; }
		[Ordinal(19)]  [RED("simulationFps")] public CFloat SimulationFps { get; set; }
		[Ordinal(20)]  [RED("sinOfHalfOfHalfMaxApertureAngle")] public CFloat SinOfHalfOfHalfMaxApertureAngle { get; set; }
		[Ordinal(21)]  [RED("sinOfHalfXAngle")] public CFloat SinOfHalfXAngle { get; set; }
		[Ordinal(22)]  [RED("sinOfHalfYAngle")] public CFloat SinOfHalfYAngle { get; set; }
		[Ordinal(23)]  [RED("sinOfHalfZAngle")] public CFloat SinOfHalfZAngle { get; set; }

		public animDangleConstraint_SimulationPendulum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
