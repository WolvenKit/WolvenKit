
namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetStats : gameMuppetComponent
	{
		public gameMuppetStats()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
