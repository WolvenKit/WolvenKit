
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLogicalHubNodeDefinition : questLogicalBaseNodeDefinition
	{

		public questLogicalHubNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			InputSocketCount = 2;
			OutputSocketCount = 1;
		}
	}
}
