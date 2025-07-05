
namespace WolvenKit.RED4.Types
{
	public partial class questTestNodeDefinition : questDisableableNodeDefinition
	{
		public questTestNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
