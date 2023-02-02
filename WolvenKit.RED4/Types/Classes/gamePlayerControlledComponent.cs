
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerControlledComponent : entIComponent
	{
		public gamePlayerControlledComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
