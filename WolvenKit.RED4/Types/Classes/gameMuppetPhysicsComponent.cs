
namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetPhysicsComponent : gameMuppetComponent
	{
		public gameMuppetPhysicsComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
