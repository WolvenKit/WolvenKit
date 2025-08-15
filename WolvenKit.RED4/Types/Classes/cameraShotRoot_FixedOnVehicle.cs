using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotRoot_FixedOnVehicle : vehicleCinematicCameraShotRoot
	{
		[Ordinal(0)] 
		[RED("deccelerationAmount")] 
		public CFloat DeccelerationAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("detachToVehicleTime")] 
		public CFloat DetachToVehicleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("detachedFromVehicle")] 
		public CBool DetachedFromVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("detachedDirection")] 
		public Vector4 DetachedDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("detachedSpeed")] 
		public CFloat DetachedSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("detachedTransform")] 
		public WorldTransform DetachedTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		public cameraShotRoot_FixedOnVehicle()
		{
			DetachToVehicleTime = -1.000000F;
			DetachedDirection = new Vector4();
			DetachedTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
