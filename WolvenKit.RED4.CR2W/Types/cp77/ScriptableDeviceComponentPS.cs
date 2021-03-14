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

		[Ordinal(21)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("forceResolveStateOnAttach")] 
		public CBool ForceResolveStateOnAttach
		{
			get
			{
				if (_forceResolveStateOnAttach == null)
				{
					_forceResolveStateOnAttach = (CBool) CR2WTypeManager.Create("Bool", "forceResolveStateOnAttach", cr2w, this);
				}
				return _forceResolveStateOnAttach;
			}
			set
			{
				if (_forceResolveStateOnAttach == value)
				{
					return;
				}
				_forceResolveStateOnAttach = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("forceVisibilityInAnimSystemOnLogicReady")] 
		public CBool ForceVisibilityInAnimSystemOnLogicReady
		{
			get
			{
				if (_forceVisibilityInAnimSystemOnLogicReady == null)
				{
					_forceVisibilityInAnimSystemOnLogicReady = (CBool) CR2WTypeManager.Create("Bool", "forceVisibilityInAnimSystemOnLogicReady", cr2w, this);
				}
				return _forceVisibilityInAnimSystemOnLogicReady;
			}
			set
			{
				if (_forceVisibilityInAnimSystemOnLogicReady == value)
				{
					return;
				}
				_forceVisibilityInAnimSystemOnLogicReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("masters")] 
		public CArray<CHandle<gameDeviceComponentPS>> Masters
		{
			get
			{
				if (_masters == null)
				{
					_masters = (CArray<CHandle<gameDeviceComponentPS>>) CR2WTypeManager.Create("array:handle:gameDeviceComponentPS", "masters", cr2w, this);
				}
				return _masters;
			}
			set
			{
				if (_masters == value)
				{
					return;
				}
				_masters = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("mastersCached")] 
		public CBool MastersCached
		{
			get
			{
				if (_mastersCached == null)
				{
					_mastersCached = (CBool) CR2WTypeManager.Create("Bool", "mastersCached", cr2w, this);
				}
				return _mastersCached;
			}
			set
			{
				if (_mastersCached == value)
				{
					return;
				}
				_mastersCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get
			{
				if (_deviceName == null)
				{
					_deviceName = (CString) CR2WTypeManager.Create("String", "deviceName", cr2w, this);
				}
				return _deviceName;
			}
			set
			{
				if (_deviceName == value)
				{
					return;
				}
				_deviceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("activationState")] 
		public CEnum<EActivationState> ActivationState
		{
			get
			{
				if (_activationState == null)
				{
					_activationState = (CEnum<EActivationState>) CR2WTypeManager.Create("EActivationState", "activationState", cr2w, this);
				}
				return _activationState;
			}
			set
			{
				if (_activationState == value)
				{
					return;
				}
				_activationState = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("drawGridLink")] 
		public CBool DrawGridLink
		{
			get
			{
				if (_drawGridLink == null)
				{
					_drawGridLink = (CBool) CR2WTypeManager.Create("Bool", "drawGridLink", cr2w, this);
				}
				return _drawGridLink;
			}
			set
			{
				if (_drawGridLink == value)
				{
					return;
				}
				_drawGridLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isLinkDynamic")] 
		public CBool IsLinkDynamic
		{
			get
			{
				if (_isLinkDynamic == null)
				{
					_isLinkDynamic = (CBool) CR2WTypeManager.Create("Bool", "isLinkDynamic", cr2w, this);
				}
				return _isLinkDynamic;
			}
			set
			{
				if (_isLinkDynamic == value)
				{
					return;
				}
				_isLinkDynamic = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("fullDepth")] 
		public CBool FullDepth
		{
			get
			{
				if (_fullDepth == null)
				{
					_fullDepth = (CBool) CR2WTypeManager.Create("Bool", "fullDepth", cr2w, this);
				}
				return _fullDepth;
			}
			set
			{
				if (_fullDepth == value)
				{
					return;
				}
				_fullDepth = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get
			{
				if (_virtualNetworkShapeID == null)
				{
					_virtualNetworkShapeID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "virtualNetworkShapeID", cr2w, this);
				}
				return _virtualNetworkShapeID;
			}
			set
			{
				if (_virtualNetworkShapeID == value)
				{
					return;
				}
				_virtualNetworkShapeID = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get
			{
				if (_tweakDBRecord == null)
				{
					_tweakDBRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBRecord", cr2w, this);
				}
				return _tweakDBRecord;
			}
			set
			{
				if (_tweakDBRecord == value)
				{
					return;
				}
				_tweakDBRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("tweakDBDescriptionRecord")] 
		public TweakDBID TweakDBDescriptionRecord
		{
			get
			{
				if (_tweakDBDescriptionRecord == null)
				{
					_tweakDBDescriptionRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBDescriptionRecord", cr2w, this);
				}
				return _tweakDBDescriptionRecord;
			}
			set
			{
				if (_tweakDBDescriptionRecord == value)
				{
					return;
				}
				_tweakDBDescriptionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get
			{
				if (_contentScale == null)
				{
					_contentScale = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentScale", cr2w, this);
				}
				return _contentScale;
			}
			set
			{
				if (_contentScale == value)
				{
					return;
				}
				_contentScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("skillCheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillCheckContainer
		{
			get
			{
				if (_skillCheckContainer == null)
				{
					_skillCheckContainer = (CHandle<BaseSkillCheckContainer>) CR2WTypeManager.Create("handle:BaseSkillCheckContainer", "skillCheckContainer", cr2w, this);
				}
				return _skillCheckContainer;
			}
			set
			{
				if (_skillCheckContainer == value)
				{
					return;
				}
				_skillCheckContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get
			{
				if (_hasUICameraZoom == null)
				{
					_hasUICameraZoom = (CBool) CR2WTypeManager.Create("Bool", "hasUICameraZoom", cr2w, this);
				}
				return _hasUICameraZoom;
			}
			set
			{
				if (_hasUICameraZoom == value)
				{
					return;
				}
				_hasUICameraZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("allowUICameraZoomDynamicSwitch")] 
		public CBool AllowUICameraZoomDynamicSwitch
		{
			get
			{
				if (_allowUICameraZoomDynamicSwitch == null)
				{
					_allowUICameraZoomDynamicSwitch = (CBool) CR2WTypeManager.Create("Bool", "allowUICameraZoomDynamicSwitch", cr2w, this);
				}
				return _allowUICameraZoomDynamicSwitch;
			}
			set
			{
				if (_allowUICameraZoomDynamicSwitch == value)
				{
					return;
				}
				_allowUICameraZoomDynamicSwitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("hasFullScreenUI")] 
		public CBool HasFullScreenUI
		{
			get
			{
				if (_hasFullScreenUI == null)
				{
					_hasFullScreenUI = (CBool) CR2WTypeManager.Create("Bool", "hasFullScreenUI", cr2w, this);
				}
				return _hasFullScreenUI;
			}
			set
			{
				if (_hasFullScreenUI == value)
				{
					return;
				}
				_hasFullScreenUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("hasAuthorizationModule")] 
		public CBool HasAuthorizationModule
		{
			get
			{
				if (_hasAuthorizationModule == null)
				{
					_hasAuthorizationModule = (CBool) CR2WTypeManager.Create("Bool", "hasAuthorizationModule", cr2w, this);
				}
				return _hasAuthorizationModule;
			}
			set
			{
				if (_hasAuthorizationModule == value)
				{
					return;
				}
				_hasAuthorizationModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("hasPersonalLinkSlot")] 
		public CBool HasPersonalLinkSlot
		{
			get
			{
				if (_hasPersonalLinkSlot == null)
				{
					_hasPersonalLinkSlot = (CBool) CR2WTypeManager.Create("Bool", "hasPersonalLinkSlot", cr2w, this);
				}
				return _hasPersonalLinkSlot;
			}
			set
			{
				if (_hasPersonalLinkSlot == value)
				{
					return;
				}
				_hasPersonalLinkSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("backdoorBreachDifficulty")] 
		public CEnum<EGameplayChallengeLevel> BackdoorBreachDifficulty
		{
			get
			{
				if (_backdoorBreachDifficulty == null)
				{
					_backdoorBreachDifficulty = (CEnum<EGameplayChallengeLevel>) CR2WTypeManager.Create("EGameplayChallengeLevel", "backdoorBreachDifficulty", cr2w, this);
				}
				return _backdoorBreachDifficulty;
			}
			set
			{
				if (_backdoorBreachDifficulty == value)
				{
					return;
				}
				_backdoorBreachDifficulty = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("shouldSkipNetrunnerMinigame")] 
		public CBool ShouldSkipNetrunnerMinigame
		{
			get
			{
				if (_shouldSkipNetrunnerMinigame == null)
				{
					_shouldSkipNetrunnerMinigame = (CBool) CR2WTypeManager.Create("Bool", "shouldSkipNetrunnerMinigame", cr2w, this);
				}
				return _shouldSkipNetrunnerMinigame;
			}
			set
			{
				if (_shouldSkipNetrunnerMinigame == value)
				{
					return;
				}
				_shouldSkipNetrunnerMinigame = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("minigameDefinition")] 
		public TweakDBID MinigameDefinition
		{
			get
			{
				if (_minigameDefinition == null)
				{
					_minigameDefinition = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "minigameDefinition", cr2w, this);
				}
				return _minigameDefinition;
			}
			set
			{
				if (_minigameDefinition == value)
				{
					return;
				}
				_minigameDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("minigameAttempt")] 
		public CInt32 MinigameAttempt
		{
			get
			{
				if (_minigameAttempt == null)
				{
					_minigameAttempt = (CInt32) CR2WTypeManager.Create("Int32", "minigameAttempt", cr2w, this);
				}
				return _minigameAttempt;
			}
			set
			{
				if (_minigameAttempt == value)
				{
					return;
				}
				_minigameAttempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("hackingMinigameState")] 
		public CEnum<gameuiHackingMinigameState> HackingMinigameState
		{
			get
			{
				if (_hackingMinigameState == null)
				{
					_hackingMinigameState = (CEnum<gameuiHackingMinigameState>) CR2WTypeManager.Create("gameuiHackingMinigameState", "hackingMinigameState", cr2w, this);
				}
				return _hackingMinigameState;
			}
			set
			{
				if (_hackingMinigameState == value)
				{
					return;
				}
				_hackingMinigameState = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("disablePersonalLinkAutoDisconnect")] 
		public CBool DisablePersonalLinkAutoDisconnect
		{
			get
			{
				if (_disablePersonalLinkAutoDisconnect == null)
				{
					_disablePersonalLinkAutoDisconnect = (CBool) CR2WTypeManager.Create("Bool", "disablePersonalLinkAutoDisconnect", cr2w, this);
				}
				return _disablePersonalLinkAutoDisconnect;
			}
			set
			{
				if (_disablePersonalLinkAutoDisconnect == value)
				{
					return;
				}
				_disablePersonalLinkAutoDisconnect = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("canHandleAdvancedInteraction")] 
		public CBool CanHandleAdvancedInteraction
		{
			get
			{
				if (_canHandleAdvancedInteraction == null)
				{
					_canHandleAdvancedInteraction = (CBool) CR2WTypeManager.Create("Bool", "canHandleAdvancedInteraction", cr2w, this);
				}
				return _canHandleAdvancedInteraction;
			}
			set
			{
				if (_canHandleAdvancedInteraction == value)
				{
					return;
				}
				_canHandleAdvancedInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("canBeTrapped")] 
		public CBool CanBeTrapped
		{
			get
			{
				if (_canBeTrapped == null)
				{
					_canBeTrapped = (CBool) CR2WTypeManager.Create("Bool", "canBeTrapped", cr2w, this);
				}
				return _canBeTrapped;
			}
			set
			{
				if (_canBeTrapped == value)
				{
					return;
				}
				_canBeTrapped = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("disassembleProperties")] 
		public DisassembleOptions DisassembleProperties
		{
			get
			{
				if (_disassembleProperties == null)
				{
					_disassembleProperties = (DisassembleOptions) CR2WTypeManager.Create("DisassembleOptions", "disassembleProperties", cr2w, this);
				}
				return _disassembleProperties;
			}
			set
			{
				if (_disassembleProperties == value)
				{
					return;
				}
				_disassembleProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("flatheadScavengeProperties")] 
		public SpiderbotScavengeOptions FlatheadScavengeProperties
		{
			get
			{
				if (_flatheadScavengeProperties == null)
				{
					_flatheadScavengeProperties = (SpiderbotScavengeOptions) CR2WTypeManager.Create("SpiderbotScavengeOptions", "flatheadScavengeProperties", cr2w, this);
				}
				return _flatheadScavengeProperties;
			}
			set
			{
				if (_flatheadScavengeProperties == value)
				{
					return;
				}
				_flatheadScavengeProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("destructionProperties")] 
		public DestructionData DestructionProperties
		{
			get
			{
				if (_destructionProperties == null)
				{
					_destructionProperties = (DestructionData) CR2WTypeManager.Create("DestructionData", "destructionProperties", cr2w, this);
				}
				return _destructionProperties;
			}
			set
			{
				if (_destructionProperties == value)
				{
					return;
				}
				_destructionProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("canPlayerTakeOverControl")] 
		public CBool CanPlayerTakeOverControl
		{
			get
			{
				if (_canPlayerTakeOverControl == null)
				{
					_canPlayerTakeOverControl = (CBool) CR2WTypeManager.Create("Bool", "canPlayerTakeOverControl", cr2w, this);
				}
				return _canPlayerTakeOverControl;
			}
			set
			{
				if (_canPlayerTakeOverControl == value)
				{
					return;
				}
				_canPlayerTakeOverControl = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("canBeInDeviceChain")] 
		public CBool CanBeInDeviceChain
		{
			get
			{
				if (_canBeInDeviceChain == null)
				{
					_canBeInDeviceChain = (CBool) CR2WTypeManager.Create("Bool", "canBeInDeviceChain", cr2w, this);
				}
				return _canBeInDeviceChain;
			}
			set
			{
				if (_canBeInDeviceChain == value)
				{
					return;
				}
				_canBeInDeviceChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("personalLinkForced")] 
		public CBool PersonalLinkForced
		{
			get
			{
				if (_personalLinkForced == null)
				{
					_personalLinkForced = (CBool) CR2WTypeManager.Create("Bool", "personalLinkForced", cr2w, this);
				}
				return _personalLinkForced;
			}
			set
			{
				if (_personalLinkForced == value)
				{
					return;
				}
				_personalLinkForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("personalLinkCustomInteraction")] 
		public TweakDBID PersonalLinkCustomInteraction
		{
			get
			{
				if (_personalLinkCustomInteraction == null)
				{
					_personalLinkCustomInteraction = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "personalLinkCustomInteraction", cr2w, this);
				}
				return _personalLinkCustomInteraction;
			}
			set
			{
				if (_personalLinkCustomInteraction == value)
				{
					return;
				}
				_personalLinkCustomInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("personalLinkStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> PersonalLinkStatus
		{
			get
			{
				if (_personalLinkStatus == null)
				{
					_personalLinkStatus = (CEnum<EPersonalLinkConnectionStatus>) CR2WTypeManager.Create("EPersonalLinkConnectionStatus", "personalLinkStatus", cr2w, this);
				}
				return _personalLinkStatus;
			}
			set
			{
				if (_personalLinkStatus == value)
				{
					return;
				}
				_personalLinkStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("isAdvancedInteractionModeOn")] 
		public CBool IsAdvancedInteractionModeOn
		{
			get
			{
				if (_isAdvancedInteractionModeOn == null)
				{
					_isAdvancedInteractionModeOn = (CBool) CR2WTypeManager.Create("Bool", "isAdvancedInteractionModeOn", cr2w, this);
				}
				return _isAdvancedInteractionModeOn;
			}
			set
			{
				if (_isAdvancedInteractionModeOn == value)
				{
					return;
				}
				_isAdvancedInteractionModeOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("juryrigTrapState")] 
		public CEnum<EJuryrigTrapState> JuryrigTrapState
		{
			get
			{
				if (_juryrigTrapState == null)
				{
					_juryrigTrapState = (CEnum<EJuryrigTrapState>) CR2WTypeManager.Create("EJuryrigTrapState", "juryrigTrapState", cr2w, this);
				}
				return _juryrigTrapState;
			}
			set
			{
				if (_juryrigTrapState == value)
				{
					return;
				}
				_juryrigTrapState = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("isControlledByThePlayer")] 
		public CBool IsControlledByThePlayer
		{
			get
			{
				if (_isControlledByThePlayer == null)
				{
					_isControlledByThePlayer = (CBool) CR2WTypeManager.Create("Bool", "isControlledByThePlayer", cr2w, this);
				}
				return _isControlledByThePlayer;
			}
			set
			{
				if (_isControlledByThePlayer == value)
				{
					return;
				}
				_isControlledByThePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get
			{
				if (_isHighlightedInFocusMode == null)
				{
					_isHighlightedInFocusMode = (CBool) CR2WTypeManager.Create("Bool", "isHighlightedInFocusMode", cr2w, this);
				}
				return _isHighlightedInFocusMode;
			}
			set
			{
				if (_isHighlightedInFocusMode == value)
				{
					return;
				}
				_isHighlightedInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get
			{
				if (_wasQuickHacked == null)
				{
					_wasQuickHacked = (CBool) CR2WTypeManager.Create("Bool", "wasQuickHacked", cr2w, this);
				}
				return _wasQuickHacked;
			}
			set
			{
				if (_wasQuickHacked == value)
				{
					return;
				}
				_wasQuickHacked = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get
			{
				if (_wasQuickHackAttempt == null)
				{
					_wasQuickHackAttempt = (CBool) CR2WTypeManager.Create("Bool", "wasQuickHackAttempt", cr2w, this);
				}
				return _wasQuickHackAttempt;
			}
			set
			{
				if (_wasQuickHackAttempt == value)
				{
					return;
				}
				_wasQuickHackAttempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("lastPerformedQuickHack")] 
		public CName LastPerformedQuickHack
		{
			get
			{
				if (_lastPerformedQuickHack == null)
				{
					_lastPerformedQuickHack = (CName) CR2WTypeManager.Create("CName", "lastPerformedQuickHack", cr2w, this);
				}
				return _lastPerformedQuickHack;
			}
			set
			{
				if (_lastPerformedQuickHack == value)
				{
					return;
				}
				_lastPerformedQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get
			{
				if (_isGlitching == null)
				{
					_isGlitching = (CBool) CR2WTypeManager.Create("Bool", "isGlitching", cr2w, this);
				}
				return _isGlitching;
			}
			set
			{
				if (_isGlitching == value)
				{
					return;
				}
				_isGlitching = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get
			{
				if (_isRestarting == null)
				{
					_isRestarting = (CBool) CR2WTypeManager.Create("Bool", "isRestarting", cr2w, this);
				}
				return _isRestarting;
			}
			set
			{
				if (_isRestarting == value)
				{
					return;
				}
				_isRestarting = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("blockSecurityWakeUp")] 
		public CBool BlockSecurityWakeUp
		{
			get
			{
				if (_blockSecurityWakeUp == null)
				{
					_blockSecurityWakeUp = (CBool) CR2WTypeManager.Create("Bool", "blockSecurityWakeUp", cr2w, this);
				}
				return _blockSecurityWakeUp;
			}
			set
			{
				if (_blockSecurityWakeUp == value)
				{
					return;
				}
				_blockSecurityWakeUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("isLockedViaSequencer")] 
		public CBool IsLockedViaSequencer
		{
			get
			{
				if (_isLockedViaSequencer == null)
				{
					_isLockedViaSequencer = (CBool) CR2WTypeManager.Create("Bool", "isLockedViaSequencer", cr2w, this);
				}
				return _isLockedViaSequencer;
			}
			set
			{
				if (_isLockedViaSequencer == value)
				{
					return;
				}
				_isLockedViaSequencer = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("distractExecuted")] 
		public CBool DistractExecuted
		{
			get
			{
				if (_distractExecuted == null)
				{
					_distractExecuted = (CBool) CR2WTypeManager.Create("Bool", "distractExecuted", cr2w, this);
				}
				return _distractExecuted;
			}
			set
			{
				if (_distractExecuted == value)
				{
					return;
				}
				_distractExecuted = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("distractionTimeCompleted")] 
		public CBool DistractionTimeCompleted
		{
			get
			{
				if (_distractionTimeCompleted == null)
				{
					_distractionTimeCompleted = (CBool) CR2WTypeManager.Create("Bool", "distractionTimeCompleted", cr2w, this);
				}
				return _distractionTimeCompleted;
			}
			set
			{
				if (_distractionTimeCompleted == value)
				{
					return;
				}
				_distractionTimeCompleted = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("hasNPCWorkspotKillInteraction")] 
		public CBool HasNPCWorkspotKillInteraction
		{
			get
			{
				if (_hasNPCWorkspotKillInteraction == null)
				{
					_hasNPCWorkspotKillInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasNPCWorkspotKillInteraction", cr2w, this);
				}
				return _hasNPCWorkspotKillInteraction;
			}
			set
			{
				if (_hasNPCWorkspotKillInteraction == value)
				{
					return;
				}
				_hasNPCWorkspotKillInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("shouldNPCWorkspotFinishLoop")] 
		public CBool ShouldNPCWorkspotFinishLoop
		{
			get
			{
				if (_shouldNPCWorkspotFinishLoop == null)
				{
					_shouldNPCWorkspotFinishLoop = (CBool) CR2WTypeManager.Create("Bool", "shouldNPCWorkspotFinishLoop", cr2w, this);
				}
				return _shouldNPCWorkspotFinishLoop;
			}
			set
			{
				if (_shouldNPCWorkspotFinishLoop == value)
				{
					return;
				}
				_shouldNPCWorkspotFinishLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("durabilityState")] 
		public CEnum<EDeviceDurabilityState> DurabilityState
		{
			get
			{
				if (_durabilityState == null)
				{
					_durabilityState = (CEnum<EDeviceDurabilityState>) CR2WTypeManager.Create("EDeviceDurabilityState", "durabilityState", cr2w, this);
				}
				return _durabilityState;
			}
			set
			{
				if (_durabilityState == value)
				{
					return;
				}
				_durabilityState = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("hasBeenScavenged")] 
		public CBool HasBeenScavenged
		{
			get
			{
				if (_hasBeenScavenged == null)
				{
					_hasBeenScavenged = (CBool) CR2WTypeManager.Create("Bool", "hasBeenScavenged", cr2w, this);
				}
				return _hasBeenScavenged;
			}
			set
			{
				if (_hasBeenScavenged == value)
				{
					return;
				}
				_hasBeenScavenged = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("currentlyAuthorizedUsers")] 
		public CArray<SecuritySystemClearanceEntry> CurrentlyAuthorizedUsers
		{
			get
			{
				if (_currentlyAuthorizedUsers == null)
				{
					_currentlyAuthorizedUsers = (CArray<SecuritySystemClearanceEntry>) CR2WTypeManager.Create("array:SecuritySystemClearanceEntry", "currentlyAuthorizedUsers", cr2w, this);
				}
				return _currentlyAuthorizedUsers;
			}
			set
			{
				if (_currentlyAuthorizedUsers == value)
				{
					return;
				}
				_currentlyAuthorizedUsers = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("performedActions")] 
		public CArray<SPerformedActions> PerformedActions
		{
			get
			{
				if (_performedActions == null)
				{
					_performedActions = (CArray<SPerformedActions>) CR2WTypeManager.Create("array:SPerformedActions", "performedActions", cr2w, this);
				}
				return _performedActions;
			}
			set
			{
				if (_performedActions == value)
				{
					return;
				}
				_performedActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("isInitialStateOperationPerformed")] 
		public CBool IsInitialStateOperationPerformed
		{
			get
			{
				if (_isInitialStateOperationPerformed == null)
				{
					_isInitialStateOperationPerformed = (CBool) CR2WTypeManager.Create("Bool", "isInitialStateOperationPerformed", cr2w, this);
				}
				return _isInitialStateOperationPerformed;
			}
			set
			{
				if (_isInitialStateOperationPerformed == value)
				{
					return;
				}
				_isInitialStateOperationPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("illegalActions")] 
		public IllegalActionTypes IllegalActions
		{
			get
			{
				if (_illegalActions == null)
				{
					_illegalActions = (IllegalActionTypes) CR2WTypeManager.Create("IllegalActionTypes", "illegalActions", cr2w, this);
				}
				return _illegalActions;
			}
			set
			{
				if (_illegalActions == value)
				{
					return;
				}
				_illegalActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("disableQuickHacks")] 
		public CBool DisableQuickHacks
		{
			get
			{
				if (_disableQuickHacks == null)
				{
					_disableQuickHacks = (CBool) CR2WTypeManager.Create("Bool", "disableQuickHacks", cr2w, this);
				}
				return _disableQuickHacks;
			}
			set
			{
				if (_disableQuickHacks == value)
				{
					return;
				}
				_disableQuickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get
			{
				if (_availableQuickHacks == null)
				{
					_availableQuickHacks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availableQuickHacks", cr2w, this);
				}
				return _availableQuickHacks;
			}
			set
			{
				if (_availableQuickHacks == value)
				{
					return;
				}
				_availableQuickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("isKeyloggerInstalled")] 
		public CBool IsKeyloggerInstalled
		{
			get
			{
				if (_isKeyloggerInstalled == null)
				{
					_isKeyloggerInstalled = (CBool) CR2WTypeManager.Create("Bool", "isKeyloggerInstalled", cr2w, this);
				}
				return _isKeyloggerInstalled;
			}
			set
			{
				if (_isKeyloggerInstalled == value)
				{
					return;
				}
				_isKeyloggerInstalled = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("actionsWithDisabledRPGChecks")] 
		public CArray<TweakDBID> ActionsWithDisabledRPGChecks
		{
			get
			{
				if (_actionsWithDisabledRPGChecks == null)
				{
					_actionsWithDisabledRPGChecks = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "actionsWithDisabledRPGChecks", cr2w, this);
				}
				return _actionsWithDisabledRPGChecks;
			}
			set
			{
				if (_actionsWithDisabledRPGChecks == value)
				{
					return;
				}
				_actionsWithDisabledRPGChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("availableSpiderbotActions")] 
		public CArray<CName> AvailableSpiderbotActions
		{
			get
			{
				if (_availableSpiderbotActions == null)
				{
					_availableSpiderbotActions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availableSpiderbotActions", cr2w, this);
				}
				return _availableSpiderbotActions;
			}
			set
			{
				if (_availableSpiderbotActions == value)
				{
					return;
				}
				_availableSpiderbotActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("currentSpiderbotActionPerformed")] 
		public CHandle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed
		{
			get
			{
				if (_currentSpiderbotActionPerformed == null)
				{
					_currentSpiderbotActionPerformed = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "currentSpiderbotActionPerformed", cr2w, this);
				}
				return _currentSpiderbotActionPerformed;
			}
			set
			{
				if (_currentSpiderbotActionPerformed == value)
				{
					return;
				}
				_currentSpiderbotActionPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("isSpiderbotInteractionOrdered")] 
		public CBool IsSpiderbotInteractionOrdered
		{
			get
			{
				if (_isSpiderbotInteractionOrdered == null)
				{
					_isSpiderbotInteractionOrdered = (CBool) CR2WTypeManager.Create("Bool", "isSpiderbotInteractionOrdered", cr2w, this);
				}
				return _isSpiderbotInteractionOrdered;
			}
			set
			{
				if (_isSpiderbotInteractionOrdered == value)
				{
					return;
				}
				_isSpiderbotInteractionOrdered = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("shouldScannerShowStatus")] 
		public CBool ShouldScannerShowStatus
		{
			get
			{
				if (_shouldScannerShowStatus == null)
				{
					_shouldScannerShowStatus = (CBool) CR2WTypeManager.Create("Bool", "shouldScannerShowStatus", cr2w, this);
				}
				return _shouldScannerShowStatus;
			}
			set
			{
				if (_shouldScannerShowStatus == value)
				{
					return;
				}
				_shouldScannerShowStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("shouldScannerShowNetwork")] 
		public CBool ShouldScannerShowNetwork
		{
			get
			{
				if (_shouldScannerShowNetwork == null)
				{
					_shouldScannerShowNetwork = (CBool) CR2WTypeManager.Create("Bool", "shouldScannerShowNetwork", cr2w, this);
				}
				return _shouldScannerShowNetwork;
			}
			set
			{
				if (_shouldScannerShowNetwork == value)
				{
					return;
				}
				_shouldScannerShowNetwork = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("shouldScannerShowAttitude")] 
		public CBool ShouldScannerShowAttitude
		{
			get
			{
				if (_shouldScannerShowAttitude == null)
				{
					_shouldScannerShowAttitude = (CBool) CR2WTypeManager.Create("Bool", "shouldScannerShowAttitude", cr2w, this);
				}
				return _shouldScannerShowAttitude;
			}
			set
			{
				if (_shouldScannerShowAttitude == value)
				{
					return;
				}
				_shouldScannerShowAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("shouldScannerShowRole")] 
		public CBool ShouldScannerShowRole
		{
			get
			{
				if (_shouldScannerShowRole == null)
				{
					_shouldScannerShowRole = (CBool) CR2WTypeManager.Create("Bool", "shouldScannerShowRole", cr2w, this);
				}
				return _shouldScannerShowRole;
			}
			set
			{
				if (_shouldScannerShowRole == value)
				{
					return;
				}
				_shouldScannerShowRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("shouldScannerShowHealth")] 
		public CBool ShouldScannerShowHealth
		{
			get
			{
				if (_shouldScannerShowHealth == null)
				{
					_shouldScannerShowHealth = (CBool) CR2WTypeManager.Create("Bool", "shouldScannerShowHealth", cr2w, this);
				}
				return _shouldScannerShowHealth;
			}
			set
			{
				if (_shouldScannerShowHealth == value)
				{
					return;
				}
				_shouldScannerShowHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("debugDevice")] 
		public CBool DebugDevice
		{
			get
			{
				if (_debugDevice == null)
				{
					_debugDevice = (CBool) CR2WTypeManager.Create("Bool", "debugDevice", cr2w, this);
				}
				return _debugDevice;
			}
			set
			{
				if (_debugDevice == value)
				{
					return;
				}
				_debugDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get
			{
				if (_debugName == null)
				{
					_debugName = (CName) CR2WTypeManager.Create("CName", "debugName", cr2w, this);
				}
				return _debugName;
			}
			set
			{
				if (_debugName == value)
				{
					return;
				}
				_debugName = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("debugExposeQuickHacks")] 
		public CBool DebugExposeQuickHacks
		{
			get
			{
				if (_debugExposeQuickHacks == null)
				{
					_debugExposeQuickHacks = (CBool) CR2WTypeManager.Create("Bool", "debugExposeQuickHacks", cr2w, this);
				}
				return _debugExposeQuickHacks;
			}
			set
			{
				if (_debugExposeQuickHacks == value)
				{
					return;
				}
				_debugExposeQuickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("debugPath")] 
		public CName DebugPath
		{
			get
			{
				if (_debugPath == null)
				{
					_debugPath = (CName) CR2WTypeManager.Create("CName", "debugPath", cr2w, this);
				}
				return _debugPath;
			}
			set
			{
				if (_debugPath == value)
				{
					return;
				}
				_debugPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("debugID")] 
		public CUInt32 DebugID
		{
			get
			{
				if (_debugID == null)
				{
					_debugID = (CUInt32) CR2WTypeManager.Create("Uint32", "debugID", cr2w, this);
				}
				return _debugID;
			}
			set
			{
				if (_debugID == value)
				{
					return;
				}
				_debugID = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("deviceOperationsSetup")] 
		public CHandle<DeviceOperationsContainer> DeviceOperationsSetup
		{
			get
			{
				if (_deviceOperationsSetup == null)
				{
					_deviceOperationsSetup = (CHandle<DeviceOperationsContainer>) CR2WTypeManager.Create("handle:DeviceOperationsContainer", "deviceOperationsSetup", cr2w, this);
				}
				return _deviceOperationsSetup;
			}
			set
			{
				if (_deviceOperationsSetup == value)
				{
					return;
				}
				_deviceOperationsSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("connectionHighlightObjects")] 
		public CArray<NodeRef> ConnectionHighlightObjects
		{
			get
			{
				if (_connectionHighlightObjects == null)
				{
					_connectionHighlightObjects = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "connectionHighlightObjects", cr2w, this);
				}
				return _connectionHighlightObjects;
			}
			set
			{
				if (_connectionHighlightObjects == value)
				{
					return;
				}
				_connectionHighlightObjects = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get
			{
				if (_activeContexts == null)
				{
					_activeContexts = (CArray<CEnum<gamedeviceRequestType>>) CR2WTypeManager.Create("array:gamedeviceRequestType", "activeContexts", cr2w, this);
				}
				return _activeContexts;
			}
			set
			{
				if (_activeContexts == value)
				{
					return;
				}
				_activeContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("playstyles")] 
		public CArray<CEnum<EPlaystyle>> Playstyles
		{
			get
			{
				if (_playstyles == null)
				{
					_playstyles = (CArray<CEnum<EPlaystyle>>) CR2WTypeManager.Create("array:EPlaystyle", "playstyles", cr2w, this);
				}
				return _playstyles;
			}
			set
			{
				if (_playstyles == value)
				{
					return;
				}
				_playstyles = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("quickHackVulnerabilties")] 
		public CArray<TweakDBID> QuickHackVulnerabilties
		{
			get
			{
				if (_quickHackVulnerabilties == null)
				{
					_quickHackVulnerabilties = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "quickHackVulnerabilties", cr2w, this);
				}
				return _quickHackVulnerabilties;
			}
			set
			{
				if (_quickHackVulnerabilties == value)
				{
					return;
				}
				_quickHackVulnerabilties = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("quickHackVulnerabiltiesInitialized")] 
		public CBool QuickHackVulnerabiltiesInitialized
		{
			get
			{
				if (_quickHackVulnerabiltiesInitialized == null)
				{
					_quickHackVulnerabiltiesInitialized = (CBool) CR2WTypeManager.Create("Bool", "quickHackVulnerabiltiesInitialized", cr2w, this);
				}
				return _quickHackVulnerabiltiesInitialized;
			}
			set
			{
				if (_quickHackVulnerabiltiesInitialized == value)
				{
					return;
				}
				_quickHackVulnerabiltiesInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("willingInvestigators")] 
		public CArray<entEntityID> WillingInvestigators
		{
			get
			{
				if (_willingInvestigators == null)
				{
					_willingInvestigators = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "willingInvestigators", cr2w, this);
				}
				return _willingInvestigators;
			}
			set
			{
				if (_willingInvestigators == value)
				{
					return;
				}
				_willingInvestigators = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		public ScriptableDeviceComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
