using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public GameTime Timestamp
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(2)] 
		[RED("isTrackedQuest")] 
		public CBool IsTrackedQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isOpenedQuest")] 
		public CBool IsOpenedQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(5)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(6)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("isVisited")] 
		public CBool IsVisited
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isResolved")] 
		public CBool IsResolved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("State")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(11)] 
		[RED("distancesFetched")] 
		public CBool DistancesFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("objectivesDistances")] 
		public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances
		{
			get => GetPropertyValue<CArray<CHandle<QuestListDistanceData>>>();
			set => SetPropertyValue<CArray<CHandle<QuestListDistanceData>>>(value);
		}

		public QuestListItemData()
		{
			Timestamp = new GameTime();
			ObjectivesDistances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
