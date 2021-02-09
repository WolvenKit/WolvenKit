using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuHubGameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("menusData")] public CHandle<MenuDataBuilder> MenusData { get; set; }
		[Ordinal(2)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(3)]  [RED("menuCtrl")] public wCHandle<MenuHubLogicController> MenuCtrl { get; set; }
		[Ordinal(4)]  [RED("metaCtrl")] public wCHandle<MetaQuestLogicController> MetaCtrl { get; set; }
		[Ordinal(5)]  [RED("subMenuCtrl")] public wCHandle<SubMenuPanelLogicController> SubMenuCtrl { get; set; }
		[Ordinal(6)]  [RED("timeCtrl")] public wCHandle<HubTimeSkipController> TimeCtrl { get; set; }
		[Ordinal(7)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(8)]  [RED("playerDevSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevSystem { get; set; }
		[Ordinal(9)]  [RED("transaction")] public CHandle<gameTransactionSystem> Transaction { get; set; }
		[Ordinal(10)]  [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(11)]  [RED("hubMenuBlackboard")] public CHandle<gameIBlackboard> HubMenuBlackboard { get; set; }
		[Ordinal(12)]  [RED("characterCredListener")] public CUInt32 CharacterCredListener { get; set; }
		[Ordinal(13)]  [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(14)]  [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(15)]  [RED("characterCredPointsListener")] public CUInt32 CharacterCredPointsListener { get; set; }
		[Ordinal(16)]  [RED("weightListener")] public CUInt32 WeightListener { get; set; }
		[Ordinal(17)]  [RED("maxWeightListener")] public CUInt32 MaxWeightListener { get; set; }
		[Ordinal(18)]  [RED("submenuHiddenListener")] public CUInt32 SubmenuHiddenListener { get; set; }
		[Ordinal(19)]  [RED("metaQuestStatusListener")] public CUInt32 MetaQuestStatusListener { get; set; }
		[Ordinal(20)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(21)]  [RED("trackedEntry")] public wCHandle<gameJournalQuestObjective> TrackedEntry { get; set; }
		[Ordinal(22)]  [RED("trackedPhase")] public wCHandle<gameJournalQuestPhase> TrackedPhase { get; set; }
		[Ordinal(23)]  [RED("trackedQuest")] public wCHandle<gameJournalQuest> TrackedQuest { get; set; }
		[Ordinal(24)]  [RED("notificationRoot")] public inkWidgetReference NotificationRoot { get; set; }
		[Ordinal(25)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(26)]  [RED("bgFluff")] public inkWidgetReference BgFluff { get; set; }
		[Ordinal(27)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(28)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(29)]  [RED("gameTimeContainer")] public inkWidgetReference GameTimeContainer { get; set; }
		[Ordinal(30)]  [RED("gameTimeController")] public CHandle<gameuiTimeDisplayLogicController> GameTimeController { get; set; }
		[Ordinal(31)]  [RED("previousRequest")] public CHandle<OpenMenuRequest> PreviousRequest { get; set; }
		[Ordinal(32)]  [RED("currentRequest")] public CHandle<OpenMenuRequest> CurrentRequest { get; set; }

		public MenuHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
