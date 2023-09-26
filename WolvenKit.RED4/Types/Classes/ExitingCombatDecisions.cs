
namespace WolvenKit.RED4.Types
{
	public partial class ExitingCombatDecisions : VehicleTransition
	{
		public ExitingCombatDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
