
namespace WolvenKit.RED4.Types
{
	public partial class PassengerDecisions : VehicleTransition
	{
		public PassengerDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
