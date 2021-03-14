using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ScannerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _scannables;
		private gamebbScriptID_Float _currentProgress;
		private gamebbScriptID_Variant _currentState;
		private gamebbScriptID_String _progressBarText;
		private gamebbScriptID_EntityID _scannedObject;
		private gamebbScriptID_Variant _scannerMode;
		private gamebbScriptID_Int32 _scannerTooltip;
		private gamebbScriptID_Variant _scannerData;
		private gamebbScriptID_Float _scannerObjectDistance;
		private gamebbScriptID_Variant _scannerObjectStats;
		private gamebbScriptID_Int32 _scannerQuickHackActionId;
		private gamebbScriptID_Bool _scannerQuickHackActionStarted;
		private gamebbScriptID_Float _scannerQuickHackTime;
		private gamebbScriptID_Bool _exclusiveFocusActive;
		private gamebbScriptID_Variant _lastTaggedTarget;
		private gamebbScriptID_Variant _skillCheckInfo;
		private gamebbScriptID_Bool _showHudHintMessege;
		private gamebbScriptID_String _hudHintMessegeContent;
		private gamebbScriptID_Bool _uIVisible;
		private gamebbScriptID_Bool _scannerLookAt;

		[Ordinal(0)] 
		[RED("Scannables")] 
		public gamebbScriptID_Variant Scannables
		{
			get
			{
				if (_scannables == null)
				{
					_scannables = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Scannables", cr2w, this);
				}
				return _scannables;
			}
			set
			{
				if (_scannables == value)
				{
					return;
				}
				_scannables = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CurrentProgress")] 
		public gamebbScriptID_Float CurrentProgress
		{
			get
			{
				if (_currentProgress == null)
				{
					_currentProgress = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "CurrentProgress", cr2w, this);
				}
				return _currentProgress;
			}
			set
			{
				if (_currentProgress == value)
				{
					return;
				}
				_currentProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CurrentState")] 
		public gamebbScriptID_Variant CurrentState
		{
			get
			{
				if (_currentState == null)
				{
					_currentState = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "CurrentState", cr2w, this);
				}
				return _currentState;
			}
			set
			{
				if (_currentState == value)
				{
					return;
				}
				_currentState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ProgressBarText")] 
		public gamebbScriptID_String ProgressBarText
		{
			get
			{
				if (_progressBarText == null)
				{
					_progressBarText = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "ProgressBarText", cr2w, this);
				}
				return _progressBarText;
			}
			set
			{
				if (_progressBarText == value)
				{
					return;
				}
				_progressBarText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ScannedObject")] 
		public gamebbScriptID_EntityID ScannedObject
		{
			get
			{
				if (_scannedObject == null)
				{
					_scannedObject = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "ScannedObject", cr2w, this);
				}
				return _scannedObject;
			}
			set
			{
				if (_scannedObject == value)
				{
					return;
				}
				_scannedObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ScannerMode")] 
		public gamebbScriptID_Variant ScannerMode
		{
			get
			{
				if (_scannerMode == null)
				{
					_scannerMode = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerMode", cr2w, this);
				}
				return _scannerMode;
			}
			set
			{
				if (_scannerMode == value)
				{
					return;
				}
				_scannerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scannerTooltip")] 
		public gamebbScriptID_Int32 ScannerTooltip
		{
			get
			{
				if (_scannerTooltip == null)
				{
					_scannerTooltip = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "scannerTooltip", cr2w, this);
				}
				return _scannerTooltip;
			}
			set
			{
				if (_scannerTooltip == value)
				{
					return;
				}
				_scannerTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("scannerData")] 
		public gamebbScriptID_Variant ScannerData
		{
			get
			{
				if (_scannerData == null)
				{
					_scannerData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "scannerData", cr2w, this);
				}
				return _scannerData;
			}
			set
			{
				if (_scannerData == value)
				{
					return;
				}
				_scannerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("scannerObjectDistance")] 
		public gamebbScriptID_Float ScannerObjectDistance
		{
			get
			{
				if (_scannerObjectDistance == null)
				{
					_scannerObjectDistance = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "scannerObjectDistance", cr2w, this);
				}
				return _scannerObjectDistance;
			}
			set
			{
				if (_scannerObjectDistance == value)
				{
					return;
				}
				_scannerObjectDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("scannerObjectStats")] 
		public gamebbScriptID_Variant ScannerObjectStats
		{
			get
			{
				if (_scannerObjectStats == null)
				{
					_scannerObjectStats = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "scannerObjectStats", cr2w, this);
				}
				return _scannerObjectStats;
			}
			set
			{
				if (_scannerObjectStats == value)
				{
					return;
				}
				_scannerObjectStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("scannerQuickHackActionId")] 
		public gamebbScriptID_Int32 ScannerQuickHackActionId
		{
			get
			{
				if (_scannerQuickHackActionId == null)
				{
					_scannerQuickHackActionId = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "scannerQuickHackActionId", cr2w, this);
				}
				return _scannerQuickHackActionId;
			}
			set
			{
				if (_scannerQuickHackActionId == value)
				{
					return;
				}
				_scannerQuickHackActionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scannerQuickHackActionStarted")] 
		public gamebbScriptID_Bool ScannerQuickHackActionStarted
		{
			get
			{
				if (_scannerQuickHackActionStarted == null)
				{
					_scannerQuickHackActionStarted = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "scannerQuickHackActionStarted", cr2w, this);
				}
				return _scannerQuickHackActionStarted;
			}
			set
			{
				if (_scannerQuickHackActionStarted == value)
				{
					return;
				}
				_scannerQuickHackActionStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scannerQuickHackTime")] 
		public gamebbScriptID_Float ScannerQuickHackTime
		{
			get
			{
				if (_scannerQuickHackTime == null)
				{
					_scannerQuickHackTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "scannerQuickHackTime", cr2w, this);
				}
				return _scannerQuickHackTime;
			}
			set
			{
				if (_scannerQuickHackTime == value)
				{
					return;
				}
				_scannerQuickHackTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("exclusiveFocusActive")] 
		public gamebbScriptID_Bool ExclusiveFocusActive
		{
			get
			{
				if (_exclusiveFocusActive == null)
				{
					_exclusiveFocusActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "exclusiveFocusActive", cr2w, this);
				}
				return _exclusiveFocusActive;
			}
			set
			{
				if (_exclusiveFocusActive == value)
				{
					return;
				}
				_exclusiveFocusActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("LastTaggedTarget")] 
		public gamebbScriptID_Variant LastTaggedTarget
		{
			get
			{
				if (_lastTaggedTarget == null)
				{
					_lastTaggedTarget = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "LastTaggedTarget", cr2w, this);
				}
				return _lastTaggedTarget;
			}
			set
			{
				if (_lastTaggedTarget == value)
				{
					return;
				}
				_lastTaggedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("skillCheckInfo")] 
		public gamebbScriptID_Variant SkillCheckInfo
		{
			get
			{
				if (_skillCheckInfo == null)
				{
					_skillCheckInfo = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "skillCheckInfo", cr2w, this);
				}
				return _skillCheckInfo;
			}
			set
			{
				if (_skillCheckInfo == value)
				{
					return;
				}
				_skillCheckInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get
			{
				if (_showHudHintMessege == null)
				{
					_showHudHintMessege = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ShowHudHintMessege", cr2w, this);
				}
				return _showHudHintMessege;
			}
			set
			{
				if (_showHudHintMessege == value)
				{
					return;
				}
				_showHudHintMessege = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get
			{
				if (_hudHintMessegeContent == null)
				{
					_hudHintMessegeContent = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "HudHintMessegeContent", cr2w, this);
				}
				return _hudHintMessegeContent;
			}
			set
			{
				if (_hudHintMessegeContent == value)
				{
					return;
				}
				_hudHintMessegeContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("UIVisible")] 
		public gamebbScriptID_Bool UIVisible
		{
			get
			{
				if (_uIVisible == null)
				{
					_uIVisible = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UIVisible", cr2w, this);
				}
				return _uIVisible;
			}
			set
			{
				if (_uIVisible == value)
				{
					return;
				}
				_uIVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ScannerLookAt")] 
		public gamebbScriptID_Bool ScannerLookAt
		{
			get
			{
				if (_scannerLookAt == null)
				{
					_scannerLookAt = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ScannerLookAt", cr2w, this);
				}
				return _scannerLookAt;
			}
			set
			{
				if (_scannerLookAt == value)
				{
					return;
				}
				_scannerLookAt = value;
				PropertySet(this);
			}
		}

		public UI_ScannerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
