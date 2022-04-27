
namespace WolvenKit.RED4.Types
{
	public partial class IdleEvents : VehicleEventsTransition
	{
		public IdleEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
