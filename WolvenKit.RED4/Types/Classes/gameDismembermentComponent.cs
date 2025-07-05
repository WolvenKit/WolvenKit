
namespace WolvenKit.RED4.Types
{
	public partial class gameDismembermentComponent : entIComponent
	{
		public gameDismembermentComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
