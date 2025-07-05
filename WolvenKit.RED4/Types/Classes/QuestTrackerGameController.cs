using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestTrackerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("questTrackerContainer")] 
		public inkWidgetReference QuestTrackerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("ObjectiveContainer")] 
		public inkCompoundWidgetReference ObjectiveContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("TrackedMappinTitle")] 
		public inkTextWidgetReference TrackedMappinTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("TrackedMappinContainer")] 
		public inkWidgetReference TrackedMappinContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("TrackedMappinObjectiveContainer")] 
		public inkCompoundWidgetReference TrackedMappinObjectiveContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(16)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		[Ordinal(17)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(18)] 
		[RED("bufferedEntry")] 
		public CWeakHandle<gameJournalQuestObjective> BufferedEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(19)] 
		[RED("bufferedPhase")] 
		public CWeakHandle<gameJournalQuestPhase> BufferedPhase
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestPhase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestPhase>>(value);
		}

		[Ordinal(20)] 
		[RED("bufferedQuest")] 
		public CWeakHandle<gameJournalQuest> BufferedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(23)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(24)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("trackedMappinId")] 
		public CHandle<redCallbackObject> TrackedMappinId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("trackedMappinSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> TrackedMappinSpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		[Ordinal(27)] 
		[RED("currentMappin")] 
		public CWeakHandle<gamemappinsIMappin> CurrentMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		public QuestTrackerGameController()
		{
			QuestTrackerContainer = new inkWidgetReference();
			QuestTitle = new inkTextWidgetReference();
			ObjectiveContainer = new inkCompoundWidgetReference();
			TrackedMappinTitle = new inkTextWidgetReference();
			TrackedMappinContainer = new inkWidgetReference();
			TrackedMappinObjectiveContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
