
namespace WolvenKit.RED4.Types
{
	public partial class questInputNodeDefinition : questIONodeDefinition
	{
		public questInputNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
