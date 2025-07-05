
namespace WolvenKit.RED4.Types
{
	public partial class DriveDecisions : VehicleTransition
	{
		public DriveDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
