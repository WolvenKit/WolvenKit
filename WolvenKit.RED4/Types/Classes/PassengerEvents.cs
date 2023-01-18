
namespace WolvenKit.RED4.Types
{
	public partial class PassengerEvents : VehicleEventsTransition
	{
		public PassengerEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
