using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotStopCondition_VehicleDistanceFromCamera : vehicleCinematicCameraShotStopCondition
	{
		[Ordinal(0)] 
		[RED("maxDistanceFromCamera")] 
		public CFloat MaxDistanceFromCamera
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleCinematicCameraShotStopCondition_VehicleDistanceFromCamera()
		{
			MaxDistanceFromCamera = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
