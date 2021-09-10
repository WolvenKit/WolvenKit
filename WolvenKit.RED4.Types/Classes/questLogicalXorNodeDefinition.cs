
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLogicalXorNodeDefinition : questLogicalBaseNodeDefinition
	{

		public questLogicalXorNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			InputSocketCount = 2;
			OutputSocketCount = 1;
		}
	}
}
