using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalSetLockQuestObjective_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("lock")] 
		public CBool Lock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJournalSetLockQuestObjective_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
