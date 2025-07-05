
namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveTowardsPlayerStrategyRequest : vehicleBaseStrategyRequest
	{
		public vehicleDriveTowardsPlayerStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.DriveTowardsPlayer;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
