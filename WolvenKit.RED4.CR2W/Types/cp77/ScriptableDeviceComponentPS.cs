using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceComponentPS : SharedGameplayPS
	{
		private CBool _isInitialized;
		private CBool _forceResolveStateOnAttach;
		private CBool _forceVisibilityInAnimSystemOnLogicReady;
		private CArray<CHandle<gameDeviceComponentPS>> _masters;
		private CBool _mastersCached;
		private CString _deviceName;
		private CEnum<EActivationState> _activationState;
		private CBool _drawGridLink;
		private CBool _isLinkDynamic;
		private CBool _fullDepth;
		private TweakDBID _virtualNetworkShapeID;
		private TweakDBID _tweakDBRecord;
		private TweakDBID _tweakDBDescriptionRecord;
		private TweakDBID _contentScale;
		private CHandle<BaseSkillCheckContainer> _skillCheckContainer;
		private CBool _hasUICameraZoom;
		private CBool _allowUICameraZoomDynamicSwitch;
		private CBool _hasFullScreenUI;
		private CBool _hasAuthorizationModule;
		private CBool _hasPersonalLinkSlot;
		private CEnum<EGameplayChallengeLevel> _backdoorBreachDifficulty;
		private CBool _shouldSkipNetrunnerMinigame;
		private TweakDBID _minigameDefinition;
		private CInt32 _minigameAttempt;
		private CEnum<gameuiHackingMinigameState> _hackingMinigameState;
		private CBool _disablePersonalLinkAutoDisconnect;
		private CBool _canHandleAdvancedInteraction;
		private CBool _canBeTrapped;
		private DisassembleOptions _disassembleProperties;
		private SpiderbotScavengeOptions _flatheadScavengeProperties;
		private DestructionData _destructionProperties;
		private CBool _canPlayerTakeOverControl;
		private CBool _canBeInDeviceChain;
		private CBool _personalLinkForced;
		private TweakDBID _personalLinkCustomInteraction;
		private CEnum<EPersonalLinkConnectionStatus> _personalLinkStatus;
		private CBool _isAdvancedInteractionModeOn;
		private CEnum<EJuryrigTrapState> _juryrigTrapState;
		private CBool _isControlledByThePlayer;
		private CBool _isHighlightedInFocusMode;
		private CBool _wasQuickHacked;
		private CBool _wasQuickHackAttempt;
		private CName _lastPerformedQuickHack;
		private CBool _isGlitching;
		private CBool _isRestarting;
		private CBool _blockSecurityWakeUp;
		private CBool _isLockedViaSequencer;
		private CBool _distractExecuted;
		private CBool _distractionTimeCompleted;
		private CBool _hasNPCWorkspotKillInteraction;
		private CBool _shouldNPCWorkspotFinishLoop;
		private CEnum<EDeviceDurabilityState> _durabilityState;
		private CBool _hasBeenScavenged;
		private CArray<SecuritySystemClearanceEntry> _currentlyAuthorizedUsers;
		private CArray<SPerformedActions> _performedActions;
		private CBool _isInitialStateOperationPerformed;
		private IllegalActionTypes _illegalActions;
		private CBool _disableQuickHacks;
		private CArray<CName> _availableQuickHacks;
		private CBool _isKeyloggerInstalled;
		private CArray<TweakDBID> _actionsWithDisabledRPGChecks;
		private CArray<CName> _availableSpiderbotActions;
		private CHandle<ScriptableDeviceAction> _currentSpiderbotActionPerformed;
		private CBool _isSpiderbotInteractionOrdered;
		private CBool _shouldScannerShowStatus;
		private CBool _shouldScannerShowNetwork;
		private CBool _shouldScannerShowAttitude;
		private CBool _shouldScannerShowRole;
		private CBool _shouldScannerShowHealth;
		private CBool _debugDevice;
		private CName _debugName;
		private CBool _debugExposeQuickHacks;
		private CName _debugPath;
		private CUInt32 _debugID;
		private CHandle<DeviceOperationsContainer> _deviceOperationsSetup;
		private CArray<NodeRef> _connectionHighlightObjects;
		private CArray<CEnum<gamedeviceRequestType>> _activeContexts;
		private CArray<CEnum<EPlaystyle>> _playstyles;
		private CArray<TweakDBID> _quickHackVulnerabilties;
		private CBool _quickHackVulnerabiltiesInitialized;
		private CArray<entEntityID> _willingInvestigators;
		private CBool _isInteractive;

		[Ordinal(22)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(23)] 
		[RED("forceResolveStateOnAttach")] 
		public CBool ForceResolveStateOnAttach
		{
			get => GetProperty(ref _forceResolveStateOnAttach);
			set => SetProperty(ref _forceResolveStateOnAttach, value);
		}

		[Ordinal(24)] 
		[RED("forceVisibilityInAnimSystemOnLogicReady")] 
		public CBool ForceVisibilityInAnimSystemOnLogicReady
		{
			get => GetProperty(ref _forceVisibilityInAnimSystemOnLogicReady);
			set => SetProperty(ref _forceVisibilityInAnimSystemOnLogicReady, value);
		}

		[Ordinal(25)] 
		[RED("masters")] 
		public CArray<CHandle<gameDeviceComponentPS>> Masters
		{
			get => GetProperty(ref _masters);
			set => SetProperty(ref _masters, value);
		}

		[Ordinal(26)] 
		[RED("mastersCached")] 
		public CBool MastersCached
		{
			get => GetProperty(ref _mastersCached);
			set => SetProperty(ref _mastersCached, value);
		}

		[Ordinal(27)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}

		[Ordinal(28)] 
		[RED("activationState")] 
		public CEnum<EActivationState> ActivationState
		{
			get => GetProperty(ref _activationState);
			set => SetProperty(ref _activationState, value);
		}

		[Ordinal(29)] 
		[RED("drawGridLink")] 
		public CBool DrawGridLink
		{
			get => GetProperty(ref _drawGridLink);
			set => SetProperty(ref _drawGridLink, value);
		}

		[Ordinal(30)] 
		[RED("isLinkDynamic")] 
		public CBool IsLinkDynamic
		{
			get => GetProperty(ref _isLinkDynamic);
			set => SetProperty(ref _isLinkDynamic, value);
		}

		[Ordinal(31)] 
		[RED("fullDepth")] 
		public CBool FullDepth
		{
			get => GetProperty(ref _fullDepth);
			set => SetProperty(ref _fullDepth, value);
		}

		[Ordinal(32)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get => GetProperty(ref _virtualNetworkShapeID);
			set => SetProperty(ref _virtualNetworkShapeID, value);
		}

		[Ordinal(33)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get => GetProperty(ref _tweakDBRecord);
			set => SetProperty(ref _tweakDBRecord, value);
		}

		[Ordinal(34)] 
		[RED("tweakDBDescriptionRecord")] 
		public TweakDBID TweakDBDescriptionRecord
		{
			get => GetProperty(ref _tweakDBDescriptionRecord);
			set => SetProperty(ref _tweakDBDescriptionRecord, value);
		}

		[Ordinal(35)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetProperty(ref _contentScale);
			set => SetProperty(ref _contentScale, value);
		}

		[Ordinal(36)] 
		[RED("skillCheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillCheckContainer
		{
			get => GetProperty(ref _skillCheckContainer);
			set => SetProperty(ref _skillCheckContainer, value);
		}

		[Ordinal(37)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetProperty(ref _hasUICameraZoom);
			set => SetProperty(ref _hasUICameraZoom, value);
		}

		[Ordinal(38)] 
		[RED("allowUICameraZoomDynamicSwitch")] 
		public CBool AllowUICameraZoomDynamicSwitch
		{
			get => GetProperty(ref _allowUICameraZoomDynamicSwitch);
			set => SetProperty(ref _allowUICameraZoomDynamicSwitch, value);
		}

		[Ordinal(39)] 
		[RED("hasFullScreenUI")] 
		public CBool HasFullScreenUI
		{
			get => GetProperty(ref _hasFullScreenUI);
			set => SetProperty(ref _hasFullScreenUI, value);
		}

		[Ordinal(40)] 
		[RED("hasAuthorizationModule")] 
		public CBool HasAuthorizationModule
		{
			get => GetProperty(ref _hasAuthorizationModule);
			set => SetProperty(ref _hasAuthorizationModule, value);
		}

		[Ordinal(41)] 
		[RED("hasPersonalLinkSlot")] 
		public CBool HasPersonalLinkSlot
		{
			get => GetProperty(ref _hasPersonalLinkSlot);
			set => SetProperty(ref _hasPersonalLinkSlot, value);
		}

		[Ordinal(42)] 
		[RED("backdoorBreachDifficulty")] 
		public CEnum<EGameplayChallengeLevel> BackdoorBreachDifficulty
		{
			get => GetProperty(ref _backdoorBreachDifficulty);
			set => SetProperty(ref _backdoorBreachDifficulty, value);
		}

		[Ordinal(43)] 
		[RED("shouldSkipNetrunnerMinigame")] 
		public CBool ShouldSkipNetrunnerMinigame
		{
			get => GetProperty(ref _shouldSkipNetrunnerMinigame);
			set => SetProperty(ref _shouldSkipNetrunnerMinigame, value);
		}

		[Ordinal(44)] 
		[RED("minigameDefinition")] 
		public TweakDBID MinigameDefinition
		{
			get => GetProperty(ref _minigameDefinition);
			set => SetProperty(ref _minigameDefinition, value);
		}

		[Ordinal(45)] 
		[RED("minigameAttempt")] 
		public CInt32 MinigameAttempt
		{
			get => GetProperty(ref _minigameAttempt);
			set => SetProperty(ref _minigameAttempt, value);
		}

		[Ordinal(46)] 
		[RED("hackingMinigameState")] 
		public CEnum<gameuiHackingMinigameState> HackingMinigameState
		{
			get => GetProperty(ref _hackingMinigameState);
			set => SetProperty(ref _hackingMinigameState, value);
		}

		[Ordinal(47)] 
		[RED("disablePersonalLinkAutoDisconnect")] 
		public CBool DisablePersonalLinkAutoDisconnect
		{
			get => GetProperty(ref _disablePersonalLinkAutoDisconnect);
			set => SetProperty(ref _disablePersonalLinkAutoDisconnect, value);
		}

		[Ordinal(48)] 
		[RED("canHandleAdvancedInteraction")] 
		public CBool CanHandleAdvancedInteraction
		{
			get => GetProperty(ref _canHandleAdvancedInteraction);
			set => SetProperty(ref _canHandleAdvancedInteraction, value);
		}

		[Ordinal(49)] 
		[RED("canBeTrapped")] 
		public CBool CanBeTrapped
		{
			get => GetProperty(ref _canBeTrapped);
			set => SetProperty(ref _canBeTrapped, value);
		}

		[Ordinal(50)] 
		[RED("disassembleProperties")] 
		public DisassembleOptions DisassembleProperties
		{
			get => GetProperty(ref _disassembleProperties);
			set => SetProperty(ref _disassembleProperties, value);
		}

		[Ordinal(51)] 
		[RED("flatheadScavengeProperties")] 
		public SpiderbotScavengeOptions FlatheadScavengeProperties
		{
			get => GetProperty(ref _flatheadScavengeProperties);
			set => SetProperty(ref _flatheadScavengeProperties, value);
		}

		[Ordinal(52)] 
		[RED("destructionProperties")] 
		public DestructionData DestructionProperties
		{
			get => GetProperty(ref _destructionProperties);
			set => SetProperty(ref _destructionProperties, value);
		}

		[Ordinal(53)] 
		[RED("canPlayerTakeOverControl")] 
		public CBool CanPlayerTakeOverControl
		{
			get => GetProperty(ref _canPlayerTakeOverControl);
			set => SetProperty(ref _canPlayerTakeOverControl, value);
		}

		[Ordinal(54)] 
		[RED("canBeInDeviceChain")] 
		public CBool CanBeInDeviceChain
		{
			get => GetProperty(ref _canBeInDeviceChain);
			set => SetProperty(ref _canBeInDeviceChain, value);
		}

		[Ordinal(55)] 
		[RED("personalLinkForced")] 
		public CBool PersonalLinkForced
		{
			get => GetProperty(ref _personalLinkForced);
			set => SetProperty(ref _personalLinkForced, value);
		}

		[Ordinal(56)] 
		[RED("personalLinkCustomInteraction")] 
		public TweakDBID PersonalLinkCustomInteraction
		{
			get => GetProperty(ref _personalLinkCustomInteraction);
			set => SetProperty(ref _personalLinkCustomInteraction, value);
		}

		[Ordinal(57)] 
		[RED("personalLinkStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> PersonalLinkStatus
		{
			get => GetProperty(ref _personalLinkStatus);
			set => SetProperty(ref _personalLinkStatus, value);
		}

		[Ordinal(58)] 
		[RED("isAdvancedInteractionModeOn")] 
		public CBool IsAdvancedInteractionModeOn
		{
			get => GetProperty(ref _isAdvancedInteractionModeOn);
			set => SetProperty(ref _isAdvancedInteractionModeOn, value);
		}

		[Ordinal(59)] 
		[RED("juryrigTrapState")] 
		public CEnum<EJuryrigTrapState> JuryrigTrapState
		{
			get => GetProperty(ref _juryrigTrapState);
			set => SetProperty(ref _juryrigTrapState, value);
		}

		[Ordinal(60)] 
		[RED("isControlledByThePlayer")] 
		public CBool IsControlledByThePlayer
		{
			get => GetProperty(ref _isControlledByThePlayer);
			set => SetProperty(ref _isControlledByThePlayer, value);
		}

		[Ordinal(61)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetProperty(ref _isHighlightedInFocusMode);
			set => SetProperty(ref _isHighlightedInFocusMode, value);
		}

		[Ordinal(62)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetProperty(ref _wasQuickHacked);
			set => SetProperty(ref _wasQuickHacked, value);
		}

		[Ordinal(63)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetProperty(ref _wasQuickHackAttempt);
			set => SetProperty(ref _wasQuickHackAttempt, value);
		}

		[Ordinal(64)] 
		[RED("lastPerformedQuickHack")] 
		public CName LastPerformedQuickHack
		{
			get => GetProperty(ref _lastPerformedQuickHack);
			set => SetProperty(ref _lastPerformedQuickHack, value);
		}

		[Ordinal(65)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetProperty(ref _isGlitching);
			set => SetProperty(ref _isGlitching, value);
		}

		[Ordinal(66)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get => GetProperty(ref _isRestarting);
			set => SetProperty(ref _isRestarting, value);
		}

		[Ordinal(67)] 
		[RED("blockSecurityWakeUp")] 
		public CBool BlockSecurityWakeUp
		{
			get => GetProperty(ref _blockSecurityWakeUp);
			set => SetProperty(ref _blockSecurityWakeUp, value);
		}

		[Ordinal(68)] 
		[RED("isLockedViaSequencer")] 
		public CBool IsLockedViaSequencer
		{
			get => GetProperty(ref _isLockedViaSequencer);
			set => SetProperty(ref _isLockedViaSequencer, value);
		}

		[Ordinal(69)] 
		[RED("distractExecuted")] 
		public CBool DistractExecuted
		{
			get => GetProperty(ref _distractExecuted);
			set => SetProperty(ref _distractExecuted, value);
		}

		[Ordinal(70)] 
		[RED("distractionTimeCompleted")] 
		public CBool DistractionTimeCompleted
		{
			get => GetProperty(ref _distractionTimeCompleted);
			set => SetProperty(ref _distractionTimeCompleted, value);
		}

		[Ordinal(71)] 
		[RED("hasNPCWorkspotKillInteraction")] 
		public CBool HasNPCWorkspotKillInteraction
		{
			get => GetProperty(ref _hasNPCWorkspotKillInteraction);
			set => SetProperty(ref _hasNPCWorkspotKillInteraction, value);
		}

		[Ordinal(72)] 
		[RED("shouldNPCWorkspotFinishLoop")] 
		public CBool ShouldNPCWorkspotFinishLoop
		{
			get => GetProperty(ref _shouldNPCWorkspotFinishLoop);
			set => SetProperty(ref _shouldNPCWorkspotFinishLoop, value);
		}

		[Ordinal(73)] 
		[RED("durabilityState")] 
		public CEnum<EDeviceDurabilityState> DurabilityState
		{
			get => GetProperty(ref _durabilityState);
			set => SetProperty(ref _durabilityState, value);
		}

		[Ordinal(74)] 
		[RED("hasBeenScavenged")] 
		public CBool HasBeenScavenged
		{
			get => GetProperty(ref _hasBeenScavenged);
			set => SetProperty(ref _hasBeenScavenged, value);
		}

		[Ordinal(75)] 
		[RED("currentlyAuthorizedUsers")] 
		public CArray<SecuritySystemClearanceEntry> CurrentlyAuthorizedUsers
		{
			get => GetProperty(ref _currentlyAuthorizedUsers);
			set => SetProperty(ref _currentlyAuthorizedUsers, value);
		}

		[Ordinal(76)] 
		[RED("performedActions")] 
		public CArray<SPerformedActions> PerformedActions
		{
			get => GetProperty(ref _performedActions);
			set => SetProperty(ref _performedActions, value);
		}

		[Ordinal(77)] 
		[RED("isInitialStateOperationPerformed")] 
		public CBool IsInitialStateOperationPerformed
		{
			get => GetProperty(ref _isInitialStateOperationPerformed);
			set => SetProperty(ref _isInitialStateOperationPerformed, value);
		}

		[Ordinal(78)] 
		[RED("illegalActions")] 
		public IllegalActionTypes IllegalActions
		{
			get => GetProperty(ref _illegalActions);
			set => SetProperty(ref _illegalActions, value);
		}

		[Ordinal(79)] 
		[RED("disableQuickHacks")] 
		public CBool DisableQuickHacks
		{
			get => GetProperty(ref _disableQuickHacks);
			set => SetProperty(ref _disableQuickHacks, value);
		}

		[Ordinal(80)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get => GetProperty(ref _availableQuickHacks);
			set => SetProperty(ref _availableQuickHacks, value);
		}

		[Ordinal(81)] 
		[RED("isKeyloggerInstalled")] 
		public CBool IsKeyloggerInstalled
		{
			get => GetProperty(ref _isKeyloggerInstalled);
			set => SetProperty(ref _isKeyloggerInstalled, value);
		}

		[Ordinal(82)] 
		[RED("actionsWithDisabledRPGChecks")] 
		public CArray<TweakDBID> ActionsWithDisabledRPGChecks
		{
			get => GetProperty(ref _actionsWithDisabledRPGChecks);
			set => SetProperty(ref _actionsWithDisabledRPGChecks, value);
		}

		[Ordinal(83)] 
		[RED("availableSpiderbotActions")] 
		public CArray<CName> AvailableSpiderbotActions
		{
			get => GetProperty(ref _availableSpiderbotActions);
			set => SetProperty(ref _availableSpiderbotActions, value);
		}

		[Ordinal(84)] 
		[RED("currentSpiderbotActionPerformed")] 
		public CHandle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed
		{
			get => GetProperty(ref _currentSpiderbotActionPerformed);
			set => SetProperty(ref _currentSpiderbotActionPerformed, value);
		}

		[Ordinal(85)] 
		[RED("isSpiderbotInteractionOrdered")] 
		public CBool IsSpiderbotInteractionOrdered
		{
			get => GetProperty(ref _isSpiderbotInteractionOrdered);
			set => SetProperty(ref _isSpiderbotInteractionOrdered, value);
		}

		[Ordinal(86)] 
		[RED("shouldScannerShowStatus")] 
		public CBool ShouldScannerShowStatus
		{
			get => GetProperty(ref _shouldScannerShowStatus);
			set => SetProperty(ref _shouldScannerShowStatus, value);
		}

		[Ordinal(87)] 
		[RED("shouldScannerShowNetwork")] 
		public CBool ShouldScannerShowNetwork
		{
			get => GetProperty(ref _shouldScannerShowNetwork);
			set => SetProperty(ref _shouldScannerShowNetwork, value);
		}

		[Ordinal(88)] 
		[RED("shouldScannerShowAttitude")] 
		public CBool ShouldScannerShowAttitude
		{
			get => GetProperty(ref _shouldScannerShowAttitude);
			set => SetProperty(ref _shouldScannerShowAttitude, value);
		}

		[Ordinal(89)] 
		[RED("shouldScannerShowRole")] 
		public CBool ShouldScannerShowRole
		{
			get => GetProperty(ref _shouldScannerShowRole);
			set => SetProperty(ref _shouldScannerShowRole, value);
		}

		[Ordinal(90)] 
		[RED("shouldScannerShowHealth")] 
		public CBool ShouldScannerShowHealth
		{
			get => GetProperty(ref _shouldScannerShowHealth);
			set => SetProperty(ref _shouldScannerShowHealth, value);
		}

		[Ordinal(91)] 
		[RED("debugDevice")] 
		public CBool DebugDevice
		{
			get => GetProperty(ref _debugDevice);
			set => SetProperty(ref _debugDevice, value);
		}

		[Ordinal(92)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get => GetProperty(ref _debugName);
			set => SetProperty(ref _debugName, value);
		}

		[Ordinal(93)] 
		[RED("debugExposeQuickHacks")] 
		public CBool DebugExposeQuickHacks
		{
			get => GetProperty(ref _debugExposeQuickHacks);
			set => SetProperty(ref _debugExposeQuickHacks, value);
		}

		[Ordinal(94)] 
		[RED("debugPath")] 
		public CName DebugPath
		{
			get => GetProperty(ref _debugPath);
			set => SetProperty(ref _debugPath, value);
		}

		[Ordinal(95)] 
		[RED("debugID")] 
		public CUInt32 DebugID
		{
			get => GetProperty(ref _debugID);
			set => SetProperty(ref _debugID, value);
		}

		[Ordinal(96)] 
		[RED("deviceOperationsSetup")] 
		public CHandle<DeviceOperationsContainer> DeviceOperationsSetup
		{
			get => GetProperty(ref _deviceOperationsSetup);
			set => SetProperty(ref _deviceOperationsSetup, value);
		}

		[Ordinal(97)] 
		[RED("connectionHighlightObjects")] 
		public CArray<NodeRef> ConnectionHighlightObjects
		{
			get => GetProperty(ref _connectionHighlightObjects);
			set => SetProperty(ref _connectionHighlightObjects, value);
		}

		[Ordinal(98)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get => GetProperty(ref _activeContexts);
			set => SetProperty(ref _activeContexts, value);
		}

		[Ordinal(99)] 
		[RED("playstyles")] 
		public CArray<CEnum<EPlaystyle>> Playstyles
		{
			get => GetProperty(ref _playstyles);
			set => SetProperty(ref _playstyles, value);
		}

		[Ordinal(100)] 
		[RED("quickHackVulnerabilties")] 
		public CArray<TweakDBID> QuickHackVulnerabilties
		{
			get => GetProperty(ref _quickHackVulnerabilties);
			set => SetProperty(ref _quickHackVulnerabilties, value);
		}

		[Ordinal(101)] 
		[RED("quickHackVulnerabiltiesInitialized")] 
		public CBool QuickHackVulnerabiltiesInitialized
		{
			get => GetProperty(ref _quickHackVulnerabiltiesInitialized);
			set => SetProperty(ref _quickHackVulnerabiltiesInitialized, value);
		}

		[Ordinal(102)] 
		[RED("willingInvestigators")] 
		public CArray<entEntityID> WillingInvestigators
		{
			get => GetProperty(ref _willingInvestigators);
			set => SetProperty(ref _willingInvestigators, value);
		}

		[Ordinal(103)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		public ScriptableDeviceComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
