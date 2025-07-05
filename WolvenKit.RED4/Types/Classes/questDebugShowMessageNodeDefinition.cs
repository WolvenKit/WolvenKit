
namespace WolvenKit.RED4.Types
{
	public partial class questDebugShowMessageNodeDefinition : questDisableableNodeDefinition
	{
		public questDebugShowMessageNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
