
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEndNodeDefinition : questStartEndNodeDefinition
	{

		public questEndNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
