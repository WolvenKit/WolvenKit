
namespace WolvenKit.RED4.Types
{
	public partial class GroundDeathDecisions : DeathDecisionsWithResurrection
	{
		public GroundDeathDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
