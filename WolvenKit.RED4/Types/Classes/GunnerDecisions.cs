
namespace WolvenKit.RED4.Types
{
	public partial class GunnerDecisions : VehicleTransition
	{
		public GunnerDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
