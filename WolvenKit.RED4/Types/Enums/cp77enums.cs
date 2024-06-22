// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.Types;

public static partial class Enums
{
	public enum AIArgumentType
	{
		Bool = 0,
		Int = 1,
		Uint64 = 2,
		Enum = 3,
		Float = 4,
		CName = 5,
		TreeRef = 8,
		Vector = 6,
		Object = 7,
		NodeRef = 9,
		GlobalNodeId = 10,
		PuppetRef = 11,
		Serializable = 12,
		TweakDBID = 13
	}

	public enum AICombatSectorType
	{
		ToBackLeft = 0,
		ToBackMid = 1,
		ToBackRight = 2,
		ToLeft = 3,
		ToMid = 4,
		ToRight = 5,
		FromLeft = 6,
		FromMid = 7,
		FromRight = 8,
		FromBackLeft = 9,
		FromBackMid = 10,
		FromBackRight = 11,
		BeyondToLeft = 12,
		BeyondToRight = 13,
		BeyondFromLeft = 14,
		BeyondFromRight = 15,
		Unknown = 16
	}

	public enum AICombatSpaceSize
	{
		Undefined = 0,
		Narrow = 1,
		Medium = 2,
		Huge = 3
	}

	public enum AICommandContextsType
	{
		Default = 0,
		Immediate = 1,
		Movement = 2,
		Workspot = 3,
		Aiming = 4
	}

	public enum AICommandState
	{
		NotExecuting = 0,
		Enqueued = 1,
		Executing = 2,
		Cancelled = 3,
		Interrupted = 4,
		Success = 5,
		Failure = 6
	}

	public enum AICoverExposureMethod
	{
		Standing_Step_Left = 0,
		Standing_Step_Right = 1,
		Standing_Lean_Left = 2,
		Standing_Lean_Right = 3,
		Crouching_Step_Left = 4,
		Crouching_Step_Right = 5,
		Crouching_Lean_Left = 6,
		Crouching_Lean_Right = 7,
		Lean_Over = 8,
		Stand_Up = 9,
		Standing_Blind_Left = 10,
		Standing_Blind_Right = 11,
		Crouching_Blind_Left = 12,
		Crouching_Blind_Right = 13,
		Crouching_Blind_Top = 14,
		Count = 15
	}

	public enum AIEExecutionOutcome
	{
		OUTCOME_FAILURE = 0,
		OUTCOME_SUCCESS = 1,
		OUTCOME_IN_PROGRESS = 2
	}

	public enum AIEExecutionStatus
	{
		STATUS_INVALID = 0,
		STATUS_SUCCESS = 1,
		STATUS_FAILURE = 2,
		STATUS_RUNNING = 3,
		STATUS_ABORTED = 4
	}

	public enum AIEInterruptionImportance
	{
		Undefined = 0,
		Casual = 1,
		Rush = 2,
		Immediate = 3,
		ForcedImmediate = 4
	}

	public enum AIEInterruptionOutcome
	{
		INTERRUPTION_SUCCESS = 0,
		INTERRUPTION_DELAYED = 1,
		INTERRUPTION_FAILED = 2
	}

	public enum AIESharedVarDefinitionType
	{
		SVInt = 0,
		SVFloat = 1,
		SVBool = 2,
		SVName = 3,
		SVTarget = 4,
		SVPosition = 5,
		SVNodeInstance = 6,
		SVGlobalNodeRef = 7
	}

	public enum AIFiniteRoleType
	{
		Patrol = 0
	}

	public enum AIForcedBehaviourPriority : byte
	{
		AboveIdle = 0,
		AboveCombat = 1,
		AboveCriticalState = 2,
		AboveDeath = 3
	}

	public enum AIIWorkspotManagerSpotUsageState : byte
	{
		Reserved = 0,
		Occupied = 1,
		None = 2
	}

	public enum AIParameterizationType
	{
		BehaviorArgument = 0,
		CustomValue = 1,
		CharacterRecord = 2,
		TweakDB = 3,
		ActionRecord = 4,
		Blackboard = 5,
		Delegate = 6
	}

	public enum AIPatrolContinuationPolicy
	{
		FromNextControlPoint = 0,
		FromClosestPoint = 1,
		FromBeginning = 2
	}

	public enum AIReactionCountOutcome
	{
		Failed = 0,
		Succeded = 1,
		NotFound = 2
	}

	public enum AISignalFlags
	{
		Undefined = 0,
		OverridesSelf = 1,
		InterruptsSamePriorityTask = 2,
		InterruptsForcedBehavior = 4,
		AcceptsAdditives = 8
	}

	public enum AISocketsForRig
	{
		Undefined = 0,
		ManAverage = 1,
		ManBig = 2,
		ManFat = 3,
		WomanAverage = 4,
		WomanBig = 5,
		ChildMale = 6
	}

	public enum AISquadType
	{
		Community = 0,
		Combat = 4,
		Follower = 6,
		Unknown = 7
	}

	public enum AIThreatPersistenceStatus
	{
		ThreatNotFound = 0,
		Persistent = 1,
		NotPersistent = 2
	}

	public enum AITrackedStatusType
	{
		Unknown = 0,
		Friendly = 1,
		Neutral = 2,
		Hostile = 3
	}

	public enum AIUninterruptibleActionType
	{
		None = 0,
		Default = 1,
		EnteringCover = 2,
		LeavingCover = 3,
		Count = 4
	}

	public enum AIactionParamsPackageTypes
	{
		Default = 0,
		Reaction = 1,
		StatusEffect = 2,
		Undefined = 3
	}

	public enum AIbehaviorActivationStatus : byte
	{
		NOT_ACTIVATED = 0,
		ACTIVATING = 1,
		ACTIVATED = 2,
		DEACTIVATING = 3
	}

	public enum AIbehaviorCombatModes : byte
	{
		Default = 0,
		LowFPS = 1,
		Background = 2
	}

	public enum AIbehaviorCompletionStatus
	{
		FAILURE = 0,
		SUCCESS = 1
	}

	public enum AIbehaviorConditionOutcomes
	{
		True = 0,
		False = 1,
		Failure = 2
	}

	public enum AIbehaviorDebugNodeStatus : byte
	{
		Undefined = 0,
		NotRunning = 1,
		ForceStopped = 2,
		Running = 3,
		Success = 4,
		Failure = 5
	}

	public enum AIbehaviorEdgeConditionAction
	{
		None = 0,
		Toggle = 1,
		TurnOn = 2,
		TurnOff = 3
	}

	public enum AIbehaviorEntityLODConditions
	{
		Crowd = 0,
		Cinematic = 1,
		WorkspotStatic = 2
	}

	public enum AIbehaviorMaybeNodeAction
	{
		Succeed = 0,
		Fail = 1,
		RepeatChild = 2
	}

	public enum AIbehaviorMovementPolicyTaskFunctions
	{
		SetMovementType = 0,
		SetTargetObject = 1,
		UseFollowSlots = 2,
		SetLocalTargetOffset = 3,
		SetIgnoreNavigation = 4,
		SetStrafingTarget = 5
	}

	public enum AIbehaviorNaryExpressionOperators
	{
		LogicalAnd = 0,
		LogicalOr = 1
	}

	public enum AIbehaviorParallelNodeChildState
	{
		Inactive = 0,
		Active = 1,
		Completed = 2
	}

	public enum AIbehaviorParallelNodeWaitFor
	{
		LeftChild = 0,
		RightChild = 1,
		AllChildren = 2,
		BothChildren = 2,
		AnyChild = 3
	}

	public enum AIbehaviorSignalConditionModes
	{
		CurrentValue = 0,
		StartOfFrameValue = 1,
		RisingEdge = 2,
		FallingEdge = 3,
		AnyEdge = 4
	}

	public enum AIbehaviorStateCompletionStatus
	{
		ForwardBehaviorStatus = 0,
		Failure = 1,
		Success = 2
	}

	public enum AIbehaviorStoryActionType
	{
		Setup = 0,
		Stop = 1
	}

	public enum AIbehaviorSystemVariableExpressionTypes
	{
		IsFPSLow = 0
	}

	public enum AIbehaviorUpdateOutcome
	{
		IN_PROGRESS = 0,
		SUCCESS = 1,
		FAILURE = 2
	}

	public enum AIinfluenceEBumpPolicy : byte
	{
		Static = 0,
		Lean = 1,
		Move = 2
	}

	public enum ATUIComputerTestStepMode
	{
		SINGLE_ACTION = 0,
		ROLLING = 1
	}

	public enum ActiveBaseContext
	{
		None = 0,
		Locomotion = 1,
		Ladder = 2,
		Swimming = 3,
		BodyCarring = 4,
		MeleeWeapon = 5,
		RangedWeapon = 6,
		BodyCarringWithRangedWeapon = 7
	}

	public enum ActiveMode
	{
		UNINITIALIZED = 0,
		CLEAR = 1,
		SEMI = 2,
		COMBAT = 3,
		FOCUS = 4
	}

	public enum ActorVisibilityStatus
	{
		OUTSIDE_CAMERA = 0,
		IN_CAMERA = 1,
		VISIBLE = 2,
		LOOKEDAT = 3
	}

	public enum AdvertisementFormat : byte
	{
		Format_0_7x1 = 0,
		Format_1x1 = 1,
		Format_1x0_7 = 2,
		Format_1x1_5 = 3,
		Format_1x2 = 4,
		Format_1x3_3 = 5,
		Format_1_5x1 = 6,
		Format_2x1 = 7,
		Format_3_3x1 = 8,
		Format_3x4 = 9,
		Format_4x3 = 10,
		Format_9x16 = 11,
		Format_9x21 = 12,
		Format_16x9 = 13,
		Format_21x9 = 14,
		Format_a = 15,
		Format_b = 16,
		Format_c = 17,
		Format_d = 18,
		Format_e = 19,
		Format_f = 20,
		Format_i = 21,
		Format_o = 22,
		Format_k = 23
	}

	public enum AdvertisementLoadMode
	{
		TweakDB = 0,
		Override = 1
	}

	public enum AimAssistSettingConfig
	{
		Default = 0,
		Scanning = 1,
		LeftHandCyberwareCharge = 2,
		LeftHandCyberware = 3,
		MeleeCombat = 4,
		MeleeCombatIdle = 5,
		AimingLimbCyber = 6,
		AimingLimbCyberZoomLevel1 = 7,
		AimingLimbCyberZoomLevel2 = 8,
		Aiming = 9,
		QuickMelee = 10,
		VehicleCombat = 11,
		Sprinting = 12,
		LimbCyber = 13,
		Vehicle = 14,
		DriverCombat = 15,
		DriverCombatAiming = 16,
		DriverCombatTPP = 17,
		DriverCombatMissiles = 18,
		DriverCombatMissilesAiming = 19,
		DriverCombatMeleeTPP = 20,
		ZoomLevel1 = 21,
		ZoomLevel2 = 22,
		Exhausted = 23,
		Off = 24,
		Count = 25
	}

	public enum ArcadeMachineType
	{
		Default = 0,
		Pachinko = 1
	}

	public enum ArcadeMinigame
	{
		Quadracer = 0,
		RoachRace = 1,
		Shooter = 2,
		Tank = 3,
		Retros = 4,
		INVALID = 5
	}

	public enum AssertType : byte
	{
		EQ = 0,
		NE = 1,
		GT = 2,
		GE = 3,
		LT = 4,
		LE = 5
	}

	public enum AttitudeChange
	{
		DONT_CHANGE = 0,
		FRIENDLY = 1,
		NEUTRAL = 2,
		HOSTILE = 3
	}

	public enum AttributeButtonState
	{
		Default = 0,
		Hover = 1
	}

	public enum BarType
	{
		Armor = 0,
		CurrentCapacity = 1,
		Edgerunner = 2
	}

	public enum BlacklistReason
	{
		UNINITIALIZED = 0,
		TRESPASSING = 1,
		REPRIMAND = 2,
		COMBAT = 3
	}

	public enum BunkerSystems
	{
		ALPHA = 0,
		BRAVO = 1,
		SIERRA = 2,
		VICTOR = 3,
		MAX = 4
	}

	public enum ButtonStatus
	{
		DEFAULT = 0,
		PROCESSING = 1,
		DISABLED = 2
	}

	public enum CasinoTableBet
	{
		none = 0,
		on_0 = 1,
		on_00 = 2,
		on_1 = 3,
		on_2 = 4,
		on_3 = 5,
		on_4 = 6,
		on_5 = 7,
		on_6 = 8,
		on_7 = 9,
		on_8 = 10,
		on_9 = 11,
		on_10 = 12,
		on_11 = 13,
		on_12 = 14,
		on_13 = 15,
		on_14 = 16,
		on_15 = 17,
		on_16 = 18,
		on_17 = 19,
		on_18 = 20,
		on_19 = 21,
		on_20 = 22,
		on_21 = 23,
		on_22 = 24,
		on_23 = 25,
		on_24 = 26,
		on_25 = 27,
		on_26 = 28,
		on_27 = 29,
		on_28 = 30,
		on_29 = 31,
		on_30 = 32,
		on_31 = 33,
		on_32 = 34,
		on_33 = 35,
		on_34 = 36,
		on_35 = 37,
		on_36 = 38,
		on_manque_1_18 = 39,
		on_passe_19_36 = 40,
		on_red = 41,
		on_black = 42,
		on_impair_odd = 43,
		on_pair_even = 44,
		on_1st_12 = 45,
		on_2st_12 = 46,
		on_3st_12 = 47
	}

	public enum CasinoTableSlot
	{
		Slot1 = 0,
		Slot2 = 1,
		Slot3 = 2,
		Slot4 = 3,
		Slot5 = 4
	}

	public enum CasinoTableState
	{
		Idle = 0,
		Game = 1
	}

	[Flags]
	public enum CensorshipFlags
	{
		Censor_Nudity = 1 << 0,
		Censor_OverSexualised = 1 << 1,
		Censor_Suggestive = 1 << 2,
		Censor_Homosexuality = 1 << 3,
		Censor_Gore = 1 << 4,
		Censor_Drugs = 1 << 5,
		Censor_Religion = 1 << 6,
		Censor_Chinese = 1 << 7
	}

	public enum CharacterScreenType
	{
		Attributes = 0,
		Perks = 1
	}

	public enum ChargeIndicatorWidgetType
	{
		INVALID = 0,
		JENKINS = 1,
		TIMEBANK = 2
	}

	public enum ClueState
	{
		active = 0,
		complete = 1
	}

	public enum CodexCategoryType
	{
		All = 0,
		Database = 1,
		Characters = 2,
		Locations = 3,
		Tutorials = 4,
		Count = 5,
		Invalid = -1
	}

	public enum CodexDataSource
	{
		Undefined = 0,
		Codex = 1,
		Onscreen = 2
	}

	public enum CodexImageType
	{
		Default = 0,
		Character = 1
	}

	public enum ConfigGraphicsQualityLevel
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3,
		RaytracingLow = 5,
		RaytracingMedium = 6,
		RaytracingUltra = 7,
		RaytracingOverdrive = 8,
		Cinematic = 9,
		Cinematic_Raytracing = 10,
		CinematicEXR = 11,
		CinematicEXR_Raytracing = 12,
		PlayStation4 = 13,
		XboxOne = 14,
		PlayStation4Pro = 15,
		XboxOneX = 16,
		PlayStation5_Performance = 17,
		PlayStation5_Quality = 18,
		PlayStation5_Backcompat_Performance = 19,
		PlayStation5_Backcompat_Quality = 20,
		XboxSeriesS_Performance = 21,
		XboxSeriesS_Quality = 22,
		XboxSeriesS_Backcompat = 23,
		XboxSeriesX_Performance = 24,
		XboxSeriesX_Quality = 25,
		XboxSeriesX_Backcompat_Performance = 26,
		XboxSeriesX_Backcompat_Quality = 27,
		SteamDeck = 4,
		SafeMode = 30,
		GeForceNow = 28,
		IconsGeneration = 29,
		Auto = 31,
		GGP_Performance = 34,
		GGP_Quality = 35
	}

	public enum ConfigMeshQualityLevel
	{
		Default = 0,
		Console = 1,
		Console_XboxSeriesS = 2
	}

	public enum ConfigTextureQualityLevel
	{
		Console = 0,
		ConsoleSafe = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		SafeMode = 5,
		Auto = 6
	}

	public enum ContactsSortMethod
	{
		ByTime = 0,
		ByName = 1
	}

	public enum CoverState
	{
		Open = 0,
		Closed = 1
	}

	public enum CrafringMaterialItemHighlight
	{
		None = 0,
		Hover = 1,
		Add = 2,
		Remove = 3
	}

	public enum CraftingCommands
	{
		CraftingFinished = 0,
		DisassemblingFinished = 1,
		UpgradingFinished = 2,
		Failed = 3
	}

	public enum CraftingMode
	{
		craft = 0,
		upgrade = 1
	}

	public enum CraftingNotificationType
	{
		NoPerks = 0,
		NotEnoughMaterial = 1
	}

	public enum CurrencyNotificationAnimState
	{
		Inactive = 0,
		Intro = 1,
		Active = 2,
		Outro = 3
	}

	public enum CustomButtonType
	{
		UnlockAllVehicles = 0,
		ShowAllPoiMappins = 1,
		DiscoverAllPoiMappins = 2
	}

	public enum CustomWeaponWheelSlot
	{
		FreeHands = 0,
		Fists = 1
	}

	public enum CyberwareScreenType
	{
		Invalid = 0,
		Ripperdoc = 1,
		Inventory = 2
	}

	public enum DamageEffectDisplayType
	{
		Flat = 0,
		TargetHealth = 1,
		Invalid = -1
	}

	public enum DerivedFilterResult
	{
		False = 0,
		True = 1,
		Pass = 2
	}

	public enum DeviceStimType
	{
		Distract = 0,
		VisualDistract = 1,
		Explosion = 2,
		VentilationAreaEffect = 3,
		None = 4
	}

	public enum Direction
	{
		Next = 0,
		Previous = 1
	}

	public enum DoorProximityDetectorAppearanceStateType
	{
		On = 0,
		Off = 1,
		Bars = 2,
		Green = 3,
		Alarm = 4,
		Glitch = 5
	}

	public enum DronePose
	{
		Relaxed = 0,
		Combat = 1
	}

	public enum DropPointPackageStatus
	{
		NOT_ACTIVE = 0,
		ACTIVE = 1,
		COLLECTED = 2
	}

	public enum DropdownDisplayContext
	{
		NotSet = 0,
		Default = 1,
		ItemChooserWeapon = 2
	}

	public enum DropdownItemDirection
	{
		None = 0,
		Down = 1,
		Up = 2
	}

	public enum DynamicTextureDataFormat : byte
	{
		R_Uint8 = 0,
		R_Float16 = 1,
		R_Float32 = 2,
		RG_Float16 = 3,
		RG_Float32 = 4,
		RGBA_Uint8 = 5,
		RGBA_Uint8_SRGB = 6,
		RGBA_Float16 = 7,
		RGBA_Float32 = 8
	}

	public enum EAIActionPhase
	{
		Inactive = 0,
		Startup = 1,
		Loop = 2,
		Recovery = 3
	}

	public enum EAIActionState
	{
		Inactive = 0,
		Startup = 1,
		Loop = 2,
		Recover = 3
	}

	public enum EAIActionTarget
	{
		None = 0,
		CombatTarget = 1,
		FriendlyTarget = 2,
		CurrentCover = 3,
		StimTarget = 4,
		StimSource = 5,
		CustomWorldPosition = 6
	}

	public enum EAIAttitude
	{
		AIA_Friendly = 0,
		AIA_Neutral = 1,
		AIA_Hostile = 2
	}

	public enum EAIBackgroundCombatStep
	{
		ChangeCover = 0,
		ChangeTarget = 1
	}

	public enum EAIBlockDirection
	{
		Undefined = 0,
		Center = 1,
		Left = 2,
		Right = 3
	}

	public enum EAICombatPreset
	{
		None = 0,
		IsReckless = 1,
		IsAggressive = 2,
		IsBalanced = 3,
		IsDefensive = 4,
		IsCautious = 5
	}

	public enum EAICoverAction
	{
		StepOut = 0,
		LeanOut = 1,
		StepUp = 2,
		LeanOver = 3,
		Undefined = 4
	}

	public enum EAICoverActionDirection
	{
		Front = 0,
		FrontRight = 1,
		Right = 2,
		BackRight = 3,
		Back = 4,
		BackLeft = 5,
		Left = 6,
		FrontLeft = 7
	}

	public enum EAIDismembermentBodyPart
	{
		NONE = -1,
		LEFT_ARM = 0,
		RIGHT_ARM = 1,
		LEFT_LEG = 2,
		RIGHT_LEG = 3,
		HEAD = 4,
		BODY = 5
	}

	public enum EAIGateEventFlags
	{
		AIGEF_Undefined = 0,
		AIGEF_OverridesSelf = 1,
		AIGEF_InterruptsSamePriorityTask = 2,
		AIGEF_InterruptsForcedBehavior = 3,
		AIGEF_AcceptsAdditives = 4
	}

	public enum EAIGateSignalFlags
	{
		AIGSF_Undefined = 0,
		AIGSF_OverridesSelf = 1,
		AIGSF_InterruptsSamePriorityTask = 2,
		AIGSF_InterruptsForcedBehavior = 3,
		AIGSF_AcceptsAdditives = 4
	}

	public enum EAIHitBodyPart
	{
		None = -1,
		Head = 1,
		LeftTorso = 2,
		RightTorso = 3,
		Belly = 4,
		LeftLeg = 5,
		RightLeg = 6
	}

	public enum EAIHitDirection
	{
		None = -1,
		Left = 0,
		Back = 1,
		Right = 2,
		Front = 3
	}

	public enum EAIHitIntensity
	{
		None = -1,
		Light = 0,
		Medium = 1,
		Heavy = 2,
		Explosion = 3
	}

	public enum EAIHitSource
	{
		None = -1,
		Ranged = 0,
		MeleeSharp = 1,
		MeleeBlunt = 2,
		QuickMelee = 3
	}

	public enum EAILastHitReactionPlayed
	{
		None = -1,
		Twitch = 0,
		Impact = 1,
		Stagger = 2,
		Knockdown = 3
	}

	public enum EAIPlayerSquadOrder
	{
		Takedown = 0,
		Invalid = 1
	}

	public enum EAIRole
	{
		None = 0,
		Patrol = 1,
		Follower = 2
	}

	public enum EAIShootingPatternRange
	{
		Close = 0,
		Medium = 1,
		Long = 2,
		Undefined = 3
	}

	public enum EAISquadAction
	{
		Invalid = 0,
		Shoot = 1,
		Charge = 2,
		TakeCover = 3,
		Search = 4,
		Reprimand = 5,
		Investigate = 6,
		Melee = 7,
		Taunt = 8,
		Defend = 9,
		Takedown = 10,
		Peek = 11,
		GrenadeThrow = 12,
		Dash = 13,
		Sync = 14,
		BattleCry = 15,
		CallOff = 16,
		BackUp = 17,
		RangedStrafe = 18,
		Quickhack = 19,
		GroupReaction = 20,
		Crouch = 21
	}

	public enum EAISquadChoiceAlgorithm
	{
		Invalid = 0,
		TargetDistance = 1,
		SectorDistance = 2,
		SquadmateDistance = 3,
		CoopDistance = 4,
		LineOfSight = 5,
		StimDistance = 6,
		StimDistancePerSource = 7,
		AvoidLastPuppetIfPossible = 8,
		Officer = 9,
		Group = 10,
		CallForBackUp = 11,
		CallOffAction = 12,
		ShareNewThreat = 13
	}

	public enum EAISquadRing
	{
		Invalid = 0,
		Melee = 1,
		Close = 2,
		Medium = 3,
		Far = 4,
		Extreme = 5
	}

	public enum EAISquadTactic
	{
		Invalid = 0,
		Flanking = 1,
		Assault = 2,
		Snipe = 3,
		Regroup = 4,
		Retreat = 5,
		Defend = 6,
		Suppress = 7,
		Medivac = 8,
		Panic = 9
	}

	public enum EAISquadVerb
	{
		Invalid = 0,
		JoinSquad = 1,
		LeaveSquad = 2,
		OpenSquadAction = 3,
		RevokeSquadAction = 4,
		RevokeOrder = 5,
		CommitToSquadAction = 6,
		ReportDoneOnSquadAction = 7,
		ReportFailureOnSquadAction = 8,
		EvaluateTicketActivation = 9,
		EvaluateTicketDeactivation = 10,
		AcknowledgeOrder = 11
	}

	public enum EAITargetType
	{
		AITT_Undefined = 0,
		AITT_Argument = 1,
		AITT_Owner = 2,
		AITT_CombatTarget = 3,
		AITT_FacingTarget = 4,
		AITT_Attacker = 5,
		AITT_Companion = 6,
		AITT_Cover = 7
	}

	public enum EAIThreatCalculationType
	{
		Regular = 0,
		Boss = 1,
		Madness = 2
	}

	public enum EAITicketStatus
	{
		Invalid = 0,
		Evaluate = 1,
		OrderFail = 2,
		OrderDone = 3,
		OrderRevoked = 4
	}

	public enum EActionContext
	{
		None = -1,
		Direct = 0,
		QHack = 1,
		Master = 2,
		Spiderbot = 3
	}

	public enum EActionInactivityReson
	{
		Ready = 0,
		Locked = 1,
		Recompilation = 2,
		OutOfMemory = 3,
		IsQuickHacked = 4,
		Invalid = 5
	}

	public enum EActionType
	{
		QuickAction = 0,
		ChargeAction = 1,
		None = 2
	}

	public enum EActionsSequencerMode
	{
		REGULAR_INTERVALS = 0,
		ACCELERATING_INTERVALS_TODO = 1,
		DECELERATING_INTEVALS_TODO = 2,
		RANDOM_INTERVALS_TODO = 3,
		AT_THE_SAME_TIME_TODO = 4
	}

	public enum EActivationState
	{
		NONE = 0,
		ACTIVATED = 1,
		DEACTIVATED = 2
	}

	public enum EAimAssistLevel
	{
		Off = 0,
		Light = 1,
		Standard = 2,
		Heavy = 3
	}

	public enum EAllowedTo
	{
		UNDEFINED = 0,
		TRESSPASSING = 1,
		ILLEGAL_ACTIONS = 2,
		COMBAT = 3
	}

	public enum EAnimationBufferDataAvailable
	{
		ABDA_None = 0,
		ABDA_Partial = 1,
		ABDA_All = 2
	}

	public enum EAnimationType
	{
		REGULAR = 0,
		TRANSFORM = 1,
		TRANSFORM_TWO_SIDES = 2,
		NONE = 3
	}

	public enum EAppliedTriangulationHackSpeed
	{
		NotAssigned = 0,
		Slow = 1,
		Normal = 2,
		Fast = 3
	}

	public enum EAreaLightShape
	{
		ALS_Sphere = 0,
		ALS_Capsule = 1
	}

	public enum EArgumentType
	{
		Object = 0,
		CoverID = 1,
		Vector4 = 2
	}

	public enum EAxisType
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum EBOOL
	{
		UNINITIALZED = 0,
		FALSE = 1,
		TRUE = 2
	}

	public enum EBarkList
	{
		vo_enemy_reaction_surprised_combat_start = 0,
		vo_enemy_reaction_generic_cursing = 1,
		vo_enemy_reaction_jammed_weapon = 2,
		vo_enemy_reaction_impact_hit = 3,
		vo_enemy_reaction_stagger_hit = 4,
		vo_enemy_reaction_crippled_arm = 5,
		vo_enemy_reaction_crippled_leg = 6,
		vo_enemy_reaction_death = 7,
		vo_enemy_group_call_to_combat = 8,
		vo_enemy_group_call_for_help = 9,
		vo_enemy_group_order_go_to_cover = 10,
		vo_enemy_group_order_flank_target = 11,
		vo_enemy_group_order_suppressing_fire = 12,
		vo_enemy_answer_to_order_suppressing_fire = 13,
		vo_enemy_group_notification_reloading = 14,
		vo_enemy_group_notification_squad_member_died = 15,
		vo_enemy_group_notification_grenade_nearby = 16,
		vo_enemy_group_notification_target_using_sandevistan = 17,
		vo_enemy_group_notification_target_using_kerenzikov = 18,
		vo_enemy_answer_to_notification_target_using_sandevistan = 19,
		vo_enemy_answer_to_notification_target_using_kerenzikov = 20,
		vo_enemy_group_generic_combat_question = 21,
		vo_enemy_answer_to_generic_combat_question = 22,
		vo_enemy_group_boost_combat_morale = 23
	}

	public enum EBeamStyle
	{
		None = 0,
		Sweeping = 1,
		HeadSlicer = 2
	}

	public enum EBinkOperationType
	{
		PLAY = 0,
		STOP = 1,
		PAUSE = 2,
		RESUME = 3
	}

	public enum EBreachOrigin
	{
		LOCAL = 0,
		EXTERNAL = 1,
		GLOBAL = 2
	}

	public enum EBroadcasteingType
	{
		Active = 0,
		SingleActive = 1,
		Direct = 2,
		Remove = 3,
		Single = 4
	}

	public enum ECLSForcedState
	{
		DEFAULT = 0,
		ForcedON = 1,
		ForcedOFF = 2
	}

	public enum ECallbackExpressionActions
	{
		SetTrue = 0,
		SetFalse = 1,
		Toggle = 2
	}

	public enum ECameraDirectionFunctionalTestsUtil
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	public enum ECarryState
	{
		None = 0,
		Pickup = 1,
		Carry = 2,
		Drop = 3,
		Release = 4,
		Dispose = 5,
		Jump = 6,
		Aim = 7,
		Throw = 8
	}

	public enum ECartOperationResult
	{
		Success = 0,
		NoItems = 1,
		AllItems = 2,
		WontSell = 3,
		WontBuy = 4,
		QuestItem = 5,
		NotInCart = 6
	}

	public enum ECentaurShieldState
	{
		Inactive = 0,
		Activating = 1,
		Active = 2,
		Destroyed = 3,
		Hacked = 4
	}

	public enum EChargesAmount
	{
		Empty = 0,
		Last = 1,
		FirstFromTop = 2,
		Max = 3
	}

	public enum EChargesItem
	{
		Grenade = 0,
		HealingItems = 1,
		ProjectileLauncher = 2
	}

	public enum EColorChannel
	{
		COLCHANNEL_Red = 0,
		COLCHANNEL_Green = 1,
		COLCHANNEL_Blue = 2,
		COLCHANNEL_Alpha = 3
	}

	public enum EColorMappingFunction : byte
	{
		CMF_Linear = 0,
		CMF_sRGB = 1,
		CMF_ArriLogC = 2
	}

	public enum EColorPrimary
	{
		PRIM_REC709 = 0,
		PRIM_DCIP3 = 1,
		PRIM_BT2020 = 2
	}

	public enum ECompanionDistancePreset
	{
		Medium = 0,
		Close = 1,
		Far = 2,
		VeryFar = 3
	}

	public enum ECompanionPositionPreset
	{
		Behind = 0,
		InFront = 1
	}

	public enum ECompareOp
	{
		CO_Lesser = 0,
		CO_LesserEq = 1,
		CO_Greater = 2,
		CO_GreaterEq = 3,
		CO_Equal = 4,
		CO_NotEqual = 5
	}

	public enum EComparisonOperator
	{
		Equal = 0,
		NotEqual = 1,
		More = 2,
		MoreOrEqual = 3,
		Less = 4,
		LessOrEqual = 5
	}

	public enum EComparisonType
	{
		Greater = 0,
		GreaterOrEqual = 1,
		Equal = 2,
		NotEqual = 3,
		Less = 4,
		LessOrEqual = 5
	}

	public enum EComponentOperation
	{
		Enable = 0,
		Disable = 1
	}

	public enum EComputerAnimationState
	{
		None = 0,
		Opened = 1,
		Closed = 2
	}

	public enum EComputerMenuType
	{
		MAIN = 0,
		SYSTEM = 1,
		FILES = 2,
		MAILS = 3,
		NEWSFEED = 4,
		INTERNET = 5,
		INVALID = 6
	}

	public enum EConclusionQuestState
	{
		Undefined = 0,
		Active = 1,
		Inactive = 2,
		Shown = 3
	}

	public enum ECookingPlatform : byte
	{
		PLATFORM_None = 0,
		PLATFORM_PC = 1,
		PLATFORM_XboxOne = 2,
		PLATFORM_PS4 = 3,
		PLATFORM_PS5 = 4,
		PLATFORM_XSX = 5,
		PLATFORM_WindowsServer = 6,
		PLATFORM_LinuxServer = 7,
		PLATFORM_GGP = 8
	}

	public enum ECooldownGameControllerMode
	{
		COOLDOWNS = 0,
		BUFFS_AND_DEBUFFS = 1
	}

	public enum ECooldownIndicatorState
	{
		Pooled = 0,
		Intro = 1,
		Filling = 2,
		Outro = 3
	}

	public enum ECoverSpecialAction
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public enum ECraftingIconPositioning
	{
		generic = 0,
		weaponBig = 1,
		weaponSmall = 2
	}

	public enum ECubeSourceTextureType
	{
		CST_CrossHorizontal = 0,
		CST_CrossVertical = 1,
		CST_Panorama = 2
	}

	public enum ECustomCameraTarget : byte
	{
		ECCTV_All = 0,
		ECCTV_OnlyOffscreen = 1,
		ECCTV_OnlyOnscreen = 2
	}

	public enum ECustomFilterDPadNavigationOption
	{
		SelectNext = 0,
		SelectPrev = 1,
		Toggle = 2
	}

	public enum ECustomMaterialParam
	{
		ECMP_CustomParam0 = 1,
		ECMP_CustomParam1 = 2,
		ECMP_CustomParam2 = 4,
		ECMP_CustomParam3 = 8,
		ECMP_CustomParam4 = 16,
		ECMP_CustomParam5 = 32,
		ECMP_CustomParam6 = 64
	}

	public enum EDPadSlot
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		LeftDouble = 4,
		UpDouble = 5,
		RightDouble = 6,
		DownDouble = 7,
		WeaponsWheel = 8,
		VehicleWheel = 9,
		GadgetWheel = 10,
		InteractionWheel = 11,
		Phone = 12,
		CallVehicle = 13,
		CycleObjective = 14,
		VehicleInsideWheel = 15,
		ConsumableWheel = 16,
		PocketRadio = 17,
		VehicleVisualCustomization = 18
	}

	public enum EDeathType
	{
		Ground = 0,
		Air = 1,
		Swimming = 2
	}

	public enum EDebuggerColor
	{
		RED = 0,
		YELLOW = 1
	}

	public enum EDecalRenderMode : byte
	{
		DRM_AllStatic = 0,
		DRM_ObjectType = 1,
		DRM_AllDynamic = 2,
		DRM_All = 3
	}

	public enum EDepthCollisionEffect
	{
		DCE_Bounce = 1,
		DCE_Glide = 2,
		DCE_Kill = 4
	}

	public enum EDeviceChallengeAttribute
	{
		Invalid = 0,
		Strength = 1,
		Reflexes = 2,
		Intelligence = 3,
		TechnicalAbility = 4,
		Cool = 5
	}

	public enum EDeviceChallengeSkill
	{
		Invalid = 0,
		Hacking = 1,
		Engineering = 2,
		Athletics = 3
	}

	public enum EDeviceDurabilityState
	{
		NOMINAL = 0,
		MALFUNCTIONING = 1,
		BROKEN = 2,
		DESTROYED = 3
	}

	public enum EDeviceDurabilityType
	{
		INVULNERABLE = 0,
		INDESTRUCTIBLE = 1,
		DESTRUCTIBLE = 2
	}

	public enum EDeviceStatus
	{
		DISABLED = -2,
		UNPOWERED = -1,
		OFF = 0,
		ON = 1,
		INVALID = 2
	}

	public enum EDocumentType
	{
		FILE = 0,
		MAIL = 1,
		Invalid = 2
	}

	public enum EDodgeMovementInput
	{
		Invalid = 0,
		Forward = 1,
		Right = 2,
		Left = 3,
		Back = 4
	}

	public enum EDoorOpeningType
	{
		SLIDING_HORIZONTALLY = 0,
		SLIDING_VERTICALLY = 1,
		HINGED = 2,
		GATE = 3,
		HINGED_SIDE_ONE = 4,
		HINGED_SIDE_TWO = 5
	}

	public enum EDoorSkillcheckSide
	{
		BOTH = 0,
		ONE = 1,
		TWO = 2
	}

	public enum EDoorStatus
	{
		SEALED = -2,
		LOCKED = -1,
		CLOSED = 0,
		OPENED = 1
	}

	public enum EDoorTriggerSide
	{
		OUTSIDE = 0,
		ONE = 1,
		TWO = 2
	}

	public enum EDoorType
	{
		NONE = 0,
		INTERACTIVE = 1,
		AUTOMATIC = 2,
		PHYSICAL = 3,
		REMOTELY_CONTROLLED = 4
	}

	public enum EDownedType
	{
		Killed = 0,
		Finished = 1,
		Defeated = 2,
		Unconscious = 3
	}

	public enum EDrillMachineRewireState
	{
		InsideInteractionRange = 0,
		OutsideInteractionRange = 1,
		InteractionStarted = 2,
		InteractionFinished = 3,
		RewireStarted = 4,
		RewireFinished = 5
	}

	public enum EDynamicDecalSpawnPriority
	{
		RDDS_Normal = 0,
		RDDS_Highest = 1
	}

	public enum EEasingType
	{
		EET_In = 0,
		EET_Out = 1,
		EET_InOut = 2
	}

	public enum EEffectOperationType
	{
		START = 0,
		STOP = 1,
		BRAKE_LOOP = 2
	}

	public enum EEmitterGroup : byte
	{
		EG_Default = 0,
		EG_Group0 = 1,
		EG_Group1 = 2,
		EG_Group2 = 3,
		EG_Group3 = 4,
		EG_Group4 = 5,
		EG_Group5 = 6,
		EG_Group6 = 7,
		EG_Group7 = 8,
		EG_Group8 = 9,
		EG_Group9 = 10,
		EG_Group10 = 11,
		EG_Group11 = 12,
		EG_Group12 = 13,
		EG_Group13 = 14,
		EG_Group14 = 15,
		EG_Group15 = 16
	}

	public enum EEntityHighlightType
	{
		EHE_None = 0,
		EHE_FillAndOutline = 1,
		EHE_FillOnly = 2,
		EHE_OutlineOnly = 3
	}

	public enum EEntryColumn : byte
	{
		left = 0,
		right = 1
	}

	public enum EEnvColorGroup : byte
	{
		ECG_Default = 0,
		ECG_Sky = 1,
		ECG_Group0 = 2,
		ECG_Group1 = 3,
		ECG_Group2 = 4,
		ECG_Group3 = 5,
		ECG_Group4 = 6,
		ECG_Group5 = 7,
		ECG_Group6 = 8,
		ECG_Group7 = 9,
		ECG_Group8 = 10,
		ECG_Group9 = 11,
		ECG_Group10 = 12,
		ECG_Group11 = 13,
		ECG_Group12 = 14,
		ECG_Group13 = 15,
		ECG_Group14 = 16,
		ECG_Group15 = 17
	}

	public enum EEnvManagerModifier
	{
		EMM_None = 0,
		EMM_WireframeSolid = 1,
		EMM_WireframeSeethrough = 2,
		EMM_Overdraw = 3,
		EMM_OverdrawSeethrough = 4,
		EMM_ParticleOverdraw = 5,
		EMM_ParticleNumLights = 6,
		EMM_DecalOverdraw = 7,
		EMM_LightOverdraw = 8,
		EMM_SceneReferredColor = 9,
		EMM_DisplayReferredColor = 10,
		EMM_GlobalIllumination = 11,
		EMM_SurfaceMaterialID = 12,
		EMM_SurfaceObjectID = 13,
		EMM_SurfaceBaseColor = 14,
		EMM_SurfaceAlbedo = 15,
		EMM_SurfaceSpecularity = 16,
		EMM_SurfaceMetalness = 17,
		EMM_SurfaceRoughness = 18,
		EMM_SurfaceEmissive = 19,
		EMM_SurfaceTranslucency = 20,
		EMM_SurfaceNormalsWorldSpace = 21,
		EMM_SurfaceNormalsViewSpace = 22,
		EMM_SurfaceHairDirection = 23,
		EMM_SurfaceHairID = 24,
		EMM_SurfaceLightBlockerIntensity = 25,
		EMM_GBuffer0A = 26,
		EMM_GBuffer1RGB = 27,
		EMM_GBuffer1A = 28,
		EMM_ConeAODir = 29,
		EMM_ConeAOAngle = 30,
		EMM_VelocityBuffer = 31,
		EMM_Depth = 32,
		EMM_UvDensity = 33,
		EMM_ToneMappingLuminance = 34,
		EMM_ToneMappingThresholds = 35,
		EMM_LuminanceSpotMeter = 36,
		EMM_IlluminanceMeter = 37,
		EMM_DiffuseLight = 38,
		EMM_SpecularLight = 39,
		EMM_ClayView = 40,
		EMM_PureGreyscaleView = 41,
		EMM_PureWhiteView = 42,
		EMM_PureReflectionView = 43,
		EMM_PureGreyReflectionView = 44,
		EMM_Cascades = 45,
		EMM_MaskShadow = 46,
		EMM_MaskSSAO = 47,
		EMM_MaskTXAA = 48,
		EMM_MaskDistortion = 49,
		EMM_MaskInvalidation = 50,
		EMM_MaskReactivityFSR2 = 51,
		EMM_SurfaceCacheID = 52,
		EMM_SurfaceCacheResolution = 53,
		EMM_LightChannels = 54,
		EMM_DebugHitProxies = 55,
		EMM_DebugShadowsMode = 56,
		EMM_RayTracingDebug = 57,
		EMM_SSRResults = 58,
		EMM_SSRFade = 59,
		EMM_DepthOfFieldCoC = 60,
		EMM_MultilayeredMode = 61,
		EMM_MultilayeredProxy = 62,
		EMM_MultilayeredUniqueMasks = 63,
		EMM_MultilayeredMaskWeight = 64,
		EMM_LocalShadowsVariance = 65,
		EMM_LocalShadowsRangesOverlapDynamicsOnly = 66,
		EMM_LocalShadowsRangesOverlapStaticsOnly = 67,
		EMM_LODColoring = 68,
		EMM_TodvisRuntimePreview = 69,
		EMM_TodvisBakePreview = 70,
		EMM_RainMask = 71,
		EMM_VolFogDensity = 72,
		EMM_PBRValidationBaseColor = 73,
		EMM_PBRValidationMetalness = 74,
		EMM_GreyPlayMode = 75,
		EMM_RTXDIDiffuseRaw = 76,
		EMM_RTXDISpecularRaw = 77,
		EMM_RTXDIDiffuseDenoised = 78,
		EMM_RTXDISpecularDenoised = 79,
		EMM_RTXDIBRDFFactor = 80,
		EMM_IndirectDiffuseRaw = 81,
		EMM_IndirectSpecularRaw = 82,
		EMM_IndirectDiffuseDenoised = 83,
		EMM_IndirectSpecularDenoised = 84
	}

	public enum EEquipmentSide
	{
		Left = 0,
		Right = 1
	}

	public enum EEquipmentState
	{
		Unequipped = 0,
		Equipped = 1,
		Equipping = 2,
		Unequipping = 3,
		FirstEquip = 4
	}

	public enum EExplosiveAdditionalGameEffectType
	{
		none = 0,
		EMP = 1
	}

	public enum EFastTravelDeviceType
	{
		DataTerm = 0,
		SubwayGate = 1
	}

	public enum EFastTravelSystemInstruction
	{
		Forward = 0,
		Previous = 1
	}

	public enum EFastTravelTriggerType
	{
		Manual = 0,
		Auto = 1
	}

	public enum EFeatureFlag : byte
	{
		FEATFLAG_Default = 0,
		FEATFLAG_Shadows = 1,
		FEATFLAG_HitProxies = 2,
		FEATFLAG_Selection = 3,
		FEATFLAG_Wireframe = 4,
		FEATFLAG_Overdraw = 10,
		FEATFLAG_VelocityBuffer = 5,
		FEATFLAG_DebugDraw_BlendOff = 6,
		FEATFLAG_DebugDraw_BlendOn = 7,
		FEATFLAG_DynamicDecals = 8,
		FEATFLAG_Highlights = 9,
		FEATFLAG_IndirectInstancedGrass = 11,
		FEATFLAG_DecalsOnStaticObjects = 12,
		FEATFLAG_DecalsOnDynamicObjects = 13,
		FEATFLAG_MaskParticlesInsideCar = 14,
		FEATFLAG_MaskParticlesInsideInterior = 15,
		FEATFLAG_MaskTXAA = 16,
		FEATFLAG_DistantShadows = 17,
		FEATFLAG_FloatTracks = 18,
		FEATFLAG_Rain = 19,
		FEATFLAG_NumLights = 20,
		FEATFLAG_DepthPrepass = 21,
		FEATFLAG_DecalsOnAllObjects = 22
	}

	public enum EFilterType
	{
		ALLOW_NONE = 0,
		ALLOW_COMBAT_ONLY = 1,
		ALLOW_ALL = 2
	}

	public enum EFocusClueInvestigationState
	{
		NONE = 0,
		INSPECTED = 1,
		NOT_INSPECTED = 2
	}

	public enum EFocusForcedHighlightType
	{
		INTERACTION = 0,
		IMPORTANT_INTERACTION = 1,
		QUEST = 2,
		DISTRACTION = 3,
		CLUE = 4,
		NPC = 5,
		WEAKSPOT = 6,
		AOE = 7,
		ITEM = 8,
		HOSTILE = 9,
		FRIENDLY = 10,
		NEUTRAL = 11,
		HACKABLE = 12,
		ENEMY_NETRUNNER = 13,
		BACKDOOR = 14,
		INVALID = 15
	}

	public enum EFocusOutlineType
	{
		HOSTILE = 0,
		FRIENDLY = 1,
		NEUTRAL = 2,
		ITEM = 3,
		INTERACTION = 4,
		IMPORTANT_INTERACTION = 5,
		QUEST = 6,
		CLUE = 7,
		DISTRACTION = 8,
		AOE = 9,
		HACKABLE = 10,
		WEAKSPOT = 11,
		ENEMY_NETRUNNER = 12,
		BACKDOOR = 13,
		INVALID = 14
	}

	public enum EForcedElevatorArrowsState
	{
		Disabled = 0,
		ArrowsUp = 1,
		ArrowsDown = 2
	}

	public enum EFreeVectorAxes
	{
		FVA_One = 1,
		FVA_Two = 2,
		FVA_Three = 3,
		FVA_Four = 4
	}

	public enum EGOGMenuState
	{
		None = 0,
		LoadGame = 1,
		MainMenu = 2
	}

	public enum EGameSessionDataType
	{
		NONE = 0,
		CameraDeadBody = 1,
		CameraTagLimit = 2
	}

	public enum EGameplayChallengeLevel
	{
		NONE = 0,
		TRIVIAL = 1,
		EASY = 2,
		MEDIUM = 3,
		HARD = 4,
		IMPOSSIBLE = 5
	}

	public enum EGameplayRole
	{
		UnAssigned = 0,
		None = 1,
		Alarm = 2,
		ControlNetwork = 3,
		ControlOtherDevice = 4,
		ControlSelf = 5,
		CutPower = 6,
		Distract = 7,
		DropPoint = 8,
		ExplodeLethal = 9,
		ExplodeNoneLethal = 10,
		Fall = 11,
		FastTravel = 12,
		GrantInformation = 13,
		HazardWarning = 14,
		HideBody = 15,
		Loot = 16,
		OpenPath = 17,
		ClearPath = 18,
		Push = 19,
		ServicePoint = 20,
		Shoot = 21,
		SpreadGas = 22,
		StoreItems = 23,
		GenericRole = 24,
		ClearPathAd = 25,
		DistractVendingMachine = 26,
		NPC = 27,
		Clue = 28,
		PlayerStash = 29,
		Wardrobe = 30
	}

	public enum EGenericNotificationPriority
	{
		Default = 0,
		Low = 1,
		Medium = 2,
		Height = 3
	}

	public enum EGlitchState
	{
		NONE = 0,
		DEFAULT = 1,
		SUBLIMINAL_MESSAGE = 2
	}

	public enum EGravityType
	{
		LowGravity = 0,
		Regular = 1
	}

	public enum EGrenadeType
	{
		Frag = 0,
		Flash = 1,
		Smoke = 2,
		Piercing = 3,
		EMP = 4,
		Biohazard = 5,
		Incendiary = 6,
		Recon = 7,
		Cutting = 8,
		Sonic = 9
	}

	public enum EHandEquipSlot
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public enum EHitReactionMode
	{
		Regular = 0,
		ForceImpact = 1,
		ForceStagger = 2,
		ForceKnockdown = 3,
		Fragile = 4,
		Weak = 5,
		Tough = 6,
		Bulky = 7,
		Unstoppable = 8,
		UnstoppableTwitchMin = 9,
		UnstoppableTwitchNone = 10,
		StaggerMin = 11,
		BulkyStaggerMin = 12,
		Invalid = 13
	}

	public enum EHitReactionZone
	{
		Head = 0,
		ChestLeft = 1,
		ArmLeft = 2,
		HandLeft = 3,
		ChestRight = 4,
		ArmRight = 5,
		HandRight = 6,
		Abdomen = 7,
		LegLeft = 8,
		LegRight = 9,
		Special = 10
	}

	public enum EHitShapeType
	{
		None = -1,
		Flesh = 0,
		Metal = 1,
		Cyberware = 2,
		Armor = 3
	}

	public enum EHotkeyRequestType
	{
		Assign = 0,
		Cycle = 1,
		Restore = 2
	}

	public enum EHudAvatarMode
	{
		Connecting = 0,
		Disconnecting = 1,
		Holocall = 2,
		Audiocall = 3
	}

	public enum EHudPhoneFunction
	{
		Inactive = 0,
		DisplayingMessage = 1,
		IncomingCall = 2,
		Holocall = 3,
		Audiocall = 4
	}

	public enum EHudPhoneVisibility
	{
		Invisible = 0,
		Showing = 1,
		Visible = 2,
		Hiding = 3
	}

	public enum EIndustrialArmAnimations
	{
		Idle = 0,
		RepairLoop = 1,
		RepairLoop2 = 2,
		RepairLoopBroken = 3,
		RepairLoopBelow = 4,
		RepairLoopBelowBroken = 5,
		CarDestroy = 6,
		Repair_below_loop_high = 7,
		Repair_below_loop_low = 8,
		Repair_below_loop_medium = 9,
		Repair_loop_high = 10,
		Repair_loop_medium = 11
	}

	public enum EInitReactionAnim
	{
		Shock = 0,
		Fear = 1,
		Curious = 2,
		Call = 3
	}

	public enum EInkAnimationPlaybackOption
	{
		PLAY = 0,
		STOP = 1,
		PAUSE = 2,
		RESUME = 3,
		CONTINUE = 4,
		GO_TO_START = 5,
		GO_TO_END = 6
	}

	public enum EInputAction
	{
		IACT_None = 0,
		IACT_Press = 1,
		IACT_Release = 2,
		IACT_Axis = 3
	}

	public enum EInputCustomKey
	{
		ICK_Pad_DigitLeftRight = 273,
		ICK_Pad_DigitUpDown = 274,
		ICK_Count = 275
	}

	public enum EInputKey
	{
		IK_None = 0,
		IK_LeftMouse = 1,
		IK_RightMouse = 2,
		IK_MiddleMouse = 3,
		IK_Unknown04 = 4,
		IK_Unknown05 = 5,
		IK_Unknown06 = 6,
		IK_Unknown07 = 7,
		IK_Backspace = 8,
		IK_Tab = 9,
		IK_Unknown0A = 10,
		IK_Unknown0B = 11,
		IK_Unknown0C = 12,
		IK_Enter = 13,
		IK_Unknown0E = 14,
		IK_Unknown0F = 15,
		IK_Shift = 16,
		IK_Ctrl = 17,
		IK_Alt = 18,
		IK_Pause = 19,
		IK_CapsLock = 20,
		IK_Unknown15 = 21,
		IK_Unknown16 = 22,
		IK_Unknown17 = 23,
		IK_Unknown18 = 24,
		IK_Unknown19 = 25,
		IK_Unknown1A = 26,
		IK_Escape = 27,
		IK_Unknown1C = 28,
		IK_Unknown1D = 29,
		IK_Unknown1E = 30,
		IK_Unknown1F = 31,
		IK_Space = 32,
		IK_PageUp = 33,
		IK_PageDown = 34,
		IK_End = 35,
		IK_Home = 36,
		IK_Left = 37,
		IK_Up = 38,
		IK_Right = 39,
		IK_Down = 40,
		IK_Select = 41,
		IK_Print = 42,
		IK_Execute = 43,
		IK_PrintScrn = 44,
		IK_Insert = 45,
		IK_Delete = 46,
		IK_Help = 47,
		IK_0 = 48,
		IK_1 = 49,
		IK_2 = 50,
		IK_3 = 51,
		IK_4 = 52,
		IK_5 = 53,
		IK_6 = 54,
		IK_7 = 55,
		IK_8 = 56,
		IK_9 = 57,
		IK_Unknown3A = 58,
		IK_Unknown3B = 59,
		IK_Unknown3C = 60,
		IK_Unknown3D = 61,
		IK_Unknown3E = 62,
		IK_Unknown3F = 63,
		IK_Unknown40 = 64,
		IK_A = 65,
		IK_B = 66,
		IK_C = 67,
		IK_D = 68,
		IK_E = 69,
		IK_F = 70,
		IK_G = 71,
		IK_H = 72,
		IK_I = 73,
		IK_J = 74,
		IK_K = 75,
		IK_L = 76,
		IK_M = 77,
		IK_N = 78,
		IK_O = 79,
		IK_P = 80,
		IK_Q = 81,
		IK_R = 82,
		IK_S = 83,
		IK_T = 84,
		IK_U = 85,
		IK_V = 86,
		IK_W = 87,
		IK_X = 88,
		IK_Y = 89,
		IK_Z = 90,
		IK_Unknown5B = 91,
		IK_Unknown5C = 92,
		IK_Unknown5D = 93,
		IK_Unknown5E = 94,
		IK_Unknown5F = 95,
		IK_NumPad0 = 96,
		IK_NumPad1 = 97,
		IK_NumPad2 = 98,
		IK_NumPad3 = 99,
		IK_NumPad4 = 100,
		IK_NumPad5 = 101,
		IK_NumPad6 = 102,
		IK_NumPad7 = 103,
		IK_NumPad8 = 104,
		IK_NumPad9 = 105,
		IK_NumStar = 106,
		IK_NumPlus = 107,
		IK_Separator = 108,
		IK_NumMinus = 109,
		IK_NumPeriod = 110,
		IK_NumSlash = 111,
		IK_F1 = 112,
		IK_F2 = 113,
		IK_F3 = 114,
		IK_F4 = 115,
		IK_F5 = 116,
		IK_F6 = 117,
		IK_F7 = 118,
		IK_F8 = 119,
		IK_F9 = 120,
		IK_F10 = 121,
		IK_F11 = 122,
		IK_F12 = 123,
		IK_F13 = 124,
		IK_F14 = 125,
		IK_F15 = 126,
		IK_F16 = 127,
		IK_F17 = 128,
		IK_F18 = 129,
		IK_F19 = 130,
		IK_F20 = 131,
		IK_F21 = 132,
		IK_F22 = 133,
		IK_F23 = 134,
		IK_F24 = 135,
		IK_Pad_A_CROSS = 136,
		IK_Pad_B_CIRCLE = 137,
		IK_Pad_X_SQUARE = 138,
		IK_Pad_Y_TRIANGLE = 139,
		IK_Pad_Start = 140,
		IK_Pad_Back_Select = 141,
		IK_Pad_DigitUp = 142,
		IK_Pad_DigitDown = 143,
		IK_Pad_DigitLeft = 144,
		IK_Pad_DigitRight = 145,
		IK_Pad_LeftThumb = 146,
		IK_Pad_RightThumb = 147,
		IK_Pad_LeftShoulder = 148,
		IK_Pad_RightShoulder = 149,
		IK_Pad_LeftTrigger = 150,
		IK_Pad_RightTrigger = 151,
		IK_Pad_LeftAxisX = 152,
		IK_Pad_LeftAxisY = 153,
		IK_Pad_RightAxisX = 154,
		IK_Pad_RightAxisY = 155,
		IK_NumLock = 156,
		IK_ScrollLock = 157,
		IK_Unknown9E = 158,
		IK_Unknown9F = 159,
		IK_LShift = 160,
		IK_RShift = 161,
		IK_LControl = 162,
		IK_RControl = 163,
		IK_UnknownA4 = 164,
		IK_UnknownA5 = 165,
		IK_UnknownA6 = 166,
		IK_UnknownA7 = 167,
		IK_UnknownA8 = 168,
		IK_UnknownA9 = 169,
		IK_UnknownAA = 170,
		IK_UnknownAB = 171,
		IK_UnknownAC = 172,
		IK_UnknownAD = 173,
		IK_UnknownAE = 174,
		IK_UnknownAF = 175,
		IK_UnknownB0 = 176,
		IK_UnknownB1 = 177,
		IK_UnknownB2 = 178,
		IK_UnknownB3 = 179,
		IK_UnknownB4 = 180,
		IK_UnknownB5 = 181,
		IK_UnknownB6 = 182,
		IK_UnknownB7 = 183,
		IK_UnknownB8 = 184,
		IK_Unicode = 185,
		IK_Semicolon = 186,
		IK_Equals = 187,
		IK_Comma = 188,
		IK_Minus = 189,
		IK_Period = 190,
		IK_Slash = 191,
		IK_Tilde = 192,
		IK_Mouse4 = 193,
		IK_Mouse5 = 194,
		IK_Mouse6 = 195,
		IK_Mouse7 = 196,
		IK_Mouse8 = 197,
		IK_UnknownC6 = 198,
		IK_UnknownC7 = 199,
		IK_Joy1 = 200,
		IK_Joy2 = 201,
		IK_Joy3 = 202,
		IK_Joy4 = 203,
		IK_Joy5 = 204,
		IK_Joy6 = 205,
		IK_Joy7 = 206,
		IK_Joy8 = 207,
		IK_Joy9 = 208,
		IK_Joy10 = 209,
		IK_Joy11 = 210,
		IK_Joy12 = 211,
		IK_Joy13 = 212,
		IK_Joy14 = 213,
		IK_Joy15 = 214,
		IK_Joy16 = 215,
		IK_UnknownD8 = 216,
		IK_UnknownD9 = 217,
		IK_UnknownDA = 218,
		IK_LeftBracket = 219,
		IK_Backslash = 220,
		IK_RightBracket = 221,
		IK_SingleQuote = 222,
		IK_UnknownDF = 223,
		IK_UnknownE0 = 224,
		IK_UnknownE1 = 225,
		IK_IntlBackslash = 226,
		IK_MouseHover = 227,
		IK_MouseX = 228,
		IK_MouseY = 229,
		IK_MouseZ = 230,
		IK_MouseW = 231,
		IK_JoyU = 232,
		IK_JoyV = 233,
		IK_JoySlider1 = 234,
		IK_JoySlider2 = 235,
		IK_MouseWheelUp = 236,
		IK_MouseWheelDown = 237,
		IK_UnknownEE = 238,
		IK_UnknownEF = 239,
		IK_JoyX = 240,
		IK_JoyY = 241,
		IK_JoyZ = 242,
		IK_JoyR = 243,
		IK_UnknownF4 = 244,
		IK_UnknownF5 = 245,
		IK_Attn = 246,
		IK_ClearSel = 247,
		IK_ExSel = 248,
		IK_ErEof = 249,
		IK_Play = 250,
		IK_Zoom = 251,
		IK_NoName = 252,
		IK_UnknownFD = 253,
		IK_UnknownFE = 254,
		IK_PS4_OPTIONS = 255,
		IK_PS4_TOUCH_PRESS = 256,
		IK_Pad_Fake_LeftAxis = 262,
		IK_Pad_Fake_RightAxis = 263,
		IK_Pad_Fake_RelativeLeftAxis = 264,
		IK_Pad_Fake_RelativeRightAxis = 265,
		IK_Pad_Fake_DigitLeftRight = 266,
		IK_Pad_Fake_DigitUpDown = 267,
		IK_STADIA_CAPTURE = 268,
		IK_SWITCH_CAPTURE = 269,
		IK_CAPTURE = 270,
		IK_Last = 271,
		IK_Count = 272,
		IK_Pad_First = 136,
		IK_Pad_Last = 155
	}

	public enum EInventoryComboBoxMode
	{
		FromInventory = 0,
		FromEquipment = 1,
		CustomizeFromEquipment = 2,
		CustomizeFromInventory = 3,
		CustomizeCyberware = 4
	}

	public enum EInventoryDataStatDisplayType
	{
		CompareBar = 0,
		DisplayBar = 1,
		Value = 2
	}

	public enum EItemOperationType
	{
		ADD = 0,
		REMOVE = 1
	}

	public enum EJuryrigTrapState
	{
		UNARMED = 0,
		ARMED = 1,
		TRIGGERED = 2
	}

	public enum EKnockdownStates
	{
		Invalid = 0,
		Start = 1,
		FallLoop = 2,
		Land = 3,
		Recovery = 4,
		AirRecovery = 5
	}

	public enum ELastUsed
	{
		Weapon = 0,
		Melee = 1,
		Ranged = 2,
		Heavy = 3
	}

	public enum ELaunchMode
	{
		Primary = 0,
		Secondary = 1,
		None = 2
	}

	public enum ELauncherActionType
	{
		QuickAction = 0,
		ChargeAction = 1,
		None = 2
	}

	public enum ELayoutType
	{
		Generic = 0,
		Militech = 1,
		Arasaka = 2,
		Zetatech = 3
	}

	public enum ELightSequenceStage
	{
		NONE = 0,
		INPROGRESS = 1,
		COMPLETE = 2
	}

	public enum ELightShadowCastingMode
	{
		LSCM_None = 0,
		LSCM_Normal = 1,
		LSCM_OnlyDynamic = 2,
		LSCM_OnlyStatic = 3,
		LSCM_NormalAndContact = 4,
		LSCM_OnlyContact = 5
	}

	public enum ELightShadowSoftnessMode
	{
		LSSM_ExtraSoft = 0,
		LSSM_Soft = 1,
		LSSM_Default = 2,
		LSSM_Sharp = 3,
		LSSM_ExtraSharp = 4
	}

	public enum ELightState
	{
		Reset = 0,
		DefaultColor = 1,
		Police = 2,
		VehicleHealth_Low = 3,
		VehicleHealth_VeryLow = 4,
		Quest = 5
	}

	public enum ELightSwitchRandomizerType
	{
		RANDOM = 0,
		RANDOM_PROGRESSIVE = 1,
		NONE = 2
	}

	public enum ELightType
	{
		LT_Point = 0,
		LT_Spot = 1,
		LT_Area = 2
	}

	public enum ELightUnit
	{
		LU_Lumen = 0,
		LU_Watt = 1,
		LU_Lux = 2,
		LU_Nit = 3,
		LU_EV100 = 4
	}

	public enum ELinkType
	{
		NETWORK = 0,
		GRID = 1,
		FREE = 2,
		INVALID = 3
	}

	public enum ELogType
	{
		DEFAULT = 0,
		WARNING = 1,
		ERROR = 2
	}

	public enum ELogicOperator
	{
		OR = 0,
		AND = 1
	}

	public enum EMagazineAmmoState
	{
		None = 0,
		FirstBullet = 1,
		LastBullet = 2
	}

	public enum EMalfunctioningType
	{
		NONE = 0,
		LOUD_ANNOUNCEMENT = 1,
		HALF_OPENING = 2,
		GLITCHING = 3
	}

	public enum EMappinDisplayMode
	{
		PLAYSTYLE = 0,
		ROLE = 1,
		MINIMALISTIC = 2
	}

	public enum EMappinVisualState
	{
		Default = 0,
		Available = 1,
		Unavailable = 2,
		Inactive = 3,
		None = 4
	}

	public enum EMaterialModifier
	{
		EMATMOD_HitProxy = 0,
		EMATMOD_WindData = 1,
		EMATMOD_ParticleParams = 2,
		EMATMOD_RemoteCamera = 3,
		EMATMOD_Mirror = 4,
		EMATMOD_CustomStructBuffer = 5,
		EMATMOD_MotionMatrix = 7,
		EMATMOD_ColorAndTexture = 8,
		EMATMOD_MaterialParams = 9,
		EMATMOD_Eye = 10,
		EMATMOD_Skin = 11,
		EMATMOD_Dismemberment = 13,
		EMATMOD_Garments = 14,
		EMATMOD_ShadowsDebugParams = 15,
		EMATMOD_MultilayeredDebug = 16,
		EMATMOD_ParallaxParams = 17,
		EMATMOD_HighlightsParams = 18,
		EMATMOD_DebugColoring = 19,
		EMATMOD_DrawBufferMask = 20,
		EMATMOD_AutoSpawnData = 21,
		EMATMOD_DestructionRegions = 22,
		EMATMOD_VehicleParams = 12,
		EMATMOD_EffectParams = 6,
		EMATMOD_FloatTracks = 23,
		EMATMOD_AutoHideDistance = 24,
		EMATMOD_Rain = 25,
		EMATMOD_PlanarReflections = 26,
		EMATMOD_WaterSim = 27,
		EMATMOD_TransparencyClipParams = 28,
		EMATMOD_FlatTireParams = 29,
		EMATMOD_MAX = 30
	}

	public enum EMaterialPriority : byte
	{
		EMP_Normal = 0,
		EMP_Front = 1
	}

	public enum EMaterialShaderTarget : byte
	{
		MSH_Invalid = 0,
		MSH_VertexShader = 1,
		MSH_PixelShader = 2,
		MSH_MAX = 3
	}

	public enum EMaterialShadingRateMode : byte
	{
		MSRM_Default = 0,
		MSRM_Disable = 1,
		MSRM_Force2x2 = 2
	}

	public enum EMaterialVertexFactory : byte
	{
		MVF_Terrain = 1,
		MVF_MeshStatic = 2,
		MVF_MeshSkinned = 3,
		MVF_MeshExtSkinned = 4,
		MVF_GarmentMeshSkinned = 5,
		MVF_GarmentMeshExtSkinned = 6,
		MVF_MeshSpeedTree = 7,
		MVF_ParticleBilboard = 8,
		MVF_ParticleParallel = 9,
		MVF_ParticleMotionBlur = 10,
		MVF_ParticleSphereAligned = 11,
		MVF_ParticleVerticalFixed = 12,
		MVF_ParticleTrail = 13,
		MVF_ParticleFacingTrail = 14,
		MVF_ParticleScreen = 15,
		MVF_ParticleBeam = 16,
		MVF_ParticleFacingBeam = 17,
		MVF_Decal = 18,
		MVF_Debug = 19,
		MVF_DrawBuffer = 20,
		MVF_Fullscreen = 21,
		MVF_MeshSkinnedVehicle = 22,
		MVF_MeshStaticVehicle = 23,
		MVF_MeshProcedural = 24,
		MVF_MeshDestructible = 25,
		MVF_MeshDestructibleSkinned = 26,
		MVF_MeshSkinnedLightBlockers = 27,
		MVF_MeshExtSkinnedLightBlockers = 28,
		MVF_GarmentMeshSkinnedLightBlockers = 29,
		MVF_GarmentMeshExtSkinnedLightBlockers = 30,
		MVF_MeshSkinnedSingleBone = 31,
		MVF_MeshProxy = 32,
		MVF_MeshWindowProxy = 33
	}

	public enum EMathOperationType
	{
		Add = 0,
		Set = 1
	}

	public enum EMathOperator
	{
		None = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Divide = 4
	}

	public enum EMeasurementSystem
	{
		Metric = 0,
		Imperial = 1
	}

	public enum EMeasurementUnit
	{
		Millimeter = 0,
		Centimeter = 1,
		Meter = 2,
		Kilometer = 3,
		Inch = 4,
		Feet = 5,
		Yard = 6,
		Mile = 7,
		NauticalMile = 8,
		SquareMillimeter = 9,
		SquareCentimeter = 10,
		SquareMeter = 11,
		Hectare = 12,
		SquareKilometer = 13,
		SquareInch = 14,
		SquareFeet = 15,
		SquareYard = 16,
		Acre = 17,
		SquareMile = 18,
		CubicCentimer = 19,
		CubicDecimeter = 20,
		CubicMeter = 21,
		Liter = 22,
		Hectoliter = 23,
		CubicInch = 24,
		CubicFeet = 25,
		FluidOunce = 26,
		Pint = 27,
		Gallon = 28,
		Gram = 29,
		Kilogram = 30,
		Tonne = 31,
		Ounce = 32,
		Pound = 33,
		Stone = 34,
		Celcius = 35,
		Fahrenheit = 36,
		MAX = 37
	}

	public enum EMeleeAttackType
	{
		Combo = 0,
		Strong = 1,
		Final = 2,
		Block = 3,
		Safe = 4,
		Slide = 5,
		Crouch = 6,
		Jump = 7,
		Sprint = 8,
		Fall = 9,
		Throw = 10,
		Dodge = 11,
		Equip = 12
	}

	public enum EMeleeAttacks
	{
		Invalid = 0,
		LightAtk_Left = 1,
		LightAtk_Right = 2,
		ComboAtk_3hits_Part1 = 3,
		ComboAtk_3hits_Part2 = 4,
		ComboAtk_3hits_Part3 = 5,
		ChargeAttack = 6
	}

	[Flags]
	public enum EMeshChunkFlags
	{
		MCF_RenderInScene = 1 << 0,
		MCF_RenderInShadows = 1 << 1,
		MCF_IsTwoSided = 1 << 2,
		MCF_IsRayTracedEmissive = 1 << 3,
		MCF_IsPrefabProxy = 1 << 6,
		MCF_ConsoleLOD0 = 1 << 9,
		MCF_SkipDynamicDecalGeneration = 1 << 10
	}

	[Flags]
	public enum EMeshChunkRenderMask
	{
		MCR_Scene = 1 << 0,
		MCR_Cascade1 = 1 << 1,
		MCR_Cascade2 = 1 << 2,
		MCR_Cascade3 = 1 << 3,
		MCR_Cascade4 = 1 << 4,
		MCR_LocalShadows = 1 << 5,
		MCR_IsTwoSided = 1 << 6,
		MCR_DistantShadows = 1 << 7,
		MCR_IsRayTracedEmissive = 1 << 8,
		MCR_PrefabProxy = 1 << 11,
		MCR_Cascades = 1 << 12
	}

	public enum EMeshParticleOrientationMode
	{
		MPOM_Normal = 0,
		MPOM_MovementDirection = 1,
		MPOM_NoRotation = 2
	}

	public enum EMeshShadowImportanceBias
	{
		MSIB_EvenLessImportant = -2,
		MSIB_LessImportant = -1,
		MSIB_Default = 0,
		MSIB_MoreImportant = 1,
		MSIB_EvenMoreImportant = 2
	}

	public enum EMeshStreamType
	{
		MST_Position_3F = 1,
		MST_SkinningIndices_4U8 = 2,
		MST_SkinningWeights_4F = 4,
		MST_SkinningIndicesExt_4U8 = 262144,
		MST_SkinningWeightsExt_4F = 524288,
		MST_Color_U32 = 8,
		MST_TexCoord0_2F = 16,
		MST_TexCoord1_2F = 32,
		MST_Normal_3F = 64,
		MST_Tangent_3F = 128,
		MST_Binormal_3F = 256,
		MST_DestructionIndices_2U16 = 1048576,
		MST_Multilayer_1F = 2097152,
		MST_Index_U16 = 512,
		MST_GarmentFlags_U32 = 4194304,
		MST_MorphOffset_3F = 8388608,
		MST_VehicleDmgNormalFront_3F = 16777216,
		MST_VehicleDmgNormalSides_3F = 33554432,
		MST_VehicleDmgPosFront_3F = 67108864,
		MST_VehicleDmgPosSides_3F = 134217728,
		MST_WindBranchData_4F = 1024,
		MST_BranchData_7F = 16384,
		MST_MorphVertexData_3F = 268435456,
		MST_FoliageBoneId_I16 = 536870912,
		MST_LightBlockerIntensity_1F = 1073741824
	}

	public enum EMeshVertexType
	{
		MVT_StaticMesh = 0,
		MVT_ProceduralMesh = 1,
		MVT_SkinnedMesh = 2,
		MVT_ExtSkinnedMesh = 3,
		MVT_GarmentSkinnedMesh = 4,
		MVT_ExtGarmentSkinnedMesh = 5,
		MVT_SpeedTreeMesh = 6,
		MVT_StaticMeshVehicle = 7,
		MVT_SkinnedMeshVehicle = 8,
		MVT_Terrain = 9,
		MVT_DestructibleMesh = 10,
		MVT_DestructibleMeshSkinned = 11,
		MVT_SkinnedMeshLightBlocker = 12,
		MVT_ExtSkinnedMeshLightBlocker = 13,
		MVT_GarmentSkinnedMeshLightBlocker = 14,
		MVT_ExtGarmentSkinnedMeshLightBlocker = 15,
		MVT_SkinnedMeshSingleBone = 16,
		MVT_ProxyMesh = 17,
		MVT_ProxyWindowMesh = 18
	}

	public enum EMissileRainPhase
	{
		Init = 0,
		Phase1 = 1,
		Phase2 = 2
	}

	public enum EMoveAssistLevel
	{
		Off = 0,
		SpecialAttacks = 1,
		AllAttacks = 2
	}

	public enum EMovementDirection
	{
		left = 0,
		right = 1,
		up = 2,
		down = 3,
		front = 4,
		back = 5
	}

	public enum ENPCPhaseState
	{
		Phase1 = 0,
		Phase2 = 1,
		Phase3 = 2,
		Phase4 = 3,
		Phase5 = 4,
		Invalid = 5
	}

	public enum ENPCTelemetryData
	{
		HitByLightAttack = 0,
		HitByStrongAttack = 1,
		HitByFinalComboAttack = 2,
		HitByBlockAttack = 3,
		BlockedAttack = 4,
		DeflectedAttack = 5,
		WasGuardBreaked = 6
	}

	public enum ENcartDistricts
	{
		WATSON = 0,
		CITY_CENTER = 1,
		JAPAN_TOWN = 2,
		HEYWOOD = 3,
		PACIFICA = 4,
		SANTO_DOMINGO = 5,
		ERROR = 6
	}

	public enum ENcartStations
	{
		NONE = 0,
		ARASAKA_WATERFRONT = 1,
		LITTLE_CHINA_HOSPITAL = 2,
		LITTLE_CHINA_NORTH = 3,
		LITTLE_CHINA_SOUTH = 4,
		JAPAN_TOWN_NORTH = 5,
		JAPAN_TOWN_SOUTH = 6,
		DOWNTOWN_NORTH = 7,
		ARROYO = 8,
		CITY_CENTER = 9,
		ARASAKA_TOWER = 10,
		WELLSPRINGS = 11,
		GLEN_NORTH = 12,
		GLEN_SOUTH = 13,
		VISTA_DEL_REY = 14,
		RANCHO_CORONADO = 15,
		LITTLE_CHINA_MEGABUILDING = 16,
		CHARTER_HILL = 17,
		GLEN_EBUNIKE = 18,
		PACIFICA_STADIUM = 19
	}

	public enum ENetworkRelation
	{
		MASTER = 0,
		SLAVE = 1,
		NONE = 2
	}

	public enum ENeutralizeType
	{
		None = 0,
		Killed = 1,
		Defeated = 2,
		Unconscious = 3
	}

	public enum ENoiseType
	{
		NT_Random = 0,
		NT_Simplex2D = 1,
		NT_Simplex3D = 2
	}

	public enum EOperationClassType
	{
		Local = 0,
		BaseState = 1,
		DoorState = 2,
		BaseAction = 3,
		CustomActions = 4,
		TriggerVolume = 5,
		Hit = 6,
		InteractionArea = 7,
		Senses = 8,
		FocusMode = 9
	}

	public enum EOutlineType
	{
		NONE = 0,
		GREEN = 1,
		RED = 2,
		YELLOW = 3
	}

	public enum EParticleEventSpawnObject
	{
		PESO_Particle = 0,
		PESO_Decal = 1
	}

	public enum EParticleEventType
	{
		PET_Any = 5,
		PET_Death = 0,
		PET_OverLife = 1,
		PET_OverDistance = 2,
		PET_Collision = 3,
		PET_PlayOneShotSoundOnSpawn = 4
	}

	public enum EPaymentSchedule
	{
		WEEKLY = 0,
		MONTHLY = 1
	}

	public enum EPermissionSource
	{
		GAMEPLAY = 0,
		PLAYER = 1,
		QUEST = 2
	}

	public enum EPersonalLinkConnectionStatus
	{
		NOT_CONNECTED = 0,
		CONNECTING = 1,
		CONNECTED = 2,
		DISCONNECTING = 3
	}

	public enum EPersonalLinkSlotSide
	{
		FRONT = 0,
		RIGHT = 1,
		BOTTOM = 2
	}

	public enum EPingType
	{
		DIRECT = 0,
		SPACE = 1
	}

	public enum EPlayerMovementDirection
	{
		Forward = 0,
		Right = 1,
		Back = 2,
		Left = 3
	}

	public enum EPlaystyle
	{
		NETRUNNER = 0,
		SOLO = 1,
		TECHIE = 2
	}

	public enum EPlaystyleType
	{
		NONE = -1,
		TECHIE = 0,
		NETRUNNER = 1,
		TECHIE_AND_NETRUNNER = 2
	}

	public enum EPreventionDebugProcessReason
	{
		Redirected_IsPsycho = 0,
		Process_NewDamage = 1,
		Process_EntityCalls = 2,
		Abort_EntitySame = 3,
		Abort_DamageZero = 4,
		Abort_SystemLockedBySceneTier = 5
	}

	public enum EPreventionHackLoopState
	{
		IDLE = 0,
		INTRO_RADIO = 1,
		HACK_LOOP = 2
	}

	public enum EPreventionHeatStage
	{
		Heat_0 = 0,
		Heat_1 = 1,
		Heat_2 = 2,
		Heat_3 = 3,
		Heat_4 = 4,
		Heat_5 = 5,
		Size = 6,
		Invalid = 7
	}

	public enum EPreventionSystemInstruction
	{
		Safe = 0,
		Active = 1,
		Off = 2,
		On = 3,
		ReconPhaseOn = 4,
		ReconPhaseOff = 5,
		Debug_BlinkStart = 6,
		Debug_BlinkStop = 7,
		Debug_SearchStart = 8,
		Debug_SearchStop = 9,
		Debug_Stars = 10
	}

	public enum EPriority
	{
		VeryLow = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		VeryHigh = 4,
		Absolute = 5
	}

	public enum EProgressBarContext
	{
		QuickHack = 0,
		PhoneCall = 1
	}

	public enum EProgressBarState
	{
		Available = 0,
		Blocked = 1,
		Invisible = 2
	}

	public enum EProgressBarType
	{
		UPLOAD = 0,
		DURATION = 1
	}

	public enum EQuestFilterType
	{
		DONT_CHANGE = 0,
		ALLOW_NONE = 1,
		ALLOW_COMBAT_ONLY = 2,
		ALLOW_ALL = 3
	}

	public enum ERadialMode
	{
		ApplyOnlyActiveSlot = 0,
		ApplyActiveSlotAndConsumables = 1
	}

	public enum ERadioStationList
	{
		AGGRO_INDUSTRIAL = 0,
		ELECTRO_INDUSTRIAL = 1,
		HIP_HOP = 2,
		AGGRO_TECHNO = 3,
		DOWNTEMPO = 4,
		ATTITUDE_ROCK = 5,
		POP = 6,
		LATINO = 7,
		METAL = 8,
		MINIMAL_TECHNO = 9,
		JAZZ = 10,
		GROWL = 11,
		DARK_STAR = 12,
		IMPULSE_FM = 13
	}

	public enum EReactLogSource
	{
		Undefined = 0,
		Detected = 1,
		StimEvent = 2,
		BehaviorCombatCheck = 3,
		BehaviorCombatTrigger = 4
	}

	public enum EReactionValue
	{
		Fear = 0,
		Aggressive = 1
	}

	public enum ERenderDynamicDecalAtlas
	{
		RDDA_1x1 = 0,
		RDDA_2x1 = 1,
		RDDA_2x2 = 2,
		RDDA_4x2 = 3,
		RDDA_4x4 = 4,
		RDDA_8x4 = 5
	}

	public enum ERenderDynamicDecalProjection
	{
		RDDP_Ortho = 0,
		RDDP_Sphere = 1
	}

	public enum ERenderMaterialType : byte
	{
		RMT_Standard = 0,
		RMT_Subsurface = 1,
		RMT_Cloth = 2,
		RMT_Eye = 3,
		RMT_Hair = 4,
		RMT_Foliage = 5
	}

	public enum ERenderMeshStreams
	{
		RMS_PositionSkinning = 1,
		RMS_TexCoords = 2,
		RMS_TangentFrame = 4,
		RMS_Extended = 8,
		RMS_Custom0 = 16,
		RMS_BindAll = 255
	}

	public enum ERenderObjectType : byte
	{
		ROT_Static = 0,
		ROT_Terrain = 1,
		ROT_Road = 2,
		ROT_Skinned = 20,
		ROT_Character = 21,
		ROT_Foliage = 22,
		ROT_Grass = 23,
		ROT_Vehicle = 24,
		ROT_Weapon = 25,
		ROT_Particle = 26,
		ROT_Enemy = 27,
		ROT_CustomCharacter1 = 12,
		ROT_CustomCharacter2 = 13,
		ROT_CustomCharacter3 = 14,
		ROT_Blackwall1 = 28,
		ROT_Blackwall2 = 29,
		ROT_MainPlayer = 15,
		ROT_NoAO = 16,
		ROT_NoLighting = 17,
		ROT_NoTXAA = 18
	}

	public enum ERenderProxyType : byte
	{
		RPT_None = 0,
		RPT_Mesh = 1,
		RPT_PointLight = 2,
		RPT_SpotLight = 3,
		RPT_AreaLight = 4,
		RPT_Particles = 5,
		RPT_Foliage = 6,
		RPT_SSDecal = 7,
		RPT_VectorField = 8,
		RPT_FogVolume = 9,
		RPT_GI = 10,
		RPT_ReflectionProbe = 11,
		RPT_MorphTargetMesh = 12,
		RPT_LightVolume = 13,
		RPT_DynamicDecalSpawner = 14,
		RPT_AutoSpawner = 15,
		RPT_LightBlocker = 16
	}

	public enum ERenderingMode
	{
		RM_HitProxies = 2,
		RM_Shaded = 0,
		RM_Shaded_NoAmbient = 1,
		RM_GBufferOnly = 3,
		RM_SafeMode = 4,
		RM_OverlayOnly = 5
	}

	public enum ERenderingPlane
	{
		RPl_Scene = 0,
		RPl_Background = 1,
		RPl_Weapon = 2
	}

	public enum ERentStatus
	{
		PAID = 0,
		OVERDUE = 1,
		EVICTED = 2
	}

	public enum EReprimandInstructions
	{
		INITIATE_FIRST = 0,
		INITIATE_SUCCESSIVE = 1,
		TAKEOVER = 2,
		CONCLUDE_SUCCESSFUL = 3,
		CONCLUDE_FAILED = 4,
		RELEASE_TO_ANOTHER_ENTITY = 5
	}

	public enum ERevealDurationType
	{
		TEMPORARY = 0,
		PERMANENT = 1
	}

	public enum ERevealPlayerType
	{
		DONT_REVEAL = 0,
		REVEAL_ONCE = 1
	}

	public enum ERevealState
	{
		STARTED = 0,
		CONTINUE = 1,
		STOPPED = 2
	}

	public enum ESSAOQualityLevel
	{
		SSAOQUALITY_VeryLow = 0,
		SSAOQUALITY_Low = 1,
		SSAOQUALITY_Medium = 2,
		SSAOQUALITY_High = 3,
		SSAOQUALITY_VeryHigh = 4
	}

	public enum ESaveFormat
	{
		SF_PNG = 2,
		SF_EXR = 32,
		SF_PNG_AND_EXR = 34
	}

	public enum EScreenRatio
	{
		Screen_21x9 = 0,
		Screen_9x21 = 1,
		Screen_9x16 = 2,
		Screen_3x4 = 3,
		Screen_4x3 = 4,
		Screen_1x1 = 5
	}

	public enum ESecurityAccessLevel
	{
		ESL_NONE = 0,
		ESL_LOCAL = 1,
		ESL_0 = 2,
		ESL_1 = 3,
		ESL_2 = 4,
		ESL_3 = 5,
		ESL_4 = 6
	}

	public enum ESecurityAreaType
	{
		DISABLED = 0,
		SAFE = 1,
		RESTRICTED = 2,
		DANGEROUS = 3
	}

	public enum ESecurityGateEntranceType
	{
		OnlySideA = 0,
		OnlySideB = 1,
		AnySide = 2
	}

	public enum ESecurityGateResponseType
	{
		AUDIOVISUAL_ONLY = 0,
		SEC_SYS_REPRIMAND = 1,
		SEC_SYS_COMBAT = 2
	}

	public enum ESecurityGateScannerIssueType
	{
		NoIssues = 0,
		ScannerEmpty = 1,
		Overcrowded = 2,
		TargetAlreadyScanned = 3
	}

	public enum ESecurityGateStatus
	{
		READY = 0,
		SCANNING = 1,
		THREAT_DETECTED = 2
	}

	public enum ESecurityNotificationType
	{
		REPRIMAND_SUCCESSFUL = -2,
		DEESCALATE = -1,
		DEFAULT = 0,
		ILLEGAL_ACTION = 1,
		REPRIMAND_ESCALATE = 2,
		DEVICE_DESTROYED = 3,
		ALARM = 4,
		SECURITY_GATE = 5,
		COMBAT = 6,
		QUEST = 7
	}

	public enum ESecuritySystemState
	{
		UNINITIALIZED = 0,
		SAFE = 1,
		ALERTED = 2,
		COMBAT = 3
	}

	public enum ESecurityTurretStatus
	{
		THREAT = -1,
		SHOOTING = 0,
		WORKING = 1,
		SCANING = 2,
		DAMAGED = 3
	}

	public enum ESecurityTurretType
	{
		SIMPLE = 0
	}

	public enum ESenseLogSource
	{
		Undefined = 0,
		AddToBlacklistEvent = 1,
		RemoveFromBlacklistEvent = 2,
		SecurityAreaCrossingPerimeter = 3
	}

	public enum ESensorDeviceStates
	{
		NONE = 0,
		IDLE = 1,
		IDLEFORCED = 2,
		TARGETLOCK = 3,
		TARGETLOSE = 4,
		TARGETRECEIVED = 5,
		REPRIMAND = 6,
		JAMMER = 7
	}

	public enum ESensorDeviceWakeState
	{
		NONE = -1,
		CLOSED = 0,
		WAKEN = 1,
		OPEN = 2
	}

	public enum EShouldChangeAttitude
	{
		PERSISTENTLY = 0,
		TEMPORARLY = 1
	}

	public enum ESmartBulletPhase
	{
		Init = 0,
		Parabolic = 1,
		Follow = 2,
		Linear = 3,
		Miss = 4
	}

	public enum ESmartHousePreset
	{
		MorningPreset = 0,
		EveningPreset = 1,
		NightPreset = 2
	}

	public enum ESoundStatusEffects
	{
		NONE = 0,
		DEAFENED = 1,
		SUPRESS_NOISE = 2
	}

	public enum ESpaceFillMode
	{
		JustifyLeft = 0,
		JustifyRight = 1,
		JustifyCenter = 2
	}

	public enum EStarState
	{
		Default = 0,
		Active = 1,
		Searching = 2,
		Blinking = 3
	}

	public enum EStatusEffectBehaviorType
	{
		Invalid = 0,
		Basic = 1,
		Stoppable = 2,
		Unstoppable = 3
	}

	public enum EStatusEffects
	{
		Invalid = 0,
		WeaponJammed = 1,
		Blind = 2,
		SmokeScreen = 3,
		Unconscious = 4,
		Burning = 5,
		Stun = 6,
		HeartAttack = 7,
		SuicideWithWeapon = 8,
		SuicideWithGrenade = 9,
		Wounded = 10,
		MonowireGrapple = 11,
		Exhausted = 12,
		Defeated = 13,
		Sleep = 14,
		Berserker = 15,
		Pain = 16,
		Sandevistan = 17,
		NetwatcherHackStage1 = 18,
		NetwatcherHackStage2 = 19,
		NetwatcherHackStage3 = 20,
		Count = 21
	}

	public enum ESurveillanceCameraState
	{
		Off = 0,
		Active = 1
	}

	public enum ESurveillanceCameraStatus
	{
		THREAT = -1,
		STREAMING = 0,
		WORKING = 1
	}

	public enum ESwitchAction
	{
		ToggleOn = 0,
		ToggleActivate = 1
	}

	public enum ESystemNotificationTypes
	{
		DiscOperationIndicator = 0,
		GenericNotModal = 1,
		AchievmentDebug = 2,
		GenericMenuInfo = 3,
		GenericYesNo = 4,
		Generic = 5,
		ExitGame = 6,
		StartNewGame = 7,
		NoDiscSpace = 8,
		OverwriteSaveFile = 9,
		OverwriteSaveFileXbCompatWarning = 10,
		LoadSaveFileInGame = 11,
		LoadSaveFile = 12,
		DeleteSaveFile = 13,
		TransferSaveFile = 14,
		CorruptedSaveFile = 15,
		UnreachableCloudFile = 16,
		RegionMismatchSaveFile = 17,
		NoPlayerProfile = 18,
		GameSaved = 19,
		SaveFailed = 20,
		UnavailableForGuest = 21,
		EnableTelemetry = 22,
		PointOfNoReturn = 23,
		PointOfNoReturnWithReward = 24,
		PointOfNoReturnLootAdded = 25,
		GenericMenuError = 26,
		ControllerReconnected = 27,
		ControllerDisconnected = 28,
		TrialPeriodEnded = 29,
		TrialPeriodTimer = 30,
		FailedToRemoveTransferredSave = 31,
		LoadModdedSaveFile = 32,
		MAX = 33,
		FirstModalHighPriority = 27
	}

	public enum ESystems
	{
		NONE = 0,
		SecuritySystem = 1,
		AccessPoints = 2,
		MaintenanceSystem = 3,
		PersonnelSystem = 4,
		SurveillanceSystem = 5
	}

	public enum ETVChannel
	{
		CH1 = 0,
		CH2 = 1,
		CH3 = 2,
		CH4 = 3,
		CH5 = 4,
		INVALID = 5
	}

	public enum ETakedownActionType
	{
		GrappleFailed = 0,
		Grapple = 1,
		Takedown = 2,
		TakedownNonLethal = 3,
		TakedownNetrunner = 4,
		TakedownMassiveTarget = 5,
		AerialTakedown = 6,
		LeapToTarget = 7,
		Struggle = 8,
		BreakFree = 9,
		TargetDead = 10,
		KillTarget = 11,
		SpareTarget = 12,
		ForceShove = 13,
		BossTakedown = 14,
		DisposalTakedown = 15,
		DisposalTakedownNonLethal = 16,
		None = 17
	}

	public enum ETakedownBossName
	{
		Smasher = 0,
		Oda = 1,
		Royce = 2,
		Sasquatch = 3,
		None = 4
	}

	public enum ETargetManagerAnimGraphState
	{
		MODELOOKAT = 0,
		IDLE = 1,
		JAMMED = 2
	}

	public enum ETauntType
	{
		Normal = 0,
		Melee = 1,
		Ranged = 2
	}

	public enum ETelemetryData
	{
		MeleeAttacksMade = 0,
		RangedAttacksMade = 1,
		BluelinesSelected = 2,
		MeleeKills = 3,
		RangedKills = 4,
		QuickHacksMade = 5,
		LegendaryItemsCrafted = 6
	}

	public enum ETextureAddressing : byte
	{
		TA_Wrap = 0,
		TA_Mirror = 1,
		TA_Clamp = 2,
		TA_MirrorOnce = 3,
		TA_Border = 4
	}

	public enum ETextureAnimationMode
	{
		TAM_Speed = 0,
		TAM_LifeTime = 1
	}

	[Flags]
	public enum ETextureChannel
	{
		TextureChannel_R = 1 << 0,
		TextureChannel_G = 1 << 1,
		TextureChannel_B = 1 << 2,
		TextureChannel_A = 1 << 3
	}

	public enum ETextureComparisonFunction : byte
	{
		TCF_None = 0,
		TCF_Less = 1,
		TCF_Equal = 2,
		TCF_LessEqual = 3,
		TCF_Greater = 4,
		TCF_NotEqual = 5,
		TCF_GreaterEqual = 6,
		TCF_Always = 7
	}

	public enum ETextureCompression
	{
		TCM_None, // = 0,
		TCM_DXTNoAlpha, // = 1,
		TCM_DXTAlpha, // = 2,
		TCM_RGBE, // = 3,
		TCM_Normalmap, // = 4,
		TCM_Normals_DEPRECATED, // = 5,
		TCM_NormalsHigh_DEPRECATED, // = 6,
		TCM_NormalsGloss_DEPRECATED, // = 7,
		TCM_TileMap, // = 8,
		TCM_DXTAlphaLinear, // = 9,
		TCM_QualityR, // = 10,
		TCM_QualityRG, // = 11,
		TCM_QualityColor, // = 12,
		TCM_HalfHDR_Unsigned, // = 13,
		TCM_HalfHDR_Signed, // = 14,
		TCM_Max, // = 15,
		TCM_Normals, // = 5,
		TCM_NormalsHigh, // = 6,
		TCM_NormalsGloss, // = 7,
		TCM_HalfHDR, // = 13
	}

	public enum ETextureFilteringMag : byte
	{
		TFMag_Point = 0,
		TFMag_Linear = 1
	}

	public enum ETextureFilteringMin : byte
	{
		TFMin_Point = 0,
		TFMin_Linear = 1,
		TFMin_Anisotropic = 2,
		TFMin_AnisotropicLow = 3
	}

	public enum ETextureFilteringMip : byte
	{
		TFMip_None = 0,
		TFMip_Point = 1,
		TFMip_Linear = 2
	}

	public enum ETextureRawFormat
	{
		TRF_Invalid, // = 0,
		TRF_TrueColor, // = 1,
		TRF_DeepColor, // = 2,
		TRF_Grayscale, // = 3,
		TRF_HDRFloat, // = 4,
		TRF_HDRHalf, // = 5,
		TRF_HDRFloatGrayscale, // = 6,
		TRF_Grayscale_Font, // = 7,
		TRF_R8G8, // = 8,
		TRF_R32UI, // = 9,
        TRF_Max, // = 0
	}

	public enum ETimeOfYearSeason
	{
		ETOYS_Spring = 0,
		ETOYS_Summer = 1,
		ETOYS_Autumn = 2,
		ETOYS_Winter = 3
	}

	public enum EToggleActivationTypeComputer
	{
		None = 0,
		Raise = 1
	}

	public enum EToggleOperationType
	{
		ADD = 0,
		REMOVE = 1
	}

	public enum ETooltipsStyle
	{
		Menus = 0,
		HUD = 1
	}

	public enum ETransformAnimationOperationType
	{
		PLAY = 0,
		PAUSE = 1,
		RESET = 2,
		SKIP = 3
	}

	public enum ETransitionMode
	{
		GENTLE = 0,
		FORCED = 1
	}

	public enum ETransitionType
	{
		EET_Linear = 0,
		EET_Sine = 1,
		EET_Cubic = 2,
		EET_Quad = 3,
		EET_Quart = 4,
		EET_Quint = 5,
		EET_Expo = 6,
		EET_Circ = 7,
		EET_Back = 8,
		EET_Bounce = 9,
		EET_Elastic = 10
	}

	public enum ETrap
	{
		Invalid = 0,
		GridRegen = 1,
		AppendStart = 2,
		Hidden = 3,
		Virus = 4
	}

	public enum ETrapEffects
	{
		Explosion = 0,
		Poisoned = 1,
		Bleeding = 2,
		Burning = 3,
		Blind = 4,
		SmokeScreen = 5,
		Stun = 6,
		Unconcious = 7
	}

	public enum ETriggerOperationType
	{
		ENTER = 0,
		EXIT = 1
	}

	public enum ETweakAINodeType
	{
		Action = 0,
		Selector = 1,
		Sequence = 2
	}

	public enum EUIActionState
	{
		Invalid = 0,
		DEFAULT = 1,
		STARTED = 2,
		COMPLETED = 3,
		ABORTED = 4
	}

	public enum EUIStealthIconType
	{
		Invalid = 0,
		HostileHuman = 1,
		Camera = 2,
		Turret = 3,
		Drone = 4
	}

	public enum EUploadProgramState
	{
		STARTED = 0,
		COMPLETED = 1
	}

	public enum EVarDBMode
	{
		Add = 0,
		Set = 1,
		Invalid = 2
	}

	public enum EVehicleBrandState
	{
		Default = 0,
		New = 1,
		Selected = 2
	}

	public enum EVehicleOfferState
	{
		Default = 0,
		New = 1,
		Owned = 2,
		Locked = 3
	}

	public enum EVehicleSpawnBlockSide
	{
		Front = 0,
		Back = 1,
		Left = 2,
		Right = 3,
		Default = 4
	}

	public enum EVendorMode
	{
		BuyItems = 0,
		SellItems = 1,
		Train = 2,
		Ripperdoc = 3,
		RipperdocSummary = 4
	}

	public enum EViabilityDecision
	{
		INCONCLUSIVE = 0,
		VIABLE = 1,
		NONVIABLE = 2
	}

	public enum EVirtualSystem
	{
		None = 0,
		SurveillanceSystem = 1,
		DoorSystem = 2,
		MediaSystem = 3,
		SecuritySystem = 4
	}

	public enum EVisionBlockerType
	{
		Smoke = 0,
		OpticalCamo = 1,
		OpticalCamoLegendary = 2,
		Undefined = 32
	}

	public enum EWeaponNamesList
	{
		EWNL_PowerStreetRifle = 0,
		EWNL_TechStreetShotgun = 1,
		EWNL_PowerCorpHandgun = 2,
		EWNL_SmartCorpRifle = 3,
		EWNL_PowerCorpHandgunJackie = 4
	}

	public enum EWidgetPlacementType
	{
		DOCKED = 0,
		FLOATING = 1
	}

	public enum EWidgetState
	{
		DEFAULT = 0,
		ON = 1,
		OFF = 2,
		INACTIVE = 3,
		ALLOWED = 4,
		LOCKED = 5,
		SEALED = 6
	}

	public enum EWindowBlindersStates
	{
		NonInteractive = 0,
		Open = 1,
		Closed = 2,
		Tilted = 3
	}

	public enum EWorkspotOperationType
	{
		ENTER = 0,
		LEAVE = 1
	}

	public enum EWorldMapView
	{
		Map = 0
	}

	public enum EWoundedBodyPart
	{
		Invalid = 0,
		WoundedLeftArm = 1,
		WoundedRightArm = 2,
		WoundedLeftLeg = 3,
		WoundedRightLeg = 4,
		DismemberedLeftArm = 5,
		DismemberedRightArm = 6,
		DismemberedLeftLeg = 7,
		DismemberedRightLeg = 8,
		DismemberedBothLegs = 9
	}

	public enum EntityNotificationType
	{
		DoNotNotifyEntity = 0,
		SendThisEventToEntity = 1,
		SendPSChangedEventToEntity = 2
	}

	public enum EquipmentManipulationAction
	{
		Undefined = 0,
		RequestActiveMeleeware = 1,
		RequestActiveWeapon = 2,
		RequestSlotActiveWeapon = 3,
		RequestLastUsedWeapon = 4,
		RequestFirstMeleeWeapon = 5,
		RequestLastUsedMeleeWeapon = 6,
		RequestLastUsedOrFirstAvailableWeapon = 7,
		RequestLastUsedOrFirstAvailableRangedWeapon = 8,
		RequestLastUsedOrFirstAvailableMeleeWeapon = 9,
		RequestLastUsedOrFirstAvailableOneHandedRangedWeapon = 10,
		RequestLastUsedOrFirstAvailableDriverCombatRangedWeapon = 11,
		RequestLastUsedOrFirstAvailableDriverCombatBikeWeapon = 12,
		RequestHeavyWeapon = 13,
		CycleWeaponWheelItem = 14,
		CycleNextWeaponWheelItem = 15,
		CyclePreviousWeaponWheelItem = 16,
		RequestConsumable = 17,
		RequestGadget = 18,
		RequestFists = 19,
		RequestLeftHandCyberware = 20,
		UnequipWeapon = 21,
		UnequipConsumable = 22,
		UnequipGadget = 23,
		UnequipLeftHandCyberware = 24,
		UnequipAll = 25,
		ReequipWeapon = 26,
		RequestWeaponSlot1 = 27,
		RequestWeaponSlot2 = 28,
		RequestWeaponSlot3 = 29,
		RequestWeaponSlot4 = 30,
		RequestNextThrowableWeapon = 31
	}

	public enum EquipmentManipulationRequestSlot
	{
		Undefined = 0,
		Right = 1,
		Left = 2,
		Both = 3
	}

	public enum EquipmentManipulationRequestType
	{
		Undefined = 0,
		Equip = 1,
		Unequip = 2
	}

	public enum EquipmentPriority
	{
		Primary = 0,
		Secondary = 1,
		All = 2
	}

	public enum EstatusEffectsState
	{
		Deactivated = 0,
		Activating = 1,
		Activated = 2
	}

	public enum ExpansionErrorType
	{
		PurchaseFailed = 0,
		PurchaseDisabled = 1,
		InstallFailed = 2,
		InstallRequestFailed = 3,
		InstallDisabled = 4,
		DataInvalid = 5
	}

	public enum ExpansionPopupType
	{
		Default = 0,
		Features = 1,
		ThankYou = 2,
		Reloading = 3,
		PreOrder = 4
	}

	public enum ExpansionStatus
	{
		NotAvailable = 0,
		Available = 1,
		Owned = 2,
		Downloaded = 3,
		Downloading = 4,
		DownloadError = 5,
		Reloading = 6,
		Processing = 7,
		PreOrder = 8,
		PreOrderOwned = 9
	}

	public enum ExplosiveTriggerDeviceLaserState
	{
		GREEN = 0,
		RED = 1,
		DISABLED = 2
	}

	public enum ExtraEffect
	{
		AccuracyVirus = 0,
		PeernoidVirus = 1,
		None = 2
	}

	public enum FTEntityRequirementsFlag : ulong
	{
		None = 0,
		LookAtComponent = 1,
		ScanningComponent = 2,
		DestructionComponent = 4,
		GameObject = 8,
		ScriptedPuppet = 16,
		AttitudeAgent = 32,
		Device = 64,
		VehicleObject = 128,
		GamePuppet = 256
	}

	public enum FTNpcMountingState
	{
		Mounted = 0,
		Unmounted = 1
	}

	public enum Ft_Result
	{
		Success = 0,
		GettingPlayerGameObjectFailed = 1,
		GetPSMBlackboardFailed = 2,
		GetStatsPoolFailed = 3,
		NoEnemyFoundInSpawner = 4,
		NoEnemyFoundInPool = 5,
		NoEntitiesFoundInSpawner = 6,
		NoEnemyTargeted = 7,
		FailedToSelectGrapple = 8,
		FailedToSelectTakedown = 9,
		TakedownWithoutGrappleAttempt = 10,
		NoInteractionAvailable = 11,
		RequestedInteractionNotAvailable = 12,
		OutOfRange = 13,
		TargetNotInEnemyPool = 14,
		DescriptorFormatError = 15
	}

	public enum Ft_TakedownStage
	{
		Default = 0,
		Grappling = 1,
		Grappled = 2,
		Takedown = 3,
		Finished = 4
	}

	public enum Ft_TakedownType
	{
		Lethal = 0,
		Nonlethal = 1,
		Breach = 2
	}

	public enum FunctionalTestsResultCode
	{
		Valid = 0,
		MalformedEntityDescr = 1,
		EntityNotFound = 2,
		ComponentNotFound = 3,
		InvalidEntityType = 4,
		InvalidComponentType = 5,
		InvalidNodeRef = 6,
		SlotNotFound = 7,
		InventoryError = 8,
		InvalidInputAction = 9,
		InvalidInputActionCallback = 10,
		EmptyContainer = 12
	}

	public enum GIGIOverrideType : byte
	{
		Default = 0,
		Override_True = 1,
		Override_False = 2
	}

	public enum GameplayTier
	{
		Undefined = 0,
		Tier1_FullGameplay = 1,
		Tier2_StagedGameplay = 2,
		Tier3_LimitedGameplay = 3,
		Tier4_FPPCinematic = 4,
		Tier5_Cinematic = 5
	}

	public enum GenericMessageNotificationResult
	{
		Cancel = 0,
		Confirm = 1,
		OK = 2,
		Yes = 3,
		No = 4
	}

	public enum GenericMessageNotificationType
	{
		OK = 0,
		Confirm = 1,
		Cancel = 2,
		ConfirmCancel = 3,
		YesNo = 4
	}

	public enum GenericNotificationType
	{
		Generic = 0,
		JournalNotification = 1,
		LevelUpNotification = 2,
		VendorNotification = 3,
		ZoneNotification = 4,
		ProgressionNotification = 5,
		CraftingNotification = 6,
		InventoryNotification = 7,
		PhoneNotification = 8
	}

	public enum GogPopupScreenType
	{
		Default = 0,
		Rewards = 1,
		Invalid = -1
	}

	public enum GpuApieBufferUsageType : byte
	{
		BUT_Default = 0,
		BUT_Immutable = 1,
		BUT_Readback = 2,
		BUT_Dynamic_Legacy = 3,
		BUT_Transient = 4,
		BUT_Mapped = 5,
		BUT_MAX = 6
	}

	public enum GpuWrapApiBufferGroup : byte
	{
		System = 0,
		MeshResource = 1,
		MeshCustom = 2,
		AutoSpawner = 3,
		Debug = 4,
		DPL = 5,
		Weather = 6,
		ReflectionProbe = 7,
		Skinning = 8,
		Lights = 9,
		Video = 10,
		Particles = 11,
		GIManagerLitProbes = 12,
		GIManagerLookup = 13,
		GIManagerInterpolation = 14,
		GIManagerLitBricks = 15,
		GIManagerLights = 16,
		GIManagerEnvVolume = 17,
		GIProxyBrick = 18,
		GIProxySurfel = 19,
		GIProxyProbes = 20,
		GIProxyFactors = 21,
		GIProxyAcceleration = 22,
		Raytracing = 23,
		RaytracingUpload = 24,
		RaytracingAS = 25,
		RaytracingOMM = 26,
		Decals = 27,
		Instances = 28,
		Materials = 29,
		Multilayer = 30,
		FrameResources = 31,
		Misc = 32,
		MorphTargets = 33,
		MAX = 34
	}

	public enum GpuWrapApiVertexPackingEStreamType : sbyte
	{
		ST_Invalid = -1,
		ST_PerVertex = 0,
		ST_PerInstance = 1,
		ST_Max = 2
	}

	public enum GpuWrapApiVertexPackingePackingType : sbyte
	{
		PT_Invalid = -1,
		PT_Float1 = 0,
		PT_Float2 = 1,
		PT_Float3 = 2,
		PT_Float4 = 3,
		PT_Float16_2 = 4,
		PT_Float16_4 = 5,
		PT_UShort1 = 6,
		PT_UShort2 = 7,
		PT_UShort4 = 8,
		PT_UShort4N = 9,
		PT_Short1 = 10,
		PT_Short2 = 11,
		PT_Short4 = 12,
		PT_Short4N = 13,
		PT_UInt1 = 14,
		PT_UInt2 = 15,
		PT_UInt3 = 16,
		PT_UInt4 = 17,
		PT_Int1 = 18,
		PT_Int2 = 19,
		PT_Int3 = 20,
		PT_Int4 = 21,
		PT_Color = 22,
		PT_UByte1 = 23,
		PT_UByte1F = 24,
		PT_UByte4 = 25,
		PT_UByte4N = 26,
		PT_Byte4N = 27,
		PT_Dec4 = 28,
		PT_Index16 = 29,
		PT_Index32 = 30,
		PT_Max = 31
	}

	public enum GpuWrapApiVertexPackingePackingUsage : sbyte
	{
		PS_Invalid = -1,
		PS_SysPosition = 0,
		PS_Position = 1,
		PS_Normal = 2,
		PS_Tangent = 3,
		PS_Binormal = 4,
		PS_TexCoord = 5,
		PS_Color = 6,
		PS_SkinIndices = 7,
		PS_SkinWeights = 8,
		PS_DestructionIndices = 9,
		PS_MultilayerPaint = 10,
		PS_InstanceTransform = 11,
		PS_InstanceLODParams = 12,
		PS_InstanceSkinningData = 13,
		PS_PatchSize = 14,
		PS_PatchBias = 15,
		PS_ExtraData = 16,
		PS_VehicleDmgNormal = 17,
		PS_VehicleDmgPosition = 18,
		PS_PositionDelta = 19,
		PS_LightBlockerIntensity = 20,
		PS_BoneIndex = 21,
		PS_Padding = 22,
		PS_PatchOffset = 23,
		PS_Max = 24
	}

	public enum GpuWrapApieBufferChunkCategory : byte
	{
		BCC_Staging = 0,
		BCC_Vertex = 1,
		BCC_VertexUAV = 2,
		BCC_Index16Bit = 3,
		BCC_Index32Bit = 4,
		BCC_VertexIndex16Bit = 5,
		BCC_Constant = 6,
		BCC_TypedUAV = 7,
		BCC_Structured = 8,
		BCC_StructuredUAV = 9,
		BCC_StructuredAppendUAV = 10,
		BCC_IndirectUAV = 11,
		BCC_Index16BitUAV = 12,
		BCC_Raw = 13,
		BCC_ShaderTable = 14,
		BCC_Invalid = 15
	}

	public enum GpuWrapApieIndexBufferChunkType : byte
	{
		IBCT_IndexUInt = 0,
		IBCT_IndexUShort = 1,
		IBCT_Max = 2
	}

	public enum GpuWrapApieTextureFormat : byte
	{
		TEXFMT_A8_Unorm = 0,
		TEXFMT_R8_Unorm = 1,
		TEXFMT_L8_Unorm = 2,
		TEXFMT_R8G8_Unorm = 3,
		TEXFMT_R8G8B8X8_Unorm = 4,
		TEXFMT_R8G8B8A8_Unorm = 5,
		TEXFMT_R8G8B8A8_Unorm_SRGB = 40,
		TEXFMT_R8G8B8A8_Snorm = 6,
		TEXFMT_B8G8R8A8 = 50,
		TEXFMT_B8G8R8A8_SRGB = 51,
		TEXFMT_R16_Unorm = 7,
		TEXFMT_R16_Snorm = 49,
		TEXFMT_R16_Uint = 8,
		TEXFMT_R32_Uint = 9,
		TEXFMT_R32G32B32A32_Uint = 10,
		TEXFMT_R32G32_Uint = 11,
		TEXFMT_R16G16B16A16_Unorm = 12,
		TEXFMT_R16G16B16A16_Uint = 14,
		TEXFMT_R16G16_Uint = 15,
		TEXFMT_R10G10B10A2_Unorm = 16,
		TEXFMT_R16G16B16A16_Float = 17,
		TEXFMT_R11G11B10_Float = 18,
		TEXFMT_R16G16_Float = 19,
		TEXFMT_R32G32_Float = 20,
		TEXFMT_R32G32B32A32_Float = 21,
		TEXFMT_R32_Float = 22,
		TEXFMT_R16_Float = 23,
		TEXFMT_D24S8 = 24,
		TEXFMT_D32FS8 = 25,
		TEXFMT_D32F = 27,
		TEXFMT_D16U = 28,
		TEXFMT_BC1 = 29,
		TEXFMT_BC1_SRGB = 41,
		TEXFMT_BC2 = 30,
		TEXFMT_BC2_SRGB = 42,
		TEXFMT_BC3 = 31,
		TEXFMT_BC3_SRGB = 43,
		TEXFMT_BC4 = 32,
		TEXFMT_BC5 = 33,
		TEXFMT_BC6H_UNSIGNED = 34,
		TEXFMT_BC6H_SIGNED = 35,
		TEXFMT_BC7 = 36,
		TEXFMT_BC7_SRGB = 37,
		TEXFMT_R8_Uint = 38,
		TEXFMT_R16G16_Unorm = 44,
		TEXFMT_R16G16_Sint = 45,
		TEXFMT_R16G16_Snorm = 46,
		TEXFMT_B5G6R5_Unorm = 47,
		TEXFMT_A8 = 0,
		TEXFMT_R8 = 1,
		TEXFMT_L8 = 2,
		TEXFMT_R8G8 = 3,
		TEXFMT_R8G8B8X8 = 4,
		TEXFMT_R8G8B8A8 = 5,
		// TEXFMT_R8G8B8A8 = 40,
		TEXFMT_Uint_16_norm = 7,
		TEXFMT_Uint_16 = 8,
		TEXFMT_Uint_32 = 9,
		TEXFMT_Uint_R32G32B32A32 = 10,
		// TEXFMT_Uint_R32G32B32A32 = 14,
		TEXFMT_R10G10B10A2 = 16,
		TEXFMT_Float_R16G16B16A16 = 17,
		TEXFMT_Float_R11G11B10 = 18,
		TEXFMT_Float_R16G16 = 19,
		TEXFMT_Float_R32G32 = 20,
		TEXFMT_Float_R32G32B32A32 = 21,
		TEXFMT_Float_R32 = 22,
		TEXFMT_Float_R16 = 23,
		TEXFMT_BC6H = 34
	}

	public enum GpuWrapApieTextureGroup : byte
	{
		TEXG_Generic_Color = 1,
		TEXG_Generic_Grayscale = 2,
		TEXG_Generic_Normal = 3,
		TEXG_Generic_Data = 4,
		TEXG_Generic_UI = 5,
		TEXG_Generic_Font = 6,
		TEXG_Generic_LUT = 7,
		TEXG_Generic_MorphBlend = 8,
		TEXG_Multilayer_Color = 9,
		TEXG_Multilayer_Normal = 10,
		TEXG_Multilayer_Grayscale = 11,
		TEXG_Multilayer_Microblend = 12
	}

	public enum GpuWrapApieTextureType : byte
	{
		TEXTYPE_2D = 0,
		TEXTYPE_CUBE = 1,
		TEXTYPE_ARRAY = 2,
		TEXTYPE_3D = 3
	}

	public enum GrenadeDamageType
	{
		Normal = 0,
		DoT = 1,
		None = 2
	}

	public enum HUDActorStatus
	{
		UNINITIALIZED = 0,
		REGISTERED = 1,
		ACTIVE = 2
	}

	public enum HUDActorType
	{
		UNINITIALIZED = 0,
		GAME_OBJECT = 1,
		VEHICLE = 2,
		DEVICE = 3,
		BODY_DISPOSAL_DEVICE = 4,
		PUPPET = 5,
		ITEM = 6
	}

	public enum HUDContext
	{
		DEFAULT = 0,
		FOCUS = 1,
		LOOKEDAT = 2
	}

	public enum HUDState
	{
		UNINITIALIZED = 0,
		DEACTIVATED = 1,
		ACTIVATED = 2
	}

	public enum HighlightContext
	{
		DEFAULT = 0,
		OUTLINE = 1,
		FILL = 2,
		FULL = 3
	}

	public enum HighlightMode
	{
		Row = 0,
		Column = 1
	}

	public enum HitShape_Type
	{
		Normal = 0,
		InternalWeakSpot = 1,
		ExternalWeakSpot = 2,
		ProtectionLayer = 3
	}

	public enum HoverStatus
	{
		DEFAULT = 0,
		HOVER = 1
	}

	public enum HubMenuCharacterItems
	{
		Skills = 0,
		Stats = 1
	}

	public enum HubMenuCraftingItems
	{
		Crafting = 0,
		Upgrade = 1
	}

	public enum HubMenuDatabaseItems
	{
		Codex = 0,
		Tarot = 1,
		Shards = 2
	}

	public enum HubMenuInventoryItems
	{
		Gear = 0,
		Cyberware = 1,
		Backpack = 2
	}

	public enum HubMenuItems
	{
		None = -1,
		Default = 0,
		Crafting = 1,
		Character = 2,
		Inventory = 3,
		Map = 4,
		Journal = 5,
		Phone = 6,
		Database = 7,
		Stats = 8,
		Backpack = 9,
		HubMenuItems = 10,
		Codex = 11,
		Shards = 12,
		Tarot = 13,
		Gear = 14,
		Cyberware = 15,
		VisualSets = 16,
		Count = 17
	}

	public enum HubVendorMenuItems
	{
		Trade = 0,
		Cyberware = 1
	}

	public enum IMaterialDataProviderDescEParameterType : byte
	{
		PT_None = 0,
		PT_Texture = 1,
		PT_Color = 2,
		PT_Cube = 3,
		PT_Vector = 4,
		PT_Scalar = 5,
		PT_Bool = 6,
		PT_TextureArray = 7,
		PT_StructBuffer = 8,
		PT_Cpu_NameU64 = 9,
		PT_SkinProfile = 10,
		PT_MultilayerSetup = 11,
		PT_MultilayerMask = 12,
		PT_HairProfile = 13,
		PT_FoliageProfile = 14,
		PT_TerrainSetup = 15,
		PT_Gradient = 16,
		PT_DynamicTexture = 17,
		PT_MAX = 18
	}

	public enum InGameConfigChangeReason : sbyte
	{
		Invalid = -1,
		Accepted = 0,
		Rejected = 1,
		NeedsConfirmation = 2,
		NeedsRestart = 3
	}

	public enum InGameConfigNotificationType : byte
	{
		RestartRequiredConfirmed = 0,
		RestartRequiredRejected = 1,
		ChangesApplied = 2,
		ChangesRejected = 3,
		ChangesLoadLastCheckpointApplied = 4,
		ChangesLoadLastCheckpointRejected = 5,
		Saved = 6,
		ErrorSaving = 7,
		Loaded = 8,
		LoadCanceled = 9,
		LoadInternalError = 10,
		Refresh = 11,
		LanguagePackInstalled = 12
	}

	public enum InGameConfigUserSettingsLoadStatus : byte
	{
		NotLoaded = 0,
		InternalError = 1,
		FileIsMissing = 2,
		FileIsCorrupted = 3,
		Loaded = 4,
		ImportedFromOldVersion = 5
	}

	public enum InGameConfigUserSettingsSaveStatus : byte
	{
		NotSaved = 0,
		InternalError = 1,
		Saved = 2
	}

	public enum InGameConfigVarType : byte
	{
		Bool = 0,
		Int = 1,
		Float = 2,
		Name = 3,
		IntList = 4,
		FloatList = 5,
		StringList = 6,
		NameList = 7
	}

	public enum InGameConfigVarUpdatePolicy : byte
	{
		Disabled = 0,
		Immediately = 1,
		ConfirmationRequired = 2,
		RestartRequired = 3,
		LoadLastCheckpointRequired = 4
	}

	public enum InnerBunkerCoreStage
	{
		Normal = 0,
		Malfunction = 1,
		Shutdown = 2
	}

	public enum InnerBunkerCoreStatus
	{
		Online = 0,
		Offline = 1,
		Unresponsive = 2
	}

	public enum InstanceState
	{
		DISABLED = 0,
		HIDDEN = 1,
		RUNNING = 2,
		MALFUNCTIONING = 3,
		ON = 4
	}

	public enum IntercomStatus
	{
		DEFAULT = 0,
		CALLING = 1,
		TALKING = 2,
		CALL_MISSED = 3,
		CALL_ENDED = 4
	}

	public enum InventoryModes
	{
		Default = 0,
		Item = 1
	}

	public enum InventoryPaperdollZoomArea
	{
		Default = 0,
		Weapon = 1,
		Legs = 2,
		Feet = 3,
		Cyberware = 4,
		QuickSlot = 5,
		Consumable = 6,
		Outfit = 7,
		Head = 8,
		Face = 9,
		InnerChest = 10,
		OuterChest = 11
	}

	public enum InventoryTooltipDisplayContext
	{
		Default = 0,
		Attachment = 1,
		Crafting = 2,
		Upgrading = 3,
		HUD = 4,
		Vendor = 5
	}

	public enum ItemAdditionalInfoType
	{
		NONE = 0,
		PRICE = 1,
		TYPE = 2
	}

	public enum ItemDisplayNotificationMessage
	{
		Default = 0,
		AddRef = 1,
		RemoveRef = 2
	}

	public enum ItemDisplayType
	{
		Item = 0,
		Weapon = 1
	}

	public enum ItemFilterCategory
	{
		RangedWeapons = 0,
		MeleeWeapons = 1,
		Clothes = 2,
		Consumables = 3,
		Grenades = 4,
		SoftwareMods = 5,
		Attachments = 6,
		Programs = 7,
		Cyberware = 8,
		Junk = 9,
		BaseCount = 10,
		Quest = 11,
		NewWardrobeAppearances = 12,
		Buyback = 13,
		AllItems = 14,
		AllCount = 15,
		Invalid = -1
	}

	public enum ItemFilterType
	{
		All = 0,
		Weapons = 1,
		Clothes = 2,
		Consumables = 3,
		Cyberware = 4,
		Attachments = 5,
		Quest = 6,
		Buyback = 7,
		LightWeapons = 8,
		HeavyWeapons = 9,
		MeleeWeapons = 10,
		Hacks = 11
	}

	public enum ItemLabelType
	{
		New = 0,
		Quest = 1,
		Money = 2,
		Equipped = 3,
		Owned = 4,
		Buyback = 5,
		DLCNew = 6
	}

	public enum ItemModeGridSize
	{
		Default = 0,
		Outfit = 1
	}

	public enum ItemSortMode
	{
		Default = 0,
		NewItems = 1,
		NameAsc = 2,
		NameDesc = 3,
		QualityAsc = 4,
		QualityDesc = 5,
		WeightAsc = 6,
		WeightDesc = 7,
		PriceAsc = 8,
		PriceDesc = 9,
		ItemType = 10,
		DpsAsc = 11,
		DpsDesc = 12
	}

	public enum ItemViewModes
	{
		Item = 0,
		Mod = 1
	}

	public enum JournalNotificationMode
	{
		Default = 0,
		Menu = 1,
		HUD = 2
	}

	public enum LadderCameraParams
	{
		None = 0,
		Enter = 1,
		Default = 2,
		CameraReset = 3,
		Exit = 4
	}

	public enum LandingType
	{
		Off = 0,
		Regular = 1,
		Hard = 2,
		VeryHard = 3,
		Superhero = 4,
		Death = 5
	}

	public enum LaserTargettingState
	{
		Start = 0,
		Update = 1,
		End = 2
	}

	public enum LibTreeEParameterType : ushort
	{
		PARAM_Bool = 0,
		PARAM_Int32 = 1,
		PARAM_Enum = 2,
		PARAM_Float = 3,
		PARAM_CName = 4,
		PARAM_TreeRef = 5,
		PARAM_TreeRefList = 6,
		PARAM_NodeRef = 7,
		PARAM_Vector = 9
	}

	public enum LifetimeStatus
	{
		Base = 0,
		Near = 1,
		Disengaging = 2
	}

	public enum MechanicalScanType
	{
		None = 0,
		Short = 1,
		Long = 2,
		Danger = 3
	}

	public enum MessageHash
	{
		Invalid = 0,
		Fake = -1
	}

	public enum MessageViewType
	{
		Sent = 0,
		Received = 1
	}

	public enum MessengerContactType : byte
	{
		SingleThread = 0,
		MultiThread = 1,
		Contact = 2,
		Fake_ShowAll = 3
	}

	public enum MinigameActionType
	{
		Device = 0,
		NPC = 1,
		Both = 2,
		AccessPoint = 3
	}

	public enum ModuleState
	{
		DISABLED = 0,
		HIDDEN = 1,
		ASLEEP = 2,
		MALFUNCTIONING = 3,
		ON = 4
	}

	public enum MorphTargetsDiffTextureSize : byte
	{
		TEXTURE_SIZE_1024x1024 = 0,
		TEXTURE_SIZE_512x512 = 1,
		TEXTURE_SIZE_256x256 = 2
	}

	public enum MorphTargetsFaceRegion : byte
	{
		FACE_REGION_EYES = 0,
		FACE_REGION_NOSE = 1,
		FACE_REGION_MOUTH = 2,
		FACE_REGION_JAW = 3,
		FACE_REGION_EARS = 4,
		FACE_REGION_NONE = 255
	}

	public enum MountType
	{
		Hijack = 0,
		Regular = 1
	}

	public enum NavGenAgentSize
	{
		Human = 0,
		Vehicle = 1,
		AgentSize_Count = 2
	}

	public enum NavGenNavmeshImpact : ushort
	{
		Ignored = 1,
		Walkable = 0,
		Blocking = 2,
		Road = 3,
		Stairs = 4,
		Drones = 5,
		Terrain = 6,
		CrowdWalkable = 0
	}

	public enum NavGenSamplingDensity : byte
	{
		None = 0,
		Sparse = 1,
		Dense = 2,
		[RED("Very dense")] Very_dense = 3
	}

	public enum NewPeksActiveScreen
	{
		Categories = 0,
		Perks = 1,
		Espionage = 2,
		Skills = 3,
		Count = 4,
		Invalid = -1
	}

	public enum NewPerkCellAnimationType
	{
		Bought = 0,
		Maxed = 1,
		Locked = 2,
		HoverOver = 3,
		HoverOut = 4,
		Sold = 5,
		Reminder = 6,
		SellLocked = 7,
		InsufficientPoints = 8,
		MaxedLocked = 9,
		COUNT = 10,
		INVALID = -1
	}

	public enum NewPerkTabsArrowDirection
	{
		Left = 0,
		Right = 1,
		Invalid = 2
	}

	public enum NewPerksCyberwareDetailsMenu
	{
		MantisBlades = 0,
		GorillaArms = 1,
		ProjectileLauncher = 2,
		Monowire = 3,
		COUNT = 4
	}

	public enum NewPerksWireState
	{
		Default = 0,
		Available = 1,
		Bought = 2,
		Count = 3,
		All = 4,
		Invalid = -1
	}

	public enum ObjectToCheck
	{
		Player = 0,
		Weapon = 1
	}

	public enum OpeningGateScreenState
	{
		Unknown = 0,
		Idle = 1,
		Loop = 2,
		Open = 3,
		Result = 4
	}

	public enum OutcomeMessage
	{
		Success = 0,
		Failure = 1
	}

	public enum PSODescBlendModeFactor : byte
	{
		FAC_Zero = 0,
		FAC_One = 1,
		FAC_SrcColor = 2,
		FAC_InvSrcColor = 3,
		FAC_SrcAlpha = 4,
		FAC_InvSrcAlpha = 5,
		FAC_DestColor = 6,
		FAC_InvDestColor = 7,
		FAC_DestAlpha = 8,
		FAC_InvDestAlpha = 9,
		FAC_BlendFactor = 10,
		FAC_InvBlendFactor = 11,
		FAC_Src1Color = 12,
		FAC_InvSrc1Color = 13,
		FAC_Src1Alpha = 14,
		FAC_InvSrc1Alpha = 15
	}

	public enum PSODescBlendModeOp : byte
	{
		OP_Add = 0,
		OP_Subtract = 1,
		OP_RevSub = 2,
		OP_Min = 3,
		OP_Max = 4,
		OP_Or = 5,
		OP_And = 6,
		OP_Xor = 7,
		OP_nOr = 9,
		OP_nAnd = 8
	}

	public enum PSODescBlendModeWriteMask : byte
	{
		MASK_None = 0,
		MASK_R = 1,
		MASK_G = 2,
		MASK_B = 4,
		MASK_A = 8,
		MASK_RG = 3,
		MASK_RB = 5,
		MASK_RA = 9,
		MASK_GB = 6,
		MASK_GA = 10,
		MASK_BA = 12,
		MASK_RGB = 7,
		MASK_RGA = 11,
		MASK_RBA = 13,
		MASK_GBA = 14,
		MASK_RGBA = 15
	}

	public enum PSODescDepthStencilModeComparisonMode : byte
	{
		COMPARISON_Never = 0,
		COMPARISON_Less = 1,
		COMPARISON_Equal = 2,
		COMPARISON_LessEqual = 3,
		COMPARISON_Greater = 4,
		COMPARISON_NotEqual = 5,
		COMPARISON_GreaterEqual = 6,
		COMPARISON_Always = 7
	}

	public enum PSODescDepthStencilModeStencilOpMode : byte
	{
		STENCILOP_Keep = 0,
		STENCILOP_Zero = 1,
		STENCILOP_Replace = 2,
		STENCILOP_IncreaseSaturate = 3,
		STENCILOP_DecreaseSaturate = 4,
		STENCILOP_Invert = 5,
		STENCILOP_Increase = 6,
		STENCILOP_Decrease = 7
	}

	public enum PSODescPrimitiveTopologyType
	{
		Invalid = 0,
		Point = 1,
		Line = 2,
		Triangle = 3,
		Patch = 4
	}

	public enum PSODescRasterizerModeCullMode : byte
	{
		CULL_None = 0,
		CULL_Front = 1,
		CULL_Back = 2
	}

	public enum PSODescRasterizerModeFrontFaceWinding : byte
	{
		FRONTFACE_CCW = 0,
		FRONTFACE_CW = 1
	}

	public enum PSODescRasterizerModeOffsetMode : byte
	{
		OFFSET_None = 0,
		OFFSET_NormalBias = 1,
		OFFSET_ShadowBias = 2,
		OFFSET_DecalBias = 3
	}

	public enum PackageStatus
	{
		UNINITIALIZED = 0,
		ON_HOLD = 1,
		FOR_IMMEDIATE_TRIGGER = 2,
		TRIGGERED = 3
	}

	public enum PaperdollPositionAnimation
	{
		Center = 0,
		Left = 1,
		Right = 2,
		LeftFullBody = 3
	}

	public enum PauseMenuAction
	{
		OpenSubMenu = 0,
		QuickSave = 1,
		Save = 2,
		ExitGame = 3,
		ExitToMainMenu = 4,
		QuickLoad = 5
	}

	public enum PaymentStatus
	{
		DEFAULT = 0,
		IN_PROGRESS = 1,
		NO_MONEY = 2
	}

	public enum PerkMenuAttribute
	{
		Body = 0,
		Reflex = 1,
		Technical_Ability = 2,
		Cool = 3,
		Intelligence = 4,
		Espionage = 5,
		Johnny = 6,
		Count = 7,
		Invalid = -1
	}

	public enum PhoneDialerTabs
	{
		Unread = 0,
		Contacts = 1
	}

	public enum PhoneScreenType
	{
		Unread = 0,
		Contacts = 1
	}

	public enum PlayerChangeCameraAndLeaveVehiclePhase
	{
		ToggleCamera = 0,
		ExitVehicle = 1,
		Done = 2
	}

	public enum PlayerCombatControllerRefreshPolicyEnum
	{
		Persistent = 0,
		Eventful = 1
	}

	public enum PlayerCombatState
	{
		Invalid = 0,
		InCombat = 1,
		OutOfCombat = 2,
		Stealth = 3
	}

	public enum PlayerVisionModeControllerRefreshPolicyEnum
	{
		Persistent = 0,
		Eventful = 1
	}

	public enum PocketRadioRestrictions
	{
		SceneTier = 0,
		UpperBodyState = 1,
		QuestContentLock = 2,
		InDaClub = 3,
		BlockFastTravel = 4,
		VehicleScene = 5,
		VehicleBlockPocketRadio = 6,
		PhoneCall = 7,
		PhoneNoTexting = 8,
		PhoneNoCalling = 9,
		FastForward = 10,
		FastForwardHintActive = 11,
		PocketRadioRestrictionCount = 12
	}

	public enum ProgramEffect
	{
		GrantAccess = 0,
		BlockAccess = 1,
		UnlockQuestFact = 2
	}

	public enum ProgramType
	{
		BasicAccess = 0,
		ExtraPlayerProgram = 1,
		ExtraServerProgram = 2,
		EnemyProgram = 3,
		EnemyLockNetwork = 4
	}

	public enum QuantityPickerActionType
	{
		Buy = 0,
		Sell = 1,
		TransferToStorage = 2,
		TransferToPlayer = 3,
		Drop = 4,
		Disassembly = 5,
		Craft = 6
	}

	public enum QuestListItemType
	{
		MainQuest = 0,
		SideQuest = 1,
		Gig = 2,
		Cyberpsycho = 3,
		NCPDQuest = 4,
		Apartment = 5,
		Courier = 6,
		Finished = 7,
		Count = 8,
		All = 9,
		Invalid = -1
	}

	public enum QuestListSortType
	{
		Updated = 0,
		Distance = 1,
		Size = 2
	}

	public enum QuickSlotActionType
	{
		Undefined = 0,
		SelectItem = 1,
		HideWeapon = 2,
		OpenPhone = 3,
		SummonCar = 4,
		SummonBike = 5,
		ToggleRadio = 6,
		SelectRadioStation = 7,
		TurnOffRadio = 8,
		CycleTrackedQuest = 9,
		SummonVehicle = 10,
		SetActiveVehicle = 11,
		QuickHack = 12,
		ToggleSummonMode = 13,
		EquipFists = 14
	}

	public enum QuickSlotItemType
	{
		Undefined = 0,
		Vehicle = 1,
		Gadget = 2,
		Consumable = 3,
		Cyberware = 4,
		Weapon = 5,
		Interaction = 6
	}

	public enum RadialHubMenuElement
	{
		None = 0,
		Inventory = 1,
		Map = 2,
		Character = 3,
		Journal = 4
	}

	public enum RarityItemType
	{
		Item = 0,
		Cyberdeck = 1,
		Program = 2,
		Count = 3,
		Invalid = 4
	}

	public enum ReactionZones_Humanoid_Side
	{
		Head = 0,
		ChestLeft = 1,
		ArmLeft = 2,
		HandLeft = 3,
		ChestRight = 4,
		ArmRight = 5,
		HandRight = 6,
		Abdomen = 7,
		LegLeft = 8,
		LegRight = 9
	}

	public enum RenderDecalNormalsBlendingMode : byte
	{
		AlphaBlending = 0,
		Reorient = 1
	}

	public enum RenderDecalOrderPriority : byte
	{
		Priority0 = 0,
		Priority1 = 1,
		Priority2 = 2,
		Priority3 = 3
	}

	public enum RenderSceneLayer : byte
	{
		Default = 0,
		Cyberspace = 1,
		WorldMap = 2
	}

	[Flags]
	public enum RenderSceneLayerMask
	{
		Default = 1 << 0,
		Cyberspace = 1 << 1,
		WorldMap = 1 << 2
	}

	public enum RequestType
	{
		INSTANTLY_TRIGGER = 0,
		MANUALLY_TRIGGERED = 1
	}

	public enum RipperdocFilter
	{
		All = 0,
		Vendor = 1,
		Player = 2,
		Buyback = 3
	}

	public enum RipperdocHoverState
	{
		None = 0,
		BarCapacity = 1,
		BarArmor = 2,
		SlotSkeleton = 3,
		SlotHands = 4
	}

	public enum RipperdocModes
	{
		Default = 0,
		Item = 1
	}

	public enum RoboticArmStateType
	{
		Idle = 0,
		Work = 1,
		Distract = 2
	}

	public enum SAnimationBufferBitwiseCompression
	{
		ABBC_None = 0,
		ABBC_24b = 1,
		ABBC_16b = 2
	}

	public enum SAnimationBufferBitwiseCompressionPreset
	{
		ABBCP_Custom = 0,
		ABBCP_VeryHighQuality = 1,
		ABBCP_HighQuality = 2,
		ABBCP_NormalQuality = 3,
		ABBCP_LowQuality = 4,
		ABBCP_VeryLowQuality = 5,
		ABBCP_Raw = 6
	}

	public enum SAnimationBufferDataCompressionMethod
	{
		ABDCM_Invalid = 0,
		ABDCM_Plain = 1,
		ABDCM_Quaternion = 2,
		ABDCM_QuaternionXYZSignedW = 3,
		ABDCM_QuaternionXYZSignedWLastBit = 4,
		ABDCM_Quaternion48b = 5,
		ABDCM_Quaternion40b = 6,
		ABDCM_Quaternion32b = 7,
		ABDCM_Quaternion64bW = 8,
		ABDCM_Quaternion48bW = 9,
		ABDCM_Quaternion40bW = 10
	}

	public enum SAnimationBufferOrientationCompressionMethod
	{
		ABOCM_PackIn64bitsW = 0,
		ABOCM_PackIn48bitsW = 1,
		ABOCM_PackIn40bitsW = 2,
		ABOCM_AsFloat_XYZW = 3,
		ABOCM_AsFloat_XYZSignedW = 4,
		ABOCM_AsFloat_XYZSignedWInLastBit = 5,
		ABOCM_PackIn48bits = 6,
		ABOCM_PackIn40bits = 7,
		ABOCM_PackIn32bits = 8
	}

	public enum SAnimationBufferStreamingOption
	{
		ABSO_NonStreamable = 0,
		ABSO_PartiallyStreamable = 1,
		ABSO_FullyStreamable = 2
	}

	public enum Sample_Replicated_Enum
	{
		One = 0,
		Two = 1,
		Three = 2
	}

	public enum ScannerDataType
	{
		None = 0,
		Name = 1,
		Level = 2,
		Health = 3,
		Rarity = 4,
		WeaponBasic = 5,
		WeaponDetailed = 6,
		BountySystem = 7,
		Vulnerabilities = 8,
		Faction = 9,
		Attitude = 10,
		SquadInfo = 11,
		Resistances = 12,
		Abilities = 13,
		Requirements = 14,
		Description = 15,
		DeviceStatus = 16,
		NetworkStatus = 17,
		NetworkLevel = 18,
		DeviceConnections = 19,
		QuestEntry = 20,
		VehicleName = 21,
		VehicleManufacturer = 22,
		VehicleProductionYears = 23,
		VehicleDriveLayout = 24,
		VehicleHorsepower = 25,
		VehicleMass = 26,
		VehicleState = 27,
		VehicleInfo = 28,
		QuickHackDescription = 29
	}

	public enum ScannerDetailTab
	{
		Data = 0,
		Hacking = 1
	}

	public enum ScannerNetworkState
	{
		NOT_CONNECTED = 0,
		NOT_BREACHED = 1,
		TIER1 = 2,
		TIER2 = 3,
		TIER3 = 4,
		BREACHED = 5
	}

	public enum ScannerObjectType
	{
		INVALID = 0,
		PUPPET = 1,
		VEHICLE = 2,
		DEVICE = 3,
		GENERIC = 4
	}

	public enum ScreenDisplayContext
	{
		Default = 0,
		Vendor = 1,
		Storage = 2
	}

	public enum SecurityEventScopeSettings
	{
		GLOBAL = 0,
		AREA_WHERE_PLAYER_IS = 1,
		SPECIFIC_AGENTS_ONLY = 2
	}

	public enum ServerState
	{
		Inactive = 0,
		Active = 1,
		Damaged = 2,
		Destroyed = 3
	}

	public enum SettingsType
	{
		Slider = 0,
		Toggle = 1,
		DropdownList = 2
	}

	public enum SignShape
	{
		RECTANGLE = 0,
		ARROWLEFT = 1,
		ARROWRIGHT = 2,
		SQUARE = 3
	}

	public enum SignType
	{
		INFORMATION = 0,
		ATTENTION = 1,
		WARNING = 2
	}

	public enum SignalType
	{
		DEFAULT = 0,
		REGISTRATION = 1,
		UNREGISTRATION = 2
	}

	public enum SlotType
	{
		DEFAULT = 0,
		HOLSTER = 1,
		WEAPON = 2,
		COMBAT_CYBERWARE = 3,
		TOOLTIP = 4,
		MISC = 5
	}

	public enum StaticShaderInputLayout
	{
		DebugVertexBase = 0,
		DebugVertexUV = 1,
		DebugVertexUV_Fullscreen = 2,
		NoBuffers_Fullscreen = 3,
		NoBuffers_PointList = 4
	}

	public enum TakeOverControlSystemInputHintSortPriority
	{
		Shoot = 0,
		SpiderNextAim = 1,
		Scanner = 2,
		NextDevice = 3,
		PreviousDevice = 4,
		ZoomIn = 5,
		ZoomOut = 6,
		SpiderNestView = 7,
		Exit = 8
	}

	public enum TestCasePhase : byte
	{
		Setup = 0,
		Body = 1,
		Wrapup = 2
	}

	public enum ThrowType
	{
		Quick = 0,
		Charge = 1
	}

	public enum Tier2WalkType
	{
		Undefined = 0,
		Slow = 1,
		Normal = 2,
		Fast = 3
	}

	public enum TrafficGenDynamicImpact : ushort
	{
		Ignored = 0,
		Blocking = 1
	}

	public enum TrafficGenMeshImpact : ushort
	{
		UseNavigation = 0,
		ForceIgnored = 1,
		ForceBlocking = 2
	}

	public enum TransferSaveAction
	{
		Export = 0,
		Import = 1
	}

	public enum TransferSaveState
	{
		ExportConfirmation = 0,
		ExportSpinner = 1,
		ExportSuccess = 2,
		ExportFailed = 3,
		ImportSpinner = 4,
		ImportLoading = 5,
		ImportNoSave = 6,
		ImportFailed = 7,
		ImportNotEnoughSpace = 8
	}

	public enum TransmogSlots
	{
		Head = 0,
		Face = 1,
		InnerChest = 2,
		OuterChest = 3,
		Legs = 4,
		Feet = 5
	}

	[Flags]
	public enum TriggerChannel
	{
		TC_Default = 1 << 0,
		TC_Player = 1 << 1,
		TC_Camera = 1 << 2,
		TC_Human = 1 << 3,
		TC_SoundReverbArea = 1 << 4,
		TC_SoundAmbientArea = 1 << 5,
		TC_Quest = 1 << 6,
		TC_Projectiles = 1 << 7,
		TC_Vehicle = 1 << 8,
		TC_Environment = 1 << 9,
		TC_WaterNullArea = 1 << 10,
		TC_Custom0 = 1 << 16,
		TC_Custom1 = 1 << 17,
		TC_Custom2 = 1 << 18,
		TC_Custom3 = 1 << 19,
		TC_Custom4 = 1 << 20,
		TC_Custom5 = 1 << 21,
		TC_Custom6 = 1 << 22,
		TC_Custom7 = 1 << 23,
		TC_Custom8 = 1 << 24,
		TC_Custom9 = 1 << 25,
		TC_Custom10 = 1 << 26,
		TC_Custom11 = 1 << 27,
		TC_Custom12 = 1 << 28,
		TC_Custom13 = 1 << 29,
		TC_Custom14 = 1 << 30
	}

	public enum TweakWeaponPose
	{
		Nothing = 0,
		Position = 1,
		Rotation = 2
	}

	public enum UIGameContext
	{
		Default = 0,
		QuickHack = 1,
		Scanning = 2,
		DeviceZoom = 3,
		BraindanceEditor = 4,
		BraindancePlayback = 5,
		VehicleMounted = 6,
		ModalPopup = 7,
		RadialWheel = 8,
		VehicleRace = 9,
		Berserk = 10
	}

	public enum UIInGameNotificationType
	{
		ActionRestriction = 0,
		CombatRestriction = 1,
		CantSaveActionRestriction = 2,
		CantSaveCombatRestriction = 3,
		CantSaveQuestRestriction = 4,
		CantSaveDeathRestriction = 5,
		NotEnoughSlotsSaveResctriction = 6,
		NotEnoughSpaceSaveResctriction = 7,
		PhotoModeDisabledRestriction = 8,
		SandevistanInCallRestriction = 9,
		ExpansionInstalled = 10,
		GenericNotification = 11
	}

	public enum UIInventoryItemWeaponBarsType
	{
		Ranged = 0,
		Melee = 1,
		Throwable = 2,
		CyberwareWeapon = 3,
		CyberwareRangedWeapon = 4,
		InjectorHealing = 5,
		InhalerHealing = 6
	}

	public enum UIItemCategory
	{
		Default = 0,
		Weapon = 1,
		Clothing = 2,
		Grenade = 3,
		Cyberware = 4,
		CyberwareWeapon = 5,
		Cyberdeck = 6,
		Program = 7
	}

	public enum UIMenuNotificationType
	{
		VendorNotEnoughMoney = 0,
		VNotEnoughMoney = 1,
		VendorRequirementsNotMet = 2,
		InventoryActionBlocked = 3,
		CraftingNoPerks = 4,
		CraftingNotEnoughMaterial = 5,
		UpgradingLevelToLow = 6,
		NoPerksPoints = 7,
		PerksLocked = 8,
		MaxLevelPerks = 9,
		NoAttributePoints = 10,
		InCombat = 11,
		InCombatExplicit = 12,
		CraftingQuickhack = 13,
		CraftingAmmoCap = 14,
		PlayerReqLevelToLow = 15,
		InventoryNoFreeSlot = 16,
		FaceUnequipBlocked = 17,
		TutorialUnequipBlocked = 18,
		NoJunkToDisassemble = 19
	}

	public enum UIObjectiveEntryType
	{
		Invalid = 0,
		Quest = 1,
		Objective = 2,
		SubObjective = 3
	}

	public enum UpdateBucketEnum : byte
	{
		Vehicle = 0,
		Character = 1,
		AttachedObject = 2
	}

	public enum VehicleQuestEngineLockState
	{
		DontToggleIfLocked = 0,
		Lock = 1,
		Unlock = 2
	}

	public enum VehicleVisualCustomizationWidgetCarPart
	{
		Default = 0,
		Body = 1,
		Hood = 2,
		Door = 3,
		Bumper = 4,
		Spoiler = 5,
		SpoilerHidden = 6
	}
	
	public enum VendorConfirmationPopupType
	{
		Default = 0,
		ExpensiveItem = 1,
		EquippedItem = 2,
		StashEquippedItem = 3,
		BuyAndEquipCyberware = 4,
		BuyNotEquipableCyberware = 5,
		SellCyberware = 6,
		DisassembeIconic = 7
	}

	public enum VendorSellJunkActionType
	{
		Sell = 0,
		Disassemble = 1
	}

	public enum VisualState
	{
		OFF = 0,
		RUNNING = 1,
		MALFUNCTIONING = 2,
		ON = 3
	}

	public enum WeaponBarType
	{
		AttackSpeed = 0,
		DamagePerHit = 1,
		ReloadSpeed = 2,
		Range = 3,
		Handling = 4,
		Stamina = 5,
		RangedCount = 6,
		MeleeAttackSpeed = 7,
		MeleeDamagePerHit = 8,
		MeleeStamina = 9,
		ThrowableEffectiveRange = 10,
		ThrowableReturnTime = 11,
		MeleeCount = 12,
		CyberwareAttackSpeed = 13,
		CyberwareDamagePerHit = 14,
		CyberwareCount = 15,
		Healing = 16,
		HealingOverTime = 17,
		HealingCount = 18,
		Invalid = -1
	}

	public enum WeaponBarTypeGroup
	{
		AttackSpeed = 0,
		DamagePerHit = 1,
		Range = 2,
		ReloadSpeed = 3,
		Stamina = 4,
		Handling = 5,
		ReturnTime = 6,
		Healing = 7,
		HealingOverTime = 8,
		Invalid = -1
	}

	public enum WeaponPartType
	{
		Scope = 0,
		Magazine = 1,
		Silencer = 2
	}

	public enum WeaponType
	{
		Ranged = 0,
		Melee = 1,
		Count = 2,
		Invalid = -1
	}

	public enum WorkspotConditionOperators
	{
		OR = 0,
		AND = 1
	}

	public enum WorkspotWeaponConditionEnum
	{
		None = 0,
		Any = 1,
		Ranged = 2,
		OneHandedRanged = 3,
		Melee = 4,
		MeleeCyberware = 5,
		LMG = 6,
		HMG = 7
	}

	public enum WorldMapTooltipType
	{
		Default = 0,
		Police = 1
	}

	public enum aimTypeEnum
	{
		AimIn = 0,
		AimOut = 1,
		Invalid = 2
	}

	public enum animAimState
	{
		Unaimed = 0,
		Aimed = 1
	}

	public enum animAnimEventGenderAlt
	{
		None = 0,
		Female = 1,
		Male = 2
	}

	public enum animAnimNode_SetDrivenKey_InternalsEChannelType
	{
		FloatTrack = 0,
		TransX = 1,
		TransY = 2,
		TransZ = 3,
		RotEulZ_Pitch = 4,
		RotEulX_Roll = 5,
		RotEulY_Yaw = 6,
		ScaleX = 7,
		ScaleY = 8,
		ScaleZ = 9,
		RotQuatX = 10,
		RotQuatY = 11,
		RotQuatZ = 12,
		RotQuatW = 13
	}

	public enum animAnimStateInterpolationType : byte
	{
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3
	}

	public enum animAnimationType : byte
	{
		Normal = 0,
		AdditiveFromRefPose = 1,
		AdditiveFromFirstFrame = 2,
		Additive = 3,
		AdditiveWithoutFirstFrame = 4
	}

	public enum animAxis
	{
		X = 0,
		Y = 1,
		Z = 2,
		NegativeX = 3,
		NegativeY = 4,
		NegativeZ = 5
	}

	public enum animClampType
	{
		None = 0,
		Clamp = 1,
		WrappedClamp = 2
	}

	public enum animCompareFunc
	{
		Equal = 0,
		NotEqual = 1,
		Less = 2,
		LessEqual = 3,
		Greater = 4,
		GreaterEqual = 5
	}

	public enum animConstraintWeightMode
	{
		Static = 0,
		FloatTrack = 1
	}

	public enum animCoverAction
	{
		NoAction = 0,
		LeanLeft = 1,
		LeanRight = 2,
		StepOutLeft = 3,
		StepOutRight = 4,
		LeanOver = 5,
		StepUp = 6,
		EnterCover = 7,
		SlideTo = 8,
		Vault = 9,
		LeaveCover = 10,
		BlindfireLeft = 11,
		BlindfireRight = 12,
		BlindfireOver = 13,
		OverheadStepOutLeft = 14,
		OverheadStepOutRight = 15,
		OverheadStepUp = 16
	}

	public enum animCoverBehavior
	{
		Idle = 0,
		PreAction = 1,
		DoAction = 2,
		PostAction = 3
	}

	public enum animCoverStance
	{
		None = 0,
		LowLeft = 1,
		HighLeft = 2,
		LowRight = 3,
		HighRight = 4
	}

	public enum animCoverState
	{
		LowCover = 1,
		HighCover = 2
	}

	public enum animDyngConstraintLinkType
	{
		KeepFixedDistance = 0,
		KeepVariableDistance = 1,
		Greater = 2,
		Closer = 3
	}

	public enum animDyngParticleProjectionType
	{
		Disabled = 0,
		ShortestPath = 1,
		Directed = 2
	}

	public enum animEAnimGraphAdditiveType
	{
		AGAT_Local = 0,
		AGAT_Ref = 1
	}

	public enum animEAnimGraphCompareFunc
	{
		AGCF_Equal = 0,
		AGCF_NotEqual = 1,
		AGCF_Less = 2,
		AGCF_LessEqual = 3,
		AGCF_Greater = 4,
		AGCF_GreaterEqual = 5
	}

	public enum animEAnimGraphLogicOp
	{
		AGLO_Or = 0,
		AGLO_And = 1
	}

	public enum animEAnimGraphMathInterpolation
	{
		AGMI_LINEAR = 0,
		AGMI_SIN = 1,
		AGMI_BEZIER = 2
	}

	public enum animEAnimGraphMathOp
	{
		AGMO_Add = 0,
		AGMO_Subtract = 1,
		AGMO_Multiply = 2,
		AGMO_Divide = 3,
		AGMO_SafeDivide = 4,
		AGMO_ATan = 5,
		AGMO_AngleDiff = 6,
		AGMO_Length = 7,
		AGMO_Abs = 8
	}

	public enum animEBlendFromPoseMode
	{
		BFPM_AlwaysOnActivation = 0,
		BFPM_RequestedByTag = 1
	}

	public enum animEBlendTracksMode
	{
		AGBT_BasePose = 0,
		AGBT_Interpolate = 1,
		AGBT_Add = 2
	}

	public enum animEBlendTypeLBC
	{
		Linear = 0,
		Smoothstep = 1,
		CustomCurve = 2
	}

	public enum animEDirectionToEuler
	{
		Pitch = 0,
		Yaw = 1,
		Roll = 2
	}

	public enum animEFootPhase : byte
	{
		RightUp = 0,
		RightForward = 1,
		LeftUp = 2,
		LeftForward = 3,
		NotConsidered = 4
	}

	public enum animEInterpolationType
	{
		Lerp = 0,
		Slerp = 1
	}

	public enum animEMotionExtractionCompressionType
	{
		EMECT_LINEAR = 6,
		EMECT_SPLINE_LOW = 4,
		EMECT_SPLINE_MID = 2,
		EMECT_SPLINE_HIGH = 5,
		EMECT_UNCOMPRESSED = 0,
		EMECT_UNCOMPRESSED_ALL_ANGLES = 3,
		EMECT_UNCOMPRESSED_2D = 7,
		EMECT_UNCOMPRESSED_3D_FALLBACKING = 8,
		EMECT_UNCOMPRESSED_ALL_ANGLES_FALLBACKING = 9
	}

	public enum animEResetTypeNode
	{
		RT_Reference = 0,
		RT_Indentity = 1
	}

	public enum animESpace
	{
		Local = 0,
		Model = 1,
		World = 2
	}

	public enum animESpaceMW
	{
		Model = 0,
		World = 1
	}

	public enum animETransformAxis
	{
		X_Axis = 1,
		Y_Axis = 2,
		Z_Axis = 4
	}

	public enum animEVectorWsToMsType
	{
		Position = 0,
		Direction = 1
	}

	public enum animEventFilterType
	{
		Default = 0,
		AlwaysCollect = 1,
		Solo = 2,
		Mute = 3
	}

	public enum animEventSide
	{
		Left = 0,
		Right = 1
	}

	public enum animFacialEmotionTransitionType
	{
		Natural = 0,
		Fast = 1,
		Blend = 2,
		Instant = 3,
		Custom = 4
	}

	public enum animFloatTrackOperationType
	{
		Override = 0,
		Multiply = 1,
		Add = 2,
		Subtract = 3,
		SubtractSwapped = 4,
		WeightComplement = 5
	}

	public enum animHitReactionType
	{
		None = 0,
		Twitch = 1,
		Impact = 2,
		Stagger = 3,
		Pain = 4,
		Knockdown = 5,
		Ragdoll = 6,
		Death = 7,
		Block = 8,
		GuardBreak = 9,
		Parry = 10,
		Bump = 11
	}

	public enum animLeg
	{
		Left = 0,
		Right = 1
	}

	public enum animLocoStateType
	{
		LS_Pre = 0,
		LS_Loop = 1
	}

	public enum animLocomotionDecision
	{
		LD_None = 0,
		LD_Stop = 1,
		LD_MoveTo = 2,
		LD_Move = 3
	}

	public enum animLocomotion_AnimType
	{
		None = 0,
		idle_stand = 1,
		idle_to_idle_0 = 2,
		idle_to_idle_090 = 3,
		idle_to_idle_270 = 4,
		idle_to_idle_180_l = 5,
		idle_to_idle_180_r = 6,
		walk_0 = 7,
		walk_left = 8,
		walk_right = 9,
		jog_0 = 10,
		jog_left = 11,
		jog_right = 12,
		sprint_0 = 13,
		sprint_left = 14,
		sprint_right = 15,
		idle_to_walk_0 = 16,
		idle_to_jog_0 = 17,
		idle_to_sprint_0 = 18,
		walk_to_idle_0 = 19,
		jog_to_idle_0 = 20,
		sprint_to_idle_0 = 21,
		walk_to_idle_0_l_hard = 22,
		walk_to_idle_0_r_hard = 23,
		jog_to_idle_0_l_hard = 24,
		jog_to_idle_0_r_hard = 25,
		sprint_to_idle_0_l_hard = 26,
		sprint_to_idle_0_r_hard = 27,
		walk_to_jog_0 = 28,
		walk_to_sprint_0 = 29,
		jog_to_walk_0 = 30,
		jog_to_sprint_0 = 31,
		sprint_to_walk_0 = 32,
		sprint_to_jog_0 = 33,
		idle_turn_to_walk_090 = 34,
		idle_turn_to_walk_180_l = 35,
		idle_turn_to_walk_180_r = 36,
		idle_turn_to_walk_270 = 37,
		idle_turn_to_jog_090 = 38,
		idle_turn_to_jog_180_l = 39,
		idle_turn_to_jog_180_r = 40,
		idle_turn_to_jog_270 = 41,
		idle_turn_to_sprint_090 = 42,
		idle_turn_to_sprint_180_l = 43,
		idle_turn_to_sprint_180_r = 44,
		idle_turn_to_sprint_270 = 45,
		walk_180 = 46,
		jog_180 = 47,
		walk_0_to_walk_180_l = 48,
		walk_0_to_walk_180_r = 49,
		walk_180_to_walk_0_l = 50,
		walk_180_to_walk_0_r = 51,
		idle_to_walk_180 = 52,
		idle_to_jog_180 = 53,
		walk_to_idle_180 = 54,
		jog_to_idle_180 = 55,
		jog_0_to_jog_180_l = 56,
		jog_0_to_jog_180_r = 57,
		jog_180_to_jog_0_l = 58,
		jog_180_to_jog_0_r = 59,
		jog_to_sprint_180 = 60,
		walk_to_jog_180 = 61,
		jog_to_walk_180 = 62,
		idle_to_walk_090 = 63,
		idle_to_walk_270 = 64,
		walk_090 = 65,
		walk_270 = 66,
		walk_to_idle_090 = 67,
		walk_to_idle_270 = 68,
		walk_0_to_walk_090 = 69,
		walk_0_to_walk_270 = 70,
		walk_180_to_walk_090 = 71,
		walk_180_to_walk_270 = 72,
		walk_090_to_walk_0 = 73,
		walk_270_to_walk_0 = 74,
		walk_090_to_walk_180 = 75,
		walk_270_to_walk_180 = 76,
		walk_090_to_walk_270_l = 77,
		walk_090_to_walk_270_r = 78,
		walk_270_to_walk_090_l = 79,
		walk_270_to_walk_090_r = 80,
		walk_0_down_stairs = 81,
		walk_0_up_stairs = 82,
		walk_0_down_slope = 83,
		walk_0_up_slope = 84,
		jog_0_down_stairs = 85,
		jog_0_up_stairs = 86,
		jog_0_down_slope = 87,
		jog_0_up_slope = 88,
		sprint_0_down_stairs = 89,
		sprint_0_up_stairs = 90,
		sprint_0_down_slope = 91,
		sprint_0_up_slope = 92,
		walk_090_up_stairs = 93,
		walk_090_down_stairs = 94,
		walk_270_up_stairs = 95,
		walk_270_down_stairs = 96,
		walk_180_up_stairs = 97,
		walk_180_down_stairs = 98,
		idle_step_single_0 = 99,
		idle_step_single_090 = 100,
		idle_step_single_180 = 101,
		idle_step_single_270 = 102
	}

	public enum animLocomotion_Style
	{
		LS_Idle = 0,
		LS_Rotation = 1,
		LS_Walk = 2,
		LS_Jog = 3,
		LS_Sprint = 4,
		LS_Any = 5
	}

	public enum animLookAtChestMode
	{
		Default = 0,
		NoHips = 1,
		Horizontal = 2,
		HorizontalNoHips = 3,
		ENUM_SIZE = 4
	}

	public enum animLookAtEyesMode
	{
		Default = 0,
		Horizontal = 1,
		ENUM_SIZE = 2
	}

	public enum animLookAtHeadMode
	{
		Default = 0,
		Horizontal = 1,
		ENUM_SIZE = 2
	}

	public enum animLookAtLeftHandedMode
	{
		Default = 0,
		Horizontal = 1,
		ENUM_SIZE = 2
	}

	public enum animLookAtLimitDegreesType
	{
		Narrow = 0,
		Normal = 1,
		Wide = 2,
		None = 3
	}

	public enum animLookAtLimitDistanceType
	{
		Short = 0,
		Normal = 1,
		Long = 2,
		None = 3
	}

	public enum animLookAtRightHandedMode
	{
		Default = 0,
		Horizontal = 1,
		ENUM_SIZE = 2
	}

	public enum animLookAtStatus
	{
		Active = 2,
		LimitReached = 4,
		TransitionInProgress = 8
	}

	public enum animLookAtStyle
	{
		VerySlow = 0,
		Slow = 1,
		Normal = 2,
		Fast = 3,
		VeryFast = 4
	}

	public enum animLookAtTwoHandedMode
	{
		Default = 0,
		Horizontal = 1,
		ENUM_SIZE = 2
	}

	public enum animMotionTableAction
	{
		MTA_None = 0,
		MTA_Start = 1,
		MTA_Stop = 2,
		MTA_Move = 3,
		MTA_TurnInPlace = 4,
		MTA_TransitionToBackward = 5,
		MTA_BackwardMove = 6,
		MTA_TransitionFromBackward = 7,
		MTA_StrafeLeft = 8,
		MTA_StrafeRight = 9,
		MTA_ForwardToStrafeLeft = 10,
		MTA_ForwardToStrafeRight = 11,
		MTA_StrafeLeftToForward = 12,
		MTA_StrafeRightToForward = 13,
		MTA_BackwardToStrafeLeft = 14,
		MTA_BackwardToStrafeRight = 15,
		MTA_StrafeLeftToBackward = 16,
		MTA_StrafeRightToBackward = 17,
		MTA_BackwardStart = 18,
		MTA_BackwardStop = 19,
		MTA_StrafeLeftStart = 20,
		MTA_StrafeLeftStop = 21,
		MTA_StrafeRightStart = 22,
		MTA_StrafeRightStop = 23,
		MTA_ForwardToWalk = 24,
		MTA_ForwardToJog = 25,
		MTA_ForwardToSprint = 26,
		MTA_HardStopLeftLeg = 27,
		MTA_HardStopRightLeg = 28,
		MTA_RepositionForward = 29,
		MTA_RepositionLeft = 30,
		MTA_RepositionRight = 31,
		MTA_RepositionBackward = 32,
		MTA_Custom = 33,
		MTA_CrowdMove = 34,
		MTA_CrowdMoveSlopes = 35,
		MTA_CrowdMoveStairs = 36,
		MTA_StrafeLeftToStrafeRight = 37,
		MTA_StrafeRightToStrafeLeft = 38,
		MTA_CrowdRelaxedStop = 39,
		MTA_CrowdHardStop = 40,
		MTA_CrowdSprintStop = 41,
		MTA_CrowdFleeStopFront = 42,
		MTA_CrowdFleeStopBack = 43,
		MTA_CrowdRelaxedStart = 44,
		MTA_CrowdFleeStartIdle = 45,
		MTA_CrowdFleeStartMotion = 46,
		MTA_CrowdDirectionalStartFast = 47
	}

	public enum animMotionTableType
	{
		MTT_None = 0,
		MTT_Walk = 1,
		MTT_Jog = 2,
		MTT_Sprint = 3,
		MTT_Custom = 4
	}

	public enum animMotionTag
	{
		MT_Invalid = 0,
		Walk = 1,
		Jog = 2,
		Sprint = 3
	}

	[Flags]
	public enum animMuteAnimEvents
	{
		STANDARD = 1 << 0,
		FACE_ANIMS = 1 << 1
	}

	public enum animNPCVehicleDeathType
	{
		Default = 0,
		Relaxed = 1,
		Combat = 2,
		Ragdoll = 3
	}

	public enum animNodeProfileTimerMode
	{
		Begin = 0,
		End = 1
	}

	public enum animParentStaticSwitchBranch
	{
		None = 0,
		TrueBranch = 1,
		FalseBranch = 2
	}

	public enum animPendulumConstraintType
	{
		Cone = 0,
		HingePlane = 1,
		HalfCone = 2
	}

	public enum animPendulumProjectionType
	{
		Disabled = 0,
		ShortestPathRotational = 1,
		DirectedRotational = 2
	}

	public enum animPositionProjectionType
	{
		Disabled = 0,
		ShortestPath = 1,
		Directional = 2
	}

	public enum animQuaternionInterpolationType
	{
		Linear = 0,
		Spherical = 1
	}

	public enum animSetBoneTransformEntry_SetMethod
	{
		NoSnapping = 0,
		WholeTransform = 1,
		TranslationOnly = 2,
		RotationOnly = 3
	}

	public enum animSpringProjectionType
	{
		Disabled = 0,
		ShortestPath = 1
	}

	public enum animStackTransformsExtender_SnapToBoneMethod
	{
		NoSnapping = 0,
		WholeTransform = 1,
		TranslationOnly = 2,
		RotationOnly = 3
	}

	public enum animStanceState
	{
		Stand = 0,
		Crouch = 1,
		Kneel = 2,
		Cover = 3,
		Swim = 4,
		Crawl = 5
	}

	public enum animStateTag
	{
		ST_Invalid = 0,
		Idle = 1,
		Cover = 2
	}

	public enum animTransformChannel
	{
		PosX = 0,
		PosY = 1,
		PosZ = 2,
		RotX = 3,
		RotY = 4,
		RotZ = 5,
		ScaleX = 6,
		ScaleY = 7,
		ScaleZ = 8
	}

	public enum animVectorCoordinateType
	{
		X = 0,
		Y = 1,
		Z = 2,
		W = 3
	}

	public enum animWeaponOwnerType
	{
		Player = 0,
		NPC = 1,
		None = 2
	}

	public enum animcompressionBufferTypePreset : byte
	{
		Spline = 0,
		SIMD = 1,
		TestRaw = 2
	}

	public enum animcompressionFrameratePreset : byte
	{
		USE_30_HZ = 0,
		USE_15_HZ = 1,
		USE_10_HZ = 2
	}

	public enum animcompressionQualityPreset : byte
	{
		CINEMATIC_HIGH = 3,
		HIGH = 0,
		MID = 1,
		LOW = 2
	}

	public enum audioAdvertIndoorFilter
	{
		Always = 0,
		OnlyIndoor = 1,
		OnlyOutdoor = 2
	}

	public enum audioAmbientGroupingVariant
	{
		AllEntities = 0,
		IndoorEntities = 1,
		OutdoorEntities = 2,
		AllEntitiesAllDirections = 3,
		IndoorAllDirections = 4,
		OutdoorAllDirections = 5,
		SameRoomEntities = 6,
		DifferentRoomEntities = 7,
		DistanceExclusion = 8
	}

	public enum audioAudioEventFlags
	{
		NoEventFlags = 0,
		SloMoOnly = 1,
		Music = 2,
		Unique = 4,
		Metadata = 8
	}

	public enum audioAudioVehicleCurve
	{
		ThrottleInput = 0,
		RPM = 1,
		Gear = 2
	}

	public enum audioBreathingTransitionComparator
	{
		Less = 0,
		Equal = 1,
		Greater = 2
	}

	public enum audioBreathingTransitionType
	{
		PlayerSpeed = 0,
		Event = 1,
		AllEventTags = 2,
		AnyEventTag = 3
	}

	public enum audioClassificationMethod
	{
		HasAnyTag = 0,
		HasAllTags = 1,
		NameEquals = 2,
		EventNameEquals = 3,
		HasAllEventTags = 4
	}

	public enum audioConversationSavingStrategy
	{
		Default = 0,
		Save = 1,
		DontSave = 2
	}

	public enum audioDynamicReverbType
	{
		Dynamic = 0,
		StaticSmall = 1,
		EnvironmentSmallStaticMedium = 2,
		DynamicSource = 3
	}

	public enum audioESoundCurveType
	{
		Log3 = 0,
		Sine = 1,
		InversedSCurve = 3,
		Linear = 4,
		SCurve = 5,
		Exp1 = 6,
		ReciprocalOfSineCurve = 7,
		Exp3 = 8
	}

	public enum audioEchoPositionType
	{
		DynamicEnvironment = 0,
		Simple = 1
	}

	public enum audioEnemyState : byte
	{
		InCombat = 0,
		Alerted = 1,
		Afraid = 2,
		Alive = 3,
		Dead = 4
	}

	public enum audioEntityEmitterContextType
	{
		[RED("Entity Emitter")] Entity_Emitter = 0,
		[RED("Radio Emitter")] Radio_Emitter = 2
	}

	public enum audioEventActionType
	{
		Play = 0,
		PlayAnimation = 1,
		SetParameter = 2,
		StopSound = 3,
		SetSwitch = 4,
		StopTagged = 5,
		PlayExternal = 6,
		Tag = 7,
		Untag = 8,
		SetAppearanceName = 9,
		SetEntityName = 10,
		AddContainerStreamingPrefetch = 11,
		RemoveContainerStreamingPrefetch = 12
	}

	public enum audioFoleyActionType
	{
		FastHeavy = 0,
		FastMedium = 1,
		FastLight = 2,
		NormalHeavy = 3,
		NormalMedium = 4,
		NormalLight = 5,
		SlowHeavy = 6,
		SlowMedium = 7,
		SlowLight = 8,
		Walk = 9,
		Run = 10
	}

	public enum audioFoleyItemPriority : byte
	{
		P0 = 0,
		P1 = 1,
		P2 = 2,
		P3 = 3,
		P4 = 4,
		P5 = 5,
		P6 = 6
	}

	public enum audioFoleyItemType : byte
	{
		Jacket = 0,
		Top = 1,
		Bottom = 2,
		Jewelry = 3
	}

	public enum audioGameplayTier
	{
		Undefined = 0,
		Tier1_FullGameplay = 1,
		Tier2_StagedGameplay = 2,
		Tier3_LimitedGameplay = 3,
		Tier4_FPPCinematic = 4,
		Tier5_Cinematic = 5
	}

	public enum audioLimitedSoundType : byte
	{
		Locomotion = 0,
		Footsteps = 1,
		Impact = 2,
		Ragdoll = 3,
		Physics = 4,
		Destructibles = 5,
		Ono = 6,
		VO = 7
	}

	public enum audioMaterialHardnessOverride
	{
		None = 0,
		SetAsSoft = 1,
		SetAsSolid = 2,
		SetAsHard = 3
	}

	public enum audioMeleeHitPerMaterialType
	{
		Light = 0,
		Light_Hard = 1,
		Light_Soft = 2,
		Light_Solid = 3,
		Light_Flesh = 4,
		Light_Flesh_Head = 5,
		Light_Robot = 6,
		Light_Robot_Head = 7,
		Light_Android = 8,
		Light_Android_Head = 9,
		Light_Mech = 10,
		Light_Mech_Head = 11,
		Light_Water = 12,
		Normal = 13,
		Normal_Hard = 14,
		Normal_Soft = 15,
		Normal_Solid = 16,
		Normal_Flesh = 17,
		Normal_Flesh_Head = 18,
		Normal_Robot = 19,
		Normal_Robot_Head = 20,
		Normal_Android = 21,
		Normal_Android_Head = 22,
		Normal_Mech = 23,
		Normal_Mech_Head = 24,
		Normal_Water = 25,
		Heavy = 26,
		Heavy_Hard = 27,
		Heavy_Soft = 28,
		Heavy_Solid = 29,
		Heavy_Flesh = 30,
		Heavy_Flesh_Head = 31,
		Heavy_Robot = 32,
		Heavy_Robot_Head = 33,
		Heavy_Android = 34,
		Heavy_Android_Head = 35,
		Heavy_Mech = 36,
		Heavy_Mech_Head = 37,
		Heavy_Water = 38,
		Slash = 39,
		Slash_Hard = 40,
		Slash_Soft = 41,
		Slash_Solid = 42,
		Slash_Flesh = 43,
		Slash_Flesh_Head = 44,
		Slash_Robot = 45,
		Slash_Robot_Head = 46,
		Slash_Android = 47,
		Slash_Android_Head = 48,
		Slash_Mech = 49,
		Slash_Mech_Head = 50,
		Slash_Water = 51,
		Cut = 52,
		Cut_Hard = 53,
		Cut_Soft = 54,
		Cut_Solid = 55,
		Cut_Flesh = 56,
		Cut_Flesh_Head = 57,
		Cut_Robot = 58,
		Cut_Robot_Head = 59,
		Cut_Android = 60,
		Cut_Android_Head = 61,
		Cut_Mech = 62,
		Cut_Mech_Head = 63,
		Cut_Water = 64,
		Stab = 65,
		Stab_Hard = 66,
		Stab_Soft = 67,
		Stab_Solid = 68,
		Stab_Flesh = 69,
		Stab_Flesh_Head = 70,
		Stab_Robot = 71,
		Stab_Robot_Head = 72,
		Stab_Android = 73,
		Stab_Android_Head = 74,
		Stab_Mech = 75,
		Stab_Mech_Head = 76,
		Stab_Water = 77,
		Finisher = 78,
		Finisher_Hard = 79,
		Finisher_Soft = 80,
		Finisher_Solid = 81,
		Finisher_Flesh = 82,
		Finisher_Flesh_Head = 83,
		Finisher_Robot = 84,
		Finisher_Robot_Head = 85,
		Finisher_Android = 86,
		Finisher_Android_Head = 87,
		Finisher_Mech = 88,
		Finisher_Mech_Head = 89,
		Finisher_Water = 90,
		Weak = 91,
		Weak_Hard = 92,
		Weak_Soft = 93,
		Weak_Solid = 94,
		Weak_Flesh = 95,
		Weak_Flesh_Head = 96,
		Weak_Robot = 97,
		Weak_Robot_Head = 98,
		Weak_Android = 99,
		Weak_Android_Head = 100,
		Weak_Mech = 101,
		Weak_Mech_Head = 102,
		Weak_Water = 103,
		Throw = 104,
		Throw_Hard = 105,
		Throw_Soft = 106,
		Throw_Solid = 107,
		Throw_Flesh = 108,
		Throw_Flesh_Head = 109,
		Throw_Robot = 110,
		Throw_Robot_Head = 111,
		Throw_Android = 112,
		Throw_Android_Head = 113,
		Throw_Mech = 114,
		Throw_Mech_Head = 115,
		Throw_Water = 116
	}

	public enum audioMeleeHitType
	{
		Light = 0,
		Normal = 1,
		Heavy = 2,
		Slash = 3,
		Cut = 4,
		Stab = 5,
		Finisher = 6,
		Weak = 7,
		Throw = 8
	}

	public enum audioMeleeMaterialType
	{
		Hard = 0,
		Soft = 1,
		Solid = 2,
		Flesh = 3,
		Robot = 4,
		Android = 5,
		Mech = 6,
		Water = 7
	}

	public enum audioMixParamsAction
	{
		Mull = 0,
		MullPercent = 1,
		MullComplemtement = 2,
		MullComplemtementPercent = 3,
		Add = 4
	}

	public enum audioMixingActionType : byte
	{
		VoContext = 0,
		EmitterTag = 1,
		SoundTag = 2,
		ActorName = 3,
		DisableCombatVo = 4,
		GlobalParameter = 5
	}

	public enum audioMusicSyncType
	{
		Beat = 1,
		Bar = 0,
		Grid = 2,
		User = 3,
		EntryCue = 5,
		ExitCue = 6,
		Transition = 4
	}

	public enum audioNumberComparer : byte
	{
		Equal = 0,
		NotEqual = 1,
		Greater = 2,
		GreaterOrEqual = 3,
		Lower = 4,
		LowerOrEqual = 5
	}

	public enum audioNumberOperation : byte
	{
		SetEqual = 0,
		Add = 1,
		Subtract = 2,
		MultiplyBy = 3,
		DivideBy = 4
	}

	public enum audioObstructionTestPattern
	{
		Direct = 0,
		Cone = 1
	}

	public enum audioObstructionTestType
	{
		SingleShot = 0,
		Continuous = 1
	}

	public enum audioRadioSoundType : byte
	{
		Song = 0,
		AnnouncementScene = 1
	}

	public enum audioRadioSpeakerType
	{
		Stanley = 0,
		MaximumMike = 1,
		PoliceDispatch = 2,
		Kurtz = 3,
		Ash = 4,
		None = 5
	}

	public enum audioReflectionVariant
	{
		WorldSpaceFixedDrections = 0,
		LocalSpaceFixedDirections = 1,
		FindingMaximumFaceAlignemnt = 2,
		LocalSpaceSideDirections = 3,
		FindingMaximumFaceAligment2Sides = 4
	}

	public enum audioTrafficVehicleAudioAction
	{
		StartEngine = 0,
		StopEngine = 1,
		StartWheel = 2,
		StopWheel = 3,
		StartRainLoop = 4,
		StopRainLoop = 5,
		Horn = 6,
		HornForced = 7,
		DisableAbilityToPlayRadio = 8,
		StartBrakeLoop = 9,
		EndBrakeLoop = 10,
		ApplyBrake = 11,
		ReleaseBrake = 12
	}

	public enum audioTriggerEffectMode : byte
	{
		Off = 0,
		Feedback = 1,
		Weapon = 2,
		Vibration = 3
	}

	public enum audioTriggerEffectTarget : byte
	{
		L2 = 0,
		R2 = 1,
		Both = 2
	}

	public enum audioVoBarkType
	{
		None = 0,
		Curse = 1,
		Morale = 2,
		Combat_Aggro = 3,
		Combat_Despair = 4,
		Stealth_Curious = 5
	}

	public enum audioVoCpoCharacter
	{
		None = 0,
		Solo = 1,
		Assassin = 2,
		Techie = 3,
		Netrunner = 4
	}

	public enum audioVoGruntInterruptMode
	{
		DontInterrupt = 0,
		PlayOnlyOnInterrupt = 1,
		CanInterrupt = 2
	}

	public enum audioVoGruntType
	{
		None = -1,
		PainShort = 23,
		PainLong = 0,
		AgroShort = 1,
		AgroLong = 2,
		Effort = 25,
		LongFall = 3,
		Death = 4,
		SilentDeath = 5,
		Grapple = 6,
		GrappleMovement = 7,
		EnvironmentalKnockdown = 8,
		Bump = 9,
		Curious = 10,
		Fear = 11,
		Jump = 12,
		EffortLong = 13,
		DeathShort = 14,
		Greet = 15,
		LaughHard = 16,
		LaughSoft = 17,
		Phone = 18,
		BraindanceExcited = 19,
		BraindanceFearful = 20,
		BraindanceNeutral = 21,
		BraindanceSexual = 22
	}

	public enum audioWeaponBulletType
	{
		standard = 0,
		sniper = 1,
		shot = 2,
		rail = 3,
		automatic = 4,
		smart = 5,
		smart_sniper = 6,
		hmg = 7
	}

	public enum audioWeaponShellCasingDirection
	{
		rightFront = 0,
		rightBack = 1,
		leftFront = 2,
		leftBack = 3
	}

	public enum audioWeaponShellCasingMode
	{
		none = 0,
		onShoot = 1,
		onReload = 2
	}

	public enum audioWeaponShellCasingType
	{
		standard = 0,
		large = 1,
		cartridge = 2
	}

	public enum audioWeaponTailEnvironment
	{
		InteriorDefault = 0,
		InteriorWide = 1,
		ExteriorWide = 2,
		ExteriorUrbanNarrow = 3,
		ExteriorUrbanStreet = 4,
		ExteriorUrbanStreetWide = 5,
		ExteriorUrbanOpen = 6,
		ExteriorUrbanEnclosed = 7,
		ExteriorBadlandsOpen = 8,
		ExteriorBadlandsCanyon = 9
	}

	public enum audiobreathingEventTag : byte
	{
		Walk = 0,
		Jog = 1,
		Run = 2,
		Sneak = 3,
		Cloth = 4,
		FootStepRegular = 5,
		FootStepSprint = 6,
		LandingRegular = 7,
		LandingHard = 8,
		LandingVeryHard = 9,
		Climb = 10,
		Jump = 11,
		Player = 12,
		Stop = 13,
		Drop_Body = 14,
		Pick_Up_Body = 15,
		Standing_Event = 16
	}

	public enum audiobreathingLoopBehavior : byte
	{
		TimedBreathing = 0,
		BreathEvery2ndStep = 1,
		BreathEveryStep = 2,
		HoldingBreath = 3
	}

	public enum audiottsvoicesFemale
	{
		Olivia = 7,
		Emily = 8,
		Jessica = 9,
		Sophie = 10,
		Elizabeth = 11,
		Carolina = 12,
		Sarah = 13
	}

	public enum audiottsvoicesMale
	{
		Andrew = 0,
		Oliver = 1,
		Jack = 2,
		Harry = 3,
		Simon = 4,
		Charlie = 5,
		Thomas = 6
	}

	public enum audiottsvoicesPolishFemale
	{
		Iwona = 16,
		Paulina = 17
	}

	public enum audiottsvoicesPolishMale
	{
		Mateusz = 14,
		Pawel = 15
	}

	public enum braindanceVisionMode
	{
		Default = 0,
		Audio = 1,
		Thermal = 2
	}

	public enum communityECommunitySpawnTime : byte
	{
		Morning = 0,
		Day = 1,
		Evening = 2,
		Night = 3,
		Midnight = 4,
		[RED("1:00")] _1_00 = 5,
		[RED("2:00")] _2_00 = 6,
		[RED("3:00")] _3_00 = 7,
		[RED("4:00")] _4_00 = 8,
		[RED("5:00")] _5_00 = 9,
		[RED("6:00")] _6_00 = 10,
		[RED("7:00")] _7_00 = 11,
		[RED("8:00")] _8_00 = 12,
		[RED("9:00")] _9_00 = 13,
		[RED("10:00")] _10_00 = 14,
		[RED("11:00")] _11_00 = 15,
		[RED("12:00 - Noon")] _12_00___Noon = 16,
		[RED("13:00")] _13_00 = 17,
		[RED("14:00")] _14_00 = 18,
		[RED("15:00")] _15_00 = 19,
		[RED("16:00")] _16_00 = 20,
		[RED("17:00")] _17_00 = 21,
		[RED("18:00")] _18_00 = 22,
		[RED("19:00")] _19_00 = 23,
		[RED("20:00")] _20_00 = 24,
		[RED("21:00")] _21_00 = 25,
		[RED("22:00")] _22_00 = 26,
		[RED("23:00")] _23_00 = 27
	}

	public enum communityESquadType : byte
	{
		Global = 0,
		Community = 1,
		Security = 2,
		Unknown = 3
	}

	public enum coverLeanDirection
	{
		Top = 0,
		Left = 1,
		Right = 2
	}

	public enum curveEInterpolationType : byte
	{
		EIT_Constant = 0,
		EIT_Linear = 1,
		EIT_BezierQuadratic = 2,
		EIT_BezierCubic = 3,
		EIT_Hermite = 4
	}

	public enum curveESegmentsLinkType : byte
	{
		ESLT_Normal = 0,
		ESLT_Smooth = 1,
		ESLT_SmoothSymmetric = 2
	}

	public enum damageSystemLogFlags
	{
		GENERAL = 1,
		ASSERT = 2,
		WEAKSPOTS = 4
	}

	public enum entAnimParamSlotFunction
	{
		RenderingPlane = 0,
		Visibility = 1
	}

	public enum entAppearanceStatus : byte
	{
		None = 0,
		Proxy = 1,
		Appearance = 2
	}

	public enum entAttachmentTarget
	{
		Transform = 0,
		TargetPosition = 1
	}

	public enum entAudioDismembermentPart
	{
		Head = 0,
		Leg = 1,
		Arm = 2
	}

	public enum entDebug_ShapeType : byte
	{
		Sphere = 0,
		Box = 1,
		Capsule = 2,
		Cylinder = 3
	}

	public enum entEBindingDirection : byte
	{
		BindToSource = 0,
		BindToDestination = 1
	}

	public enum entEntitySpawnPriority : byte
	{
		Background = 0,
		Normal = 1,
		Immediate = 2,
		Paramount = 3,
		Critical = 4
	}

	public enum entEntityUserComponentResolutionMode : byte
	{
		Select = 0,
		Suppress = 1
	}

	public enum entForcedLodDistance : byte
	{
		Default = 0,
		Background = 1,
		Regular = 2,
		Cinematic = 3,
		Vehicle = 4,
		CinematicVehicle = 5,
		VehicleInterior = 6,
		VehicleDecoration = 7,
		ConsoleLOD = 8
	}

	public enum entMeshComponentLODMode : byte
	{
		AlwaysVisible = 0,
		Appearance = 1,
		AppearanceProxy = 2
	}

	public enum entRenderToTextureFeaturesPlatform : byte
	{
		RTFP_All = 0,
		RTFP_PC = 1,
		RTFP_PC_PS5_XSX = 2,
		RTFP_Consoles = 3,
		RTFP_None = 4
	}

	public enum entRenderToTextureMode : byte
	{
		Shaded = 0,
		GBufferOnly = 1
	}

	public enum entRepellingShape
	{
		Sphere = 0,
		Capsule = 1
	}

	public enum entRepellingType : byte
	{
		Debris = 0,
		BigObjects = 1,
		WindImpulse = 2,
		WaterImpulse = 3
	}

	public enum entTemplateComponentResolveMode : byte
	{
		AutoSelect = 0,
		Select = 1,
		Suppress = 2
	}

	public enum entVertexAnimationMapperSourceType
	{
		FloatTrack = 0,
		TranslationX = 1,
		TranslationY = 2,
		TranslationZ = 3,
		RotationQuatX = 4,
		RotationQuatY = 5,
		RotationQuatZ = 6,
		RotationQuatW = 7
	}

	public enum entVisibilityParamSource : byte
	{
		PhantomEntitySystem = 7
	}

	[Flags]
	public enum entdismembermentGoreTypeE
	{
		FLESH = 1 << 2,
		CYBER = 1 << 3
	}

	[Flags]
	public enum entdismembermentPlacementE
	{
		MAIN_MESH = 1 << 4,
		DISM_MESH = 1 << 5,
		RAGDOLL_CONTACT = 1 << 8,
		RAGDOLL_CONTACT_SLIDE = 1 << 9,
		RAGDOLL_SLEEP = 1 << 10
	}

	public enum entdismembermentResourceSetE : byte
	{
		NONE = 16,
		BARE = 0,
		BARE1 = 1,
		BARE2 = 2,
		BARE3 = 3,
		GARMENT = 4,
		GARMENT1 = 5,
		GARMENT2 = 6,
		GARMENT3 = 7,
		CYBER = 8,
		CYBER1 = 9,
		CYBER2 = 10,
		CYBER3 = 11,
		MIXED = 12,
		MIXED1 = 13,
		MIXED2 = 14,
		MIXED3 = 15
	}

	[Flags]
	public enum entdismembermentResourceSetMask
	{
		BARE = 1 << 0,
		BARE1 = 1 << 1,
		BARE2 = 1 << 2,
		BARE3 = 1 << 3,
		GARMENT = 1 << 4,
		GARMENT1 = 1 << 5,
		GARMENT2 = 1 << 6,
		GARMENT3 = 1 << 7,
		CYBER = 1 << 8,
		CYBER1 = 1 << 9,
		CYBER2 = 1 << 10,
		CYBER3 = 1 << 11,
		MIXED = 1 << 12,
		MIXED1 = 1 << 13,
		MIXED2 = 1 << 14,
		MIXED3 = 1 << 15
	}

	public enum entdismembermentSimulationTypeE : ushort
	{
		NONE = 0,
		DANGLE = 128
	}

	[Flags]
	public enum entdismembermentWoundTypeE
	{
		CLEAN = 1 << 0,
		COARSE = 1 << 1,
		HOLE = 1 << 6
	}

	public enum entragdollActivationRequestType
	{
		Default = 0,
		Animated = 1,
		Forced = 2
	}

	public enum envUtilsNeighborMode : byte
	{
		eCLOSEST = 0,
		eONLY_GLOBAL = 1,
		eONLY_SELF = 2,
		eFILL_SURROUNDING = 3
	}

	public enum envUtilsReflectionProbeAmbientContributionMode : byte
	{
		eNO_AMBIENT_CONTRIBUTION = 0,
		eALLOW_AMBIENT_CONTRIBUTION = 1,
		eOVERRIDE_GI_AMBIENT = 2
	}

	public enum gameAIDirectorTensionEventType
	{
		Time = 0,
		Progress = 1,
		DealingDamage = 2,
		TakingDamage = 3,
		Kill = 4
	}

	public enum gameAggregationType
	{
		AND = 0,
		OR = 1
	}

	public enum gameAlwaysSpawnedState : byte
	{
		[RED("default (false)")] default__false_ = 0,
		[RED("true")] true_ = 1,
		[RED("false")] false_ = 2
	}

	public enum gameAppearanceSource
	{
		EntityResource = 0,
		PopulationSpawner = 1,
		CommunityEntry = 2,
		CommunityAppearancePicker = 3,
		TweakDBRecord = 4,
		VisualTag = 5,
		Invalid = 7
	}

	public enum gameBinkVideoAction : byte
	{
		Undefined = 0,
		Start = 1,
		Stop = 2
	}

	public enum gameBoolSignalAction
	{
		None = 0,
		TurnOn = 1,
		TurnOff = 2
	}

	public enum gameBreachUITrackingChange
	{
		NoChange = 0,
		StartedNew = 1,
		StoppedOnTimeout = 2,
		StoppedOnTargetDeath = 3,
		StoppedOnDestroyed = 6,
		StoppedForced = 7,
		Hidden = 8,
		Unhidden = 9
	}

	public enum gameCameraCurve
	{
		CentricPitchOfSpeed = 0,
		CentricVerticalOffsetOfSpeed = 1,
		BoomLengthOfSpeed = 2,
		BoomLengthOfAcc = 3,
		BoomPitchOfSpeed = 4,
		BoomPitchOfGlobalVehiclePitch = 5,
		BoomYawOfTurnCoeff = 6,
		BoomYawRotateRateOfSpeed = 7,
		FOVOfSpeed = 8,
		PivotOffsetXOfTurnCoeff = 9,
		PivotOffsetZOfTurnCoeff = 10,
		COUNT = 11
	}

	public enum gameCityAreaType
	{
		Undefined = 0,
		PublicZone = 1,
		SafeZone = 2,
		RestrictedZone = 3,
		DangerousZone = 4
	}

	public enum gameCombinedStatOperation
	{
		Addition = 0,
		Subtraction = 1,
		Multiplication = 2,
		Division = 3,
		Modulo = 4,
		Invert = 5,
		ComplementMultiplication = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gameComparisonType
	{
		EQUAL = 0,
		NOT_EQUAL = 1,
		LESS = 2,
		GREATER = 3,
		LESS_OR_EQUAL = 4,
		GREATER_OR_EQUAL = 5
	}

	public enum gameContactType
	{
		Caller = 0,
		Texter = 1
	}

	public enum gameCoverHeight
	{
		Invalid = 0,
		Low = 1,
		High = 2
	}

	public enum gameCrowdCreationDataMergeMode : byte
	{
		Average = 0,
		Override = 1
	}

	public enum gameCrowdEntryType : byte
	{
		Pedestrian = 0,
		Vehicle = 1,
		AV = 2
	}

	public enum gameDamageCallbackType
	{
		HitTriggered = 0,
		MissTriggered = 3,
		HitReceived = 1,
		PipelineProcessed = 2,
		COUNT = 4,
		INVALID = 5
	}

	public enum gameDamageListenerPipelineType
	{
		None = 0,
		Damage = 1,
		ProjectedDamage = 2,
		All = -1
	}

	public enum gameDamagePipelineStage
	{
		PreProcess = 0,
		Process = 1,
		ProcessHitReaction = 2,
		PostProcess = 3,
		COUNT = 4,
		INVALID = 5
	}

	public enum gameDebugViewETextAlignment
	{
		Left = -1,
		Center = 0,
		Right = 1
	}

	public enum gameDelayContext
	{
		Standard_TD = 1,
		Standard_ND = 2,
		Quest_TD = 4,
		SpawnManager_ND = 8
	}

	public enum gameDifficulty
	{
		Easy = 0,
		Hard = 1,
		VeryHard = 2,
		Story = 3
	}

	public enum gameDismBodyPart
	{
		LEFT_LEG = 896,
		RIGHT_LEG = 7168,
		LEFT_ARM = 14,
		RIGHT_ARM = 112,
		HEAD = 1,
		BODY = 8192
	}

	public enum gameDismWoundType
	{
		CLEAN = 1,
		COARSE = 2,
		HOLE = 64
	}

	public enum gameDynamicVehicleType
	{
		None = 0,
		Car = 1,
		AV = 2,
		RoadBlockade = 3,
		RoadBlockadeWithAV = 4
	}

	public enum gameEActionFlags : ushort
	{
		NONE = 0,
		USE_ANIMATION = 1,
		USE_MOVEMENT = 2
	}

	public enum gameEActionStatus
	{
		STATUS_INVALID = 0,
		STATUS_BOUND = 1,
		STATUS_READY = 2,
		STATUS_PROGRESS = 3,
		STATUS_COMPLETE = 4,
		STATUS_FAILURE = 5
	}

	public enum gameEAreaShape : ushort
	{
		NONE = 0,
		SPHERE = 1,
		CUBE = 2,
		COUNT = 3
	}

	public enum gameEAreaType : ushort
	{
		NONE = 0,
		LOCATION = 1,
		AFFILIATION = 2,
		COUNT = 3
	}

	public enum gameECharacterStance
	{
		Stance_Stand = 0,
		Stance_Crouch = 1,
		Stance_Kneel = 2,
		Stance_Cover = 3,
		Stance_Standing_Cover = 4,
		Stance_Crouching_Cover = 5
	}

	public enum gameEContinuousMode
	{
		None = 0,
		Start = 1,
		Stop = 2
	}

	public enum gameEEquipmentManagerState
	{
		InfiniteAmmo = 1
	}

	public enum gameEHotkey
	{
		INVALID = -1,
		DPAD_UP = 0,
		DPAD_DOWN = 1,
		DPAD_RIGHT = 2,
		RB = 3,
		LBRB = 4
	}

	public enum gameEInventoryFlags
	{
		MustSave = 1
	}

	[Flags]
	public enum gameEItemDynamicTags
	{
		Quest = 1 << 0,
		UnequipBlocked = 1 << 1,
		DLCAdded = 1 << 2,
		TransmogBlocked = 1 << 3
	}

	public enum gameEItemIDFlag : byte
	{
		Preview = 1
	}

	public enum gameELootGenerationType
	{
		DropChance = 0,
		NumberBased = 1,
		Weights = 2,
		Count = 3
	}

	public enum gameEMaterialZone : byte
	{
		Zero = 0,
		One = 1,
		Two = 2,
		Three = 3
	}

	public enum gameEPowerDifferential
	{
		IMPOSSIBLE = -6,
		HARD = -3,
		NORMAL = 2,
		EASY = 4,
		TRASH = 5
	}

	public enum gameEPrerequisiteType
	{
		None = 0,
		NestedPrereq = 1,
		StatValue = 2,
		StatPoolValue = 3,
		HealthAbsolute = 4,
		HealthPercent = 5,
		ItemInInventory = 6,
		ItemEquipped = 7,
		ItemCount = 8,
		QuestAchieved = 9,
		WasScanned = 10,
		Attitude = 11,
		Count = 12
	}

	public enum gameESlotState
	{
		Taken = 0,
		Empty = 1,
		Available = 2
	}

	public enum gameEStatFlags
	{
		Bool = 1,
		EquipOnPlayer = 2,
		EquipOnNPC = 4,
		ExcludeRootCombination = 8
	}

	public enum gameEStatProviderDataSource
	{
		gameItemData = 0,
		InventoryItemData = 1,
		InnerItemData = 2,
		Invalid = 3
	}

	public enum gameEffectAction_KillFXAction
	{
		Stop = 0,
		BreakLoop = 1
	}

	public enum gameEffectExecutor_AnimFeatureApplyTo
	{
		Target = 0,
		Instigator = 1
	}

	public enum gameEffectHitDataType : byte
	{
		Entity = 0,
		Node = 1,
		Static = 2
	}

	public enum gameEffectObjectFilter_AxisRangeAxis
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum gameEffectObjectFilter_EntityTypeEntityTypeFilter
	{
		Puppet = 0,
		Device = 1
	}

	public enum gameEffectObjectFilter_HitTypeAction
	{
		Accept = 0,
		Reject = 1
	}

	public enum gameEffectTriggerPositioningType
	{
		PlayerRoot = 0,
		CameraRoot = 1,
		AtSpawn = 2,
		XYCameraZPlayer = 3,
		XYPlayerZCamera = 4,
		XYCameraZTerrain = 5,
		XYPlayerZTerrain = 6
	}

	public enum gameEffectTriggerRotationType
	{
		None = 0,
		AtSpawn = 1,
		Continuous = 2
	}

	public enum gameEnemyStealthAwarenessState
	{
		Relaxed = 0,
		Aware = 1,
		Alerted = 2,
		Combat = 3
	}

	public enum gameEntityReferenceType : byte
	{
		EntityRef = 0,
		Tag = 1,
		SlotID = 2,
		SceneActorContextName = 3
	}

	public enum gameEntitySpawnerEventType
	{
		Spawn = 2,
		Despawn = 3,
		Death = 4
	}

	public enum gameEntityStubClass : byte
	{
		Other = 0,
		Puppet = 1,
		Vehicle = 2
	}

	public enum gameEquipAnimationType
	{
		Default = 0,
		Instant = 1,
		FirstEquip = 2,
		HACK_ForceInstantEquip = 3
	}

	public enum gameEquipmentSetType
	{
		Offensive = 0,
		Defensive = 1,
		Cyberware = 2
	}

	public enum gameFearStage : byte
	{
		Relaxed = 0,
		Stressed = 1,
		Alarmed = 2,
		Panic = 3
	}

	public enum gameGameVersion
	{
		CP77_Initial = 0,
		CP77_Development = 1,
		CP77_GoldMaster = 2,
		CP77_ActualGoldMaster = 3,
		CP77_AlmostPatchDay0 = 4,
		CP77_PatchDay0 = 5,
		CP77_PatchDay0_Hotfix1 = 6,
		CP77_PatchDay0_Hotfix2 = 7,
		CP77_PatchDay0_Hotfix2_V2 = 8,
		CP77_PatchDay0_Hotfix3 = 9,
		CP77_PatchDay0_ChristmasHotfix = 10,
		CP77_PatchDay0_Hotfix4_Internal = 11,
		CP77_Patch_1_Internal = 12,
		CP77_Patch_1_1 = 1100,
		CP77_Patch_1_1_Hotfix1 = 1110,
		CP77_Patch_1_1_Hotfix2 = 1120,
		CP77_Patch_1_2 = 1200,
		CP77_Patch_1_2_Hotfix1 = 1210,
		CP77_Patch_1_2_Hotfix2 = 1220,
		CP77_Patch_1_2_Hotfix3 = 1230,
		CP77_Patch_1_2_Hotfix4_dlc1 = 1240,
		CP77_Patch_1_3 = 1300,
		CP77_Patch_1_3_Hotfix1 = 1301,
		CP77_Patch_1_3_Development = 1399,
		CP77_Patch_1_4 = 1310,
		CP77_Patch_1_5 = 1500,
		CP77_Patch_1_5_Hotfix1 = 1510,
		CP77_Patch_1_5_Actual_Hotfix1 = 1520,
		CP77_Patch_1_5_Development = 1599,
		CP77_Patch_1_6 = 1600,
		CP77_Patch_1_6_Hotfix1 = 1610,
		CP77_Patch_1_6_Hotfix2 = 1620,
		CP77_Patch_1_6_Hotfix3 = 1630,
		CP77_Patch_2_0 = 2000,
		CP77_Patch_2_0_Hotfix1 = 2010,
		CP77_Patch_2_0_Hotfix2 = 2020,
		CP77_Patch_2_1 = 2100,
		CP77_Patch_2_1_Hotfix1 = 2110,
		CP77_Patch_2_1_Hotfix2 = 2120,
		Current = 2120
	}

	public enum gameGameplayEventFlag
	{
		Ai = 1,
		Trigger = 2,
		Component = 4,
		Script = 8
	}

	public enum gameGlobalTierSubtype : byte
	{
		Quest = 0,
		Supervisor = 1
	}

	public enum gameGodModeType
	{
		Immortal = 1,
		Invulnerable = 0,
		Mortal = 2
	}

	public enum gameGrenadeThrowStartType
	{
		Invalid = 0,
		LeftSide = 1,
		RightSide = 2,
		Top = 3,
		Count = 4
	}

	public enum gameInitalChoiceStage
	{
		None = 0,
		Difficulty = 1,
		LifePath = 2,
		Gender = 3,
		Customizations = 4,
		Attributes = 5,
		Finished = 6
	}

	public enum gameInventoryItemAttachmentType
	{
		Generic = 0,
		Dedicated = 1
	}

	public enum gameInventoryItemShape : byte
	{
		SingleSlot = 0,
		DoubleSlot = 1
	}

	public enum gameItemComparisonState
	{
		Default = 0,
		NoChange = 1,
		Better = 2,
		Worse = 3
	}

	public enum gameItemDisplayContext
	{
		None = 0,
		Vendor = 1,
		Tooltip = 2,
		VendorPlayer = 3,
		GearPanel = 4,
		Backpack = 5,
		DPAD_RADIAL = 6,
		Attachment = 7,
		Ripperdoc = 8,
		Crafting = 9
	}

	public enum gameItemEquipContexts
	{
		LastWeaponEquipped = 0,
		LastUsedMeleeWeapon = 1,
		LastUsedRangedWeapon = 2,
		Gadget = 3,
		MeleeCyberware = 4,
		LauncherCyberware = 5,
		Fists = 6,
		TutorialCyberware = 7
	}

	public enum gameItemIconGender : byte
	{
		Female = 0,
		Male = 1
	}

	public enum gameItemUnequipContexts
	{
		AllWeapons = 0,
		HeadClothing = 1,
		FaceClothing = 2,
		OuterChestClothing = 3,
		InnerChestClothing = 4,
		LegClothing = 5,
		FootClothing = 6,
		AllClothing = 7,
		RightHandWeapon = 8,
		LeftHandWeapon = 9,
		AllQuestItems = 10,
		AllItems = 11
	}

	public enum gameJournalBriefingContentType
	{
		MapLocation = 0,
		VideoContent = 1,
		Paperdoll = 2
	}

	public enum gameJournalCallbackOption
	{
		DoNotFire = 0,
		Fire = 1
	}

	public enum gameJournalChangeType
	{
		Undefined = 0,
		Direct = 1,
		Indirect = 2,
		IndirectDependent = 3
	}

	public enum gameJournalEntryState
	{
		Undefined = 0,
		Inactive = 1,
		Active = 2,
		Succeeded = 3,
		Failed = 4
	}

	public enum gameJournalEntryUserState : byte
	{
		Undefined = 0,
		Inactive = 1,
		Active = 2,
		Succeeded = 3,
		Failed = 4,
		[RED("Read")] Read_ = 5,
		Open = 6
	}

	public enum gameJournalListenerType
	{
		State = 0,
		Visited = 1,
		Tracked = 2,
		Untracked = 3,
		Counter = 4,
		StateDelay = 5,
		ObjectiveOptional = 6,
		ChoiceEntry = 7
	}

	public enum gameJournalNotifyOption
	{
		Undefined = 0,
		DoNotNotify = 1,
		Notify = 2
	}

	public enum gameJournalQuestType
	{
		MainQuest = 0,
		SideQuest = 1,
		MinorQuest = 2,
		StreetStory = 3,
		CyberPsycho = 4,
		Contract = 5,
		VehicleQuest = 6,
		ApartmentQuest = 7,
		CourierQuest = 8,
		CourierSideQuest = 9
	}

	public enum gameKillType
	{
		Normal = 0,
		Defeat = 1
	}

	public enum gameLoSMode
	{
		Invalid = 0,
		Keep = 1,
		Avoid = 2
	}

	public enum gameLootItemType : byte
	{
		Default = 0,
		Quest = 1,
		Shard = 2
	}

	[Flags]
	public enum gameLootSlotState
	{
		Looted = 1 << 0,
		Unavailable = 1 << 1
	}

	public enum gameMessageSender
	{
		NPC = 0,
		Player = 1
	}

	public enum gameMountDescriptorMountType
	{
		Unmounted = 0,
		KeepState = 1,
		Vehicle = 3,
		MovingPlatform = 4
	}

	public enum gameMountingObjectSubType
	{
		Invalid = -1,
		Car = 0,
		Bike = 1
	}

	public enum gameMountingObjectType
	{
		Invalid = -1,
		Object = 0,
		Vehicle = 1,
		Puppet = 2,
		Platform = 3
	}

	public enum gameMountingRelationshipType
	{
		Invalid = -1,
		Parent = 0,
		Child = 1
	}

	public enum gameMountingSlotRole
	{
		Invalid = -1,
		Driver = 0,
		Passenger = 1,
		Passenger_FR = 2,
		Passenger_BL = 3,
		Passenger_BR = 4
	}

	public enum gameMovingPlatformLoopType
	{
		NoLooping = 0,
		Bounce = 1,
		Repeat = 2
	}

	public enum gameMovingPlatformMovementInitializationType
	{
		Time = 0,
		Speed = 1
	}

	public enum gameMuppetComparisonReportItemType
	{
		Different = 0,
		WithinTolerance = 1,
		Equal = 2
	}

	public enum gameMuppetDebugCommand
	{
		None = 0,
		Kill = 1,
		KillAll = 2
	}

	public enum gameMuppetInputActionType
	{
		Unknown = 0,
		Impulse = 1,
		Press = 2
	}

	public enum gameMuppetMoveStyle
	{
		Invalid = 0,
		Walk = 1,
		Sprint = 2,
		Crouch = 3,
		WalkAim = 4,
		GravityOnly = 5
	}

	public enum gameOnlineSystemErrors
	{
		None = 0,
		RequestFailed = 1,
		TemporaryFailure = 2,
		NoInternetConnection = 3,
		NotSignedInGalaxy = 4,
		NotSignedInLauncher = 5,
		NotSignedInGame = 6
	}

	public enum gameOnlineSystemStatus
	{
		Uninitialized = 0,
		GeneratingCPID = 1,
		CheckingRegistrationStatus = 2,
		RegistrationPending = 3,
		Registered = 4,
		Error = 5
	}

	public enum gamePSMBodyCarrying
	{
		Any = -1,
		Default = 0,
		PickUp = 1,
		Carry = 2,
		Dispose = 3,
		Drop = 4,
		Aim = 5,
		Throw = 6
	}

	public enum gamePSMBodyCarryingLocomotion
	{
		Default = 0,
		Jump = 1,
		Crouch = 2,
		Sprint = 3,
		Fall = 4,
		Land = 5,
		DropBody = 6
	}

	public enum gamePSMBodyCarryingStyle
	{
		Any = 0,
		Default = 1,
		Friendly = 2,
		Strong = 3,
		WoundedSoldier = 4
	}

	public enum gamePSMCombat
	{
		Any = -1,
		Default = 0,
		InCombat = 1,
		OutOfCombat = 2,
		Stealth = 3
	}

	public enum gamePSMCombatGadget
	{
		Default = 0,
		EquipRequest = 1,
		Equipped = 2,
		Charging = 3,
		Throwing = 4,
		WaitForUnequip = 5,
		QuickThrow = 6
	}

	public enum gamePSMCover
	{
		Any = -1,
		Default = 0,
		InCover = 1,
		Peek = 2,
		Lean = 3,
		OutOfCover = 4
	}

	public enum gamePSMCrosshairStates
	{
		Default = 0,
		Safe = 1,
		Scanning = 2,
		GrenadeCharging = 3,
		Aim = 4,
		Reload = 5,
		ReloadDriverCombatMountedWeapons = 6,
		Sprint = 7,
		HipFire = 8,
		LeftHandCyberware = 9,
		QuickHack = 10
	}

	public enum gamePSMDetailedBodyDisposal
	{
		Default = 0,
		Dispose = 1,
		Lethal = 2,
		NonLethal = 3
	}

	public enum gamePSMDetailedLocomotionStates
	{
		NotInBaseLocomotion = 0,
		Stand = 1,
		AimWalk = 2,
		Crouch = 3,
		Sprint = 4,
		Slide = 5,
		SlideFall = 6,
		Dodge = 7,
		Climb = 8,
		Vault = 9,
		Ladder = 10,
		LadderSprint = 11,
		LadderSlide = 12,
		LadderJump = 13,
		Fall = 14,
		AirThrusters = 15,
		AirHover = 16,
		SuperheroFall = 17,
		Jump = 18,
		DoubleJump = 19,
		ChargeJump = 20,
		HoverJump = 21,
		DodgeAir = 22,
		RegularLand = 23,
		HardLand = 24,
		VeryHardLand = 25,
		DeathLand = 26,
		SuperheroLand = 27,
		SuperheroLandRecovery = 28,
		Knockdown = 29,
		CrouchSprint = 30,
		Felled = 31
	}

	public enum gamePSMFallStates
	{
		Default = 0,
		RegularFall = 1,
		SafeFall = 2,
		FastFall = 3,
		VeryFastFall = 4,
		DeathFall = 5
	}

	public enum gamePSMHighLevel
	{
		Any = -1,
		Default = 0,
		SceneTier1 = 1,
		SceneTier2 = 2,
		SceneTier3 = 3,
		SceneTier4 = 4,
		SceneTier5 = 5,
		Swimming = 6
	}

	public enum gamePSMLandingState
	{
		Default = 0,
		RegularLand = 1,
		HardLand = 2,
		VeryHardLand = 3,
		DeathLand = 4,
		SuperheroLand = 5,
		SuperheroLandRecovery = 6
	}

	public enum gamePSMLeftHandCyberware
	{
		Default = 0,
		Safe = 1,
		EquipRequest = 2,
		Idle = 3,
		Equipped = 4,
		Charge = 5,
		Loop = 6,
		Catch = 7,
		QuickAction = 8,
		ChargeAction = 9,
		CatchAction = 10,
		StartUnequip = 11,
		Unequip = 12
	}

	public enum gamePSMLocomotionStates
	{
		Any = -1,
		Default = 0,
		Crouch = 1,
		Sprint = 2,
		Kereznikov = 3,
		Jump = 5,
		Vault = 6,
		Dodge = 7,
		DodgeAir = 8,
		Workspot = 9,
		Slide = 10,
		SlideFall = 11,
		CrouchSprint = 12,
		CrouchDodge = 13
	}

	public enum gamePSMMelee
	{
		Any = -1,
		Default = 0,
		Attack = 1,
		Block = 2
	}

	public enum gamePSMMeleeWeapon
	{
		NotReady = 0,
		Equipping = 1,
		Idle = 2,
		Safe = 3,
		PublicSafe = 4,
		Parried = 5,
		Hold = 6,
		ChargedHold = 7,
		Block = 8,
		Targeting = 9,
		Deflect = 10,
		ComboAttack = 11,
		FinalAttack = 12,
		StrongAttack = 13,
		SafeAttack = 14,
		BlockAttack = 15,
		SprintAttack = 16,
		CrouchAttack = 17,
		JumpAttack = 18,
		ThrowAttack = 19,
		DeflectAttack = 20,
		EquipAttack = 21,
		Default = 22
	}

	public enum gamePSMNanoWireLaunchMode
	{
		Default = 0,
		Primary = 1,
		Secondary = 2
	}

	public enum gamePSMRangedWeaponStates
	{
		Any = -1,
		Default = 0,
		Charging = 1,
		Reload = 2,
		QuickMelee = 3,
		NoAmmo = 4,
		Ready = 5,
		Safe = 6,
		Overheat = 7,
		Shoot = 8
	}

	public enum gamePSMReaction
	{
		Default = 0,
		Stagger = 1
	}

	public enum gamePSMStamina
	{
		Rested = 0,
		Fatigued = 1,
		Exhausted = 2
	}

	public enum gamePSMSwimming
	{
		Any = -1,
		Default = 0,
		Surface = 1,
		Diving = 2,
		Climbing = 3
	}

	public enum gamePSMTakedown
	{
		Any = -1,
		Default = 0,
		EnteringGrapple = 1,
		Grapple = 2,
		Leap = 3,
		Takedown = 4
	}

	public enum gamePSMTimeDilation
	{
		Any = -1,
		Default = 0,
		Sandevistan = 1
	}

	public enum gamePSMUIState
	{
		None = 0,
		WeaponSelect = 1
	}

	public enum gamePSMUpperBodyStates
	{
		Any = -1,
		Default = 0,
		SwitchItems = 1,
		SwitchCyberware = 2,
		Reload = 3,
		Aim = 6,
		TemporaryUnequip = 4,
		ForceEmptyHands = 5
	}

	public enum gamePSMVehicle
	{
		Any = -1,
		Default = 0,
		Driving = 1,
		Combat = 2,
		Passenger = 3,
		Transition = 4,
		Turret = 5,
		DriverCombat = 6,
		Scene = 7
	}

	public enum gamePSMVision
	{
		Any = -1,
		Default = 0,
		Focus = 1
	}

	public enum gamePSMVisionDebug
	{
		Default = 0,
		VisionToggle = 1
	}

	public enum gamePSMVitals
	{
		Alive = 0,
		Dead = 1,
		Resurrecting = 2
	}

	public enum gamePSMWeaponStates
	{
		Any = -1,
		Default = 0,
		NoAmmo = 1,
		Ready = 2,
		Safe = 3
	}

	public enum gamePSMWhip
	{
		Default = 0,
		Charging = 1,
		Pulling = 2
	}

	public enum gamePSMWorkspotState
	{
		Default = 0,
		Workspot = 1
	}

	public enum gamePSMZones
	{
		Any = -1,
		Default = 0,
		Public = 1,
		Safe = 2,
		Restricted = 3,
		Dangerous = 4
	}

	public enum gamePhantomEntityState
	{
		RootMotion = 0,
		Workspot = 1,
		MoveOnSpline = 2
	}

	public enum gamePlatformMovementState
	{
		Stopped = 0,
		Paused = 1,
		MovingUp = 2,
		MovingDown = 3
	}

	public enum gamePlayerCoverDirection
	{
		None = -1,
		Up = 0,
		Left = 1,
		Right = 2
	}

	public enum gamePlayerCoverMode
	{
		None = 0,
		Auto = 1,
		Manual = 2
	}

	public enum gamePlayerObstacleSystemQueryType
	{
		Climb_Vault = 0,
		Covers = 1,
		AverageNormal = 2
	}

	public enum gamePlayerStateMachine
	{
		Locomotion = 0,
		UpperBody = 1,
		Weapon = 2,
		HighLevel = 3,
		Projectile = 4,
		Vision = 5,
		TimeDilation = 6,
		CoverAction = 7,
		IconicItem = 8,
		Combat = 9,
		Vehicle = 10,
		Takedown = 11
	}

	public enum gamePopulationEntityPriority : byte
	{
		Quest = 0,
		Community = 1,
		Crowd = 2
	}

	public enum gamePopupPosition
	{
		Undefined = 0,
		UpperRight = 1,
		UpperLeft = 2,
		LowerLeft = 3,
		LowerRight = 4,
		Center = 5
	}

	public enum gamePuppetVehicleState
	{
		IdleMounted = 0,
		IdleStand = 1,
		CombatSeated = 3,
		CombatWindowed = 2,
		Turret = 4,
		GunnerSlot = 5
	}

	public enum gameQuestGuidanceMarkerPathfindingType
	{
		Auto = 0,
		Navmesh = 1,
		Traffic = 2
	}

	public enum gameRegular1v1FinisherScenarioPivotSetting : byte
	{
		AttackerSlidesAndRotates_TargetStandsStill = 0,
		AttackerStandsStill_TargetSlidesAndRotates = 1
	}

	public enum gameReprimandMappinAnimationState
	{
		None = 0,
		Normal = 1,
		Fast = 2
	}

	public enum gameSaveLockReason
	{
		Nothing = 0,
		Combat = 1,
		Scene = 2,
		Quest = 3,
		Script = 4,
		Boundary = 5,
		MainMenu = 6,
		LoadingScreen = 7,
		PlayerStateMachine = 8,
		PlayerState = 9,
		Tier = 10,
		NotEnoughSlots = 11,
		NotEnoughSpace = 12,
		PlayerOnMovingPlatform = 13
	}

	public enum gameScanningMode
	{
		Inactive = 0,
		Light = 1,
		Heavy = 2
	}

	public enum gameScanningState
	{
		Default = 0,
		Started = 1,
		Stopped = 2,
		Complete = 3,
		ShallowComplete = 4,
		Reset = 5
	}

	public enum gameSceneAnimationMotionActionParamsEasingType
	{
		Linear = 0,
		SinusoidalEaseInOut = 1,
		QuadraticEaseIn = 2,
		QuadraticEaseOut = 3,
		CubicEaseInOut = 4,
		CubicEaseIn = 5,
		CubicEaseOut = 6
	}

	public enum gameSceneAnimationMotionActionParamsMotionType
	{
		Rid = 0,
		Anim = 1
	}

	public enum gameSceneAnimationMotionActionParamsPlacementMode
	{
		Blend = 0,
		TeleportToStart = 1,
		PlayAtActorPosition = 2
	}

	public enum gameScriptTaskExecutionStage
	{
		Any = 0,
		PostPhysics = 1
	}

	public enum gameScriptedBlackboardStorage
	{
		Default = 0
	}

	public enum gameSharedInventoryTag
	{
		None = 0,
		PlayerStash = 1000000
	}

	public enum gameSimpleMessageType
	{
		Undefined = 0,
		Negative = 1,
		Neutral = 2,
		Vehicle = 3,
		Apartment = 4,
		Relic = 5,
		Money = 6,
		Reveal = 7,
		Boss = 8
	}

	public enum gameSmartObjectInstanceEntryType
	{
		UseEntryAnimation = 0,
		UseLocomotion = 1
	}

	public enum gameSmartObjectPointType
	{
		Entry = 0,
		Exit = 1,
		Action = 2
	}

	public enum gameSmartObjectType
	{
		Default = 0,
		LadderUp = 1,
		LadderDown = 2,
		JumpOnSameLevel = 3,
		Jump3mUp = 4,
		Jump3mDown = 5,
		Climb110cmUp = 6,
		Climb110cmDown = 7,
		Climb200cmUp = 8,
		Climb200cmDown = 9,
		Climb300cmUp = 10,
		Climb300cmDown = 11,
		Vault10cm = 12,
		Vault40cm = 13,
		Vault100cm = 14,
		ChargedJump400cmUp = 15,
		ChargedJump400cmDown = 16,
		ChargedJump600cmUp = 17,
		ChargedJump600cmDown = 18,
		ChargedJump800cmUp = 19,
		ChargedJump800cmDown = 20,
		ThrusterJumpUp = 21,
		ThrusterJumpDown = 22,
		Climb400cmDown = 23,
		Jump4mDown = 24,
		VaultJump7mDown = 25
	}

	public enum gameSpawnInViewState : byte
	{
		[RED("default (true)")] default__true_ = 0,
		[RED("true")] true_ = 1,
		[RED("false")] false_ = 2
	}

	public enum gameStatIDType
	{
		EntityID = 0,
		ItemID = 1,
		Invalid = 2
	}

	public enum gameStatModifierType
	{
		Additive = 0,
		AdditiveMultiplier = 1,
		Multiplier = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gameStatObjectsRelation
	{
		Self = 0,
		Owner = 1,
		Root = 2,
		Parent = 3,
		Target = 4,
		Player = 5,
		Instigator = 6,
		Count = 7,
		Invalid = 9
	}

	public enum gameStatPoolDataBonusType : byte
	{
		None = 0,
		Persistent = 1,
		NonPersistent = 2
	}

	public enum gameStatPoolDataStatPoolModificationStatus : byte
	{
		Regeneration = 0,
		Decay = 1,
		NoModification = 2
	}

	public enum gameStatPoolDataValueChangeMode : byte
	{
		Normal = 0,
		IncreasingOnly = 1,
		DecreasingOnly = 2,
		NonZero = 3
	}

	public enum gameStatPoolModificationTypes
	{
		Regeneration = 0,
		Decay = 1
	}

	public enum gameStatPoolModifierProperty
	{
		RangeBegin = 0,
		RangeEnd = 1,
		StartDelay = 2,
		ValuePerSec = 3,
		Enabled = 4,
		DelayOnChange = 5,
		Count = 6
	}

	public enum gameStatsBundleOwnerType
	{
		None = 0,
		Cleared = 1,
		UniqueItem = 2,
		StackableItem = 3,
		InnerItem = 4,
		Entity = 5,
		Stub = 6,
		Reinitialized = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gameStoryTier : byte
	{
		Gameplay = 0,
		Cinematic = 1
	}

	public enum gameStubMappinType : byte
	{
		None = 0,
		Police = 1,
		PoliceVehicle = 2,
		Vehicle = 3
	}

	public enum gameTStatModifier : byte
	{
		Constant = 0,
		Random = 1,
		Curve = 2,
		Combined = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gameTargetingSet
	{
		Visible = 0,
		ClearlyVisible = 1,
		Frustum = 2,
		Complete = 3,
		None = 4
	}

	public enum gameTelemetryDamageSituation
	{
		Irrelevant = 0,
		EnemyToPlayer = 1,
		EnemyToCompanion = 2,
		PlayerToEnemy = 3,
		CompanionToEnemy = 4,
		PlayerToPlayer = 5
	}

	public enum gameTelemetryHitDefenseType
	{
		Block = 0,
		Deflect = 1
	}

	public enum gameTelemetryMilestoneType
	{
		StartFact = 0,
		ImportantFact = 1,
		Reward = 2,
		EndFact = 4,
		EndReward = 3,
		Invalid = 5
	}

	public enum gameTelemetryMovementType
	{
		Jump = 0,
		DoubleJump = 1,
		ChargedJump = 2,
		Dodge = 3,
		AirDodge = 4
	}

	public enum gameTickableEventState
	{
		Idle = 0,
		FirstTick = 1,
		NormalTick = 2,
		LastTick = 3,
		Canceled = 4
	}

	public enum gameTransformAnimation_MoveOnSplineRotationMode
	{
		Disabled = 0,
		Yaw = 1,
		PitchAndYaw = 2
	}

	public enum gameTransformAnimation_RotateOnAxisAxis
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum gameTutorialBracketType
	{
		WidgetArea = 0,
		CustomArea = 1
	}

	public enum gameVehicleCommonCurve
	{
		RPMLimit = 0,
		ForcedBrakeForce = 1,
		COUNT = 2
	}

	public enum gameVehicleCurve
	{
		SpeedToWheelMaxTurn = 0,
		InputToWheelMaxTurn = 1,
		SpeedToWheelTurnSpeed = 2,
		InputToWheelTurnSpeed = 3,
		COUNT = 4
	}

	public enum gameVideoType : byte
	{
		Tutorial_720x405 = 0,
		Tutorial_1024x576 = 1,
		Tutorial_1280x720 = 2,
		Tutorial_1360x768 = 3,
		Unknown = 4
	}

	public enum gameVisionModePatternType
	{
		Default = 0,
		Netrunner = 1
	}

	public enum gameVisionModeType
	{
		Default = 0,
		Focus = 1
	}

	public enum gameWardrobeClothingSetIndex
	{
		Slot1 = 0,
		Slot2 = 1,
		Slot3 = 2,
		Slot4 = 3,
		Slot5 = 4,
		Slot6 = 5,
		Slot7 = 6,
		COUNT = 7,
		INVALID = 8
	}

	public enum gameWorkspotSlidingBehaviour
	{
		PlayAtResourcePosition = 1,
		DontPlayAtResourcePosition = 0,
		SlideActorAndRotateDevice = 2
	}

	public enum gameaudioeventsSurfaceDirection
	{
		Normal = 0,
		WallLeft = 1,
		WallRight = 2
	}

	public enum gamecheatsystemFlag
	{
		God_Immortal = 1,
		God_Invulnerable = 2,
		Resurrect = 4,
		IgnoreTimeDilation = 8,
		BypassMagazine = 16,
		InfiniteAmmo = 32,
		Kill = 64,
		Invisible = 128
	}

	public enum gamedataAIActionSecurityAreaType
	{
		DANGEROUS = 0,
		DISABLED = 1,
		RESTRICTED = 2,
		SAFE = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataAIActionSecurityNotificationType
	{
		COMBAT = 0,
		DEESCALATE = 1,
		DEFAULT = 2,
		ILLEGAL_ACTION = 3,
		REPRIMAND_ESCALATE = 4,
		REPRIMAND_SUCCESSFUL = 5,
		SECURITY_GATE = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataAIActionTarget
	{
		AssignedVehicle = 0,
		CombatTarget = 1,
		CommandCover = 2,
		CommandMovementDestination = 3,
		ConsideredCover = 4,
		CurrentCover = 5,
		CurrentNetrunnerProxy = 6,
		CustomWorldPosition = 7,
		DesiredCover = 8,
		FriendlyTarget = 9,
		FurthestNavigableSquadmate = 10,
		FurthestSquadmate = 11,
		FurthestThreat = 12,
		HostileOfficer = 13,
		In_LastKnownPosition = 14,
		MountedVehicle = 15,
		MovementDestination = 16,
		NearestDefeatedSquadmate = 17,
		NearestNavigableSquadmate = 18,
		NearestSquadmate = 19,
		NearestThreat = 20,
		NetrunnerProxy = 21,
		ObjectOfInterest = 22,
		Out_LastChasePosition = 23,
		Out_SearchPosition = 24,
		Owner = 25,
		Player = 26,
		PointOfInterest = 27,
		RingBackDestination = 28,
		RingBackLeftDestination = 29,
		RingBackRightDestination = 30,
		RingFrontDestination = 31,
		RingFrontLeftDestination = 32,
		RingFrontRightDestination = 33,
		RingLeftDestination = 34,
		RingRightDestination = 35,
		SelectedCover = 36,
		SpawnPosition = 37,
		SquadOfficer = 38,
		StimSource = 39,
		StimTarget = 40,
		TargetDevice = 41,
		TargetItem = 42,
		TeleportPosition = 43,
		TopFriendly = 44,
		TopThreat = 45,
		VisibleFurthestThreat = 46,
		VisibleNearestThreat = 47,
		VisibleTopThreat = 48,
		Count = 49,
		Invalid = 50
	}

	public enum gamedataAIActionType
	{
		BackUp = 0,
		BattleCry = 1,
		Block = 2,
		CallOff = 3,
		Charge = 4,
		Crouch = 5,
		Dash = 6,
		GrenadeThrow = 7,
		GroupReaction = 8,
		Investigate = 9,
		Melee = 10,
		Peek = 11,
		Quickhack = 12,
		Reprimand = 13,
		Search = 14,
		Shoot = 15,
		Sync = 16,
		TakeCover = 17,
		Takedown = 18,
		Taunt = 19,
		Count = 20,
		Invalid = 21
	}

	public enum gamedataAIAdditionalTraceType
	{
		Chest = 0,
		Hip = 1,
		Knee = 2,
		Undefined = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataAIComparison
	{
		Equal = 0,
		Greater = 1,
		GreaterOrEqual = 2,
		Less = 3,
		LessOrEqual = 4,
		NotEqual = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataAIDifficulty
	{
		Easy = 0,
		Hard = 1,
		Story = 2,
		VeryHard = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataAIDirectorEntryStartType
	{
		Default = 0,
		DespawnAllEnemies = 1,
		DespawnExcessedEnemies = 2,
		WaitUntilNoEnemies = 3,
		WaitUntilSameOrLessAmountOfEnemies = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataAIExposureMethodType
	{
		BlindFire = 0,
		Lean = 1,
		StepOut = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataAIRingType
	{
		Approach = 0,
		Close = 1,
		Default = 2,
		Defend = 3,
		Extreme = 4,
		Far = 5,
		LatestActive = 6,
		Medium = 7,
		Melee = 8,
		Support = 9,
		Undefined = 10,
		Count = 11,
		Invalid = 12
	}

	public enum gamedataAIRole
	{
		Follower = 0,
		Patrol = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataAISmartCompositeType
	{
		Selector = 0,
		SelectorWithMemory = 1,
		SelectorWithSmartMemory = 2,
		Sequence = 3,
		SequenceWithMemory = 4,
		SequenceWithSmartMemory = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataAISquadType
	{
		Attitude = 0,
		Community = 1,
		Global = 2,
		Security = 3,
		Unknown = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataAITacticType
	{
		Assault = 0,
		Defend = 1,
		Flank = 2,
		Medivac = 3,
		Panic = 4,
		Regroup = 5,
		Retreat = 6,
		Snipe = 7,
		Suppress = 8,
		Count = 9,
		Invalid = 10
	}

	public enum gamedataAIThreatPersistenceSource
	{
		AddThreat = 0,
		CatchUp = 1,
		CommandAimWithWeapon = 2,
		CommandForceShoot = 3,
		CommandInjectCombatTarget = 4,
		CommandInjectThreat = 5,
		CommandMeleeAttack = 6,
		CommandShoot = 7,
		CommandThrowGrenade = 8,
		Default = 9,
		QuickhackUpload = 10,
		SetNewCombatTarget = 11,
		TrackedBySecuritySystemAgent = 12,
		Count = 13,
		Invalid = 14
	}

	public enum gamedataAITicketType
	{
		AndroidMelee = 0,
		BackUp = 1,
		BattleCry = 2,
		Block = 3,
		CallOff = 4,
		CatchUp = 5,
		CatchUpToMeleePlayerOnHard = 6,
		CatchUpToMeleePlayerOnVeryHard = 7,
		Charge = 8,
		CloseRing = 9,
		CloseRing1stFilter = 10,
		CloseRing2ndFilter = 11,
		Crouch = 12,
		DefaultRing = 13,
		Dodge = 14,
		Equip = 15,
		EquipMelee = 16,
		ExtremeRing = 17,
		ExtremeRing1stFilter = 18,
		ExtremeRing2ndFilter = 19,
		FarRing = 20,
		FarRing1stFilter = 21,
		FarRing2ndFilter = 22,
		GoToCover = 23,
		GrenadeThrow = 24,
		GrenadeThrow_Hard = 25,
		GrenadeThrow_VeryHard = 26,
		GroupReaction = 27,
		Investigate = 28,
		MediumRing = 29,
		MediumRing1stFilter = 30,
		MediumRing2ndFilter = 31,
		Melee = 32,
		MeleeApproach = 33,
		MeleeRing = 34,
		MeleeRing1stFilter = 35,
		MeleeRing2ndFilter = 36,
		MeleeSupport = 37,
		OpticalCamo_Hard = 38,
		OpticalCamo_VeryHard = 39,
		Peek = 40,
		QuickMelee = 41,
		Quickhack = 42,
		Quickhack_Hard = 43,
		Quickhack_VeryHard = 44,
		Reload = 45,
		Reprimand = 46,
		Search = 47,
		Shoot = 48,
		SimpleCombat = 49,
		SimpleCombatMovement = 50,
		SmokeGrenadeThrow = 51,
		Strafe = 52,
		StrafeEvade = 53,
		Sync = 54,
		TakeCover = 55,
		Takedown = 56,
		Taunt = 57,
		TauntBackground = 58,
		Count = 59,
		Invalid = 60
	}

	public enum gamedataAchievement
	{
		AllThePresidentsMen = 0,
		Bladerunner = 1,
		BornToBeWild = 2,
		Breathtaking = 3,
		BushidoAndChill = 4,
		Cyberjunkie = 5,
		Denied = 6,
		DirtyWork = 7,
		DogtownLaw = 8,
		EasyComeEasyGo = 9,
		FollowingTheRiver = 10,
		Fortuneteller = 11,
		Gearhead = 12,
		GetMeThereScottie = 13,
		GunKata = 14,
		Gunslinger = 15,
		HandyMan = 16,
		HydraIsDead = 17,
		IAmMaxTac = 18,
		IHateSpider = 19,
		KingOfTheCups = 20,
		KingOfThePentacles = 21,
		KingOfTheSwords = 22,
		KingOfTheWands = 23,
		Kingmaker = 24,
		LikeFatherLikeSon = 25,
		LittleTokyo = 26,
		MasterRunner = 27,
		MaxPain = 28,
		MustBeTheRats = 29,
		NeverFadeAway = 30,
		NoMansLand = 31,
		NotTheMobile = 32,
		QueenOfTheHighway = 33,
		RelicMaster = 34,
		Roleplayer = 35,
		Specialist = 36,
		Temperance = 37,
		ThatIsSoHardForTheKnees = 38,
		TheDevil = 39,
		TheFool = 40,
		TheHermit = 41,
		TheHightPriestess = 42,
		TheLovers = 43,
		TheStar = 44,
		TheSun = 45,
		TheTower = 46,
		TheWheelOfFortune = 47,
		TheWorld = 48,
		ThisIsPacifica = 49,
		TradeUnion = 50,
		TrueSoldier = 51,
		TrueWarrior = 52,
		TwoHeadsOneBullet = 53,
		UnderPressure = 54,
		VForVendetta = 55,
		YipMan = 56,
		YouKnowWhoIAm = 57,
		Count = 58,
		Invalid = 59
	}

	public enum gamedataAffiliation
	{
		AfterlifeMercs = 0,
		Aldecaldos = 1,
		Animals = 2,
		Arasaka = 3,
		Barghest = 4,
		Biotechnica = 5,
		CityCouncil = 6,
		Civilian = 7,
		Classified = 8,
		KangTao = 9,
		Maelstrom = 10,
		MaelstromAndroid = 11,
		Militech = 12,
		NCPD = 13,
		NUSA = 14,
		NetWatch = 15,
		News54 = 16,
		OA = 17,
		RecordingAgency = 18,
		SSI = 19,
		Scavengers = 20,
		ScavengersAndroid = 21,
		SixthStreet = 22,
		SixthStreetAndroid = 23,
		SouthCalifornia = 24,
		TheMox = 25,
		TraumaTeam = 26,
		TygerClaws = 27,
		Unaffiliated = 28,
		UnaffiliatedCorpo = 29,
		Unknown = 30,
		Valentinos = 31,
		VoodooBoys = 32,
		Wraiths = 33,
		WraithsAndroid = 34,
		Zetatech = 35,
		corpbud = 36,
		crimson_harvest = 37,
		growl = 38,
		highriders = 39,
		private_press = 40,
		Count = 41,
		Invalid = 42
	}

	public enum gamedataAimAssistType
	{
		BreachTarget = 0,
		ChestTarget = 1,
		DriverCombat = 2,
		HeadTarget = 3,
		LegTarget = 4,
		MechanicalTarget = 5,
		Melee = 6,
		None = 7,
		QuickHack = 8,
		Scanning = 9,
		Shooting = 10,
		ShootingLimbCyber = 11,
		WeakSpotTarget = 12,
		Count = 13,
		Invalid = 14
	}

	public enum gamedataArchetypeType
	{
		AndroidMeleeT1 = 0,
		AndroidMeleeT2 = 1,
		AndroidRangedT2 = 2,
		FastMeleeT2 = 3,
		FastMeleeT3 = 4,
		FastRangedT2 = 5,
		FastRangedT3 = 6,
		FastShotgunnerT2 = 7,
		FastShotgunnerT3 = 8,
		FastSniperT3 = 9,
		FriendlyGenericRangedT3 = 10,
		GenericMeleeT1 = 11,
		GenericMeleeT2 = 12,
		GenericRangedT1 = 13,
		GenericRangedT2 = 14,
		GenericRangedT3 = 15,
		HeavyMeleeT2 = 16,
		HeavyMeleeT3 = 17,
		HeavyRangedT2 = 18,
		HeavyRangedT3 = 19,
		NetrunnerT1 = 20,
		NetrunnerT2 = 21,
		NetrunnerT3 = 22,
		ShotgunnerT2 = 23,
		ShotgunnerT3 = 24,
		SniperT2 = 25,
		TechieT2 = 26,
		TechieT3 = 27,
		Count = 28,
		Invalid = 29
	}

	public enum gamedataAttackSubtype
	{
		BlockAttack = 0,
		BodySlamAttack = 1,
		ComboAttack = 2,
		CrouchAttack = 3,
		DeflectAttack = 4,
		EquipAttack = 5,
		FinalAttack = 6,
		JumpAttack = 7,
		SafeAttack = 8,
		SprintAttack = 9,
		SpyTreeMeleewareAttack = 10,
		ThrowAttack = 11,
		Count = 12,
		Invalid = 13
	}

	public enum gamedataAttackType
	{
		ChargedWhipAttack = 0,
		Direct = 1,
		Effect = 2,
		Explosion = 3,
		ForceKill = 4,
		GuardBreak = 5,
		Hack = 6,
		Melee = 7,
		PressureWave = 8,
		QuickMelee = 9,
		Ranged = 10,
		Reflect = 11,
		StrongMelee = 12,
		Thrown = 13,
		WhipAttack = 14,
		Count = 15,
		Invalid = 16
	}

	public enum gamedataAttributeDataType
	{
		BodyAttributeData = 0,
		CoolAttributeData = 1,
		EspionageAttributeData = 2,
		IntelligenceAttributeData = 3,
		ReflexesAttributeData = 4,
		TechnicalAbilityAttributeData = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataBuildType
	{
		Avg_10_Int_Netrunner = 0,
		Body40 = 1,
		CherryHybrid30 = 2,
		CherryHybrid50 = 3,
		CorporateStarting = 4,
		E32019NetrunnerPhase1 = 5,
		E32019StrongSoloPhase1 = 6,
		EP1_Standalone_Corpo_MA_StartingBuild = 7,
		EP1_Standalone_Corpo_WA_StartingBuild = 8,
		EP1_Standalone_Nomad_MA_StartingBuild = 9,
		EP1_Standalone_Nomad_WA_StartingBuild = 10,
		EP1_Standalone_StartingBuild = 11,
		EP1_Standalone_Street_MA_StartingBuild = 12,
		EP1_Standalone_Street_WA_StartingBuild = 13,
		FunctionalTestsProgressionBuildTest = 14,
		FunctionalTestsStartingBuild = 15,
		GYMcclBuild = 16,
		GymSmoketestMaxedBuild = 17,
		HandsOnStarting = 18,
		Hard_20_Body = 19,
		Hard_20_Intelligence = 20,
		Hard_20_Reflex = 21,
		Hard_30_BodyTech = 22,
		Hard_30_IntBody = 23,
		Hard_30_Reflex = 24,
		JohnnyQ101 = 25,
		JohnnyQ108 = 26,
		JohnnyQ204 = 27,
		KurtMQ301Delivery = 28,
		KurtMQ301Initiation = 29,
		MaxSkillsAllWeapons = 30,
		MaxStealthHacker = 31,
		NomadStarting = 32,
		Normal_20_Melee = 33,
		Normal_20_Netrunner = 34,
		Normal_20_Ranged = 35,
		Reflex40 = 36,
		SmartRunner40 = 37,
		StartingBuild = 38,
		Story_15 = 39,
		Story_25 = 40,
		Story_5 = 41,
		Str_10_Tank = 42,
		Str_30_Cool_Assassin = 43,
		Str_5_Tank = 44,
		StreetKidStarting = 45,
		UIStressTest = 46,
		VHard_50_BodyCool = 47,
		VHard_50_CoolRef = 48,
		VHard_50_IntRef = 49,
		VHard_50_IntTech = 50,
		VHard_50_RefBody = 51,
		VHard_50_RefTech = 52,
		VHard_50_TechCool = 53,
		Weak_10 = 54,
		Weak_20_Cool = 55,
		Weak_30 = 56,
		CpoAssassinBuild = 57,
		CpoDefaultBuild = 58,
		CpoNetrunnerBuild = 59,
		CpoSoloBuild = 60,
		CpoTechieBuild = 61,
		Count = 62,
		Invalid = 63
	}

	public enum gamedataChargeStep
	{
		Idle = 0,
		Charging = 1,
		Charged = 2,
		Overcharging = 3,
		Discharging = 4
	}

	public enum gamedataCheckType
	{
		Category = 0,
		Evolution = 1,
		FullyModded = 2,
		None = 3,
		Record = 4,
		Tag = 5,
		Type = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataChoiceCaptionPartType
	{
		Blueline = 0,
		Icon = 1,
		QuickhackCost = 2,
		Tag = 3,
		Text = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataCompanionDistancePreset
	{
		Close = 0,
		Far = 1,
		Medium = 2,
		VeryFar = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataComputerUIStyle
	{
		DarkBlue = 0,
		LightBlue = 1,
		Orange = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataConsumableBaseName
	{
		Alcohol = 0,
		BonesMcCoy70 = 1,
		CarryCapacityBooster = 2,
		Drinkable = 3,
		Edible = 4,
		FirstAidWhiff = 5,
		HealthBooster = 6,
		MemoryBooster = 7,
		OxyBooster = 8,
		StaminaBooster = 9,
		Count = 10,
		Invalid = 11
	}

	public enum gamedataConsumableType
	{
		Drug = 0,
		Medical = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataContainerType
	{
		AmmoCase = 0,
		Body = 1,
		ClothingContainer = 2,
		ComponentContainer = 3,
		ConsumableContainer = 4,
		GadgetCase = 5,
		Misc = 6,
		QuestContainer = 7,
		Safe = 8,
		ShardCaseContainer = 9,
		ValuableCrate = 10,
		WeaponContainer = 11,
		Count = 12,
		Invalid = 13
	}

	public enum gamedataDamageType
	{
		Chemical = 0,
		Electric = 1,
		Physical = 2,
		Thermal = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataDataNodeType
	{
		File = 0,
		Group = 1,
		Variable = 2,
		Value = 3,
		SimpleValue = 4,
		ComplexValue = 5
	}

	public enum gamedataDefenseMode
	{
		DefendAll = 0,
		DefendMelee = 1,
		DefendRanged = 2,
		NoDefend = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataDevelopmentPointType
	{
		Attribute = 0,
		Espionage = 1,
		Primary = 2,
		Secondary = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataDeviceHackCategory
	{
		ControlHack = 0,
		CovertHack = 1,
		DamageHack = 2,
		VehicleHack = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataDeviceHackTier
	{
		Tier1DeviceHack = 0,
		Tier2DeviceHack = 1,
		Tier3DeviceHack = 2,
		Tier4DeviceHack = 3,
		Tier5DeviceHack = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataDistrict
	{
		ArasakaWaterfront = 0,
		ArasakaWaterfront_AbandonedWarehouse = 1,
		ArasakaWaterfront_KonpekiPlaza = 2,
		Arroyo = 3,
		Arroyo_Arasaka_Warehouse = 4,
		Arroyo_ClairesGarage = 5,
		Arroyo_CytechFactory = 6,
		Arroyo_Kendachi = 7,
		Arroyo_KenmoreCafe = 8,
		Arroyo_LasPalapas = 9,
		Arroyo_Red_Dirt = 10,
		Arroyo_TireEmpire = 11,
		Badlands = 12,
		Badlands_BiotechnicaFlats = 13,
		Badlands_DryCreek = 14,
		Badlands_JacksonPlains = 15,
		Badlands_LagunaBend = 16,
		Badlands_LasPalapas = 17,
		Badlands_NorthSunriseOilField = 18,
		Badlands_RattlesnakeCreek = 19,
		Badlands_RedPeaks = 20,
		Badlands_RockyRidge = 21,
		Badlands_SantaClara = 22,
		Badlands_SierraSonora = 23,
		Badlands_SoCalBorderCrossing = 24,
		Badlands_Spaceport = 25,
		Badlands_VasquezPass = 26,
		Badlands_Yucca = 27,
		Badlands_YuccaGarage = 28,
		Badlands_YuccaRadioTower = 29,
		CharterHill = 30,
		CharterHill_AuCabanon = 31,
		CharterHill_PowerPlant = 32,
		CityCenter = 33,
		Coastview = 34,
		Coastview_BattysHotel = 35,
		Coastview_ButcherShop = 36,
		Coastview_GrandImperialMall = 37,
		Coastview_RundownApartment = 38,
		Coastview_VDBChapel = 39,
		Coastview_VDBMaglev = 40,
		Coastview_q110Cyberspace = 41,
		CorpoPlaza = 42,
		CorpoPlaza_Apartment = 43,
		CorpoPlaza_ArasakaTowerAtrium = 44,
		CorpoPlaza_ArasakaTowerCEOFloor = 45,
		CorpoPlaza_ArasakaTowerJenkins = 46,
		CorpoPlaza_ArasakaTowerJungle = 47,
		CorpoPlaza_ArasakaTowerLobby = 48,
		CorpoPlaza_ArasakaTowerNest = 49,
		CorpoPlaza_ArasakaTowerSaburoOffice = 50,
		CorpoPlaza_ArasakaTowerUnlistedFloors = 51,
		CorpoPlaza_ArasakaTowerUpperAtrium = 52,
		CorpoPlaza_q201Cyberspace = 53,
		Dogtown = 54,
		Dogtown_Akebono = 55,
		Dogtown_Brooklyn = 56,
		Dogtown_CapitanCaliente = 57,
		Dogtown_Cynosure = 58,
		Dogtown_Expo = 59,
		Dogtown_Hideout = 60,
		Dogtown_Worldmap_Sub = 61,
		Downtown = 62,
		Downtown_Jinguji = 63,
		Downtown_TheHammer = 64,
		Glen = 65,
		Glen_Apartment = 66,
		Glen_Embers = 67,
		Glen_MusicStore = 68,
		Glen_NCPDLab = 69,
		Glen_WichedTires = 70,
		Heywood = 71,
		JapanTown = 72,
		JapanTown_Apartment = 73,
		JapanTown_Clouds = 74,
		JapanTown_DarkMatter = 75,
		JapanTown_Fingers = 76,
		JapanTown_FourthWallBdStudio = 77,
		JapanTown_HiromisApartment = 78,
		JapanTown_MegabuildingH8 = 79,
		JapanTown_VR_Tutorial = 80,
		JapanTown_Wakakos_Pachinko_Parlor = 81,
		Kabuki = 82,
		Kabuki_JudysApartment = 83,
		Kabuki_LizziesBar = 84,
		Kabuki_NoTellMotel = 85,
		LagunaBend_LakeHut = 86,
		Langley_Clinic = 87,
		LittleChina = 88,
		LittleChina_Afterlife = 89,
		LittleChina_MistysShop = 90,
		LittleChina_Q101Cyberspace = 91,
		LittleChina_RiotClub = 92,
		LittleChina_TomsDiner = 93,
		LittleChina_VApartment = 94,
		LittleChina_VictorsClinic = 95,
		MorroRock = 96,
		MorroRock_NCX = 97,
		NorthBadlands = 98,
		NorthOaks = 99,
		NorthOaks_Arasaka_Estate = 100,
		NorthOaks_Columbarium = 101,
		NorthOaks_Denny_Estate = 102,
		NorthOaks_Kerry_Estate = 103,
		Northside = 104,
		Northside_All_Foods = 105,
		Northside_Apartment = 106,
		Northside_CleanCut = 107,
		Northside_Totentaz = 108,
		Northside_WNS = 109,
		Pacifica = 110,
		RanchoCoronado = 111,
		RanchoCoronado_Caliente = 112,
		RanchoCoronado_GunORama = 113,
		RanchoCoronado_Piez = 114,
		RanchoCoronado_Softsys = 115,
		RanchoCoronado_Stylishly = 116,
		SantoDomingo = 117,
		SouthBadlands = 118,
		SouthBadlands_EdgewoodFarm = 119,
		SouthBadlands_PoppyFarm = 120,
		SouthBadlands_TrailerPark = 121,
		SouthBadlands_q201SpaceStation = 122,
		VistaDelRey = 123,
		Vista_del_Rey_Delamain = 124,
		Vista_del_Rey_LaCatrina = 125,
		Vista_del_rey_Abandoned_Apartment_Building = 126,
		Vista_del_rey_ElCoyoteCojo = 127,
		Watson = 128,
		Wellsprings = 129,
		WestWindEstate = 130,
		Westbrook = 131,
		Count = 132,
		Invalid = 133
	}

	public enum gamedataDriverCombatType
	{
		CrystalDome = 0,
		Disabled = 1,
		Doors = 2,
		MountedWeapons = 3,
		Standard = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataEffectorTimeDilationDriver
	{
		Source = 0,
		Target = 1,
		World = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataEquipmentArea
	{
		AbilityCW = 0,
		ArmsCW = 1,
		BaseFists = 2,
		BotCPU = 3,
		BotChassisModule = 4,
		BotMainModule = 5,
		BotSoftware = 6,
		CardiovascularSystemCW = 7,
		Consumable = 8,
		CyberwareWheel = 9,
		EyesCW = 10,
		Face = 11,
		FaceCW = 12,
		Feet = 13,
		FrontalCortexCW = 14,
		Gadget = 15,
		HandsCW = 16,
		Head = 17,
		ImmuneSystemCW = 18,
		InnerChest = 19,
		IntegumentarySystemCW = 20,
		LeftArm = 21,
		Legs = 22,
		LegsCW = 23,
		MusculoskeletalSystemCW = 24,
		NervousSystemCW = 25,
		OuterChest = 26,
		Outfit = 27,
		PersonalLink = 28,
		PlayerTattoo = 29,
		Quest = 30,
		QuickSlot = 31,
		QuickWheel = 32,
		RightArm = 33,
		SilverhandArm = 34,
		Splinter = 35,
		SystemReplacementCW = 36,
		UnderwearBottom = 37,
		UnderwearTop = 38,
		VDefaultHandgun = 39,
		Weapon = 40,
		WeaponHeavy = 41,
		WeaponLeft = 42,
		WeaponWheel = 43,
		Count = 44,
		Invalid = 45
	}

	public enum gamedataEthnicity
	{
		African = 0,
		AfricanAmerican = 1,
		AmericanEnglish = 2,
		Arabic = 3,
		Brasilian = 4,
		BritishEnglish = 5,
		Caribbean = 6,
		Chinese = 7,
		Default = 8,
		Indian = 9,
		Japanese = 10,
		Mexican = 11,
		NativeAmerican = 12,
		Russian = 13,
		Count = 14,
		Invalid = 15
	}

	public enum gamedataFxAction
	{
		EnterCharge = 0,
		EnterDischarge = 1,
		EnterLowAmmo = 2,
		EnterNoAmmo = 3,
		EnterOverheat = 4,
		EnterReload = 5,
		ExitCharge = 6,
		ExitDischarge = 7,
		ExitLowAmmo = 8,
		ExitNoAmmo = 9,
		ExitOverheat = 10,
		ExitReload = 11,
		ExitShoot = 12,
		MeleeBlock = 13,
		MeleeHit = 14,
		MuzzleBrakeShoot = 15,
		Shoot = 16,
		SilencedShoot = 17,
		Count = 18,
		Invalid = 19
	}

	public enum gamedataFxActionType
	{
		BreakLoop = 0,
		Kill = 1,
		Start = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataGender
	{
		Default = 0,
		Female = 1,
		Male = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataGrenadeDeliveryMethodType
	{
		Homing = 0,
		Regular = 1,
		Sticky = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataGroupNodeGroupVariableDeriveInfo : byte
	{
		FullyDerived = 0,
		TypeDerived = 1,
		ValueChanged = 2,
		NotDerived = 3
	}

	public enum gamedataGroupNodeInheritanceState
	{
		Unresolved = 0,
		Resolving = 1,
		Resolved = 2
	}

	public enum gamedataHackCategory
	{
		BreachingHack = 0,
		ControlHack = 1,
		CovertHack = 2,
		DamageHack = 3,
		DeviceHack = 4,
		NotAHack = 5,
		UltimateHack = 6,
		VehicleHack = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gamedataHitPrereqConditionType
	{
		AgentMoving = 0,
		AmmoState = 1,
		AttackSubType = 2,
		AttackTag = 3,
		AttackType = 4,
		BodyPart = 5,
		ConsecutiveHits = 6,
		DamageOverTimeType = 7,
		DamageType = 8,
		DismembermentTriggered = 9,
		DistanceCovered = 10,
		EffectNamePresent = 11,
		HitFlag = 12,
		HitIsQuickhackPresentInQueue = 13,
		InstigatorType = 14,
		ReactionPreset = 15,
		SameTarget = 16,
		SelfHit = 17,
		SourceType = 18,
		Stat = 19,
		StatComparison = 20,
		StatPool = 21,
		StatPoolComparison = 22,
		StatusEffectPresent = 23,
		TargetBreachCanGetKilledByDamage = 24,
		TargetCanGetKilledByDamage = 25,
		TargetIsCrowd = 26,
		TargetKilled = 27,
		TargetNPCRarity = 28,
		TargetNPCType = 29,
		TargetType = 30,
		TriggerMode = 31,
		WeaponEvolution = 32,
		WeaponItemType = 33,
		WeaponType = 34,
		WoundedTriggered = 35,
		Count = 36,
		Invalid = 37
	}

	public enum gamedataImprovementRelation
	{
		Direct = 0,
		Inverse = 1,
		None = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataIsHackable
	{
		Always = 0,
		Dynamic = 1,
		Never = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataItemCategory
	{
		Clothing = 0,
		Consumable = 1,
		Cyberware = 2,
		Gadget = 3,
		General = 4,
		Part = 5,
		Weapon = 6,
		WeaponMod = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gamedataItemStructure
	{
		BlueprintStackable = 0,
		Stackable = 1,
		Unique = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataItemType
	{
		Clo_Face = 0,
		Clo_Feet = 1,
		Clo_Head = 2,
		Clo_InnerChest = 3,
		Clo_Legs = 4,
		Clo_OuterChest = 5,
		Clo_Outfit = 6,
		Con_Ammo = 7,
		Con_Edible = 8,
		Con_Inhaler = 9,
		Con_Injector = 10,
		Con_LongLasting = 11,
		Con_Skillbook = 12,
		Cyb_Ability = 13,
		Cyb_HealingAbility = 14,
		Cyb_Launcher = 15,
		Cyb_MantisBlades = 16,
		Cyb_NanoWires = 17,
		Cyb_StrongArms = 18,
		Cyberware = 19,
		CyberwareStatsShard = 20,
		CyberwareUpgradeShard = 21,
		Fla_Launcher = 22,
		Fla_Rifle = 23,
		Fla_Shock = 24,
		Fla_Support = 25,
		Gad_Grenade = 26,
		Gen_CraftingMaterial = 27,
		Gen_DataBank = 28,
		Gen_Jewellery = 29,
		Gen_Junk = 30,
		Gen_Keycard = 31,
		Gen_Misc = 32,
		Gen_MoneyShard = 33,
		Gen_Readable = 34,
		Gen_Tarot = 35,
		GrenadeDelivery = 36,
		Grenade_Core = 37,
		Prt_AR_SMG_LMGMod = 38,
		Prt_BladeMod = 39,
		Prt_BluntMod = 40,
		Prt_BootsFabricEnhancer = 41,
		Prt_Capacitor = 42,
		Prt_FabricEnhancer = 43,
		Prt_FaceFabricEnhancer = 44,
		Prt_Fragment = 45,
		Prt_HandgunMod = 46,
		Prt_HandgunMuzzle = 47,
		Prt_HeadFabricEnhancer = 48,
		Prt_LongScope = 49,
		Prt_Magazine = 50,
		Prt_MeleeMod = 51,
		Prt_Mod = 52,
		Prt_Muzzle = 53,
		Prt_OuterTorsoFabricEnhancer = 54,
		Prt_PantsFabricEnhancer = 55,
		Prt_PowerMod = 56,
		Prt_PowerSniperScope = 57,
		Prt_Precision_Sniper_RifleMod = 58,
		Prt_Program = 59,
		Prt_RangedMod = 60,
		Prt_Receiver = 61,
		Prt_RifleMuzzle = 62,
		Prt_Scope = 63,
		Prt_ScopeRail = 64,
		Prt_ShortScope = 65,
		Prt_ShotgunMod = 66,
		Prt_SmartMod = 67,
		Prt_Stock = 68,
		Prt_TargetingSystem = 69,
		Prt_TechMod = 70,
		Prt_TechSniperScope = 71,
		Prt_ThrowableMod = 72,
		Prt_TorsoFabricEnhancer = 73,
		VendorToken = 74,
		Wea_AssaultRifle = 75,
		Wea_Axe = 76,
		Wea_Chainsword = 77,
		Wea_Fists = 78,
		Wea_GrenadeLauncher = 79,
		Wea_Hammer = 80,
		Wea_Handgun = 81,
		Wea_HeavyMachineGun = 82,
		Wea_Katana = 83,
		Wea_Knife = 84,
		Wea_LightMachineGun = 85,
		Wea_LongBlade = 86,
		Wea_Machete = 87,
		Wea_Melee = 88,
		Wea_OneHandedClub = 89,
		Wea_PrecisionRifle = 90,
		Wea_Revolver = 91,
		Wea_Rifle = 92,
		Wea_ShortBlade = 93,
		Wea_Shotgun = 94,
		Wea_ShotgunDual = 95,
		Wea_SniperRifle = 96,
		Wea_SubmachineGun = 97,
		Wea_Sword = 98,
		Wea_TwoHandedClub = 99,
		Wea_VehicleMissileLauncher = 100,
		Wea_VehiclePowerWeapon = 101,
		Count = 102,
		Invalid = 103
	}

	public enum gamedataLifePath
	{
		Corporate = 0,
		Nomad = 1,
		StreetKid = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataLocomotionMode
	{
		Moving = 0,
		Static = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataMappinPhase
	{
		CompletedPhase = 0,
		DefaultPhase = 1,
		DiscoveredPhase = 2,
		UndiscoveredPhase = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataMappinVariant
	{
		ActionDealDamageVariant = 0,
		ActionFastSoloVariant = 1,
		ActionGenericInteractionVariant = 2,
		ActionNetrunnerAccessPointVariant = 3,
		ActionNetrunnerVariant = 4,
		ActionScanVariant = 5,
		ActionSoloVariant = 6,
		ActionTechieVariant = 7,
		AimVariant = 8,
		AllowVariant = 9,
		ApartmentVariant = 10,
		ArrowVariant = 11,
		BackOutVariant = 12,
		BountyHuntVariant = 13,
		CallVariant = 14,
		ChangeToFriendlyVariant = 15,
		ClientInDistressVariant = 16,
		ConversationVariant = 17,
		ConvoyVariant = 18,
		CoolVariant = 19,
		CourierVariant = 20,
		CustomPositionVariant = 21,
		CyberspaceNPC = 22,
		CyberspaceObject = 23,
		DefaultInteractionVariant = 24,
		DefaultQuestVariant = 25,
		DefaultVariant = 26,
		DistractVariant = 27,
		DropboxVariant = 28,
		DynamicEventVariant = 29,
		EffectAlarmVariant = 30,
		EffectControlNetworkVariant = 31,
		EffectControlOtherDeviceVariant = 32,
		EffectControlSelfVariant = 33,
		EffectCutPowerVariant = 34,
		EffectDistractVariant = 35,
		EffectDropPointVariant = 36,
		EffectExplodeLethalVariant = 37,
		EffectExplodeNonLethalVariant = 38,
		EffectFallVariant = 39,
		EffectGrantInformationVariant = 40,
		EffectHideBodyVariant = 41,
		EffectLootVariant = 42,
		EffectOpenPathVariant = 43,
		EffectPushVariant = 44,
		EffectServicePointVariant = 45,
		EffectShootVariant = 46,
		EffectSpreadGasVariant = 47,
		EffectStoreItemsVariant = 48,
		ExclamationMarkVariant = 49,
		FailedCrossingVariant = 50,
		FastTravelVariant = 51,
		FixerVariant = 52,
		FocusClueVariant = 53,
		GPSForcedPathVariant = 54,
		GPSPortalVariant = 55,
		GangWatchVariant = 56,
		GenericRoleVariant = 57,
		GetInVariant = 58,
		GetUpVariant = 59,
		GrenadeVariant = 60,
		GunSuicideVariant = 61,
		HandVariant = 62,
		HazardWarningVariant = 63,
		HiddenStashVariant = 64,
		HitVariant = 65,
		HuntForPsychoVariant = 66,
		ImportantInteractionVariant = 67,
		InvalidVariant = 68,
		JackInVariant = 69,
		JamWeaponVariant = 70,
		LifepathCorpoVariant = 71,
		LifepathNomadVariant = 72,
		LifepathStreetKidVariant = 73,
		LootVariant = 74,
		MinorActivityVariant = 75,
		NPCVariant = 76,
		NetrunnerAccessPointVariant = 77,
		NetrunnerSoloTechieVariant = 78,
		NetrunnerSoloVariant = 79,
		NetrunnerTechieVariant = 80,
		NetrunnerVariant = 81,
		NonLethalTakedownVariant = 82,
		OffVariant = 83,
		OpenVendorVariant = 84,
		OutpostVariant = 85,
		PhoneCallVariant = 86,
		QuestGiverVariant = 87,
		QuestionMarkVariant = 88,
		QuickHackVariant = 89,
		ReflexesVariant = 90,
		ResourceVariant = 91,
		RetrievingVariant = 92,
		SOSsignalVariant = 93,
		SabotageVariant = 94,
		ServicePointBarVariant = 95,
		ServicePointClothesVariant = 96,
		ServicePointCyberwareVariant = 97,
		ServicePointDropPointVariant = 98,
		ServicePointFoodVariant = 99,
		ServicePointGunsVariant = 100,
		ServicePointJunkVariant = 101,
		ServicePointMedsVariant = 102,
		ServicePointMeleeTrainerVariant = 103,
		ServicePointNetTrainerVariant = 104,
		ServicePointProstituteVariant = 105,
		ServicePointRipperdocVariant = 106,
		ServicePointTechVariant = 107,
		SitVariant = 108,
		SmugglersDenVariant = 109,
		SoloTechieVariant = 110,
		SoloVariant = 111,
		SpeechVariant = 112,
		TakeControlVariant = 113,
		TakeDownVariant = 114,
		TarotVariant = 115,
		TechieVariant = 116,
		ThieveryVariant = 117,
		UseVariant = 118,
		VehicleVariant = 119,
		WanderingMerchantVariant = 120,
		Zzz01_CarForPurchaseVariant = 121,
		Zzz02_MotorcycleForPurchaseVariant = 122,
		Zzz03_MotorcycleVariant = 123,
		Zzz04_PreventionVehicleVariant = 124,
		Zzz05_ApartmentToPurchaseVariant = 125,
		Zzz06_NCPDGigVariant = 126,
		Zzz07_PlayerStashVariant = 127,
		Zzz08_WardrobeVariant = 128,
		Zzz09_CourierSandboxActivityVariant = 129,
		Zzz10_RemoteControlDrivingVariant = 130,
		Zzz11_RoadBlockadeVariant = 131,
		Zzz12_QuickHackQueueVariant = 132,
		Zzz12_WorldEncounterVariant = 133,
		Zzz13_DogtownGateVariant = 134,
		Zzz14_ServicePointBlackMarketVariant = 135,
		Zzz15_QuickHackDurationVariant = 136,
		Zzz16_RelicDeviceBasicVariant = 137,
		Zzz16_RelicDeviceSpecialVariant = 138,
		Zzz17_NCARTVariant = 139,
		Zzz18_RacingVariant = 140,
		CPO_PingDoorVariant = 141,
		CPO_PingGoHereVariant = 142,
		CPO_PingLootVariant = 143,
		CPO_RemotePlayerVariant = 144,
		Count = 145,
		Invalid = 146
	}

	public enum gamedataMeleeAttackDirection
	{
		Center = 0,
		DownToUp = 1,
		LeftDownToRightUp = 2,
		LeftToRight = 3,
		LeftUpToRightDown = 4,
		RightDownToLeftUp = 5,
		RightToLeft = 6,
		RightUpToLeftDown = 7,
		UpToDown = 8,
		Count = 9,
		Invalid = 10
	}

	public enum gamedataMetaQuest
	{
		MetaQuest1 = 0,
		MetaQuest2 = 1,
		MetaQuest3 = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataMinigameActionType
	{
		AccessPoint = 0,
		Both = 1,
		Device = 2,
		NPC = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataMinigameCategory
	{
		CameraAccess = 0,
		CyberwareAccess = 1,
		DataAccess = 2,
		DefenseSystemAccess = 3,
		NeuralAccess = 4,
		SecurityAccess = 5,
		Trojan = 6,
		TurretAccess = 7,
		WeaponAccess = 8,
		Count = 9,
		Invalid = 10
	}

	public enum gamedataMinigameTrapType
	{
		Both = 0,
		Device = 1,
		NPC = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataMovementType
	{
		Run = 0,
		Sprint = 1,
		Strafe = 2,
		Walk = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataNPCBehaviorState
	{
		State1 = 0,
		State2 = 1,
		State3 = 2,
		State4 = 3,
		State5 = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataNPCHighLevelState
	{
		Alerted = 0,
		Any = 1,
		Combat = 2,
		Dead = 3,
		Fear = 4,
		Relaxed = 5,
		Stealth = 6,
		Unconscious = 7,
		Wounded = 8,
		Count = 9,
		Invalid = 10
	}

	public enum gamedataNPCQuestAffiliation
	{
		General = 0,
		MainQuest = 1,
		MinorActivity = 2,
		MinorQuest = 3,
		SideQuest = 4,
		StreetStory = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataNPCRarity
	{
		Boss = 0,
		Elite = 1,
		MaxTac = 2,
		Normal = 3,
		Officer = 4,
		Rare = 5,
		Trash = 6,
		Weak = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gamedataNPCStanceState
	{
		Any = 0,
		Cover = 1,
		Crouch = 2,
		Stand = 3,
		Swim = 4,
		Vehicle = 5,
		VehicleWindow = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataNPCType
	{
		Android = 0,
		Any = 1,
		Cerberus = 2,
		Chimera = 3,
		Device = 4,
		Drone = 5,
		Human = 6,
		Mech = 7,
		Spiderbot = 8,
		Count = 9,
		Invalid = 10
	}

	public enum gamedataNPCUpperBodyState
	{
		Aim = 0,
		Any = 1,
		Attack = 2,
		ChargedAttack = 3,
		Defend = 4,
		Equip = 5,
		Normal = 6,
		Parry = 7,
		Reload = 8,
		Shoot = 9,
		Taunt = 10,
		Count = 11,
		Invalid = 12
	}

	public enum gamedataNewPerkCategoryType
	{
		MasterNewPerkCategory = 0,
		MilestoneNewPerkCategory = 1,
		SimpleNewPerkCategory = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataNewPerkSlotType
	{
		Central_Milestone_1 = 0,
		Central_Milestone_2 = 1,
		Central_Milestone_3 = 2,
		Central_Perk_1_1 = 3,
		Central_Perk_1_2 = 4,
		Central_Perk_1_3 = 5,
		Central_Perk_1_4 = 6,
		Central_Perk_2_1 = 7,
		Central_Perk_2_2 = 8,
		Central_Perk_2_3 = 9,
		Central_Perk_2_4 = 10,
		Central_Perk_3_1 = 11,
		Central_Perk_3_2 = 12,
		Central_Perk_3_3 = 13,
		Central_Perk_3_4 = 14,
		Espionage_Main_Perk_1 = 15,
		Espionage_Main_Perk_1_Side_1 = 16,
		Espionage_Main_Perk_1_Side_2 = 17,
		Espionage_Main_Perk_1_Side_3 = 18,
		Espionage_Main_Perk_1_Side_4 = 19,
		Espionage_Main_Perk_2 = 20,
		Espionage_Main_Perk_2_Side_1 = 21,
		Espionage_Main_Perk_3 = 22,
		Espionage_Main_Perk_3_Side_1 = 23,
		Inbetween_Left_2 = 24,
		Inbetween_Left_3 = 25,
		Inbetween_Right_2 = 26,
		Inbetween_Right_3 = 27,
		Left_Milestone_1 = 28,
		Left_Milestone_2 = 29,
		Left_Milestone_3 = 30,
		Left_Perk_1_1 = 31,
		Left_Perk_1_2 = 32,
		Left_Perk_1_3 = 33,
		Left_Perk_1_4 = 34,
		Left_Perk_2_1 = 35,
		Left_Perk_2_2 = 36,
		Left_Perk_2_3 = 37,
		Left_Perk_2_4 = 38,
		Left_Perk_3_1 = 39,
		Left_Perk_3_2 = 40,
		Left_Perk_3_3 = 41,
		Left_Perk_3_4 = 42,
		Master_Perk_1 = 43,
		Master_Perk_2 = 44,
		Master_Perk_3 = 45,
		Master_Perk_4 = 46,
		Master_Perk_5 = 47,
		Right_Milestone_1 = 48,
		Right_Milestone_2 = 49,
		Right_Milestone_3 = 50,
		Right_Perk_1_1 = 51,
		Right_Perk_1_2 = 52,
		Right_Perk_1_3 = 53,
		Right_Perk_1_4 = 54,
		Right_Perk_2_1 = 55,
		Right_Perk_2_2 = 56,
		Right_Perk_2_3 = 57,
		Right_Perk_2_4 = 58,
		Right_Perk_3_1 = 59,
		Right_Perk_3_2 = 60,
		Right_Perk_3_3 = 61,
		Right_Perk_3_4 = 62,
		Count = 63,
		Invalid = 64
	}

	public enum gamedataNewPerkTierType
	{
		AdeptNewPerkTier = 0,
		EspionageNewPerkTier = 1,
		ExpertNewPerkTier = 2,
		MasterNewPerkTier = 3,
		NoviceNewPerkTier = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataNewPerkType
	{
		Body_Central_Milestone_1 = 0,
		Body_Central_Milestone_3 = 1,
		Body_Central_Perk_1_1 = 2,
		Body_Central_Perk_1_2 = 3,
		Body_Central_Perk_1_3 = 4,
		Body_Central_Perk_1_4 = 5,
		Body_Central_Perk_3_1 = 6,
		Body_Central_Perk_3_2 = 7,
		Body_Central_Perk_3_4 = 8,
		Body_Inbetween_Left_3 = 9,
		Body_Inbetween_Right_3 = 10,
		Body_Left_Milestone_2 = 11,
		Body_Left_Milestone_3 = 12,
		Body_Left_Perk_2_1 = 13,
		Body_Left_Perk_2_3 = 14,
		Body_Left_Perk_2_4 = 15,
		Body_Left_Perk_3_1 = 16,
		Body_Left_Perk_3_2 = 17,
		Body_Left_Perk_3_3 = 18,
		Body_Left_Perk_3_4 = 19,
		Body_Master_Perk_1 = 20,
		Body_Master_Perk_2 = 21,
		Body_Master_Perk_3 = 22,
		Body_Master_Perk_5 = 23,
		Body_Right_Milestone_1 = 24,
		Body_Right_Milestone_2 = 25,
		Body_Right_Milestone_3 = 26,
		Body_Right_Perk_2_1 = 27,
		Body_Right_Perk_2_2 = 28,
		Body_Right_Perk_2_3 = 29,
		Body_Right_Perk_2_4 = 30,
		Body_Right_Perk_3_1 = 31,
		Body_Right_Perk_3_2 = 32,
		Cool_Central_Milestone_1 = 33,
		Cool_Central_Milestone_3 = 34,
		Cool_Central_Perk_1_1 = 35,
		Cool_Central_Perk_1_2 = 36,
		Cool_Central_Perk_1_4 = 37,
		Cool_Central_Perk_3_1 = 38,
		Cool_Central_Perk_3_2 = 39,
		Cool_Central_Perk_3_4 = 40,
		Cool_Inbetween_Left_2 = 41,
		Cool_Inbetween_Left_3 = 42,
		Cool_Inbetween_Right_3 = 43,
		Cool_Left_Milestone_1 = 44,
		Cool_Left_Milestone_2 = 45,
		Cool_Left_Milestone_3 = 46,
		Cool_Left_Perk_2_1 = 47,
		Cool_Left_Perk_2_2 = 48,
		Cool_Left_Perk_2_3 = 49,
		Cool_Left_Perk_2_4 = 50,
		Cool_Left_Perk_3_1 = 51,
		Cool_Left_Perk_3_2 = 52,
		Cool_Left_Perk_3_3 = 53,
		Cool_Left_Perk_3_4 = 54,
		Cool_Master_Perk_1 = 55,
		Cool_Master_Perk_2 = 56,
		Cool_Master_Perk_4 = 57,
		Cool_Right_Milestone_1 = 58,
		Cool_Right_Milestone_2 = 59,
		Cool_Right_Milestone_3 = 60,
		Cool_Right_Perk_1_1 = 61,
		Cool_Right_Perk_1_2 = 62,
		Cool_Right_Perk_2_1 = 63,
		Cool_Right_Perk_2_2 = 64,
		Cool_Right_Perk_2_3 = 65,
		Cool_Right_Perk_2_4 = 66,
		Cool_Right_Perk_3_1 = 67,
		Cool_Right_Perk_3_2 = 68,
		Cool_Right_Perk_3_3 = 69,
		Cool_Right_Perk_3_4 = 70,
		Espionage_Central_Milestone_1 = 71,
		Espionage_Central_Perk_1_1 = 72,
		Espionage_Central_Perk_1_2 = 73,
		Espionage_Central_Perk_1_3 = 74,
		Espionage_Central_Perk_1_4 = 75,
		Espionage_Left_Milestone_Perk = 76,
		Espionage_Left_Perk_1_2 = 77,
		Espionage_Right_Milestone_1 = 78,
		Espionage_Right_Perk_1_1 = 79,
		Intelligence_Central_Milestone_1 = 80,
		Intelligence_Central_Milestone_2 = 81,
		Intelligence_Central_Milestone_3 = 82,
		Intelligence_Central_Perk_1_1 = 83,
		Intelligence_Central_Perk_1_2 = 84,
		Intelligence_Central_Perk_1_3 = 85,
		Intelligence_Central_Perk_2_1 = 86,
		Intelligence_Central_Perk_2_2 = 87,
		Intelligence_Central_Perk_2_3 = 88,
		Intelligence_Central_Perk_2_4 = 89,
		Intelligence_Central_Perk_3_1 = 90,
		Intelligence_Central_Perk_3_2 = 91,
		Intelligence_Central_Perk_3_3 = 92,
		Intelligence_Inbetween_Left_2 = 93,
		Intelligence_Inbetween_Left_3 = 94,
		Intelligence_Inbetween_Right_2 = 95,
		Intelligence_Left_Milestone_1 = 96,
		Intelligence_Left_Milestone_2 = 97,
		Intelligence_Left_Milestone_3 = 98,
		Intelligence_Left_Perk_1_1 = 99,
		Intelligence_Left_Perk_1_2 = 100,
		Intelligence_Left_Perk_2_1 = 101,
		Intelligence_Left_Perk_2_2 = 102,
		Intelligence_Left_Perk_2_3 = 103,
		Intelligence_Left_Perk_2_4 = 104,
		Intelligence_Left_Perk_3_1 = 105,
		Intelligence_Left_Perk_3_2 = 106,
		Intelligence_Left_Perk_3_4 = 107,
		Intelligence_Master_Perk_1 = 108,
		Intelligence_Master_Perk_3 = 109,
		Intelligence_Master_Perk_4 = 110,
		Intelligence_Right_Milestone_1 = 111,
		Intelligence_Right_Milestone_2 = 112,
		Intelligence_Right_Milestone_3 = 113,
		Intelligence_Right_Perk_2_1 = 114,
		Intelligence_Right_Perk_2_2 = 115,
		Intelligence_Right_Perk_3_1 = 116,
		Intelligence_Right_Perk_3_2 = 117,
		Reflexes_Central_Milestone_1 = 118,
		Reflexes_Central_Milestone_2 = 119,
		Reflexes_Central_Milestone_3 = 120,
		Reflexes_Central_Perk_1_1 = 121,
		Reflexes_Central_Perk_1_2 = 122,
		Reflexes_Central_Perk_1_3 = 123,
		Reflexes_Central_Perk_1_4 = 124,
		Reflexes_Central_Perk_2_1 = 125,
		Reflexes_Central_Perk_2_2 = 126,
		Reflexes_Central_Perk_2_3 = 127,
		Reflexes_Central_Perk_2_4 = 128,
		Reflexes_Central_Perk_3_2 = 129,
		Reflexes_Central_Perk_3_3 = 130,
		Reflexes_Inbetween_Left_3 = 131,
		Reflexes_Inbetween_Right_2 = 132,
		Reflexes_Left_Milestone_1 = 133,
		Reflexes_Left_Milestone_2 = 134,
		Reflexes_Left_Milestone_3 = 135,
		Reflexes_Left_Perk_2_2 = 136,
		Reflexes_Left_Perk_2_3 = 137,
		Reflexes_Left_Perk_2_4 = 138,
		Reflexes_Left_Perk_3_1 = 139,
		Reflexes_Left_Perk_3_2 = 140,
		Reflexes_Left_Perk_3_3 = 141,
		Reflexes_Left_Perk_3_4 = 142,
		Reflexes_Master_Perk_1 = 143,
		Reflexes_Master_Perk_2 = 144,
		Reflexes_Master_Perk_3 = 145,
		Reflexes_Master_Perk_5 = 146,
		Reflexes_Right_Milestone_2 = 147,
		Reflexes_Right_Milestone_3 = 148,
		Reflexes_Right_Perk_2_1 = 149,
		Reflexes_Right_Perk_2_2 = 150,
		Reflexes_Right_Perk_2_3 = 151,
		Reflexes_Right_Perk_3_1 = 152,
		Reflexes_Right_Perk_3_3 = 153,
		Reflexes_Right_Perk_3_4 = 154,
		Tech_Central_Milestone_2 = 155,
		Tech_Central_Milestone_3 = 156,
		Tech_Central_Perk_2_1 = 157,
		Tech_Central_Perk_2_2 = 158,
		Tech_Central_Perk_2_3 = 159,
		Tech_Central_Perk_2_4 = 160,
		Tech_Central_Perk_3_1 = 161,
		Tech_Central_Perk_3_2 = 162,
		Tech_Central_Perk_3_3 = 163,
		Tech_Central_Perk_3_4 = 164,
		Tech_Inbetween_Left_3 = 165,
		Tech_Inbetween_Right_2 = 166,
		Tech_Left_Milestone_1 = 167,
		Tech_Left_Milestone_2 = 168,
		Tech_Left_Milestone_3 = 169,
		Tech_Left_Perk_1_1 = 170,
		Tech_Left_Perk_1_2 = 171,
		Tech_Left_Perk_2_1 = 172,
		Tech_Left_Perk_2_2 = 173,
		Tech_Left_Perk_2_3 = 174,
		Tech_Left_Perk_2_4 = 175,
		Tech_Left_Perk_3_01 = 176,
		Tech_Left_Perk_3_2 = 177,
		Tech_Left_Perk_3_3 = 178,
		Tech_Left_Perk_3_4 = 179,
		Tech_Master_Perk_2 = 180,
		Tech_Master_Perk_3 = 181,
		Tech_Master_Perk_5 = 182,
		Tech_Right_Milestone_1 = 183,
		Tech_Right_Milestone_3 = 184,
		Tech_Right_Perk_3_1 = 185,
		Tech_Right_Perk_3_2 = 186,
		Tech_Right_Perk_3_3 = 187,
		Tech_Right_Perk_3_4 = 188,
		Count = 189,
		Invalid = 190
	}

	public enum gamedataObjectActionReference
	{
		Instigator = 0,
		Source = 1,
		Target = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataObjectActionType
	{
		DeviceQuickHack = 0,
		Direct = 1,
		Item = 2,
		MinigameUpload = 3,
		Payment = 4,
		PuppetQuickHack = 5,
		Remote = 6,
		VehicleQuickHack = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gamedataOutput
	{
		AskToFollowOrder = 0,
		AskToHolster = 1,
		BackOff = 2,
		BodyInvestigate = 3,
		Bump = 4,
		CallGuard = 5,
		CallPolice = 6,
		DeviceInvestigate = 7,
		Dodge = 8,
		DodgeToSide = 9,
		FearInPlace = 10,
		Flee = 11,
		Ignore = 12,
		Intruder = 13,
		Investigate = 14,
		LookAt = 15,
		Panic = 16,
		PlayerCall = 17,
		ProjectileInvestigate = 18,
		Reprimand = 19,
		SquadCall = 20,
		Surrender = 21,
		TurnAt = 22,
		WalkAway = 23,
		Count = 24,
		Invalid = 25
	}

	public enum gamedataParentAttachmentType
	{
		Animated = 0,
		Skinned = 1,
		Slot = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataPerkArea
	{
		Assault_Area_01 = 0,
		Assault_Area_02 = 1,
		Assault_Area_03 = 2,
		Assault_Area_04 = 3,
		Assault_Area_05 = 4,
		Assault_Area_06 = 5,
		Assault_Area_07 = 6,
		Assault_Area_08 = 7,
		Assault_Area_09 = 8,
		Assault_Area_10 = 9,
		Athletics_Area_01 = 10,
		Athletics_Area_02 = 11,
		Athletics_Area_03 = 12,
		Athletics_Area_04 = 13,
		Athletics_Area_05 = 14,
		Athletics_Area_06 = 15,
		Athletics_Area_07 = 16,
		Athletics_Area_08 = 17,
		Athletics_Area_09 = 18,
		Athletics_Area_10 = 19,
		Brawling_Area_01 = 20,
		Brawling_Area_02 = 21,
		Brawling_Area_03 = 22,
		Brawling_Area_04 = 23,
		Brawling_Area_05 = 24,
		Brawling_Area_06 = 25,
		Brawling_Area_07 = 26,
		Brawling_Area_08 = 27,
		ColdBlood_Area_01 = 28,
		ColdBlood_Area_02 = 29,
		ColdBlood_Area_03 = 30,
		ColdBlood_Area_04 = 31,
		ColdBlood_Area_05 = 32,
		ColdBlood_Area_06 = 33,
		ColdBlood_Area_07 = 34,
		ColdBlood_Area_08 = 35,
		ColdBlood_Area_09 = 36,
		ColdBlood_Area_10 = 37,
		CombatHacking_Area_01 = 38,
		CombatHacking_Area_02 = 39,
		CombatHacking_Area_03 = 40,
		CombatHacking_Area_04 = 41,
		CombatHacking_Area_05 = 42,
		CombatHacking_Area_06 = 43,
		CombatHacking_Area_07 = 44,
		CombatHacking_Area_08 = 45,
		CombatHacking_Area_09 = 46,
		CombatHacking_Area_10 = 47,
		Crafting_Area_01 = 48,
		Crafting_Area_02 = 49,
		Crafting_Area_03 = 50,
		Crafting_Area_04 = 51,
		Crafting_Area_05 = 52,
		Crafting_Area_06 = 53,
		Crafting_Area_07 = 54,
		Crafting_Area_08 = 55,
		Crafting_Area_09 = 56,
		Crafting_Area_10 = 57,
		Demolition_Area_01 = 58,
		Demolition_Area_02 = 59,
		Demolition_Area_03 = 60,
		Demolition_Area_04 = 61,
		Demolition_Area_05 = 62,
		Demolition_Area_06 = 63,
		Demolition_Area_07 = 64,
		Demolition_Area_08 = 65,
		Demolition_Area_09 = 66,
		Demolition_Area_10 = 67,
		Engineering_Area_01 = 68,
		Engineering_Area_02 = 69,
		Engineering_Area_03 = 70,
		Engineering_Area_04 = 71,
		Engineering_Area_05 = 72,
		Engineering_Area_06 = 73,
		Engineering_Area_07 = 74,
		Engineering_Area_08 = 75,
		Engineering_Area_09 = 76,
		Engineering_Area_10 = 77,
		Gunslinger_Area_01 = 78,
		Gunslinger_Area_02 = 79,
		Gunslinger_Area_03 = 80,
		Gunslinger_Area_04 = 81,
		Gunslinger_Area_05 = 82,
		Gunslinger_Area_06 = 83,
		Gunslinger_Area_07 = 84,
		Gunslinger_Area_08 = 85,
		Gunslinger_Area_09 = 86,
		Gunslinger_Area_10 = 87,
		Hacking_Area_01 = 88,
		Hacking_Area_02 = 89,
		Hacking_Area_03 = 90,
		Hacking_Area_04 = 91,
		Hacking_Area_05 = 92,
		Hacking_Area_06 = 93,
		Hacking_Area_07 = 94,
		Hacking_Area_08 = 95,
		Hacking_Area_09 = 96,
		Hacking_Area_10 = 97,
		Kenjutsu_Area_01 = 98,
		Kenjutsu_Area_02 = 99,
		Kenjutsu_Area_03 = 100,
		Kenjutsu_Area_04 = 101,
		Kenjutsu_Area_05 = 102,
		Kenjutsu_Area_06 = 103,
		Kenjutsu_Area_07 = 104,
		Kenjutsu_Area_08 = 105,
		Stealth_Area_01 = 106,
		Stealth_Area_02 = 107,
		Stealth_Area_03 = 108,
		Stealth_Area_04 = 109,
		Stealth_Area_05 = 110,
		Stealth_Area_06 = 111,
		Stealth_Area_07 = 112,
		Stealth_Area_08 = 113,
		Stealth_Area_09 = 114,
		Stealth_Area_10 = 115,
		Count = 116,
		Invalid = 117
	}

	public enum gamedataPerkType
	{
		Assault_Area_01_Perk_1 = 0,
		Assault_Area_01_Perk_2 = 1,
		Assault_Area_02_Perk_1 = 2,
		Assault_Area_02_Perk_2 = 3,
		Assault_Area_03_Perk_1 = 4,
		Assault_Area_03_Perk_2 = 5,
		Assault_Area_04_Perk_1 = 6,
		Assault_Area_04_Perk_2 = 7,
		Assault_Area_05_Perk_1 = 8,
		Assault_Area_05_Perk_2 = 9,
		Assault_Area_06_Perk_1 = 10,
		Assault_Area_06_Perk_2 = 11,
		Assault_Area_07_Perk_1 = 12,
		Assault_Area_07_Perk_2 = 13,
		Assault_Area_08_Perk_1 = 14,
		Assault_Area_08_Perk_2 = 15,
		Assault_Area_09_Perk_1 = 16,
		Assault_Area_09_Perk_2 = 17,
		Assault_Area_10_Perk_1 = 18,
		Athletics_Area_01_Perk_1 = 19,
		Athletics_Area_01_Perk_2 = 20,
		Athletics_Area_02_Perk_1 = 21,
		Athletics_Area_02_Perk_2 = 22,
		Athletics_Area_03_Perk_1 = 23,
		Athletics_Area_03_Perk_2 = 24,
		Athletics_Area_04_Perk_1 = 25,
		Athletics_Area_04_Perk_2 = 26,
		Athletics_Area_05_Perk_1 = 27,
		Athletics_Area_05_Perk_2 = 28,
		Athletics_Area_05_Perk_3 = 29,
		Athletics_Area_06_Perk_1 = 30,
		Athletics_Area_06_Perk_2 = 31,
		Athletics_Area_06_Perk_3 = 32,
		Athletics_Area_07_Perk_1 = 33,
		Athletics_Area_07_Perk_2 = 34,
		Athletics_Area_08_Perk_1 = 35,
		Athletics_Area_08_Perk_2 = 36,
		Athletics_Area_09_Perk_1 = 37,
		Athletics_Area_10_Perk_1 = 38,
		Athletics_Area_10_Perk_2 = 39,
		Brawling_Area_01_Perk_1 = 40,
		Brawling_Area_01_Perk_2 = 41,
		Brawling_Area_02_Perk_1 = 42,
		Brawling_Area_02_Perk_2 = 43,
		Brawling_Area_03_Perk_1 = 44,
		Brawling_Area_03_Perk_2 = 45,
		Brawling_Area_04_Perk_1 = 46,
		Brawling_Area_04_Perk_2 = 47,
		Brawling_Area_05_Perk_1 = 48,
		Brawling_Area_05_Perk_2 = 49,
		Brawling_Area_06_Perk_1 = 50,
		Brawling_Area_06_Perk_2 = 51,
		Brawling_Area_07_Perk_1 = 52,
		Brawling_Area_07_Perk_2 = 53,
		Brawling_Area_08_Perk_1 = 54,
		Brawling_Area_08_Perk_2 = 55,
		ColdBlood_Area_01_Perk_1 = 56,
		ColdBlood_Area_02_Perk_1 = 57,
		ColdBlood_Area_02_Perk_2 = 58,
		ColdBlood_Area_03_Perk_1 = 59,
		ColdBlood_Area_03_Perk_2 = 60,
		ColdBlood_Area_04_Perk_1 = 61,
		ColdBlood_Area_04_Perk_2 = 62,
		ColdBlood_Area_05_Perk_1 = 63,
		ColdBlood_Area_05_Perk_2 = 64,
		ColdBlood_Area_06_Perk_1 = 65,
		ColdBlood_Area_06_Perk_2 = 66,
		ColdBlood_Area_06_Perk_3 = 67,
		ColdBlood_Area_07_Perk_1 = 68,
		ColdBlood_Area_07_Perk_2 = 69,
		ColdBlood_Area_08_Perk_1 = 70,
		ColdBlood_Area_08_Perk_2 = 71,
		ColdBlood_Area_09_Perk_1 = 72,
		ColdBlood_Area_10_Perk_1 = 73,
		CombatHacking_Area_01_Perk_1 = 74,
		CombatHacking_Area_01_Perk_2 = 75,
		CombatHacking_Area_02_Perk_1 = 76,
		CombatHacking_Area_02_Perk_2 = 77,
		CombatHacking_Area_02_Perk_3 = 78,
		CombatHacking_Area_03_Perk_1 = 79,
		CombatHacking_Area_03_Perk_2 = 80,
		CombatHacking_Area_04_Perk_1 = 81,
		CombatHacking_Area_05_Perk_1 = 82,
		CombatHacking_Area_06_Perk_1 = 83,
		CombatHacking_Area_06_Perk_2 = 84,
		CombatHacking_Area_06_Perk_3 = 85,
		CombatHacking_Area_07_Perk_1 = 86,
		CombatHacking_Area_08_Perk_1 = 87,
		CombatHacking_Area_08_Perk_2 = 88,
		CombatHacking_Area_09_Perk_1 = 89,
		CombatHacking_Area_10_Perk_1 = 90,
		CombatHacking_Area_10_Perk_2 = 91,
		Crafting_Area_01_Perk_1 = 92,
		Crafting_Area_01_Perk_2 = 93,
		Crafting_Area_02_Perk_1 = 94,
		Crafting_Area_02_Perk_2 = 95,
		Crafting_Area_03_Perk_1 = 96,
		Crafting_Area_04_Perk_1 = 97,
		Crafting_Area_04_Perk_2 = 98,
		Crafting_Area_05_Perk_1 = 99,
		Crafting_Area_05_Perk_2 = 100,
		Crafting_Area_06_Perk_1 = 101,
		Crafting_Area_06_Perk_2 = 102,
		Crafting_Area_06_Perk_3 = 103,
		Crafting_Area_07_Perk_1 = 104,
		Crafting_Area_07_Perk_2 = 105,
		Crafting_Area_08_Perk_1 = 106,
		Crafting_Area_08_Perk_2 = 107,
		Crafting_Area_09_Perk_1 = 108,
		Crafting_Area_10_Perk_1 = 109,
		Demolition_Area_01_Perk_1 = 110,
		Demolition_Area_02_Perk_1 = 111,
		Demolition_Area_02_Perk_2 = 112,
		Demolition_Area_03_Perk_1 = 113,
		Demolition_Area_03_Perk_2 = 114,
		Demolition_Area_04_Perk_1 = 115,
		Demolition_Area_04_Perk_2 = 116,
		Demolition_Area_05_Perk_1 = 117,
		Demolition_Area_05_Perk_2 = 118,
		Demolition_Area_06_Perk_1 = 119,
		Demolition_Area_06_Perk_2 = 120,
		Demolition_Area_07_Perk_1 = 121,
		Demolition_Area_07_Perk_2 = 122,
		Demolition_Area_08_Perk_1 = 123,
		Demolition_Area_08_Perk_2 = 124,
		Demolition_Area_09_Perk_1 = 125,
		Demolition_Area_09_Perk_2 = 126,
		Demolition_Area_10_Perk_1 = 127,
		Demolition_Area_10_Perk_2 = 128,
		Engineering_Area_01_Perk_1 = 129,
		Engineering_Area_01_Perk_2 = 130,
		Engineering_Area_02_Perk_1 = 131,
		Engineering_Area_02_Perk_2 = 132,
		Engineering_Area_03_Perk_1 = 133,
		Engineering_Area_04_Perk_1 = 134,
		Engineering_Area_04_Perk_2 = 135,
		Engineering_Area_04_Perk_3 = 136,
		Engineering_Area_05_Perk_1 = 137,
		Engineering_Area_05_Perk_2 = 138,
		Engineering_Area_06_Perk_1 = 139,
		Engineering_Area_06_Perk_2 = 140,
		Engineering_Area_07_Perk_1 = 141,
		Engineering_Area_07_Perk_2 = 142,
		Engineering_Area_07_Perk_3 = 143,
		Engineering_Area_08_Perk_1 = 144,
		Engineering_Area_08_Perk_2 = 145,
		Engineering_Area_09_Perk_1 = 146,
		Engineering_Area_10_Perk_1 = 147,
		Engineering_Area_10_Perk_2 = 148,
		Gunslinger_Area_01_Perk_1 = 149,
		Gunslinger_Area_01_Perk_2 = 150,
		Gunslinger_Area_02_Perk_1 = 151,
		Gunslinger_Area_02_Perk_2 = 152,
		Gunslinger_Area_03_Perk_1 = 153,
		Gunslinger_Area_03_Perk_2 = 154,
		Gunslinger_Area_04_Perk_1 = 155,
		Gunslinger_Area_04_Perk_2 = 156,
		Gunslinger_Area_04_Perk_3 = 157,
		Gunslinger_Area_05_Perk_1 = 158,
		Gunslinger_Area_05_Perk_2 = 159,
		Gunslinger_Area_06_Perk_1 = 160,
		Gunslinger_Area_06_Perk_2 = 161,
		Gunslinger_Area_07_Perk_1 = 162,
		Gunslinger_Area_07_Perk_2 = 163,
		Gunslinger_Area_08_Perk_1 = 164,
		Gunslinger_Area_08_Perk_2 = 165,
		Gunslinger_Area_09_Perk_1 = 166,
		Gunslinger_Area_10_Perk_1 = 167,
		Hacking_Area_01_Perk_1 = 168,
		Hacking_Area_01_Perk_2 = 169,
		Hacking_Area_02_Perk_1 = 170,
		Hacking_Area_02_Perk_2 = 171,
		Hacking_Area_03_Perk_1 = 172,
		Hacking_Area_03_Perk_2 = 173,
		Hacking_Area_04_Perk_1 = 174,
		Hacking_Area_04_Perk_2 = 175,
		Hacking_Area_05_Perk_1 = 176,
		Hacking_Area_06_Perk_1 = 177,
		Hacking_Area_06_Perk_2 = 178,
		Hacking_Area_07_Perk_1 = 179,
		Hacking_Area_07_Perk_2 = 180,
		Hacking_Area_08_Perk_1 = 181,
		Hacking_Area_08_Perk_2 = 182,
		Hacking_Area_09_Perk_1 = 183,
		Hacking_Area_09_Perk_2 = 184,
		Hacking_Area_10_Perk_1 = 185,
		Hacking_Area_10_Perk_2 = 186,
		Kenjutsu_Area_01_Perk_1 = 187,
		Kenjutsu_Area_01_Perk_2 = 188,
		Kenjutsu_Area_02_Perk_1 = 189,
		Kenjutsu_Area_02_Perk_2 = 190,
		Kenjutsu_Area_03_Perk_1 = 191,
		Kenjutsu_Area_03_Perk_2 = 192,
		Kenjutsu_Area_04_Perk_1 = 193,
		Kenjutsu_Area_04_Perk_2 = 194,
		Kenjutsu_Area_05_Perk_1 = 195,
		Kenjutsu_Area_05_Perk_2 = 196,
		Kenjutsu_Area_06_Perk_1 = 197,
		Kenjutsu_Area_06_Perk_2 = 198,
		Kenjutsu_Area_07_Perk_1 = 199,
		Kenjutsu_Area_07_Perk_2 = 200,
		Kenjutsu_Area_08_Perk_1 = 201,
		Kenjutsu_Area_08_Perk_2 = 202,
		Stealth_Area_01_Perk_1 = 203,
		Stealth_Area_01_Perk_2 = 204,
		Stealth_Area_02_Perk_1 = 205,
		Stealth_Area_02_Perk_2 = 206,
		Stealth_Area_02_Perk_3 = 207,
		Stealth_Area_03_Perk_1 = 208,
		Stealth_Area_03_Perk_2 = 209,
		Stealth_Area_03_Perk_3 = 210,
		Stealth_Area_04_Perk_1 = 211,
		Stealth_Area_04_Perk_2 = 212,
		Stealth_Area_05_Perk_1 = 213,
		Stealth_Area_05_Perk_2 = 214,
		Stealth_Area_05_Perk_3 = 215,
		Stealth_Area_06_Perk_1 = 216,
		Stealth_Area_06_Perk_2 = 217,
		Stealth_Area_07_Perk_1 = 218,
		Stealth_Area_07_Perk_2 = 219,
		Stealth_Area_07_Perk_3 = 220,
		Stealth_Area_08_Perk_1 = 221,
		Stealth_Area_08_Perk_2 = 222,
		Stealth_Area_08_Perk_3 = 223,
		Stealth_Area_09_Perk_1 = 224,
		Stealth_Area_09_Perk_2 = 225,
		Stealth_Area_09_Perk_3 = 226,
		Stealth_Area_10_Perk_1 = 227,
		Count = 228,
		Invalid = 229
	}

	public enum gamedataPerkUtility
	{
		ActiveUtility = 0,
		PassiveUtility = 1,
		TriggeredUtility = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataPerkWeaponGroupType
	{
		AssaultRiflesPerkWeaponGroup = 0,
		BladesPerkWeaponGroup = 1,
		BluntsPerkWeaponGroup = 2,
		BodyGunsPerkWeaponGroup = 3,
		CoolGunsPerkWeaponGroup = 4,
		HandgunsPerkWeaponGroup = 5,
		LMGsPerkWeaponGroup = 6,
		PrecisionGunsPerkWeaponGroup = 7,
		ReflexesGunsPerkWeaponGroup = 8,
		SMGsPerkWeaponGroup = 9,
		ShotgunsPerkWeaponGroup = 10,
		SmartGunsPerkWeaponGroup = 11,
		TechGunsPerkWeaponGroup = 12,
		ThrowablePerkWeaponGroup = 13,
		Count = 14,
		Invalid = 15
	}

	public enum gamedataPingType
	{
		Device = 0,
		Door = 1,
		Elevator = 2,
		Junction = 3,
		Location = 4,
		Loot = 5,
		Trap = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataPlayerBuild
	{
		Cool = 0,
		Netrunner = 1,
		Reflexes = 2,
		Solo = 3,
		Techie = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataPlayerPossesion
	{
		Default = 0,
		Johnny = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataProficiencyType
	{
		Assault = 0,
		Athletics = 1,
		Brawling = 2,
		ColdBlood = 3,
		CombatHacking = 4,
		CoolSkill = 5,
		Crafting = 6,
		Demolition = 7,
		Engineering = 8,
		Espionage = 9,
		Gunslinger = 10,
		Hacking = 11,
		IntelligenceSkill = 12,
		Kenjutsu = 13,
		Level = 14,
		ReflexesSkill = 15,
		Stealth = 16,
		StreetCred = 17,
		StrengthSkill = 18,
		TechnicalAbilitySkill = 19,
		Count = 20,
		Invalid = 21
	}

	public enum gamedataProjectileLaunchMode
	{
		Regular = 0,
		Tracking = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataProjectileOnCollisionAction
	{
		Bounce = 0,
		Pierce = 1,
		Stop = 2,
		StopAndStick = 3,
		StopAndStickPerpendicular = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataQuality
	{
		Common = 0,
		CommonPlus = 1,
		Epic = 2,
		EpicPlus = 3,
		Iconic = 4,
		Legendary = 5,
		LegendaryPlus = 6,
		LegendaryPlusPlus = 7,
		Random = 8,
		Rare = 9,
		RarePlus = 10,
		Uncommon = 11,
		UncommonPlus = 12,
		Count = 13,
		Invalid = 14
	}

	public enum gamedataReactionPresetType
	{
		Cerberus_Aggressive = 0,
		Child = 1,
		Civilian_Grabbable = 2,
		Civilian_Guard = 3,
		Civilian_Neutral = 4,
		Civilian_NoReaction = 5,
		Civilian_Passive = 6,
		Corpo_Aggressive = 7,
		Corpo_Passive = 8,
		Follower = 9,
		Ganger_Aggressive = 10,
		Ganger_Passive = 11,
		InVehicle_Aggressive = 12,
		InVehicle_Civilian = 13,
		InVehicle_Passive = 14,
		Lore_Aggressive = 15,
		Lore_Civilian = 16,
		Lore_Passive = 17,
		Mechanical_Aggressive = 18,
		Mechanical_NonCombat = 19,
		Mechanical_Passive = 20,
		NoReaction = 21,
		Police_Aggressive = 22,
		Police_Passive = 23,
		Sleep_Aggressive = 24,
		Sleep_Civilian = 25,
		Sleep_Passive = 26,
		Count = 27,
		Invalid = 28
	}

	public enum gamedataSearchFilterMaskType
	{
		Att_Friendly = 0,
		Att_Hostile = 1,
		Att_Neutral = 2,
		Obj_Device = 3,
		Obj_Other = 4,
		Obj_Player = 5,
		Obj_Puppet = 6,
		Obj_Sensor = 7,
		Sp_Aggressive = 8,
		Sp_AimAssistEnabled = 9,
		Sp_VisibleThroughGeometry = 10,
		St_Alive = 11,
		St_AliveAndActive = 12,
		St_Conscious = 13,
		St_Dead = 14,
		St_DeadOrInactive = 15,
		St_Defeated = 16,
		St_MountedToBike = 17,
		St_MountedToCar = 18,
		St_MountedToVehicle = 19,
		St_NotDefeated = 20,
		St_QuickHackable = 21,
		St_TurnedOff = 22,
		St_TurnedOn = 23,
		St_Unconscious = 24,
		TF_None = 25,
		Count = 26,
		Invalid = 27
	}

	public enum gamedataSenseObjectType
	{
		Camera = 0,
		Deadbody = 1,
		Follower = 2,
		Npc = 3,
		Player = 4,
		Turret = 5,
		Undefined = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataSimpleValueNodeValueType
	{
		String = 0,
		Number = 1,
		Bool = 2,
		Ident = 3
	}

	public enum gamedataSpawnableObjectPriority
	{
		Crowd = 0,
		Quest = 1,
		Regular = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataStatPoolType
	{
		AccumulatedDoT = 0,
		Adrenaline = 1,
		Aggressiveness = 2,
		Armor = 3,
		BerserkCharge = 4,
		BleedingTrigger = 5,
		BurningTrigger = 6,
		CPUPower = 7,
		CWMaskCharges = 8,
		CallReinforcementProgress = 9,
		CyberdeckOverclock = 10,
		Durability = 11,
		E3_BossWeakSpotHealth = 12,
		ElectrocutedTrigger = 13,
		Fear = 14,
		GrenadesCharges = 15,
		HealingItemsCharges = 16,
		Health = 17,
		HitShapeArmor = 18,
		JenkinsHelper = 19,
		LeftArmHealth = 20,
		LeftLegHealth = 21,
		Memory = 22,
		OpticalCamoCharges = 23,
		Overshield = 24,
		Oxygen = 25,
		PhoneCallDuration = 26,
		Poise = 27,
		PoisonTrigger = 28,
		ProjectileLauncherCharges = 29,
		QuickHackDuration = 30,
		QuickHackUpload = 31,
		ReprimandEscalation = 32,
		RightLegHealth = 33,
		SandevistanCharge = 34,
		Stamina = 35,
		StunTrigger = 36,
		ThrowRecovery = 37,
		TimeBank = 38,
		UnlockProgress = 39,
		VehicleMissileLauncherCharges = 40,
		WeakspotHealth = 41,
		WeaponCharge = 42,
		WeaponOverheat = 43,
		CPOShockedTrigger = 44,
		CPO_Armor = 45,
		CPO_NPC_Importance = 46,
		Count = 47,
		Invalid = 48
	}

	public enum gamedataStatType
	{
		ADSSpeedPercentBonus = 0,
		ADSSpeedPercentBonusModifierHelper = 1,
		ADSStaminaRegenMultiplier = 2,
		ARSMGLMGMod2_HorRecoil = 3,
		ARSMGLMGMod2_RecoilKick = 4,
		ARSMGLMGMod2_RecoilKickCover = 5,
		ARSMGLMGMod3_SpreadPerShot = 6,
		Acceleration = 7,
		AccumulatedDoT = 8,
		AccumulatedDoTDecayDelayOnChange = 9,
		AccumulatedDoTDecayEnabled = 10,
		AccumulatedDoTDecayEndThrehold = 11,
		AccumulatedDoTDecayRate = 12,
		AccumulatedDoTDecayStartDelay = 13,
		AccumulatedDoTDecayStartThreshold = 14,
		Accuracy = 15,
		AddExtraHitImpactVfx = 16,
		AdditionalStealthDamage = 17,
		Adrenaline = 18,
		AimFOV = 19,
		AimInTime = 20,
		AimOffset = 21,
		AimOutTime = 22,
		AimTime = 23,
		AimingCost = 24,
		AirDrop_BurningApplicationRate = 25,
		Airdropped = 26,
		AllDamageDonePercentBonus = 27,
		AllowMovementInput = 28,
		AllowRotation = 29,
		AmmoPerQuickMelee = 30,
		AntiVirusCooldownReduction = 31,
		ApplicationChance = 32,
		Armor = 33,
		ArmorEffectivenessMultiplier = 34,
		ArmorMultBonus = 35,
		ArmorPenetrationBonus = 36,
		Assault = 37,
		AssaultMastery = 38,
		AssaultRifleStaminaCostReduction = 39,
		AssaultTrait01Stat = 40,
		Athletics = 41,
		AthleticsMastery = 42,
		AthleticsTrait01Stat = 43,
		AttackPenetration = 44,
		AttackSpeed = 45,
		AttackSpeedPercent = 46,
		AttacksNumber = 47,
		AttacksPerSecond = 48,
		AttacksPerSecondBase = 49,
		AttunementHelper = 50,
		AttunementHelper2 = 51,
		AttunementHelper3 = 52,
		AttunementHelper4 = 53,
		AttunementHelper5 = 54,
		AudioLocomotionStimRangeMultiplier = 55,
		AudioStimRangeMultiplier = 56,
		AutoReveal = 57,
		AutocraftDuration = 58,
		AutomaticReplenishment = 59,
		AutomaticUploadPerk = 60,
		AxeStaminaCostReduction = 61,
		BaseChargeTime = 62,
		BaseDamage = 63,
		BaseDamageMax = 64,
		BaseDamageMin = 65,
		BaseKnockdownImpulse = 66,
		BaseMaxChargeThreshold = 67,
		BaseMeleeAttackStaminaCost = 68,
		BaseRicochetDamageModifier = 69,
		BatonStaminaCostReduction = 70,
		BerserkArmorBonus = 71,
		BerserkChargesDecayBegins = 72,
		BerserkChargesDecayEnabled = 73,
		BerserkChargesDecayEnds = 74,
		BerserkChargesDecayRate = 75,
		BerserkChargesDecayRateMult = 76,
		BerserkChargesDecayStartDelay = 77,
		BerserkChargesDelayOnChange = 78,
		BerserkChargesRegenBegins = 79,
		BerserkChargesRegenEnabled = 80,
		BerserkChargesRegenEnds = 81,
		BerserkChargesRegenRate = 82,
		BerserkCooldownBase = 83,
		BerserkCooldownReduction = 84,
		BerserkDurationBase = 85,
		BerserkDynamicHealthBonusOnActivation = 86,
		BerserkHealthBonusPerKillCount = 87,
		BerserkHealthRegenBonus = 88,
		BerserkKillCount = 89,
		BerserkMeleeDamageBonus = 90,
		BerserkRechargeDuration = 91,
		BerserkRecoilReduction = 92,
		BerserkResistancesBonus = 93,
		BerserkShockwaveDamage = 94,
		BerserkShockwaveRangeBonus = 95,
		BerserkStaticHealthBonusOnActivation = 96,
		BerserkSwayReduction = 97,
		BlackWallStack = 98,
		BladeMod1_CritChance = 99,
		BleedingApplicationRate = 100,
		BleedingApplicationRateModifierHelper = 101,
		BleedingImmunity = 102,
		BlindImmunity = 103,
		BlindResistance = 104,
		BlockCyberwareBreaches = 105,
		BlockFactor = 106,
		BlockLocomotionWhenLeaningOutOfCover = 107,
		BlockOpticalCamoRelicPerk = 108,
		BlockQuickhackMenu = 109,
		BlockReduction = 110,
		BloodPumpMaxCharges = 111,
		BloodQueueHealing = 112,
		BluntFinisherHealthThresholdIncrease = 113,
		BluntMod1_KnockbackChance = 114,
		BluntMod2_BleedChance = 115,
		BluntMod2_BleedConverter = 116,
		BluntMod3_ModPower = 117,
		BonusCarryCapacity = 118,
		BonusChargeDamage = 119,
		BonusCritChanceVsElectrocutedEnemies = 120,
		BonusCritChanceVsElectrocutedEnemiesModifierHelper = 121,
		BonusDPS = 122,
		BonusDamageAgainstBosses = 123,
		BonusDamageAgainstBossesModifierHelper = 124,
		BonusDamageAgainstElites = 125,
		BonusDamageAgainstMechanicals = 126,
		BonusDamageAgainstRares = 127,
		BonusDamagePerHit = 128,
		BonusDmgVsRaresAndElites = 129,
		BonusHealth = 130,
		BonusMemory = 131,
		BonusPercentDamageToEnemiesAtFullHealth = 132,
		BonusPercentDamageToEnemiesAtFullHealthModifierHelper = 133,
		BonusPercentDamageToEnemiesBelowHalfHealth = 134,
		BonusPercentDamageToEnemiesBelowHalfHealthModifierHelper = 135,
		BonusPercentDamageVsBurningEnemies = 136,
		BonusPercentDamageVsBurningEnemiesModifierHelper = 137,
		BonusQuickHackDamage = 138,
		BonusQuickHackDamageModifierHelper = 139,
		BonusRecoilKick = 140,
		BonusRicochetAngle = 141,
		BonusRicochetCritChance = 142,
		BonusRicochetDamage = 143,
		BonusRicochetDamageModifierHelper = 144,
		BonusSmartGunTimeToLock = 145,
		BonusSpreadChange = 146,
		BonusStamina = 147,
		BossResistance = 148,
		BossResistanceModifierHelper = 149,
		Brake = 150,
		BrakeDot = 151,
		Brawling = 152,
		BrawlingMastery = 153,
		BrawlingTrait01Stat = 154,
		BreachStreakBuffBonus = 155,
		BufferSize = 156,
		BulletDeadReckoningEnabled = 157,
		BulletDeadReckoningMaxAngleCorrection = 158,
		BulletDeadReckoningMaxRange = 159,
		BulletDeadReckoningMinimumSpeed = 160,
		BulletMagnetismDefaultAngle = 161,
		BulletMagnetismHighVelocityAngle = 162,
		BulletPseudoPierceHitVFxChance = 163,
		BulletSurroundingHitVFxChance = 164,
		BurningApplicationRate = 165,
		BurningApplicationRateModifierHelper = 166,
		BurningImmunity = 167,
		BurningRegenStamina = 168,
		CPUPower = 169,
		CWMaskCharges = 170,
		CWMaskChargesDecayStartDelay = 171,
		CWMaskChargesDelayOnChange = 172,
		CWMaskChargesRegenBegins = 173,
		CWMaskChargesRegenEnabled = 174,
		CWMaskChargesRegenEnds = 175,
		CWMaskChargesRegenRate = 176,
		CWMaskMaxCharges = 177,
		CWMaskRechargeDuration = 178,
		CallReinforcement = 179,
		CameraDetectionSpeedReduction = 180,
		CameraShutdownExtension = 181,
		CanAerialTakedown = 182,
		CanAimWhileDodging = 183,
		CanAskToFollowOrder = 184,
		CanAskToHolsterWeapon = 185,
		CanAutomaticallyDisassembleJunk = 186,
		CanAutomaticallyRestoreKnives = 187,
		CanBleedingCriticallyHit = 188,
		CanBleedingSlowTarget = 189,
		CanBlindQuickHack = 190,
		CanBlock = 191,
		CanBreatheUnderwater = 192,
		CanBuffCamoQuickHack = 193,
		CanBuffMechanicalsOnTakeControl = 194,
		CanBuffSturdinessQuickHack = 195,
		CanBurningCriticallyHit = 196,
		CanCallDrones = 197,
		CanCallReinforcements = 198,
		CanCatchUp = 199,
		CanCatchUpDistance = 200,
		CanCharge = 201,
		CanChargedShoot = 202,
		CanCloseCombat = 203,
		CanCommsCallInQuickHack = 204,
		CanCommsNoiseQuickHack = 205,
		CanControlFullyChargedWeapon = 206,
		CanCraftEpicItems = 207,
		CanCraftFromInventory = 208,
		CanCraftLegendaryItems = 209,
		CanCraftRareItems = 210,
		CanCraftTechAmmunition = 211,
		CanCrouch = 212,
		CanCyberwareMalfunctionQuickHack = 213,
		CanDash = 214,
		CanDataMineQuickHack = 215,
		CanDealFullDamageToArmored = 216,
		CanDeathQuickHack = 217,
		CanDisassemble = 218,
		CanDisassembleConsumables = 219,
		CanDisassembleGadgets = 220,
		CanDoGrandFinaleWithMantisBlades = 221,
		CanDoRapidFireWithProjectileLauncher = 222,
		CanDropWeapon = 223,
		CanElectrocuteNullifyStats = 224,
		CanElectrocuteRoot = 225,
		CanExitWSOnSoundStimuli = 226,
		CanExplodeQuickHack = 227,
		CanFastTravelWhileEncumbered = 228,
		CanFistsCauseBleeding = 229,
		CanForceDismbember = 230,
		CanFullyChargeWeapon = 231,
		CanGrab = 232,
		CanGrappleAndroids = 233,
		CanGrappleSilently = 234,
		CanGrenadeLaunch = 235,
		CanGrenadeQuickHack = 236,
		CanGrenadesCriticallyHit = 237,
		CanGrenadesDealExternalDamage = 238,
		CanGroundSlamInAir = 239,
		CanGroundSlamOnGround = 240,
		CanGuardBreak = 241,
		CanHeartattackQuickHack = 242,
		CanIgnoreArmorDamageReduction = 243,
		CanIgnoreStamina = 244,
		CanIgnoreWeaponStaminaPenaties = 245,
		CanInstaKillNPCs = 246,
		CanInstallTechMods = 247,
		CanJamWeaponLvl2QuickHack = 248,
		CanJamWeaponQuickHack = 249,
		CanJump = 250,
		CanLandSilently = 251,
		CanLegendaryCraftedWeaponsBeBoosted = 252,
		CanLegendaryCraftedWeaponsBeBoosted2 = 253,
		CanLocomotionMalfunctionQuickHack = 254,
		CanMadnessQuickHack = 255,
		CanMalfunctionQuickHack = 256,
		CanMeleeBerserk = 257,
		CanMeleeDash = 258,
		CanMeleeInfinitelyCombo = 259,
		CanMeleeLeap = 260,
		CanMeleeLeapInAir = 261,
		CanMeleeLeapTakedown = 262,
		CanMemoryWipeQuickHack = 263,
		CanOnePunchWithGorillaArms = 264,
		CanOverchargeWeapon = 265,
		CanOverheatQuickHack = 266,
		CanOverloadQuickHack = 267,
		CanOverrideAttitudeQuickHack = 268,
		CanOverrideAuthorizationQuickHack = 269,
		CanParry = 270,
		CanPerformBluntFinisher = 271,
		CanPerformCoolFinisher = 272,
		CanPerformMonowireFinisher = 273,
		CanPerformReflexFinisher = 274,
		CanPickUpBodyAfterTakedown = 275,
		CanPickUpWeapon = 276,
		CanPingQuickHack = 277,
		CanPlayerBoostConsumables = 278,
		CanPlayerBoostGrenades = 279,
		CanPlayerDodgeOnDetection = 280,
		CanPlayerExitCombatWithOpticalCamo = 281,
		CanPlayerGagOnDetection = 282,
		CanPlayerPierceDriver = 283,
		CanPlayerPiercePoisonImmunity = 284,
		CanPoisonLowerArmor = 285,
		CanPoisonSlow = 286,
		CanPreciseShoot = 287,
		CanPushBack = 288,
		CanPushFromGrapple = 289,
		CanQuickHackCriticallyHit = 290,
		CanQuickMeleeStagger = 291,
		CanQuickhack = 292,
		CanQuickhackHealPuppet = 293,
		CanQuickhackTransferBetweenEnemies = 294,
		CanRegenInCombat = 295,
		CanRemoveModsFromClothing = 296,
		CanRemoveModsFromWeapons = 297,
		CanResurrectAllies = 298,
		CanRetreat = 299,
		CanRetrieveModsFromDisassemble = 300,
		CanRunSilently = 301,
		CanSandevistanSprintHarass = 302,
		CanScrapPartsFromMechanicals = 303,
		CanSeeCyberwareBreaches = 304,
		CanSeeGrenadeRadius = 305,
		CanSeeRicochetVisuals = 306,
		CanSeeThroughOpticalCamos = 307,
		CanSeeThroughSmoke = 308,
		CanSeeThroughWalls = 309,
		CanShareThreatsWithPlayer = 310,
		CanShootWhileCarryingBody = 311,
		CanShootWhileDodging = 312,
		CanShootWhileGrappling = 313,
		CanShootWhileMoving = 314,
		CanShootWhileVaulting = 315,
		CanSilentKill = 316,
		CanSmartShoot = 317,
		CanSpreadMonoWireQuickhack = 318,
		CanSprint = 319,
		CanSprintHarass = 320,
		CanSprintWhileCarryingBody = 321,
		CanSuicideQuickHack = 322,
		CanSwitchWeapon = 323,
		CanTakeControlQuickHack = 324,
		CanTakedownLethally = 325,
		CanTakedownSilently = 326,
		CanTaunt = 327,
		CanThrowWeapon = 328,
		CanUpgradeFromInventory = 329,
		CanUpgradeToLegendaryQuality = 330,
		CanUseAntiStun = 331,
		CanUseBiohazardGrenades = 332,
		CanUseCloseRing = 333,
		CanUseCombatStims = 334,
		CanUseConsumables = 335,
		CanUseCoolingSystem = 336,
		CanUseCovers = 337,
		CanUseCuttingGrenades = 338,
		CanUseEMPGrenades = 339,
		CanUseExtremeRing = 340,
		CanUseFarRing = 341,
		CanUseFlashbangGrenades = 342,
		CanUseFragGrenades = 343,
		CanUseGrenades = 344,
		CanUseHolographicCamo = 345,
		CanUseIncendiaryGrenades = 346,
		CanUseLeftHand = 347,
		CanUseLegs = 348,
		CanUseMantisBlades = 349,
		CanUseMediumRing = 350,
		CanUseMeleeRing = 351,
		CanUseNewMeleewareAttackSpyTree = 352,
		CanUseOpticalCamo = 353,
		CanUseOverclock = 354,
		CanUsePainInhibitors = 355,
		CanUsePersonalSoundSilencer = 356,
		CanUsePhoneUnderWater = 357,
		CanUseProjectileLauncher = 358,
		CanUseReconGrenades = 359,
		CanUseRetractableShield = 360,
		CanUseRightHand = 361,
		CanUseShootingSpots = 362,
		CanUseSmokeGrenades = 363,
		CanUseStaticCamo = 364,
		CanUseStrongArms = 365,
		CanUseTakedowns = 366,
		CanUseTerrainCamo = 367,
		CanUseZoom = 368,
		CanWalkSilently = 369,
		CanWallStick = 370,
		CanWeaponBlock = 371,
		CanWeaponBlockAttack = 372,
		CanWeaponComboAttack = 373,
		CanWeaponCriticallyHit = 374,
		CanWeaponCrouchAttack = 375,
		CanWeaponDash = 376,
		CanWeaponDeflect = 377,
		CanWeaponIgnoreArmor = 378,
		CanWeaponInfinitlyCombo = 379,
		CanWeaponJumpAttack = 380,
		CanWeaponLeap = 381,
		CanWeaponMalfunctionQuickHack = 382,
		CanWeaponReload = 383,
		CanWeaponReloadWhileInactive = 384,
		CanWeaponReloadWhileSliding = 385,
		CanWeaponReloadWhileSprinting = 386,
		CanWeaponReloadWhileVaulting = 387,
		CanWeaponSafeAttack = 388,
		CanWeaponShoot = 389,
		CanWeaponShootWhileSliding = 390,
		CanWeaponShootWhileSprinting = 391,
		CanWeaponShootWhileVaulting = 392,
		CanWeaponSprintAttack = 393,
		CanWeaponStrongAttack = 394,
		CanWeaponTriggerHeadshot = 395,
		CannotBeDetectedWhileSubmerged = 396,
		CannotBeHealed = 397,
		CannotSprintHarass = 398,
		CapacityBoosterHumanity = 399,
		CarryCapacity = 400,
		CarryCapacityModifierHelper = 401,
		CausingPanicReducesUltimateHacksCost = 402,
		ChainswordStaminaCostReduction = 403,
		Charge = 404,
		ChargeBonus = 405,
		ChargeDischargeTime = 406,
		ChargeFullMultiplier = 407,
		ChargeMaxTimeInChargedState = 408,
		ChargeMinValueBonus = 409,
		ChargeMultiplier = 410,
		ChargeReadyPercentage = 411,
		ChargeShouldFireWhenReady = 412,
		ChargeTime = 413,
		ChemicalDamage = 414,
		ChemicalDamageAdditiveMultiplier = 415,
		ChemicalDamageMax = 416,
		ChemicalDamageMin = 417,
		ChemicalDamageModifierHelper = 418,
		ChemicalDamagePercent = 419,
		ChemicalDamagePercentBonus = 420,
		ChemicalDamagePercentBonusModifierHelper = 421,
		ChemicalResistance = 422,
		ChemicalResistanceModifierHelper = 423,
		ChimeraModInstalled = 424,
		ChingadaMadreBonanza = 425,
		ClimbSpeedModifier = 426,
		ClipTimesCycle = 427,
		ClipTimesCycleBase = 428,
		ClipTimesCyclePlusReload = 429,
		ClipTimesCyclePlusReloadBase = 430,
		CloudComputingTraps = 431,
		ColdBlood = 432,
		ColdBloodBuffBonus = 433,
		ColdBloodDurationReductor = 434,
		ColdBloodMastery = 435,
		ColdBloodMaxDuration = 436,
		ColdBloodMaxStacks = 437,
		ColdBloodTrait01 = 438,
		CombatHacking = 439,
		CombatHackingMastery = 440,
		CommonTierFailsafe = 441,
		CommsCallDistance = 442,
		CommsNoiseJamOnQuickhack = 443,
		ControlledRandomPower = 444,
		Cool = 445,
		CoolAllocated = 446,
		CoolAvailable = 447,
		CoolOpticalDuration = 448,
		CoolSkill = 449,
		Cool_Inbetween_Right_3_Stacks = 450,
		CounterattackGuardbreakImmunity = 451,
		Crafting = 452,
		CraftingBonusArmorValue = 453,
		CraftingBonusArmorValue2 = 454,
		CraftingBonusGrenadeDamage = 455,
		CraftingBonusWeaponDamage = 456,
		CraftingBonusWeaponDamage2 = 457,
		CraftingCostReduction = 458,
		CraftingItemLevelBoost = 459,
		CraftingMastery = 460,
		CraftingMaterialDropChance = 461,
		CraftingMaterialRandomGrantChance = 462,
		CraftingMaterialRetrieveChance = 463,
		CraftingTrait01 = 464,
		CritChance = 465,
		CritChanceBonus = 466,
		CritChanceBonusModifierHelper = 467,
		CritChanceModifierHelper = 468,
		CritChanceTimeCritDamage = 469,
		CritDPSBonus = 470,
		CritDamage = 471,
		CritDamageBonus = 472,
		CritDamageBonusModifierHelper = 473,
		CritDamageModifierHelper = 474,
		CrouchSprintStaminaCostReduction = 475,
		CyberWareMalfunctionBlocked = 476,
		CyberWareMalfunctionBlockedMaxStacks = 477,
		CyberWareMalfunctionDoT = 478,
		CyberdeckOverclockCooldown = 479,
		CyberdeckOverclockDecayRate = 480,
		CyberdeckOverclockDecayStartDelay = 481,
		CyberdeckOverclockDelayOnChange = 482,
		CyberdeckOverclockDuration = 483,
		CyberdeckOverclockEmptyStat = 484,
		CyberdeckOverclockRegenBegins = 485,
		CyberdeckOverclockRegenEnabled = 486,
		CyberdeckOverclockRegenEnds = 487,
		CyberdeckOverclockRegenRate = 488,
		CyberdeckOverclockStatValue = 489,
		CyberwareCooldownReduction = 490,
		CyberwareDurationBuff = 491,
		CyberwareMalfunctionCanExplode = 492,
		CyberwareMalfunctionDamageMultiplier = 493,
		CyberwareMalfunctionStacks = 494,
		CyberwareRechargeSpeedBonus = 495,
		CyberwareTinkererStat = 496,
		CycleTime = 497,
		CycleTimeAimBlockDuration = 498,
		CycleTimeAimBlockStart = 499,
		CycleTimeBase = 500,
		CycleTimeBonus = 501,
		CycleTimeDPSComponent = 502,
		CycleTimeShootingMult = 503,
		CycleTimeShootingMultPeriod = 504,
		CycleTime_Burst = 505,
		CycleTime_BurstMaxCharge = 506,
		CycleTime_BurstSecondary = 507,
		CycleTriggerModeTime = 508,
		DPS = 509,
		DamageFalloffDisabled = 510,
		DamageHackSpread = 511,
		DamageOverTimePercentBonus = 512,
		DamageOverTimePercentBonusModifierHelper = 513,
		DamageOverTimeResistance = 514,
		DamageOverTimeResistanceModifierHelper = 515,
		DamagePerHit = 516,
		DamageQuickHackMemoryCostReduction = 517,
		DamageReduction = 518,
		DamageReductionBulletExplosion = 519,
		DamageReductionDamageOverTime = 520,
		DamageReductionExplosion = 521,
		DamageReductionMelee = 522,
		DamageReductionQuickhacks = 523,
		DashAttackStaminaCostReduction = 524,
		DataLeakTraps = 525,
		DealsChemicalDamage = 526,
		DealsElectricDamage = 527,
		DealsPhysicalDamage = 528,
		DealsThermalDamage = 529,
		Deceleration = 530,
		DefeatedHeadDamageThreshold = 531,
		DefeatedLArmDamageThreshold = 532,
		DefeatedLLegDamageThreshold = 533,
		DefeatedRArmDamageThreshold = 534,
		DefeatedRLegDamageThreshold = 535,
		DefeatingEnemiesReduceHacksCost = 536,
		Demolition = 537,
		DemolitionMastery = 538,
		DemolitionTrait01Stat = 539,
		Detection = 540,
		DetectionSpeedDecrease = 541,
		DeviceMemoryCostReduction = 542,
		DeviceMemoryCostReductionMult = 543,
		DisableCyberwareOnBurning = 544,
		DisassemblingIngredientsDoubleBonus = 545,
		DisassemblingMaterialQualityObtainChance = 546,
		DismHeadDamageThreshold = 547,
		DismLArmDamageThreshold = 548,
		DismLLegDamageThreshold = 549,
		DismRArmDamageThreshold = 550,
		DismRLegDamageThreshold = 551,
		DoNotCheckFriendlyFireMadnessPassive = 552,
		DodgeStaminaCostReduction = 553,
		DodgeStaminaCostReductionModifierHelper = 554,
		DriverUpdatePerkFlag = 555,
		DualShotgunStaminaCostReduction = 556,
		DummyModCritDamage = 557,
		DummyResistanceStat = 558,
		Durability = 559,
		DurationBonusBleeding = 560,
		DurationBonusBurning = 561,
		DurationBonusControlQuickhack = 562,
		DurationBonusCovertQuickhack = 563,
		DurationBonusElectrified = 564,
		DurationBonusOverclock = 565,
		DurationBonusPoisoned = 566,
		DurationBonusQuickhack = 567,
		DurationBonusQuickhackModifierHelper = 568,
		DurationBonusStun = 569,
		DurationReductionDot = 570,
		EMPImmunity = 571,
		EdgerunnerHealthReduction = 572,
		EffectiveChargeTime = 573,
		EffectiveDPS = 574,
		EffectiveDamagePerHit = 575,
		EffectiveDamagePerHitMax = 576,
		EffectiveDamagePerHitMin = 577,
		EffectiveDamagePerHitTimesAttacksPerSecond = 578,
		EffectiveQualityToMaxQualityRatio = 579,
		EffectiveRange = 580,
		EffectiveRangeBonus = 581,
		EffectiveTier = 582,
		EffectorChance = 583,
		ElectricDamage = 584,
		ElectricDamageAdditiveMultiplier = 585,
		ElectricDamageMax = 586,
		ElectricDamageMin = 587,
		ElectricDamageModifierHelper = 588,
		ElectricDamagePercent = 589,
		ElectricDamagePercentBonus = 590,
		ElectricDamagePercentBonusModifierHelper = 591,
		ElectricResistance = 592,
		ElectricResistanceModifierHelper = 593,
		ElectrocuteImmunity = 594,
		ElectrocutedApplicationRate = 595,
		ElectrocutedApplicationRateModifierHelper = 596,
		ElectroshockMechanismProcChance = 597,
		ElementalDamagePerHit = 598,
		ElementalResistanceMultiplier = 599,
		EmptyReloadEndTime = 600,
		EmptyReloadTime = 601,
		EmptySlot_GenerationWeight_On_TierPlus = 602,
		EmptyStat = 603,
		EnemyChemicalResistanceReduction = 604,
		EnemyHackUploadProgressBumpMultiplier = 605,
		EnemyQuickHackUploadDurationBonus = 606,
		Engineering = 607,
		EngineeringMastery = 608,
		EngineeringTrait01 = 609,
		EquipActionDuration_Corpo = 610,
		EquipActionDuration_Gang = 611,
		EquipAnimationDuration_Corpo = 612,
		EquipAnimationDuration_Gang = 613,
		EquipDuration = 614,
		EquipDuration_First = 615,
		EquipItemTime_Corpo = 616,
		EquipItemTime_Gang = 617,
		Espionage = 618,
		EvadeImpulse = 619,
		Evasion = 620,
		ExecuteDismemberByHealthChance = 621,
		ExecuteDismemberProximityChance = 622,
		ExhaustionImmunity = 623,
		ExplosionDamagePercentBonus = 624,
		ExplosionDamagePercentBonusModifierHelper = 625,
		ExplosionKillsRecudeUltimateHacksCost = 626,
		ExplosionResistance = 627,
		ExplosionResistanceModifierHelper = 628,
		ExtendedStealthDuration = 629,
		FFInputLock = 630,
		FallDamageReduction = 631,
		FearOnQuickHackKill = 632,
		FinisherHealthThresholdIncrease = 633,
		FinisherHealthThresholdIncreaseForQueue = 634,
		FinisherIsAvailable = 635,
		Finisher_TargetHealthMax_Clamp = 636,
		FirePower = 637,
		FirePowerBonus = 638,
		FirstHackInQueueUploadTimeDecrease = 639,
		FirstHackOfTypeInQueueRAMDecrease = 640,
		FistsStaminaCostReduction = 641,
		FocusedGrenadeShootingPerk = 642,
		ForcePreventResurrect = 643,
		ForceQualityHelper = 644,
		FullAutoOnFullCharge = 645,
		FullAutoStaminaCostPenalty = 646,
		FullyChargedThreshold = 647,
		GearheadDamageMultiplier = 648,
		GenericMod1_Damage = 649,
		GenericStatPrereqValue = 650,
		GrenadeDamagePercentBonus = 651,
		GrenadeDamagePercentBonusModifierHelper = 652,
		GrenadeExplosionBonusDamage = 653,
		GrenadeExplosionBonusRange = 654,
		GrenadesCharges = 655,
		GrenadesChargesDecayStartDelay = 656,
		GrenadesChargesDelayOnChange = 657,
		GrenadesChargesRegenBegins = 658,
		GrenadesChargesRegenEnabled = 659,
		GrenadesChargesRegenEnds = 660,
		GrenadesChargesRegenMult = 661,
		GrenadesChargesRegenMultModifierHelper = 662,
		GrenadesChargesRegenRate = 663,
		GrenadesMaxCharges = 664,
		GrenadesRechargeDuration = 665,
		GroundSlamCooldownModifier = 666,
		Gunslinger = 667,
		GunslingerMastery = 668,
		GunslingerTrait01Stat = 669,
		HGMod1_Accuracy = 670,
		HGMod1_CommonStacks = 671,
		HGMod1_EpicStacks = 672,
		HGMod1_LegendaryStacks = 673,
		HGMod1_ModCount = 674,
		HGMod1_RareStacks = 675,
		HGMod1_StackCount = 676,
		HGMod1_UncommonStacks = 677,
		HGMod2_CritChance = 678,
		HGMod2_Spread = 679,
		HGMod2_Swap = 680,
		HGMod3_Sway = 681,
		HackRevealPositionModifier = 682,
		HackedEnemiesGetDamagedByFriendlyFire = 683,
		HackedEnemyArmorReduction = 684,
		Hacking = 685,
		HackingMastery = 686,
		HackingPenetration = 687,
		HackingResistance = 688,
		HackingResistanceUltimate = 689,
		HandgunStaminaCostReduction = 690,
		Handling = 691,
		HasAdditionalSplinterSlot = 692,
		HasAheadTargeting = 693,
		HasAirHover = 694,
		HasAirThrusters = 695,
		HasAutoReloader = 696,
		HasAutomaticReplenishment = 697,
		HasAutomaticTagging = 698,
		HasBerserk = 699,
		HasBleedImmunity = 700,
		HasBlindImmunity = 701,
		HasBoostedCortex = 702,
		HasBurningBuffs = 703,
		HasCameraLinking = 704,
		HasChargeJump = 705,
		HasCritImmunity = 706,
		HasCyberdeck = 707,
		HasCybereye = 708,
		HasDodge = 709,
		HasDodgeAir = 710,
		HasDoubleJump = 711,
		HasElectricCoating = 712,
		HasElectroPlating = 713,
		HasExtendedHitReactionImmunity = 714,
		HasFireproofSkin = 715,
		HasGPS = 716,
		HasGlowingTattoos = 717,
		HasGraphiteTissue = 718,
		HasGrenadeHack = 719,
		HasHackingInteractions = 720,
		HasHealingReapplication = 721,
		HasHealthMonitorBomb = 722,
		HasHostileHackImmunity = 723,
		HasICELevelBooster = 724,
		HasImmunityToNPCQuickhacks = 725,
		HasInfravision = 726,
		HasJuiceInjector = 727,
		HasKerenzikov = 728,
		HasKerenzikovOmen = 729,
		HasKerenzikovSlide = 730,
		HasKers = 731,
		HasKiroshiOpticsFragment = 732,
		HasKnifeSharpener = 733,
		HasLinkToBountySystem = 734,
		HasLoweringPerception = 735,
		HasMadnessLvl4Passive = 736,
		HasMajorQuickhackResistance = 737,
		HasMechanicalControl = 738,
		HasMeleeHitReactionAndTakedownResistance = 739,
		HasMeleeTargeting = 740,
		HasMetabolicEnhancer = 741,
		HasMuzzleBrake = 742,
		HasOpticalCamoEpic = 743,
		HasOpticalCamoLegendary = 744,
		HasOpticalCamoRare = 745,
		HasPlatingGlitch = 746,
		HasPoisonHeal = 747,
		HasPoisonImmunity = 748,
		HasPowerGrip = 749,
		HasQuickhackResistance = 750,
		HasRemoteBotAccessPointBreach = 751,
		HasSandevistan = 752,
		HasSandevistanTier1 = 753,
		HasSandevistanTier2 = 754,
		HasSandevistanTier3 = 755,
		HasSecondHeart = 756,
		HasSelfHealingSkin = 757,
		HasSmartLink = 758,
		HasSpiderBotControl = 759,
		HasStunImmunity = 760,
		HasSubdermalArmor = 761,
		HasSuperheroFall = 762,
		HasSystemCollapse = 763,
		HasThermovision = 764,
		HasTimedImmunity = 765,
		HasToxicCleanser = 766,
		HasWallRunSkill = 767,
		HeadshotCritChance = 768,
		HeadshotDamageMultiplier = 769,
		HeadshotDamageMultiplierModifierHelper = 770,
		HeadshotImmunity = 771,
		HealOnKillingBleedingTarget = 772,
		HealOnKillingBleedingTargetModifierHelper = 773,
		HealingItemMaxCharges = 774,
		HealingItemsCharges = 775,
		HealingItemsChargesDecayStartDelay = 776,
		HealingItemsChargesDelayOnChange = 777,
		HealingItemsChargesRegenBegins = 778,
		HealingItemsChargesRegenEnabled = 779,
		HealingItemsChargesRegenEnds = 780,
		HealingItemsChargesRegenMult = 781,
		HealingItemsChargesRegenMultModifierHelper = 782,
		HealingItemsChargesRegenRate = 783,
		HealingItemsEffectPercentBonus = 784,
		HealingItemsEffectPercentBonusModifierHelper = 785,
		HealingItemsRechargeDuration = 786,
		Health = 787,
		HealthBonusBlackmarket = 788,
		HealthGeneralRegenRateAdd = 789,
		HealthGeneralRegenRateAddModifierHelper = 790,
		HealthGeneralRegenRateMult = 791,
		HealthGeneralRegenRateMultModifierHelper = 792,
		HealthInCombatRegenDelayOnChange = 793,
		HealthInCombatRegenEnabled = 794,
		HealthInCombatRegenEndThreshold = 795,
		HealthInCombatRegenRate = 796,
		HealthInCombatRegenRateAdd = 797,
		HealthInCombatRegenRateBase = 798,
		HealthInCombatRegenRateMult = 799,
		HealthInCombatRegenStartThreshold = 800,
		HealthInCombatStartDelay = 801,
		HealthModifierHelper = 802,
		HealthOutOfCombatRegenDelayOnChange = 803,
		HealthOutOfCombatRegenEnabled = 804,
		HealthOutOfCombatRegenEndThreshold = 805,
		HealthOutOfCombatRegenRate = 806,
		HealthOutOfCombatRegenRateAdd = 807,
		HealthOutOfCombatRegenRateBase = 808,
		HealthOutOfCombatRegenRateMult = 809,
		HealthOutOfCombatRegenStartThreshold = 810,
		HealthRegainOnKill = 811,
		HealthRegainOnKillModifierHelper = 812,
		Hearing = 813,
		HeavyAttacksNumber = 814,
		HiddenSlot_GenerationWeight_On_TierPlus = 815,
		HighlightAccessPoint = 816,
		HitDismembermentFactor = 817,
		HitReactionDamageHealthFactor = 818,
		HitReactionFactor = 819,
		HitShapeArmor = 820,
		HitTimerAfterDefeated = 821,
		HitTimerAfterImpact = 822,
		HitTimerAfterImpactMelee = 823,
		HitTimerAfterKnockdown = 824,
		HitTimerAfterPain = 825,
		HitTimerAfterStagger = 826,
		HitTimerAfterStaggerMelee = 827,
		HitWoundsFactor = 828,
		HoldDuration = 829,
		HoldEnterDuration = 830,
		HoldTimeoutDuration = 831,
		HolographicSkinCooldownDuration = 832,
		HolographicSkinDuration = 833,
		HousingBuffsDurationBonus = 834,
		Humanity = 835,
		HumanityAllocated = 836,
		HumanityAvailable = 837,
		HumanityOverallocated = 838,
		HumanityOverallocationPossible = 839,
		HumanityTotalMaxValue = 840,
		IconicCWFromTreasureChestLooted = 841,
		IconicItemUpgraded = 842,
		IconicJointLockCover = 843,
		IgnoreAwarenessCostWhenOverclocked = 844,
		ImpactDamageThreshold = 845,
		ImpactDamageThresholdImpulse = 846,
		ImpactDamageThresholdInCover = 847,
		InVehicleDamageTakenPercent = 848,
		InhalerBaseHealing = 849,
		InjectorBaseHealing = 850,
		InjectorBaseOverTheTimeHealing = 851,
		InjectorHealingDecayStartDelay = 852,
		InjectorHealingDelayOnChange = 853,
		InjectorHealingRegenBegins = 854,
		InjectorHealingRegenEnabled = 855,
		InjectorHealingRegenEnds = 856,
		Intelligence = 857,
		IntelligenceAllocated = 858,
		IntelligenceAvailable = 859,
		IntelligenceSkill = 860,
		IntelligenceSkillcheckBonus = 861,
		IntrinsicQuickHackUploadBonus = 862,
		IntrinsicReloadTimeBonus = 863,
		IntrinsicZoomLevelBonus = 864,
		IsAVMaxTac = 865,
		IsAggressive = 866,
		IsAimingWithWeapon = 867,
		IsBalanced = 868,
		IsBlocking = 869,
		IsCautious = 870,
		IsCrowd = 871,
		IsDefensive = 872,
		IsDeflecting = 873,
		IsDodgeStaminaFree = 874,
		IsDodging = 875,
		IsExcludedFromExtraHealingOnHigherDifficulties = 876,
		IsExo = 877,
		IsFastMeleeArchetype = 878,
		IsFastRangedArchetype = 879,
		IsGenericMeleeArchetype = 880,
		IsGenericRangedArchetype = 881,
		IsHealingItemEquipped = 882,
		IsHeavyRangedArchetype = 883,
		IsIgnoredByEnemyNPC = 884,
		IsInvulnerable = 885,
		IsItemBroken = 886,
		IsItemCracked = 887,
		IsItemCrafted = 888,
		IsItemIconic = 889,
		IsItemPlus = 890,
		IsItemUpgraded = 891,
		IsMainBoss = 892,
		IsManBig = 893,
		IsManMassive = 894,
		IsMechanical = 895,
		IsNetrunnerArchetype = 896,
		IsNotSlowedDuringADS = 897,
		IsNotSlowedDuringBlock = 898,
		IsNotSlowedDuringReload = 899,
		IsPlayerGuardian = 900,
		IsReckless = 901,
		IsShotgunnerArchetype = 902,
		IsSniperArchetype = 903,
		IsSprintStaminaFree = 904,
		IsStrongMeleeArchetype = 905,
		IsTechieArchetype = 906,
		IsTier1Archetype = 907,
		IsTier2Archetype = 908,
		IsTier3Archetype = 909,
		IsTier4Archetype = 910,
		IsWeakspot = 911,
		IsWeaponLethal = 912,
		ItemArmor = 913,
		ItemArmorModifierHelper = 914,
		ItemLevel = 915,
		ItemPlusDPS = 916,
		ItemPurchasedAtVendor = 917,
		ItemRequiresElectroPlating = 918,
		ItemRequiresPowerGrip = 919,
		ItemRequiresSmartLink = 920,
		JenkinsHelper = 921,
		JenkinsHelperDecayEnabled = 922,
		JenkinsHelperDecayPerSecond = 923,
		JenkinsHelperEmptyStat = 924,
		JenkinsHelperRegenEnabled = 925,
		JenkinsHelperRegenPerSecond = 926,
		JumpHeight = 927,
		JumpSpeedModifier = 928,
		KatanaStaminaCostReduction = 929,
		Kenjutsu = 930,
		KenjutsuMastery = 931,
		KenjutsuTrait01Stat = 932,
		KerenzikovCooldownDuration = 933,
		KiroshiMaxZoomLevel = 934,
		KiroshiPierceScanAngle = 935,
		KiroshiPierceScanRange = 936,
		KnifeStaminaCostReduction = 937,
		KnockdownDamageThreshold = 938,
		KnockdownDamageThresholdImpulse = 939,
		KnockdownDamageThresholdInCover = 940,
		KnockdownImmunity = 941,
		KnockdownImpulse = 942,
		Level = 943,
		Liberty_Padre_BurningApplicationRate = 944,
		LightMachinegunStaminaCostReduction = 945,
		LimbHealth = 946,
		LinearDirectionUpdateMax = 947,
		LinearDirectionUpdateMaxADS = 948,
		LinearDirectionUpdateMin = 949,
		LinearDirectionUpdateMinADS = 950,
		LocomotionExperienceReward = 951,
		LocomotionPenaltyDisabled = 952,
		LootLevel = 953,
		LowerActiveCooldownOnDefeat = 954,
		LowerHackingResistanceOnHack = 955,
		MacheteStaminaCostReduction = 956,
		MagazineAutoRefill = 957,
		MagazineCapacity = 958,
		MagazineCapacityBase = 959,
		MagazineCapacityBonus = 960,
		MagazineCapacityDPSComponent = 961,
		ManiacPerkBonusSpeed = 962,
		ManiacStatCounter = 963,
		MantisBladesStaminaCostReduction = 964,
		MaxDuration = 965,
		MaxPercentDamageTakenPerHit = 966,
		MaxQuality = 967,
		MaxQualityWhenLooted = 968,
		MaxSpeed = 969,
		MaxSpeedModifierHelper = 970,
		MaxStacks = 971,
		MaxStacksBonusBleeding = 972,
		MaxStacksBonusBurning = 973,
		MaximumRange = 974,
		MechResistance = 975,
		MechResistanceModifierHelper = 976,
		MechanicalsBuffDPSBonus = 977,
		MeleeAttackComboDuration = 978,
		MeleeAttackDuration = 979,
		MeleeBorgStaminaDrain = 980,
		MeleeDamagePercentBonus = 981,
		MeleeDamagePercentBonusModifierHelper = 982,
		MeleeMod1_CritChance = 983,
		MeleeMod1_CritDamage = 984,
		MeleeMod2_Duration = 985,
		MeleeMod2_Stacks = 986,
		MeleeMod3_CritChance = 987,
		MeleeMod3_CritDamage = 988,
		MeleeProjectileGravitySimulationMultiplier = 989,
		MeleeResistance = 990,
		MeleeResistanceModifierHelper = 991,
		Memory = 992,
		MemoryCostModifier = 993,
		MemoryCostReduction = 994,
		MemoryRegenBonusBlackmarket = 995,
		MemoryRegenDelayOnChange = 996,
		MemoryRegenEnabled = 997,
		MemoryRegenEndThreshold = 998,
		MemoryRegenRate = 999,
		MemoryRegenRateAdd = 1000,
		MemoryRegenRateBase = 1001,
		MemoryRegenRateMult = 1002,
		MemoryRegenStartThreshold = 1003,
		MemoryStartDelay = 1004,
		MemoryTrackerCooldownDuration = 1005,
		MemoryWipeImmunity = 1006,
		MicroGeneratorExplosionDamage = 1007,
		MinCharge = 1008,
		MinSpeed = 1009,
		MinigameBufferExtension = 1010,
		MinigameMaterialsEarned = 1011,
		MinigameMemoryRegenPerk = 1012,
		MinigameMoneyMultiplier = 1013,
		MinigameNextInstanceBufferExtensionPerk = 1014,
		MinigameShardChanceMultiplier = 1015,
		MinigameTimeLimitExtension = 1016,
		MinigameTrapsPossibilityChance = 1017,
		MitigationChance = 1018,
		MitigationChanceModifierHelper = 1019,
		MitigationStrength = 1020,
		MitigationStrengthModifierHelper = 1021,
		ModifierPower = 1022,
		ModifierPowerBase = 1023,
		ModsAmountInGenerationPool = 1024,
		MonoWiresStaminaCostReduction = 1025,
		MultiKill_Counter = 1026,
		MuzzleBreakRicochetBonus = 1027,
		NPCAnimationTime = 1028,
		NPCCorpoEquipItemDuration = 1029,
		NPCCorpoUnequipItemDuration = 1030,
		NPCDamage = 1031,
		NPCDoTDPS = 1032,
		NPCEquipItemDuration = 1033,
		NPCGangEquipItemDuration = 1034,
		NPCGangUnequipItemDuration = 1035,
		NPCLoopDuration = 1036,
		NPCLootLevelHelper = 1037,
		NPCRarity = 1038,
		NPCRecoverDuration = 1039,
		NPCStartupDuration = 1040,
		NPCThrowImmunity = 1041,
		NPCUnequipItemDuration = 1042,
		NPCUploadTime = 1043,
		NPCWeaponDropHelper = 1044,
		NPCWeaponDropRandomizer = 1045,
		NewPerkFinisherBlunt_TargetDistanceMax = 1046,
		NewPerkFinisherBlunt_TargetHealthMax = 1047,
		NewPerkFinisherCool_TargetDistanceMax = 1048,
		NewPerkFinisherCool_TargetHealthMax = 1049,
		NewPerkFinisherMonowire_TargetDistanceMax = 1050,
		NewPerkFinisherMonowire_TargetHealthMax = 1051,
		NewPerkFinisherReflexes_TargetDistanceMax = 1052,
		NewPerkFinisherReflexes_TargetHealthMax = 1053,
		NoJam = 1054,
		NumShotsInBurst = 1055,
		NumShotsInBurstMaxCharge = 1056,
		NumShotsInBurstSecondary = 1057,
		NumShotsToFire = 1058,
		NumberIgnoredTraps = 1059,
		OccupiedSlot_GenerationWeight_On_TierPlus = 1060,
		OnBikeDamageTakenPercent = 1061,
		OnBikeDamageTakenPercentMaxSpeed = 1062,
		OnBikeDamageTakenPercentMinSpeed = 1063,
		OnRevealHackProgressIncrement = 1064,
		OneHandBladeStaminaCostReduction = 1065,
		OneHandBluntStaminaCostReduction = 1066,
		OpticalCamoCharges = 1067,
		OpticalCamoChargesDecayRate = 1068,
		OpticalCamoChargesDecayRateMult = 1069,
		OpticalCamoChargesDecayStartDelay = 1070,
		OpticalCamoChargesDelayOnChange = 1071,
		OpticalCamoChargesRegenBegins = 1072,
		OpticalCamoChargesRegenEnabled = 1073,
		OpticalCamoChargesRegenEnds = 1074,
		OpticalCamoChargesRegenRate = 1075,
		OpticalCamoDuration = 1076,
		OpticalCamoDurationMultiplier = 1077,
		OpticalCamoEmptyStat = 1078,
		OpticalCamoIsActive = 1079,
		OpticalCamoRechargeDuration = 1080,
		OverchargeThreshold = 1081,
		OverclockSpreadChance = 1082,
		OverclockedStateHealthCost = 1083,
		Overheat = 1084,
		OverheatDurationIncrease = 1085,
		Overshield = 1086,
		OvershieldDecayDelayOnChange = 1087,
		OvershieldDecayEnabled = 1088,
		OvershieldDecayEndThrehold = 1089,
		OvershieldDecayRate = 1090,
		OvershieldDecayStartDelay = 1091,
		OvershieldDecayStartThreshold = 1092,
		OvershieldDelayOnChange = 1093,
		OvershieldGainedToHealAmountMultiplier = 1094,
		Oxygen = 1095,
		PRSRMod2_CommonCount = 1096,
		PRSRMod2_CommonStacks = 1097,
		PRSRMod2_EpicCount = 1098,
		PRSRMod2_EpicStacks = 1099,
		PRSRMod2_Handling = 1100,
		PRSRMod2_KillCount = 1101,
		PRSRMod2_LegendaryCount = 1102,
		PRSRMod2_LegendaryStacks = 1103,
		PRSRMod2_RareCount = 1104,
		PRSRMod2_RareStacks = 1105,
		PRSRMod2_Stacks = 1106,
		PRSRMod2_UncommonCount = 1107,
		PRSRMod2_UncommonStacks = 1108,
		PainEditorDamageReduction = 1109,
		PartArmor = 1110,
		PenetrationHealth = 1111,
		PercentDamageReductionFromPoisonedEnemies = 1112,
		PercentDamageReductionFromPoisonedEnemiesModifierHelper = 1113,
		PerfectChargeTimeWindowIncrease = 1114,
		PerfectChargeWindow = 1115,
		PersonalityAggressive = 1116,
		PersonalityCuriosity = 1117,
		PersonalityDisgust = 1118,
		PersonalityFear = 1119,
		PersonalityFunny = 1120,
		PersonalityJoy = 1121,
		PersonalitySad = 1122,
		PersonalityShock = 1123,
		PersonalitySurprise = 1124,
		PhoneCallDuration = 1125,
		PhysicalDamage = 1126,
		PhysicalDamageAdditiveMultiplier = 1127,
		PhysicalDamageMax = 1128,
		PhysicalDamageMin = 1129,
		PhysicalDamageModifierHelper = 1130,
		PhysicalDamagePercent = 1131,
		PhysicalImpulse = 1132,
		PhysicalResistance = 1133,
		PlayerCorruptedSandevistanChargesDecayEnabled = 1134,
		PlayerOnRevealHackProgressMultiplier = 1135,
		PlayerSandevistanChargesDecayEnabled = 1136,
		PlayerSandevistanChargesDecayPerSecond = 1137,
		PlayerSandevistanChargesEmptyStat = 1138,
		Poise = 1139,
		PoisonImmunity = 1140,
		PoisonRegenHealth = 1141,
		PoisonedApplicationRate = 1142,
		PoisonedApplicationRateModifierHelper = 1143,
		PostLexWilsonBuyPrice = 1144,
		PostTutorialCyberwarePrice = 1145,
		PowerLevel = 1146,
		PowerMod1_DamageConvert = 1147,
		PowerMod2_StaminaCost = 1148,
		PreFireTime = 1149,
		PrecisionRifleStaminaCostReduction = 1150,
		PrefersCovers = 1151,
		PrefersShootingSpots = 1152,
		PreventQuickhackStaggerDuration = 1153,
		PreventQuickhacking = 1154,
		Price = 1155,
		ProjectileLauncherCharges = 1156,
		ProjectileLauncherChargesDecayStartDelay = 1157,
		ProjectileLauncherChargesDelayOnChange = 1158,
		ProjectileLauncherChargesRegenBegins = 1159,
		ProjectileLauncherChargesRegenEnds = 1160,
		ProjectileLauncherChargesRegenMult = 1161,
		ProjectileLauncherChargesRegenRate = 1162,
		ProjectileLauncherMaxCharges = 1163,
		ProjectileLauncherQualityMult = 1164,
		ProjectileLauncherRechargeDuration = 1165,
		ProjectileLauncherRegenEnabled = 1166,
		ProjectilesPerShot = 1167,
		ProjectilesPerShotBase = 1168,
		ProjectilesPerShotBonus = 1169,
		Protection = 1170,
		Quality = 1171,
		QualityRequirementMetFlag = 1172,
		QualityToMaxQualityRatio = 1173,
		Quantity = 1174,
		QuickHackBlackWallSpreadNumber = 1175,
		QuickHackBlindSpreadNumber = 1176,
		QuickHackContagionSpreadNumber = 1177,
		QuickHackCritChance = 1178,
		QuickHackDuration = 1179,
		QuickHackDurationExtension = 1180,
		QuickHackEffectsApplied = 1181,
		QuickHackImmunity = 1182,
		QuickHackOverclockSpreadNumber = 1183,
		QuickHackQueueCount = 1184,
		QuickHackQueueSize = 1185,
		QuickHackQueueUploadTimeDecrease = 1186,
		QuickHackResistancesMod = 1187,
		QuickHackSpreadDistance = 1188,
		QuickHackSpreadDistanceIncrease = 1189,
		QuickHackSpreadNumber = 1190,
		QuickHackSuddenDeathChance = 1191,
		QuickHackUpload = 1192,
		QuickHackUploadTimeDecrease = 1193,
		QuickhackDamageBonusMultiplier = 1194,
		QuickhackDamageOverTimeBonusMultiplier = 1195,
		QuickhackExtraDamageMultiplier = 1196,
		QuickhackResistance = 1197,
		QuickhackResistanceModifierHelper = 1198,
		QuickhackShield = 1199,
		QuickhacksCooldownReduction = 1200,
		QuickhacksCooldownReductionModifierHelper = 1201,
		RamManagerCooldownReduction = 1202,
		RamOnKill = 1203,
		RamOnKillModifierHelper = 1204,
		RandomCurveInput = 1205,
		Range = 1206,
		RangedMod1_CritChance = 1207,
		Recoil = 1208,
		RecoilAllowSway = 1209,
		RecoilAlternateDir = 1210,
		RecoilAlternateDirADS = 1211,
		RecoilAngle = 1212,
		RecoilAngleADS = 1213,
		RecoilAngleReduction = 1214,
		RecoilAnimation = 1215,
		RecoilChargeMult = 1216,
		RecoilChargeMultADS = 1217,
		RecoilCycleSize = 1218,
		RecoilCycleSizeADS = 1219,
		RecoilCycleTime = 1220,
		RecoilCycleTimeADS = 1221,
		RecoilDelay = 1222,
		RecoilDir = 1223,
		RecoilDirADS = 1224,
		RecoilDirPlanCycleRandDir = 1225,
		RecoilDirPlanCycleRandDirADS = 1226,
		RecoilDirPlanCycleRandRangeDir = 1227,
		RecoilDirPlanCycleRandRangeDirADS = 1228,
		RecoilDirPlanSequence = 1229,
		RecoilDirPlanSequenceADS = 1230,
		RecoilDirReduction = 1231,
		RecoilDriftRandomRangeMax = 1232,
		RecoilDriftRandomRangeMin = 1233,
		RecoilEnableCycleX = 1234,
		RecoilEnableCycleXADS = 1235,
		RecoilEnableCycleY = 1236,
		RecoilEnableCycleYADS = 1237,
		RecoilEnableLinearX = 1238,
		RecoilEnableLinearXADS = 1239,
		RecoilEnableLinearY = 1240,
		RecoilEnableLinearYADS = 1241,
		RecoilEnableScaleX = 1242,
		RecoilEnableScaleXADS = 1243,
		RecoilEnableScaleY = 1244,
		RecoilEnableScaleYADS = 1245,
		RecoilFullChargeMult = 1246,
		RecoilFullChargeMultADS = 1247,
		RecoilHoldDuration = 1248,
		RecoilHoldDurationADS = 1249,
		RecoilKickMax = 1250,
		RecoilKickMaxADS = 1251,
		RecoilKickMin = 1252,
		RecoilKickMinADS = 1253,
		RecoilKickReduction = 1254,
		RecoilMagForFullDrift = 1255,
		RecoilMaxLength = 1256,
		RecoilMaxLengthADS = 1257,
		RecoilPercentBonus = 1258,
		RecoilPercentBonusModifierHelper = 1259,
		RecoilRecoveryMinSpeed = 1260,
		RecoilRecoveryMinSpeedADS = 1261,
		RecoilRecoverySpeed = 1262,
		RecoilRecoverySpeedADS = 1263,
		RecoilRecoveryTime = 1264,
		RecoilRecoveryTimeADS = 1265,
		RecoilScaleMax = 1266,
		RecoilScaleMaxADS = 1267,
		RecoilScaleTime = 1268,
		RecoilScaleTimeADS = 1269,
		RecoilSpeed = 1270,
		RecoilSpeedADS = 1271,
		RecoilTime = 1272,
		RecoilTimeADS = 1273,
		RecoilUseDifferentStatsInADS = 1274,
		Reflexes = 1275,
		ReflexesAllocated = 1276,
		ReflexesAvailable = 1277,
		ReflexesSkill = 1278,
		Reflexes_Left_Milestone_3_Stack = 1279,
		Reflexes_Left_Milestone_3_StackDecrease = 1280,
		Reflexes_Left_Milestone_3_StackIncrease = 1281,
		Reflexes_Right_Milestone_2_StaminaDeflectPerc = 1282,
		Reflexes_Right_Milestone_2_StaminaReduction = 1283,
		RefreshesPingOnQuickhack = 1284,
		RegenerateHPMinigamePerk = 1285,
		ReloadAmount = 1286,
		ReloadEndTime = 1287,
		ReloadEndTimeBase = 1288,
		ReloadSpeedPercentBonus = 1289,
		ReloadSpeedPercentBonusModifierHelper = 1290,
		ReloadTime = 1291,
		ReloadTimeBase = 1292,
		ReloadTimeBonus = 1293,
		ReloadTimeDPSComponent = 1294,
		ReloadTimeExhaustionPenalty = 1295,
		RemoveAllStacksWhenDurationEnds = 1296,
		RemoveColdBloodStacksOneByOne = 1297,
		RemoveSprintOnQuickhack = 1298,
		ReprimandEscalation = 1299,
		RestoreMemoryOnDefeat = 1300,
		RevealNetrunnerWhenHacked = 1301,
		RevealPositionMaxDistance = 1302,
		RevolverStaminaCostReduction = 1303,
		RicochetChance = 1304,
		RicochetCount = 1305,
		RicochetMaxAngle = 1306,
		RicochetMinAngle = 1307,
		RicochetTargetSearchAngle = 1308,
		RoadWarriorDamageMultiplier = 1309,
		RollForPlusBelowMaxQuality = 1310,
		RollForPlusOnMaxQuality = 1311,
		SEApplicationRateBasedOnWeaponCharge = 1312,
		SandevistanChargesDecayDelayOnChange = 1313,
		SandevistanChargesDecayStartDelay = 1314,
		SandevistanChargesRegenBegins = 1315,
		SandevistanChargesRegenDelayOnChange = 1316,
		SandevistanChargesRegenEnabled = 1317,
		SandevistanChargesRegenEnds = 1318,
		SandevistanChargesRegenStartDelay = 1319,
		SandevistanDashShoot = 1320,
		SandevistanKillRechargeValue = 1321,
		SandevistanRechargeDuration = 1322,
		SasquatchStaminaDrain = 1323,
		ScalingBlocked = 1324,
		ScanDepth = 1325,
		ScanTimeReduction = 1326,
		ScopeFOV = 1327,
		ScopeOffset = 1328,
		ScrapItemChance = 1329,
		SecondHeartCooldownDuration = 1330,
		SecondaryModifiersAdditiveMultiplier = 1331,
		SharedCacheTraps = 1332,
		ShinyWeaponRoll = 1333,
		ShootingOffsetAI = 1334,
		ShortCircuitOnCriticalHit = 1335,
		ShortDistanceDamageIncrease = 1336,
		ShorterChains = 1337,
		ShotDelay = 1338,
		ShotgunMod1_BuffDuration = 1339,
		ShotgunMod1_DismemberBonus = 1340,
		ShotgunMod1_ModCount = 1341,
		ShotgunMod2_BulletCountLeftLeg = 1342,
		ShotgunMod2_BulletCountRightLeg = 1343,
		ShotgunMod2_ModCount = 1344,
		ShotgunMod3_Spread = 1345,
		ShotgunStaminaCostReduction = 1346,
		ShouldIgnoreSmartUI = 1347,
		SimpleWeaponMod04 = 1348,
		SkillBookExperience = 1349,
		SlideWhenLeaningOutOfCover = 1350,
		SmartGunAddSpiralTrajectory = 1351,
		SmartGunAdsLockingAnglePitch = 1352,
		SmartGunAdsLockingAngleYaw = 1353,
		SmartGunAdsMaxLockedTargets = 1354,
		SmartGunAdsTagLockAnglePitch = 1355,
		SmartGunAdsTagLockAngleYaw = 1356,
		SmartGunAdsTargetableAnglePitch = 1357,
		SmartGunAdsTargetableAngleYaw = 1358,
		SmartGunAdsTimeToLock = 1359,
		SmartGunAdsTimeToUnlock = 1360,
		SmartGunContinousLockEnabled = 1361,
		SmartGunDisableOnReload = 1362,
		SmartGunEvenDistributionPeriod = 1363,
		SmartGunHipLockingAnglePitch = 1364,
		SmartGunHipLockingAngleYaw = 1365,
		SmartGunHipMaxLockedTargets = 1366,
		SmartGunHipTagLockAnglePitch = 1367,
		SmartGunHipTagLockAngleYaw = 1368,
		SmartGunHipTargetableAnglePitch = 1369,
		SmartGunHipTargetableAngleYaw = 1370,
		SmartGunHipTimeToLock = 1371,
		SmartGunHipTimeToUnlock = 1372,
		SmartGunHitProbability = 1373,
		SmartGunHitProbabilityMultiplier = 1374,
		SmartGunKeepTargetsOnAimStateChange = 1375,
		SmartGunKeepTargetsOnWeaponSwap = 1376,
		SmartGunMaxLockedPointsPerTarget = 1377,
		SmartGunMissDelay = 1378,
		SmartGunMissRadius = 1379,
		SmartGunNPCApplySpreadAtHitplane = 1380,
		SmartGunNPCLockOnTime = 1381,
		SmartGunNPCLockTimeout = 1382,
		SmartGunNPCLockingAnglePitch = 1383,
		SmartGunNPCLockingAngleYaw = 1384,
		SmartGunNPCProjectileStartingOrientationAngleOffset = 1385,
		SmartGunNPCProjectileVelocity = 1386,
		SmartGunNPCShootProjectilesOnlyStraight = 1387,
		SmartGunNPCSpreadMultiplier = 1388,
		SmartGunNPCTrajectoryCurvatureMultiplier = 1389,
		SmartGunPlayerProjectileVelocity = 1390,
		SmartGunProjectileVelocityVariance = 1391,
		SmartGunSpiralCycleTimeMax = 1392,
		SmartGunSpiralCycleTimeMin = 1393,
		SmartGunSpiralRadius = 1394,
		SmartGunSpiralRampDistanceEnd = 1395,
		SmartGunSpiralRampDistanceStart = 1396,
		SmartGunSpiralRandomizeDirection = 1397,
		SmartGunSpreadMultiplier = 1398,
		SmartGunStartingAccuracy = 1399,
		SmartGunTargetAcquisitionRange = 1400,
		SmartGunTargetingRectangleSizeIncrease = 1401,
		SmartGunTimeToLockBreachComponentMultiplier = 1402,
		SmartGunTimeToLockChestComponentMultiplier = 1403,
		SmartGunTimeToLockHeadComponentMultiplier = 1404,
		SmartGunTimeToLockLegComponentMultiplier = 1405,
		SmartGunTimeToLockMechanicalComponentMultiplier = 1406,
		SmartGunTimeToLockVehicleComponentMultiplier = 1407,
		SmartGunTimeToLockWeakSpotComponentMultiplier = 1408,
		SmartGunTimeToMaxAccuracy = 1409,
		SmartGunTimeToRemoveOccludedTarget = 1410,
		SmartGunTrackBreachComponents = 1411,
		SmartGunTrackChestComponents = 1412,
		SmartGunTrackHeadComponents = 1413,
		SmartGunTrackLegComponents = 1414,
		SmartGunTrackMechanicalComponents = 1415,
		SmartGunTrackMultipleEntitiesInADS = 1416,
		SmartGunTrackVehicleComponents = 1417,
		SmartGunTrackWeakSpotComponents = 1418,
		SmartGunUseEvenDistributionTargeting = 1419,
		SmartGunUseTagLockTargeting = 1420,
		SmartGunUseTimeBasedAccuracy = 1421,
		SmartMod2_Velocity = 1422,
		SmartMod3_Zone = 1423,
		SmartTargetingDisruptionProbability = 1424,
		SmartTargetingShouldNotDisableCollision = 1425,
		SmartWeaponDamagePercentBonus = 1426,
		SmasherBossHackUploadProgressBumpMultiplier = 1427,
		SniperStaminaCostReduction = 1428,
		SpecialDamage = 1429,
		SpeedBoost = 1430,
		SpeedBoostMaxSpeed = 1431,
		Spread = 1432,
		SpreadAdsChangePerShot = 1433,
		SpreadAdsChargeMult = 1434,
		SpreadAdsDefaultX = 1435,
		SpreadAdsDefaultY = 1436,
		SpreadAdsFastSpeedMax = 1437,
		SpreadAdsFastSpeedMaxAdd = 1438,
		SpreadAdsFastSpeedMin = 1439,
		SpreadAdsFastSpeedMinAdd = 1440,
		SpreadAdsFullChargeMult = 1441,
		SpreadAdsMaxX = 1442,
		SpreadAdsMaxY = 1443,
		SpreadAdsMinX = 1444,
		SpreadAdsMinY = 1445,
		SpreadAnimation = 1446,
		SpreadChangePerShot = 1447,
		SpreadChargeMult = 1448,
		SpreadCrouchDefaultMult = 1449,
		SpreadCrouchMaxMult = 1450,
		SpreadDefaultX = 1451,
		SpreadDefaultY = 1452,
		SpreadEvenDistributionJitterSize = 1453,
		SpreadEvenDistributionRowCount = 1454,
		SpreadFastSpeedMax = 1455,
		SpreadFastSpeedMaxAdd = 1456,
		SpreadFastSpeedMin = 1457,
		SpreadFastSpeedMinAdd = 1458,
		SpreadFullChargeMult = 1459,
		SpreadMaxAI = 1460,
		SpreadMaxX = 1461,
		SpreadMaxY = 1462,
		SpreadMinX = 1463,
		SpreadMinY = 1464,
		SpreadPenalty = 1465,
		SpreadQuickhacksOnStart = 1466,
		SpreadRandomizeOriginPoint = 1467,
		SpreadResetSpeed = 1468,
		SpreadResetTimeThreshold = 1469,
		SpreadToken = 1470,
		SpreadUseCircularSpread = 1471,
		SpreadUseEvenDistribution = 1472,
		SpreadUseInAds = 1473,
		SpreadZeroOnFirstShot = 1474,
		SpreadingAttackConeAngle = 1475,
		SpreadingAttackDamageMultiplier = 1476,
		SpreadingAttackMaxJumps = 1477,
		SpreadingAttackMaxTargets = 1478,
		SpreadingAttackRange = 1479,
		StaggerDamageThreshold = 1480,
		StaggerDamageThresholdImpulse = 1481,
		StaggerDamageThresholdInCover = 1482,
		Stamina = 1483,
		StaminaAimingCost = 1484,
		StaminaCostReduction = 1485,
		StaminaCostToBlock = 1486,
		StaminaDamage = 1487,
		StaminaDecayDelayOnChange = 1488,
		StaminaDecayEnabled = 1489,
		StaminaDecayEndThrehold = 1490,
		StaminaDecayRate = 1491,
		StaminaDecayStartDelay = 1492,
		StaminaDecayStartThreshold = 1493,
		StaminaRatio = 1494,
		StaminaRegenBonusBlackmarket = 1495,
		StaminaRegenDelayOnChange = 1496,
		StaminaRegenEnabled = 1497,
		StaminaRegenEndThrehold = 1498,
		StaminaRegenRate = 1499,
		StaminaRegenRateAdd = 1500,
		StaminaRegenRateBase = 1501,
		StaminaRegenRateMult = 1502,
		StaminaRegenStartDelay = 1503,
		StaminaRegenStartThreshold = 1504,
		StaminaSprintDecayRate = 1505,
		StatModifierGroupLimit = 1506,
		StaticModifierMultiplier = 1507,
		Stealth = 1508,
		StealthHacksCostReduction = 1509,
		StealthHitDamageBonus = 1510,
		StealthHitDamageBonusModifierHelper = 1511,
		StealthHitDamageMultiplier = 1512,
		StealthMastery = 1513,
		StealthTrait01Stat = 1514,
		StealthWeakspotDamageMultiplier = 1515,
		StreetCred = 1516,
		StreetCredXPBonusMultiplier = 1517,
		Strength = 1518,
		StrengthAllocated = 1519,
		StrengthAvailable = 1520,
		StrengthSkill = 1521,
		StrengthSkillcheckBonus = 1522,
		StrongArmsStaminaCostReduction = 1523,
		StunApplicationRate = 1524,
		StunImmunity = 1525,
		StyleOverSubstanceCount = 1526,
		SubMachinegunStaminaCostReduction = 1527,
		SuicideHackMemoryCostReduction = 1528,
		Sway = 1529,
		SwayCenterMaximumAngleOffset = 1530,
		SwayCurvatureMaximumFactor = 1531,
		SwayCurvatureMinimumFactor = 1532,
		SwayInitialOffsetRandomFactor = 1533,
		SwayResetOnAimStart = 1534,
		SwaySideBottomAngleLimit = 1535,
		SwaySideMaximumAngleDistance = 1536,
		SwaySideMinimumAngleDistance = 1537,
		SwaySideStepChangeMaximumFactor = 1538,
		SwaySideStepChangeMinimumFactor = 1539,
		SwaySideTopAngleLimit = 1540,
		SwayStartBlendTime = 1541,
		SwayStartDelay = 1542,
		SwayTraversalTime = 1543,
		SystemCollapseImmunity = 1544,
		SystemCollapseMemoryCostReduction = 1545,
		TBHsBaseCoefficient = 1546,
		TBHsBaseSourceMultiplierCoefficient = 1547,
		TBHsCoverTraceLoSIncreaseSpeed = 1548,
		TBHsMinimumLineOfSightTime = 1549,
		TBHsReactionCooldownReduction = 1550,
		TBHsSensesTraceLoSIncreaseSpeed = 1551,
		TBHsVisibilityCooldown = 1552,
		TechBaseChargeThreshold = 1553,
		TechMaxChargeThreshold = 1554,
		TechMod1_EMPChance = 1555,
		TechMod3_ChargeTime = 1556,
		TechOverChargeThreshold = 1557,
		TechPierceChargeLevel = 1558,
		TechPierceDamageFactor = 1559,
		TechPierceEnabled = 1560,
		TechPierceHighlightsEnabled = 1561,
		TechPierceScanAngle = 1562,
		TechWeaponDamagePercentBonus = 1563,
		Tech_Central_Milestone_2_Discount = 1564,
		Tech_Central_Perk_2_2_Humanity = 1565,
		Tech_Master_Perk_3_Humanity = 1566,
		TechnicalAbility = 1567,
		TechnicalAbilityAllocated = 1568,
		TechnicalAbilityAvailable = 1569,
		TechnicalAbilitySkill = 1570,
		TechnicalAbilitySkillcheckBonus = 1571,
		ThermalDamage = 1572,
		ThermalDamageAdditiveMultiplier = 1573,
		ThermalDamageMax = 1574,
		ThermalDamageMin = 1575,
		ThermalDamageModifierHelper = 1576,
		ThermalDamagePercent = 1577,
		ThermalDamagePercentBonus = 1578,
		ThermalDamagePercentBonusModifierHelper = 1579,
		ThermalResistance = 1580,
		ThermalResistanceModifierHelper = 1581,
		ThreeOrMoreProgramsCooldownRedPerk = 1582,
		ThreeOrMoreProgramsMemoryRegPerk = 1583,
		ThrowMod1_CanReturn = 1584,
		ThrowMod1_ReturnChance = 1585,
		ThrowMod3_Armor_Pene = 1586,
		ThrowRecovery = 1587,
		TimeBankCharges = 1588,
		TimeBankRegenDelayOnChange = 1589,
		TimeBankRegenEnabled = 1590,
		TimeBankRegenEndThrehold = 1591,
		TimeBankRegenRate = 1592,
		TimeBankRegenStartDelay = 1593,
		TimeBankRegenStartThreshold = 1594,
		TimeDilationGenericDuration = 1595,
		TimeDilationGenericTimeScale = 1596,
		TimeDilationKerenzikovDuration = 1597,
		TimeDilationKerenzikovPlayerTimeScale = 1598,
		TimeDilationKerenzikovTimeScale = 1599,
		TimeDilationOnDodgesCooldownDuration = 1600,
		TimeDilationOnDodgesDuration = 1601,
		TimeDilationOnDodgesTimeScale = 1602,
		TimeDilationOnHealthDropCooldownDuration = 1603,
		TimeDilationOnHealthDropDuration = 1604,
		TimeDilationOnHealthDropTimeScale = 1605,
		TimeDilationSandevistanCooldownBase = 1606,
		TimeDilationSandevistanCooldownReduction = 1607,
		TimeDilationSandevistanDuration = 1608,
		TimeDilationSandevistanEnterCost = 1609,
		TimeDilationSandevistanRechargeDuration = 1610,
		TimeDilationSandevistanTimeScale = 1611,
		TimeDilationWhenEnteringCombatCooldownDuration = 1612,
		TimeDilationWhenEnteringCombatDuration = 1613,
		TimeDilationWhenEnteringCombatTimeScale = 1614,
		TranquilizerImmunity = 1615,
		TriggerDismembermentChance = 1616,
		TriggerWoundedChance = 1617,
		TurretFriendlyExtension = 1618,
		TurretShutdownExtension = 1619,
		TwoHandBluntStaminaCostReduction = 1620,
		TwoHandHammerStaminaCostReduction = 1621,
		UltimateHackSpread = 1622,
		UltimateHacksCostReduction = 1623,
		UltimateMemoryCostReduction = 1624,
		UnconsciousImmunity = 1625,
		UnequipAnimationDuration_Corpo = 1626,
		UnequipAnimationDuration_Gang = 1627,
		UnequipDuration = 1628,
		UnequipDuration_Corpo = 1629,
		UnequipDuration_Gang = 1630,
		UnequipItemTime_Corpo = 1631,
		UnequipItemTime_Gang = 1632,
		UnlockProgress = 1633,
		UpgradeCompensate = 1634,
		UpgradeCount = 1635,
		UpgradingCostReduction = 1636,
		UpgradingMaterialDropChance = 1637,
		UpgradingMaterialRandomGrantChance = 1638,
		UpgradingMaterialRetrieveChance = 1639,
		UploadQuickHackMod = 1640,
		VehicleDamagePercentBonus = 1641,
		VehicleDamageQualityDivisor = 1642,
		VehicleMinHealthPercentWhenDamaged = 1643,
		VehicleMissileLauncherBaseCharges = 1644,
		VehicleMissileLauncherCharges = 1645,
		VehicleMissileLauncherChargesRegenBegins = 1646,
		VehicleMissileLauncherChargesRegenDelayOnChange = 1647,
		VehicleMissileLauncherChargesRegenEnds = 1648,
		VehicleMissileLauncherChargesRegenRate = 1649,
		VehicleMissileLauncherChargesRegenStartDelay = 1650,
		VehicleMissileLauncherLockOnTime = 1651,
		VehicleMissileLauncherMaxCharges = 1652,
		VehicleMissileLauncherProjectilesPerCharge = 1653,
		VehicleMissileLauncherRechargeDuration = 1654,
		VehicleMissileLauncherRegenEnabled = 1655,
		VehicleMissileLauncherSalvoCharges = 1656,
		VendorBuyPriceDiscount = 1657,
		VendorSellPriceDiscount = 1658,
		Visibility = 1659,
		VisibilityReduction = 1660,
		VisibilityReductionModifierHelper = 1661,
		VisualStimRangeMultiplier = 1662,
		VulnerabilityExtension = 1663,
		VulnerableImmunity = 1664,
		WallRunHorSpeedToEnterMin = 1665,
		WallRunStrafeAngleMax = 1666,
		WallRunTimeMax = 1667,
		WallRunVertSpeedToEnterMax = 1668,
		WasItemUpgraded = 1669,
		WasQuickHacked = 1670,
		WeakspotDamageMultiplier = 1671,
		WeaponEvolutionToStaminaCost = 1672,
		WeaponHasAutoloader = 1673,
		WeaponNoise = 1674,
		WeaponPosAdsX = 1675,
		WeaponPosAdsY = 1676,
		WeaponPosAdsZ = 1677,
		WeaponPosX = 1678,
		WeaponPosY = 1679,
		WeaponPosZ = 1680,
		WeaponRotAdsX = 1681,
		WeaponRotAdsY = 1682,
		WeaponRotAdsZ = 1683,
		WeaponRotX = 1684,
		WeaponRotY = 1685,
		WeaponRotZ = 1686,
		WeaponSwapDuration = 1687,
		WeaponTypeToStaminaCost = 1688,
		WeaponVFX_BulletFxScaleFullAutoRandRange = 1689,
		WeaponVFX_BulletFxScaleFullAutoRandStart = 1690,
		WeaponVFX_BulletFxScaleFullAutoRandomization = 1691,
		WeaponVFX_DecalFxScale = 1692,
		WeaponVFX_MuzzleFxScale = 1693,
		WeaponVFX_ProjectileFxScale = 1694,
		WeaponVFX_ShellsFxScale = 1695,
		WeaponVFX_TracerFxScale = 1696,
		WeaponVehicleDamagePercentBonus = 1697,
		Weight = 1698,
		WoundHeadDamageThreshold = 1699,
		WoundLArmDamageThreshold = 1700,
		WoundLLegDamageThreshold = 1701,
		WoundRArmDamageThreshold = 1702,
		WoundRLegDamageThreshold = 1703,
		WoundedImmunity = 1704,
		XPbonusMultiplier = 1705,
		ZoomLevel = 1706,
		CPO_Armor = 1707,
		CPO_NPC_Importance = 1708,
		Count = 1709,
		Invalid = 1710
	}

	public enum gamedataStatType_1300DEPRECATED
	{
		Acceleration = 0,
		Accuracy = 1,
		Adrenaline = 2,
		AimFOV = 3,
		AimInTime = 4,
		AimOffset = 5,
		AimOutTime = 6,
		AllowMovementInput = 7,
		AllowRotation = 8,
		Armor = 9,
		Assault = 10,
		AssaultMastery = 11,
		AssaultTrait01Stat = 12,
		Athletics = 13,
		AthleticsMastery = 14,
		AthleticsTrait01Stat = 15,
		AttackPenetration = 16,
		AttackSpeed = 17,
		AttackSpeedPercent = 18,
		AttacksNumber = 19,
		AttacksPerSecond = 20,
		AttacksPerSecondBase = 21,
		AudioLocomotionStimRangeMultiplier = 22,
		AudioStimRangeMultiplier = 23,
		AutoReveal = 24,
		AutocraftDuration = 25,
		AutomaticReplenishment = 26,
		AutomaticUploadPerk = 27,
		BaseChargeTime = 28,
		BaseDamage = 29,
		BaseDamageMax = 30,
		BaseDamageMin = 31,
		BerserkArmorBonus = 32,
		BerserkCooldownBase = 33,
		BerserkCooldownReduction = 34,
		BerserkDurationBase = 35,
		BerserkHealthRegenBonus = 36,
		BerserkMeleeDamageBonus = 37,
		BerserkRecoilReduction = 38,
		BerserkResistancesBonus = 39,
		BerserkShockwaveDamage = 40,
		BerserkShockwaveRangeBonus = 41,
		BerserkSwayReduction = 42,
		BleedingApplicationRate = 43,
		BleedingImmunity = 44,
		BlindImmunity = 45,
		BlindResistance = 46,
		BlockFactor = 47,
		BlockLocomotionWhenLeaningOutOfCover = 48,
		BlockReduction = 49,
		BonusChargeDamage = 50,
		BonusDPS = 51,
		BonusDamageAgainstElites = 52,
		BonusDamageAgainstMechanicals = 53,
		BonusDamageAgainstRares = 54,
		BonusQuickHackDamage = 55,
		BonusRicochetDamage = 56,
		Brake = 57,
		BrakeDot = 58,
		Brawling = 59,
		BrawlingMastery = 60,
		BrawlingTrait01Stat = 61,
		BufferSize = 62,
		BulletMagnetismDefaultAngle = 63,
		BulletMagnetismHighVelocityAngle = 64,
		BulletPseudoPierceHitVFxChance = 65,
		BulletSurroundingHitVFxChance = 66,
		BurningApplicationRate = 67,
		BurningImmunity = 68,
		BurningRegenStamina = 69,
		CPUPower = 70,
		CallReinforcement = 71,
		CameraShutdownExtension = 72,
		CanAerialTakedown = 73,
		CanAimWhileDodging = 74,
		CanAskToFollowOrder = 75,
		CanAskToHolsterWeapon = 76,
		CanAutomaticallyDisassembleJunk = 77,
		CanAutomaticallyRestoreKnives = 78,
		CanBleedingCriticallyHit = 79,
		CanBleedingSlowTarget = 80,
		CanBlindQuickHack = 81,
		CanBlock = 82,
		CanBreatheUnderwater = 83,
		CanBuffCamoQuickHack = 84,
		CanBuffMechanicalsOnTakeControl = 85,
		CanBuffSturdinessQuickHack = 86,
		CanBurningCriticallyHit = 87,
		CanCallDrones = 88,
		CanCallReinforcements = 89,
		CanCatchUp = 90,
		CanCatchUpDistance = 91,
		CanCharge = 92,
		CanChargedShoot = 93,
		CanCloseCombat = 94,
		CanCommsCallInQuickHack = 95,
		CanCommsCallOutQuickHack = 96,
		CanCommsNoiseQuickHack = 97,
		CanControlFullyChargedWeapon = 98,
		CanCraftEpicItems = 99,
		CanCraftFromInventory = 100,
		CanCraftLegendaryItems = 101,
		CanCraftRareItems = 102,
		CanCraftTechAmmunition = 103,
		CanCrouch = 104,
		CanCyberwareMalfunctionQuickHack = 105,
		CanDash = 106,
		CanDataMineQuickHack = 107,
		CanDealFullDamageToArmored = 108,
		CanDeathQuickHack = 109,
		CanDisassemble = 110,
		CanDisassembleConsumables = 111,
		CanDisassembleGadgets = 112,
		CanDropWeapon = 113,
		CanElectrocuteNullifyStats = 114,
		CanElectrocuteRoot = 115,
		CanExitWSOnSoundStimuli = 116,
		CanExplodeQuickHack = 117,
		CanFastTravelWhileEncumbered = 118,
		CanFullyChargeWeapon = 119,
		CanGrab = 120,
		CanGrappleAndroids = 121,
		CanGrappleSilently = 122,
		CanGrenadeLaunch = 123,
		CanGrenadeQuickHack = 124,
		CanGrenadesCriticallyHit = 125,
		CanGrenadesDealExternalDamage = 126,
		CanGuardBreak = 127,
		CanHeartattackQuickHack = 128,
		CanIgnoreArmorDamageReduction = 129,
		CanIgnoreStamina = 130,
		CanInstallTechMods = 131,
		CanJamWeaponQuickHack = 132,
		CanJump = 133,
		CanLandSilently = 134,
		CanLegendaryCraftedWeaponsBeBoosted = 135,
		CanLocomotionMalfunctionQuickHack = 136,
		CanMadnessQuickHack = 137,
		CanMalfunctionQuickHack = 138,
		CanMeleeBerserk = 139,
		CanMeleeDash = 140,
		CanMeleeInfinitelyCombo = 141,
		CanMeleeLeap = 142,
		CanMeleeLeapTakedown = 143,
		CanOverchargeWeapon = 144,
		CanOverheatQuickHack = 145,
		CanOverloadQuickHack = 146,
		CanOverrideAttitudeQuickHack = 147,
		CanOverrideAuthorizationQuickHack = 148,
		CanParry = 149,
		CanPickUpBodyAfterTakedown = 150,
		CanPickUpWeapon = 151,
		CanPingQuickHack = 152,
		CanPlayerBoostConsumables = 153,
		CanPlayerBoostGrenades = 154,
		CanPoisonLowerArmor = 155,
		CanPoisonSlow = 156,
		CanPreciseShoot = 157,
		CanPushBack = 158,
		CanPushFromGrapple = 159,
		CanQuickHackCriticallyHit = 160,
		CanQuickMeleeStagger = 161,
		CanQuickhack = 162,
		CanQuickhackHealPuppet = 163,
		CanQuickhackTransferBetweenEnemies = 164,
		CanRegenInCombat = 165,
		CanRemoveModsFromClothing = 166,
		CanRemoveModsFromWeapons = 167,
		CanResurrectAllies = 168,
		CanRetrieveModsFromDisassemble = 169,
		CanRunSilently = 170,
		CanSandevistanSprintHarass = 171,
		CanScrapPartsFromMechanicals = 172,
		CanSeeGrenadeRadius = 173,
		CanSeeRicochetVisuals = 174,
		CanSeeThroughWalls = 175,
		CanShareThreatsWithPlayer = 176,
		CanShootWhileCarryingBody = 177,
		CanShootWhileDodging = 178,
		CanShootWhileGrappling = 179,
		CanShootWhileMoving = 180,
		CanShootWhileVaulting = 181,
		CanSilentKill = 182,
		CanSmartShoot = 183,
		CanSprint = 184,
		CanSprintHarass = 185,
		CanSprintWhileCarryingBody = 186,
		CanSuicideQuickHack = 187,
		CanSwitchWeapon = 188,
		CanTakeControlQuickHack = 189,
		CanTakedownLethally = 190,
		CanTakedownSilently = 191,
		CanTaunt = 192,
		CanThrowWeapon = 193,
		CanUpgradeFromInventory = 194,
		CanUpgradeToLegendaryQuality = 195,
		CanUseAntiStun = 196,
		CanUseBiohazardGrenades = 197,
		CanUseCloseRing = 198,
		CanUseCombatStims = 199,
		CanUseConsumables = 200,
		CanUseCoolingSystem = 201,
		CanUseCovers = 202,
		CanUseCuttingGrenades = 203,
		CanUseEMPGrenades = 204,
		CanUseExtremeRing = 205,
		CanUseFarRing = 206,
		CanUseFlashbangGrenades = 207,
		CanUseFragGrenades = 208,
		CanUseGrenades = 209,
		CanUseHolographicCamo = 210,
		CanUseIncendiaryGrenades = 211,
		CanUseLeftHand = 212,
		CanUseLegs = 213,
		CanUseMantisBlades = 214,
		CanUseMediumRing = 215,
		CanUseMeleeRing = 216,
		CanUseOpticalCamo = 217,
		CanUsePainInhibitors = 218,
		CanUsePersonalSoundSilencer = 219,
		CanUseProjectileLauncher = 220,
		CanUseReconGrenades = 221,
		CanUseRetractableShield = 222,
		CanUseRightHand = 223,
		CanUseShootingSpots = 224,
		CanUseStaticCamo = 225,
		CanUseStrongArms = 226,
		CanUseTakedowns = 227,
		CanUseTerrainCamo = 228,
		CanUseZoom = 229,
		CanWalkSilently = 230,
		CanWallStick = 231,
		CanWeaponBlock = 232,
		CanWeaponBlockAttack = 233,
		CanWeaponComboAttack = 234,
		CanWeaponCriticallyHit = 235,
		CanWeaponCrouchAttack = 236,
		CanWeaponDash = 237,
		CanWeaponDeflect = 238,
		CanWeaponIgnoreArmor = 239,
		CanWeaponInfinitlyCombo = 240,
		CanWeaponJumpAttack = 241,
		CanWeaponLeap = 242,
		CanWeaponMalfunctionQuickHack = 243,
		CanWeaponReload = 244,
		CanWeaponReloadWhileInactive = 245,
		CanWeaponReloadWhileSliding = 246,
		CanWeaponReloadWhileSprinting = 247,
		CanWeaponReloadWhileVaulting = 248,
		CanWeaponSafeAttack = 249,
		CanWeaponShoot = 250,
		CanWeaponShootWhileSliding = 251,
		CanWeaponShootWhileSprinting = 252,
		CanWeaponShootWhileVaulting = 253,
		CanWeaponSnapToLimbs = 254,
		CanWeaponSprintAttack = 255,
		CanWeaponStrongAttack = 256,
		CanWeaponTriggerHeadshot = 257,
		CannotBeDetectedWhileSubmerged = 258,
		CannotBeHealed = 259,
		CannotSprintHarass = 260,
		CarryCapacity = 261,
		CausingPanicReducesUltimateHacksCost = 262,
		Charge = 263,
		ChargeDischargeTime = 264,
		ChargeFullMultiplier = 265,
		ChargeMaxTimeInChargedState = 266,
		ChargeMultiplier = 267,
		ChargeReadyPercentage = 268,
		ChargeShouldFireWhenReady = 269,
		ChargeTime = 270,
		ChemicalDamage = 271,
		ChemicalDamageMax = 272,
		ChemicalDamageMin = 273,
		ChemicalDamagePercent = 274,
		ChemicalResistance = 275,
		ClimbSpeedModifier = 276,
		ClipTimesCycle = 277,
		ClipTimesCycleBase = 278,
		ClipTimesCyclePlusReload = 279,
		ClipTimesCyclePlusReloadBase = 280,
		CloudComputingTraps = 281,
		ColdBlood = 282,
		ColdBloodBuffBonus = 283,
		ColdBloodMastery = 284,
		ColdBloodMaxDuration = 285,
		ColdBloodMaxStacks = 286,
		ColdBloodTrait01 = 287,
		CombatHacking = 288,
		CombatHackingMastery = 289,
		CommsNoiseJamOnQuickhack = 290,
		Cool = 291,
		Crafting = 292,
		CraftingBonusArmorValue = 293,
		CraftingBonusConsumableDuration = 294,
		CraftingBonusGrenadeDamage = 295,
		CraftingBonusWeaponDamage = 296,
		CraftingCostReduction = 297,
		CraftingItemLevelBoost = 298,
		CraftingMastery = 299,
		CraftingMaterialDropChance = 300,
		CraftingMaterialRandomGrantChance = 301,
		CraftingMaterialRetrieveChance = 302,
		CraftingTrait01 = 303,
		CritChance = 304,
		CritChanceTimeCritDamage = 305,
		CritDPSBonus = 306,
		CritDamage = 307,
		CyberwareCooldownReduction = 308,
		CycleTime = 309,
		CycleTimeAimBlockDuration = 310,
		CycleTimeAimBlockStart = 311,
		CycleTimeBase = 312,
		CycleTimeBonus = 313,
		CycleTimeShootingMult = 314,
		CycleTimeShootingMultPeriod = 315,
		CycleTime_Burst = 316,
		CycleTime_BurstMaxCharge = 317,
		CycleTime_BurstSecondary = 318,
		CycleTriggerModeTime = 319,
		DPS = 320,
		DamageFalloffDisabled = 321,
		DamageHackSpread = 322,
		DamagePerHit = 323,
		DamageReductionDamageOverTime = 324,
		DamageReductionExplosion = 325,
		DashAttackStaminaCostReduction = 326,
		DataLeakTraps = 327,
		DealsChemicalDamage = 328,
		DealsElectricDamage = 329,
		DealsPhysicalDamage = 330,
		DealsThermalDamage = 331,
		Deceleration = 332,
		DefeatedHeadDamageThreshold = 333,
		DefeatedLArmDamageThreshold = 334,
		DefeatedLLegDamageThreshold = 335,
		DefeatedRArmDamageThreshold = 336,
		DefeatedRLegDamageThreshold = 337,
		DefeatingEnemiesReduceHacksCost = 338,
		Demolition = 339,
		DemolitionMastery = 340,
		DemolitionTrait01Stat = 341,
		Detection = 342,
		DeviceMemoryCostReduction = 343,
		DisableCyberwareOnBurning = 344,
		DisassemblingIngredientsDoubleBonus = 345,
		DisassemblingMaterialQualityObtainChance = 346,
		DismHeadDamageThreshold = 347,
		DismLArmDamageThreshold = 348,
		DismLLegDamageThreshold = 349,
		DismRArmDamageThreshold = 350,
		DismRLegDamageThreshold = 351,
		DoNotCheckFriendlyFireMadnessPassive = 352,
		DummyResistanceStat = 353,
		Durability = 354,
		DurationBonusBleeding = 355,
		DurationBonusBurning = 356,
		DurationBonusElectrified = 357,
		DurationBonusPoisoned = 358,
		DurationBonusQuickhack = 359,
		DurationBonusStun = 360,
		EMPImmunity = 361,
		EffectiveDPS = 362,
		EffectiveDamagePerHit = 363,
		EffectiveDamagePerHitMax = 364,
		EffectiveDamagePerHitMin = 365,
		EffectiveDamagePerHitTimesAttacksPerSecond = 366,
		EffectiveRange = 367,
		ElectricDamage = 368,
		ElectricDamageMax = 369,
		ElectricDamageMin = 370,
		ElectricDamagePercent = 371,
		ElectricResistance = 372,
		ElectrocuteImmunity = 373,
		ElectrocutedApplicationRate = 374,
		ElementalDamagePerHit = 375,
		ElementalResistanceMultiplier = 376,
		EmptyReloadTime = 377,
		Engineering = 378,
		EngineeringMastery = 379,
		EngineeringTrait01 = 380,
		EquipActionDuration_Corpo = 381,
		EquipActionDuration_Gang = 382,
		EquipAnimationDuration_Corpo = 383,
		EquipAnimationDuration_Gang = 384,
		EquipDuration = 385,
		EquipDuration_First = 386,
		EquipItemTime_Corpo = 387,
		EquipItemTime_Gang = 388,
		Evasion = 389,
		ExplosionKillsRecudeUltimateHacksCost = 390,
		FFInputLock = 391,
		FallDamageReduction = 392,
		FearOnQuickHackKill = 393,
		FullAutoOnFullCharge = 394,
		Gunslinger = 395,
		GunslingerMastery = 396,
		GunslingerTrait01Stat = 397,
		HackedEnemiesGetDamagedByFriendlyFire = 398,
		HackedEnemyArmorReduction = 399,
		Hacking = 400,
		HackingMastery = 401,
		HackingPenetration = 402,
		HackingResistance = 403,
		HackingResistanceUltimate = 404,
		HasAdditionalSplinterSlot = 405,
		HasAheadTargeting = 406,
		HasAirHover = 407,
		HasAirThrusters = 408,
		HasAutoReloader = 409,
		HasAutomaticReplenishment = 410,
		HasAutomaticTagging = 411,
		HasBerserk = 412,
		HasBleedImmunity = 413,
		HasBlindImmunity = 414,
		HasBoostedCortex = 415,
		HasBurningBuffs = 416,
		HasCameraLinking = 417,
		HasChargeJump = 418,
		HasCritImmunity = 419,
		HasCyberdeck = 420,
		HasCybereye = 421,
		HasDodge = 422,
		HasDodgeAir = 423,
		HasDoubleJump = 424,
		HasElectricCoating = 425,
		HasElectroPlating = 426,
		HasExtendedHitReactionImmunity = 427,
		HasFireproofSkin = 428,
		HasGPS = 429,
		HasGlowingTattoos = 430,
		HasGraphiteTissue = 431,
		HasHackingInteractions = 432,
		HasHealingReapplication = 433,
		HasHealthMonitorBomb = 434,
		HasHostileHackImmunity = 435,
		HasICELevelBooster = 436,
		HasInfravision = 437,
		HasJuiceInjector = 438,
		HasKerenzikov = 439,
		HasKerenzikovSlide = 440,
		HasKers = 441,
		HasLinkToBountySystem = 442,
		HasLoweringPerception = 443,
		HasMadnessLvl4Passive = 444,
		HasMajorQuickhackResistance = 445,
		HasMechanicalControl = 446,
		HasMeleeImmunity = 447,
		HasMeleeTargeting = 448,
		HasMetabolicEnhancer = 449,
		HasPoisonHeal = 450,
		HasPoisonImmunity = 451,
		HasPowerGrip = 452,
		HasQuickhackResistance = 453,
		HasRemoteBotAccessPointBreach = 454,
		HasSandevistan = 455,
		HasSandevistanTier1 = 456,
		HasSandevistanTier2 = 457,
		HasSandevistanTier3 = 458,
		HasSecondHeart = 459,
		HasSelfHealingSkin = 460,
		HasSmartLink = 461,
		HasSpiderBotControl = 462,
		HasStunImmunity = 463,
		HasSubdermalArmor = 464,
		HasSuperheroFall = 465,
		HasThermovision = 466,
		HasTimedImmunity = 467,
		HasToxicCleanser = 468,
		HasWallRunSkill = 469,
		HeadshotDamageMultiplier = 470,
		HeadshotImmunity = 471,
		Health = 472,
		HealthInCombatRegenDelayOnChange = 473,
		HealthInCombatRegenEnabled = 474,
		HealthInCombatRegenEndThreshold = 475,
		HealthInCombatRegenRate = 476,
		HealthInCombatRegenRateAdd = 477,
		HealthInCombatRegenRateBase = 478,
		HealthInCombatRegenRateMult = 479,
		HealthInCombatRegenStartThreshold = 480,
		HealthInCombatStartDelay = 481,
		HealthMonitorCooldownDuration = 482,
		HealthOutOfCombatRegenDelayOnChange = 483,
		HealthOutOfCombatRegenEnabled = 484,
		HealthOutOfCombatRegenEndThreshold = 485,
		HealthOutOfCombatRegenRate = 486,
		HealthOutOfCombatRegenRateAdd = 487,
		HealthOutOfCombatRegenRateBase = 488,
		HealthOutOfCombatRegenRateMult = 489,
		HealthOutOfCombatRegenStartThreshold = 490,
		Hearing = 491,
		HeavyAttacksNumber = 492,
		HighlightAccessPoint = 493,
		HitDismembermentFactor = 494,
		HitReactionDamageHealthFactor = 495,
		HitReactionFactor = 496,
		HitTimerAfterDefeated = 497,
		HitTimerAfterImpact = 498,
		HitTimerAfterImpactMelee = 499,
		HitTimerAfterKnockdown = 500,
		HitTimerAfterPain = 501,
		HitTimerAfterStagger = 502,
		HitTimerAfterStaggerMelee = 503,
		HitWoundsFactor = 504,
		HoldDuration = 505,
		HoldEnterDuration = 506,
		HoldTimeoutDuration = 507,
		HolographicSkinCooldownDuration = 508,
		HolographicSkinDuration = 509,
		IconicItemUpgraded = 510,
		ImpactDamageThreshold = 511,
		ImpactDamageThresholdImpulse = 512,
		ImpactDamageThresholdInCover = 513,
		Intelligence = 514,
		IsAggressive = 515,
		IsBalanced = 516,
		IsBlocking = 517,
		IsCautious = 518,
		IsDefensive = 519,
		IsDeflecting = 520,
		IsDodgeStaminaFree = 521,
		IsDodging = 522,
		IsFastMeleeArchetype = 523,
		IsFastRangedArchetype = 524,
		IsGenericMeleeArchetype = 525,
		IsGenericRangedArchetype = 526,
		IsHeavyRangedArchetype = 527,
		IsInvulnerable = 528,
		IsItemBroken = 529,
		IsItemCracked = 530,
		IsItemCrafted = 531,
		IsItemIconic = 532,
		IsItemUpgraded = 533,
		IsManBig = 534,
		IsManMassive = 535,
		IsMechanical = 536,
		IsNetrunnerArchetype = 537,
		IsNotSlowedDuringADS = 538,
		IsNotSlowedDuringBlock = 539,
		IsNotSlowedDuringReload = 540,
		IsReckless = 541,
		IsShotgunnerArchetype = 542,
		IsSniperArchetype = 543,
		IsSprintStaminaFree = 544,
		IsStrongMeleeArchetype = 545,
		IsTechieArchetype = 546,
		IsTier1Archetype = 547,
		IsTier2Archetype = 548,
		IsTier3Archetype = 549,
		IsTier4Archetype = 550,
		IsWeakspot = 551,
		IsWeaponLethal = 552,
		ItemArmor = 553,
		ItemLevel = 554,
		ItemRequiresElectroPlating = 555,
		ItemRequiresPowerGrip = 556,
		ItemRequiresSmartLink = 557,
		JumpHeight = 558,
		Kenjutsu = 559,
		KenjutsuMastery = 560,
		KenjutsuTrait01Stat = 561,
		KnockdownDamageThreshold = 562,
		KnockdownDamageThresholdImpulse = 563,
		KnockdownDamageThresholdInCover = 564,
		KnockdownImmunity = 565,
		KnockdownImpulse = 566,
		Level = 567,
		LimbHealth = 568,
		LinearDirectionUpdateMax = 569,
		LinearDirectionUpdateMaxADS = 570,
		LinearDirectionUpdateMin = 571,
		LinearDirectionUpdateMinADS = 572,
		LowerActiveCooldownOnDefeat = 573,
		LowerHackingResistanceOnHack = 574,
		MagazineCapacity = 575,
		MagazineCapacityBase = 576,
		MagazineCapacityBonus = 577,
		MaxDuration = 578,
		MaxPercentDamageTakenPerHit = 579,
		MaxSpeed = 580,
		MaxStacks = 581,
		MaxStacksBonusBleeding = 582,
		MaxStacksBonusBurning = 583,
		MaximumRange = 584,
		MechanicalsBuffDPSBonus = 585,
		MeleeAttackDuration = 586,
		Memory = 587,
		MemoryCostModifier = 588,
		MemoryCostReduction = 589,
		MemoryInCombatRegenDelayOnChange = 590,
		MemoryInCombatRegenEnabled = 591,
		MemoryInCombatRegenEndThreshold = 592,
		MemoryInCombatRegenRate = 593,
		MemoryInCombatRegenRateAdd = 594,
		MemoryInCombatRegenRateBase = 595,
		MemoryInCombatRegenRateMult = 596,
		MemoryInCombatRegenStartThreshold = 597,
		MemoryInCombatStartDelay = 598,
		MemoryOutOfCombatRegenDelayOnChange = 599,
		MemoryOutOfCombatRegenEnabled = 600,
		MemoryOutOfCombatRegenEndThreshold = 601,
		MemoryOutOfCombatRegenRate = 602,
		MemoryOutOfCombatRegenRateAdd = 603,
		MemoryOutOfCombatRegenRateBase = 604,
		MemoryOutOfCombatRegenRateMult = 605,
		MemoryOutOfCombatRegenStartThreshold = 606,
		MemoryOutOfCombatStartDelay = 607,
		MemoryTrackerCooldownDuration = 608,
		MemoryWipeImmunity = 609,
		MinSpeed = 610,
		MinigameBufferExtension = 611,
		MinigameMaterialsEarned = 612,
		MinigameMemoryRegenPerk = 613,
		MinigameMoneyMultiplier = 614,
		MinigameNextInstanceBufferExtensionPerk = 615,
		MinigameShardChanceMultiplier = 616,
		MinigameTimeLimitExtension = 617,
		MinigameTrapsPossibilityChance = 618,
		NPCAnimationTime = 619,
		NPCCorpoEquipItemDuration = 620,
		NPCCorpoUnequipItemDuration = 621,
		NPCDamage = 622,
		NPCEquipItemDuration = 623,
		NPCGangEquipItemDuration = 624,
		NPCGangUnequipItemDuration = 625,
		NPCLoopDuration = 626,
		NPCRecoverDuration = 627,
		NPCStartupDuration = 628,
		NPCUnequipItemDuration = 629,
		NPCUploadTime = 630,
		NoJam = 631,
		NumShotsInBurst = 632,
		NumShotsInBurstMaxCharge = 633,
		NumShotsInBurstSecondary = 634,
		NumShotsToFire = 635,
		NumberIgnoredTraps = 636,
		Overheat = 637,
		Oxygen = 638,
		PartArmor = 639,
		PenetrationHealth = 640,
		PersonalityAggressive = 641,
		PersonalityCuriosity = 642,
		PersonalityDisgust = 643,
		PersonalityFear = 644,
		PersonalityFunny = 645,
		PersonalityJoy = 646,
		PersonalitySad = 647,
		PersonalityShock = 648,
		PersonalitySurprise = 649,
		PhoneCallDuration = 650,
		PhysicalDamage = 651,
		PhysicalDamageMax = 652,
		PhysicalDamageMin = 653,
		PhysicalDamagePercent = 654,
		PhysicalImpulse = 655,
		PhysicalResistance = 656,
		PoisonImmunity = 657,
		PoisonRegenHealth = 658,
		PoisonedApplicationRate = 659,
		PowerLevel = 660,
		PreFireTime = 661,
		PrefersCovers = 662,
		PrefersShootingSpots = 663,
		Price = 664,
		ProjectilesPerShot = 665,
		ProjectilesPerShotBase = 666,
		ProjectilesPerShotBonus = 667,
		Quality = 668,
		Quantity = 669,
		QuickHackDuration = 670,
		QuickHackDurationExtension = 671,
		QuickHackImmunity = 672,
		QuickHackResistancesMod = 673,
		QuickHackSpreadDistance = 674,
		QuickHackSpreadNumber = 675,
		QuickHackSuddenDeathChance = 676,
		QuickHackUpload = 677,
		QuickhackExtraDamageMultiplier = 678,
		QuickhackShield = 679,
		QuickhacksCooldownReduction = 680,
		RandomCurveInput = 681,
		Range = 682,
		Recoil = 683,
		RecoilAllowSway = 684,
		RecoilAlternateDir = 685,
		RecoilAlternateDirADS = 686,
		RecoilAngle = 687,
		RecoilAngleADS = 688,
		RecoilAnimation = 689,
		RecoilChargeMult = 690,
		RecoilChargeMultADS = 691,
		RecoilCycleSize = 692,
		RecoilCycleSizeADS = 693,
		RecoilCycleTime = 694,
		RecoilCycleTimeADS = 695,
		RecoilDelay = 696,
		RecoilDir = 697,
		RecoilDirADS = 698,
		RecoilDirPlanCycleRandDir = 699,
		RecoilDirPlanCycleRandDirADS = 700,
		RecoilDirPlanCycleRandRangeDir = 701,
		RecoilDirPlanCycleRandRangeDirADS = 702,
		RecoilDirPlanSequence = 703,
		RecoilDirPlanSequenceADS = 704,
		RecoilDriftRandomRangeMax = 705,
		RecoilDriftRandomRangeMin = 706,
		RecoilEnableCycleX = 707,
		RecoilEnableCycleXADS = 708,
		RecoilEnableCycleY = 709,
		RecoilEnableCycleYADS = 710,
		RecoilEnableLinearX = 711,
		RecoilEnableLinearXADS = 712,
		RecoilEnableLinearY = 713,
		RecoilEnableLinearYADS = 714,
		RecoilEnableScaleX = 715,
		RecoilEnableScaleXADS = 716,
		RecoilEnableScaleY = 717,
		RecoilEnableScaleYADS = 718,
		RecoilFullChargeMult = 719,
		RecoilFullChargeMultADS = 720,
		RecoilHoldDuration = 721,
		RecoilHoldDurationADS = 722,
		RecoilKickMax = 723,
		RecoilKickMaxADS = 724,
		RecoilKickMin = 725,
		RecoilKickMinADS = 726,
		RecoilMagForFullDrift = 727,
		RecoilMaxLength = 728,
		RecoilMaxLengthADS = 729,
		RecoilRecoveryMinSpeed = 730,
		RecoilRecoveryMinSpeedADS = 731,
		RecoilRecoverySpeed = 732,
		RecoilRecoverySpeedADS = 733,
		RecoilRecoveryTime = 734,
		RecoilRecoveryTimeADS = 735,
		RecoilScaleMax = 736,
		RecoilScaleMaxADS = 737,
		RecoilScaleTime = 738,
		RecoilScaleTimeADS = 739,
		RecoilSpeed = 740,
		RecoilSpeedADS = 741,
		RecoilTime = 742,
		RecoilTimeADS = 743,
		RecoilUseDifferentStatsInADS = 744,
		Reflexes = 745,
		RefreshesPingOnQuickhack = 746,
		RegenerateHPMinigamePerk = 747,
		ReloadAmount = 748,
		ReloadEndTime = 749,
		ReloadTime = 750,
		ReloadTimeBase = 751,
		ReloadTimeBonus = 752,
		RemoveAllStacksWhenDurationEnds = 753,
		RemoveColdBloodStacksOneByOne = 754,
		RemoveSprintOnQuickhack = 755,
		ReprimandEscalation = 756,
		RestoreMemoryOnDefeat = 757,
		RevealNetrunnerWhenHacked = 758,
		RicochetChance = 759,
		RicochetCount = 760,
		RicochetMaxAngle = 761,
		RicochetMinAngle = 762,
		RicochetTargetSearchAngle = 763,
		SandevistanDashShoot = 764,
		ScanDepth = 765,
		ScanTimeReduction = 766,
		ScopeFOV = 767,
		ScopeOffset = 768,
		ScrapItemChance = 769,
		SharedCacheTraps = 770,
		ShootingOffsetAI = 771,
		ShortCircuitOnCriticalHit = 772,
		ShorterChains = 773,
		ShotDelay = 774,
		SlideWhenLeaningOutOfCover = 775,
		SmartGunAddSpiralTrajectory = 776,
		SmartGunAdsLockingAnglePitch = 777,
		SmartGunAdsLockingAngleYaw = 778,
		SmartGunAdsMaxLockedTargets = 779,
		SmartGunAdsTagLockAnglePitch = 780,
		SmartGunAdsTagLockAngleYaw = 781,
		SmartGunAdsTargetableAnglePitch = 782,
		SmartGunAdsTargetableAngleYaw = 783,
		SmartGunAdsTimeToLock = 784,
		SmartGunAdsTimeToUnlock = 785,
		SmartGunEvenDistributionPeriod = 786,
		SmartGunHipLockingAnglePitch = 787,
		SmartGunHipLockingAngleYaw = 788,
		SmartGunHipMaxLockedTargets = 789,
		SmartGunHipTagLockAnglePitch = 790,
		SmartGunHipTagLockAngleYaw = 791,
		SmartGunHipTargetableAnglePitch = 792,
		SmartGunHipTargetableAngleYaw = 793,
		SmartGunHipTimeToLock = 794,
		SmartGunHipTimeToUnlock = 795,
		SmartGunHitProbability = 796,
		SmartGunHitProbabilityMultiplier = 797,
		SmartGunMissDelay = 798,
		SmartGunMissRadius = 799,
		SmartGunNPCApplySpreadAtHitplane = 800,
		SmartGunNPCLockOnTime = 801,
		SmartGunNPCLockTimeout = 802,
		SmartGunNPCLockingAnglePitch = 803,
		SmartGunNPCLockingAngleYaw = 804,
		SmartGunNPCProjectileStartingOrientationAngleOffset = 805,
		SmartGunNPCProjectileVelocity = 806,
		SmartGunNPCShootProjectilesOnlyStraight = 807,
		SmartGunNPCSpreadMultiplier = 808,
		SmartGunNPCTrajectoryCurvatureMultiplier = 809,
		SmartGunPlayerProjectileVelocity = 810,
		SmartGunProjectileVelocityVariance = 811,
		SmartGunSpiralCycleTimeMax = 812,
		SmartGunSpiralCycleTimeMin = 813,
		SmartGunSpiralRadius = 814,
		SmartGunSpiralRampDistanceEnd = 815,
		SmartGunSpiralRampDistanceStart = 816,
		SmartGunSpiralRandomizeDirection = 817,
		SmartGunSpreadMultiplier = 818,
		SmartGunStartingAccuracy = 819,
		SmartGunTargetAcquisitionRange = 820,
		SmartGunTimeToMaxAccuracy = 821,
		SmartGunTimeToRemoveOccludedTarget = 822,
		SmartGunTrackAllBodyparts = 823,
		SmartGunTrackHeadComponents = 824,
		SmartGunTrackLegComponents = 825,
		SmartGunTrackMechanicalComponents = 826,
		SmartGunTrackMultipleEntitiesInADS = 827,
		SmartGunUseEvenDistributionTargeting = 828,
		SmartGunUseTagLockTargeting = 829,
		SmartGunUseTimeBasedAccuracy = 830,
		SmartTargetingDisruptionProbability = 831,
		SpecialDamage = 832,
		SpeedBoost = 833,
		SpeedBoostMaxSpeed = 834,
		Spread = 835,
		SpreadAdsChangePerShot = 836,
		SpreadAdsChargeMult = 837,
		SpreadAdsDefaultX = 838,
		SpreadAdsDefaultY = 839,
		SpreadAdsFastSpeedMax = 840,
		SpreadAdsFastSpeedMaxAdd = 841,
		SpreadAdsFastSpeedMin = 842,
		SpreadAdsFastSpeedMinAdd = 843,
		SpreadAdsFullChargeMult = 844,
		SpreadAdsMaxX = 845,
		SpreadAdsMaxY = 846,
		SpreadAdsMinX = 847,
		SpreadAdsMinY = 848,
		SpreadAnimation = 849,
		SpreadChangePerShot = 850,
		SpreadChargeMult = 851,
		SpreadCrouchDefaultMult = 852,
		SpreadCrouchMaxMult = 853,
		SpreadDefaultX = 854,
		SpreadDefaultY = 855,
		SpreadEvenDistributionJitterSize = 856,
		SpreadEvenDistributionRowCount = 857,
		SpreadFastSpeedMax = 858,
		SpreadFastSpeedMaxAdd = 859,
		SpreadFastSpeedMin = 860,
		SpreadFastSpeedMinAdd = 861,
		SpreadFullChargeMult = 862,
		SpreadMaxAI = 863,
		SpreadMaxX = 864,
		SpreadMaxY = 865,
		SpreadMinX = 866,
		SpreadMinY = 867,
		SpreadRandomizeOriginPoint = 868,
		SpreadResetSpeed = 869,
		SpreadResetTimeThreshold = 870,
		SpreadUseCircularSpread = 871,
		SpreadUseEvenDistribution = 872,
		SpreadUseInAds = 873,
		SpreadZeroOnFirstShot = 874,
		StaggerDamageThreshold = 875,
		StaggerDamageThresholdImpulse = 876,
		StaggerDamageThresholdInCover = 877,
		Stamina = 878,
		StaminaCostReduction = 879,
		StaminaCostToBlock = 880,
		StaminaDamage = 881,
		StaminaRegenDelayOnChange = 882,
		StaminaRegenEnabled = 883,
		StaminaRegenEndThrehold = 884,
		StaminaRegenRate = 885,
		StaminaRegenRateAdd = 886,
		StaminaRegenRateBase = 887,
		StaminaRegenRateMult = 888,
		StaminaRegenStartDelay = 889,
		StaminaRegenStartThreshold = 890,
		StaminaSprintDecayRate = 891,
		StatModifierGroupLimit = 892,
		Stealth = 893,
		StealthHacksCostReduction = 894,
		StealthHitDamageMultiplier = 895,
		StealthMastery = 896,
		StealthTrait01Stat = 897,
		StealthWeakspotDamageMultiplier = 898,
		StreetCred = 899,
		Strength = 900,
		StunImmunity = 901,
		Sway = 902,
		SwayCenterMaximumAngleOffset = 903,
		SwayCurvatureMaximumFactor = 904,
		SwayCurvatureMinimumFactor = 905,
		SwayInitialOffsetRandomFactor = 906,
		SwayResetOnAimStart = 907,
		SwaySideBottomAngleLimit = 908,
		SwaySideMaximumAngleDistance = 909,
		SwaySideMinimumAngleDistance = 910,
		SwaySideStepChangeMaximumFactor = 911,
		SwaySideStepChangeMinimumFactor = 912,
		SwaySideTopAngleLimit = 913,
		SwayStartBlendTime = 914,
		SwayStartDelay = 915,
		SwayTraversalTime = 916,
		SystemCollapseImmunity = 917,
		TBHsBaseCoefficient = 918,
		TBHsBaseSourceMultiplierCoefficient = 919,
		TBHsCoverTraceLoSIncreaseSpeed = 920,
		TBHsMinimumLineOfSightTime = 921,
		TBHsSensesTraceLoSIncreaseSpeed = 922,
		TBHsVisibilityCooldown = 923,
		TechBaseChargeThreshold = 924,
		TechMaxChargeThreshold = 925,
		TechOverChargeThreshold = 926,
		TechPierceChargeLevel = 927,
		TechPierceEnabled = 928,
		TechnicalAbility = 929,
		ThermalDamage = 930,
		ThermalDamageMax = 931,
		ThermalDamageMin = 932,
		ThermalDamagePercent = 933,
		ThermalResistance = 934,
		ThreeOrMoreProgramsCooldownRedPerk = 935,
		ThreeOrMoreProgramsMemoryRegPerk = 936,
		TimeDilationGenericDuration = 937,
		TimeDilationGenericTimeScale = 938,
		TimeDilationKerenzikovDuration = 939,
		TimeDilationKerenzikovPlayerTimeScale = 940,
		TimeDilationKerenzikovTimeScale = 941,
		TimeDilationOnDodgesCooldownDuration = 942,
		TimeDilationOnDodgesDuration = 943,
		TimeDilationOnDodgesTimeScale = 944,
		TimeDilationOnHealthDropCooldownDuration = 945,
		TimeDilationOnHealthDropDuration = 946,
		TimeDilationOnHealthDropTimeScale = 947,
		TimeDilationSandevistanCooldownBase = 948,
		TimeDilationSandevistanCooldownReduction = 949,
		TimeDilationSandevistanDuration = 950,
		TimeDilationSandevistanTimeScale = 951,
		TimeDilationWhenEnteringCombatCooldownDuration = 952,
		TimeDilationWhenEnteringCombatDuration = 953,
		TimeDilationWhenEnteringCombatTimeScale = 954,
		TranquilizerImmunity = 955,
		TriggerDismembermentChance = 956,
		TriggerWoundedChance = 957,
		TurretFriendlyExtension = 958,
		TurretShutdownExtension = 959,
		UltimateHackSpread = 960,
		UltimateHacksCostReduction = 961,
		UltimateMemoryCostReduction = 962,
		UnconsciousImmunity = 963,
		UnequipAnimationDuration_Corpo = 964,
		UnequipAnimationDuration_Gang = 965,
		UnequipDuration = 966,
		UnequipDuration_Corpo = 967,
		UnequipDuration_Gang = 968,
		UnequipItemTime_Corpo = 969,
		UnequipItemTime_Gang = 970,
		UnlockProgress = 971,
		UpgradingCostReduction = 972,
		UpgradingMaterialDropChance = 973,
		UpgradingMaterialRandomGrantChance = 974,
		UpgradingMaterialRetrieveChance = 975,
		UploadQuickHackMod = 976,
		Visibility = 977,
		VisualStimRangeMultiplier = 978,
		VulnerabilityExtension = 979,
		WallRunHorSpeedToEnterMin = 980,
		WallRunStrafeAngleMax = 981,
		WallRunTimeMax = 982,
		WallRunVertSpeedToEnterMax = 983,
		WasItemUpgraded = 984,
		WasQuickHacked = 985,
		WeakspotDamageMultiplier = 986,
		WeaponHasAutoloader = 987,
		WeaponNoise = 988,
		WeaponPosAdsX = 989,
		WeaponPosAdsY = 990,
		WeaponPosAdsZ = 991,
		WeaponPosX = 992,
		WeaponPosY = 993,
		WeaponPosZ = 994,
		WeaponRotAdsX = 995,
		WeaponRotAdsY = 996,
		WeaponRotAdsZ = 997,
		WeaponRotX = 998,
		WeaponRotY = 999,
		WeaponRotZ = 1000,
		Weight = 1001,
		WoundHeadDamageThreshold = 1002,
		WoundLArmDamageThreshold = 1003,
		WoundLLegDamageThreshold = 1004,
		WoundRArmDamageThreshold = 1005,
		WoundRLegDamageThreshold = 1006,
		ZoomLevel = 1007,
		CPO_Armor = 1008,
		CPO_NPC_Importance = 1009,
		Count = 1010,
		Invalid = 1011
	}

	public enum gamedataStatusEffectAIBehaviorFlag
	{
		AcceptsAdditives = 0,
		InterruptsForcedBehavior = 1,
		InterruptsSamePriorityTask = 2,
		None = 3,
		OverridesSelf = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataStatusEffectAIBehaviorType
	{
		Basic = 0,
		None = 1,
		Stoppable = 2,
		Unstoppable = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataStatusEffectType
	{
		AndroidTurnOff = 0,
		AndroidTurnOn = 1,
		Berserk = 2,
		Berserker = 3,
		BlackwallHack = 4,
		Bleeding = 5,
		Blind = 6,
		BlockCoverVisibilityReduction = 7,
		BlockTargetingPlayer = 8,
		BrainMelt = 9,
		Burning = 10,
		Cloaked = 11,
		CommsCall = 12,
		CommsNoise = 13,
		Crippled = 14,
		DamageBurst = 15,
		Deafened = 16,
		Defeated = 17,
		DefeatedWithRecover = 18,
		EMP = 19,
		Electrocuted = 20,
		Exhausted = 21,
		ForceShoot = 22,
		Grapple = 23,
		Housing = 24,
		Jam = 25,
		JamCommuniations = 26,
		Kill = 27,
		Knockdown = 28,
		Madness = 29,
		MagnetDeviceNPC = 30,
		MechWeaponsDown = 31,
		MeleeInvulnerability = 32,
		Misc = 33,
		MuteAudioStims = 34,
		NetwatcherHackStage1 = 35,
		NetwatcherHackStage2 = 36,
		NetwatcherHackStage3 = 37,
		Overheat = 38,
		Overload = 39,
		Pain = 40,
		PassiveBuff = 41,
		PassiveDebuff = 42,
		PlayerCooldown = 43,
		Poisoned = 44,
		QuickHackFreezeLocomotion = 45,
		QuickHackStaggerCyberware = 46,
		QuickHackStaggerLocomotion = 47,
		QuickHackStaggerWeapon = 48,
		Quickhack = 49,
		Regeneration = 50,
		Sandevistan = 51,
		SetFriendly = 52,
		Sleep = 53,
		SoftKill = 54,
		Stagger = 55,
		StrongArmsActive = 56,
		Stunned = 57,
		SuicideHack = 58,
		SystemCollapse = 59,
		Unconscious = 60,
		UncontrolledMovement = 61,
		VehicleKnockdown = 62,
		WeakspotOverload = 63,
		Wounded = 64,
		CPOShocked = 65,
		Count = 66,
		Invalid = 67
	}

	public enum gamedataStatusEffectVariation
	{
		Bike = 0,
		Default = 1,
		Vehicle = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataStimPriority
	{
		High = 0,
		Low = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataStimPropagation
	{
		Audio = 0,
		Visual = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataStimTargets
	{
		All = 0,
		Puppets = 1,
		Vehicles = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataStimType
	{
		AimingAt = 0,
		Alarm = 1,
		AreaEffect = 2,
		AskToFollowOrder = 3,
		Attention = 4,
		AudioEnemyPing = 5,
		Bullet = 6,
		Bump = 7,
		Call = 8,
		CarAlarm = 9,
		CarryBody = 10,
		Combat = 11,
		CombatCall = 12,
		CombatHit = 13,
		CombatWhistle = 14,
		CrimeWitness = 15,
		CrowdIllegalAction = 16,
		DeadBody = 17,
		DeviceExplosion = 18,
		Distract = 19,
		DodgeVehicle = 20,
		Driving = 21,
		Dying = 22,
		EnvironmentalHazard = 23,
		Explosion = 24,
		FootStepRegular = 25,
		FootStepSprint = 26,
		GrenadeLanded = 27,
		Gunshot = 28,
		Hacked = 29,
		HijackVehicle = 30,
		IllegalAction = 31,
		IllegalActionNoCombat = 32,
		IllegalInteraction = 33,
		LandingHard = 34,
		LandingRegular = 35,
		LandingVeryHard = 36,
		MeleeAttack = 37,
		MeleeHit = 38,
		OpeningDoor = 39,
		ProjectileDistraction = 40,
		Provoke = 41,
		Recon = 42,
		ReevaluateDetectionOverwrite = 43,
		Reload = 44,
		Reprimand = 45,
		ReprimandFinalWarning = 46,
		Scream = 47,
		SecurityBreach = 48,
		SilencedGunshot = 49,
		SilentAlarm = 50,
		SoundDistraction = 51,
		SpreadFear = 52,
		StopedAiming = 53,
		Terror = 54,
		TooCloseDistance = 55,
		UndeadCall = 56,
		VehicleHit = 57,
		VehicleHorn = 58,
		VisualDistract = 59,
		WarningDistance = 60,
		WeaponDisplayed = 61,
		WeaponHolstered = 62,
		WeaponSafe = 63,
		Whistle = 64,
		Count = 65,
		Invalid = 66
	}

	public enum gamedataSubCharacter
	{
		Flathead = 0,
		Count = 1,
		Invalid = 2
	}

	public enum gamedataTrackingMode
	{
		BeliefPosition = 0,
		LastKnownPosition = 1,
		RealPosition = 2,
		SharedBeliefPosition = 3,
		SharedLastKnownPosition = 4,
		Count = 5,
		Invalid = 6
	}

	public enum gamedataTraitType
	{
		AssaultTrait01 = 0,
		AthleticsTrait01 = 1,
		BrawlingTrait01 = 2,
		ColdBloodTrait01 = 3,
		CombatHackingTrait01 = 4,
		CraftingTrait01 = 5,
		DemolitionTrait01 = 6,
		EngineeringTrait01 = 7,
		GunslingerTrait01 = 8,
		HackingTrait01 = 9,
		KenjutsuTrait01 = 10,
		StealthTrait01 = 11,
		Count = 12,
		Invalid = 13
	}

	public enum gamedataTriggerMode
	{
		Burst = 0,
		Charge = 1,
		FullAuto = 2,
		Lock = 3,
		SemiAuto = 4,
		Windup = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataTweakDBType
	{
		Invalid = 0,
		ForeignKey = 1,
		Int = 2,
		Float = 3,
		Bool = 4,
		String = 5,
		CName = 6,
		ResRef = 7,
		LocKey = 8,
		Color = 9,
		Vector2 = 10,
		Vector3 = 11,
		EulerAngles = 12,
		Quaternion = 13
	}

	public enum gamedataUICondition
	{
		InEyesSubMenu = 0,
		InHandsSubMenu = 1,
		InSubMenu = 2,
		IsIntroFinished = 3,
		IsSetEquippingSubMenu = 4,
		Visible = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataUIIconCensorFlag
	{
		Drugs = 0,
		Gore = 1,
		Homosexuality = 2,
		None = 3,
		Nudity = 4,
		OverSexualised = 5,
		Religion = 6,
		Suggestive = 7,
		Count = 8,
		Invalid = 9
	}

	public enum gamedataUINameplateDisplayType
	{
		AfterScan = 0,
		Always = 1,
		Default = 2,
		Never = 3,
		Count = 4,
		Invalid = 5
	}

	public enum gamedataVariableNodeVariableValueDeriveInfo : byte
	{
		NotDerived = 0,
		ArrayAddition = 1
	}

	public enum gamedataVehicleManufacturer
	{
		Arch = 0,
		Archer = 1,
		Aurochs = 2,
		Brennan = 3,
		Chevillon = 4,
		Delamain = 5,
		Herrera = 6,
		Kaukaz = 7,
		Mahir = 8,
		Makigai = 9,
		Militech = 10,
		Mizutani = 11,
		Porsche = 12,
		Quadra = 13,
		Rayfield = 14,
		Seamurai = 15,
		Thorton = 16,
		Villefort = 17,
		Yaiba = 18,
		Zetatech = 19,
		Count = 20,
		Invalid = 21
	}

	public enum gamedataVehicleModel
	{
		Aerondight = 0,
		Alvarado = 1,
		Basilisk = 2,
		Bratsk = 3,
		Colby = 4,
		Columbus = 5,
		Cortes = 6,
		Deleon = 7,
		Emperor = 8,
		Galena = 9,
		GalenaNomad = 10,
		Hearse = 11,
		Hozuki = 12,
		Kusanagi = 13,
		Mackinaw = 14,
		Maimai = 15,
		Merrimac = 16,
		Octant = 17,
		Riptide = 18,
		Shion = 19,
		Supron = 20,
		Thrax = 21,
		Turbo = 22,
		Type66 = 23,
		Zeya = 24,
		Count = 25,
		Invalid = 26
	}

	public enum gamedataVehicleType
	{
		Bike = 0,
		Car = 1,
		Panzer = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataVehicleUnlockType
	{
		CourierMissions = 0,
		Quest = 1,
		StreetCred = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataVendorType
	{
		Armorsmith = 0,
		Clothes = 1,
		Clothing = 2,
		Cyberware = 3,
		Drinks = 4,
		DropPoint = 5,
		Food = 6,
		GrilledFood = 7,
		Gunsmith = 8,
		Junk = 9,
		Kiosk = 10,
		Market = 11,
		Medical = 12,
		PackedFood = 13,
		RipperDoc = 14,
		SkillTrainer = 15,
		Tech = 16,
		TechJunk = 17,
		VendingMachine = 18,
		Count = 19,
		Invalid = 20
	}

	public enum gamedataWeaponEvolution
	{
		Blade = 0,
		Blunt = 1,
		None = 2,
		Power = 3,
		Smart = 4,
		Tech = 5,
		Throwable = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataWeaponManufacturer
	{
		Corporation = 0,
		Street = 1,
		Count = 2,
		Invalid = 3
	}

	public enum gamedataWidgetStyle
	{
		Arasaka = 0,
		DarkNet = 1,
		Konopeki = 2,
		Maelstrom = 3,
		Militech = 4,
		None = 5,
		Zetatech = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataWorkspotActionType
	{
		DeviceInvestigation = 0,
		FearHide = 1,
		LookAround = 2,
		Count = 3,
		Invalid = 4
	}

	public enum gamedataWorkspotCategory
	{
		Any = 0,
		Eating = 1,
		Nervous = 2,
		Sitting = 3,
		Sleeping = 4,
		Smoking = 5,
		Count = 6,
		Invalid = 7
	}

	public enum gamedataWorkspotReactionType
	{
		Anger = 0,
		BumpLeftBack = 1,
		BumpLeftFront = 2,
		BumpRightBack = 3,
		BumpRightFront = 4,
		Curious = 5,
		Fear = 6,
		Count = 7,
		Invalid = 8
	}

	public enum gamedataWorldMapFilter
	{
		ApartmentToPurchaseFilter = 0,
		AutofixerFilter = 1,
		CommonFilter = 2,
		Courier = 3,
		CustomFilter = 4,
		DogtownGateFilter = 5,
		DropPoint = 6,
		ExplorationFilter = 7,
		FastTravel = 8,
		Gigs = 9,
		NoFilter = 10,
		Outpost = 11,
		PsychoFilter = 12,
		Quest = 13,
		RelicDeviceFilter = 14,
		RipperdocFilter = 15,
		ServicePoint = 16,
		Story = 17,
		TarotFilter = 18,
		VehicleForSaleFilter = 19,
		VendorFilter = 20,
		Count = 21,
		Invalid = 22
	}

	public enum gamedeviceActionPropertyFlags
	{
		None = 0,
		IsUsedByQuest = 1
	}

	public enum gamedeviceRequestType
	{
		None = 0,
		External = 1,
		Remote = 2,
		Direct = 3,
		Internal = 4
	}

	public enum gameeventsDeathDirection
	{
		Undefined = 0,
		Left = 1,
		Backward = 2,
		Right = 3,
		Forward = 4
	}

	public enum gameinfluenceCollisionTestOutcome
	{
		NoCell = 0,
		Empty = 1,
		Full = 2
	}

	public enum gameinfluenceEBoundingBoxType
	{
		Colider = 0,
		Custom = 1
	}

	public enum gameinfluenceTestLineResult
	{
		Fail = 0,
		Success = 1,
		Unknown = 2
	}

	public enum gameinputActionType
	{
		BUTTON_PRESSED = 0,
		BUTTON_RELEASED = 1,
		BUTTON_HOLD_PROGRESS = 2,
		BUTTON_HOLD_COMPLETE = 3,
		BUTTON_MULTITAP_BEGIN_LAST = 4,
		BUTTON_MULTITAP_END_LAST = 5,
		AXIS_CHANGE = 6,
		RELATIVE_CHANGE = 7,
		TOGGLE_PRESSED = 8,
		TOGGLE_RELEASED = 9,
		REPEAT = 10
	}

	public enum gameinteractionsBumpIntensity
	{
		Invalid = 0,
		Light = 1,
		Medium = 2,
		Heavy = 3,
		Strafe = 4
	}

	public enum gameinteractionsBumpLocation
	{
		Invalid = 0,
		Front = 1,
		Back = 2
	}

	public enum gameinteractionsBumpSide
	{
		Invalid = 0,
		Left = 1,
		Right = 2
	}

	public enum gameinteractionsBumpType
	{
		Workspot = 0,
		Crowd = 1
	}

	public enum gameinteractionsChoiceLookAtType
	{
		Root = 0,
		Slot = 1,
		Orb = 2
	}

	public enum gameinteractionsChoiceType
	{
		QuestImportant = 1,
		AlreadyRead = 2,
		Inactive = 4,
		CheckSuccess = 8,
		CheckFailed = 16,
		InnerDialog = 32,
		PossessedDialog = 64,
		TimedDialog = 128,
		Blueline = 256,
		Pay = 512,
		Selected = 1024,
		Illegal = 2048,
		Glowline = 4096
	}

	public enum gameinteractionsEBinaryOperator
	{
		EBinaryOperator_and = 0,
		EBinaryOperator_or = 1
	}

	public enum gameinteractionsEGroupType
	{
		EGT_default = 0,
		EGT_noInput = 1,
		EGT_hint = 2
	}

	public enum gameinteractionsEInteractionEventType
	{
		EIET_activate = 0,
		EIET_deactivate = 1
	}

	public enum gameinteractionsELookAtTarget
	{
		Entity = 0,
		Component = 1
	}

	public enum gameinteractionsELookAtTest
	{
		Targeting = 0,
		Interaction = 1
	}

	public enum gameinteractionsELootChoiceType
	{
		Available = 0,
		Unavailable = 1,
		Invisible = 2
	}

	public enum gameinteractionsELootVisualiserControlOperation
	{
		Locked = 1
	}

	public enum gameinteractionsEPredicateType
	{
		EPredicateFunction_true = 0,
		EPredicateFunction_distanceFromScreenCentre = 1,
		EPredicateFunction_containedInShapes = 2,
		EPredicateFunction_onScreenTest = 3,
		EPredicateFunction_visibleTarget = 4,
		EPredicateFunction_lookAt = 5,
		EPredicateFunction_lookAtComponent = 6,
		EPredicateFunction_logicalLookAt = 7,
		EPredicateFunction_obstructedLookAt = 8,
		EPredicateFunction_lineOfSight = 4
	}

	public enum gameinteractionsEUnaryOperator
	{
		EUnaryOperator_empty = 0,
		EUnaryOperator_not = 1
	}

	public enum gameinteractionsReactionState
	{
		Idle = 0,
		Starting = 1,
		InInteraction = 2,
		Finishing = 3,
		Canceling = 4
	}

	public enum gameinteractionsvisEVisualizerActivityState
	{
		None = 0,
		Visible = 1,
		Available = 2,
		Active = 3
	}

	public enum gameinteractionsvisEVisualizerDefinitionFlags : ushort
	{
		None = 0,
		Fading = 1,
		HeadlineSelection = 2,
		QuestImportant = 8,
		CPO_Mode = 16
	}

	public enum gameinteractionsvisEVisualizerRuntimeFlags : ushort
	{
		None = 0,
		Locked = 1,
		Failsafe = 2,
		Dbg_Active = 4
	}

	public enum gameinteractionsvisEVisualizerType
	{
		Device = 0,
		Dialog = 1,
		Loot = 2,
		Invalid = 3
	}

	public enum gameinteractionsvisInteractionType : byte
	{
		LookAt = 0,
		Proximity = 1
	}

	public enum gamemappinsMappinTargetType
	{
		World = 0,
		Minimap = 1,
		Map = 2
	}

	public enum gamemappinsVerticalPositioning
	{
		Above = 0,
		Same = 1,
		Below = 2
	}

	public enum gameprojectileELaunchMode
	{
		Default = 0,
		FromLogic = 1,
		FromVisuals = 2
	}

	public enum gameprojectileOnCollisionAction
	{
		None = 0,
		Stop = 1,
		Bounce = 2,
		StopAndStick = 3,
		StopAndStickPerpendicular = 4,
		Pierce = 5
	}

	public enum gameprojectileParabolicUnknownVariable
	{
		TargetPoint = 0,
		VelocityValue = 1,
		Accel = 2
	}

	public enum gamesmartGunTargetState
	{
		Visible = 1,
		Targetable = 2,
		Locking = 4,
		Locked = 16,
		Unlocking = 8
	}

	public enum gamestateMachineParameterAspect
	{
		Temporary = 0,
		Permanent = 1,
		Conditional = 2
	}

	[Flags]
	public enum gametargetingSystemAimAssistFilter
	{
		Melee = 1 << 0,
		Shooting = 1 << 1,
		Scanning = 1 << 2,
		QuickHack = 1 << 3,
		ShootingLimbCyber = 1 << 4,
		HeadTarget = 1 << 5,
		LegTarget = 1 << 6,
		MechanicalTarget = 1 << 7,
		DriverCombat = 1 << 8,
		BreachTarget = 1 << 9
	}

	public enum gametargetingSystemETargetFilterStatus
	{
		Stop = 0,
		Continue = 1
	}

	public enum gametargetingSystemScriptFilter
	{
		Melee = 1,
		Shooting = 2,
		Scanning = 4,
		QuickHack = 8,
		ShootingLimbCyber = 16,
		HeadTarget = 32,
		LegTarget = 64,
		MechanicalTarget = 128
	}

	public enum gametargetingSystemSearchFilterMaskValue
	{
		Obj_Player = 1,
		Obj_Puppet = 2,
		Obj_Sensor = 4,
		Obj_Device = 8,
		Obj_Other = 16,
		Att_Friendly = 32,
		Att_Hostile = 64,
		Att_Neutral = 128,
		Sp_AimAssistEnabled = 256,
		Sp_Aggressive = 512,
		St_Alive = 2048,
		St_Dead = 4096,
		St_NotDefeated = 8192,
		St_Defeated = 16384,
		St_Conscious = 32768,
		St_Unconscious = 65536,
		St_TurnedOn = 131072,
		St_TurnedOff = 262144,
		St_QuickHackable = 524288,
		St_AliveAndActive = 174080
	}

	public enum gameuiActivePhoneElement
	{
		Call = 1,
		IncomingCall = 2,
		Contacts = 4,
		SmsMessenger = 8,
		Notifications = 16,
		InVehicle = 32,
		None = 64
	}

	public enum gameuiAuthorisationNotificationType
	{
		Unknown = 0,
		GotKeycard = 1,
		AccessGranted = 2
	}

	public enum gameuiBaseMenuGameControllerPuppetGenderInfo
	{
		Male = 0,
		Female = 1,
		ShouldBeDetermined = 2
	}

	public enum gameuiBinkVideoStatus
	{
		Idle = 0,
		NotStarted = 1,
		Initializing = 2,
		Playing = 3,
		Finished = 4,
		OutOfFrustum = 5,
		Stopped = 6,
		Error = 7
	}

	public enum gameuiCharacterCustomizationActionType
	{
		Activate = 0,
		Deactivate = 1,
		EquipItem = 2,
		UnequipItem = 3,
		Refresh = 4
	}

	public enum gameuiCharacterCustomizationEditTag
	{
		NewGame = 0,
		HairDresser = 1,
		Ripperdoc = 2
	}

	public enum gameuiCharacterCustomizationPart
	{
		Head = 0,
		Body = 1,
		Arms = 2
	}

	public enum gameuiCharacterCustomization_BrokenNoseStage
	{
		CCBN_Disabled = 0,
		CCBN_Stage1 = 1,
		CCBN_Stage2 = 2,
		CCBN_FinalScene = 3
	}

	public enum gameuiChoiceIndicatorType
	{
		Default = 0,
		Speech = 1,
		Call = 2,
		Arrow = 3,
		Hand = 4,
		Loot = 5,
		Quest = 6,
		FastTravel = 7,
		Solo = 9,
		Netrunner = 10,
		Techie = 12
	}

	public enum gameuiChoiceListVisualizerType
	{
		Interaction = 0,
		Dialog = 1
	}

	[Flags]
	public enum gameuiContext
	{
		Default = 1 << 0,
		QuickHack = 1 << 1,
		Scanning = 1 << 2,
		DeviceZoom = 1 << 3,
		BraindanceEditor = 1 << 4,
		BraindancePlayback = 1 << 5,
		VehicleMounted = 1 << 6,
		ModalPopup = 1 << 7,
		RadialWheel = 1 << 8,
		VehicleRace = 1 << 9,
		Berserk = 1 << 10,
		MAX = 1 << 31
	}

	public enum gameuiCyberspaceElementType
	{
		CyberspaceNPC = 0,
		CyberspaceFakeObject = 1
	}

	public enum gameuiDamageDigitsMode
	{
		Off = 0,
		Individual = 1,
		Accumulated = 2,
		Both = 3
	}

	public enum gameuiDamageDigitsStickingMode
	{
		None = 0,
		Individual = 1,
		Accumulated = 2,
		Both = 3
	}

	public enum gameuiDamageIndicatorMode
	{
		Off = 0,
		DamageOnly = 1,
		On = 2
	}

	public enum gameuiDriverCombatCrosshairReticleDataState
	{
		Default = 0,
		Dot = 1
	}

	public enum gameuiEBraindanceLayer
	{
		Visual = 0,
		Audio = 1,
		Thermal = 2
	}

	public enum gameuiEClueDescriptorMode
	{
		Invalid = 0,
		Add = 1,
		Finish = 2
	}

	public enum gameuiEIconOrientation
	{
		Upright = 0,
		Entity = 1
	}

	public enum gameuiETooltipPlacement : byte
	{
		LeftCenter = 0,
		RightCenter = 1,
		LeftTop = 2,
		RightTop = 3
	}

	public enum gameuiEWorldMapCameraMode : byte
	{
		TopDown = 0,
		ZoomLevels = 1,
		COUNT = 2
	}

	public enum gameuiEWorldMapDistrictView
	{
		None = 0,
		Districts = 1,
		SubDistricts = 2
	}

	public enum gameuiGenericNotificationType : byte
	{
		Generic = 0,
		QuestUpdate = 1,
		Vendor = 3,
		ZoneAlert = 4,
		VehicleAlert = 5,
		PreventionBounty = 6,
		ProgressionView = 7
	}

	public enum gameuiHackingMinigameState
	{
		Unknown = 0,
		InProgress = 1,
		Succeeded = 2,
		Failed = 3
	}

	public enum gameuiHitType
	{
		Miss = 0,
		Glance = 1,
		Hit = 2,
		CriticalHit = 3,
		CriticalHit_x2 = 4,
		Special = 5
	}

	public enum gameuiInputHintSortingPriority
	{
		Top = -2147483648,
		Bottom = 2147483646,
		Invalid = 2147483647
	}

	public enum gameuiMappinGroupState
	{
		Ungrouped = 0,
		Grouped = 1,
		GroupedCollection = 2,
		GroupedHidden = 3
	}

	public enum gameuiOneTimeMessage
	{
		XboxCompatibilityLimitation = 0
	}

	public enum gameuiPatchIntro
	{
		Patch1500_NextGen = 0,
		Patch1600 = 1,
		Patch2000 = 2,
		Patch2000_EP1 = 3,
		Patch2100 = 4
	}

	public enum gameuiTutorialHiddenReason
	{
		None = 0,
		DefaultHiddenReason = 1,
		InPhotomode = 2
	}

	public enum gameuiarcadeArcadeColliderType
	{
		Body = 0,
		Up = 1,
		Right = 2,
		Bottom = 3,
		Left = 4
	}

	public enum gameuiarcadeArcadeMinigame
	{
		RoachRace = 0,
		Shooter = 1,
		Tank = 2
	}

	public enum gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum gameuiarcadeArcadeParallaxPlaneControllerLoopType
	{
		None = 0,
		Repeat = 1
	}

	public enum gameuiarcadeRoachRaceObjectType
	{
		BoostObject_Apple = 0,
		BoostObject_Carrot = 1,
		Obstacle = 2
	}

	public enum gameuiarcadeShooterAIType
	{
		MELEE = 0,
		RANGESHOOTER = 1,
		RANGEGRENADE = 2,
		FLYINGDRONE = 3,
		SPIDERDRONE = 4,
		POWERUPDRONE = 5,
		TRANSPORT = 6,
		VIP = 8,
		VIPPLAT = 9,
		LANDMINE = 12,
		BARREL = 13,
		NINJA = 14,
		BASILISK = 16,
		MEATHEAD = 15
	}

	public enum gameuiarcadeShooterLevelType
	{
		HORIZONTAL = 0,
		VERTICALUP = 1,
		VERTICALDOWN = 2
	}

	public enum gameuiarcadeShooterSpawnerCondition
	{
		ScreenLeft = 0,
		ScreenRight = 1,
		ScreenTop = 2,
		ScreenBottom = 3,
		EventTrigger = 4
	}

	public enum gameuiarcadeShooterTriggerType
	{
		Delay = 0,
		SpawnerFinish = 1,
		SpawnerObjectsDeath = 2
	}

	public enum gameuiarcadeTankEnemyMovementType
	{
		x_axis = 0,
		x_axisL = 1,
		x_axisR = 2,
		y_axis = 3
	}

	public enum gameuiarcadeTankPickupType
	{
		Patch_Kit = 0,
		AEAMS = 1,
		Mini_Tank = 2,
		Pile_of_Eddies = 3,
		Pile_of_Guns = 4
	}

	public enum gameweaponReloadStatus
	{
		Standard = 0,
		Interrupted = 1
	}

	public enum genLevelRandomizerDataSource
	{
		Entries = 0,
		Markers = 1
	}

	public enum grsDeathmatchStatus
	{
		Waiting = 0,
		AdditionalWaiting = 1,
		Starting = 2,
		InGame = 3,
		Ending = 4,
		Sumup = 5
	}

	public enum grsHeistStatus
	{
		Waiting = 0,
		Starting = 1,
		Lobby = 2,
		InGame = 3,
		Ending = 4,
		Victory = 5,
		Failure = 6
	}

	[Flags]
	public enum gsmGameDefType
	{
		BASE = 1 << 0,
		EP1 = 1 << 1,
		OTHER = 1 << 2
	}

	public enum gsmStateError
	{
		StateError_OK = 0,
		StateError_SettingsCorrupted = 1,
		StateError_SettingsCorrupted_Save = 2,
		StateError_ProfileCorrupted = 3,
		StateError_ProfileCorrupted_Save = 4,
		StateError_CannotInitializeContext = 5,
		StateError_CantLoadGameDefinition = 6,
		StateError_CantInitializeSession = 7,
		StateError_CantLoadSave_CantLoadFile = 8,
		StateError_CantLoadSave_CantCreateLoadStream = 9,
		StateError_CantLoadSave_CensorshipLevelMismatch = 10,
		StateError_CantLoadSave_RegionMismatch = 11,
		StateError_CantLoadSave_CensorshipOptionalNudity = 12,
		StateError_CantLoadSave_VersionMismatch = 13,
		StateError_CantLoadSave_Corrupted = 14,
		StateError_CantLoadSave_SessionDescInvalid = 15,
		StateError_CantLoadSave_CantLoadCloudFile = 16,
		StateError_CantLoadSave_AdditionalContentIDsMismatch = 17
	}

	public enum hitFlag
	{
		None = 0,
		IgnoreImmortalityModes = 1,
		FriendlyFire = 2,
		DisableSounds = 3,
		DisableVFX = 4,
		CannotReturnDamage = 5,
		CanParry = 6,
		CanCounter = 7,
		CanDodge = 8,
		WasBlocked = 9,
		WasDeflected = 10,
		WasDodged = 11,
		WasEvaded = 12,
		WasMitigated = 13,
		Kill = 14,
		DontShowDamageFloater = 15,
		DealNoDamage = 16,
		CannotModifyDamage = 17,
		Headshot = 18,
		CriticalHit = 19,
		FinisherTriggered = 20,
		DamageNullified = 21,
		Nonlethal = 22,
		WasKillingBlow = 23,
		ProcessDefeated = 24,
		Defeated = 25,
		SilentKillModifier = 26,
		DeterministicDamage = 27,
		WeakspotHit = 28,
		StealthHit = 29,
		DoNotTriggerFinisher = 30,
		DealtDamage = 31,
		ImmortalTarget = 32,
		CanDamageSelf = 33,
		SuccessfulAttack = 34,
		WeaponFullyCharged = 35,
		DisableNPCHitReaction = 36,
		VehicleDamage = 37,
		VehicleImpact = 38,
		VehicleImpactWithPlayer = 39,
		RagdollImpact = 40,
		IgnoreDifficulty = 41,
		QuickHack = 42,
		IgnoreVehicles = 43,
		DamageOverTime = 44,
		DotApplied = 45,
		OverridePlayerDamageWithFixedPercentage = 46,
		DeviceExplosionAttack = 47,
		NPCPassengerVehicleCollision = 48,
		TargetWasAlreadyDeadNoStatPool = 49,
		PROJECT_SPECIFIC_FLAGS = 100000,
		UsedKerenzikov = 100001,
		FragmentationSplinter = 100002,
		DetonateGrenades = 100003,
		WeakExplosion = 100004,
		BulletExplosion = 100005,
		GrenadeQuickhackExplosion = 100006,
		FriendlyFireIgnored = 100007,
		ForceNoCrit = 100008,
		ReduceDamage = 100009,
		ForceDismember = 100010,
		SaburoKatana = 100011,
		SaburoTanto = 100012,
		WasBulletParried = 100013,
		WasBulletDeflected = 100014,
		WasBulletBlocked = 100015,
		HauntedCyberdeck = 100016,
		HauntedGun = 100017,
		HauntedKill = 100018,
		BreachHit = 100019,
		OnePunch = 100020,
		GrandFinale = 100021,
		BleedingDot = 100022,
		AirDropBurningDoT = 100023,
		BreachExplosion = 100024,
		RevengeActivatingHit = 100025,
		GroundSlam = 100026,
		PerfectlyCharged = 100027,
		ChainLightning = 100028,
		CWExplosion = 100029,
		RelicGoldenNumbers = 100030,
		CannotKillPlayer = 100031,
		ExplosionOverride = 100032,
		Overheat = 100033,
		HighSpeedMelee = 100034,
		PlayerWallImpact = 100035,
		Explosion = 100036,
		StunApplied = 100037,
		IgnoreStatPoolCustomLimit = 100038,
		ForceKnockdown = 100039,
		DisablePlayerHitReaction = 100040,
		ReflexesMasterPerk1 = 100041,
		BodyPerksMeleeAttack = 100042,
		CriticalHitNoDamageModifier = 100043,
		Special = 100044,
		CWMalfunctionEMPExplosion = 100045,
		UltimateQuickHack = 100046,
		DamageBasedOnMissingMemoryBonus = 100047,
		ProjectileLauncherAttack = 100048,
		ForceHeadshotMult10 = 100049,
		ForceHeadshotMult25 = 100050,
		ForceWeakspotMult10 = 100051,
		ForceWeakspotMult25 = 100052
	}

	public enum inkBrushDrawType : byte
	{
		NoDraw = 0,
		Solid = 1,
		Wire = 2
	}

	public enum inkBrushMirrorType : byte
	{
		NoMirror = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3
	}

	public enum inkBrushTileType : byte
	{
		NoTile = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3
	}

	public enum inkCacheMode : byte
	{
		Normal = 0,
		Minimap = 1,
		ExternalDynamicTexture = 2
	}

	public enum inkCharacterEventType : byte
	{
		CharInput = 0,
		MoveCaretForward = 1,
		MoveCaretBackward = 2,
		Delete = 3,
		Backspace = 4
	}

	public enum inkCompositionParamType : byte
	{
		FLOAT = 0,
		VECTOR2 = 1
	}

	public enum inkDiscreteNavigationDirection : byte
	{
		Up = 0,
		Right = 1,
		Down = 2,
		Left = 3
	}

	public enum inkDisplayMode
	{
		Invalid = 0,
		Basic = 1,
		BasicTranslatable = 2,
		Bold = 3,
		Header = 4,
		Single = 5
	}

	public enum inkEAnchor : byte
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		CenterLeft = 3,
		Centered = 4,
		CenterRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8,
		TopFillHorizontaly = 9,
		CenterFillHorizontaly = 10,
		BottomFillHorizontaly = 11,
		LeftFillVerticaly = 12,
		CenterFillVerticaly = 13,
		RightFillVerticaly = 14,
		Fill = 15
	}

	public enum inkEBlurDimension
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum inkEButtonState
	{
		Normal = 0,
		Hover = 1,
		Press = 2,
		Disabled = 3
	}

	public enum inkEChildOrder : byte
	{
		Forward = 0,
		Backward = 1
	}

	public enum inkEEndCapStyle
	{
		BUTT = 0,
		SQUARE = 1,
		ROUND = 2,
		JOINED = 3
	}

	public enum inkEHorizontalAlign : byte
	{
		Fill = 0,
		Left = 1,
		Center = 2,
		Right = 3
	}

	public enum inkEJointStyle
	{
		MITER = 0,
		BEVEL = 1,
		ROUND = 2
	}

	public enum inkELayerLoadPriority : byte
	{
		Normal = 0,
		High = 1
	}

	public enum inkELayerType : byte
	{
		Watermarks = 0,
		WaitingSign = 1,
		SystemNotifications = 2,
		Loading = 3,
		GameNotifications = 4,
		Menu = 5,
		Video = 6,
		HUD = 7,
		Editor = 8,
		World = 9,
		Offscreen = 10,
		Advertisements = 11,
		StreetSigns = 12,
		PhotoMode = 13,
		Debug = 14,
		MAX = 15
	}

	public enum inkEOrientation : byte
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum inkEScrollDirection
	{
		Vertical = 0,
		Horizontal = 1
	}

	public enum inkEShapeVariant
	{
		Fill = 0,
		Border = 1,
		FillAndBorder = 2
	}

	public enum inkESizeRule : byte
	{
		Fixed = 0,
		Stretch = 1
	}

	public enum inkESliderDirection
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum inkETextDirection
	{
		LeftToRight = 0,
		RightToLeft = 1,
		Mixed = 2
	}

	public enum inkETextureResolution : byte
	{
		UltraHD_3840_2160 = 0,
		FullHD_1920_1080 = 1,
		HD_1280_720 = 2
	}

	public enum inkEToggleState
	{
		Normal = 0,
		Press = 1,
		Hover = 2,
		Disabled = 3,
		Toggled = 4,
		ToggledPress = 5,
		ToggledHover = 6
	}

	public enum inkEVerticalAlign : byte
	{
		Fill = 0,
		Top = 1,
		Center = 2,
		Bottom = 3
	}

	public enum inkEffectType : byte
	{
		ScanlineWipe = 0,
		LinearWipe = 1,
		RadialWipe = 2,
		LightSweep = 3,
		BoxBlur = 4,
		Mask = 5,
		Glitch = 6,
		PointCloud = 7,
		ColorFill = 8,
		InnerGlow = 9,
		ColorCorrection = 10,
		Multisampling = 11,
		Blackwall = 12
	}

	public enum inkFinalConfigurationVisibility
	{
		VisibleOnlyInFinal = 0,
		HiddenOnlyInFinal = 1
	}

	public enum inkFitToContentDirection
	{
		None = 0,
		Horizontal = 2,
		Vertical = 1
	}

	public enum inkFocusCause : byte
	{
		Mouse = 0,
		Navigation = 1,
		SetDirectly = 2,
		Cleared = 3,
		OtherWidgetLostFocus = 4,
		WindowActivate = 5
	}

	public enum inkGradientMode : byte
	{
		Linear = 0,
		Rectangular = 1
	}

	public enum inkIconResult
	{
		Success = 0,
		UnknownIconTweak = 1,
		AtlasResourceNotFound = 2,
		PartNotFoundInAtlas = 3
	}

	public enum inkInputHintHoldIndicationType : byte
	{
		FromInputConfig = 0,
		Press = 1,
		Hold = 2
	}

	public enum inkInputHintKeyCombinationType
	{
		Or = 0,
		And = 1
	}

	public enum inkLanguageId
	{
		EN = 0,
		PL = 1,
		JP = 2,
		DE = 3,
		ES = 4,
		MX = 5,
		KR = 6,
		IT = 7,
		FR = 8,
		RU = 9,
		PR = 10,
		ZH_CN = 11,
		TW = 12,
		CZ = 13,
		HU = 14,
		AR = 15,
		TR = 16,
		TH = 17,
		HT = 18,
		UA = 20,
		DEBUG = 21
	}

	public enum inkLastTickVideoState
	{
		NotDrawn = 0,
		Drawn = 1,
		Paused = 2
	}

	public enum inkLayerDrawingPolicy
	{
		InOrder = 0,
		InParallel = 1
	}

	public enum inkLifePath : byte
	{
		Corporate = 0,
		StreetKid = 2,
		Nomad = 1,
		Invalid = 3
	}

	public enum inkLineType : byte
	{
		RegularPatternSpacing = 0,
		LoosePatternSpacing = 1
	}

	public enum inkLoadingScreenType
	{
		Unknown = 0,
		SplashScreen = 1,
		Initial = 2,
		FastTravel = 3
	}

	public enum inkMaskDataSource : byte
	{
		TextureAtlas = 0,
		DynamicTexture = 1
	}

	public enum inkMenuMode
	{
		Unknown = 0,
		PauseMenu = 1,
		HubMenu = 2,
		CustomMenu = 3
	}

	public enum inkMenuState
	{
		Enabled = 0,
		Disabled = 1
	}

	public enum inkRumblePosition : byte
	{
		Both = 0,
		Left = 1,
		Right = 2
	}

	public enum inkRumbleStrength : byte
	{
		SuperLight = 0,
		Light = 1,
		Medium = 2,
		Heavy = 3
	}

	public enum inkRumbleType : byte
	{
		Fast = 0,
		Pulse = 1,
		Slow = 2
	}

	public enum inkSaveStatus : byte
	{
		Invalid = 0,
		Local = 1,
		Upload = 2,
		Cloud = 3,
		InSync = 4
	}

	public enum inkSaveTransferStatus : byte
	{
		ExportStarted = 0,
		ExportSuccess = 1,
		ExportFailed = 2,
		ImportChecking = 3,
		ImportStarted = 4,
		ImportSuccess = 5,
		ImportNoSave = 6,
		ImportFailed = 7,
		ImportNotEnoughSpace = 8
	}

	public enum inkSaveType : byte
	{
		ManualSave = 0,
		QuickSave = 1,
		AutoSave = 2,
		PointOfNoReturn = 3,
		EndGameSave = 4
	}

	public enum inkSelectionRule : byte
	{
		Single = 0,
		Parent = 1,
		Children = 2,
		TypeBased = 3,
		NameBased = 4
	}

	public enum inkSelectorChangeDirection
	{
		None = 0,
		Prior = 1,
		Next = 2
	}

	public enum inkSpawnMode
	{
		SingleAndMultiplayer = 0,
		OnlySingleplayer = 1,
		OnlyMultiplayer = 2
	}

	public enum inkState : byte
	{
		InitEngine = 0,
		PreGameMenu = 3,
		InitialLoading = 4,
		Game = 5,
		InGameMenu = 6,
		PauseMenu = 7,
		FastTravelLoading = 8,
		PhotoMode = 9,
		MiniGameMenu = 10,
		EndGameLoading = 11,
		EditorDifficultyLevel = 12
	}

	public enum inkStyleOverrideType : byte
	{
		Invalid = 0,
		BigFont = 1,
		FluffReduction = 2
	}

	public enum inkTextReplaceAnimationControllerWidgetTextUsage : byte
	{
		BaseText = 0,
		TargetText = 1,
		NoUsage = 2
	}

	public enum inkTextWrappingPolicy
	{
		SingleLine = 0,
		MultiLine = 1,
		MultilineNoWrap = 2
	}

	public enum inkTextureType : byte
	{
		StaticTexture = 0,
		DynamicTexture = 1,
		InvalidTexture = 2
	}

	public enum inkVideoInstanceDoneReason
	{
		Failed = 0,
		Stopped = 1,
		Finished = 2
	}

	public enum inkVideoOptimizationState
	{
		None = 0,
		TooManyBinks = 1,
		FullscreenBinkVisible = 2
	}

	public enum inkWidgetResourceVersion : byte
	{
		Default = 0,
		BrushToAtlas = 1
	}

	public enum inkanimEventType : byte
	{
		OnLoaded = 0,
		OnStart = 1,
		OnFinish = 2,
		OnPause = 3,
		OnResume = 4,
		OnStartLoop = 5,
		OnEndLoop = 6
	}

	public enum inkanimInterpolationDirection : byte
	{
		To = 0,
		From = 1,
		FromTo = 2
	}

	public enum inkanimInterpolationMode : byte
	{
		EasyIn = 0,
		EasyOut = 1,
		EasyInOut = 2,
		EasyOutIn = 3
	}

	public enum inkanimInterpolationType : byte
	{
		Linear = 0,
		Quadratic = 1,
		Qubic = 2,
		Quartic = 3,
		Quintic = 4,
		Sinusoidal = 5,
		Exponential = 6,
		Elastic = 7,
		Circular = 8,
		Back = 9
	}

	public enum inkanimLoopType : byte
	{
		None = 0,
		Cycle = 1,
		PingPong = 2
	}

	public enum inkanimPropertyType : byte
	{
		Size = 0,
		Color = 1,
		Margin = 2,
		Padding = 3,
		Transparency = 4,
		Rotation = 5
	}

	public enum inputContextType
	{
		Action = 0,
		RPG = 1
	}

	public enum inputEInputDevice
	{
		INVALID = 0,
		KBD_MOUSE = 1,
		ORBIS = 2,
		DURANGO = 3,
		STEAM = 4,
		XINPUT_PAD = 5,
		STADIA = 6,
		NINTENDO_SWITCH = 7,
		SCARLETT_GAMEPAD = 8,
		PROSPERO = 9,
		EID_COUNT = 10
	}

	public enum inputEInputScheme : byte
	{
		LEGACY = 0,
		AGILE = 1,
		ALTERNATIVE = 2
	}

	public enum inputESimplifiedInputDevice : byte
	{
		KBM = 0,
		PAD = 1
	}

	public enum locHolocallActorMode : byte
	{
		Default = 0,
		ActorUsesHolocall = 1,
		ActorDoesntUseHolocall = 2
	}

	public enum locVoiceTagGender
	{
		Undefined = 0,
		Male = 1,
		Female = 2
	}

	public enum locVoiceoverContext : byte
	{
		Vo_Context_Quest = 0,
		Vo_Context_Community = 1,
		Vo_Context_Combat = 2,
		Vo_Context_Minor_Activity = 3,
		Default_Vo_Context = 5
	}

	public enum locVoiceoverExpression : byte
	{
		Vo_Expression_Spoken = 0,
		Vo_Expression_Phone = 1,
		Vo_Expression_InnerDialog = 2,
		Vo_Expression_Loudspeaker_Room = 3,
		Vo_Expression_Loudspeaker_Street = 4,
		Vo_Expression_Loudspeaker_City = 5,
		Vo_Expression_Radio = 6,
		Vo_Expression_GlobalTV = 7,
		Vo_Experession_Cb_Radio = 8,
		Vo_Expression_Cyberspace = 9,
		Vo_Expression_Possessed = 10,
		Vo_Expression_Helmet = 11
	}

	public enum meleeMoveDirection
	{
		Forward = 0,
		Right = 1,
		Back = 2,
		Left = 3
	}

	public enum meleeQueuedAttack
	{
		Block = 0,
		Combo = 1,
		Crouch = 2,
		Final = 3,
		Jump = 4,
		Safe = 5,
		Sprint = 6,
		Strong = 7,
		Throw = 8
	}

	public enum minimapuiELayerType : byte
	{
		Floor = 0,
		Cover = 1,
		WallInterior = 2,
		WallExterior = 3,
		Door = 4,
		Stairs = 5,
		Road = 6,
		Count = 7
	}

	public enum moveCirclingDirection
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public enum moveExplorationType
	{
		None = 0,
		Ladder = 1,
		Jump = 2,
		Climb = 3,
		Vault = 4,
		ChargedJump = 5,
		ThrusterJump = 6
	}

	public enum moveLineOfSight
	{
		None = 0,
		Keep = 1,
		Avoid = 2
	}

	public enum moveLineOfSightPointPreference
	{
		None = 0,
		ClosestToOwner = 1,
		ClosestToTarget = 2,
		FurthestFromTarget = 3
	}

	public enum moveLocomotionAction
	{
		Undefined = 0,
		Exploration = 1,
		Idle = 2,
		IdleTurn = 3,
		Reposition = 4,
		Start = 5,
		Move = 6,
		Stop = 7
	}

	public enum moveMovementOrientationType
	{
		NotSet = 0,
		Forward = 1,
		Backward = 2,
		Left = 3,
		Right = 4
	}

	public enum moveMovementType
	{
		Walk = 0,
		Run = 1,
		Sprint = 2,
		Strafe = 3,
		Stand = 4
	}

	public enum moveSecureFootingFailureReason
	{
		Invalid = 0,
		Filter = 1,
		SimulationType = 2,
		Ground = 3
	}

	public enum moveSecureFootingFailureType
	{
		Invalid = 0,
		Edge = 1,
		Slope = 2
	}

	public enum navLocomotionPathSegmentTypes : byte
	{
		Invalid = 0,
		Spline = 1,
		OffMeshLink = 2
	}

	public enum navNavAreaID : byte
	{
		Unwalkable = 0,
		Terrain = 1,
		Crouchable = 2,
		Regular = 3,
		Road = 4,
		Pavement = 5,
		Door = 10,
		Ladder = 11,
		Jump = 12,
		Elevator = 14,
		Stairs = 15,
		Drones = 16,
		Exploration = 17,
		CrowdWalkable = 5
	}

	public enum navNaviPositionType
	{
		None = 0,
		Normal = 1,
		Projected = 2
	}

	public enum navPathQueryDebugStatus
	{
		InvalidQuery = 0,
		Active = 1,
		WaitingForStreaming = 2,
		Completed = 3,
		NoPathPossible = 4
	}

	public enum operationsMode
	{
		PLAYER = 0,
		FLATHEAD = 1,
		TOOLBOX = 2
	}

	public enum panzerBootupUI
	{
		UnbootedIdle = 0,
		BootingAttempt = 1,
		BootingSuccess = 2,
		Loop = 3
	}

	[Flags]
	public enum physicsDestructionType
	{
		DT_PhysicalNode = 1 << 0,
		DT_PhysicalComponent = 1 << 1,
		DT_BakedNode = 1 << 2,
		DT_BakedComponent = 1 << 3,
		DT_IDN = 1 << 4,
		DT_FoliageDestruction = 1 << 5,
		DT_QuestComponent = 1 << 6,
		DT_QuestNode = 1 << 7
	}

	[Flags]
	public enum physicsEClothCollisionMaskEnum
	{
		SPHERE = 1 << 0,
		BOX = 1 << 1,
		CONVEX = 1 << 2,
		TRIMESH = 1 << 3,
		CAPSULE = 1 << 4
	}

	public enum physicsFilterDataSource : byte
	{
		Parent = 0,
		Collider = 1,
		Component = 0,
		Body = 1
	}

	public enum physicsFractureFieldEffect : byte
	{
		FE_Fracture = 0,
		FE_Erase = 1
	}

	[Flags]
	public enum physicsFractureFieldOptions
	{
		FFO_OnlyPrefractured = 1 << 0,
		FFO_DisableReiteration = 1 << 1
	}

	[Flags]
	public enum physicsFractureFieldType
	{
		FF_Default = 1 << 0,
		FF_Locomotion = 1 << 1,
		FF_TriggerDestructionEvent = 1 << 2,
		FF_FractureFieldNode = 1 << 3,
		FF_FractureFieldGameEffect = 1 << 4,
		FF_FractureFieldComponent = 1 << 5
	}

	public enum physicsFractureFieldValueType : byte
	{
		FFVT_Impulse = 0,
		FFVT_Velocity = 1
	}

	public enum physicsMaterialFriction
	{
		Enabled = 0,
		DisabledStrong = 1,
		Disabled = 2
	}

	public enum physicsMaterialTagAIVisibility : byte
	{
		None = 0,
		SemiTransparent = 1,
		Transparent = 2
	}

	public enum physicsMaterialTagProjectilePenetration : byte
	{
		TechOnly = 0,
		Any = 1,
		Medium = 2,
		Heavy = 3,
		Never = 4
	}

	public enum physicsMaterialTagProjectileRicochet : byte
	{
		Default = 0,
		Always = 1
	}

	public enum physicsMaterialTagType : byte
	{
		AIVisibility = 0,
		PlayerVisibility = 1,
		ProjectilePenetration = 2,
		ProjectileRicochet = 3,
		VehicleTraction = 4
	}

	public enum physicsMaterialTagVehicleTraction : byte
	{
		Default = 0,
		Gravel = 1
	}

	public enum physicsMaterialTagVisibility : byte
	{
		None = 0,
		SemiTransparent = 1,
		Transparent = 2,
		Ignore = 3
	}

	public enum physicsPhysicalSystemOwner : byte
	{
		Unknown = 0,
		BakedDestructionNode = 1,
		ClothMeshNode = 2,
		CollisionAreaNode = 3,
		DecorationMeshNode = 4,
		DynamicMeshNode = 5,
		InstancedDestructibleNode = 6,
		PhysicalDestructionNode = 7,
		PhysicalTriggerNode = 8,
		StaticMeshNode = 9,
		TerrainCollisionNode = 10,
		WaterPatchNode = 11,
		WorldCollisionNode = 12,
		BakedDestructionComponent = 13,
		ClothComponent = 14,
		ColliderComponent = 15,
		PhysicalDestructionComponent = 16,
		PhysicalMeshComponent = 17,
		PhysicalSkinnedMeshComponent = 18,
		PhysicalTriggerComponent = 19,
		SimpleColliderComponent = 20,
		SkinnedClothComponent = 21,
		StateMachineComponent = 22,
		VehicleChassisComponent = 23,
		PhysicalParticleSystem = 24,
		PhotoModeSystem = 25,
		RagdollBinder = 26,
		FoliageDestruction = 27,
		EntityProxy = 28
	}

	public enum physicsPhysicsJointAxis : byte
	{
		AxisX = 0,
		AxisY = 1,
		AxisZ = 2,
		Twist = 3,
		Swing1 = 4,
		Swing2 = 5
	}

	public enum physicsPhysicsJointDriveType : byte
	{
		AxisX = 0,
		AxisY = 1,
		AxisZ = 2,
		Swing = 3,
		Twist = 4,
		SLERP = 5
	}

	public enum physicsPhysicsJointMotion : byte
	{
		Locked = 0,
		Limited = 1,
		Free = 2
	}

	public enum physicsProxyType : byte
	{
		Invalid = 0,
		PhysicalSystem = 1,
		CharacterController = 2,
		Destruction = 3,
		ParticleSystem = 4,
		Trigger = 5,
		Cloth = 6,
		WorldCollision = 7,
		Terrain = 8,
		SimpleCollider = 9,
		AggregateSystem = 10,
		CharacterObstacle = 11,
		Ragdoll = 12,
		FoliageDestruction = 13
	}

	public enum physicsQueryUseCase : ushort
	{
		Default = 0,
		ActionAnimation = 1,
		AI = 2,
		AnimationComponent = 3,
		Audio = 4,
		AudioHedgehog = 5,
		Components = 6,
		Debug = 7,
		Gameplay = 8,
		GeomDescription = 9,
		LineOfSightTests = 10,
		MoveZAlignment = 11,
		Navigation = 12,
		Nodes = 13,
		PuppetBlackboardUpdater = 14,
		Ragdoll = 15,
		Scripts = 16,
		TargetingSystem = 17,
		VehicleAI = 18,
		VehicleAIColliders = 19,
		Vehicles = 20,
		VehicleChassis = 21,
		VehiclesCrowd = 22,
		VehicleWheel = 23,
		VehicleStreamingHack = 24,
		VehicleWater = 25,
		VisibilityResolver = 26,
		WorldUI = 27,
		GameEffects = 28,
		GameProjectiles = 29
	}

	[Flags]
	public enum physicsRagdollBodyPartE
	{
		HEAD = 1 << 0,
		LARM_UPPER = 1 << 1,
		LARM_LOWER = 1 << 2,
		LARM_PALM = 1 << 3,
		RARM_UPPER = 1 << 4,
		RARM_LOWER = 1 << 5,
		RARM_PALM = 1 << 6,
		LLEG_UPPER = 1 << 7,
		LLEG_LOWER = 1 << 8,
		LLEG_FOOT = 1 << 9,
		RLEG_UPPER = 1 << 10,
		RLEG_LOWER = 1 << 11,
		RLEG_FOOT = 1 << 12,
		BODY = 1 << 13
	}

	public enum physicsRagdollShapeType : byte
	{
		CAPSULE = 0,
		BOX = 1,
		SPHERE = 2
	}

	public enum physicsShapeType : byte
	{
		Box = 0,
		Sphere = 1,
		Capsule = 2,
		ConvexMesh = 3,
		TriangleMesh = 4,
		Invalid = 6
	}

	public enum physicsSimulationType : byte
	{
		Static = 0,
		Dynamic = 1,
		Kinematic = 2,
		Invalid = 3
	}

	public enum physicsStateValue
	{
		Position = 1,
		Rotation = 2,
		Transform = 3,
		LinearVelocity = 4,
		AngularVelocity = 5,
		LinearSpeed = 6,
		TouchesGround = 10,
		TouchesWalls = 11,
		ImpulseAccumulator = 12,
		IsSleeping = 13,
		Mass = 16,
		Volume = 18,
		IsSimulated = 20,
		IsKinematic = 21,
		TimeDeltaOverride = 27,
		SimulationFilter = 32,
		Radius = 30
	}

	public enum physicsStaticCollisionShapeCategory
	{
		Interior = 0,
		Exterior = 1,
		Architecture = 2,
		Decoration = 3,
		Other = 4
	}

	public enum populationSpawnerObjectCtrlAction : byte
	{
		Undefined = 0,
		Activate = 1,
		Deactivate = 2,
		Reactivate = 3,
		ResetKillCount = 4,
		Spawn = 1,
		Despawn = 2,
		Respawn = 3
	}

	public enum questAttachmentOffsetMode : byte
	{
		UseRealOffset = 0,
		UseCustomOffset = 1
	}

	public enum questAudioEventPrefetchMode : byte
	{
		AddEventPrefetch = 0,
		RemoveEventPrefetch = 1
	}

	public enum questAvailableVehicleType
	{
		AnyCar = 0,
		AnyMotorcycle = 1,
		AnyVehicle = 2,
		SpecificVehicle = 3
	}

	public enum questBehindInteractionEventType : byte
	{
		Undefined = 0,
		StartedBeingBehind = 1,
		StoppedBeingBehind = 2,
		IsBehind = 3,
		IsNotBehind = 4
	}

	public enum questBlockAction
	{
		Block = 0,
		Unblock = 1,
		UnblockAll = 2
	}

	public enum questBriefingPlayerType
	{
		Fullscreen = 0,
		Hud = 1,
		World = 2
	}

	public enum questBriefingSequencePlayerFunction
	{
		StartSequence = 0,
		ChangeSequence = 1,
		FinishSequence = 2
	}

	public enum questBriefingType
	{
		Fullscreen = 0,
		Hud = 1,
		World = 2
	}

	public enum questCameraParallaxSpace
	{
		Trajectory = 0,
		Camera = 1,
		Chest = 2
	}

	public enum questCameraPlanesPreset : byte
	{
		Undefined = 0,
		VeryNear = 1,
		Near = 2,
		Normal = 3,
		None = 4
	}

	public enum questCharacterHitEventType
	{
		Bullet = 0,
		Explosion = 1,
		Melee = 2,
		Other = 3
	}

	public enum questChoiceSection_ConditionTypeMode : byte
	{
		Highlight = 0,
		Selection = 1
	}

	public enum questCombatNodeFunctions
	{
		CombatTarget = 0,
		ShootAt = 1,
		LookAtTarget = 2,
		ThrowGrenade = 3,
		UseCover = 4,
		SwitchWeapon = 5,
		PrimaryWeapon = 6,
		SecondaryWeapon = 7,
		RestrictMovementToArea = 8
	}

	public enum questCompanionPositions
	{
		Behind = 0,
		InFront = 1
	}

	public enum questControlCrowdAction : byte
	{
		Disable = 0,
		Enable = 1
	}

	public enum questCustomStyle
	{
		PlacidePhone = 0,
		VideoCallInterupt = 1
	}

	public enum questDistanceType
	{
		Nearest = 0,
		Furthest = 1
	}

	public enum questDrillingState
	{
		Undefined = 0,
		Started = 1,
		Finished = 2
	}

	public enum questEAddRemoveItemType
	{
		AddItem = 0,
		RemoveByItemID = 1,
		RemoveByTag = 2,
		RemoveAll = 3
	}

	public enum questEComparisonTypeEquality
	{
		Equal = 0,
		NotEqual = 1
	}

	public enum questEDebugViewMode
	{
		NONE = 0,
		CLAY = 1,
		PURE_GRAY = 2,
		PURE_WHITE = 3,
		SHADOWS = 4,
		BASE_COLOR = 5,
		NORMALS = 6,
		ROUGHNESS = 7,
		METALNESS = 8,
		EMISSIVE = 9,
		MATERIAL_ID = 10,
		WIREFRAME = 11,
		OVERDRAW = 12
	}

	public enum questESwitchBehaviourType
	{
		[RED("First Fulfilled")] First_Fulfilled = 0,
		[RED("All Fulfilled")] All_Fulfilled = 1
	}

	public enum questETimeDilationOverride
	{
		None = 0,
		Ignore = 1,
		Inherit = 2
	}

	public enum questETimeShiftType
	{
		ShiftByTime = 0,
		ShiftToHour = 1
	}

	public enum questEUIMenuState
	{
		Open = 0,
		Closed = 1
	}

	public enum questEUseWeapon_MissileOffsetsSource
	{
		None = 0,
		Predefined_Narrow = 1,
		Predefined_Wide = 2,
		TweakDB = 3,
		List = 4
	}

	public enum questElevator_ManageNPCAttachment_NodeTypeParamsAction
	{
		Attach = 0,
		Detach = 1
	}

	public enum questExitType : byte
	{
		Terminating = 0,
		NonTerminating = 1
	}

	public enum questGameplayRestrictionAction
	{
		AddRestriction = 0,
		RemoveRestriction = 1,
		RemoveAllRestrictions = 2
	}

	public enum questImpulseMagnitude
	{
		Any = 0,
		Low = 1,
		Medium = 2,
		High = 3
	}

	public enum questInjectLootOperationType
	{
		Inject = 0,
		Remove = 1,
		RemoveAll = 2
	}

	public enum questInputDevice
	{
		Undefined = 0,
		KeyboardMouse = 1,
		XBoxGamepad = 2,
		PS4Gamepad = 3,
		StadiaGamepad = 4,
		NintendoGamepad = 5
	}

	public enum questInputScheme
	{
		Legacy = 0,
		Agile = 1,
		Alternative = 2
	}

	public enum questJournalAlignmentEventType
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum questJournalQuestEntry_NodeTypeNodeVersion : byte
	{
		Initial = 0,
		OptionalProperty = 1
	}

	public enum questJournalSizeEventType
	{
		Maximize = 0,
		Minimize = 1
	}

	public enum questLanguageMode
	{
		Undefined = 0,
		VoLang = 1,
		SubsLang = 2,
		TextLang = 3
	}

	public enum questLocationAction
	{
		Entered = 0,
		Exited = 1
	}

	public enum questLogicalOperation : byte
	{
		AND = 0,
		OR = 1,
		XOR = 2,
		NAND = 3,
		NOR = 4,
		NXOR = 5
	}

	public enum questLookAtAction
	{
		Nothing = 0,
		Reset = 1,
		Set = 2
	}

	public enum questLookAtDrivenTurnsMode
	{
		Start = 0,
		Pause = 1,
		Resume = 2,
		Stop = 3,
		ForceStop = 4
	}

	public enum questLootTokenState
	{
		Enabled = 0,
		Disabled = 1,
		Sealed = 2,
		Unsealed = 3
	}

	public enum questMountConditionType : byte
	{
		OnMount = 0,
		OnUnmount = 1
	}

	public enum questMountVehicleOrigin
	{
		Any = 0,
		NotStolen = 1,
		Stolen = 2
	}

	public enum questMountVehicleType
	{
		Any = 0,
		Car = 1,
		Motorcycle = 2
	}

	public enum questMoveOnSplineType
	{
		Simple = 0,
		Anim = 1,
		WithCompanion = 2
	}

	public enum questMoveType
	{
		MoveOnSpline = 0,
		MoveTo = 1,
		RotateTo = 2,
		Patrol = 3,
		Follow = 4,
		JoinCrowd = 5
	}

	public enum questMultiplayerAIDirectorFunction
	{
		SetStatus = 0,
		SetCurrentPath = 1,
		OverrideScheduleEntry = 2,
		SetCurrentShedule = 3
	}

	public enum questMultiplayerAIDirectorStatus
	{
		Enabled = 0,
		Disabled = 1
	}

	public enum questMultiplayerHeistState
	{
		Invalid = 0,
		Failure = 1,
		Victory = 2
	}

	public enum questNodeType
	{
		Equip = 0,
		Unequip = 1
	}

	public enum questObjectInspectEventType
	{
		Undefined = 0,
		Started = 1,
		Finished = 2
	}

	public enum questObjectInteractionEventType : byte
	{
		Undefined = 0,
		Entered = 1,
		Exited = 2,
		Executed = 3
	}

	public enum questObjectScanEventType : byte
	{
		Undefined = 0,
		Started = 1,
		Finished = 2
	}

	public enum questPhaseNodeType : byte
	{
		Quest = 0,
		OpenWorld = 1,
		Combat = 2,
		Audio = 3
	}

	public enum questPhoneCallMode
	{
		Undefined = 0,
		Audio = 1,
		Video = 2
	}

	public enum questPhoneCallPhase
	{
		Undefined = 0,
		IncomingCall = 1,
		StartCall = 2,
		EndCall = 3
	}

	public enum questPhoneCallVisuals
	{
		Default = 0,
		Somi = 1
	}

	public enum questPhoneStatus
	{
		Available = 0,
		NotAvailable = 1,
		Busy = 2,
		Minimized = 3
	}

	public enum questPhoneTalkingState
	{
		Ended = 0,
		Initializing = 1,
		Talking = 2,
		Rejected = 3
	}

	public enum questPlatform
	{
		PC = 0,
		Console = 1,
		LastGenConsole = 2,
		CurrGenConsole = 3
	}

	public enum questProximityProgressBarAction
	{
		Activated = 0,
		Inactivated = 1,
		Completed = 2,
		WentOutOfRange = 3
	}

	public enum questProximityProgressBarOrientation
	{
		Undefined = 0,
		InRange = 1,
		OutOfRange = 2
	}

	public enum questProximityProgressBarState
	{
		None = 0,
		Active = 1,
		Inactive = 2,
		Complete = 3
	}

	public enum questQuestContentType : byte
	{
		EP1_MainQuest = 0,
		EP1_SideQuest = 1,
		EP1_Minor = 2,
		Fixer = 3,
		MainQuest = 4,
		SideQuest_MainPath = 5,
		SideQuest_Romance = 6,
		SideQuest_Standalone = 7,
		MinorQuestAndSts = 8
	}

	public enum questQuickItemsSet
	{
		Q001_Kereznikov_Heal_Phone = 0,
		Q003_All = 1
	}

	public enum questRandomizerMode : byte
	{
		Random = 0,
		IgnoreLastUsed = 1,
		IgnoreAllUsed = 2
	}

	public enum questScanningState
	{
		NotScanned = 0,
		Scanned = 1
	}

	public enum questSceneConditionType : byte
	{
		Undefined = 0,
		IsInside = 1,
		IsOutside = 2,
		Entered = 3,
		Exited = 4
	}

	public enum questSetDestructionStateAction
	{
		Undefined = 0,
		Trigger = 1
	}

	public enum questSocketType : byte
	{
		Undefined = 0,
		Input = 1,
		Output = 2,
		CutSource = 3,
		CutDestination = 4
	}

	public enum questSpawnDirectionPreference
	{
		Behind = 0,
		InFront = 1
	}

	public enum questSpawnedVehicleType
	{
		EntityReferenced = 0,
		AnyCar = 1,
		AnyMotorcycle = 2,
		SpecificVehicle = 3
	}

	public enum questStorage
	{
		Slow = 0,
		Fast = 1
	}

	public enum questSwitchWeaponModes
	{
		PrimaryWeapon = 0,
		SecondaryWeapon = 1
	}

	public enum questTimeSkipMode : byte
	{
		PreSkip = 0,
		PostSkip = 1
	}

	public enum questTriggerConditionType : byte
	{
		Undefined = 0,
		Entered = 1,
		Exited = 2,
		IsInside = 3,
		IsOutside = 4,
		AllInsideMP = 5,
		AllOutsideMP = 6
	}

	public enum questTutorialScreenMode : byte
	{
		Undefined = 0,
		Fullscreen = 1,
		Popup = 2
	}

	public enum questUIGameContextRequestType
	{
		Push = 0,
		Pop = 1,
		Reset = 2
	}

	public enum questUseWorkspotNodeFunctions
	{
		UseWorkspot = 0,
		JumpWorkspot = 1,
		StopWorkspot = 2,
		IdleOnlyMode = 3
	}

	public enum questUseWorkspotTier
	{
		Tier3 = 0,
		Tier4 = 1
	}

	public enum questVehicleCameraPerspective : byte
	{
		FPP = 1,
		TPP = 0
	}

	public enum questVehicleCameraType : byte
	{
		Undefined = 0,
		PuppetFPP = 1,
		TPP = 2,
		DriverFPP = 3,
		FPP = 1
	}

	public enum questVehicleCommandType : byte
	{
		[RED("Move On Spline")] Move_On_Spline = 0,
		Follow = 1,
		[RED("Move To")] Move_To = 2,
		Racing = 3,
		[RED("Join Traffic")] Join_Traffic = 4,
		Panic = 5,
		Chase = 6
	}

	public enum questVehicleWeaponQuestID : byte
	{
		Primary = 0,
		Secondary = 1,
		Tertiary = 2,
		Quaternary = 3,
		Quinary = 4,
		Senary = 5,
		Septenary = 6,
		Octonary = 7,
		All = 8
	}

	public enum questVisionModeType
	{
		Undefined = 0,
		FocusMode = 1,
		EnhancedMode = 2
	}

	public enum questWeaponUsageType
	{
		Shoot = 0,
		StopShooting = 1,
		Reload = 2,
		StartAttack = 3,
		StopAttack = 4
	}

	public enum redTaskTextMessageType
	{
		Info = 0,
		Error = 1
	}

	public enum rendCaptureContextType
	{
		SceneGamedef = 0,
		AnimViewer = 1
	}

	public enum rendContactShadowReciever : byte
	{
		CSR_None = 0,
		CSR_All = 3,
		CSR_CharacterOnly = 2
	}

	public enum rendEParticleSortingMode
	{
		PSM_None = 0,
		PSM_Billboard = 1,
		PSM_Regular = 2
	}

	public enum rendEPathTracingLightUsage : byte
	{
		PTLU_Everywhere = 0,
		PTLU_OnlyInPathTracing = 1,
		PTLU_ExcludeFromPathTracing = 2
	}

	public enum rendEStreamingObserverMode : byte
	{
		Point = 0,
		Box = 1
	}

	public enum rendGIGroup : byte
	{
		GI_Group0 = 0,
		GI_Group1 = 1
	}

	public enum rendGIVolume : byte
	{
		GI_Exterior = 0,
		GI_Interior1 = 1,
		GI_Interior2 = 2,
		GI_Interior3 = 3,
		GI_Interior4 = 4
	}

	public enum rendLightAttenuation : byte
	{
		LA_InverseSquare = 0,
		LA_Linear = 1
	}

	[Flags]
	public enum rendLightChannel
	{
		LC_Channel1 = 1 << 0,
		LC_Channel2 = 1 << 1,
		LC_Channel3 = 1 << 2,
		LC_Channel4 = 1 << 3,
		LC_Channel5 = 1 << 4,
		LC_Channel6 = 1 << 5,
		LC_Channel7 = 1 << 6,
		LC_Channel8 = 1 << 7,
		LC_ChannelWorld = 1 << 8,
		LC_Character = 1 << 9,
		LC_Player = 1 << 10,
		LC_Automated = 1 << 15
	}

	public enum rendLightGroup : byte
	{
		LG_Group0 = 0,
		LG_Group1 = 1,
		LG_Group2 = 2,
		LG_Group3 = 3,
		LG_Group4 = 4,
		LG_Group5 = 5,
		LG_Group6 = 6,
		LG_Group7 = 7
	}

	public enum rendPostFx_ScanningState : byte
	{
		Off = 0,
		Scanning = 2,
		Cancelled = 3,
		Complete = 4
	}

	public enum rendRayTracedShadowsPlatform : byte
	{
		RLSP_All = 0,
		RLSP_PC = 1,
		RLSP_Consoles = 2
	}

	public enum rendResolutionMultiplier
	{
		X1 = 1,
		X2 = 2,
		X4 = 4
	}

	public enum rendScreenshotMode
	{
		NONE = 0,
		NORMAL = 1,
		NORMAL_MULTISAMPLE = 2,
		LAYERED = 4,
		HIGH_RESOLUTION = 5,
		HIGH_RESOLUTION_LAYERED = 6
	}

	public enum rendWindShapeAnchorPointDepth
	{
		AP_CENTER = 0,
		AP_FRONT = 1,
		AP_BACK = 2
	}

	public enum rendWindShapeAnchorPointHorz
	{
		AP_CENTER = 0,
		AP_RIGHT = 1,
		AP_LEFT = 2
	}

	public enum rendWindShapeAnchorPointVert
	{
		AP_CENTER = 0,
		AP_TOP = 1,
		AP_BOTTOM = 2
	}

	public enum renddimEPreset
	{
		[RED("228x128")] _228x128 = 0,
		[RED("456x256")] _456x256 = 1,
		[RED("480x270")] _480x270 = 2,
		[RED("640x480")] _640x480 = 3,
		[RED("960x540")] _960x540 = 4,
		[RED("1280x720")] _1280x720 = 5,
		[RED("1600x900")] _1600x900 = 6,
		[RED("1920x1080")] _1920x1080 = 7,
		[RED("2560x1080")] _2560x1080 = 8,
		[RED("2560x1440")] _2560x1440 = 9,
		[RED("3440x1440")] _3440x1440 = 11,
		[RED("3840x1600")] _3840x1600 = 12,
		[RED("3840x2160")] _3840x2160 = 13,
		[RED("688x388")] _688x388 = 14,
		[RED("776x436")] _776x436 = 15,
		Console_Base = 7,
		Console_Pro_Prospero_Lockhart = 9,
		Console_Scorpio = 13,
		Console_Anaconda = 13
	}

	public enum renderDevEnvProbeView
	{
		RADIANCE = 0,
		ALBEDO = 1,
		NORMAL = 2,
		ROUGHNESS = 3,
		METALNESS = 4,
		EMISSIVE = 5,
		SKY_MASK = 6
	}

	public enum renderDevGIProbeView
	{
		RADIANCE = 0,
		SKY_VISIBILITY = 1,
		ENV_ID = 2,
		FLAG_0 = 3,
		FLAG_1 = 4,
		FLAG_2 = 5,
		CURRENT_ID = 6
	}

	public enum renderDevSurfelView
	{
		ALBEDO = 0,
		NORMAL = 1,
		SHADOWS = 2,
		CLOSEST_PROBE = 3,
		EMISSIVE = 4,
		LIGHTING = 5,
		BOUNCE = 6,
		INSIDE = 7,
		SHADOW = 8
	}

	public enum renderDevTXAADebugMode
	{
		TXAA_NoDebug = 0,
		TXAA_ShowHistoryBlendFactor = 1
	}

	public enum scnAdditionalSpeakerRole
	{
		Full = 0,
		OnlyLipsync = 1
	}

	public enum scnAdditionalSpeakerType
	{
		Normal = 0,
		Holocall = 1
	}

	public enum scnAnimNameType
	{
		direct = 0,
		reference = 1,
		container = 2,
		dynamic = 3
	}

	public enum scnAnimationCategory
	{
		Body = 0,
		Facial = 1,
		Cyberware = 2
	}

	public enum scnAudioFastForwardSupport : byte
	{
		MuteDuringFastForward = 1,
		DontMuteDuringFastForward = 2
	}

	public enum scnAudioPlaybackDirectionSupportFlag : byte
	{
		Forward = 1,
		Backward = 2
	}

	public enum scnBraindanceLayer : byte
	{
		Visual = 0,
		Audio = 1,
		Thermal = 2
	}

	public enum scnBraindancePerspective : byte
	{
		FirstPerson = 0,
		ThirdPerson = 1
	}

	public enum scnBraindanceSpeed : byte
	{
		Any = 0,
		Slow = 1,
		Normal = 2,
		Fast = 3,
		VeryFast = 4
	}

	[Flags]
	public enum scnChoiceNodeNsChoiceNodeBitFlags
	{
		IsFocusClue = 1 << 0,
		IsValidInteractionFailsafeDisabled = 1 << 1
	}

	public enum scnChoiceNodeNsChoiceNodeFlags : ushort
	{
		IsFocusClue = 1,
		IsValidInteractionFailsafeDisabled = 2
	}

	public enum scnChoiceNodeNsMappinLocation : byte
	{
		None = 0,
		Interaction = 1,
		Nameplate = 2,
		ObjectDefault = 4
	}

	public enum scnChoiceNodeNsOperationMode : byte
	{
		attachToActor = 0,
		attachToProp = 1,
		attachToGameObject = 2,
		attachToScreen = 3,
		attachToWorld = 4
	}

	public enum scnChoiceNodeNsSizePreset : byte
	{
		small = 0,
		normal = 1,
		big = 2,
		Dialogue = 3,
		Interaction = 4,
		Dialogue360 = 5
	}

	public enum scnChoiceNodeNsTimedAction : byte
	{
		appear = 0,
		disappear = 1,
		disappearFading = 2
	}

	public enum scnChoiceNodeNsVisualizerStyle : byte
	{
		onScreen = 0,
		inWorld = 1
	}

	public enum scnContextualActorName
	{
		Player = 0,
		VoicesetHolder = 1,
		Voice = 2,
		SpecificVoicetagHolder = 3,
		ContextActorName = 4
	}

	public enum scnDialogLineLanguage
	{
		Origin = 0,
		Creole = 1,
		Japanese = 2,
		Arabic = 4,
		Russian = 5,
		Chinese = 6,
		Brasilian = 7,
		English = 8,
		Korean = 9,
		Swahili = 10,
		French = 11,
		Polish = 12
	}

	public enum scnDialogLineType
	{
		None = 0,
		Regular = 1,
		Holocall = 2,
		SceneComment = 3,
		OverHead = 4,
		Radio = 5,
		GlobalTV = 6,
		Invisible = 7,
		OverHeadAlwaysVisible = 9,
		OwnerlessRegular = 10,
		AlwaysCinematicNoSpeaker = 11,
		GlobalTVAlwaysVisible = 12,
		Narrator = 13
	}

	public enum scnDialogLineVisualStyle : byte
	{
		regular = 0,
		overHead = 1,
		radio = 2,
		globalTV = 3,
		invisible = 4,
		innerDialog = 5,
		overHeadAlwaysVisible = 6,
		alwaysCinematicNoSpeaker = 7,
		globalTVAlwaysVisible = 8,
		narrator = 9
	}

	public enum scnDistractedConditionTarget : byte
	{
		Anyone = 0,
		Speaker = 1,
		SpeakerOrAddressee = 2
	}

	public enum scnEasingType : byte
	{
		Linear = 0,
		SinusoidalEaseInOut = 1,
		QuadraticEaseIn = 2,
		QuadraticEaseOut = 3,
		CubicEaseInOut = 4,
		CubicEaseIn = 5,
		CubicEaseOut = 6
	}

	public enum scnEndNodeNsType : byte
	{
		Terminating = 0,
		NonTerminating = 1
	}

	public enum scnEntityAcquisitionPlan
	{
		findInContext = 1,
		findInWorld = 2,
		spawnDespawn = 3,
		findInEntity = 4,
		spawnSet = 5,
		community = 6,
		spawner = 7,
		findNetworkPlayer = 9,
		findInNode = 8
	}

	public enum scnEventType
	{
	}

	public enum scnFastForwardMode
	{
		Default = 0,
		GameplayReview = 1
	}

	public enum scnFastForwardStrategy
	{
		automatic = 0,
		allow_fully = 1,
		block_on_start = 2,
		block_on_end = 3,
		block_on_start_and_end = 4,
		block_fully = 5,
		block_on_end_if_activator_matched = 6
	}

	public enum scnInterruptCapability
	{
		None = 0,
		Interruptable = 1,
		NotInterruptable = 2
	}

	public enum scnInterruptReturnLinesBehavior : byte
	{
		Default = 0,
		Vehicle = 1,
		Holocall = 2
	}

	public enum scnInterruptionPhase : byte
	{
		WaitForInterruption = 0,
		WaitForInterrupted = 1,
		Interrupted = 2,
		ClearTier = 3,
		FadeOutLines = 4,
		InterruptionVoiceset = 5,
		WaitForReturn = 6,
		InstallTalkInteraction = 7,
		WaitForTalkInteraction = 8,
		ReturnVoiceset = 9,
		ReturnAnswerVoiceset = 10,
		ShowLines = 11,
		SyncTime = 12,
		RestoreTier = 13,
		Returned = 14,
		FadeOutLookAt = 15,
		FadeInLookAt = 16,
		InterruptSignal = 17,
		PostInterruptSignalTimeDelay = 18,
		ReturnSignal = 19,
		PostReturnSignalTimeDelay = 20,
		ProcessTalkInteraction = 21,
		ClearCommands = 22
	}

	public enum scnLookAtTargetType
	{
		Actor = 0,
		Prop = 1
	}

	public enum scnMarkerType
	{
		Local = 0,
		Global = 1,
		Entity = 2
	}

	public enum scnOffsetMode : byte
	{
		useRealOffset = 0,
		useCustomOffset = 1
	}

	public enum scnPlayDirection
	{
		Forward = 0,
		Backward = 1
	}

	public enum scnPlaySpeed
	{
		Pause = 0,
		Slow = 1,
		Normal = 2,
		Fast = 3,
		VeryFast = 4
	}

	public enum scnPropOwnershipTransferOptionsType
	{
		TransferToWorkspotSystem_Automatic = 0,
		TransferToWorkspotSystem_Custom = 1,
		DisposeAfterScene = 2
	}

	public enum scnPuppetVehicleState : byte
	{
		IdleMounted = 0,
		IdleStand = 1,
		CombatWindowed = 2,
		CombatSeated = 3,
		Turret = 4,
		GunnerSlot = 5
	}

	public enum scnRandomizerMode : byte
	{
		Random = 0,
		IgnoreLastUsed = 1,
		IgnoreAllUsed = 2
	}

	public enum scnReminderConditionProcessStep
	{
		ReminderA = 0,
		ReminderB = 1,
		ReminderC = 2,
		Looping = 3
	}

	public enum scnRidActorPlacement
	{
		SceneOrigin = 0,
		Actual = 1,
		Player = 2
	}

	public enum scnRootMotionAnimPlacementMode
	{
		Blend = 0,
		TeleportToStart = 1,
		PlayAtActorPosition = 2
	}

	public enum scnSceneCategoryTag : byte
	{
		voiceset = 0,
		mainQuests = 1,
		sideQuests = 2,
		minorQuests = 3,
		otherQuests = 4,
		dialoguesQuests = 5,
		streetOpenWorld = 6,
		vendorsOpenWorld = 7,
		dancefloorsOpenWorld = 8,
		cityOpenWorld = 9,
		chatsOpenWorld = 10,
		otherOpenWorld = 11,
		holocalls = 12,
		other = 13
	}

	public enum scnSceneVersionCheck : byte
	{
		OlderOrEqual = 0,
		Equal = 1
	}

	public enum scnSectionInternalsActorBehaviorMode
	{
		OnlyIfAlive = 0,
		EvenIfDead = 1
	}

	public enum scnWorldMarkerType : byte
	{
		Tag = 0,
		NodeRef = 1
	}

	public enum scnblocLocaleId : byte
	{
		db_db = 0,
		pl_pl = 1,
		en_us = 2
	}

	public enum scndevEventType
	{
		NodeFailed = 1,
		DebugMessage = 0,
		NodeProgressSet = 2
	}

	public enum scneventsRidCameraPlacement
	{
		SceneOrigin = 0,
		Actual = 1,
		Player = 2
	}

	public enum scneventsUIAnimActionType
	{
		Play = 0,
		Update = 1,
		Resume = 2,
		Pause = 3,
		Stop = 4
	}

	public enum scneventsVFXActionType
	{
		Play = 0,
		Break = 1,
		Kill = 2
	}

	public enum scnfppBlendOverride
	{
		Centering = 0,
		CopyPitch_CenteringYaw = 1,
		CopyPitch_CopyYaw = 2,
		Custom_PitchYaw = 3
	}

	public enum scnfppParallaxSpace
	{
		Default = 0,
		Camera = 1,
		Trajectory = 2,
		Chest = 3
	}

	public enum scnlocLocaleId : byte
	{
		db_db = 0,
		pl_pl = 1,
		en_us = 2
	}

	public enum scnscreenplayItemType : byte
	{
		invalid = 0,
		dialogLine = 1,
		choiceOption = 2,
		standaloneComment = 3
	}

	public enum senseAdditionalTraceType
	{
		Knee = 0,
		Hip = 1,
		Chest = 2
	}

	public enum senseEShapeType
	{
		INVALID = -1,
		BOX = 0,
		SPHERE = 1,
		CONE = 2,
		ANGLE_RANGE = 3
	}

	public enum senseTracingFreq
	{
		Never = 0,
		Lowest = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		Highest = 5
	}

	public enum servicesCloudSavesQueryStatus : byte
	{
		NotFetched = 0,
		FetchedSuccessfully = 1,
		CloudSavesDisabled = 2,
		NotLoggedIn = 3,
		FetchFailed = 4
	}

	public enum shadowsShadowCastingMode : byte
	{
		Default = 0,
		Always = 1,
		Never = 2
	}

	public enum sharedCommandResult
	{
		Success = 0,
		NeedOptions = 1,
		Fail = 2,
		Abort = 3
	}

	public enum sharedMenuItemType : byte
	{
		Action = 0,
		Checked = 1,
		Group = 2,
		Separator = 3
	}

	public enum telemetryLevelGainReason
	{
		Ignore = 0,
		Gameplay = 1,
		IsDebug = 2
	}

	public enum tempshitMapPinOperation : byte
	{
		Undefined = 0,
		Add = 1,
		Remove = 2
	}

	public enum textHorizontalAlignment : byte
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum textJustificationType : byte
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum textLetterCase : byte
	{
		OriginalCase = 0,
		UpperCase = 1,
		LowerCase = 2
	}

	public enum textOverflowPolicy : byte
	{
		None = 0,
		DotsEnd = 1,
		DotsEndLastLine = 2,
		AutoScroll = 3,
		PingPongScroll = 4,
		AdjustToSize = 5
	}

	public enum textTextDirection : byte
	{
		LeftToRight = 0,
		RightToLeft = 1,
		Mixed = 2
	}

	public enum textTextFlowDirection : byte
	{
		Auto = 0,
		LeftToRight = 1,
		RightToLeft = 2
	}

	public enum textTextShapingMethod : byte
	{
		Auto = 0,
		KerningOnly = 1,
		FullShaping = 2
	}

	public enum textVerticalAlignment : byte
	{
		Top = 0,
		Center = 1,
		Bottom = 2
	}

	public enum textWrappingPolicy : byte
	{
		Default = 0,
		PerCharacter = 1
	}

	public enum toolsMessageSeverity
	{
		Success = 0,
		Info = 1,
		Warning = 2,
		Error = 3
	}

	public enum toolsMessageTokenType
	{
		Text = 0,
		Location = 1,
		Tag = 2
	}

	public enum toolsMessageVerbosity
	{
		Normal = 0,
		Verbose = 1
	}

	public enum vehicleAIPathTrafficDeletionMode
	{
		INSTANT = 0,
		OUT_OF_VIEW = 1,
		DEFERRED = 2
	}

	public enum vehicleAudioEventAction
	{
		OnPlayerDriving = 0,
		OnPlayerPassenger = 1,
		OnPlayerExitVehicle = 4,
		OnPlayerEnterCombat = 2,
		OnPlayerExitCombat = 3,
		OnPlayerVehicleSummoned = 5
	}

	public enum vehicleBikeCurve
	{
		SpeedToTilt = 0,
		InputToTilt = 1,
		SpeedToTiltSpeed = 2
	}

	public enum vehicleCameraPerspective : byte
	{
		FPP = 0,
		TPPClose = 1,
		TPPMedium = 2,
		TPPFar = 3,
		DriverCombatClose = 4,
		DriverCombatMedium = 5,
		DriverCombatFar = 6
	}

	public enum vehicleCameraType
	{
		FPP = 0,
		TPP = 1
	}

	public enum vehicleColorSelectorActiveMode
	{
		None = 0,
		Primary = 1,
		Secondary = 2,
        Lights = 3
    }

	public enum vehicleColorSelectorMenuCloseReason
	{
		Apply = 0,
		Reset = 1,
		Cancel = 2
	}
	
	public enum vehicleCoolExitImpulseLevel
	{
		NoExit = 0,
		NoImpulse = 1,
		LowImpulse = 2,
		MaxImpulse = 3
	}

	public enum vehicleDisabledReason
	{
		FrontTire = 0,
		RearTire = 1,
		Other = 2
	}

	public enum vehicleELightMode
	{
		Off = 0,
		On = 1,
		HighBeams = 2
	}

	public enum vehicleELightType
	{
		Head = 1,
		Brake = 2,
		LeftBlinker = 4,
		RightBlinker = 8,
		Reverse = 16,
		Interior = 32,
		Utility = 64,
		Default = 47,
		Blinkers = 12
	}

	public enum vehicleEQuestVehicleDoorState
	{
		ForceOpen = 0,
		ForceClose = 1,
		OpenAll = 2,
		CloseAll = 3,
		ForceLock = 4,
		ForceUnlock = 5,
		LockAll = 6,
		EnableInteraction = 7,
		DisableInteraction = 8,
		DisableAllInteractions = 9,
		ResetInteractions = 10,
		ResetVehicle = 11,
		OpenAllRegular = 12,
		QuestLock = 13,
		QuestLockAll = 14,
		Count = 15,
		Invalid = 16
	}

	public enum vehicleEQuestVehicleWindowState
	{
		ForceOpen = 0,
		ForceClose = 1,
		OpenAll = 2,
		CloseAll = 3
	}

	public enum vehicleEState
	{
		Default = 1,
		On = 2,
		Disabled = 3,
		Destroyed = 4
	}

	public enum vehicleESummonedVehicleType
	{
		Any = 0,
		Car = 1,
		Motorcycle = 2
	}

	public enum vehicleEVehicleDoor
	{
		seat_front_left = 0,
		seat_front_right = 1,
		seat_back_left = 2,
		seat_back_right = 3,
		trunk = 4,
		hood = 5,
		count = 6,
		invalid = 7
	}

	public enum vehicleEVehicleSpeedConditionType
	{
		CT_EQUAL = 0,
		CT_NOT_EQUAL = 1,
		CT_GREATER = 2,
		CT_GREATER_EQUAL = 3,
		CT_LESS = 4,
		CT_LESS_EQUAL = 5,
		CT_ABS_GREATER = 6,
		CT_ABS_GREATER_EQUAL = 7,
		CT_ABS_LESS = 8,
		CT_ABS_LESS_EQUAL = 9
	}

	public enum vehicleEVehicleWindowState
	{
		Closed = 0,
		Open = 1
	}

	public enum vehicleExitDirection
	{
		NoDirection = -1,
		Left = 0,
		Right = 1,
		Front = 2,
		Back = 3,
		Top = 4
	}

	public enum vehicleFormationType : byte
	{
		FORMATION_TRIANGLE = 0,
		FORMATION_TURTLE = 1,
		FORMATION_QUINCUNX = 2
	}

	public enum vehicleGarageState
	{
		NoVehiclesAvailable = 0,
		SummonAvailable = 1,
		SummonDisabled = 2
	}

	public enum vehiclePlayerToAIInterpolationType
	{
		PTAIT_INSTANT = 0,
		PTAIT_LINEAR = 1,
		PTAIT_EASE_IN_QUAD = 2,
		PTAIT_EASE_IN_CUBIC = 3,
		PTAIT_EASE_OUT_CUBIC = 4,
		PTAIT_EASE_IN_OUT_CUBIC = 5,
		PTAIT_EASE_IN_QUANTIC = 6,
		PTAIT_EASE_IN_SIN = 7,
		PTAIT_EASE_OUT_SIN = 8,
		PTAIT_EASE_IN_OUT_SIN = 9,
		PTAIT_LINEAR_NON_SMOOTHED = 10,
		PTAIT_EASE_IN_QUAD_NON_SMOOTHED = 11,
		PTAIT_EASE_IN_CUBIC_NON_SMOOTHED = 12,
		PTAIT_EASE_OUT_CUBIC_NON_SMOOTHED = 13,
		PTAIT_EASE_IN_OUT_CUBIC_NON_SMOOTHED = 14,
		PTAIT_EASE_IN_QUANTIC_NON_SMOOTHED = 15,
		PTAIT_EASE_IN_SIN_NON_SMOOTHED = 16,
		PTAIT_EASE_OUT_SIN_NON_SMOOTHED = 17,
		PTAIT_EASE_IN_OUT_SIN_NON_SMOOTHED = 18
	}

	public enum vehiclePoliceStrategy : byte
	{
		None = 0,
		DriveTowardsPlayer = 1,
		DriveAwayFromPlayer = 2,
		PatrolNearby = 3,
		InterceptAtNextIntersection = 4,
		GetToPlayerFromAnywhere = 5,
		InitialSearch = 6,
		SearchFromAnywhere = 7,
		Count = 8
	}

	public enum vehicleQuestUIEnable
	{
		Gameplay = 0,
		ForceEnable = 1,
		ForceDisable = 2
	}

	public enum vehicleQuestWindowDestruction
	{
		window_f = 0,
		window_fl = 1,
		window_fr = 2,
		window_bl = 3,
		window_br = 4,
		window_b = 5
	}

	public enum vehicleRaceUI
	{
		PreRaceSetup = 0,
		CountdownStart = 1,
		RaceStart = 2,
		RaceEnd = 3,
		Disable = 4
	}

	public enum vehicleSummonFinishState
	{
		Arrived = 0
	}

	public enum vehicleSummonState
	{
		Idle = 0,
		EnRoute = 1,
		AlreadySummoned = 2,
		PathfindingFailed = 3,
		Arrived = 4
	}

	public enum vehicleTPPCameraDistance
	{
		Close = 0,
		Medium = 1,
		Far = 2,
		DriverCombatClose = 3,
		DriverCombatMedium = 4,
		DriverCombatFar = 5
	}

	public enum vehicleTPPCameraHeight
	{
		Low = 0,
		High = 1
	}

	public enum vehicleVehicleDoorInteractionState
	{
		Available = 0,
		Locked = 1,
		Disabled = 2,
		QuestLocked = 3,
		Reserved = 4
	}

	public enum vehicleVehicleDoorState
	{
		Closed = 0,
		Open = 1,
		Detached = 2
	}

	public enum vehicleVehicleNetrunnerQuickhackType
	{
		ForceBrakes = 0,
		Explode = 1,
		Accelerate = 2,
		NONE = 3
	}

	public enum vgEStyleAttributeType
	{
		FillColor = 0,
		StrokeColor = 1,
		StrokeSize = 2,
		StrokeMiterLimit = 3,
		FontFamily = 4,
		FontSize = 5
	}

	public enum visWorldOccluderType : byte
	{
		Default = 0,
		None = 1,
		Detail = 2,
		MinorInterior = 3,
		MajorInterior = 4,
		Exterior = 5
	}

	public enum workLogicalOperation : byte
	{
		AND = 0,
		OR = 1
	}

	public enum workPropAttachMethod
	{
		BonePosition = 0,
		RelativePosition = 1,
		Custom = 2
	}

	public enum workWeaponType
	{
		Any = 0,
		Ranged = 1,
		OneHandedRanged = 2,
		AssaultRifle = 3,
		Hammer = 8,
		Handgun = 9,
		HeavyMachineGun = 10,
		Katana = 11,
		Knife = 12,
		LightMachineGun = 13,
		LongBlade = 14,
		Melee = 16,
		OneHandedClub = 17,
		PrecisionRifle = 18,
		Revolver = 19,
		Rifle = 20,
		ShortBlade = 21,
		Shotgun = 22,
		ShotgunDual = 23,
		SniperRifle = 24,
		SubmachineGun = 25,
		TwoHandedClub = 27
	}

	public enum workWorkspotDebugMode
	{
		VisualLogToogle = 2,
		VisualLogOn = 4,
		VisualLogOff = 8,
		VisualStateToogle = 16,
		VisualStateOn = 32,
		VisualStateOff = 64,
		RecorderOn = 128,
		RecorderOff = 256,
		PlaybackOn = 512,
		PlaybackOff = 1024,
		Invalid = 4096,
		FunctionalTests = 8192
	}

	[Flags]
	public enum workWorkspotItemPolicy
	{
		ItemPolicy_SpawnItemOnIdleChange = 1 << 0,
		ItemPolicy_DespawnItemOnIdleChange = 1 << 1,
		ItemPolicy_DespawnItemOnReaction = 1 << 2
	}

	public enum workWorkspotLogic
	{
		Allow = 0,
		Deny = 1
	}

	public enum worldCommunityRegistryItemAreaNodeType : byte
	{
		Regular = 0,
		Streamable = 1,
		Background = 2,
		Count = 3
	}

	public enum worldEClusteringModel : byte
	{
		HierarchicalGrid = 0,
		AlwaysLoaded = 1,
		Discard = 2
	}

	public enum worldEditablePrefabType : byte
	{
		Regular = 0,
		Decoration = 1,
		Quest = 2,
		Building = 3,
		Road = 4
	}

	public enum worldFindLaneFilter
	{
		None = 0,
		Road = 1,
		PatrolRoute = 2,
		Pavement = 3
	}

	public enum worldNavigationRequestStatus
	{
		OK = 0,
		InvalidStartingPosition = 1,
		InvalidEndPosition = 2,
		OtherError = 3
	}

	public enum worldNodeGroupType : byte
	{
		RegularGroup = 0,
		PrefabVariant = 1,
		DecorationCell = 2,
		ProxyGroup = 3
	}

	public enum worldNodeSocketType : byte
	{
		Bidirectional = 0,
		Inward = 1,
		Outward = 2,
		Disabled = 3
	}

	public enum worldObjectTag
	{
		None = 1701736270,
		WallInterior = 1231839575,
		WallExterior = 1164730711,
		Floor = 1869573190,
		Stairs = 1936880723,
		Ladder = 1684300108,
		Decoration = 1868784964,
		Discard = 1668507972,
		Cover = 1920364355
	}

	public enum worldObjectTagExt
	{
		None = 1701736270,
		Default = 1634100548,
		NonClimbable = 1651262286
	}

	public enum worldOffMeshConnectionType
	{
		Door = 0,
		Ladder = 1,
		Floor = 2,
		Jump = 3,
		Elevator = 4,
		Drone = 5,
		Exploration = 6,
		Custom = 7,
		Blockade = 8
	}

	public enum worldPatrolSplinePointTypes
	{
		Workspot = 0,
		LookAt = 1,
		ClearLookAt = 2
	}

	public enum worldPrefabInteriorMapContribution : byte
	{
		Auto = 0,
		Include = 1,
		Discard = 2
	}

	public enum worldPrefabMinimapContribution : byte
	{
		Auto = 0,
		Include = 1,
		Discard = 2
	}

	public enum worldPrefabOwnership : byte
	{
		None = 0,
		Quest = 1,
		Audio = 2,
		Environment = 3,
		FX = 4,
		LevelDesign = 5,
		Lighting = 6,
		OpenWorld = 7,
		Cinematics = 8
	}

	public enum worldPrefabProxyMeshOnly : byte
	{
		SettingFromResource = 0,
		Enabled = 1,
		Disabled = 2
	}

	public enum worldPrefabStreamingImportance : byte
	{
		Auto = 0,
		P1 = 1,
		P2 = 2,
		P3 = 3,
		P4 = 4,
		P5 = 5
	}

	public enum worldPrefabStreamingOcclusion : byte
	{
		Default = 0,
		Exterior = 1,
		Interior = 2,
		OpenInterior = 3
	}

	public enum worldPrefabType : byte
	{
		Regular = 0,
		Area = 1,
		Generated = 2,
		Decoration = 3,
		Quest = 4,
		Road = 5,
		Building = 6,
		Terrain = 7
	}

	public enum worldProxWindowsType : byte
	{
		SkipWindows = 0,
		PropagateWindows = 1,
		BakeLongDistantWindows = 2,
		BakeWindowsToBuffer = 3
	}

	public enum worldProxyBBoxSyncOptions : byte
	{
		Do_Nothing = 0,
		Pull = 1,
		Pull_And_Delete = 2
	}

	public enum worldProxyCoreAxis : byte
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum worldProxyGroupingNormals : byte
	{
		Around_Core_Axis = 0,
		Around_All_Axes = 1
	}

	public enum worldProxyMeshBuildType : byte
	{
		ProxyFromScratch = 1,
		ProxyFromProxy = 0,
		OnlyFromChildProxies = 2
	}

	public enum worldProxyMeshDependencyMode : byte
	{
		Auto = 0,
		Include = 1,
		Discard = 2
	}

	public enum worldProxyMeshOutputType : byte
	{
		RayScan = 0,
		SurfaceReconstruction = 1,
		LegacyFromVoxels = 2,
		FromCustomMesh = 3,
		FromBoxes = 4,
		FromCollision = 5,
		FromConvexHull = 6,
		BoundsCombine = 7,
		BlobCrowd = 8,
		ReduceTarps = 9,
		KeepCurrent = 127
	}

	public enum worldProxyMeshTexRes : byte
	{
		RES_64 = 0,
		RES_128 = 1,
		RES_256 = 2,
		RES_512 = 3,
		RES_1024 = 4
	}

	public enum worldProxyMeshUVType : byte
	{
		UvUseExisting = 0,
		UvGenerateNew = 1
	}

	public enum worldProxyNormalAngleStepSize : byte
	{
		STEP_90 = 0,
		STEP_45 = 1,
		STEP_15 = 2,
		STEP_5 = 3
	}

	public enum worldProxySyncNormalSource : byte
	{
		From_Groups = 0,
		From_Face_Average = 1
	}

	public enum worldQuestPrefabLoadingMode : byte
	{
		Disable = 0,
		ForceLoad = 1
	}

	public enum worldQuestPreventionNotifierActivation : byte
	{
		OnFootOnly = 0,
		InVehicleOnly = 1,
		Always = 2
	}

	public enum worldQuestPreventionNotifierType : byte
	{
		Deescalation = 0,
		Clear = 1
	}

	public enum worldQuestType : byte
	{
		MainQuest = 0,
		SideQuest = 1,
		StreetStory = 2,
		MinorActivities = 3,
		MiniWorldStories = 4,
		CyberJunkie = 5,
		Courier = 6,
		CourierQuestGiver = 7,
		StuntChallenges = 8,
		StuntChallengesQuestGiver = 9,
		AirDrop = 10,
		BlackMarket = 11,
		Food = 12,
		TechStore = 13,
		Clothing = 14,
		Medpoint = 15,
		WeaponShop = 16,
		Ripperdoc = 17,
		CyberwareShop = 18,
		MeleeWeaponVendor = 19,
		Netrunner = 20,
		Outpost = 21,
		GangWatch = 22
	}

	public enum worldRainIntensity
	{
		NoRain = 0,
		LightRain = 1,
		HeavyRain = 2
	}

	public enum worldRoadMaterial
	{
		Concrete = 0,
		ConcreteDestroyed = 1,
		Dirt = 2,
		HardenedDirtDestroyed = 3
	}

	public enum worldRotatingMeshNodeAxis
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum worldSpeedSplineOrientationMarkerType
	{
		UseSplineOrientation = 0,
		WorldSpace = 1,
		LocalSpace = 2,
		KeepYawRoll_WorldSpacePitch = 3,
		KeepPitchYaw_WorldSpaceRoll = 4,
		KeepPitchRoll_WorldSpaceYaw = 5,
		KeepYaw_WorldSpacePitchRoll = 6,
		KeepRoll_WorldSpacePitchYaw = 7,
		KeepPitch_WorldSpaceYawRoll = 8
	}

	public enum worldStreamingDataGroup : byte
	{
		Base = 0,
		EP1 = 1
	}

	public enum worldStreamingSectorCategory : sbyte
	{
		Exterior = 0,
		Interior = 1,
		Quest = 2,
		Navigation = 3,
		AlwaysLoaded = 4,
		Unknown = -1
	}

	public enum worldStreamingTestCheckpointType
	{
		BeginMove = 0,
		EndMove = 1
	}

	public enum worldTrafficLanePersistentFlags : ushort
	{
		FromRoadSpline = 1,
		Bidirectional = 2,
		PatrolRoute = 4,
		Pavement = 8,
		Road = 16,
		Intersection = 32,
		NeverDeadEnd = 64,
		TrafficDisabled = 128,
		CrossWalk = 256,
		GPSOnly = 512,
		ShowDebug = 1024,
		Blockade = 2048,
		Yield = 4096,
		NoAIDriving = 8192,
		Highway = 16384
	}

	public enum worldTrafficLightColor
	{
		GREEN = 0,
		RED = 1,
		YELLOW = 2,
		INVALID = 3
	}

	public enum worldTrafficMovementBehavior
	{
		Pedestrian = 0,
		Car = 1
	}

	public enum worldTrafficSplineNodeUsage
	{
		Pavement = 0,
		Road = 1
	}

	public enum worldTrafficSpotDirection
	{
		Forward = 0,
		Backward = 1,
		Both = 2
	}

	public enum worldenvUtilsEBlendParamsType
	{
		EBPS_Tick = 0,
		EBPS_Game = 1,
		EBPS_Frame = 2
	}

	public enum worldgeometryDescriptionQueryFlags
	{
		DistanceVector = 1,
		CollisionNormal = 2,
		ObstacleDepth = 4,
		UpExtent = 8,
		DownExtent = 16,
		TopExtent = 32,
		TopPoint = 64,
		BehindPoint = 128
	}

	public enum worldgeometryDescriptionQueryStatus
	{
		OK = 0,
		NoGeometry = 1,
		UpVectorSameAsDirection = 2
	}

	public enum worldgeometryProbingStatus
	{
		None = 0,
		StillInObstacle = 1,
		GeometryDiverged = 2,
		Failure = 3
	}

	public enum worldgeometryaverageNormalDetectionHelperQueryStatus
	{
		Finished = 0,
		NoGeometry = 1
	}

	[Flags]
	public enum worlduiContextVisibility : ulong
	{
		SceneDefault = 1UL << 0,
		SceneTier1 = 1UL << 8,
		SceneTier2 = 1UL << 16,
		SceneTier3 = 1UL << 24,
		SceneTier4 = 1UL << 32,
		SceneTier5 = 1UL << 40
	}

	public enum worlduiEntryVisibility
	{
		TierVisibility = 0,
		ForceShow = 1,
		ForceHide = 2
	}

}