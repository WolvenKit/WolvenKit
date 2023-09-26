
namespace WolvenKit.RED4.Types
{
	public partial class WaitingForSceneDecisions : VehicleTransition
	{
		public WaitingForSceneDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
