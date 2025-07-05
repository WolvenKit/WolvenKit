
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingCombatDecisions : VehicleTransition
	{
		public SceneExitingCombatDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
