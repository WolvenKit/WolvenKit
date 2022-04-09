
namespace WolvenKit.RED4.Types
{
	public partial class ExitEvents : VehicleEventsTransition
	{
		public ExitEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
