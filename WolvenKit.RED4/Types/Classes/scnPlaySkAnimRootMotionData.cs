using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlaySkAnimRootMotionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("placementMode")] 
		public CEnum<scnRootMotionAnimPlacementMode> PlacementMode
		{
			get => GetPropertyValue<CEnum<scnRootMotionAnimPlacementMode>>();
			set => SetPropertyValue<CEnum<scnRootMotionAnimPlacementMode>>(value);
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		[Ordinal(3)] 
		[RED("originOffset")] 
		public Transform OriginOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(4)] 
		[RED("customBlendInTime")] 
		public CFloat CustomBlendInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("customBlendInCurve")] 
		public CEnum<scnEasingType> CustomBlendInCurve
		{
			get => GetPropertyValue<CEnum<scnEasingType>>();
			set => SetPropertyValue<CEnum<scnEasingType>>(value);
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("meshDissolvingEnabled")] 
		public CBool MeshDissolvingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleChangePhysicsState")] 
		public CBool VehicleChangePhysicsState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleEnabledPhysicsOnEnd")] 
		public CBool VehicleEnabledPhysicsOnEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get => GetPropertyValue<CArray<scnAnimationMotionSample>>();
			set => SetPropertyValue<CArray<scnAnimationMotionSample>>(value);
		}

		public scnPlaySkAnimRootMotionData()
		{
			OriginMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };
			OriginOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			CustomBlendInTime = -1.000000F;
			CustomBlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut;
			RemovePitchRollRotation = true;
			MeshDissolvingEnabled = true;
			VehicleChangePhysicsState = true;
			VehicleEnabledPhysicsOnEnd = true;
			TrajectoryLOD = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
