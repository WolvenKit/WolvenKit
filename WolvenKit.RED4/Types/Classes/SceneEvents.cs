
namespace WolvenKit.RED4.Types
{
	public partial class SceneEvents : VehicleEventsTransition
	{
		public SceneEvents()
		{
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
