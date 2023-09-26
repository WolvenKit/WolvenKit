using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("questType")] 
		public CEnum<QuestListItemType> QuestType
		{
			get => GetPropertyValue<CEnum<QuestListItemType>>();
			set => SetPropertyValue<CEnum<QuestListItemType>>(value);
		}

		[Ordinal(1)] 
		[RED("lastUpdateTimestamp")] 
		public GameTime LastUpdateTimestamp
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
		[RED("State")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(9)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("distancesFetched")] 
		public CBool DistancesFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("objectivesDistances")] 
		public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances
		{
			get => GetPropertyValue<CArray<CHandle<QuestListDistanceData>>>();
			set => SetPropertyValue<CArray<CHandle<QuestListDistanceData>>>(value);
		}

		public QuestListItemData()
		{
			LastUpdateTimestamp = new GameTime();
			ObjectivesDistances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
