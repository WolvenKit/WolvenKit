using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestTrackerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _questTitle;
		private inkCompoundWidgetReference _objectiveContainer;
		private inkTextWidgetReference _trackedMappinTitle;
		private inkWidgetReference _trackedMappinContainer;
		private inkCompoundWidgetReference _trackedMappinObjectiveContainer;
		private CWeakHandle<gameObject> _player;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<gameJournalQuestObjective> _bufferedEntry;
		private CWeakHandle<gameJournalQuestPhase> _bufferedPhase;
		private CWeakHandle<gameJournalQuest> _bufferedQuest;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CHandle<redCallbackObject> _uiSystemId;
		private CHandle<redCallbackObject> _trackedMappinId;
		private CWeakHandle<inkAsyncSpawnRequest> _trackedMappinSpawnRequest;
		private CWeakHandle<gamemappinsIMappin> _currentMappin;

		[Ordinal(9)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(10)] 
		[RED("ObjectiveContainer")] 
		public inkCompoundWidgetReference ObjectiveContainer
		{
			get => GetProperty(ref _objectiveContainer);
			set => SetProperty(ref _objectiveContainer, value);
		}

		[Ordinal(11)] 
		[RED("TrackedMappinTitle")] 
		public inkTextWidgetReference TrackedMappinTitle
		{
			get => GetProperty(ref _trackedMappinTitle);
			set => SetProperty(ref _trackedMappinTitle, value);
		}

		[Ordinal(12)] 
		[RED("TrackedMappinContainer")] 
		public inkWidgetReference TrackedMappinContainer
		{
			get => GetProperty(ref _trackedMappinContainer);
			set => SetProperty(ref _trackedMappinContainer, value);
		}

		[Ordinal(13)] 
		[RED("TrackedMappinObjectiveContainer")] 
		public inkCompoundWidgetReference TrackedMappinObjectiveContainer
		{
			get => GetProperty(ref _trackedMappinObjectiveContainer);
			set => SetProperty(ref _trackedMappinObjectiveContainer, value);
		}

		[Ordinal(14)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(15)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(16)] 
		[RED("bufferedEntry")] 
		public CWeakHandle<gameJournalQuestObjective> BufferedEntry
		{
			get => GetProperty(ref _bufferedEntry);
			set => SetProperty(ref _bufferedEntry, value);
		}

		[Ordinal(17)] 
		[RED("bufferedPhase")] 
		public CWeakHandle<gameJournalQuestPhase> BufferedPhase
		{
			get => GetProperty(ref _bufferedPhase);
			set => SetProperty(ref _bufferedPhase, value);
		}

		[Ordinal(18)] 
		[RED("bufferedQuest")] 
		public CWeakHandle<gameJournalQuest> BufferedQuest
		{
			get => GetProperty(ref _bufferedQuest);
			set => SetProperty(ref _bufferedQuest, value);
		}

		[Ordinal(19)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(20)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(21)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(22)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(23)] 
		[RED("trackedMappinId")] 
		public CHandle<redCallbackObject> TrackedMappinId
		{
			get => GetProperty(ref _trackedMappinId);
			set => SetProperty(ref _trackedMappinId, value);
		}

		[Ordinal(24)] 
		[RED("trackedMappinSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> TrackedMappinSpawnRequest
		{
			get => GetProperty(ref _trackedMappinSpawnRequest);
			set => SetProperty(ref _trackedMappinSpawnRequest, value);
		}

		[Ordinal(25)] 
		[RED("currentMappin")] 
		public CWeakHandle<gamemappinsIMappin> CurrentMappin
		{
			get => GetProperty(ref _currentMappin);
			set => SetProperty(ref _currentMappin, value);
		}
	}
}
