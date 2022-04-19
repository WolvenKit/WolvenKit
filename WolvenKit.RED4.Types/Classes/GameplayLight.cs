
namespace WolvenKit.RED4.Types
{
	public partial class GameplayLight : InteractiveDevice
	{
		public GameplayLight()
		{
			ControllerTypeName = "GameplayLightController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
