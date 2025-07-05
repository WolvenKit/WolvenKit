
namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveAwayFromPlayerStrategyRequest : vehicleBaseStrategyRequest
	{
		public vehicleDriveAwayFromPlayerStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.DriveAwayFromPlayer;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
