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
		[RED("filtersList")] 
		public inkWidgetReference FiltersList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("questList")] 
		public inkWidgetReference QuestList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(9)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(10)] 
		[RED("quests")] 
		public CArray<CWeakHandle<gameJournalEntry>> Quests
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(11)] 
		[RED("resolvedQuests")] 
		public CArray<CWeakHandle<gameJournalEntry>> ResolvedQuests
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(13)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(14)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(15)] 
		[RED("curreentQuest")] 
		public CWeakHandle<gameJournalQuest> CurreentQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(16)] 
		[RED("externallyOpenedQuestHash")] 
		public CInt32 ExternallyOpenedQuestHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("entryAnimProxy")] 
		public CHandle<inkanimProxy> EntryAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("detailsPanelCtrl")] 
		public CWeakHandle<QuestDetailsPanelController> DetailsPanelCtrl
		{
			get => GetPropertyValue<CWeakHandle<QuestDetailsPanelController>>();
			set => SetPropertyValue<CWeakHandle<QuestDetailsPanelController>>(value);
		}

		[Ordinal(22)] 
		[RED("virtualListController")] 
		public CWeakHandle<QuestListVirtualController> VirtualListController
		{
			get => GetPropertyValue<CWeakHandle<QuestListVirtualController>>();
			set => SetPropertyValue<CWeakHandle<QuestListVirtualController>>(value);
		}

		[Ordinal(23)] 
		[RED("filters")] 
		public CArray<CWeakHandle<QuestListFilterButtonController>> Filters
		{
			get => GetPropertyValue<CArray<CWeakHandle<QuestListFilterButtonController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<QuestListFilterButtonController>>>(value);
		}

		[Ordinal(24)] 
		[RED("activeFilter")] 
		public CWeakHandle<QuestListFilterButtonController> ActiveFilter
		{
			get => GetPropertyValue<CWeakHandle<QuestListFilterButtonController>>();
			set => SetPropertyValue<CWeakHandle<QuestListFilterButtonController>>(value);
		}

		[Ordinal(25)] 
		[RED("currentCustomFilterIndex")] 
		public CInt32 CurrentCustomFilterIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("mouseDataThreshold")] 
		public CFloat MouseDataThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("delayedShowDuration")] 
		public CFloat DelayedShowDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("delayedShow")] 
		public gameDelayID DelayedShow
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(30)] 
		[RED("listPanelHoverd")] 
		public CBool ListPanelHoverd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isDelayTicking")] 
		public CBool IsDelayTicking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("filterSwich")] 
		public CBool FilterSwich
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("questData")] 
		public CWeakHandle<gameJournalQuest> QuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(35)] 
		[RED("appliedQuestData")] 
		public CWeakHandle<gameJournalQuest> AppliedQuestData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(36)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("listData")] 
		public CArray<CHandle<QuestListItemData>> ListData
		{
			get => GetPropertyValue<CArray<CHandle<QuestListItemData>>>();
			set => SetPropertyValue<CArray<CHandle<QuestListItemData>>>(value);
		}

		[Ordinal(38)] 
		[RED("questTypeList")] 
		public CArray<CEnum<QuestListItemType>> QuestTypeList
		{
			get => GetPropertyValue<CArray<CEnum<QuestListItemType>>>();
			set => SetPropertyValue<CArray<CEnum<QuestListItemType>>>(value);
		}

		[Ordinal(39)] 
		[RED("questToOpen")] 
		public CWeakHandle<gameJournalQuest> QuestToOpen
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		public questLogGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
