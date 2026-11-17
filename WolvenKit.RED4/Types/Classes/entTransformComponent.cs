
namespace WolvenKit.RED4.Types
{
	public partial class entTransformComponent : entIPlacedComponent
	{
		public entTransformComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
