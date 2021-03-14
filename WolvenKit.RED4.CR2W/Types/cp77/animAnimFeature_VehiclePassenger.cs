using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassenger : animAnimFeature
	{
		private Vector4 _overallForceMS;
		private CFloat _turnSpeed;
		private CFloat _bankSpeed;
		private CFloat _longitudinalForce;
		private CFloat _transversalForce;
		private CFloat _collisionForceLR;
		private CFloat _collisionForceFB;
		private CFloat _speed;
		private CFloat _inputLR;
		private CFloat _inputFB;
		private CFloat _inputGas;
		private CFloat _inputBreak;
		private CFloat _inputHandBreak;
		private CFloat _vehicleRoll;
		private CFloat _vehiclePitch;
		private CBool _isCar;
		private CBool _inAir;
		private CBool _clutchInUse;
		private CBool _headCollision;

		[Ordinal(0)] 
		[RED("overallForceMS")] 
		public Vector4 OverallForceMS
		{
			get
			{
				if (_overallForceMS == null)
				{
					_overallForceMS = (Vector4) CR2WTypeManager.Create("Vector4", "overallForceMS", cr2w, this);
				}
				return _overallForceMS;
			}
			set
			{
				if (_overallForceMS == value)
				{
					return;
				}
				_overallForceMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("turnSpeed")] 
		public CFloat TurnSpeed
		{
			get
			{
				if (_turnSpeed == null)
				{
					_turnSpeed = (CFloat) CR2WTypeManager.Create("Float", "turnSpeed", cr2w, this);
				}
				return _turnSpeed;
			}
			set
			{
				if (_turnSpeed == value)
				{
					return;
				}
				_turnSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bankSpeed")] 
		public CFloat BankSpeed
		{
			get
			{
				if (_bankSpeed == null)
				{
					_bankSpeed = (CFloat) CR2WTypeManager.Create("Float", "bankSpeed", cr2w, this);
				}
				return _bankSpeed;
			}
			set
			{
				if (_bankSpeed == value)
				{
					return;
				}
				_bankSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("longitudinalForce")] 
		public CFloat LongitudinalForce
		{
			get
			{
				if (_longitudinalForce == null)
				{
					_longitudinalForce = (CFloat) CR2WTypeManager.Create("Float", "longitudinalForce", cr2w, this);
				}
				return _longitudinalForce;
			}
			set
			{
				if (_longitudinalForce == value)
				{
					return;
				}
				_longitudinalForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("transversalForce")] 
		public CFloat TransversalForce
		{
			get
			{
				if (_transversalForce == null)
				{
					_transversalForce = (CFloat) CR2WTypeManager.Create("Float", "transversalForce", cr2w, this);
				}
				return _transversalForce;
			}
			set
			{
				if (_transversalForce == value)
				{
					return;
				}
				_transversalForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("collisionForceLR")] 
		public CFloat CollisionForceLR
		{
			get
			{
				if (_collisionForceLR == null)
				{
					_collisionForceLR = (CFloat) CR2WTypeManager.Create("Float", "collisionForceLR", cr2w, this);
				}
				return _collisionForceLR;
			}
			set
			{
				if (_collisionForceLR == value)
				{
					return;
				}
				_collisionForceLR = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("collisionForceFB")] 
		public CFloat CollisionForceFB
		{
			get
			{
				if (_collisionForceFB == null)
				{
					_collisionForceFB = (CFloat) CR2WTypeManager.Create("Float", "collisionForceFB", cr2w, this);
				}
				return _collisionForceFB;
			}
			set
			{
				if (_collisionForceFB == value)
				{
					return;
				}
				_collisionForceFB = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("inputLR")] 
		public CFloat InputLR
		{
			get
			{
				if (_inputLR == null)
				{
					_inputLR = (CFloat) CR2WTypeManager.Create("Float", "inputLR", cr2w, this);
				}
				return _inputLR;
			}
			set
			{
				if (_inputLR == value)
				{
					return;
				}
				_inputLR = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inputFB")] 
		public CFloat InputFB
		{
			get
			{
				if (_inputFB == null)
				{
					_inputFB = (CFloat) CR2WTypeManager.Create("Float", "inputFB", cr2w, this);
				}
				return _inputFB;
			}
			set
			{
				if (_inputFB == value)
				{
					return;
				}
				_inputFB = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("inputGas")] 
		public CFloat InputGas
		{
			get
			{
				if (_inputGas == null)
				{
					_inputGas = (CFloat) CR2WTypeManager.Create("Float", "inputGas", cr2w, this);
				}
				return _inputGas;
			}
			set
			{
				if (_inputGas == value)
				{
					return;
				}
				_inputGas = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inputBreak")] 
		public CFloat InputBreak
		{
			get
			{
				if (_inputBreak == null)
				{
					_inputBreak = (CFloat) CR2WTypeManager.Create("Float", "inputBreak", cr2w, this);
				}
				return _inputBreak;
			}
			set
			{
				if (_inputBreak == value)
				{
					return;
				}
				_inputBreak = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inputHandBreak")] 
		public CFloat InputHandBreak
		{
			get
			{
				if (_inputHandBreak == null)
				{
					_inputHandBreak = (CFloat) CR2WTypeManager.Create("Float", "inputHandBreak", cr2w, this);
				}
				return _inputHandBreak;
			}
			set
			{
				if (_inputHandBreak == value)
				{
					return;
				}
				_inputHandBreak = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("vehicleRoll")] 
		public CFloat VehicleRoll
		{
			get
			{
				if (_vehicleRoll == null)
				{
					_vehicleRoll = (CFloat) CR2WTypeManager.Create("Float", "vehicleRoll", cr2w, this);
				}
				return _vehicleRoll;
			}
			set
			{
				if (_vehicleRoll == value)
				{
					return;
				}
				_vehicleRoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("vehiclePitch")] 
		public CFloat VehiclePitch
		{
			get
			{
				if (_vehiclePitch == null)
				{
					_vehiclePitch = (CFloat) CR2WTypeManager.Create("Float", "vehiclePitch", cr2w, this);
				}
				return _vehiclePitch;
			}
			set
			{
				if (_vehiclePitch == value)
				{
					return;
				}
				_vehiclePitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isCar")] 
		public CBool IsCar
		{
			get
			{
				if (_isCar == null)
				{
					_isCar = (CBool) CR2WTypeManager.Create("Bool", "isCar", cr2w, this);
				}
				return _isCar;
			}
			set
			{
				if (_isCar == value)
				{
					return;
				}
				_isCar = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inAir")] 
		public CBool InAir
		{
			get
			{
				if (_inAir == null)
				{
					_inAir = (CBool) CR2WTypeManager.Create("Bool", "inAir", cr2w, this);
				}
				return _inAir;
			}
			set
			{
				if (_inAir == value)
				{
					return;
				}
				_inAir = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("clutchInUse")] 
		public CBool ClutchInUse
		{
			get
			{
				if (_clutchInUse == null)
				{
					_clutchInUse = (CBool) CR2WTypeManager.Create("Bool", "clutchInUse", cr2w, this);
				}
				return _clutchInUse;
			}
			set
			{
				if (_clutchInUse == value)
				{
					return;
				}
				_clutchInUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("headCollision")] 
		public CBool HeadCollision
		{
			get
			{
				if (_headCollision == null)
				{
					_headCollision = (CBool) CR2WTypeManager.Create("Bool", "headCollision", cr2w, this);
				}
				return _headCollision;
			}
			set
			{
				if (_headCollision == value)
				{
					return;
				}
				_headCollision = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_VehiclePassenger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
