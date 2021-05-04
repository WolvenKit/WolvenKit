using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _questTitle;
		private inkCompoundWidgetReference _objectiveContainer;
		private inkTextWidgetReference _trackedMappinTitle;
		private inkWidgetReference _trackedMappinContainer;
		private inkCompoundWidgetReference _trackedMappinObjectiveContainer;
		private wCHandle<gameObject> _player;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalQuestObjective> _bufferedEntry;
		private wCHandle<gameJournalQuestPhase> _bufferedPhase;
		private wCHandle<gameJournalQuest> _bufferedQuest;
		private wCHandle<inkWidget> _root;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;
		private CUInt32 _trackedMappinId;

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
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(15)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(16)] 
		[RED("bufferedEntry")] 
		public wCHandle<gameJournalQuestObjective> BufferedEntry
		{
			get => GetProperty(ref _bufferedEntry);
			set => SetProperty(ref _bufferedEntry, value);
		}

		[Ordinal(17)] 
		[RED("bufferedPhase")] 
		public wCHandle<gameJournalQuestPhase> BufferedPhase
		{
			get => GetProperty(ref _bufferedPhase);
			set => SetProperty(ref _bufferedPhase, value);
		}

		[Ordinal(18)] 
		[RED("bufferedQuest")] 
		public wCHandle<gameJournalQuest> BufferedQuest
		{
			get => GetProperty(ref _bufferedQuest);
			set => SetProperty(ref _bufferedQuest, value);
		}

		[Ordinal(19)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(20)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
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
		public CUInt32 UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(23)] 
		[RED("trackedMappinId")] 
		public CUInt32 TrackedMappinId
		{
			get => GetProperty(ref _trackedMappinId);
			set => SetProperty(ref _trackedMappinId, value);
		}

		public QuestTrackerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
