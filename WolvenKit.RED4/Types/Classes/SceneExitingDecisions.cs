
namespace WolvenKit.RED4.Types
{
	public partial class SceneExitingDecisions : VehicleTransition
	{
		public SceneExitingDecisions()
		{
			ExitSlot = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
