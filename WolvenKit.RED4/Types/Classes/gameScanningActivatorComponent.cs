
namespace WolvenKit.RED4.Types
{
	public partial class gameScanningActivatorComponent : entIComponent
	{
		public gameScanningActivatorComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
