
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerMappinComponent : entIComponent
	{
		public gamePlayerMappinComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
