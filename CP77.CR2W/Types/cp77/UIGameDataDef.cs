using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIGameDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("InteractionData")] public gamebbScriptID_Variant InteractionData { get; set; }
		[Ordinal(1)] [RED("ShowDialogLine")] public gamebbScriptID_Variant ShowDialogLine { get; set; }
		[Ordinal(2)] [RED("HideDialogLine")] public gamebbScriptID_Variant HideDialogLine { get; set; }
		[Ordinal(3)] [RED("HideDialogLineByData")] public gamebbScriptID_Variant HideDialogLineByData { get; set; }
		[Ordinal(4)] [RED("ShowSceneComment")] public gamebbScriptID_String ShowSceneComment { get; set; }
		[Ordinal(5)] [RED("HideSceneComment")] public gamebbScriptID_Bool HideSceneComment { get; set; }
		[Ordinal(6)] [RED("ShowSubtitlesBackground")] public gamebbScriptID_Bool ShowSubtitlesBackground { get; set; }
		[Ordinal(7)] [RED("Popup_IsModal")] public gamebbScriptID_Bool Popup_IsModal { get; set; }
		[Ordinal(8)] [RED("Popup_IsShown")] public gamebbScriptID_Bool Popup_IsShown { get; set; }
		[Ordinal(9)] [RED("Popup_Data")] public gamebbScriptID_Variant Popup_Data { get; set; }
		[Ordinal(10)] [RED("Popup_Settings")] public gamebbScriptID_Variant Popup_Settings { get; set; }
		[Ordinal(11)] [RED("Controller_Disconnected")] public gamebbScriptID_Bool Controller_Disconnected { get; set; }
		[Ordinal(12)] [RED("ActivityLog")] public gamebbScriptID_Variant ActivityLog { get; set; }
		[Ordinal(13)] [RED("RightWeaponRecordID")] public gamebbScriptID_Variant RightWeaponRecordID { get; set; }
		[Ordinal(14)] [RED("LeftWeaponRecordID")] public gamebbScriptID_Variant LeftWeaponRecordID { get; set; }
		[Ordinal(15)] [RED("UIVendorContextRequest")] public gamebbScriptID_Bool UIVendorContextRequest { get; set; }
		[Ordinal(16)] [RED("UIjailbreakData")] public gamebbScriptID_Variant UIjailbreakData { get; set; }
		[Ordinal(17)] [RED("QuestTimerInitialDuration")] public gamebbScriptID_Float QuestTimerInitialDuration { get; set; }
		[Ordinal(18)] [RED("QuestTimerCurrentDuration")] public gamebbScriptID_Float QuestTimerCurrentDuration { get; set; }
		[Ordinal(19)] [RED("Tutorial_EnableHighlight")] public gamebbScriptID_Bool Tutorial_EnableHighlight { get; set; }
		[Ordinal(20)] [RED("Tutorial_EntityRefToHighlight")] public gamebbScriptID_Variant Tutorial_EntityRefToHighlight { get; set; }
		[Ordinal(21)] [RED("WeaponSway")] public gamebbScriptID_Vector2 WeaponSway { get; set; }
		[Ordinal(22)] [RED("NotificationJournalHash")] public gamebbScriptID_Int32 NotificationJournalHash { get; set; }

		public UIGameDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
