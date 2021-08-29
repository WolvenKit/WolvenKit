using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestDetailsPanelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _questTitle;
		private inkTextWidgetReference _questDescription;
		private inkTextWidgetReference _questLevel;
		private inkCompoundWidgetReference _activeObjectives;
		private inkCompoundWidgetReference _optionalObjectives;
		private inkCompoundWidgetReference _completedObjectives;
		private inkCompoundWidgetReference _codexLinksContainer;
		private inkWidgetReference _contentContainer;
		private inkWidgetReference _noSelectedQuestContainer;
		private CWeakHandle<gameJournalQuest> _currentQuestData;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<PhoneSystem> _phoneSystem;
		private CWeakHandle<gamemappinsMappinSystem> _mappinSystem;
		private CWeakHandle<gameJournalQuestObjective> _trackedObjective;
		private CBool _canUsePhone;

		[Ordinal(1)] 
		[RED("questTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(2)] 
		[RED("questDescription")] 
		public inkTextWidgetReference QuestDescription
		{
			get => GetProperty(ref _questDescription);
			set => SetProperty(ref _questDescription, value);
		}

		[Ordinal(3)] 
		[RED("questLevel")] 
		public inkTextWidgetReference QuestLevel
		{
			get => GetProperty(ref _questLevel);
			set => SetProperty(ref _questLevel, value);
		}

		[Ordinal(4)] 
		[RED("activeObjectives")] 
		public inkCompoundWidgetReference ActiveObjectives
		{
			get => GetProperty(ref _activeObjectives);
			set => SetProperty(ref _activeObjectives, value);
		}

		[Ordinal(5)] 
		[RED("optionalObjectives")] 
		public inkCompoundWidgetReference OptionalObjectives
		{
			get => GetProperty(ref _optionalObjectives);
			set => SetProperty(ref _optionalObjectives, value);
		}

		[Ordinal(6)] 
		[RED("completedObjectives")] 
		public inkCompoundWidgetReference CompletedObjectives
		{
			get => GetProperty(ref _completedObjectives);
			set => SetProperty(ref _completedObjectives, value);
		}

		[Ordinal(7)] 
		[RED("codexLinksContainer")] 
		public inkCompoundWidgetReference CodexLinksContainer
		{
			get => GetProperty(ref _codexLinksContainer);
			set => SetProperty(ref _codexLinksContainer, value);
		}

		[Ordinal(8)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetProperty(ref _contentContainer);
			set => SetProperty(ref _contentContainer, value);
		}

		[Ordinal(9)] 
		[RED("noSelectedQuestContainer")] 
		public inkWidgetReference NoSelectedQuestContainer
		{
			get => GetProperty(ref _noSelectedQuestContainer);
			set => SetProperty(ref _noSelectedQuestContainer, value);
		}

		[Ordinal(10)] 
		[RED("currentQuestData")] 
		public CWeakHandle<gameJournalQuest> CurrentQuestData
		{
			get => GetProperty(ref _currentQuestData);
			set => SetProperty(ref _currentQuestData, value);
		}

		[Ordinal(11)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(12)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(13)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		[Ordinal(14)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjective> TrackedObjective
		{
			get => GetProperty(ref _trackedObjective);
			set => SetProperty(ref _trackedObjective, value);
		}

		[Ordinal(15)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetProperty(ref _canUsePhone);
			set => SetProperty(ref _canUsePhone, value);
		}
	}
}
