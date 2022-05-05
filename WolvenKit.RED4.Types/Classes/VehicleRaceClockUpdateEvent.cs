
namespace WolvenKit.RED4.Types
{
	public partial class VehicleRaceClockUpdateEvent : gameTickableEvent
	{
		public VehicleRaceClockUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
