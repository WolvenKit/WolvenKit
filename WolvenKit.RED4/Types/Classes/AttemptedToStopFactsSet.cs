
namespace WolvenKit.RED4.Types
{
	public partial class AttemptedToStopFactsSet : BunkerSystemsFactsSet
	{
		public AttemptedToStopFactsSet()
		{
			BRAVO_FACT = "q305_attempted_to_stop_server_02";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
