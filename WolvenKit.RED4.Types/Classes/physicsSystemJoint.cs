using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSystemJoint : physicsISystemObject
	{
		private CMatrix _localToWorld;
		private CHandle<physicsPhysicalJointPin> _pinA;
		private CHandle<physicsPhysicalJointPin> _pinB;
		private physicsPhysicsJointLinearLimit _linearLimit;
		private physicsPhysicsJointAngularLimitPair _twistLimit;
		private physicsPhysicsJointLimitConePair _swingLimit;
		private physicsPhysicsJointDrive _driveY;
		private physicsPhysicsJointDrive _driveX;
		private physicsPhysicsJointDrive _driveZ;
		private physicsPhysicsJointDrive _driveTwist;
		private physicsPhysicsJointDrive _driveSwing;
		private physicsPhysicsJointDrive _driveSLERP;
		private physicsPhysicsJointDriveVelocity _driveVelocity;
		private CMatrix _drivePosition;
		private CBool _projectionEnabled;
		private CFloat _linearTolerance;
		private CFloat _angularTolerance;
		private CBool _isBreakable;
		private CFloat _breakingForce;
		private CFloat _breakingTorque;

		[Ordinal(1)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetProperty(ref _localToWorld);
			set => SetProperty(ref _localToWorld, value);
		}

		[Ordinal(2)] 
		[RED("pinA")] 
		public CHandle<physicsPhysicalJointPin> PinA
		{
			get => GetProperty(ref _pinA);
			set => SetProperty(ref _pinA, value);
		}

		[Ordinal(3)] 
		[RED("pinB")] 
		public CHandle<physicsPhysicalJointPin> PinB
		{
			get => GetProperty(ref _pinB);
			set => SetProperty(ref _pinB, value);
		}

		[Ordinal(4)] 
		[RED("linearLimit")] 
		public physicsPhysicsJointLinearLimit LinearLimit
		{
			get => GetProperty(ref _linearLimit);
			set => SetProperty(ref _linearLimit, value);
		}

		[Ordinal(5)] 
		[RED("twistLimit")] 
		public physicsPhysicsJointAngularLimitPair TwistLimit
		{
			get => GetProperty(ref _twistLimit);
			set => SetProperty(ref _twistLimit, value);
		}

		[Ordinal(6)] 
		[RED("swingLimit")] 
		public physicsPhysicsJointLimitConePair SwingLimit
		{
			get => GetProperty(ref _swingLimit);
			set => SetProperty(ref _swingLimit, value);
		}

		[Ordinal(7)] 
		[RED("driveY")] 
		public physicsPhysicsJointDrive DriveY
		{
			get => GetProperty(ref _driveY);
			set => SetProperty(ref _driveY, value);
		}

		[Ordinal(8)] 
		[RED("driveX")] 
		public physicsPhysicsJointDrive DriveX
		{
			get => GetProperty(ref _driveX);
			set => SetProperty(ref _driveX, value);
		}

		[Ordinal(9)] 
		[RED("driveZ")] 
		public physicsPhysicsJointDrive DriveZ
		{
			get => GetProperty(ref _driveZ);
			set => SetProperty(ref _driveZ, value);
		}

		[Ordinal(10)] 
		[RED("driveTwist")] 
		public physicsPhysicsJointDrive DriveTwist
		{
			get => GetProperty(ref _driveTwist);
			set => SetProperty(ref _driveTwist, value);
		}

		[Ordinal(11)] 
		[RED("driveSwing")] 
		public physicsPhysicsJointDrive DriveSwing
		{
			get => GetProperty(ref _driveSwing);
			set => SetProperty(ref _driveSwing, value);
		}

		[Ordinal(12)] 
		[RED("driveSLERP")] 
		public physicsPhysicsJointDrive DriveSLERP
		{
			get => GetProperty(ref _driveSLERP);
			set => SetProperty(ref _driveSLERP, value);
		}

		[Ordinal(13)] 
		[RED("driveVelocity")] 
		public physicsPhysicsJointDriveVelocity DriveVelocity
		{
			get => GetProperty(ref _driveVelocity);
			set => SetProperty(ref _driveVelocity, value);
		}

		[Ordinal(14)] 
		[RED("drivePosition")] 
		public CMatrix DrivePosition
		{
			get => GetProperty(ref _drivePosition);
			set => SetProperty(ref _drivePosition, value);
		}

		[Ordinal(15)] 
		[RED("projectionEnabled")] 
		public CBool ProjectionEnabled
		{
			get => GetProperty(ref _projectionEnabled);
			set => SetProperty(ref _projectionEnabled, value);
		}

		[Ordinal(16)] 
		[RED("linearTolerance")] 
		public CFloat LinearTolerance
		{
			get => GetProperty(ref _linearTolerance);
			set => SetProperty(ref _linearTolerance, value);
		}

		[Ordinal(17)] 
		[RED("angularTolerance")] 
		public CFloat AngularTolerance
		{
			get => GetProperty(ref _angularTolerance);
			set => SetProperty(ref _angularTolerance, value);
		}

		[Ordinal(18)] 
		[RED("isBreakable")] 
		public CBool IsBreakable
		{
			get => GetProperty(ref _isBreakable);
			set => SetProperty(ref _isBreakable, value);
		}

		[Ordinal(19)] 
		[RED("breakingForce")] 
		public CFloat BreakingForce
		{
			get => GetProperty(ref _breakingForce);
			set => SetProperty(ref _breakingForce, value);
		}

		[Ordinal(20)] 
		[RED("breakingTorque")] 
		public CFloat BreakingTorque
		{
			get => GetProperty(ref _breakingTorque);
			set => SetProperty(ref _breakingTorque, value);
		}
	}
}
