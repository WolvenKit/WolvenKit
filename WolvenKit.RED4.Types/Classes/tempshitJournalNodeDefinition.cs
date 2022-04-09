
namespace WolvenKit.RED4.Types
{
	public partial class tempshitJournalNodeDefinition : questDisableableNodeDefinition
	{
		public tempshitJournalNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
