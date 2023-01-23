
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerTierComponent : entIComponent
	{
		public gamePlayerTierComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
