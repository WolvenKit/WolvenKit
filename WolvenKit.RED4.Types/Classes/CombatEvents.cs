
namespace WolvenKit.RED4.Types
{
	public partial class CombatEvents : VehicleEventsTransition
	{
		public CombatEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
