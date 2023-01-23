using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestDetailsPanelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("questTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("questDescription")] 
		public inkTextWidgetReference QuestDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("questLevel")] 
		public inkTextWidgetReference QuestLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("activeObjectives")] 
		public inkCompoundWidgetReference ActiveObjectives
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("optionalObjectives")] 
		public inkCompoundWidgetReference OptionalObjectives
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("completedObjectives")] 
		public inkCompoundWidgetReference CompletedObjectives
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("codexLinksContainer")] 
		public inkCompoundWidgetReference CodexLinksContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("noSelectedQuestContainer")] 
		public inkWidgetReference NoSelectedQuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("currentQuestData")] 
		public CWeakHandle<gameJournalQuest> CurrentQuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(11)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(12)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(13)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjective> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(15)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestDetailsPanelController()
		{
			QuestTitle = new();
			QuestDescription = new();
			QuestLevel = new();
			ActiveObjectives = new();
			OptionalObjectives = new();
			CompletedObjectives = new();
			CodexLinksContainer = new();
			ContentContainer = new();
			NoSelectedQuestContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
