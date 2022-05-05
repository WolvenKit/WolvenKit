
namespace WolvenKit.RED4.Types
{
	public partial class SceneEvents : VehicleEventsTransition
	{
		public SceneEvents()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
