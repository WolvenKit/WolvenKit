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
			get
			{
				if (_interactionData == null)
				{
					_interactionData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "InteractionData", cr2w, this);
				}
				return _interactionData;
			}
			set
			{
				if (_interactionData == value)
				{
					return;
				}
				_interactionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ShowDialogLine")] 
		public gamebbScriptID_Variant ShowDialogLine
		{
			get
			{
				if (_showDialogLine == null)
				{
					_showDialogLine = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ShowDialogLine", cr2w, this);
				}
				return _showDialogLine;
			}
			set
			{
				if (_showDialogLine == value)
				{
					return;
				}
				_showDialogLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("HideDialogLine")] 
		public gamebbScriptID_Variant HideDialogLine
		{
			get
			{
				if (_hideDialogLine == null)
				{
					_hideDialogLine = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "HideDialogLine", cr2w, this);
				}
				return _hideDialogLine;
			}
			set
			{
				if (_hideDialogLine == value)
				{
					return;
				}
				_hideDialogLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HideDialogLineByData")] 
		public gamebbScriptID_Variant HideDialogLineByData
		{
			get
			{
				if (_hideDialogLineByData == null)
				{
					_hideDialogLineByData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "HideDialogLineByData", cr2w, this);
				}
				return _hideDialogLineByData;
			}
			set
			{
				if (_hideDialogLineByData == value)
				{
					return;
				}
				_hideDialogLineByData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ShowSceneComment")] 
		public gamebbScriptID_String ShowSceneComment
		{
			get
			{
				if (_showSceneComment == null)
				{
					_showSceneComment = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "ShowSceneComment", cr2w, this);
				}
				return _showSceneComment;
			}
			set
			{
				if (_showSceneComment == value)
				{
					return;
				}
				_showSceneComment = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HideSceneComment")] 
		public gamebbScriptID_Bool HideSceneComment
		{
			get
			{
				if (_hideSceneComment == null)
				{
					_hideSceneComment = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HideSceneComment", cr2w, this);
				}
				return _hideSceneComment;
			}
			set
			{
				if (_hideSceneComment == value)
				{
					return;
				}
				_hideSceneComment = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ShowSubtitlesBackground")] 
		public gamebbScriptID_Bool ShowSubtitlesBackground
		{
			get
			{
				if (_showSubtitlesBackground == null)
				{
					_showSubtitlesBackground = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ShowSubtitlesBackground", cr2w, this);
				}
				return _showSubtitlesBackground;
			}
			set
			{
				if (_showSubtitlesBackground == value)
				{
					return;
				}
				_showSubtitlesBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Popup_IsModal")] 
		public gamebbScriptID_Bool Popup_IsModal
		{
			get
			{
				if (_popup_IsModal == null)
				{
					_popup_IsModal = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Popup_IsModal", cr2w, this);
				}
				return _popup_IsModal;
			}
			set
			{
				if (_popup_IsModal == value)
				{
					return;
				}
				_popup_IsModal = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Popup_IsShown")] 
		public gamebbScriptID_Bool Popup_IsShown
		{
			get
			{
				if (_popup_IsShown == null)
				{
					_popup_IsShown = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Popup_IsShown", cr2w, this);
				}
				return _popup_IsShown;
			}
			set
			{
				if (_popup_IsShown == value)
				{
					return;
				}
				_popup_IsShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Popup_Data")] 
		public gamebbScriptID_Variant Popup_Data
		{
			get
			{
				if (_popup_Data == null)
				{
					_popup_Data = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Popup_Data", cr2w, this);
				}
				return _popup_Data;
			}
			set
			{
				if (_popup_Data == value)
				{
					return;
				}
				_popup_Data = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Popup_Settings")] 
		public gamebbScriptID_Variant Popup_Settings
		{
			get
			{
				if (_popup_Settings == null)
				{
					_popup_Settings = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Popup_Settings", cr2w, this);
				}
				return _popup_Settings;
			}
			set
			{
				if (_popup_Settings == value)
				{
					return;
				}
				_popup_Settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Controller_Disconnected")] 
		public gamebbScriptID_Bool Controller_Disconnected
		{
			get
			{
				if (_controller_Disconnected == null)
				{
					_controller_Disconnected = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Controller_Disconnected", cr2w, this);
				}
				return _controller_Disconnected;
			}
			set
			{
				if (_controller_Disconnected == value)
				{
					return;
				}
				_controller_Disconnected = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ActivityLog")] 
		public gamebbScriptID_Variant ActivityLog
		{
			get
			{
				if (_activityLog == null)
				{
					_activityLog = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActivityLog", cr2w, this);
				}
				return _activityLog;
			}
			set
			{
				if (_activityLog == value)
				{
					return;
				}
				_activityLog = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("RightWeaponRecordID")] 
		public gamebbScriptID_Variant RightWeaponRecordID
		{
			get
			{
				if (_rightWeaponRecordID == null)
				{
					_rightWeaponRecordID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "RightWeaponRecordID", cr2w, this);
				}
				return _rightWeaponRecordID;
			}
			set
			{
				if (_rightWeaponRecordID == value)
				{
					return;
				}
				_rightWeaponRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("LeftWeaponRecordID")] 
		public gamebbScriptID_Variant LeftWeaponRecordID
		{
			get
			{
				if (_leftWeaponRecordID == null)
				{
					_leftWeaponRecordID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "LeftWeaponRecordID", cr2w, this);
				}
				return _leftWeaponRecordID;
			}
			set
			{
				if (_leftWeaponRecordID == value)
				{
					return;
				}
				_leftWeaponRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("UIVendorContextRequest")] 
		public gamebbScriptID_Bool UIVendorContextRequest
		{
			get
			{
				if (_uIVendorContextRequest == null)
				{
					_uIVendorContextRequest = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UIVendorContextRequest", cr2w, this);
				}
				return _uIVendorContextRequest;
			}
			set
			{
				if (_uIVendorContextRequest == value)
				{
					return;
				}
				_uIVendorContextRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get
			{
				if (_uIjailbreakData == null)
				{
					_uIjailbreakData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "UIjailbreakData", cr2w, this);
				}
				return _uIjailbreakData;
			}
			set
			{
				if (_uIjailbreakData == value)
				{
					return;
				}
				_uIjailbreakData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("QuestTimerInitialDuration")] 
		public gamebbScriptID_Float QuestTimerInitialDuration
		{
			get
			{
				if (_questTimerInitialDuration == null)
				{
					_questTimerInitialDuration = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "QuestTimerInitialDuration", cr2w, this);
				}
				return _questTimerInitialDuration;
			}
			set
			{
				if (_questTimerInitialDuration == value)
				{
					return;
				}
				_questTimerInitialDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("QuestTimerCurrentDuration")] 
		public gamebbScriptID_Float QuestTimerCurrentDuration
		{
			get
			{
				if (_questTimerCurrentDuration == null)
				{
					_questTimerCurrentDuration = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "QuestTimerCurrentDuration", cr2w, this);
				}
				return _questTimerCurrentDuration;
			}
			set
			{
				if (_questTimerCurrentDuration == value)
				{
					return;
				}
				_questTimerCurrentDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Tutorial_EnableHighlight")] 
		public gamebbScriptID_Bool Tutorial_EnableHighlight
		{
			get
			{
				if (_tutorial_EnableHighlight == null)
				{
					_tutorial_EnableHighlight = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Tutorial_EnableHighlight", cr2w, this);
				}
				return _tutorial_EnableHighlight;
			}
			set
			{
				if (_tutorial_EnableHighlight == value)
				{
					return;
				}
				_tutorial_EnableHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("Tutorial_EntityRefToHighlight")] 
		public gamebbScriptID_Variant Tutorial_EntityRefToHighlight
		{
			get
			{
				if (_tutorial_EntityRefToHighlight == null)
				{
					_tutorial_EntityRefToHighlight = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Tutorial_EntityRefToHighlight", cr2w, this);
				}
				return _tutorial_EntityRefToHighlight;
			}
			set
			{
				if (_tutorial_EntityRefToHighlight == value)
				{
					return;
				}
				_tutorial_EntityRefToHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("WeaponSway")] 
		public gamebbScriptID_Vector2 WeaponSway
		{
			get
			{
				if (_weaponSway == null)
				{
					_weaponSway = (gamebbScriptID_Vector2) CR2WTypeManager.Create("gamebbScriptID_Vector2", "WeaponSway", cr2w, this);
				}
				return _weaponSway;
			}
			set
			{
				if (_weaponSway == value)
				{
					return;
				}
				_weaponSway = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("NotificationJournalHash")] 
		public gamebbScriptID_Int32 NotificationJournalHash
		{
			get
			{
				if (_notificationJournalHash == null)
				{
					_notificationJournalHash = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "NotificationJournalHash", cr2w, this);
				}
				return _notificationJournalHash;
			}
			set
			{
				if (_notificationJournalHash == value)
				{
					return;
				}
				_notificationJournalHash = value;
				PropertySet(this);
			}
		}

		public UIGameDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
