
namespace WolvenKit.RED4.Types
{
	public partial class gameSourceShootComponent : entIComponent
	{
		public gameSourceShootComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
