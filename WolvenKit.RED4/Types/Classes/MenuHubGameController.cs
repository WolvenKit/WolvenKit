using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuHubGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get => GetPropertyValue<CHandle<MenuDataBuilder>>();
			set => SetPropertyValue<CHandle<MenuDataBuilder>>(value);
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(5)] 
		[RED("menuCtrl")] 
		public CWeakHandle<MenuHubLogicController> MenuCtrl
		{
			get => GetPropertyValue<CWeakHandle<MenuHubLogicController>>();
			set => SetPropertyValue<CWeakHandle<MenuHubLogicController>>(value);
		}

		[Ordinal(6)] 
		[RED("metaCtrl")] 
		public CWeakHandle<MetaQuestLogicController> MetaCtrl
		{
			get => GetPropertyValue<CWeakHandle<MetaQuestLogicController>>();
			set => SetPropertyValue<CWeakHandle<MetaQuestLogicController>>(value);
		}

		[Ordinal(7)] 
		[RED("subMenuCtrl")] 
		public CWeakHandle<SubMenuPanelLogicController> SubMenuCtrl
		{
			get => GetPropertyValue<CWeakHandle<SubMenuPanelLogicController>>();
			set => SetPropertyValue<CWeakHandle<SubMenuPanelLogicController>>(value);
		}

		[Ordinal(8)] 
		[RED("timeCtrl")] 
		public CWeakHandle<HubTimeSkipController> TimeCtrl
		{
			get => GetPropertyValue<CWeakHandle<HubTimeSkipController>>();
			set => SetPropertyValue<CWeakHandle<HubTimeSkipController>>(value);
		}

		[Ordinal(9)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(10)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(11)] 
		[RED("transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(12)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("hubMenuBlackboard")] 
		public CWeakHandle<gameIBlackboard> HubMenuBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("maxWeightListener")] 
		public CHandle<redCallbackObject> MaxWeightListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("submenuHiddenListener")] 
		public CHandle<redCallbackObject> SubmenuHiddenListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("metaQuestStatusListener")] 
		public CHandle<redCallbackObject> MetaQuestStatusListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(23)] 
		[RED("trackedEntry")] 
		public CWeakHandle<gameJournalQuestObjective> TrackedEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(24)] 
		[RED("trackedPhase")] 
		public CWeakHandle<gameJournalQuestPhase> TrackedPhase
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestPhase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestPhase>>(value);
		}

		[Ordinal(25)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(26)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("bgFluff")] 
		public inkWidgetReference BgFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(31)] 
		[RED("gameTimeContainer")] 
		public inkWidgetReference GameTimeContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("gameTimeController")] 
		public CWeakHandle<gameuiTimeDisplayLogicController> GameTimeController
		{
			get => GetPropertyValue<CWeakHandle<gameuiTimeDisplayLogicController>>();
			set => SetPropertyValue<CWeakHandle<gameuiTimeDisplayLogicController>>(value);
		}

		[Ordinal(33)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(34)] 
		[RED("callback")] 
		public CHandle<CurrencyUpdateCallback> Callback
		{
			get => GetPropertyValue<CHandle<CurrencyUpdateCallback>>();
			set => SetPropertyValue<CHandle<CurrencyUpdateCallback>>(value);
		}

		[Ordinal(35)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(36)] 
		[RED("previousRequest")] 
		public CHandle<OpenMenuRequest> PreviousRequest
		{
			get => GetPropertyValue<CHandle<OpenMenuRequest>>();
			set => SetPropertyValue<CHandle<OpenMenuRequest>>(value);
		}

		[Ordinal(37)] 
		[RED("currentRequest")] 
		public CHandle<OpenMenuRequest> CurrentRequest
		{
			get => GetPropertyValue<CHandle<OpenMenuRequest>>();
			set => SetPropertyValue<CHandle<OpenMenuRequest>>(value);
		}

		public MenuHubGameController()
		{
			NotificationRoot = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			BgFluff = new inkWidgetReference();
			GameTimeContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
