
namespace WolvenKit.RED4.Types
{
	public partial class questLogicalXorNodeDefinition : questLogicalBaseNodeDefinition
	{
		public questLogicalXorNodeDefinition()
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
