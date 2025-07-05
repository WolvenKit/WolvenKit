using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestPhase : gameJournalContainerEntry
	{
		[Ordinal(3)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameJournalQuestPhase()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
