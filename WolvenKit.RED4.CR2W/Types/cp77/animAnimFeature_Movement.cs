using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Movement : animAnimFeature
	{
		private Vector4 _movementDirection;
		private CFloat _speed;
		private CFloat _desiredSpeed;
		private CFloat _stabilizedSpeed;
		private CFloat _acceleration;
		private CFloat _timeToChangeLocomotion;
		private CFloat _strafeYaw;
		private CFloat _yawSpeed;
		private CInt32 _locomotionState;

		[Ordinal(0)] 
		[RED("movementDirection")] 
		public Vector4 MovementDirection
		{
			get
			{
				if (_movementDirection == null)
				{
					_movementDirection = (Vector4) CR2WTypeManager.Create("Vector4", "movementDirection", cr2w, this);
				}
				return _movementDirection;
			}
			set
			{
				if (_movementDirection == value)
				{
					return;
				}
				_movementDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get
			{
				if (_desiredSpeed == null)
				{
					_desiredSpeed = (CFloat) CR2WTypeManager.Create("Float", "desiredSpeed", cr2w, this);
				}
				return _desiredSpeed;
			}
			set
			{
				if (_desiredSpeed == value)
				{
					return;
				}
				_desiredSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stabilizedSpeed")] 
		public CFloat StabilizedSpeed
		{
			get
			{
				if (_stabilizedSpeed == null)
				{
					_stabilizedSpeed = (CFloat) CR2WTypeManager.Create("Float", "stabilizedSpeed", cr2w, this);
				}
				return _stabilizedSpeed;
			}
			set
			{
				if (_stabilizedSpeed == value)
				{
					return;
				}
				_stabilizedSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get
			{
				if (_acceleration == null)
				{
					_acceleration = (CFloat) CR2WTypeManager.Create("Float", "acceleration", cr2w, this);
				}
				return _acceleration;
			}
			set
			{
				if (_acceleration == value)
				{
					return;
				}
				_acceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeToChangeLocomotion")] 
		public CFloat TimeToChangeLocomotion
		{
			get
			{
				if (_timeToChangeLocomotion == null)
				{
					_timeToChangeLocomotion = (CFloat) CR2WTypeManager.Create("Float", "timeToChangeLocomotion", cr2w, this);
				}
				return _timeToChangeLocomotion;
			}
			set
			{
				if (_timeToChangeLocomotion == value)
				{
					return;
				}
				_timeToChangeLocomotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("strafeYaw")] 
		public CFloat StrafeYaw
		{
			get
			{
				if (_strafeYaw == null)
				{
					_strafeYaw = (CFloat) CR2WTypeManager.Create("Float", "strafeYaw", cr2w, this);
				}
				return _strafeYaw;
			}
			set
			{
				if (_strafeYaw == value)
				{
					return;
				}
				_strafeYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get
			{
				if (_yawSpeed == null)
				{
					_yawSpeed = (CFloat) CR2WTypeManager.Create("Float", "yawSpeed", cr2w, this);
				}
				return _yawSpeed;
			}
			set
			{
				if (_yawSpeed == value)
				{
					return;
				}
				_yawSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get
			{
				if (_locomotionState == null)
				{
					_locomotionState = (CInt32) CR2WTypeManager.Create("Int32", "locomotionState", cr2w, this);
				}
				return _locomotionState;
			}
			set
			{
				if (_locomotionState == value)
				{
					return;
				}
				_locomotionState = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Movement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
