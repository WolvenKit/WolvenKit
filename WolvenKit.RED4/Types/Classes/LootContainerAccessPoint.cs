
namespace WolvenKit.RED4.Types
{
	public partial class LootContainerAccessPoint : AccessPoint
	{
		public LootContainerAccessPoint()
		{
			ControllerTypeName = "LootContainerAccessPointController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
