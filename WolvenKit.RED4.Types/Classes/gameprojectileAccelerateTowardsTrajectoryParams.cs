using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileAccelerateTowardsTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _accelerationSpeed;
		private CFloat _maxSpeed;
		private CFloat _decelerateTowardsTargetPositionDistance;
		private CFloat _maxRotationSpeed;
		private CFloat _minRotationSpeed;
		private CFloat _diffForMaxRotation;
		private CWeakHandle<gameObject> _target;
		private CWeakHandle<entIPlacedComponent> _targetComponent;
		private Vector4 _targetPosition;
		private Vector4 _targetOffset;
		private CFloat _accuracy;

		[Ordinal(0)] 
		[RED("accelerationSpeed")] 
		public CFloat AccelerationSpeed
		{
			get => GetProperty(ref _accelerationSpeed);
			set => SetProperty(ref _accelerationSpeed, value);
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(2)] 
		[RED("decelerateTowardsTargetPositionDistance")] 
		public CFloat DecelerateTowardsTargetPositionDistance
		{
			get => GetProperty(ref _decelerateTowardsTargetPositionDistance);
			set => SetProperty(ref _decelerateTowardsTargetPositionDistance, value);
		}

		[Ordinal(3)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetProperty(ref _maxRotationSpeed);
			set => SetProperty(ref _maxRotationSpeed, value);
		}

		[Ordinal(4)] 
		[RED("minRotationSpeed")] 
		public CFloat MinRotationSpeed
		{
			get => GetProperty(ref _minRotationSpeed);
			set => SetProperty(ref _minRotationSpeed, value);
		}

		[Ordinal(5)] 
		[RED("diffForMaxRotation")] 
		public CFloat DiffForMaxRotation
		{
			get => GetProperty(ref _diffForMaxRotation);
			set => SetProperty(ref _diffForMaxRotation, value);
		}

		[Ordinal(6)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(7)] 
		[RED("targetComponent")] 
		public CWeakHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(8)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(9)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get => GetProperty(ref _targetOffset);
			set => SetProperty(ref _targetOffset, value);
		}

		[Ordinal(10)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetProperty(ref _accuracy);
			set => SetProperty(ref _accuracy, value);
		}
	}
}
