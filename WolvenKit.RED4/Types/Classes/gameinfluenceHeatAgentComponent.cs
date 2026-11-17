
namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceHeatAgentComponent : entIPlacedComponent
	{
		public gameinfluenceHeatAgentComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
