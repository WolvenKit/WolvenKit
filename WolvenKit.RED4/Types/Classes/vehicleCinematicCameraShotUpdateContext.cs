using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotUpdateContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cameraComponent")] 
		public CHandle<vehicleCinematicCameraComponent> CameraComponent
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraComponent>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<gamedataVehicleType>>();
			set => SetPropertyValue<CEnum<gamedataVehicleType>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleTransform")] 
		public WorldTransform VehicleTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleBoundingBox")] 
		public Box VehicleBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(4)] 
		[RED("vehicleSpeed")] 
		public CFloat VehicleSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("engineTime")] 
		public CFloat EngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotUpdateContext()
		{
			VehicleTransform = new WorldTransform();
			VehicleBoundingBox = new Box();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
