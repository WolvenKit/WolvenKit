
namespace WolvenKit.RED4.Types
{
	public partial class EnteringEvents : VehicleEventsTransition
	{
		public EnteringEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
