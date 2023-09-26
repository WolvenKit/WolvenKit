
namespace WolvenKit.RED4.Types
{
	public partial class IdleDecisions : VehicleTransition
	{
		public IdleDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
