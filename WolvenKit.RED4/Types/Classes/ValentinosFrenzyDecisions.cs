
namespace WolvenKit.RED4.Types
{
	public partial class ValentinosFrenzyDecisions : ExitToNextShootDecisionsBase
	{
		public ValentinosFrenzyDecisions()
		{
			EnteredStateVarName = "LastShotInValentinosFrenzy";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
