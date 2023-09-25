
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingEvents : VehicleEventsTransition
	{
		public SceneExitingEvents()
		{
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
