
namespace WolvenKit.RED4.Types
{
	public partial class vehicleGetToPlayerFromAnywhereStrategyRequest : vehicleBaseStrategyRequest
	{
		public vehicleGetToPlayerFromAnywhereStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.GetToPlayerFromAnywhere;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
