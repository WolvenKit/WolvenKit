using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotStopCondition_VehicleNotVisible : vehicleCinematicCameraShotStopCondition
	{
		[Ordinal(0)] 
		[RED("timeOutOfSightBeforeStop")] 
		public CFloat TimeOutOfSightBeforeStop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("counter")] 
		public CFloat Counter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotStopCondition_VehicleNotVisible()
		{
			TimeOutOfSightBeforeStop = 0.750000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
