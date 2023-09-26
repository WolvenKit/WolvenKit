
namespace WolvenKit.RED4.Types
{
	public partial class EnteringCombatDecisions : VehicleTransition
	{
		public EnteringCombatDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
