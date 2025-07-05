
namespace WolvenKit.RED4.Types
{
	public partial class questLogicalHubNodeDefinition : questLogicalBaseNodeDefinition
	{
		public questLogicalHubNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			InputSocketCount = 2;
			OutputSocketCount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
