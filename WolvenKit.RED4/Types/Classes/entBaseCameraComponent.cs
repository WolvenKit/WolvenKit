using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entBaseCameraComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("fov")] 
		public CFloat Fov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("nearPlaneOverride")] 
		public CFloat NearPlaneOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("farPlaneOverride")] 
		public CFloat FarPlaneOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entBaseCameraComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Fov = 60.000000F;
			Zoom = 1.000000F;
			MotionBlurScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
