
namespace WolvenKit.RED4.Types
{
	public partial class gameNavmeshDetector : entIPlacedComponent
	{
		public gameNavmeshDetector()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
