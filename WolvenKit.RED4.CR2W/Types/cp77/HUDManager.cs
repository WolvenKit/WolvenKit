using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManager : gameNativeHudManager
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
		private wCHandle<gameHudActor> _lastTarget;
		private wCHandle<gameHudActor> _currentTarget;
		private entEntityID _lookAtTarget;
		private entEntityID _scannerTarget;
		private entEntityID _nameplateTarget;
		private entEntityID _quickHackTarget;
		private entEntityID _lootedTarget;
		private wCHandle<gameScanningController> _scannningController;
		private CBool _uiScannerVisible;
		private CBool _uiQuickHackVisible;
		private CBool _quickHackDescriptionVisible;
		private wCHandle<gametargetingTargetingSystem> _targetingSystem;
		private wCHandle<gameVisionModeSystem> _visionModeSystem;
		private CBool _isHackingMinigameActive;
		private CUInt32 _stickInputListener;
		private CUInt32 _quickHackPanelListener;
		private CUInt32 _carriedBodyListener;
		private CUInt32 _grappleListener;
		private gameaimAssistAimRequest _lookatRequest;
		private CBool _isQHackUIInputLocked;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CUInt32 _playerTargetCallbackID;
		private CUInt32 _braindanceToggleCallbackID;
		private CUInt32 _nameplateCallbackID;
		private CUInt32 _visionModeChangedCallbackID;
		private CUInt32 _scannerTargetCallbackID;
		private CUInt32 _hackingMinigameCallbackID;
		private CUInt32 _uiScannerVisibleCallbackID;
		private CUInt32 _uiQuickHackVisibleCallbackID;
		private CUInt32 _lootDataCallbackID;
		private gameDelayID _pulseDelayID;
		private Vector4 _previousStickInput;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<HUDState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<HUDState>) CR2WTypeManager.Create("HUDState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activeMode")] 
		public CEnum<ActiveMode> ActiveMode
		{
			get
			{
				if (_activeMode == null)
				{
					_activeMode = (CEnum<ActiveMode>) CR2WTypeManager.Create("ActiveMode", "activeMode", cr2w, this);
				}
				return _activeMode;
			}
			set
			{
				if (_activeMode == value)
				{
					return;
				}
				_activeMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instructionsDelayID")] 
		public gameDelayID InstructionsDelayID
		{
			get
			{
				if (_instructionsDelayID == null)
				{
					_instructionsDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "instructionsDelayID", cr2w, this);
				}
				return _instructionsDelayID;
			}
			set
			{
				if (_instructionsDelayID == value)
				{
					return;
				}
				_instructionsDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get
			{
				if (_isBraindanceActive == null)
				{
					_isBraindanceActive = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceActive", cr2w, this);
				}
				return _isBraindanceActive;
			}
			set
			{
				if (_isBraindanceActive == value)
				{
					return;
				}
				_isBraindanceActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("modulesArray")] 
		public CArray<CHandle<HUDModule>> ModulesArray
		{
			get
			{
				if (_modulesArray == null)
				{
					_modulesArray = (CArray<CHandle<HUDModule>>) CR2WTypeManager.Create("array:handle:HUDModule", "modulesArray", cr2w, this);
				}
				return _modulesArray;
			}
			set
			{
				if (_modulesArray == value)
				{
					return;
				}
				_modulesArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scanner")] 
		public CHandle<ScannerModule> Scanner
		{
			get
			{
				if (_scanner == null)
				{
					_scanner = (CHandle<ScannerModule>) CR2WTypeManager.Create("handle:ScannerModule", "scanner", cr2w, this);
				}
				return _scanner;
			}
			set
			{
				if (_scanner == value)
				{
					return;
				}
				_scanner = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("braindanceModule")] 
		public CHandle<BraindanceModule> BraindanceModule
		{
			get
			{
				if (_braindanceModule == null)
				{
					_braindanceModule = (CHandle<BraindanceModule>) CR2WTypeManager.Create("handle:BraindanceModule", "braindanceModule", cr2w, this);
				}
				return _braindanceModule;
			}
			set
			{
				if (_braindanceModule == value)
				{
					return;
				}
				_braindanceModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("highlightsModule")] 
		public CHandle<HighlightModule> HighlightsModule
		{
			get
			{
				if (_highlightsModule == null)
				{
					_highlightsModule = (CHandle<HighlightModule>) CR2WTypeManager.Create("handle:HighlightModule", "highlightsModule", cr2w, this);
				}
				return _highlightsModule;
			}
			set
			{
				if (_highlightsModule == value)
				{
					return;
				}
				_highlightsModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("iconsModule")] 
		public CHandle<IconsModule> IconsModule
		{
			get
			{
				if (_iconsModule == null)
				{
					_iconsModule = (CHandle<IconsModule>) CR2WTypeManager.Create("handle:IconsModule", "iconsModule", cr2w, this);
				}
				return _iconsModule;
			}
			set
			{
				if (_iconsModule == value)
				{
					return;
				}
				_iconsModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("crosshair")] 
		public CHandle<CrosshairModule> Crosshair
		{
			get
			{
				if (_crosshair == null)
				{
					_crosshair = (CHandle<CrosshairModule>) CR2WTypeManager.Create("handle:CrosshairModule", "crosshair", cr2w, this);
				}
				return _crosshair;
			}
			set
			{
				if (_crosshair == value)
				{
					return;
				}
				_crosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("aimAssist")] 
		public CHandle<AimAssistModule> AimAssist
		{
			get
			{
				if (_aimAssist == null)
				{
					_aimAssist = (CHandle<AimAssistModule>) CR2WTypeManager.Create("handle:AimAssistModule", "aimAssist", cr2w, this);
				}
				return _aimAssist;
			}
			set
			{
				if (_aimAssist == value)
				{
					return;
				}
				_aimAssist = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("quickhackModule")] 
		public CHandle<QuickhackModule> QuickhackModule
		{
			get
			{
				if (_quickhackModule == null)
				{
					_quickhackModule = (CHandle<QuickhackModule>) CR2WTypeManager.Create("handle:QuickhackModule", "quickhackModule", cr2w, this);
				}
				return _quickhackModule;
			}
			set
			{
				if (_quickhackModule == value)
				{
					return;
				}
				_quickhackModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lastTarget")] 
		public wCHandle<gameHudActor> LastTarget
		{
			get
			{
				if (_lastTarget == null)
				{
					_lastTarget = (wCHandle<gameHudActor>) CR2WTypeManager.Create("whandle:gameHudActor", "lastTarget", cr2w, this);
				}
				return _lastTarget;
			}
			set
			{
				if (_lastTarget == value)
				{
					return;
				}
				_lastTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("currentTarget")] 
		public wCHandle<gameHudActor> CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (wCHandle<gameHudActor>) CR2WTypeManager.Create("whandle:gameHudActor", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lookAtTarget")] 
		public entEntityID LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get
			{
				if (_scannerTarget == null)
				{
					_scannerTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "scannerTarget", cr2w, this);
				}
				return _scannerTarget;
			}
			set
			{
				if (_scannerTarget == value)
				{
					return;
				}
				_scannerTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("nameplateTarget")] 
		public entEntityID NameplateTarget
		{
			get
			{
				if (_nameplateTarget == null)
				{
					_nameplateTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "nameplateTarget", cr2w, this);
				}
				return _nameplateTarget;
			}
			set
			{
				if (_nameplateTarget == value)
				{
					return;
				}
				_nameplateTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("quickHackTarget")] 
		public entEntityID QuickHackTarget
		{
			get
			{
				if (_quickHackTarget == null)
				{
					_quickHackTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "quickHackTarget", cr2w, this);
				}
				return _quickHackTarget;
			}
			set
			{
				if (_quickHackTarget == value)
				{
					return;
				}
				_quickHackTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("lootedTarget")] 
		public entEntityID LootedTarget
		{
			get
			{
				if (_lootedTarget == null)
				{
					_lootedTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "lootedTarget", cr2w, this);
				}
				return _lootedTarget;
			}
			set
			{
				if (_lootedTarget == value)
				{
					return;
				}
				_lootedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("scannningController")] 
		public wCHandle<gameScanningController> ScannningController
		{
			get
			{
				if (_scannningController == null)
				{
					_scannningController = (wCHandle<gameScanningController>) CR2WTypeManager.Create("whandle:gameScanningController", "scannningController", cr2w, this);
				}
				return _scannningController;
			}
			set
			{
				if (_scannningController == value)
				{
					return;
				}
				_scannningController = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("uiScannerVisible")] 
		public CBool UiScannerVisible
		{
			get
			{
				if (_uiScannerVisible == null)
				{
					_uiScannerVisible = (CBool) CR2WTypeManager.Create("Bool", "uiScannerVisible", cr2w, this);
				}
				return _uiScannerVisible;
			}
			set
			{
				if (_uiScannerVisible == value)
				{
					return;
				}
				_uiScannerVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("uiQuickHackVisible")] 
		public CBool UiQuickHackVisible
		{
			get
			{
				if (_uiQuickHackVisible == null)
				{
					_uiQuickHackVisible = (CBool) CR2WTypeManager.Create("Bool", "uiQuickHackVisible", cr2w, this);
				}
				return _uiQuickHackVisible;
			}
			set
			{
				if (_uiQuickHackVisible == value)
				{
					return;
				}
				_uiQuickHackVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("quickHackDescriptionVisible")] 
		public CBool QuickHackDescriptionVisible
		{
			get
			{
				if (_quickHackDescriptionVisible == null)
				{
					_quickHackDescriptionVisible = (CBool) CR2WTypeManager.Create("Bool", "quickHackDescriptionVisible", cr2w, this);
				}
				return _quickHackDescriptionVisible;
			}
			set
			{
				if (_quickHackDescriptionVisible == value)
				{
					return;
				}
				_quickHackDescriptionVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("targetingSystem")] 
		public wCHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get
			{
				if (_targetingSystem == null)
				{
					_targetingSystem = (wCHandle<gametargetingTargetingSystem>) CR2WTypeManager.Create("whandle:gametargetingTargetingSystem", "targetingSystem", cr2w, this);
				}
				return _targetingSystem;
			}
			set
			{
				if (_targetingSystem == value)
				{
					return;
				}
				_targetingSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("visionModeSystem")] 
		public wCHandle<gameVisionModeSystem> VisionModeSystem
		{
			get
			{
				if (_visionModeSystem == null)
				{
					_visionModeSystem = (wCHandle<gameVisionModeSystem>) CR2WTypeManager.Create("whandle:gameVisionModeSystem", "visionModeSystem", cr2w, this);
				}
				return _visionModeSystem;
			}
			set
			{
				if (_visionModeSystem == value)
				{
					return;
				}
				_visionModeSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isHackingMinigameActive")] 
		public CBool IsHackingMinigameActive
		{
			get
			{
				if (_isHackingMinigameActive == null)
				{
					_isHackingMinigameActive = (CBool) CR2WTypeManager.Create("Bool", "isHackingMinigameActive", cr2w, this);
				}
				return _isHackingMinigameActive;
			}
			set
			{
				if (_isHackingMinigameActive == value)
				{
					return;
				}
				_isHackingMinigameActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("stickInputListener")] 
		public CUInt32 StickInputListener
		{
			get
			{
				if (_stickInputListener == null)
				{
					_stickInputListener = (CUInt32) CR2WTypeManager.Create("Uint32", "stickInputListener", cr2w, this);
				}
				return _stickInputListener;
			}
			set
			{
				if (_stickInputListener == value)
				{
					return;
				}
				_stickInputListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("quickHackPanelListener")] 
		public CUInt32 QuickHackPanelListener
		{
			get
			{
				if (_quickHackPanelListener == null)
				{
					_quickHackPanelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "quickHackPanelListener", cr2w, this);
				}
				return _quickHackPanelListener;
			}
			set
			{
				if (_quickHackPanelListener == value)
				{
					return;
				}
				_quickHackPanelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("carriedBodyListener")] 
		public CUInt32 CarriedBodyListener
		{
			get
			{
				if (_carriedBodyListener == null)
				{
					_carriedBodyListener = (CUInt32) CR2WTypeManager.Create("Uint32", "carriedBodyListener", cr2w, this);
				}
				return _carriedBodyListener;
			}
			set
			{
				if (_carriedBodyListener == value)
				{
					return;
				}
				_carriedBodyListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("grappleListener")] 
		public CUInt32 GrappleListener
		{
			get
			{
				if (_grappleListener == null)
				{
					_grappleListener = (CUInt32) CR2WTypeManager.Create("Uint32", "grappleListener", cr2w, this);
				}
				return _grappleListener;
			}
			set
			{
				if (_grappleListener == value)
				{
					return;
				}
				_grappleListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("lookatRequest")] 
		public gameaimAssistAimRequest LookatRequest
		{
			get
			{
				if (_lookatRequest == null)
				{
					_lookatRequest = (gameaimAssistAimRequest) CR2WTypeManager.Create("gameaimAssistAimRequest", "lookatRequest", cr2w, this);
				}
				return _lookatRequest;
			}
			set
			{
				if (_lookatRequest == value)
				{
					return;
				}
				_lookatRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isQHackUIInputLocked")] 
		public CBool IsQHackUIInputLocked
		{
			get
			{
				if (_isQHackUIInputLocked == null)
				{
					_isQHackUIInputLocked = (CBool) CR2WTypeManager.Create("Bool", "isQHackUIInputLocked", cr2w, this);
				}
				return _isQHackUIInputLocked;
			}
			set
			{
				if (_isQHackUIInputLocked == value)
				{
					return;
				}
				_isQHackUIInputLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get
			{
				if (_playerAttachedCallbackID == null)
				{
					_playerAttachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerAttachedCallbackID", cr2w, this);
				}
				return _playerAttachedCallbackID;
			}
			set
			{
				if (_playerAttachedCallbackID == value)
				{
					return;
				}
				_playerAttachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get
			{
				if (_playerDetachedCallbackID == null)
				{
					_playerDetachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerDetachedCallbackID", cr2w, this);
				}
				return _playerDetachedCallbackID;
			}
			set
			{
				if (_playerDetachedCallbackID == value)
				{
					return;
				}
				_playerDetachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("playerTargetCallbackID")] 
		public CUInt32 PlayerTargetCallbackID
		{
			get
			{
				if (_playerTargetCallbackID == null)
				{
					_playerTargetCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerTargetCallbackID", cr2w, this);
				}
				return _playerTargetCallbackID;
			}
			set
			{
				if (_playerTargetCallbackID == value)
				{
					return;
				}
				_playerTargetCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("braindanceToggleCallbackID")] 
		public CUInt32 BraindanceToggleCallbackID
		{
			get
			{
				if (_braindanceToggleCallbackID == null)
				{
					_braindanceToggleCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "braindanceToggleCallbackID", cr2w, this);
				}
				return _braindanceToggleCallbackID;
			}
			set
			{
				if (_braindanceToggleCallbackID == value)
				{
					return;
				}
				_braindanceToggleCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("nameplateCallbackID")] 
		public CUInt32 NameplateCallbackID
		{
			get
			{
				if (_nameplateCallbackID == null)
				{
					_nameplateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "nameplateCallbackID", cr2w, this);
				}
				return _nameplateCallbackID;
			}
			set
			{
				if (_nameplateCallbackID == value)
				{
					return;
				}
				_nameplateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("visionModeChangedCallbackID")] 
		public CUInt32 VisionModeChangedCallbackID
		{
			get
			{
				if (_visionModeChangedCallbackID == null)
				{
					_visionModeChangedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "visionModeChangedCallbackID", cr2w, this);
				}
				return _visionModeChangedCallbackID;
			}
			set
			{
				if (_visionModeChangedCallbackID == value)
				{
					return;
				}
				_visionModeChangedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("scannerTargetCallbackID")] 
		public CUInt32 ScannerTargetCallbackID
		{
			get
			{
				if (_scannerTargetCallbackID == null)
				{
					_scannerTargetCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "scannerTargetCallbackID", cr2w, this);
				}
				return _scannerTargetCallbackID;
			}
			set
			{
				if (_scannerTargetCallbackID == value)
				{
					return;
				}
				_scannerTargetCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("hackingMinigameCallbackID")] 
		public CUInt32 HackingMinigameCallbackID
		{
			get
			{
				if (_hackingMinigameCallbackID == null)
				{
					_hackingMinigameCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "hackingMinigameCallbackID", cr2w, this);
				}
				return _hackingMinigameCallbackID;
			}
			set
			{
				if (_hackingMinigameCallbackID == value)
				{
					return;
				}
				_hackingMinigameCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("uiScannerVisibleCallbackID")] 
		public CUInt32 UiScannerVisibleCallbackID
		{
			get
			{
				if (_uiScannerVisibleCallbackID == null)
				{
					_uiScannerVisibleCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "uiScannerVisibleCallbackID", cr2w, this);
				}
				return _uiScannerVisibleCallbackID;
			}
			set
			{
				if (_uiScannerVisibleCallbackID == value)
				{
					return;
				}
				_uiScannerVisibleCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("uiQuickHackVisibleCallbackID")] 
		public CUInt32 UiQuickHackVisibleCallbackID
		{
			get
			{
				if (_uiQuickHackVisibleCallbackID == null)
				{
					_uiQuickHackVisibleCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "uiQuickHackVisibleCallbackID", cr2w, this);
				}
				return _uiQuickHackVisibleCallbackID;
			}
			set
			{
				if (_uiQuickHackVisibleCallbackID == value)
				{
					return;
				}
				_uiQuickHackVisibleCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("lootDataCallbackID")] 
		public CUInt32 LootDataCallbackID
		{
			get
			{
				if (_lootDataCallbackID == null)
				{
					_lootDataCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "lootDataCallbackID", cr2w, this);
				}
				return _lootDataCallbackID;
			}
			set
			{
				if (_lootDataCallbackID == value)
				{
					return;
				}
				_lootDataCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("pulseDelayID")] 
		public gameDelayID PulseDelayID
		{
			get
			{
				if (_pulseDelayID == null)
				{
					_pulseDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "pulseDelayID", cr2w, this);
				}
				return _pulseDelayID;
			}
			set
			{
				if (_pulseDelayID == value)
				{
					return;
				}
				_pulseDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("previousStickInput")] 
		public Vector4 PreviousStickInput
		{
			get
			{
				if (_previousStickInput == null)
				{
					_previousStickInput = (Vector4) CR2WTypeManager.Create("Vector4", "previousStickInput", cr2w, this);
				}
				return _previousStickInput;
			}
			set
			{
				if (_previousStickInput == value)
				{
					return;
				}
				_previousStickInput = value;
				PropertySet(this);
			}
		}

		public HUDManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
