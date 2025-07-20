using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_LookAtVehicle : vehicleTimedCinematicCameraShotEffect
	{
		[Ordinal(3)] 
		[RED("aimOffset")] 
		public Vector4 AimOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("ignoreHorizontal")] 
		public CBool IgnoreHorizontal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreVertical")] 
		public CBool IgnoreVertical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cameraShotEffect_LookAtVehicle()
		{
			AimOffset = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
