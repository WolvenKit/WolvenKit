
namespace WolvenKit.RED4.Types
{
	public partial class BothWeaponsDecisions : ExitToNextShootDecisionsBase
	{
		public BothWeaponsDecisions()
		{
			EnteredStateVarName = "EnteredBothWeaponsWithState";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
