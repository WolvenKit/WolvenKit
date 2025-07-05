
namespace WolvenKit.RED4.Types
{
	public partial class questEndNodeDefinition : questStartEndNodeDefinition
	{
		public questEndNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
