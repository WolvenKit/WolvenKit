
namespace WolvenKit.RED4.Types
{
	public partial class entTargetPointComponent : entIPlacedComponent
	{
		public entTargetPointComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
