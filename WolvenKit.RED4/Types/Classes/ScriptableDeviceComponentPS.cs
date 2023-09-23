using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptableDeviceComponentPS : SharedGameplayPS
	{
		[Ordinal(23)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("forceResolveStateOnAttach")] 
		public CBool ForceResolveStateOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("forceVisibilityInAnimSystemOnLogicReady")] 
		public CBool ForceVisibilityInAnimSystemOnLogicReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("masters")] 
		public CArray<CHandle<gameDeviceComponentPS>> Masters
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		[Ordinal(27)] 
		[RED("mastersCached")] 
		public CBool MastersCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(29)] 
		[RED("activationState")] 
		public CEnum<EActivationState> ActivationState
		{
			get => GetPropertyValue<CEnum<EActivationState>>();
			set => SetPropertyValue<CEnum<EActivationState>>(value);
		}

		[Ordinal(30)] 
		[RED("drawGridLink")] 
		public CBool DrawGridLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isLinkDynamic")] 
		public CBool IsLinkDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("fullDepth")] 
		public CBool FullDepth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(34)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(35)] 
		[RED("tweakDBDescriptionRecord")] 
		public TweakDBID TweakDBDescriptionRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(36)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(37)] 
		[RED("skillCheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillCheckContainer
		{
			get => GetPropertyValue<CHandle<BaseSkillCheckContainer>>();
			set => SetPropertyValue<CHandle<BaseSkillCheckContainer>>(value);
		}

		[Ordinal(38)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("allowUICameraZoomDynamicSwitch")] 
		public CBool AllowUICameraZoomDynamicSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("hasFullScreenUI")] 
		public CBool HasFullScreenUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("hasAuthorizationModule")] 
		public CBool HasAuthorizationModule
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("hasPersonalLinkSlot")] 
		public CBool HasPersonalLinkSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("backdoorBreachDifficulty")] 
		public CEnum<EGameplayChallengeLevel> BackdoorBreachDifficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		[Ordinal(44)] 
		[RED("shouldSkipNetrunnerMinigame")] 
		public CBool ShouldSkipNetrunnerMinigame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("minigameDefinition")] 
		public TweakDBID MinigameDefinition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(46)] 
		[RED("minigameAttempt")] 
		public CInt32 MinigameAttempt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(47)] 
		[RED("hackingMinigameState")] 
		public CEnum<gameuiHackingMinigameState> HackingMinigameState
		{
			get => GetPropertyValue<CEnum<gameuiHackingMinigameState>>();
			set => SetPropertyValue<CEnum<gameuiHackingMinigameState>>(value);
		}

		[Ordinal(48)] 
		[RED("disablePersonalLinkAutoDisconnect")] 
		public CBool DisablePersonalLinkAutoDisconnect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("canHandleAdvancedInteraction")] 
		public CBool CanHandleAdvancedInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("canBeTrapped")] 
		public CBool CanBeTrapped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("disassembleProperties")] 
		public DisassembleOptions DisassembleProperties
		{
			get => GetPropertyValue<DisassembleOptions>();
			set => SetPropertyValue<DisassembleOptions>(value);
		}

		[Ordinal(52)] 
		[RED("flatheadScavengeProperties")] 
		public SpiderbotScavengeOptions FlatheadScavengeProperties
		{
			get => GetPropertyValue<SpiderbotScavengeOptions>();
			set => SetPropertyValue<SpiderbotScavengeOptions>(value);
		}

		[Ordinal(53)] 
		[RED("destructionProperties")] 
		public DestructionData DestructionProperties
		{
			get => GetPropertyValue<DestructionData>();
			set => SetPropertyValue<DestructionData>(value);
		}

		[Ordinal(54)] 
		[RED("canPlayerTakeOverControl")] 
		public CBool CanPlayerTakeOverControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("canBeInDeviceChain")] 
		public CBool CanBeInDeviceChain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("personalLinkForced")] 
		public CBool PersonalLinkForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("personalLinkCustomInteraction")] 
		public TweakDBID PersonalLinkCustomInteraction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(58)] 
		[RED("personalLinkStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> PersonalLinkStatus
		{
			get => GetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>();
			set => SetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>(value);
		}

		[Ordinal(59)] 
		[RED("isAdvancedInteractionModeOn")] 
		public CBool IsAdvancedInteractionModeOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("juryrigTrapState")] 
		public CEnum<EJuryrigTrapState> JuryrigTrapState
		{
			get => GetPropertyValue<CEnum<EJuryrigTrapState>>();
			set => SetPropertyValue<CEnum<EJuryrigTrapState>>(value);
		}

		[Ordinal(61)] 
		[RED("isControlledByThePlayer")] 
		public CBool IsControlledByThePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("lastPerformedQuickHack")] 
		public CName LastPerformedQuickHack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(66)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("isTimedTurnOff")] 
		public CBool IsTimedTurnOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("blockSecurityWakeUp")] 
		public CBool BlockSecurityWakeUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("isLockedViaSequencer")] 
		public CBool IsLockedViaSequencer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("distractExecuted")] 
		public CBool DistractExecuted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("distractionTimeCompleted")] 
		public CBool DistractionTimeCompleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("hasNPCWorkspotKillInteraction")] 
		public CBool HasNPCWorkspotKillInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("shouldNPCWorkspotFinishLoop")] 
		public CBool ShouldNPCWorkspotFinishLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("durabilityState")] 
		public CEnum<EDeviceDurabilityState> DurabilityState
		{
			get => GetPropertyValue<CEnum<EDeviceDurabilityState>>();
			set => SetPropertyValue<CEnum<EDeviceDurabilityState>>(value);
		}

		[Ordinal(76)] 
		[RED("hasBeenScavenged")] 
		public CBool HasBeenScavenged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("currentlyAuthorizedUsers")] 
		public CArray<SecuritySystemClearanceEntry> CurrentlyAuthorizedUsers
		{
			get => GetPropertyValue<CArray<SecuritySystemClearanceEntry>>();
			set => SetPropertyValue<CArray<SecuritySystemClearanceEntry>>(value);
		}

		[Ordinal(78)] 
		[RED("performedActions")] 
		public CArray<SPerformedActions> PerformedActions
		{
			get => GetPropertyValue<CArray<SPerformedActions>>();
			set => SetPropertyValue<CArray<SPerformedActions>>(value);
		}

		[Ordinal(79)] 
		[RED("isInitialStateOperationPerformed")] 
		public CBool IsInitialStateOperationPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("illegalActions")] 
		public IllegalActionTypes IllegalActions
		{
			get => GetPropertyValue<IllegalActionTypes>();
			set => SetPropertyValue<IllegalActionTypes>(value);
		}

		[Ordinal(81)] 
		[RED("disableQuickHacks")] 
		public CBool DisableQuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(83)] 
		[RED("isKeyloggerInstalled")] 
		public CBool IsKeyloggerInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(84)] 
		[RED("actionsWithDisabledRPGChecks")] 
		public CArray<TweakDBID> ActionsWithDisabledRPGChecks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(85)] 
		[RED("availableSpiderbotActions")] 
		public CArray<CName> AvailableSpiderbotActions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(86)] 
		[RED("currentSpiderbotActionPerformed")] 
		public CHandle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(87)] 
		[RED("isSpiderbotInteractionOrdered")] 
		public CBool IsSpiderbotInteractionOrdered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(88)] 
		[RED("shouldScannerShowStatus")] 
		public CBool ShouldScannerShowStatus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(89)] 
		[RED("shouldScannerShowNetwork")] 
		public CBool ShouldScannerShowNetwork
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(90)] 
		[RED("shouldScannerShowAttitude")] 
		public CBool ShouldScannerShowAttitude
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(91)] 
		[RED("shouldScannerShowRole")] 
		public CBool ShouldScannerShowRole
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(92)] 
		[RED("shouldScannerShowHealth")] 
		public CBool ShouldScannerShowHealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("debugDevice")] 
		public CBool DebugDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(94)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(95)] 
		[RED("debugExposeQuickHacks")] 
		public CBool DebugExposeQuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("debugPath")] 
		public CName DebugPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(97)] 
		[RED("debugID")] 
		public CUInt32 DebugID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(98)] 
		[RED("isUnderEMPEffect")] 
		public CBool IsUnderEMPEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("deviceOperationsSetup")] 
		public CHandle<DeviceOperationsContainer> DeviceOperationsSetup
		{
			get => GetPropertyValue<CHandle<DeviceOperationsContainer>>();
			set => SetPropertyValue<CHandle<DeviceOperationsContainer>>(value);
		}

		[Ordinal(100)] 
		[RED("connectionHighlightObjects")] 
		public CArray<NodeRef> ConnectionHighlightObjects
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(101)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get => GetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>(value);
		}

		[Ordinal(102)] 
		[RED("playstyles")] 
		public CArray<CEnum<EPlaystyle>> Playstyles
		{
			get => GetPropertyValue<CArray<CEnum<EPlaystyle>>>();
			set => SetPropertyValue<CArray<CEnum<EPlaystyle>>>(value);
		}

		[Ordinal(103)] 
		[RED("quickHackVulnerabilties")] 
		public CArray<TweakDBID> QuickHackVulnerabilties
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(104)] 
		[RED("quickHackVulnerabiltiesInitialized")] 
		public CBool QuickHackVulnerabiltiesInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("willingInvestigators")] 
		public CArray<entEntityID> WillingInvestigators
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(106)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScriptableDeviceComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
