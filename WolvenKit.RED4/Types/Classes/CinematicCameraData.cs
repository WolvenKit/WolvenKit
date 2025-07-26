using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CinematicCameraData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cameraComponent")] 
		public CHandle<vehicleCinematicCameraComponent> CameraComponent
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraComponent>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("currentShot")] 
		public CHandle<vehicleCinematicCameraShot> CurrentShot
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraShot>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraShot>>(value);
		}

		[Ordinal(2)] 
		[RED("shotInitialTransform")] 
		public WorldTransform ShotInitialTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleInitialTransform")] 
		public WorldTransform VehicleInitialTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(4)] 
		[RED("referenceLocalBoundingBox")] 
		public Box ReferenceLocalBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(5)] 
		[RED("currentLocalBoundingBox")] 
		public Box CurrentLocalBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(6)] 
		[RED("shotStartTime")] 
		public CFloat ShotStartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("shotRootTransform")] 
		public WorldTransform ShotRootTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(8)] 
		[RED("shotSpaceTransform")] 
		public WorldTransform ShotSpaceTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleTransform")] 
		public WorldTransform VehicleTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleSpeed")] 
		public CFloat VehicleSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CinematicCameraData()
		{
			ShotInitialTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			VehicleInitialTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			ReferenceLocalBoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };
			CurrentLocalBoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };
			ShotRootTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			ShotSpaceTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			VehicleTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
