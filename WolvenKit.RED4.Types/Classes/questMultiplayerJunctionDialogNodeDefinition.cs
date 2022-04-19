
namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerJunctionDialogNodeDefinition : questDisableableNodeDefinition
	{
		public questMultiplayerJunctionDialogNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
