
namespace WolvenKit.RED4.Types
{
	public partial class questStartNodeDefinition : questStartEndNodeDefinition
	{
		public questStartNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
