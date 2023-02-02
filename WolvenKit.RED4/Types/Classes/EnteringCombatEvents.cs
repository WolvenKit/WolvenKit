
namespace WolvenKit.RED4.Types
{
	public partial class EnteringCombatEvents : VehicleEventsTransition
	{
		public EnteringCombatEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
