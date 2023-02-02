
namespace WolvenKit.RED4.Types
{
	public partial class DriveEvents : VehicleEventsTransition
	{
		public DriveEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
