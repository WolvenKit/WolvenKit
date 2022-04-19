using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalQuestEntry_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("trackQuest")] 
		public CBool TrackQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJournalQuestEntry_NodeType()
		{
			SendNotification = true;
			TrackQuest = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
