using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotEffect_EulerAnglesDamper : vehicleTimedCinematicCameraShotEffect
	{
		[Ordinal(3)] 
		[RED("dampingCurve")] 
		public CName DampingCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotEffect_EulerAnglesDamper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
