
namespace WolvenKit.RED4.Types
{
	public partial class DriverCombatDecisions : VehicleTransition
	{
		public DriverCombatDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
