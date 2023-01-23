
namespace WolvenKit.RED4.Types
{
	public partial class gameObjectMountableComponent : gamemountingMountableComponent
	{
		public gameObjectMountableComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
