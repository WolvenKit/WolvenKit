using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSystemJoint : physicsISystemObject
	{
		[Ordinal(1)] [RED("localToWorld")] public Matrix LocalToWorld { get; set; }
		[Ordinal(2)] [RED("pinA")] public CHandle<physicsPhysicalJointPin> PinA { get; set; }
		[Ordinal(3)] [RED("pinB")] public CHandle<physicsPhysicalJointPin> PinB { get; set; }
		[Ordinal(4)] [RED("linearLimit")] public physicsPhysicsJointLinearLimit LinearLimit { get; set; }
		[Ordinal(5)] [RED("twistLimit")] public physicsPhysicsJointAngularLimitPair TwistLimit { get; set; }
		[Ordinal(6)] [RED("swingLimit")] public physicsPhysicsJointLimitConePair SwingLimit { get; set; }
		[Ordinal(7)] [RED("driveY")] public physicsPhysicsJointDrive DriveY { get; set; }
		[Ordinal(8)] [RED("driveX")] public physicsPhysicsJointDrive DriveX { get; set; }
		[Ordinal(9)] [RED("driveZ")] public physicsPhysicsJointDrive DriveZ { get; set; }
		[Ordinal(10)] [RED("driveTwist")] public physicsPhysicsJointDrive DriveTwist { get; set; }
		[Ordinal(11)] [RED("driveSwing")] public physicsPhysicsJointDrive DriveSwing { get; set; }
		[Ordinal(12)] [RED("driveSLERP")] public physicsPhysicsJointDrive DriveSLERP { get; set; }
		[Ordinal(13)] [RED("driveVelocity")] public physicsPhysicsJointDriveVelocity DriveVelocity { get; set; }
		[Ordinal(14)] [RED("drivePosition")] public Matrix DrivePosition { get; set; }
		[Ordinal(15)] [RED("projectionEnabled")] public CBool ProjectionEnabled { get; set; }
		[Ordinal(16)] [RED("linearTolerance")] public CFloat LinearTolerance { get; set; }
		[Ordinal(17)] [RED("angularTolerance")] public CFloat AngularTolerance { get; set; }
		[Ordinal(18)] [RED("isBreakable")] public CBool IsBreakable { get; set; }
		[Ordinal(19)] [RED("breakingForce")] public CFloat BreakingForce { get; set; }
		[Ordinal(20)] [RED("breakingTorque")] public CFloat BreakingTorque { get; set; }

		public physicsSystemJoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
