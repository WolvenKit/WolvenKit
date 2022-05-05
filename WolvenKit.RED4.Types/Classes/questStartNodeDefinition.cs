
namespace WolvenKit.RED4.Types
{
	public partial class questStartNodeDefinition : questStartEndNodeDefinition
	{
		public questStartNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
