using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("timeBetweenIntroAndIntroDescription")] public CFloat TimeBetweenIntroAndIntroDescription { get; set; }
		[Ordinal(10)] [RED("timeBetweenIntroAndDescritpionDelayID")] public gameDelayID TimeBetweenIntroAndDescritpionDelayID { get; set; }
		[Ordinal(11)] [RED("timeBetweenIntroAndDescritpionCheck")] public CBool TimeBetweenIntroAndDescritpionCheck { get; set; }
		[Ordinal(12)] [RED("introDescriptionAnimProxy")] public CHandle<inkanimProxy> IntroDescriptionAnimProxy { get; set; }
		[Ordinal(13)] [RED("middleDots")] public inkWidgetReference MiddleDots { get; set; }
		[Ordinal(14)] [RED("memoryWidget")] public inkWidgetReference MemoryWidget { get; set; }
		[Ordinal(15)] [RED("avaliableMemory")] public inkTextWidgetReference AvaliableMemory { get; set; }
		[Ordinal(16)] [RED("listWidget")] public inkWidgetReference ListWidget { get; set; }
		[Ordinal(17)] [RED("executeBtn")] public inkWidgetReference ExecuteBtn { get; set; }
		[Ordinal(18)] [RED("executeAndCloseBtn")] public inkWidgetReference ExecuteAndCloseBtn { get; set; }
		[Ordinal(19)] [RED("rightPanel")] public inkWidgetReference RightPanel { get; set; }
		[Ordinal(20)] [RED("networkBreach")] public inkWidgetReference NetworkBreach { get; set; }
		[Ordinal(21)] [RED("costReductionPanel")] public inkWidgetReference CostReductionPanel { get; set; }
		[Ordinal(22)] [RED("costReductionValue")] public inkTextWidgetReference CostReductionValue { get; set; }
		[Ordinal(23)] [RED("targetName")] public inkTextWidgetReference TargetName { get; set; }
		[Ordinal(24)] [RED("icePanel")] public inkWidgetReference IcePanel { get; set; }
		[Ordinal(25)] [RED("iceValue")] public inkTextWidgetReference IceValue { get; set; }
		[Ordinal(26)] [RED("vulnerabilitiesPanel")] public inkWidgetReference VulnerabilitiesPanel { get; set; }
		[Ordinal(27)] [RED("vulnerabilityFields")] public CArray<inkWidgetReference> VulnerabilityFields { get; set; }
		[Ordinal(28)] [RED("subHeader")] public inkTextWidgetReference SubHeader { get; set; }
		[Ordinal(29)] [RED("tier")] public inkTextWidgetReference Tier { get; set; }
		[Ordinal(30)] [RED("description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(31)] [RED("recompileTimer")] public inkTextWidgetReference RecompileTimer { get; set; }
		[Ordinal(32)] [RED("damage")] public inkTextWidgetReference Damage { get; set; }
		[Ordinal(33)] [RED("duration")] public inkTextWidgetReference Duration { get; set; }
		[Ordinal(34)] [RED("cooldown")] public inkTextWidgetReference Cooldown { get; set; }
		[Ordinal(35)] [RED("uploadTime")] public inkTextWidgetReference UploadTime { get; set; }
		[Ordinal(36)] [RED("memoryCost")] public inkTextWidgetReference MemoryCost { get; set; }
		[Ordinal(37)] [RED("memoryRawCost")] public inkTextWidgetReference MemoryRawCost { get; set; }
		[Ordinal(38)] [RED("warningWidget")] public inkWidgetReference WarningWidget { get; set; }
		[Ordinal(39)] [RED("warningText")] public inkTextWidgetReference WarningText { get; set; }
		[Ordinal(40)] [RED("recompilePanel")] public inkWidgetReference RecompilePanel { get; set; }
		[Ordinal(41)] [RED("recompileText")] public inkTextWidgetReference RecompileText { get; set; }
		[Ordinal(42)] [RED("isUILocked")] public CBool IsUILocked { get; set; }
		[Ordinal(43)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(44)] [RED("visionModeSystem")] public wCHandle<gameVisionModeSystem> VisionModeSystem { get; set; }
		[Ordinal(45)] [RED("scanningCtrl")] public wCHandle<gameScanningController> ScanningCtrl { get; set; }
		[Ordinal(46)] [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(47)] [RED("contextHelpOverlay")] public CBool ContextHelpOverlay { get; set; }
		[Ordinal(48)] [RED("quickHackDescriptionVisibility")] public CUInt32 QuickHackDescriptionVisibility { get; set; }
		[Ordinal(49)] [RED("buffListListener")] public CUInt32 BuffListListener { get; set; }
		[Ordinal(50)] [RED("memoryBoard")] public CHandle<gameIBlackboard> MemoryBoard { get; set; }
		[Ordinal(51)] [RED("memoryBoardDef")] public CHandle<UI_PlayerBioMonitorDef> MemoryBoardDef { get; set; }
		[Ordinal(52)] [RED("memoryPercentListener")] public CUInt32 MemoryPercentListener { get; set; }
		[Ordinal(53)] [RED("quickhackBarArray")] public CArray<wCHandle<inkCompoundWidget>> QuickhackBarArray { get; set; }
		[Ordinal(54)] [RED("maxQuickhackBars")] public CInt32 MaxQuickhackBars { get; set; }
		[Ordinal(55)] [RED("listController")] public CHandle<inkListController> ListController { get; set; }
		[Ordinal(56)] [RED("data")] public CArray<CHandle<QuickhackData>> Data { get; set; }
		[Ordinal(57)] [RED("selectedData")] public CHandle<QuickhackData> SelectedData { get; set; }
		[Ordinal(58)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(59)] [RED("memorySpendAnimation")] public CHandle<inkanimProxy> MemorySpendAnimation { get; set; }
		[Ordinal(60)] [RED("currentMemoryCellsActive")] public CInt32 CurrentMemoryCellsActive { get; set; }
		[Ordinal(61)] [RED("desiredMemoryCellsActive")] public CInt32 DesiredMemoryCellsActive { get; set; }
		[Ordinal(62)] [RED("selectedMemoryLoop")] public CArray<CHandle<inkanimProxy>> SelectedMemoryLoop { get; set; }
		[Ordinal(63)] [RED("inkIntroAnimProxy")] public CHandle<inkanimProxy> InkIntroAnimProxy { get; set; }
		[Ordinal(64)] [RED("inkVulnerabilityAnimProxy")] public CHandle<inkanimProxy> InkVulnerabilityAnimProxy { get; set; }
		[Ordinal(65)] [RED("inkWarningAnimProxy")] public CHandle<inkanimProxy> InkWarningAnimProxy { get; set; }
		[Ordinal(66)] [RED("inkRecompileAnimProxy")] public CHandle<inkanimProxy> InkRecompileAnimProxy { get; set; }
		[Ordinal(67)] [RED("inkReductionAnimProxy")] public CHandle<inkanimProxy> InkReductionAnimProxy { get; set; }
		[Ordinal(68)] [RED("HACK_wasPlayedOnTarget")] public CBool HACK_wasPlayedOnTarget { get; set; }
		[Ordinal(69)] [RED("inkMemoryWarningTransitionAnimProxy")] public CHandle<inkanimProxy> InkMemoryWarningTransitionAnimProxy { get; set; }
		[Ordinal(70)] [RED("lastMemoryWarningTransitionAnimName")] public CName LastMemoryWarningTransitionAnimName { get; set; }
		[Ordinal(71)] [RED("hasActiveUpload")] public CBool HasActiveUpload { get; set; }
		[Ordinal(72)] [RED("lastCompiledTarget")] public entEntityID LastCompiledTarget { get; set; }
		[Ordinal(73)] [RED("statPoolListenersIndexes")] public CArray<CInt32> StatPoolListenersIndexes { get; set; }
		[Ordinal(74)] [RED("chunkBlackboard")] public CHandle<gameIBlackboard> ChunkBlackboard { get; set; }
		[Ordinal(75)] [RED("nameCallbackID")] public CUInt32 NameCallbackID { get; set; }
		[Ordinal(76)] [RED("axisInputConsumed")] public CBool AxisInputConsumed { get; set; }
		[Ordinal(77)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }

		public QuickhacksListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
