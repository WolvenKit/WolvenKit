
namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInventory : gameMuppetComponent
	{
		public gameMuppetInventory()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
