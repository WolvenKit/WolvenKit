using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestPhase : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameJournalQuestPhase()
		{
			Entries = new();
		}
	}
}
