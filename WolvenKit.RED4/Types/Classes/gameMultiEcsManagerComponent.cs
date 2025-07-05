
namespace WolvenKit.RED4.Types
{
	public partial class gameMultiEcsManagerComponent : entIComponent
	{
		public gameMultiEcsManagerComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
