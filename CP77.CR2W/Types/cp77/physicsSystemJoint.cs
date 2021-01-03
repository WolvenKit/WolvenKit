using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsSystemJoint : physicsISystemObject
	{
		[Ordinal(0)]  [RED("angularTolerance")] public CFloat AngularTolerance { get; set; }
		[Ordinal(1)]  [RED("breakingForce")] public CFloat BreakingForce { get; set; }
		[Ordinal(2)]  [RED("breakingTorque")] public CFloat BreakingTorque { get; set; }
		[Ordinal(3)]  [RED("drivePosition")] public CMatrix DrivePosition { get; set; }
		[Ordinal(4)]  [RED("driveSLERP")] public physicsPhysicsJointDrive DriveSLERP { get; set; }
		[Ordinal(5)]  [RED("driveSwing")] public physicsPhysicsJointDrive DriveSwing { get; set; }
		[Ordinal(6)]  [RED("driveTwist")] public physicsPhysicsJointDrive DriveTwist { get; set; }
		[Ordinal(7)]  [RED("driveVelocity")] public physicsPhysicsJointDriveVelocity DriveVelocity { get; set; }
		[Ordinal(8)]  [RED("driveX")] public physicsPhysicsJointDrive DriveX { get; set; }
		[Ordinal(9)]  [RED("driveY")] public physicsPhysicsJointDrive DriveY { get; set; }
		[Ordinal(10)]  [RED("driveZ")] public physicsPhysicsJointDrive DriveZ { get; set; }
		[Ordinal(11)]  [RED("isBreakable")] public CBool IsBreakable { get; set; }
		[Ordinal(12)]  [RED("linearLimit")] public physicsPhysicsJointLinearLimit LinearLimit { get; set; }
		[Ordinal(13)]  [RED("linearTolerance")] public CFloat LinearTolerance { get; set; }
		[Ordinal(14)]  [RED("localToWorld")] public CMatrix LocalToWorld { get; set; }
		[Ordinal(15)]  [RED("pinA")] public CHandle<physicsPhysicalJointPin> PinA { get; set; }
		[Ordinal(16)]  [RED("pinB")] public CHandle<physicsPhysicalJointPin> PinB { get; set; }
		[Ordinal(17)]  [RED("projectionEnabled")] public CBool ProjectionEnabled { get; set; }
		[Ordinal(18)]  [RED("swingLimit")] public physicsPhysicsJointLimitConePair SwingLimit { get; set; }
		[Ordinal(19)]  [RED("twistLimit")] public physicsPhysicsJointAngularLimitPair TwistLimit { get; set; }

		public physicsSystemJoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
