using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChattersGameController : BaseSubtitlesGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("lineMap")] public CArray<subtitleLineMapEntry> LineMap { get; set; }
		[Ordinal(8)]  [RED("pendingShowLines")] public CArray<CRUID> PendingShowLines { get; set; }
		[Ordinal(9)]  [RED("pendingHideLines")] public CArray<CRUID> PendingHideLines { get; set; }
		[Ordinal(10)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(11)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(12)]  [RED("bbCbShowDialogLine")] public CUInt32 BbCbShowDialogLine { get; set; }
		[Ordinal(13)]  [RED("bbCbHideDialogLine")] public CUInt32 BbCbHideDialogLine { get; set; }
		[Ordinal(14)]  [RED("bbCbHideDialogLineByData")] public CUInt32 BbCbHideDialogLineByData { get; set; }
		[Ordinal(15)]  [RED("bbCbShowBackground")] public CUInt32 BbCbShowBackground { get; set; }
		[Ordinal(16)]  [RED("showBackgroud")] public CBool ShowBackgroud { get; set; }
		[Ordinal(17)]  [RED("isCreoleUnlocked")] public CBool IsCreoleUnlocked { get; set; }
		[Ordinal(18)]  [RED("isPlayerJohnny")] public CBool IsPlayerJohnny { get; set; }
		[Ordinal(19)]  [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(20)]  [RED("settingsListener")] public CHandle<SubtitlesSettingsListener> SettingsListener { get; set; }
		[Ordinal(21)]  [RED("groupPath")] public CName GroupPath { get; set; }
		[Ordinal(22)]  [RED("disabledBySettings")] public CBool DisabledBySettings { get; set; }
		[Ordinal(23)]  [RED("backgroundOpacity")] public CFloat BackgroundOpacity { get; set; }
		[Ordinal(24)]  [RED("fontSize")] public CInt32 FontSize { get; set; }
		[Ordinal(25)]  [RED("factlistenerId")] public CUInt32 FactlistenerId { get; set; }
		[Ordinal(26)]  [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(27)]  [RED("c_CloseDisplayRange")] public CFloat C_CloseDisplayRange { get; set; }
		[Ordinal(28)]  [RED("c_TimeToUnblockSec")] public CFloat C_TimeToUnblockSec { get; set; }
		[Ordinal(29)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(30)]  [RED("AllControllers")] public CArray<ChatterKeyValuePair> AllControllers { get; set; }
		[Ordinal(31)]  [RED("targetingSystem")] public CHandle<gametargetingTargetingSystem> TargetingSystem { get; set; }
		[Ordinal(32)]  [RED("broadcastBlockingLines")] public CArray<CRUID> BroadcastBlockingLines { get; set; }
		[Ordinal(33)]  [RED("playerInDialogChoice")] public CBool PlayerInDialogChoice { get; set; }
		[Ordinal(34)]  [RED("lastBroadcastBlockingLineTime")] public EngineTime LastBroadcastBlockingLineTime { get; set; }
		[Ordinal(35)]  [RED("lastChoiceTime")] public EngineTime LastChoiceTime { get; set; }
		[Ordinal(36)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(37)]  [RED("sceneTier")] public CInt32 SceneTier { get; set; }

		public ChattersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
