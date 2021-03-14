using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SensorDevice : animAnimFeature
	{
		private CBool _isCeiling;
		private CBool _isInitialized;
		private CBool _isTurnedOn;
		private CBool _isDestroyed;
		private CBool _wasHit;
		private CInt32 _state;
		private CInt32 _wakeState;
		private CBool _isControlled;
		private CFloat _overrideRootRotation;
		private CFloat _pitchAngle;
		private CFloat _maxRotationAngle;
		private CFloat _rotationSpeed;
		private Vector4 _currentRotation;

		[Ordinal(0)] 
		[RED("isCeiling")] 
		public CBool IsCeiling
		{
			get
			{
				if (_isCeiling == null)
				{
					_isCeiling = (CBool) CR2WTypeManager.Create("Bool", "isCeiling", cr2w, this);
				}
				return _isCeiling;
			}
			set
			{
				if (_isCeiling == value)
				{
					return;
				}
				_isCeiling = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTurnedOn")] 
		public CBool IsTurnedOn
		{
			get
			{
				if (_isTurnedOn == null)
				{
					_isTurnedOn = (CBool) CR2WTypeManager.Create("Bool", "isTurnedOn", cr2w, this);
				}
				return _isTurnedOn;
			}
			set
			{
				if (_isTurnedOn == value)
				{
					return;
				}
				_isTurnedOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get
			{
				if (_isDestroyed == null)
				{
					_isDestroyed = (CBool) CR2WTypeManager.Create("Bool", "isDestroyed", cr2w, this);
				}
				return _isDestroyed;
			}
			set
			{
				if (_isDestroyed == value)
				{
					return;
				}
				_isDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("wasHit")] 
		public CBool WasHit
		{
			get
			{
				if (_wasHit == null)
				{
					_wasHit = (CBool) CR2WTypeManager.Create("Bool", "wasHit", cr2w, this);
				}
				return _wasHit;
			}
			set
			{
				if (_wasHit == value)
				{
					return;
				}
				_wasHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("wakeState")] 
		public CInt32 WakeState
		{
			get
			{
				if (_wakeState == null)
				{
					_wakeState = (CInt32) CR2WTypeManager.Create("Int32", "wakeState", cr2w, this);
				}
				return _wakeState;
			}
			set
			{
				if (_wakeState == value)
				{
					return;
				}
				_wakeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get
			{
				if (_isControlled == null)
				{
					_isControlled = (CBool) CR2WTypeManager.Create("Bool", "isControlled", cr2w, this);
				}
				return _isControlled;
			}
			set
			{
				if (_isControlled == value)
				{
					return;
				}
				_isControlled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("overrideRootRotation")] 
		public CFloat OverrideRootRotation
		{
			get
			{
				if (_overrideRootRotation == null)
				{
					_overrideRootRotation = (CFloat) CR2WTypeManager.Create("Float", "overrideRootRotation", cr2w, this);
				}
				return _overrideRootRotation;
			}
			set
			{
				if (_overrideRootRotation == value)
				{
					return;
				}
				_overrideRootRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get
			{
				if (_pitchAngle == null)
				{
					_pitchAngle = (CFloat) CR2WTypeManager.Create("Float", "pitchAngle", cr2w, this);
				}
				return _pitchAngle;
			}
			set
			{
				if (_pitchAngle == value)
				{
					return;
				}
				_pitchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get
			{
				if (_maxRotationAngle == null)
				{
					_maxRotationAngle = (CFloat) CR2WTypeManager.Create("Float", "maxRotationAngle", cr2w, this);
				}
				return _maxRotationAngle;
			}
			set
			{
				if (_maxRotationAngle == value)
				{
					return;
				}
				_maxRotationAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get
			{
				if (_rotationSpeed == null)
				{
					_rotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "rotationSpeed", cr2w, this);
				}
				return _rotationSpeed;
			}
			set
			{
				if (_rotationSpeed == value)
				{
					return;
				}
				_rotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get
			{
				if (_currentRotation == null)
				{
					_currentRotation = (Vector4) CR2WTypeManager.Create("Vector4", "currentRotation", cr2w, this);
				}
				return _currentRotation;
			}
			set
			{
				if (_currentRotation == value)
				{
					return;
				}
				_currentRotation = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
