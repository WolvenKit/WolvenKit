using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIGameDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _interactionData;
		private gamebbScriptID_Variant _showDialogLine;
		private gamebbScriptID_Variant _hideDialogLine;
		private gamebbScriptID_Variant _hideDialogLineByData;
		private gamebbScriptID_String _showSceneComment;
		private gamebbScriptID_Bool _hideSceneComment;
		private gamebbScriptID_Bool _showSubtitlesBackground;
		private gamebbScriptID_Bool _popup_IsModal;
		private gamebbScriptID_Bool _popup_IsShown;
		private gamebbScriptID_Variant _popup_Data;
		private gamebbScriptID_Variant _popup_Settings;
		private gamebbScriptID_Bool _controller_Disconnected;
		private gamebbScriptID_Variant _activityLog;
		private gamebbScriptID_Variant _rightWeaponRecordID;
		private gamebbScriptID_Variant _leftWeaponRecordID;
		private gamebbScriptID_Bool _uIVendorContextRequest;
		private gamebbScriptID_Variant _uIjailbreakData;
		private gamebbScriptID_Float _questTimerInitialDuration;
		private gamebbScriptID_Float _questTimerCurrentDuration;
		private gamebbScriptID_Bool _tutorial_EnableHighlight;
		private gamebbScriptID_Variant _tutorial_EntityRefToHighlight;
		private gamebbScriptID_Vector2 _weaponSway;
		private gamebbScriptID_Int32 _notificationJournalHash;

		[Ordinal(0)] 
		[RED("InteractionData")] 
		public gamebbScriptID_Variant InteractionData
		{
			get => GetProperty(ref _interactionData);
			set => SetProperty(ref _interactionData, value);
		}

		[Ordinal(1)] 
		[RED("ShowDialogLine")] 
		public gamebbScriptID_Variant ShowDialogLine
		{
			get => GetProperty(ref _showDialogLine);
			set => SetProperty(ref _showDialogLine, value);
		}

		[Ordinal(2)] 
		[RED("HideDialogLine")] 
		public gamebbScriptID_Variant HideDialogLine
		{
			get => GetProperty(ref _hideDialogLine);
			set => SetProperty(ref _hideDialogLine, value);
		}

		[Ordinal(3)] 
		[RED("HideDialogLineByData")] 
		public gamebbScriptID_Variant HideDialogLineByData
		{
			get => GetProperty(ref _hideDialogLineByData);
			set => SetProperty(ref _hideDialogLineByData, value);
		}

		[Ordinal(4)] 
		[RED("ShowSceneComment")] 
		public gamebbScriptID_String ShowSceneComment
		{
			get => GetProperty(ref _showSceneComment);
			set => SetProperty(ref _showSceneComment, value);
		}

		[Ordinal(5)] 
		[RED("HideSceneComment")] 
		public gamebbScriptID_Bool HideSceneComment
		{
			get => GetProperty(ref _hideSceneComment);
			set => SetProperty(ref _hideSceneComment, value);
		}

		[Ordinal(6)] 
		[RED("ShowSubtitlesBackground")] 
		public gamebbScriptID_Bool ShowSubtitlesBackground
		{
			get => GetProperty(ref _showSubtitlesBackground);
			set => SetProperty(ref _showSubtitlesBackground, value);
		}

		[Ordinal(7)] 
		[RED("Popup_IsModal")] 
		public gamebbScriptID_Bool Popup_IsModal
		{
			get => GetProperty(ref _popup_IsModal);
			set => SetProperty(ref _popup_IsModal, value);
		}

		[Ordinal(8)] 
		[RED("Popup_IsShown")] 
		public gamebbScriptID_Bool Popup_IsShown
		{
			get => GetProperty(ref _popup_IsShown);
			set => SetProperty(ref _popup_IsShown, value);
		}

		[Ordinal(9)] 
		[RED("Popup_Data")] 
		public gamebbScriptID_Variant Popup_Data
		{
			get => GetProperty(ref _popup_Data);
			set => SetProperty(ref _popup_Data, value);
		}

		[Ordinal(10)] 
		[RED("Popup_Settings")] 
		public gamebbScriptID_Variant Popup_Settings
		{
			get => GetProperty(ref _popup_Settings);
			set => SetProperty(ref _popup_Settings, value);
		}

		[Ordinal(11)] 
		[RED("Controller_Disconnected")] 
		public gamebbScriptID_Bool Controller_Disconnected
		{
			get => GetProperty(ref _controller_Disconnected);
			set => SetProperty(ref _controller_Disconnected, value);
		}

		[Ordinal(12)] 
		[RED("ActivityLog")] 
		public gamebbScriptID_Variant ActivityLog
		{
			get => GetProperty(ref _activityLog);
			set => SetProperty(ref _activityLog, value);
		}

		[Ordinal(13)] 
		[RED("RightWeaponRecordID")] 
		public gamebbScriptID_Variant RightWeaponRecordID
		{
			get => GetProperty(ref _rightWeaponRecordID);
			set => SetProperty(ref _rightWeaponRecordID, value);
		}

		[Ordinal(14)] 
		[RED("LeftWeaponRecordID")] 
		public gamebbScriptID_Variant LeftWeaponRecordID
		{
			get => GetProperty(ref _leftWeaponRecordID);
			set => SetProperty(ref _leftWeaponRecordID, value);
		}

		[Ordinal(15)] 
		[RED("UIVendorContextRequest")] 
		public gamebbScriptID_Bool UIVendorContextRequest
		{
			get => GetProperty(ref _uIVendorContextRequest);
			set => SetProperty(ref _uIVendorContextRequest, value);
		}

		[Ordinal(16)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get => GetProperty(ref _uIjailbreakData);
			set => SetProperty(ref _uIjailbreakData, value);
		}

		[Ordinal(17)] 
		[RED("QuestTimerInitialDuration")] 
		public gamebbScriptID_Float QuestTimerInitialDuration
		{
			get => GetProperty(ref _questTimerInitialDuration);
			set => SetProperty(ref _questTimerInitialDuration, value);
		}

		[Ordinal(18)] 
		[RED("QuestTimerCurrentDuration")] 
		public gamebbScriptID_Float QuestTimerCurrentDuration
		{
			get => GetProperty(ref _questTimerCurrentDuration);
			set => SetProperty(ref _questTimerCurrentDuration, value);
		}

		[Ordinal(19)] 
		[RED("Tutorial_EnableHighlight")] 
		public gamebbScriptID_Bool Tutorial_EnableHighlight
		{
			get => GetProperty(ref _tutorial_EnableHighlight);
			set => SetProperty(ref _tutorial_EnableHighlight, value);
		}

		[Ordinal(20)] 
		[RED("Tutorial_EntityRefToHighlight")] 
		public gamebbScriptID_Variant Tutorial_EntityRefToHighlight
		{
			get => GetProperty(ref _tutorial_EntityRefToHighlight);
			set => SetProperty(ref _tutorial_EntityRefToHighlight, value);
		}

		[Ordinal(21)] 
		[RED("WeaponSway")] 
		public gamebbScriptID_Vector2 WeaponSway
		{
			get => GetProperty(ref _weaponSway);
			set => SetProperty(ref _weaponSway, value);
		}

		[Ordinal(22)] 
		[RED("NotificationJournalHash")] 
		public gamebbScriptID_Int32 NotificationJournalHash
		{
			get => GetProperty(ref _notificationJournalHash);
			set => SetProperty(ref _notificationJournalHash, value);
		}

		public UIGameDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
