
namespace WolvenKit.RED4.Types
{
	public partial class questLogicalHubNodeDefinition : questLogicalBaseNodeDefinition
	{
		public questLogicalHubNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			InputSocketCount = 2;
			OutputSocketCount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
