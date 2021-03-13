using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ScannerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("Scannables")] public gamebbScriptID_Variant Scannables { get; set; }
		[Ordinal(1)] [RED("CurrentProgress")] public gamebbScriptID_Float CurrentProgress { get; set; }
		[Ordinal(2)] [RED("CurrentState")] public gamebbScriptID_Variant CurrentState { get; set; }
		[Ordinal(3)] [RED("ProgressBarText")] public gamebbScriptID_String ProgressBarText { get; set; }
		[Ordinal(4)] [RED("ScannedObject")] public gamebbScriptID_EntityID ScannedObject { get; set; }
		[Ordinal(5)] [RED("ScannerMode")] public gamebbScriptID_Variant ScannerMode { get; set; }
		[Ordinal(6)] [RED("scannerTooltip")] public gamebbScriptID_Int32 ScannerTooltip { get; set; }
		[Ordinal(7)] [RED("scannerData")] public gamebbScriptID_Variant ScannerData { get; set; }
		[Ordinal(8)] [RED("scannerObjectDistance")] public gamebbScriptID_Float ScannerObjectDistance { get; set; }
		[Ordinal(9)] [RED("scannerObjectStats")] public gamebbScriptID_Variant ScannerObjectStats { get; set; }
		[Ordinal(10)] [RED("scannerQuickHackActionId")] public gamebbScriptID_Int32 ScannerQuickHackActionId { get; set; }
		[Ordinal(11)] [RED("scannerQuickHackActionStarted")] public gamebbScriptID_Bool ScannerQuickHackActionStarted { get; set; }
		[Ordinal(12)] [RED("scannerQuickHackTime")] public gamebbScriptID_Float ScannerQuickHackTime { get; set; }
		[Ordinal(13)] [RED("exclusiveFocusActive")] public gamebbScriptID_Bool ExclusiveFocusActive { get; set; }
		[Ordinal(14)] [RED("LastTaggedTarget")] public gamebbScriptID_Variant LastTaggedTarget { get; set; }
		[Ordinal(15)] [RED("skillCheckInfo")] public gamebbScriptID_Variant SkillCheckInfo { get; set; }
		[Ordinal(16)] [RED("ShowHudHintMessege")] public gamebbScriptID_Bool ShowHudHintMessege { get; set; }
		[Ordinal(17)] [RED("HudHintMessegeContent")] public gamebbScriptID_String HudHintMessegeContent { get; set; }
		[Ordinal(18)] [RED("UIVisible")] public gamebbScriptID_Bool UIVisible { get; set; }
		[Ordinal(19)] [RED("ScannerLookAt")] public gamebbScriptID_Bool ScannerLookAt { get; set; }

		public UI_ScannerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
