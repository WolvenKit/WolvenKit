
namespace WolvenKit.RED4.Types
{
	public partial class gameTargetShootComponent : entIComponent
	{
		public gameTargetShootComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
