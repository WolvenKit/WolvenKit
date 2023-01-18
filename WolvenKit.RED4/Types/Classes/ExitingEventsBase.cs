
namespace WolvenKit.RED4.Types
{
	public partial class ExitingEventsBase : VehicleEventsTransition
	{
		public ExitingEventsBase()
		{
			CameraToggleHoldToResetTimeSeconds = 0.350000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
