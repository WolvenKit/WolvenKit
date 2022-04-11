
namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMountableComponent : gamemountingMountableComponent
	{
		public gameMovingPlatformMountableComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
