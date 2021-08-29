using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManager : gameNativeHudManager
	{
		private CEnum<HUDState> _state;
		private CEnum<ActiveMode> _activeMode;
		private gameDelayID _instructionsDelayID;
		private CBool _isBraindanceActive;
		private CArray<CHandle<HUDModule>> _modulesArray;
		private CHandle<ScannerModule> _scanner;
		private CHandle<BraindanceModule> _braindanceModule;
		private CHandle<HighlightModule> _highlightsModule;
		private CHandle<IconsModule> _iconsModule;
		private CHandle<CrosshairModule> _crosshair;
		private CHandle<AimAssistModule> _aimAssist;
		private CHandle<QuickhackModule> _quickhackModule;
		private CWeakHandle<gameHudActor> _lastTarget;
		private CWeakHandle<gameHudActor> _currentTarget;
		private entEntityID _lookAtTarget;
		private entEntityID _scannerTarget;
		private entEntityID _nameplateTarget;
		private entEntityID _quickHackTarget;
		private entEntityID _lootedTarget;
		private CWeakHandle<gameScanningController> _scannningController;
		private CBool _uiScannerVisible;
		private CBool _uiQuickHackVisible;
		private CBool _quickHackDescriptionVisible;
		private CWeakHandle<gametargetingTargetingSystem> _targetingSystem;
		private CWeakHandle<gameVisionModeSystem> _visionModeSystem;
		private CBool _isHackingMinigameActive;
		private CHandle<redCallbackObject> _stickInputListener;
		private CHandle<redCallbackObject> _quickHackPanelListener;
		private CHandle<redCallbackObject> _carriedBodyListener;
		private CHandle<redCallbackObject> _grappleListener;
		private gameaimAssistAimRequest _lookatRequest;
		private CBool _isQHackUIInputLocked;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CHandle<redCallbackObject> _playerTargetCallbackID;
		private CHandle<redCallbackObject> _braindanceToggleCallbackID;
		private CHandle<redCallbackObject> _nameplateCallbackID;
		private CHandle<redCallbackObject> _visionModeChangedCallbackID;
		private CHandle<redCallbackObject> _scannerTargetCallbackID;
		private CHandle<redCallbackObject> _hackingMinigameCallbackID;
		private CHandle<redCallbackObject> _uiScannerVisibleCallbackID;
		private CHandle<redCallbackObject> _uiQuickHackVisibleCallbackID;
		private CHandle<redCallbackObject> _lootDataCallbackID;
		private gameDelayID _pulseDelayID;
		private Vector4 _previousStickInput;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<HUDState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("activeMode")] 
		public CEnum<ActiveMode> ActiveMode
		{
			get => GetProperty(ref _activeMode);
			set => SetProperty(ref _activeMode, value);
		}

		[Ordinal(2)] 
		[RED("instructionsDelayID")] 
		public gameDelayID InstructionsDelayID
		{
			get => GetProperty(ref _instructionsDelayID);
			set => SetProperty(ref _instructionsDelayID, value);
		}

		[Ordinal(3)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetProperty(ref _isBraindanceActive);
			set => SetProperty(ref _isBraindanceActive, value);
		}

		[Ordinal(4)] 
		[RED("modulesArray")] 
		public CArray<CHandle<HUDModule>> ModulesArray
		{
			get => GetProperty(ref _modulesArray);
			set => SetProperty(ref _modulesArray, value);
		}

		[Ordinal(5)] 
		[RED("scanner")] 
		public CHandle<ScannerModule> Scanner
		{
			get => GetProperty(ref _scanner);
			set => SetProperty(ref _scanner, value);
		}

		[Ordinal(6)] 
		[RED("braindanceModule")] 
		public CHandle<BraindanceModule> BraindanceModule
		{
			get => GetProperty(ref _braindanceModule);
			set => SetProperty(ref _braindanceModule, value);
		}

		[Ordinal(7)] 
		[RED("highlightsModule")] 
		public CHandle<HighlightModule> HighlightsModule
		{
			get => GetProperty(ref _highlightsModule);
			set => SetProperty(ref _highlightsModule, value);
		}

		[Ordinal(8)] 
		[RED("iconsModule")] 
		public CHandle<IconsModule> IconsModule
		{
			get => GetProperty(ref _iconsModule);
			set => SetProperty(ref _iconsModule, value);
		}

		[Ordinal(9)] 
		[RED("crosshair")] 
		public CHandle<CrosshairModule> Crosshair
		{
			get => GetProperty(ref _crosshair);
			set => SetProperty(ref _crosshair, value);
		}

		[Ordinal(10)] 
		[RED("aimAssist")] 
		public CHandle<AimAssistModule> AimAssist
		{
			get => GetProperty(ref _aimAssist);
			set => SetProperty(ref _aimAssist, value);
		}

		[Ordinal(11)] 
		[RED("quickhackModule")] 
		public CHandle<QuickhackModule> QuickhackModule
		{
			get => GetProperty(ref _quickhackModule);
			set => SetProperty(ref _quickhackModule, value);
		}

		[Ordinal(12)] 
		[RED("lastTarget")] 
		public CWeakHandle<gameHudActor> LastTarget
		{
			get => GetProperty(ref _lastTarget);
			set => SetProperty(ref _lastTarget, value);
		}

		[Ordinal(13)] 
		[RED("currentTarget")] 
		public CWeakHandle<gameHudActor> CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(14)] 
		[RED("lookAtTarget")] 
		public entEntityID LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(15)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get => GetProperty(ref _scannerTarget);
			set => SetProperty(ref _scannerTarget, value);
		}

		[Ordinal(16)] 
		[RED("nameplateTarget")] 
		public entEntityID NameplateTarget
		{
			get => GetProperty(ref _nameplateTarget);
			set => SetProperty(ref _nameplateTarget, value);
		}

		[Ordinal(17)] 
		[RED("quickHackTarget")] 
		public entEntityID QuickHackTarget
		{
			get => GetProperty(ref _quickHackTarget);
			set => SetProperty(ref _quickHackTarget, value);
		}

		[Ordinal(18)] 
		[RED("lootedTarget")] 
		public entEntityID LootedTarget
		{
			get => GetProperty(ref _lootedTarget);
			set => SetProperty(ref _lootedTarget, value);
		}

		[Ordinal(19)] 
		[RED("scannningController")] 
		public CWeakHandle<gameScanningController> ScannningController
		{
			get => GetProperty(ref _scannningController);
			set => SetProperty(ref _scannningController, value);
		}

		[Ordinal(20)] 
		[RED("uiScannerVisible")] 
		public CBool UiScannerVisible
		{
			get => GetProperty(ref _uiScannerVisible);
			set => SetProperty(ref _uiScannerVisible, value);
		}

		[Ordinal(21)] 
		[RED("uiQuickHackVisible")] 
		public CBool UiQuickHackVisible
		{
			get => GetProperty(ref _uiQuickHackVisible);
			set => SetProperty(ref _uiQuickHackVisible, value);
		}

		[Ordinal(22)] 
		[RED("quickHackDescriptionVisible")] 
		public CBool QuickHackDescriptionVisible
		{
			get => GetProperty(ref _quickHackDescriptionVisible);
			set => SetProperty(ref _quickHackDescriptionVisible, value);
		}

		[Ordinal(23)] 
		[RED("targetingSystem")] 
		public CWeakHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get => GetProperty(ref _targetingSystem);
			set => SetProperty(ref _targetingSystem, value);
		}

		[Ordinal(24)] 
		[RED("visionModeSystem")] 
		public CWeakHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetProperty(ref _visionModeSystem);
			set => SetProperty(ref _visionModeSystem, value);
		}

		[Ordinal(25)] 
		[RED("isHackingMinigameActive")] 
		public CBool IsHackingMinigameActive
		{
			get => GetProperty(ref _isHackingMinigameActive);
			set => SetProperty(ref _isHackingMinigameActive, value);
		}

		[Ordinal(26)] 
		[RED("stickInputListener")] 
		public CHandle<redCallbackObject> StickInputListener
		{
			get => GetProperty(ref _stickInputListener);
			set => SetProperty(ref _stickInputListener, value);
		}

		[Ordinal(27)] 
		[RED("quickHackPanelListener")] 
		public CHandle<redCallbackObject> QuickHackPanelListener
		{
			get => GetProperty(ref _quickHackPanelListener);
			set => SetProperty(ref _quickHackPanelListener, value);
		}

		[Ordinal(28)] 
		[RED("carriedBodyListener")] 
		public CHandle<redCallbackObject> CarriedBodyListener
		{
			get => GetProperty(ref _carriedBodyListener);
			set => SetProperty(ref _carriedBodyListener, value);
		}

		[Ordinal(29)] 
		[RED("grappleListener")] 
		public CHandle<redCallbackObject> GrappleListener
		{
			get => GetProperty(ref _grappleListener);
			set => SetProperty(ref _grappleListener, value);
		}

		[Ordinal(30)] 
		[RED("lookatRequest")] 
		public gameaimAssistAimRequest LookatRequest
		{
			get => GetProperty(ref _lookatRequest);
			set => SetProperty(ref _lookatRequest, value);
		}

		[Ordinal(31)] 
		[RED("isQHackUIInputLocked")] 
		public CBool IsQHackUIInputLocked
		{
			get => GetProperty(ref _isQHackUIInputLocked);
			set => SetProperty(ref _isQHackUIInputLocked, value);
		}

		[Ordinal(32)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(33)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(34)] 
		[RED("playerTargetCallbackID")] 
		public CHandle<redCallbackObject> PlayerTargetCallbackID
		{
			get => GetProperty(ref _playerTargetCallbackID);
			set => SetProperty(ref _playerTargetCallbackID, value);
		}

		[Ordinal(35)] 
		[RED("braindanceToggleCallbackID")] 
		public CHandle<redCallbackObject> BraindanceToggleCallbackID
		{
			get => GetProperty(ref _braindanceToggleCallbackID);
			set => SetProperty(ref _braindanceToggleCallbackID, value);
		}

		[Ordinal(36)] 
		[RED("nameplateCallbackID")] 
		public CHandle<redCallbackObject> NameplateCallbackID
		{
			get => GetProperty(ref _nameplateCallbackID);
			set => SetProperty(ref _nameplateCallbackID, value);
		}

		[Ordinal(37)] 
		[RED("visionModeChangedCallbackID")] 
		public CHandle<redCallbackObject> VisionModeChangedCallbackID
		{
			get => GetProperty(ref _visionModeChangedCallbackID);
			set => SetProperty(ref _visionModeChangedCallbackID, value);
		}

		[Ordinal(38)] 
		[RED("scannerTargetCallbackID")] 
		public CHandle<redCallbackObject> ScannerTargetCallbackID
		{
			get => GetProperty(ref _scannerTargetCallbackID);
			set => SetProperty(ref _scannerTargetCallbackID, value);
		}

		[Ordinal(39)] 
		[RED("hackingMinigameCallbackID")] 
		public CHandle<redCallbackObject> HackingMinigameCallbackID
		{
			get => GetProperty(ref _hackingMinigameCallbackID);
			set => SetProperty(ref _hackingMinigameCallbackID, value);
		}

		[Ordinal(40)] 
		[RED("uiScannerVisibleCallbackID")] 
		public CHandle<redCallbackObject> UiScannerVisibleCallbackID
		{
			get => GetProperty(ref _uiScannerVisibleCallbackID);
			set => SetProperty(ref _uiScannerVisibleCallbackID, value);
		}

		[Ordinal(41)] 
		[RED("uiQuickHackVisibleCallbackID")] 
		public CHandle<redCallbackObject> UiQuickHackVisibleCallbackID
		{
			get => GetProperty(ref _uiQuickHackVisibleCallbackID);
			set => SetProperty(ref _uiQuickHackVisibleCallbackID, value);
		}

		[Ordinal(42)] 
		[RED("lootDataCallbackID")] 
		public CHandle<redCallbackObject> LootDataCallbackID
		{
			get => GetProperty(ref _lootDataCallbackID);
			set => SetProperty(ref _lootDataCallbackID, value);
		}

		[Ordinal(43)] 
		[RED("pulseDelayID")] 
		public gameDelayID PulseDelayID
		{
			get => GetProperty(ref _pulseDelayID);
			set => SetProperty(ref _pulseDelayID, value);
		}

		[Ordinal(44)] 
		[RED("previousStickInput")] 
		public Vector4 PreviousStickInput
		{
			get => GetProperty(ref _previousStickInput);
			set => SetProperty(ref _previousStickInput, value);
		}
	}
}
