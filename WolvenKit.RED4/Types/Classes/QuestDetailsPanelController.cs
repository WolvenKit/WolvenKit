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
		[RED("missionLinksContainer")] 
		public inkCompoundWidgetReference MissionLinksContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("fluffLinksContainer")] 
		public inkCompoundWidgetReference FluffLinksContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("mapLinksContainer")] 
		public inkCompoundWidgetReference MapLinksContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("missionLinkLine")] 
		public inkCompoundWidgetReference MissionLinkLine
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("fluffShardLinkLine")] 
		public inkCompoundWidgetReference FluffShardLinkLine
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("codexLinkLine")] 
		public inkCompoundWidgetReference CodexLinkLine
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("scrollContainer")] 
		public inkWidgetReference ScrollContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("noSelectedQuestContainer")] 
		public inkWidgetReference NoSelectedQuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("ep1Marker")] 
		public inkWidgetReference Ep1Marker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("scrollContainerCtrl")] 
		public CWeakHandle<inkScrollController> ScrollContainerCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(19)] 
		[RED("currentQuestData")] 
		public CWeakHandle<gameJournalQuest> CurrentQuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(20)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(21)] 
		[RED("shardEntry")] 
		public CWeakHandle<gameJournalOnscreen> ShardEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalOnscreen>>();
			set => SetPropertyValue<CWeakHandle<gameJournalOnscreen>>(value);
		}

		[Ordinal(22)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(23)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(24)] 
		[RED("uiSystem")] 
		public CWeakHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CWeakHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(25)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjective> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(26)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("objectiveOffset")] 
		public CFloat ObjectiveOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("objectiveActionOffset")] 
		public CFloat ObjectiveActionOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("objectiveActionsCount")] 
		public CInt32 ObjectiveActionsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public QuestDetailsPanelController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
