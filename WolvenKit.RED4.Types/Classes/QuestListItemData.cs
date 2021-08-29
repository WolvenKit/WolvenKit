using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListItemData : IScriptable
	{
		private CInt32 _questType;
		private GameTime _timestamp;
		private CBool _isTrackedQuest;
		private CBool _isOpenedQuest;
		private CWeakHandle<gameJournalQuest> _questData;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CBool _isVisited;
		private CBool _isResolved;
		private CEnum<gameJournalEntryState> _state;
		private CBool _distancesFetched;
		private CArray<CHandle<QuestListDistanceData>> _objectivesDistances;

		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public GameTime Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		[Ordinal(2)] 
		[RED("isTrackedQuest")] 
		public CBool IsTrackedQuest
		{
			get => GetProperty(ref _isTrackedQuest);
			set => SetProperty(ref _isTrackedQuest, value);
		}

		[Ordinal(3)] 
		[RED("isOpenedQuest")] 
		public CBool IsOpenedQuest
		{
			get => GetProperty(ref _isOpenedQuest);
			set => SetProperty(ref _isOpenedQuest, value);
		}

		[Ordinal(4)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(5)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(6)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(7)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(8)] 
		[RED("isVisited")] 
		public CBool IsVisited
		{
			get => GetProperty(ref _isVisited);
			set => SetProperty(ref _isVisited, value);
		}

		[Ordinal(9)] 
		[RED("isResolved")] 
		public CBool IsResolved
		{
			get => GetProperty(ref _isResolved);
			set => SetProperty(ref _isResolved, value);
		}

		[Ordinal(10)] 
		[RED("State")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(11)] 
		[RED("distancesFetched")] 
		public CBool DistancesFetched
		{
			get => GetProperty(ref _distancesFetched);
			set => SetProperty(ref _distancesFetched, value);
		}

		[Ordinal(12)] 
		[RED("objectivesDistances")] 
		public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances
		{
			get => GetProperty(ref _objectivesDistances);
			set => SetProperty(ref _objectivesDistances, value);
		}
	}
}
