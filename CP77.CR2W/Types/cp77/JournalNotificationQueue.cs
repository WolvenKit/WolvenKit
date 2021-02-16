using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("showDuration")] public CFloat ShowDuration { get; set; }
		[Ordinal(3)] [RED("currencyNotification")] public CName CurrencyNotification { get; set; }
		[Ordinal(4)] [RED("shardNotification")] public CName ShardNotification { get; set; }
		[Ordinal(5)] [RED("itemNotification")] public CName ItemNotification { get; set; }
		[Ordinal(6)] [RED("questNotification")] public CName QuestNotification { get; set; }
		[Ordinal(7)] [RED("genericNotification")] public CName GenericNotification { get; set; }
		[Ordinal(8)] [RED("messageNotification")] public CName MessageNotification { get; set; }
		[Ordinal(9)] [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(10)] [RED("newAreablackboard")] public CHandle<gameIBlackboard> NewAreablackboard { get; set; }
		[Ordinal(11)] [RED("newAreaDef")] public CHandle<UI_MapDef> NewAreaDef { get; set; }
		[Ordinal(12)] [RED("newAreaID")] public CUInt32 NewAreaID { get; set; }
		[Ordinal(13)] [RED("tutorialBlackboard")] public CHandle<gameIBlackboard> TutorialBlackboard { get; set; }
		[Ordinal(14)] [RED("tutorialDef")] public CHandle<UIGameDataDef> TutorialDef { get; set; }
		[Ordinal(15)] [RED("tutorialID")] public CUInt32 TutorialID { get; set; }
		[Ordinal(16)] [RED("tutorialDataID")] public CUInt32 TutorialDataID { get; set; }
		[Ordinal(17)] [RED("isHiddenByTutorial")] public CBool IsHiddenByTutorial { get; set; }
		[Ordinal(18)] [RED("customQuestNotificationblackBoardID")] public CUInt32 CustomQuestNotificationblackBoardID { get; set; }
		[Ordinal(19)] [RED("customQuestNotificationblackboardDef")] public CHandle<UI_CustomQuestNotificationDef> CustomQuestNotificationblackboardDef { get; set; }
		[Ordinal(20)] [RED("customQuestNotificationblackboard")] public CHandle<gameIBlackboard> CustomQuestNotificationblackboard { get; set; }
		[Ordinal(21)] [RED("transactionSystem")] public wCHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(22)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(23)] [RED("activeVehicleBlackboard")] public CHandle<gameIBlackboard> ActiveVehicleBlackboard { get; set; }
		[Ordinal(24)] [RED("mountBBConnectionId")] public CUInt32 MountBBConnectionId { get; set; }
		[Ordinal(25)] [RED("isPlayerMounted")] public CBool IsPlayerMounted { get; set; }
		[Ordinal(26)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(27)] [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(28)] [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }
		[Ordinal(29)] [RED("trackedMappinId")] public CUInt32 TrackedMappinId { get; set; }
		[Ordinal(30)] [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(31)] [RED("shardTransactionListener")] public wCHandle<gameInventoryScriptListener> ShardTransactionListener { get; set; }

		public JournalNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
