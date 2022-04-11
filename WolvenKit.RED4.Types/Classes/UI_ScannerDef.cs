using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ScannerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Scannables")] 
		public gamebbScriptID_Variant Scannables
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("CurrentProgress")] 
		public gamebbScriptID_Float CurrentProgress
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("CurrentState")] 
		public gamebbScriptID_Variant CurrentState
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("ProgressBarText")] 
		public gamebbScriptID_String ProgressBarText
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(4)] 
		[RED("ScannedObject")] 
		public gamebbScriptID_EntityID ScannedObject
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(5)] 
		[RED("ScannerMode")] 
		public gamebbScriptID_Variant ScannerMode
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(6)] 
		[RED("scannerTooltip")] 
		public gamebbScriptID_Int32 ScannerTooltip
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("scannerData")] 
		public gamebbScriptID_Variant ScannerData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(8)] 
		[RED("scannerObjectDistance")] 
		public gamebbScriptID_Float ScannerObjectDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(9)] 
		[RED("scannerObjectStats")] 
		public gamebbScriptID_Variant ScannerObjectStats
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("scannerQuickHackActionId")] 
		public gamebbScriptID_Int32 ScannerQuickHackActionId
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("scannerQuickHackActionStarted")] 
		public gamebbScriptID_Bool ScannerQuickHackActionStarted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(12)] 
		[RED("scannerQuickHackTime")] 
		public gamebbScriptID_Float ScannerQuickHackTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(13)] 
		[RED("exclusiveFocusActive")] 
		public gamebbScriptID_Bool ExclusiveFocusActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("LastTaggedTarget")] 
		public gamebbScriptID_Variant LastTaggedTarget
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("skillCheckInfo")] 
		public gamebbScriptID_Variant SkillCheckInfo
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(16)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(17)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(18)] 
		[RED("UIVisible")] 
		public gamebbScriptID_Bool UIVisible
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(19)] 
		[RED("ScannerLookAt")] 
		public gamebbScriptID_Bool ScannerLookAt
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_ScannerDef()
		{
			Scannables = new();
			CurrentProgress = new();
			CurrentState = new();
			ProgressBarText = new();
			ScannedObject = new();
			ScannerMode = new();
			ScannerTooltip = new();
			ScannerData = new();
			ScannerObjectDistance = new();
			ScannerObjectStats = new();
			ScannerQuickHackActionId = new();
			ScannerQuickHackActionStarted = new();
			ScannerQuickHackTime = new();
			ExclusiveFocusActive = new();
			LastTaggedTarget = new();
			SkillCheckInfo = new();
			ShowHudHintMessege = new();
			HudHintMessegeContent = new();
			UIVisible = new();
			ScannerLookAt = new();
		}
	}
}
