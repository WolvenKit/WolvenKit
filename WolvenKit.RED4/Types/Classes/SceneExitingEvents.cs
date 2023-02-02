
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingEvents : VehicleEventsTransition
	{
		public SceneExitingEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
