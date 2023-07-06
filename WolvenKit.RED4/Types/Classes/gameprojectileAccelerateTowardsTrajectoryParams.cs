using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileAccelerateTowardsTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] 
		[RED("accelerationSpeed")] 
		public CFloat AccelerationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("decelerateTowardsTargetPositionDistance")] 
		public CFloat DecelerateTowardsTargetPositionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minRotationSpeed")] 
		public CFloat MinRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("diffForMaxRotation")] 
		public CFloat DiffForMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("targetComponent")] 
		public CWeakHandle<entIPlacedComponent> TargetComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(8)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(10)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileAccelerateTowardsTrajectoryParams()
		{
			AccelerationSpeed = 2.000000F;
			MaxSpeed = 4.000000F;
			DecelerateTowardsTargetPositionDistance = -1.000000F;
			MaxRotationSpeed = 360.000000F;
			MinRotationSpeed = 180.000000F;
			DiffForMaxRotation = 120.000000F;
			TargetPosition = new Vector4();
			TargetOffset = new Vector4();
			Accuracy = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
