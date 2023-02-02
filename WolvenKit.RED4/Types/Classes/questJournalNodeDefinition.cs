using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIJournal_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questIJournal_NodeType>>();
			set => SetPropertyValue<CHandle<questIJournal_NodeType>>(value);
		}

		public questJournalNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
