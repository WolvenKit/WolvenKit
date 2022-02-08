
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTestNodeDefinition : questDisableableNodeDefinition
	{

		public questTestNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
