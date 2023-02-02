
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingCombatEvents : VehicleEventsTransition
	{
		public SceneExitingCombatEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
