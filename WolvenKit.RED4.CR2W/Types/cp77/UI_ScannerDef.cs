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
			get => GetProperty(ref _scannables);
			set => SetProperty(ref _scannables, value);
		}

		[Ordinal(1)] 
		[RED("CurrentProgress")] 
		public gamebbScriptID_Float CurrentProgress
		{
			get => GetProperty(ref _currentProgress);
			set => SetProperty(ref _currentProgress, value);
		}

		[Ordinal(2)] 
		[RED("CurrentState")] 
		public gamebbScriptID_Variant CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		[Ordinal(3)] 
		[RED("ProgressBarText")] 
		public gamebbScriptID_String ProgressBarText
		{
			get => GetProperty(ref _progressBarText);
			set => SetProperty(ref _progressBarText, value);
		}

		[Ordinal(4)] 
		[RED("ScannedObject")] 
		public gamebbScriptID_EntityID ScannedObject
		{
			get => GetProperty(ref _scannedObject);
			set => SetProperty(ref _scannedObject, value);
		}

		[Ordinal(5)] 
		[RED("ScannerMode")] 
		public gamebbScriptID_Variant ScannerMode
		{
			get => GetProperty(ref _scannerMode);
			set => SetProperty(ref _scannerMode, value);
		}

		[Ordinal(6)] 
		[RED("scannerTooltip")] 
		public gamebbScriptID_Int32 ScannerTooltip
		{
			get => GetProperty(ref _scannerTooltip);
			set => SetProperty(ref _scannerTooltip, value);
		}

		[Ordinal(7)] 
		[RED("scannerData")] 
		public gamebbScriptID_Variant ScannerData
		{
			get => GetProperty(ref _scannerData);
			set => SetProperty(ref _scannerData, value);
		}

		[Ordinal(8)] 
		[RED("scannerObjectDistance")] 
		public gamebbScriptID_Float ScannerObjectDistance
		{
			get => GetProperty(ref _scannerObjectDistance);
			set => SetProperty(ref _scannerObjectDistance, value);
		}

		[Ordinal(9)] 
		[RED("scannerObjectStats")] 
		public gamebbScriptID_Variant ScannerObjectStats
		{
			get => GetProperty(ref _scannerObjectStats);
			set => SetProperty(ref _scannerObjectStats, value);
		}

		[Ordinal(10)] 
		[RED("scannerQuickHackActionId")] 
		public gamebbScriptID_Int32 ScannerQuickHackActionId
		{
			get => GetProperty(ref _scannerQuickHackActionId);
			set => SetProperty(ref _scannerQuickHackActionId, value);
		}

		[Ordinal(11)] 
		[RED("scannerQuickHackActionStarted")] 
		public gamebbScriptID_Bool ScannerQuickHackActionStarted
		{
			get => GetProperty(ref _scannerQuickHackActionStarted);
			set => SetProperty(ref _scannerQuickHackActionStarted, value);
		}

		[Ordinal(12)] 
		[RED("scannerQuickHackTime")] 
		public gamebbScriptID_Float ScannerQuickHackTime
		{
			get => GetProperty(ref _scannerQuickHackTime);
			set => SetProperty(ref _scannerQuickHackTime, value);
		}

		[Ordinal(13)] 
		[RED("exclusiveFocusActive")] 
		public gamebbScriptID_Bool ExclusiveFocusActive
		{
			get => GetProperty(ref _exclusiveFocusActive);
			set => SetProperty(ref _exclusiveFocusActive, value);
		}

		[Ordinal(14)] 
		[RED("LastTaggedTarget")] 
		public gamebbScriptID_Variant LastTaggedTarget
		{
			get => GetProperty(ref _lastTaggedTarget);
			set => SetProperty(ref _lastTaggedTarget, value);
		}

		[Ordinal(15)] 
		[RED("skillCheckInfo")] 
		public gamebbScriptID_Variant SkillCheckInfo
		{
			get => GetProperty(ref _skillCheckInfo);
			set => SetProperty(ref _skillCheckInfo, value);
		}

		[Ordinal(16)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get => GetProperty(ref _showHudHintMessege);
			set => SetProperty(ref _showHudHintMessege, value);
		}

		[Ordinal(17)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get => GetProperty(ref _hudHintMessegeContent);
			set => SetProperty(ref _hudHintMessegeContent, value);
		}

		[Ordinal(18)] 
		[RED("UIVisible")] 
		public gamebbScriptID_Bool UIVisible
		{
			get => GetProperty(ref _uIVisible);
			set => SetProperty(ref _uIVisible, value);
		}

		[Ordinal(19)] 
		[RED("ScannerLookAt")] 
		public gamebbScriptID_Bool ScannerLookAt
		{
			get => GetProperty(ref _scannerLookAt);
			set => SetProperty(ref _scannerLookAt, value);
		}

		public UI_ScannerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
