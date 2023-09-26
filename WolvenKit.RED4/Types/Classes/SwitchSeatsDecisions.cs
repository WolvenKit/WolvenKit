
namespace WolvenKit.RED4.Types
{
	public partial class SwitchSeatsDecisions : VehicleTransition
	{
		public SwitchSeatsDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
