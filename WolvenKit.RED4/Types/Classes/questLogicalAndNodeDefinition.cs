
namespace WolvenKit.RED4.Types
{
	public partial class questLogicalAndNodeDefinition : questLogicalBaseNodeDefinition
	{
		public questLogicalAndNodeDefinition()
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
