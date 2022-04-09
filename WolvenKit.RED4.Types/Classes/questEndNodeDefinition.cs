
namespace WolvenKit.RED4.Types
{
	public partial class questEndNodeDefinition : questStartEndNodeDefinition
	{
		public questEndNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
