
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLogicalAndNodeDefinition : questLogicalBaseNodeDefinition
	{

		public questLogicalAndNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			InputSocketCount = 2;
			OutputSocketCount = 1;
		}
	}
}
