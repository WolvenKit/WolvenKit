
namespace WolvenKit.RED4.Types
{
	public partial class entSoundListenerComponent : entIPlacedComponent
	{
		public entSoundListenerComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
