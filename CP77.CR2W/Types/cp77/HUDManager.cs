using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDManager : gameNativeHudManager
	{
		[Ordinal(0)] [RED("state")] public CEnum<HUDState> State { get; set; }
		[Ordinal(1)] [RED("activeMode")] public CEnum<ActiveMode> ActiveMode { get; set; }
		[Ordinal(2)] [RED("instructionsDelayID")] public gameDelayID InstructionsDelayID { get; set; }
		[Ordinal(3)] [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(4)] [RED("modulesArray")] public CArray<CHandle<HUDModule>> ModulesArray { get; set; }
		[Ordinal(5)] [RED("scanner")] public CHandle<ScannerModule> Scanner { get; set; }
		[Ordinal(6)] [RED("braindanceModule")] public CHandle<BraindanceModule> BraindanceModule { get; set; }
		[Ordinal(7)] [RED("highlightsModule")] public CHandle<HighlightModule> HighlightsModule { get; set; }
		[Ordinal(8)] [RED("iconsModule")] public CHandle<IconsModule> IconsModule { get; set; }
		[Ordinal(9)] [RED("crosshair")] public CHandle<CrosshairModule> Crosshair { get; set; }
		[Ordinal(10)] [RED("aimAssist")] public CHandle<AimAssistModule> AimAssist { get; set; }
		[Ordinal(11)] [RED("quickhackModule")] public CHandle<QuickhackModule> QuickhackModule { get; set; }
		[Ordinal(12)] [RED("lastTarget")] public wCHandle<gameHudActor> LastTarget { get; set; }
		[Ordinal(13)] [RED("currentTarget")] public wCHandle<gameHudActor> CurrentTarget { get; set; }
		[Ordinal(14)] [RED("lookAtTarget")] public entEntityID LookAtTarget { get; set; }
		[Ordinal(15)] [RED("scannerTarget")] public entEntityID ScannerTarget { get; set; }
		[Ordinal(16)] [RED("nameplateTarget")] public entEntityID NameplateTarget { get; set; }
		[Ordinal(17)] [RED("quickHackTarget")] public entEntityID QuickHackTarget { get; set; }
		[Ordinal(18)] [RED("lootedTarget")] public entEntityID LootedTarget { get; set; }
		[Ordinal(19)] [RED("scannningController")] public wCHandle<gameScanningController> ScannningController { get; set; }
		[Ordinal(20)] [RED("uiScannerVisible")] public CBool UiScannerVisible { get; set; }
		[Ordinal(21)] [RED("uiQuickHackVisible")] public CBool UiQuickHackVisible { get; set; }
		[Ordinal(22)] [RED("quickHackDescriptionVisible")] public CBool QuickHackDescriptionVisible { get; set; }
		[Ordinal(23)] [RED("targetingSystem")] public wCHandle<gametargetingTargetingSystem> TargetingSystem { get; set; }
		[Ordinal(24)] [RED("visionModeSystem")] public wCHandle<gameVisionModeSystem> VisionModeSystem { get; set; }
		[Ordinal(25)] [RED("isHackingMinigameActive")] public CBool IsHackingMinigameActive { get; set; }
		[Ordinal(26)] [RED("stickInputListener")] public CUInt32 StickInputListener { get; set; }
		[Ordinal(27)] [RED("quickHackPanelListener")] public CUInt32 QuickHackPanelListener { get; set; }
		[Ordinal(28)] [RED("carriedBodyListener")] public CUInt32 CarriedBodyListener { get; set; }
		[Ordinal(29)] [RED("grappleListener")] public CUInt32 GrappleListener { get; set; }
		[Ordinal(30)] [RED("lookatRequest")] public gameaimAssistAimRequest LookatRequest { get; set; }
		[Ordinal(31)] [RED("isQHackUIInputLocked")] public CBool IsQHackUIInputLocked { get; set; }
		[Ordinal(32)] [RED("playerAttachedCallbackID")] public CUInt32 PlayerAttachedCallbackID { get; set; }
		[Ordinal(33)] [RED("playerDetachedCallbackID")] public CUInt32 PlayerDetachedCallbackID { get; set; }
		[Ordinal(34)] [RED("playerTargetCallbackID")] public CUInt32 PlayerTargetCallbackID { get; set; }
		[Ordinal(35)] [RED("braindanceToggleCallbackID")] public CUInt32 BraindanceToggleCallbackID { get; set; }
		[Ordinal(36)] [RED("nameplateCallbackID")] public CUInt32 NameplateCallbackID { get; set; }
		[Ordinal(37)] [RED("visionModeChangedCallbackID")] public CUInt32 VisionModeChangedCallbackID { get; set; }
		[Ordinal(38)] [RED("scannerTargetCallbackID")] public CUInt32 ScannerTargetCallbackID { get; set; }
		[Ordinal(39)] [RED("hackingMinigameCallbackID")] public CUInt32 HackingMinigameCallbackID { get; set; }
		[Ordinal(40)] [RED("uiScannerVisibleCallbackID")] public CUInt32 UiScannerVisibleCallbackID { get; set; }
		[Ordinal(41)] [RED("uiQuickHackVisibleCallbackID")] public CUInt32 UiQuickHackVisibleCallbackID { get; set; }
		[Ordinal(42)] [RED("lootDataCallbackID")] public CUInt32 LootDataCallbackID { get; set; }
		[Ordinal(43)] [RED("pulseDelayID")] public gameDelayID PulseDelayID { get; set; }
		[Ordinal(44)] [RED("previousStickInput")] public Vector4 PreviousStickInput { get; set; }

		public HUDManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
