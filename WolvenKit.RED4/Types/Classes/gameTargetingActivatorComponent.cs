
namespace WolvenKit.RED4.Types
{
	public partial class gameTargetingActivatorComponent : entIComponent
	{
		public gameTargetingActivatorComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
