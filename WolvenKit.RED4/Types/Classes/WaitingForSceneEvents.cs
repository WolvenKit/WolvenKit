
namespace WolvenKit.RED4.Types
{
	public partial class WaitingForSceneEvents : VehicleTransition
	{
		public WaitingForSceneEvents()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
