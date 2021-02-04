using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSystemJoint : physicsISystemObject
	{
		[Ordinal(0)]  [RED("localToWorld")] public CMatrix LocalToWorld { get; set; }
		[Ordinal(1)]  [RED("pinA")] public CHandle<physicsPhysicalJointPin> PinA { get; set; }
		[Ordinal(2)]  [RED("pinB")] public CHandle<physicsPhysicalJointPin> PinB { get; set; }
		[Ordinal(3)]  [RED("linearLimit")] public physicsPhysicsJointLinearLimit LinearLimit { get; set; }
		[Ordinal(4)]  [RED("twistLimit")] public physicsPhysicsJointAngularLimitPair TwistLimit { get; set; }
		[Ordinal(5)]  [RED("swingLimit")] public physicsPhysicsJointLimitConePair SwingLimit { get; set; }
		[Ordinal(6)]  [RED("driveY")] public physicsPhysicsJointDrive DriveY { get; set; }
		[Ordinal(7)]  [RED("driveX")] public physicsPhysicsJointDrive DriveX { get; set; }
		[Ordinal(8)]  [RED("driveZ")] public physicsPhysicsJointDrive DriveZ { get; set; }
		[Ordinal(9)]  [RED("driveTwist")] public physicsPhysicsJointDrive DriveTwist { get; set; }
		[Ordinal(10)]  [RED("driveSwing")] public physicsPhysicsJointDrive DriveSwing { get; set; }
		[Ordinal(11)]  [RED("driveSLERP")] public physicsPhysicsJointDrive DriveSLERP { get; set; }
		[Ordinal(12)]  [RED("driveVelocity")] public physicsPhysicsJointDriveVelocity DriveVelocity { get; set; }
		[Ordinal(13)]  [RED("drivePosition")] public CMatrix DrivePosition { get; set; }
		[Ordinal(14)]  [RED("projectionEnabled")] public CBool ProjectionEnabled { get; set; }
		[Ordinal(15)]  [RED("linearTolerance")] public CFloat LinearTolerance { get; set; }
		[Ordinal(16)]  [RED("angularTolerance")] public CFloat AngularTolerance { get; set; }
		[Ordinal(17)]  [RED("isBreakable")] public CBool IsBreakable { get; set; }
		[Ordinal(18)]  [RED("breakingForce")] public CFloat BreakingForce { get; set; }
		[Ordinal(19)]  [RED("breakingTorque")] public CFloat BreakingTorque { get; set; }

		public physicsSystemJoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
