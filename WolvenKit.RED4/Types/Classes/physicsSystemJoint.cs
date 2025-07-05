using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSystemJoint : physicsISystemObject
	{
		[Ordinal(1)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(2)] 
		[RED("pinA")] 
		public CHandle<physicsPhysicalJointPin> PinA
		{
			get => GetPropertyValue<CHandle<physicsPhysicalJointPin>>();
			set => SetPropertyValue<CHandle<physicsPhysicalJointPin>>(value);
		}

		[Ordinal(3)] 
		[RED("pinB")] 
		public CHandle<physicsPhysicalJointPin> PinB
		{
			get => GetPropertyValue<CHandle<physicsPhysicalJointPin>>();
			set => SetPropertyValue<CHandle<physicsPhysicalJointPin>>(value);
		}

		[Ordinal(4)] 
		[RED("linearLimit")] 
		public physicsPhysicsJointLinearLimit LinearLimit
		{
			get => GetPropertyValue<physicsPhysicsJointLinearLimit>();
			set => SetPropertyValue<physicsPhysicsJointLinearLimit>(value);
		}

		[Ordinal(5)] 
		[RED("twistLimit")] 
		public physicsPhysicsJointAngularLimitPair TwistLimit
		{
			get => GetPropertyValue<physicsPhysicsJointAngularLimitPair>();
			set => SetPropertyValue<physicsPhysicsJointAngularLimitPair>(value);
		}

		[Ordinal(6)] 
		[RED("swingLimit")] 
		public physicsPhysicsJointLimitConePair SwingLimit
		{
			get => GetPropertyValue<physicsPhysicsJointLimitConePair>();
			set => SetPropertyValue<physicsPhysicsJointLimitConePair>(value);
		}

		[Ordinal(7)] 
		[RED("driveY")] 
		public physicsPhysicsJointDrive DriveY
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(8)] 
		[RED("driveX")] 
		public physicsPhysicsJointDrive DriveX
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(9)] 
		[RED("driveZ")] 
		public physicsPhysicsJointDrive DriveZ
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(10)] 
		[RED("driveTwist")] 
		public physicsPhysicsJointDrive DriveTwist
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(11)] 
		[RED("driveSwing")] 
		public physicsPhysicsJointDrive DriveSwing
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(12)] 
		[RED("driveSLERP")] 
		public physicsPhysicsJointDrive DriveSLERP
		{
			get => GetPropertyValue<physicsPhysicsJointDrive>();
			set => SetPropertyValue<physicsPhysicsJointDrive>(value);
		}

		[Ordinal(13)] 
		[RED("driveVelocity")] 
		public physicsPhysicsJointDriveVelocity DriveVelocity
		{
			get => GetPropertyValue<physicsPhysicsJointDriveVelocity>();
			set => SetPropertyValue<physicsPhysicsJointDriveVelocity>(value);
		}

		[Ordinal(14)] 
		[RED("drivePosition")] 
		public CMatrix DrivePosition
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(15)] 
		[RED("projectionEnabled")] 
		public CBool ProjectionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("linearTolerance")] 
		public CFloat LinearTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("angularTolerance")] 
		public CFloat AngularTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("isBreakable")] 
		public CBool IsBreakable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("breakingForce")] 
		public CFloat BreakingForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("breakingTorque")] 
		public CFloat BreakingTorque
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsSystemJoint()
		{
			LocalToWorld = new CMatrix();
			LinearLimit = new physicsPhysicsJointLinearLimit();
			TwistLimit = new physicsPhysicsJointAngularLimitPair { Upper = 180.000000F, Lower = -180.000000F };
			SwingLimit = new physicsPhysicsJointLimitConePair();
			DriveY = new physicsPhysicsJointDrive();
			DriveX = new physicsPhysicsJointDrive();
			DriveZ = new physicsPhysicsJointDrive();
			DriveTwist = new physicsPhysicsJointDrive();
			DriveSwing = new physicsPhysicsJointDrive();
			DriveSLERP = new physicsPhysicsJointDrive();
			DriveVelocity = new physicsPhysicsJointDriveVelocity { LinearVelocity = new Vector4 { W = 1.000000F }, AngularVelocity = new Vector4 { W = 1.000000F } };
			DrivePosition = new CMatrix();
			LinearTolerance = 10000000000.000000F;
			AngularTolerance = 3.141593F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
