using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerSystemsFactsSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ALPHA_FACT")] 
		public CName ALPHA_FACT
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("BRAVO_FACT")] 
		public CName BRAVO_FACT
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("SIERRA_FACT")] 
		public CName SIERRA_FACT
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("VICTOR_FACT")] 
		public CName VICTOR_FACT
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BunkerSystemsFactsSet()
		{
			ALPHA_FACT = "q305_server_01_offline";
			BRAVO_FACT = "q305_server_02_offline";
			SIERRA_FACT = "q305_server_backup_01_offline";
			VICTOR_FACT = "q305_server_backup_02_offline";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
