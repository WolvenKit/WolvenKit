using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("shardNotification")] 
		public CName ShardNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("questNotification")] 
		public CName QuestNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("genericNotification")] 
		public CName GenericNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("messageNotification")] 
		public CName MessageNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(10)] 
		[RED("newAreablackboard")] 
		public CWeakHandle<gameIBlackboard> NewAreablackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("newAreaDef")] 
		public CHandle<UI_MapDef> NewAreaDef
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(12)] 
		[RED("newAreaID")] 
		public CHandle<redCallbackObject> NewAreaID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("tutorialBlackboard")] 
		public CWeakHandle<gameIBlackboard> TutorialBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("tutorialDef")] 
		public CHandle<UIGameDataDef> TutorialDef
		{
			get => GetPropertyValue<CHandle<UIGameDataDef>>();
			set => SetPropertyValue<CHandle<UIGameDataDef>>(value);
		}

		[Ordinal(15)] 
		[RED("tutorialID")] 
		public CHandle<redCallbackObject> TutorialID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("tutorialDataID")] 
		public CHandle<redCallbackObject> TutorialDataID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("isHiddenByTutorial")] 
		public CBool IsHiddenByTutorial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("customQuestNotificationblackBoardID")] 
		public CHandle<redCallbackObject> CustomQuestNotificationblackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("customQuestNotificationblackboardDef")] 
		public CHandle<UI_CustomQuestNotificationDef> CustomQuestNotificationblackboardDef
		{
			get => GetPropertyValue<CHandle<UI_CustomQuestNotificationDef>>();
			set => SetPropertyValue<CHandle<UI_CustomQuestNotificationDef>>(value);
		}

		[Ordinal(20)] 
		[RED("customQuestNotificationblackboard")] 
		public CWeakHandle<gameIBlackboard> CustomQuestNotificationblackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(23)] 
		[RED("activeVehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(24)] 
		[RED("mountBBConnectionId")] 
		public CHandle<redCallbackObject> MountBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("isPlayerMounted")] 
		public CBool IsPlayerMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(28)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("trackedMappinId")] 
		public CHandle<redCallbackObject> TrackedMappinId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(31)] 
		[RED("shardTransactionListener")] 
		public CWeakHandle<gameInventoryScriptListener> ShardTransactionListener
		{
			get => GetPropertyValue<CWeakHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CWeakHandle<gameInventoryScriptListener>>(value);
		}

		public JournalNotificationQueue()
		{
			ShowDuration = 6.000000F;
			CurrencyNotification = "notification_currency";
			ShardNotification = "notification_shard";
			ItemNotification = "Item_Received_SMALL";
			QuestNotification = "notification_quest";
			GenericNotification = "notification";
			MessageNotification = "notification_message";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
