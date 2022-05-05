using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLogGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("detailsPanel")] 
		public inkWidgetReference DetailsPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonHints")] 
		public inkWidgetReference ButtonHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonTrack")] 
		public inkWidgetReference ButtonTrack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(8)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(9)] 
		[RED("quests")] 
		public CArray<CWeakHandle<gameJournalEntry>> Quests
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(10)] 
		[RED("resolvedQuests")] 
		public CArray<CWeakHandle<gameJournalEntry>> ResolvedQuests
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(12)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(13)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(14)] 
		[RED("curreentQuest")] 
		public CWeakHandle<gameJournalQuest> CurreentQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(15)] 
		[RED("externallyOpenedQuestHash")] 
		public CInt32 ExternallyOpenedQuestHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("entryAnimProxy")] 
		public CHandle<inkanimProxy> EntryAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("listData")] 
		public CArray<CHandle<VirutalNestedListData>> ListData
		{
			get => GetPropertyValue<CArray<CHandle<VirutalNestedListData>>>();
			set => SetPropertyValue<CArray<CHandle<VirutalNestedListData>>>(value);
		}

		public questLogGameController()
		{
			VirtualList = new();
			DetailsPanel = new();
			ButtonHints = new();
			ButtonTrack = new();
			Game = new();
			Quests = new();
			ResolvedQuests = new();
			ListData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
