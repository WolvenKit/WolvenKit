
namespace WolvenKit.RED4.Types
{
	public partial class gameChaseSpawnComponent : entIComponent
	{
		public gameChaseSpawnComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
