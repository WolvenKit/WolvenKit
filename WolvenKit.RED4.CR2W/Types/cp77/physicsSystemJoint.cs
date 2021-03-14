using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemJoint : physicsISystemObject
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
			get
			{
				if (_localToWorld == null)
				{
					_localToWorld = (CMatrix) CR2WTypeManager.Create("Matrix", "localToWorld", cr2w, this);
				}
				return _localToWorld;
			}
			set
			{
				if (_localToWorld == value)
				{
					return;
				}
				_localToWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pinA")] 
		public CHandle<physicsPhysicalJointPin> PinA
		{
			get
			{
				if (_pinA == null)
				{
					_pinA = (CHandle<physicsPhysicalJointPin>) CR2WTypeManager.Create("handle:physicsPhysicalJointPin", "pinA", cr2w, this);
				}
				return _pinA;
			}
			set
			{
				if (_pinA == value)
				{
					return;
				}
				_pinA = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pinB")] 
		public CHandle<physicsPhysicalJointPin> PinB
		{
			get
			{
				if (_pinB == null)
				{
					_pinB = (CHandle<physicsPhysicalJointPin>) CR2WTypeManager.Create("handle:physicsPhysicalJointPin", "pinB", cr2w, this);
				}
				return _pinB;
			}
			set
			{
				if (_pinB == value)
				{
					return;
				}
				_pinB = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("linearLimit")] 
		public physicsPhysicsJointLinearLimit LinearLimit
		{
			get
			{
				if (_linearLimit == null)
				{
					_linearLimit = (physicsPhysicsJointLinearLimit) CR2WTypeManager.Create("physicsPhysicsJointLinearLimit", "linearLimit", cr2w, this);
				}
				return _linearLimit;
			}
			set
			{
				if (_linearLimit == value)
				{
					return;
				}
				_linearLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("twistLimit")] 
		public physicsPhysicsJointAngularLimitPair TwistLimit
		{
			get
			{
				if (_twistLimit == null)
				{
					_twistLimit = (physicsPhysicsJointAngularLimitPair) CR2WTypeManager.Create("physicsPhysicsJointAngularLimitPair", "twistLimit", cr2w, this);
				}
				return _twistLimit;
			}
			set
			{
				if (_twistLimit == value)
				{
					return;
				}
				_twistLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("swingLimit")] 
		public physicsPhysicsJointLimitConePair SwingLimit
		{
			get
			{
				if (_swingLimit == null)
				{
					_swingLimit = (physicsPhysicsJointLimitConePair) CR2WTypeManager.Create("physicsPhysicsJointLimitConePair", "swingLimit", cr2w, this);
				}
				return _swingLimit;
			}
			set
			{
				if (_swingLimit == value)
				{
					return;
				}
				_swingLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("driveY")] 
		public physicsPhysicsJointDrive DriveY
		{
			get
			{
				if (_driveY == null)
				{
					_driveY = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveY", cr2w, this);
				}
				return _driveY;
			}
			set
			{
				if (_driveY == value)
				{
					return;
				}
				_driveY = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("driveX")] 
		public physicsPhysicsJointDrive DriveX
		{
			get
			{
				if (_driveX == null)
				{
					_driveX = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveX", cr2w, this);
				}
				return _driveX;
			}
			set
			{
				if (_driveX == value)
				{
					return;
				}
				_driveX = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("driveZ")] 
		public physicsPhysicsJointDrive DriveZ
		{
			get
			{
				if (_driveZ == null)
				{
					_driveZ = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveZ", cr2w, this);
				}
				return _driveZ;
			}
			set
			{
				if (_driveZ == value)
				{
					return;
				}
				_driveZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("driveTwist")] 
		public physicsPhysicsJointDrive DriveTwist
		{
			get
			{
				if (_driveTwist == null)
				{
					_driveTwist = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveTwist", cr2w, this);
				}
				return _driveTwist;
			}
			set
			{
				if (_driveTwist == value)
				{
					return;
				}
				_driveTwist = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("driveSwing")] 
		public physicsPhysicsJointDrive DriveSwing
		{
			get
			{
				if (_driveSwing == null)
				{
					_driveSwing = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveSwing", cr2w, this);
				}
				return _driveSwing;
			}
			set
			{
				if (_driveSwing == value)
				{
					return;
				}
				_driveSwing = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("driveSLERP")] 
		public physicsPhysicsJointDrive DriveSLERP
		{
			get
			{
				if (_driveSLERP == null)
				{
					_driveSLERP = (physicsPhysicsJointDrive) CR2WTypeManager.Create("physicsPhysicsJointDrive", "driveSLERP", cr2w, this);
				}
				return _driveSLERP;
			}
			set
			{
				if (_driveSLERP == value)
				{
					return;
				}
				_driveSLERP = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("driveVelocity")] 
		public physicsPhysicsJointDriveVelocity DriveVelocity
		{
			get
			{
				if (_driveVelocity == null)
				{
					_driveVelocity = (physicsPhysicsJointDriveVelocity) CR2WTypeManager.Create("physicsPhysicsJointDriveVelocity", "driveVelocity", cr2w, this);
				}
				return _driveVelocity;
			}
			set
			{
				if (_driveVelocity == value)
				{
					return;
				}
				_driveVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("drivePosition")] 
		public CMatrix DrivePosition
		{
			get
			{
				if (_drivePosition == null)
				{
					_drivePosition = (CMatrix) CR2WTypeManager.Create("Matrix", "drivePosition", cr2w, this);
				}
				return _drivePosition;
			}
			set
			{
				if (_drivePosition == value)
				{
					return;
				}
				_drivePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("projectionEnabled")] 
		public CBool ProjectionEnabled
		{
			get
			{
				if (_projectionEnabled == null)
				{
					_projectionEnabled = (CBool) CR2WTypeManager.Create("Bool", "projectionEnabled", cr2w, this);
				}
				return _projectionEnabled;
			}
			set
			{
				if (_projectionEnabled == value)
				{
					return;
				}
				_projectionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("linearTolerance")] 
		public CFloat LinearTolerance
		{
			get
			{
				if (_linearTolerance == null)
				{
					_linearTolerance = (CFloat) CR2WTypeManager.Create("Float", "linearTolerance", cr2w, this);
				}
				return _linearTolerance;
			}
			set
			{
				if (_linearTolerance == value)
				{
					return;
				}
				_linearTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("angularTolerance")] 
		public CFloat AngularTolerance
		{
			get
			{
				if (_angularTolerance == null)
				{
					_angularTolerance = (CFloat) CR2WTypeManager.Create("Float", "angularTolerance", cr2w, this);
				}
				return _angularTolerance;
			}
			set
			{
				if (_angularTolerance == value)
				{
					return;
				}
				_angularTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isBreakable")] 
		public CBool IsBreakable
		{
			get
			{
				if (_isBreakable == null)
				{
					_isBreakable = (CBool) CR2WTypeManager.Create("Bool", "isBreakable", cr2w, this);
				}
				return _isBreakable;
			}
			set
			{
				if (_isBreakable == value)
				{
					return;
				}
				_isBreakable = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("breakingForce")] 
		public CFloat BreakingForce
		{
			get
			{
				if (_breakingForce == null)
				{
					_breakingForce = (CFloat) CR2WTypeManager.Create("Float", "breakingForce", cr2w, this);
				}
				return _breakingForce;
			}
			set
			{
				if (_breakingForce == value)
				{
					return;
				}
				_breakingForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("breakingTorque")] 
		public CFloat BreakingTorque
		{
			get
			{
				if (_breakingTorque == null)
				{
					_breakingTorque = (CFloat) CR2WTypeManager.Create("Float", "breakingTorque", cr2w, this);
				}
				return _breakingTorque;
			}
			set
			{
				if (_breakingTorque == value)
				{
					return;
				}
				_breakingTorque = value;
				PropertySet(this);
			}
		}

		public physicsSystemJoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
