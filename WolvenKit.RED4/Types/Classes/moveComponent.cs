
namespace WolvenKit.RED4.Types
{
	public partial class moveComponent : entIMoverComponent
	{
		public moveComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
