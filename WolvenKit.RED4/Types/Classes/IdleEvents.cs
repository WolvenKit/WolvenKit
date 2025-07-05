
namespace WolvenKit.RED4.Types
{
	public partial class IdleEvents : VehicleEventsTransition
	{
		public IdleEvents()
		{
			ExitSlot = "default";
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
