using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseBunkerComputerGameController : gameuiBaseBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("factsSet")] 
		public BunkerSystemsFactsSet FactsSet
		{
			get => GetPropertyValue<BunkerSystemsFactsSet>();
			set => SetPropertyValue<BunkerSystemsFactsSet>(value);
		}

		[Ordinal(3)] 
		[RED("gateClosedFact")] 
		public CName GateClosedFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BaseBunkerComputerGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
