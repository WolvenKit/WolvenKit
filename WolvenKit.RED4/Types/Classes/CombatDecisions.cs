
namespace WolvenKit.RED4.Types
{
	public partial class CombatDecisions : VehicleTransition
	{
		public CombatDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
