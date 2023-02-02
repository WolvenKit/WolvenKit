
namespace WolvenKit.RED4.Types
{
	public partial class gameComponentsStateSaveComponent : entIComponent
	{
		public gameComponentsStateSaveComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
