
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStartNodeDefinition : questStartEndNodeDefinition
	{

		public questStartNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
