
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingCombatEvents : VehicleEventsTransition
	{
		public SceneExitingCombatEvents()
		{
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
