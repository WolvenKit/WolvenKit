
namespace WolvenKit.RED4.Types
{
	public partial class OnlyVehicleEvents : QuickSlotsReadyEvents
	{
		public OnlyVehicleEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
