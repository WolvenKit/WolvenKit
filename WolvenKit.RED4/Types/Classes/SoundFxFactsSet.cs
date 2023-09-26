
namespace WolvenKit.RED4.Types
{
	public partial class SoundFxFactsSet : BunkerSystemsFactsSet
	{
		public SoundFxFactsSet()
		{
			ALPHA_FACT = "q305_server_01_opening_sfx";
			BRAVO_FACT = "q305_server_02_opening_sfx";
			SIERRA_FACT = "q305_server_backup_01_opening_sfx";
			VICTOR_FACT = "q305_server_backup_02_opening_sfx";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
