
namespace WolvenKit.RED4.Types
{
	public partial class ExitingDecisions : VehicleTransition
	{
		public ExitingDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
