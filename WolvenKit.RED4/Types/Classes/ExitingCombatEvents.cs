
namespace WolvenKit.RED4.Types
{
	public partial class ExitingCombatEvents : VehicleEventsTransition
	{
		public ExitingCombatEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
