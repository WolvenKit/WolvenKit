
namespace WolvenKit.RED4.Types
{
	public partial class ExitingCombatEvents : VehicleEventsTransition
	{
		public ExitingCombatEvents()
		{
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
