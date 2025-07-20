using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_FOV : vehicleTimedCinematicCameraShotEffect
	{
		[Ordinal(3)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("startFOV")] 
		public CFloat StartFOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("endFOV")] 
		public CFloat EndFOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public cameraShotEffect_FOV()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
