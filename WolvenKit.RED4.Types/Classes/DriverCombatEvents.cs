
namespace WolvenKit.RED4.Types
{
	public partial class DriverCombatEvents : VehicleEventsTransition
	{
		public DriverCombatEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
