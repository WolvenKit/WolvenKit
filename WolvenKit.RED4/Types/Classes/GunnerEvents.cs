
namespace WolvenKit.RED4.Types
{
	public partial class GunnerEvents : VehicleEventsTransition
	{
		public GunnerEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
