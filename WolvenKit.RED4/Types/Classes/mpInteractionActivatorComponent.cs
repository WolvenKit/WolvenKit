
namespace WolvenKit.RED4.Types
{
	public partial class mpInteractionActivatorComponent : entIPlacedComponent
	{
		public mpInteractionActivatorComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
