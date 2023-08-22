
namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerJunctionDialogNodeDefinition : questDisableableNodeDefinition
	{
		public questMultiplayerJunctionDialogNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
