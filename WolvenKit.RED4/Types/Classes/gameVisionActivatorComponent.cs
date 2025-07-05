
namespace WolvenKit.RED4.Types
{
	public partial class gameVisionActivatorComponent : entIComponent
	{
		public gameVisionActivatorComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
