
namespace WolvenKit.RED4.Types
{
	public partial class EnteringDecisions : VehicleTransition
	{
		public EnteringDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
