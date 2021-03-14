using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileAccelerateTowardsTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _accelerationSpeed;
		private CFloat _maxSpeed;
		private CFloat _decelerateTowardsTargetPositionDistance;
		private CFloat _maxRotationSpeed;
		private CFloat _minRotationSpeed;
		private CFloat _diffForMaxRotation;
		private wCHandle<gameObject> _target;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private Vector4 _targetPosition;
		private Vector4 _targetOffset;
		private CFloat _accuracy;

		[Ordinal(0)] 
		[RED("accelerationSpeed")] 
		public CFloat AccelerationSpeed
		{
			get
			{
				if (_accelerationSpeed == null)
				{
					_accelerationSpeed = (CFloat) CR2WTypeManager.Create("Float", "accelerationSpeed", cr2w, this);
				}
				return _accelerationSpeed;
			}
			set
			{
				if (_accelerationSpeed == value)
				{
					return;
				}
				_accelerationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get
			{
				if (_maxSpeed == null)
				{
					_maxSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxSpeed", cr2w, this);
				}
				return _maxSpeed;
			}
			set
			{
				if (_maxSpeed == value)
				{
					return;
				}
				_maxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("decelerateTowardsTargetPositionDistance")] 
		public CFloat DecelerateTowardsTargetPositionDistance
		{
			get
			{
				if (_decelerateTowardsTargetPositionDistance == null)
				{
					_decelerateTowardsTargetPositionDistance = (CFloat) CR2WTypeManager.Create("Float", "decelerateTowardsTargetPositionDistance", cr2w, this);
				}
				return _decelerateTowardsTargetPositionDistance;
			}
			set
			{
				if (_decelerateTowardsTargetPositionDistance == value)
				{
					return;
				}
				_decelerateTowardsTargetPositionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get
			{
				if (_maxRotationSpeed == null)
				{
					_maxRotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxRotationSpeed", cr2w, this);
				}
				return _maxRotationSpeed;
			}
			set
			{
				if (_maxRotationSpeed == value)
				{
					return;
				}
				_maxRotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minRotationSpeed")] 
		public CFloat MinRotationSpeed
		{
			get
			{
				if (_minRotationSpeed == null)
				{
					_minRotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "minRotationSpeed", cr2w, this);
				}
				return _minRotationSpeed;
			}
			set
			{
				if (_minRotationSpeed == value)
				{
					return;
				}
				_minRotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("diffForMaxRotation")] 
		public CFloat DiffForMaxRotation
		{
			get
			{
				if (_diffForMaxRotation == null)
				{
					_diffForMaxRotation = (CFloat) CR2WTypeManager.Create("Float", "diffForMaxRotation", cr2w, this);
				}
				return _diffForMaxRotation;
			}
			set
			{
				if (_diffForMaxRotation == value)
				{
					return;
				}
				_diffForMaxRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get
			{
				if (_targetOffset == null)
				{
					_targetOffset = (Vector4) CR2WTypeManager.Create("Vector4", "targetOffset", cr2w, this);
				}
				return _targetOffset;
			}
			set
			{
				if (_targetOffset == value)
				{
					return;
				}
				_targetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get
			{
				if (_accuracy == null)
				{
					_accuracy = (CFloat) CR2WTypeManager.Create("Float", "accuracy", cr2w, this);
				}
				return _accuracy;
			}
			set
			{
				if (_accuracy == value)
				{
					return;
				}
				_accuracy = value;
				PropertySet(this);
			}
		}

		public gameprojectileAccelerateTowardsTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
