using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4Player : CPlayer
	{
		[Ordinal(1)] [RED("uselessProp")] 		public CEnum<EAsyncCheckResult> UselessProp { get; set;}

		[Ordinal(2)] [RED("horseWithInventory")] 		public EntityHandle HorseWithInventory { get; set;}

		[Ordinal(3)] [RED("pcGamePlayInitialized")] 		public CBool PcGamePlayInitialized { get; set;}

		[Ordinal(4)] [RED("pcMode")] 		public CBool PcMode { get; set;}

		[Ordinal(5)] [RED("weaponHolster")] 		public CHandle<WeaponHolster> WeaponHolster { get; set;}

		[Ordinal(6)] [RED("rangedWeapon")] 		public CHandle<Crossbow> RangedWeapon { get; set;}

		[Ordinal(7)] [RED("crossbowDontPopStateHack")] 		public CBool CrossbowDontPopStateHack { get; set;}

		[Ordinal(8)] [RED("hitReactTransScale")] 		public CFloat HitReactTransScale { get; set;}

		[Ordinal(9)] [RED("bIsCombatActionAllowed")] 		public CBool BIsCombatActionAllowed { get; set;}

		[Ordinal(10)] [RED("currentCombatAction")] 		public CEnum<EBufferActionType> CurrentCombatAction { get; set;}

		[Ordinal(11)] [RED("uninterruptedHitsCount")] 		public CInt32 UninterruptedHitsCount { get; set;}

		[Ordinal(12)] [RED("uninterruptedHitsCameraStarted")] 		public CBool UninterruptedHitsCameraStarted { get; set;}

		[Ordinal(13)] [RED("uninterruptedHitsCurrentCameraEffect")] 		public CName UninterruptedHitsCurrentCameraEffect { get; set;}

		[Ordinal(14)] [RED("counterTimestamps", 2,0)] 		public CArray<EngineTime> CounterTimestamps { get; set;}

		[Ordinal(15)] [RED("hitReactionEffect")] 		public CBool HitReactionEffect { get; set;}

		[Ordinal(16)] [RED("lookAtPosition")] 		public Vector LookAtPosition { get; set;}

		[Ordinal(17)] [RED("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[Ordinal(18)] [RED("customOrientationTarget")] 		public CEnum<EOrientationTarget> CustomOrientationTarget { get; set;}

		[Ordinal(19)] [RED("customOrientationStack", 2,0)] 		public CArray<SCustomOrientationParams> CustomOrientationStack { get; set;}

		[Ordinal(20)] [RED("delayOrientationChange")] 		public CBool DelayOrientationChange { get; set;}

		[Ordinal(21)] [RED("delayCameraOrientationChange")] 		public CBool DelayCameraOrientationChange { get; set;}

		[Ordinal(22)] [RED("actionType")] 		public CInt32 ActionType { get; set;}

		[Ordinal(23)] [RED("customOrientationStackIndex")] 		public CInt32 CustomOrientationStackIndex { get; set;}

		[Ordinal(24)] [RED("emptyMoveTargetTimer")] 		public CFloat EmptyMoveTargetTimer { get; set;}

		[Ordinal(25)] [RED("onlyOneEnemyLeft")] 		public CBool OnlyOneEnemyLeft { get; set;}

		[Ordinal(26)] [RED("isInFinisher")] 		public CBool IsInFinisher { get; set;}

		[Ordinal(27)] [RED("finisherTarget")] 		public CHandle<CGameplayEntity> FinisherTarget { get; set;}

		[Ordinal(28)] [RED("combatStance")] 		public CEnum<EPlayerCombatStance> CombatStance { get; set;}

		[Ordinal(29)] [RED("approachAttack")] 		public CInt32 ApproachAttack { get; set;}

		[Ordinal(30)] [RED("specialAttackCamera")] 		public CBool SpecialAttackCamera { get; set;}

		[Ordinal(31)] [RED("specialAttackTimeRatio")] 		public CFloat SpecialAttackTimeRatio { get; set;}

		[Ordinal(32)] [RED("itemsPerLevel", 2,0)] 		public CArray<CName> ItemsPerLevel { get; set;}

		[Ordinal(33)] [RED("itemsPerLevelGiven", 2,0)] 		public CArray<CBool> ItemsPerLevelGiven { get; set;}

		[Ordinal(34)] [RED("playerTickTimerPhase")] 		public CInt32 PlayerTickTimerPhase { get; set;}

		[Ordinal(35)] [RED("evadeHeading")] 		public CFloat EvadeHeading { get; set;}

		[Ordinal(36)] [RED("vehicleCbtMgrAiming")] 		public CBool VehicleCbtMgrAiming { get; set;}

		[Ordinal(37)] [RED("specialHeavyChargeDuration")] 		public CFloat SpecialHeavyChargeDuration { get; set;}

		[Ordinal(38)] [RED("specialHeavyStartEngineTime")] 		public EngineTime SpecialHeavyStartEngineTime { get; set;}

		[Ordinal(39)] [RED("playedSpecialAttackMissingResourceSound")] 		public CBool PlayedSpecialAttackMissingResourceSound { get; set;}

		[Ordinal(40)] [RED("counterCollisionGroupNames", 2,0)] 		public CArray<CName> CounterCollisionGroupNames { get; set;}

		[Ordinal(41)] [RED("lastInstantKillTime")] 		public GameTime LastInstantKillTime { get; set;}

		[Ordinal(42)] [RED("noSaveLockCombatActionName")] 		public CString NoSaveLockCombatActionName { get; set;}

		[Ordinal(43)] [RED("noSaveLockCombatAction")] 		public CInt32 NoSaveLockCombatAction { get; set;}

		[Ordinal(44)] [RED("deathNoSaveLock")] 		public CInt32 DeathNoSaveLock { get; set;}

		[Ordinal(45)] [RED("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[Ordinal(46)] [RED("newGamePlusInitialized")] 		public CBool NewGamePlusInitialized { get; set;}

		[Ordinal(47)] [RED("BufferAllSteps")] 		public CBool BufferAllSteps { get; set;}

		[Ordinal(48)] [RED("BufferCombatAction")] 		public CEnum<EBufferActionType> BufferCombatAction { get; set;}

		[Ordinal(49)] [RED("BufferButtonStage")] 		public CEnum<EButtonStage> BufferButtonStage { get; set;}

		[Ordinal(50)] [RED("keepRequestingCriticalAnimStart")] 		public CBool KeepRequestingCriticalAnimStart { get; set;}

		[Ordinal(51)] [RED("currentCustomAction")] 		public CEnum<EPlayerExplorationAction> CurrentCustomAction { get; set;}

		[Ordinal(52)] [RED("substateManager")] 		public CHandle<CExplorationStateManager> SubstateManager { get; set;}

		[Ordinal(53)] [RED("isOnBoat")] 		public CBool IsOnBoat { get; set;}

		[Ordinal(54)] [RED("isInShallowWater")] 		public CBool IsInShallowWater { get; set;}

		[Ordinal(55)] [RED("medallion")] 		public CHandle<W3MedallionFX> Medallion { get; set;}

		[Ordinal(56)] [RED("lastMedallionEffect")] 		public CFloat LastMedallionEffect { get; set;}

		[Ordinal(57)] [RED("isInRunAnimation")] 		public CBool IsInRunAnimation { get; set;}

		[Ordinal(58)] [RED("interiorTracker")] 		public CHandle<CPlayerInteriorTracker> InteriorTracker { get; set;}

		[Ordinal(59)] [RED("m_SettlementBlockCanter")] 		public CInt32 M_SettlementBlockCanter { get; set;}

		[Ordinal(60)] [RED("fistFightMinigameEnabled")] 		public CBool FistFightMinigameEnabled { get; set;}

		[Ordinal(61)] [RED("isFFMinigameToTheDeath")] 		public CBool IsFFMinigameToTheDeath { get; set;}

		[Ordinal(62)] [RED("FFMinigameEndsithBS")] 		public CBool FFMinigameEndsithBS { get; set;}

		[Ordinal(63)] [RED("fistFightTeleportNode")] 		public CHandle<CNode> FistFightTeleportNode { get; set;}

		[Ordinal(64)] [RED("isStartingFistFightMinigame")] 		public CBool IsStartingFistFightMinigame { get; set;}

		[Ordinal(65)] [RED("GeraltMaxHealth")] 		public CFloat GeraltMaxHealth { get; set;}

		[Ordinal(66)] [RED("fistsItems", 2,0)] 		public CArray<SItemUniqueId> FistsItems { get; set;}

		[Ordinal(67)] [RED("gwintAiDifficulty")] 		public CEnum<EGwintDifficultyMode> GwintAiDifficulty { get; set;}

		[Ordinal(68)] [RED("gwintAiAggression")] 		public CEnum<EGwintAggressionMode> GwintAiAggression { get; set;}

		[Ordinal(69)] [RED("gwintMinigameState")] 		public CEnum<EMinigameState> GwintMinigameState { get; set;}

		[Ordinal(70)] [RED("currentlyMountedHorse")] 		public CHandle<CNewNPC> CurrentlyMountedHorse { get; set;}

		[Ordinal(71)] [RED("horseSummonTimeStamp")] 		public CFloat HorseSummonTimeStamp { get; set;}

		[Ordinal(72)] [RED("isHorseRacing")] 		public CBool IsHorseRacing { get; set;}

		[Ordinal(73)] [RED("horseCombatSlowMo")] 		public CBool HorseCombatSlowMo { get; set;}

		[Ordinal(74)] [RED("HudMessages", 2,0)] 		public CArray<CString> HudMessages { get; set;}

		[Ordinal(75)] [RED("fShowToLowStaminaIndication")] 		public CFloat FShowToLowStaminaIndication { get; set;}

		[Ordinal(76)] [RED("showTooLowAdrenaline")] 		public CBool ShowTooLowAdrenaline { get; set;}

		[Ordinal(77)] [RED("HAXE3Container")] 		public CHandle<W3Container> HAXE3Container { get; set;}

		[Ordinal(78)] [RED("HAXE3bAutoLoot")] 		public CBool HAXE3bAutoLoot { get; set;}

		[Ordinal(79)] [RED("bShowHud")] 		public CBool BShowHud { get; set;}

		[Ordinal(80)] [RED("dodgeFeedbackTarget")] 		public CHandle<CActor> DodgeFeedbackTarget { get; set;}

		[Ordinal(81)] [RED("displayedQuestsGUID", 2,0)] 		public CArray<CGUID> DisplayedQuestsGUID { get; set;}

		[Ordinal(82)] [RED("rewardsMultiplier", 2,0)] 		public CArray<SRewardMultiplier> RewardsMultiplier { get; set;}

		[Ordinal(83)] [RED("glossaryImageOverride", 2,0)] 		public CArray<SGlossaryImageOverride> GlossaryImageOverride { get; set;}

		[Ordinal(84)] [RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[Ordinal(85)] [RED("explorationInputContext")] 		public CName ExplorationInputContext { get; set;}

		[Ordinal(86)] [RED("combatInputContext")] 		public CName CombatInputContext { get; set;}

		[Ordinal(87)] [RED("combatFistsInputContext")] 		public CName CombatFistsInputContext { get; set;}

		[Ordinal(88)] [RED("isInsideInteraction")] 		public CBool IsInsideInteraction { get; set;}

		[Ordinal(89)] [RED("isInsideHorseInteraction")] 		public CBool IsInsideHorseInteraction { get; set;}

		[Ordinal(90)] [RED("horseInteractionSource")] 		public CHandle<CEntity> HorseInteractionSource { get; set;}

		[Ordinal(91)] [RED("nearbyLockedContainersNoKey", 2,0)] 		public CArray<CHandle<W3LockableEntity>> NearbyLockedContainersNoKey { get; set;}

		[Ordinal(92)] [RED("bMoveTargetChangeAllowed")] 		public CBool BMoveTargetChangeAllowed { get; set;}

		[Ordinal(93)] [RED("moveAdj")] 		public CHandle<CMovementAdjustor> MoveAdj { get; set;}

		[Ordinal(94)] [RED("defaultLocomotionController")] 		public CHandle<CR4LocomotionPlayerControllerScript> DefaultLocomotionController { get; set;}

		[Ordinal(95)] [RED("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[Ordinal(96)] [RED("actorToFollow")] 		public CHandle<CActor> ActorToFollow { get; set;}

		[Ordinal(97)] [RED("terrainPitch")] 		public CFloat TerrainPitch { get; set;}

		[Ordinal(98)] [RED("steepSlopeNormalPitch")] 		public CFloat SteepSlopeNormalPitch { get; set;}

		[Ordinal(99)] [RED("disableSprintTerrainPitch")] 		public CFloat DisableSprintTerrainPitch { get; set;}

		[Ordinal(100)] [RED("submergeDepth")] 		public CFloat SubmergeDepth { get; set;}

		[Ordinal(101)] [RED("m_useSelectedItemIfSpawned")] 		public CBool M_useSelectedItemIfSpawned { get; set;}

		[Ordinal(102)] [RED("navQuery")] 		public CHandle<CNavigationReachabilityQueryInterface> NavQuery { get; set;}

		[Ordinal(103)] [RED("rememberedCustomHead")] 		public CName RememberedCustomHead { get; set;}

		[Ordinal(104)] [RED("disableWeatherDisplay")] 		public CBool DisableWeatherDisplay { get; set;}

		[Ordinal(105)] [RED("proudWalk")] 		public CBool ProudWalk { get; set;}

		[Ordinal(106)] [RED("etherealCount")] 		public CInt32 EtherealCount { get; set;}

		[Ordinal(107)] [RED("injuredWalk")] 		public CBool InjuredWalk { get; set;}

		[Ordinal(108)] [RED("tiedWalk")] 		public CBool TiedWalk { get; set;}

		[Ordinal(109)] [RED("insideDiveAttackArea")] 		public CBool InsideDiveAttackArea { get; set;}

		[Ordinal(110)] [RED("diveAreaNumber")] 		public CInt32 DiveAreaNumber { get; set;}

		[Ordinal(111)] [RED("flyingBossCamera")] 		public CBool FlyingBossCamera { get; set;}

		[Ordinal(112)] [RED("upscaledTooltipState")] 		public CBool UpscaledTooltipState { get; set;}

		[Ordinal(113)] [RED("phantomWeaponMgr")] 		public CHandle<CPhantomWeaponManager> PhantomWeaponMgr { get; set;}

		[Ordinal(114)] [RED("delayBetweenIllusionOneliners")] 		public CFloat DelayBetweenIllusionOneliners { get; set;}

		[Ordinal(115)] [RED("battlecry_timeForNext")] 		public CFloat Battlecry_timeForNext { get; set;}

		[Ordinal(116)] [RED("battlecry_delayMin")] 		public CFloat Battlecry_delayMin { get; set;}

		[Ordinal(117)] [RED("battlecry_delayMax")] 		public CFloat Battlecry_delayMax { get; set;}

		[Ordinal(118)] [RED("battlecry_lastTry")] 		public CName Battlecry_lastTry { get; set;}

		[Ordinal(119)] [RED("previousWeather")] 		public CName PreviousWeather { get; set;}

		[Ordinal(120)] [RED("previousRainStrength")] 		public CFloat PreviousRainStrength { get; set;}

		[Ordinal(121)] [RED("receivedDamageInCombat")] 		public CBool ReceivedDamageInCombat { get; set;}

		[Ordinal(122)] [RED("prevDayNightIsNight")] 		public CBool PrevDayNightIsNight { get; set;}

		[Ordinal(123)] [RED("failedFundamentalsFirstAchievementCondition")] 		public CBool FailedFundamentalsFirstAchievementCondition { get; set;}

		[Ordinal(124)] [RED("spawnedTime")] 		public CFloat SpawnedTime { get; set;}

		[Ordinal(125)] [RED("currentMonsterHuntInvestigationArea")] 		public CHandle<W3MonsterHuntInvestigationArea> CurrentMonsterHuntInvestigationArea { get; set;}

		[Ordinal(126)] [RED("isPerformingPhaseChangeAnimation")] 		public CBool IsPerformingPhaseChangeAnimation { get; set;}

		[Ordinal(127)] [RED("playerMode")] 		public CHandle<W3PlayerMode> PlayerMode { get; set;}

		[Ordinal(128)] [RED("selectedItemId")] 		public SItemUniqueId SelectedItemId { get; set;}

		[Ordinal(129)] [RED("blockedRadialSlots", 2,0)] 		public CArray<SRadialSlotDef> BlockedRadialSlots { get; set;}

		[Ordinal(130)] [RED("enemyCollectionDist")] 		public CFloat EnemyCollectionDist { get; set;}

		[Ordinal(131)] [RED("findMoveTargetDistMin")] 		public CFloat FindMoveTargetDistMin { get; set;}

		[Ordinal(132)] [RED("findMoveTargetDistMax")] 		public CFloat FindMoveTargetDistMax { get; set;}

		[Ordinal(133)] [RED("findMoveTargetScaledFrame")] 		public CFloat FindMoveTargetScaledFrame { get; set;}

		[Ordinal(134)] [RED("interactDist")] 		public CFloat InteractDist { get; set;}

		[Ordinal(135)] [RED("bCanFindTarget")] 		public CBool BCanFindTarget { get; set;}

		[Ordinal(136)] [RED("bIsConfirmingEmptyTarget")] 		public CBool BIsConfirmingEmptyTarget { get; set;}

		[Ordinal(137)] [RED("displayTarget")] 		public CHandle<CGameplayEntity> DisplayTarget { get; set;}

		[Ordinal(138)] [RED("isShootingFriendly")] 		public CBool IsShootingFriendly { get; set;}

		[Ordinal(139)] [RED("currentSelectedTarget")] 		public CHandle<CActor> CurrentSelectedTarget { get; set;}

		[Ordinal(140)] [RED("selectedTargetToConfirm")] 		public CHandle<CActor> SelectedTargetToConfirm { get; set;}

		[Ordinal(141)] [RED("bConfirmTargetTimerIsEnabled")] 		public CBool BConfirmTargetTimerIsEnabled { get; set;}

		[Ordinal(142)] [RED("thrownEntityHandle")] 		public EntityHandle ThrownEntityHandle { get; set;}

		[Ordinal(143)] [RED("isThrowingItemWithAim")] 		public CBool IsThrowingItemWithAim { get; set;}

		[Ordinal(144)] [RED("isThrowingItem")] 		public CBool IsThrowingItem { get; set;}

		[Ordinal(145)] [RED("isThrowHoldPressed")] 		public CBool IsThrowHoldPressed { get; set;}

		[Ordinal(146)] [RED("isAimingCrossbow")] 		public CBool IsAimingCrossbow { get; set;}

		[Ordinal(147)] [RED("playerAiming")] 		public CHandle<PlayerAiming> PlayerAiming { get; set;}

		[Ordinal(148)] [RED("forceDismember")] 		public CBool ForceDismember { get; set;}

		[Ordinal(149)] [RED("forceDismemberName")] 		public CName ForceDismemberName { get; set;}

		[Ordinal(150)] [RED("forceDismemberChance")] 		public CInt32 ForceDismemberChance { get; set;}

		[Ordinal(151)] [RED("forceDismemberExplosion")] 		public CBool ForceDismemberExplosion { get; set;}

		[Ordinal(152)] [RED("finisherVictim")] 		public CHandle<CActor> FinisherVictim { get; set;}

		[Ordinal(153)] [RED("forceFinisher")] 		public CBool ForceFinisher { get; set;}

		[Ordinal(154)] [RED("forceFinisherAnimName")] 		public CName ForceFinisherAnimName { get; set;}

		[Ordinal(155)] [RED("forceFinisherChance")] 		public CInt32 ForceFinisherChance { get; set;}

		[Ordinal(156)] [RED("forcedStance")] 		public CBool ForcedStance { get; set;}

		[Ordinal(157)] [RED("m_WeaponFXCollisionGroupNames", 2,0)] 		public CArray<CName> M_WeaponFXCollisionGroupNames { get; set;}

		[Ordinal(158)] [RED("m_CollisionEffect")] 		public CHandle<CEntity> M_CollisionEffect { get; set;}

		[Ordinal(159)] [RED("m_LastWeaponTipPos")] 		public Vector M_LastWeaponTipPos { get; set;}

		[Ordinal(160)] [RED("m_CollisionFxTemplate")] 		public CHandle<CEntityTemplate> M_CollisionFxTemplate { get; set;}

		[Ordinal(161)] [RED("m_RefreshWeaponFXType")] 		public CBool M_RefreshWeaponFXType { get; set;}

		[Ordinal(162)] [RED("m_PlayWoodenFX")] 		public CBool M_PlayWoodenFX { get; set;}

		[Ordinal(163)] [RED("m_activePoster")] 		public CHandle<W3Poster> M_activePoster { get; set;}

		[Ordinal(164)] [RED("horseOnNavMesh")] 		public CBool HorseOnNavMesh { get; set;}

		[Ordinal(165)] [RED("testAdjustRequestedMovementDirection")] 		public CBool TestAdjustRequestedMovementDirection { get; set;}

		[Ordinal(166)] [RED("targeting")] 		public CHandle<CR4PlayerTargeting> Targeting { get; set;}

		[Ordinal(167)] [RED("targetingPrecalcs")] 		public SR4PlayerTargetingPrecalcs TargetingPrecalcs { get; set;}

		[Ordinal(168)] [RED("targetingIn")] 		public SR4PlayerTargetingIn TargetingIn { get; set;}

		[Ordinal(169)] [RED("targetingOut")] 		public SR4PlayerTargetingOut TargetingOut { get; set;}

		[Ordinal(170)] [RED("useNativeTargeting")] 		public CBool UseNativeTargeting { get; set;}

		[Ordinal(171)] [RED("visibleActors", 2,0)] 		public CArray<CHandle<CActor>> VisibleActors { get; set;}

		[Ordinal(172)] [RED("visibleActorsTime", 2,0)] 		public CArray<CFloat> VisibleActorsTime { get; set;}

		[Ordinal(173)] [RED("parryTarget")] 		public CHandle<CActor> ParryTarget { get; set;}

		[Ordinal(174)] [RED("ragdollTarget")] 		public CHandle<CActor> RagdollTarget { get; set;}

		[Ordinal(175)] [RED("playerActionEventListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventListeners { get; set;}

		[Ordinal(176)] [RED("playerActionEventBlockingListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventBlockingListeners { get; set;}

		[Ordinal(177)] [RED("playerActionSlotAnimName")] 		public CName PlayerActionSlotAnimName { get; set;}

		[Ordinal(178)] [RED("isHoldingDeadlySword")] 		public CBool IsHoldingDeadlySword { get; set;}

		[Ordinal(179)] [RED("reevaluateCurrentWeapon")] 		public CBool ReevaluateCurrentWeapon { get; set;}

		[Ordinal(180)] [RED("disableActionBlend")] 		public CBool DisableActionBlend { get; set;}

		[Ordinal(181)] [RED("slideNPC")] 		public CHandle<CNewNPC> SlideNPC { get; set;}

		[Ordinal(182)] [RED("minSlideDistance")] 		public CFloat MinSlideDistance { get; set;}

		[Ordinal(183)] [RED("maxSlideDistance")] 		public CFloat MaxSlideDistance { get; set;}

		[Ordinal(184)] [RED("slideTicket")] 		public SMovementAdjustmentRequestTicket SlideTicket { get; set;}

		[Ordinal(185)] [RED("gwintCardNumbersArray", 2,0)] 		public CArray<CInt32> GwintCardNumbersArray { get; set;}

		[Ordinal(186)] [RED("customCameraStack", 2,0)] 		public CArray<SCustomCameraParams> CustomCameraStack { get; set;}

		[Ordinal(187)] [RED("questCameraRequest")] 		public SQuestCameraRequest QuestCameraRequest { get; set;}

		[Ordinal(188)] [RED("cameraRequestTimeStamp")] 		public CFloat CameraRequestTimeStamp { get; set;}

		[Ordinal(189)] [RED("wasRunning")] 		public CBool WasRunning { get; set;}

		[Ordinal(190)] [RED("vel")] 		public CFloat Vel { get; set;}

		[Ordinal(191)] [RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		[Ordinal(192)] [RED("constDamper")] 		public CHandle<ConstDamper> ConstDamper { get; set;}

		[Ordinal(193)] [RED("rotMultVel")] 		public CFloat RotMultVel { get; set;}

		[Ordinal(194)] [RED("wasBRAxisPushed")] 		public CBool WasBRAxisPushed { get; set;}

		[Ordinal(195)] [RED("fovVel")] 		public CFloat FovVel { get; set;}

		[Ordinal(196)] [RED("sprintOffset")] 		public Vector SprintOffset { get; set;}

		[Ordinal(197)] [RED("previousOffset")] 		public CBool PreviousOffset { get; set;}

		[Ordinal(198)] [RED("previousRotationVelocity")] 		public CFloat PreviousRotationVelocity { get; set;}

		[Ordinal(199)] [RED("pivotRotationTimeStamp")] 		public CFloat PivotRotationTimeStamp { get; set;}

		[Ordinal(200)] [RED("disableManualCameraControlStack", 2,0)] 		public CArray<CName> DisableManualCameraControlStack { get; set;}

		[Ordinal(201)] [RED("customOrientationInfoStack", 2,0)] 		public CArray<SCustomOrientationInfo> CustomOrientationInfoStack { get; set;}

		[Ordinal(202)] [RED("isSnappedToNavMesh")] 		public CBool IsSnappedToNavMesh { get; set;}

		[Ordinal(203)] [RED("snapToNavMeshCachedFlag")] 		public CBool SnapToNavMeshCachedFlag { get; set;}

		[Ordinal(204)] [RED("navMeshSnapInfoStack", 2,0)] 		public CArray<CName> NavMeshSnapInfoStack { get; set;}

		[Ordinal(205)] [RED("beingWarnedBy", 2,0)] 		public CArray<CHandle<CActor>> BeingWarnedBy { get; set;}

		[Ordinal(206)] [RED("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[Ordinal(207)] [RED("hostileMonsters", 2,0)] 		public CArray<CHandle<CActor>> HostileMonsters { get; set;}

		[Ordinal(208)] [RED("canFindPathEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> CanFindPathEnemiesList { get; set;}

		[Ordinal(209)] [RED("disablecanFindPathEnemiesListUpdate")] 		public CBool DisablecanFindPathEnemiesListUpdate { get; set;}

		[Ordinal(210)] [RED("lastCanFindPathEnemy")] 		public CHandle<CActor> LastCanFindPathEnemy { get; set;}

		[Ordinal(211)] [RED("cachedMoveTarget")] 		public CHandle<CActor> CachedMoveTarget { get; set;}

		[Ordinal(212)] [RED("reachabilityTestId")] 		public CInt32 ReachabilityTestId { get; set;}

		[Ordinal(213)] [RED("reachabilityTestId2")] 		public CInt32 ReachabilityTestId2 { get; set;}

		[Ordinal(214)] [RED("finishableEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemiesList { get; set;}

		[Ordinal(215)] [RED("hostileEnemyToRemove")] 		public CHandle<CActor> HostileEnemyToRemove { get; set;}

		[Ordinal(216)] [RED("moveTargets", 2,0)] 		public CArray<CHandle<CActor>> MoveTargets { get; set;}

		[Ordinal(217)] [RED("enableStrafe")] 		public CBool EnableStrafe { get; set;}

		[Ordinal(218)] [RED("isInCombatReason")] 		public CInt32 IsInCombatReason { get; set;}

		[Ordinal(219)] [RED("canFindPathToEnemy")] 		public CBool CanFindPathToEnemy { get; set;}

		[Ordinal(220)] [RED("combatModeEnt")] 		public CHandle<CEntity> CombatModeEnt { get; set;}

		[Ordinal(221)] [RED("navDist")] 		public CFloat NavDist { get; set;}

		[Ordinal(222)] [RED("directDist")] 		public CFloat DirectDist { get; set;}

		[Ordinal(223)] [RED("reachableEnemyWasTooFar")] 		public CBool ReachableEnemyWasTooFar { get; set;}

		[Ordinal(224)] [RED("reachableEnemyWasTooFarTimeStamp")] 		public CFloat ReachableEnemyWasTooFarTimeStamp { get; set;}

		[Ordinal(225)] [RED("reachablilityFailed")] 		public CBool ReachablilityFailed { get; set;}

		[Ordinal(226)] [RED("reachablilityFailedTimeStamp")] 		public CFloat ReachablilityFailedTimeStamp { get; set;}

		[Ordinal(227)] [RED("isThreatened")] 		public CBool IsThreatened { get; set;}

		[Ordinal(228)] [RED("bConfirmDisplayTargetTimerEnabled")] 		public CBool BConfirmDisplayTargetTimerEnabled { get; set;}

		[Ordinal(229)] [RED("displayTargetToConfirm")] 		public CHandle<CGameplayEntity> DisplayTargetToConfirm { get; set;}

		[Ordinal(230)] [RED("currentSelectedDisplayTarget")] 		public CHandle<CGameplayEntity> CurrentSelectedDisplayTarget { get; set;}

		[Ordinal(231)] [RED("isDisplayTargetTargetable")] 		public CBool IsDisplayTargetTargetable { get; set;}

		[Ordinal(232)] [RED("radialSlots", 2,0)] 		public CArray<CName> RadialSlots { get; set;}

		[Ordinal(233)] [RED("combatModeColor")] 		public CColor CombatModeColor { get; set;}

		[Ordinal(234)] [RED("confirmCombatStanceTimeStamp")] 		public CFloat ConfirmCombatStanceTimeStamp { get; set;}

		[Ordinal(235)] [RED("isConfirmingCombatStance")] 		public CBool IsConfirmingCombatStance { get; set;}

		[Ordinal(236)] [RED("isInHolsterAnim")] 		public CBool IsInHolsterAnim { get; set;}

		[Ordinal(237)] [RED("dodgeTimerRunning")] 		public CBool DodgeTimerRunning { get; set;}

		[Ordinal(238)] [RED("forceCanAttackWhenNotInCombat")] 		public CInt32 ForceCanAttackWhenNotInCombat { get; set;}

		[Ordinal(239)] [RED("countDownToStart")] 		public CInt32 CountDownToStart { get; set;}

		[Ordinal(240)] [RED("inWaterTrigger")] 		public CBool InWaterTrigger { get; set;}

		[Ordinal(241)] [RED("isRotatingInPlace")] 		public CBool IsRotatingInPlace { get; set;}

		[Ordinal(242)] [RED("isInIdle")] 		public CBool IsInIdle { get; set;}

		[Ordinal(243)] [RED("isInGuardedState")] 		public CBool IsInGuardedState { get; set;}

		[Ordinal(244)] [RED("restoreUsableItem")] 		public CBool RestoreUsableItem { get; set;}

		[Ordinal(245)] [RED("holsterUsableItem")] 		public CBool HolsterUsableItem { get; set;}

		[Ordinal(246)] [RED("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[Ordinal(247)] [RED("finisherSaveLock")] 		public CInt32 FinisherSaveLock { get; set;}

		[Ordinal(248)] [RED("currentlyUsingItem")] 		public CBool CurrentlyUsingItem { get; set;}

		[Ordinal(249)] [RED("MOUNT_DISTANCE_CBT")] 		public CFloat MOUNT_DISTANCE_CBT { get; set;}

		[Ordinal(250)] [RED("MOUNT_ANGLE_CBT")] 		public CFloat MOUNT_ANGLE_CBT { get; set;}

		[Ordinal(251)] [RED("MOUNT_ANGLE_EXP")] 		public CFloat MOUNT_ANGLE_EXP { get; set;}

		[Ordinal(252)] [RED("m_bossTag")] 		public CName M_bossTag { get; set;}

		[Ordinal(253)] [RED("m_usingCoatOfArms")] 		public CBool M_usingCoatOfArms { get; set;}

		[Ordinal(254)] [RED("m_initialTimeOut")] 		public CFloat M_initialTimeOut { get; set;}

		[Ordinal(255)] [RED("m_currentTimeOut")] 		public CFloat M_currentTimeOut { get; set;}

		[Ordinal(256)] [RED("loopingCameraShakeAnimName")] 		public CName LoopingCameraShakeAnimName { get; set;}

		[Ordinal(257)] [RED("forcedFinisherVictim")] 		public CHandle<CActor> ForcedFinisherVictim { get; set;}

		public CR4Player(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Player(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}