using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleTimedCinematicCameraShotEffect : vehicleCinematicCameraShotEffect
	{
		[Ordinal(0)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hasStarted")] 
		public CBool HasStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleTimedCinematicCameraShotEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
