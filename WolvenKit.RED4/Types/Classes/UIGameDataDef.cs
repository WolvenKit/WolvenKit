using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIGameDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("InteractionData")] 
		public gamebbScriptID_Variant InteractionData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("ShowDialogLine")] 
		public gamebbScriptID_Variant ShowDialogLine
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("HideDialogLine")] 
		public gamebbScriptID_Variant HideDialogLine
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("HideDialogLineByData")] 
		public gamebbScriptID_Variant HideDialogLineByData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("ShowSceneComment")] 
		public gamebbScriptID_String ShowSceneComment
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(5)] 
		[RED("HideSceneComment")] 
		public gamebbScriptID_Bool HideSceneComment
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("ShowSubtitlesBackground")] 
		public gamebbScriptID_Bool ShowSubtitlesBackground
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("Popup_IsModal")] 
		public gamebbScriptID_Bool Popup_IsModal
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("Popup_IsShown")] 
		public gamebbScriptID_Bool Popup_IsShown
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("Popup_Data")] 
		public gamebbScriptID_Variant Popup_Data
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("Popup_Settings")] 
		public gamebbScriptID_Variant Popup_Settings
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("Controller_Disconnected")] 
		public gamebbScriptID_Bool Controller_Disconnected
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(12)] 
		[RED("ActivityLog")] 
		public gamebbScriptID_Variant ActivityLog
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("RightWeaponRecordID")] 
		public gamebbScriptID_Variant RightWeaponRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(14)] 
		[RED("LeftWeaponRecordID")] 
		public gamebbScriptID_Variant LeftWeaponRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("UIVendorContextRequest")] 
		public gamebbScriptID_Bool UIVendorContextRequest
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(17)] 
		[RED("QuestTimerInitialDuration")] 
		public gamebbScriptID_Float QuestTimerInitialDuration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(18)] 
		[RED("QuestTimerCurrentDuration")] 
		public gamebbScriptID_Float QuestTimerCurrentDuration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(19)] 
		[RED("Tutorial_EnableHighlight")] 
		public gamebbScriptID_Bool Tutorial_EnableHighlight
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(20)] 
		[RED("Tutorial_EntityRefToHighlight")] 
		public gamebbScriptID_Variant Tutorial_EntityRefToHighlight
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(21)] 
		[RED("WeaponSway")] 
		public gamebbScriptID_Vector2 WeaponSway
		{
			get => GetPropertyValue<gamebbScriptID_Vector2>();
			set => SetPropertyValue<gamebbScriptID_Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("NotificationJournalHash")] 
		public gamebbScriptID_Int32 NotificationJournalHash
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(23)] 
		[RED("IsBriefingActive")] 
		public gamebbScriptID_Bool IsBriefingActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("MuppetStats")] 
		public gamebbScriptID_Variant MuppetStats
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UIGameDataDef()
		{
			InteractionData = new gamebbScriptID_Variant();
			ShowDialogLine = new gamebbScriptID_Variant();
			HideDialogLine = new gamebbScriptID_Variant();
			HideDialogLineByData = new gamebbScriptID_Variant();
			ShowSceneComment = new gamebbScriptID_String();
			HideSceneComment = new gamebbScriptID_Bool();
			ShowSubtitlesBackground = new gamebbScriptID_Bool();
			Popup_IsModal = new gamebbScriptID_Bool();
			Popup_IsShown = new gamebbScriptID_Bool();
			Popup_Data = new gamebbScriptID_Variant();
			Popup_Settings = new gamebbScriptID_Variant();
			Controller_Disconnected = new gamebbScriptID_Bool();
			ActivityLog = new gamebbScriptID_Variant();
			RightWeaponRecordID = new gamebbScriptID_Variant();
			LeftWeaponRecordID = new gamebbScriptID_Variant();
			UIVendorContextRequest = new gamebbScriptID_Bool();
			UIjailbreakData = new gamebbScriptID_Variant();
			QuestTimerInitialDuration = new gamebbScriptID_Float();
			QuestTimerCurrentDuration = new gamebbScriptID_Float();
			Tutorial_EnableHighlight = new gamebbScriptID_Bool();
			Tutorial_EntityRefToHighlight = new gamebbScriptID_Variant();
			WeaponSway = new gamebbScriptID_Vector2();
			NotificationJournalHash = new gamebbScriptID_Int32();
			IsBriefingActive = new gamebbScriptID_Bool();
			MuppetStats = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
