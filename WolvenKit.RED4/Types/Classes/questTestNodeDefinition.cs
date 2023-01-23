
namespace WolvenKit.RED4.Types
{
	public partial class questTestNodeDefinition : questDisableableNodeDefinition
	{
		public questTestNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
