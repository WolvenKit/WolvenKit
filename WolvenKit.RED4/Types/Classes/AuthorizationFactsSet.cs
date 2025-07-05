
namespace WolvenKit.RED4.Types
{
	public partial class AuthorizationFactsSet : BunkerSystemsFactsSet
	{
		public AuthorizationFactsSet()
		{
			ALPHA_FACT = "q305_server_01_authorization_needed";
			BRAVO_FACT = "q305_server_02_authorization_needed";
			SIERRA_FACT = "q305_backup_server_01_authorization_needed";
			VICTOR_FACT = "q305_backup_server_02_authorization_needed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
