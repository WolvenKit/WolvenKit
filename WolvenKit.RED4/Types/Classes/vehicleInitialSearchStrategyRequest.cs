
namespace WolvenKit.RED4.Types
{
	public partial class vehicleInitialSearchStrategyRequest : vehicleBaseStrategyRequest
	{
		public vehicleInitialSearchStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.InitialSearch;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
