
namespace WolvenKit.RED4.Types
{
	public partial class gamePuppetMountableComponent : gamemountingMountableComponent
	{
		public gamePuppetMountableComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
