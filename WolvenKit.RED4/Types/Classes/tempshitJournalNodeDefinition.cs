
namespace WolvenKit.RED4.Types
{
	public partial class tempshitJournalNodeDefinition : questDisableableNodeDefinition
	{
		public tempshitJournalNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
