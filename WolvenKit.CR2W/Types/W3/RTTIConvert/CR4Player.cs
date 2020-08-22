using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4Player : CPlayer
	{
		[RED("uselessProp")] 		public CEnum<EAsyncCheckResult> UselessProp { get; set;}

		[RED("horseWithInventory")] 		public EntityHandle HorseWithInventory { get; set;}

		[RED("pcGamePlayInitialized")] 		public CBool PcGamePlayInitialized { get; set;}

		[RED("pcMode")] 		public CBool PcMode { get; set;}

		[RED("weaponHolster")] 		public CHandle<WeaponHolster> WeaponHolster { get; set;}

		[RED("rangedWeapon")] 		public CHandle<Crossbow> RangedWeapon { get; set;}

		[RED("crossbowDontPopStateHack")] 		public CBool CrossbowDontPopStateHack { get; set;}

		[RED("hitReactTransScale")] 		public CFloat HitReactTransScale { get; set;}

		[RED("bIsCombatActionAllowed")] 		public CBool BIsCombatActionAllowed { get; set;}

		[RED("currentCombatAction")] 		public CEnum<EBufferActionType> CurrentCombatAction { get; set;}

		[RED("uninterruptedHitsCount")] 		public CInt32 UninterruptedHitsCount { get; set;}

		[RED("uninterruptedHitsCameraStarted")] 		public CBool UninterruptedHitsCameraStarted { get; set;}

		[RED("uninterruptedHitsCurrentCameraEffect")] 		public CName UninterruptedHitsCurrentCameraEffect { get; set;}

		[RED("counterTimestamps", 2,0)] 		public CArray<EngineTime> CounterTimestamps { get; set;}

		[RED("hitReactionEffect")] 		public CBool HitReactionEffect { get; set;}

		[RED("lookAtPosition")] 		public Vector LookAtPosition { get; set;}

		[RED("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[RED("customOrientationTarget")] 		public CEnum<EOrientationTarget> CustomOrientationTarget { get; set;}

		[RED("customOrientationStack", 2,0)] 		public CArray<SCustomOrientationParams> CustomOrientationStack { get; set;}

		[RED("delayOrientationChange")] 		public CBool DelayOrientationChange { get; set;}

		[RED("delayCameraOrientationChange")] 		public CBool DelayCameraOrientationChange { get; set;}

		[RED("actionType")] 		public CInt32 ActionType { get; set;}

		[RED("customOrientationStackIndex")] 		public CInt32 CustomOrientationStackIndex { get; set;}

		[RED("emptyMoveTargetTimer")] 		public CFloat EmptyMoveTargetTimer { get; set;}

		[RED("onlyOneEnemyLeft")] 		public CBool OnlyOneEnemyLeft { get; set;}

		[RED("isInFinisher")] 		public CBool IsInFinisher { get; set;}

		[RED("finisherTarget")] 		public CHandle<CGameplayEntity> FinisherTarget { get; set;}

		[RED("combatStance")] 		public CEnum<EPlayerCombatStance> CombatStance { get; set;}

		[RED("approachAttack")] 		public CInt32 ApproachAttack { get; set;}

		[RED("specialAttackCamera")] 		public CBool SpecialAttackCamera { get; set;}

		[RED("specialAttackTimeRatio")] 		public CFloat SpecialAttackTimeRatio { get; set;}

		[RED("itemsPerLevel", 2,0)] 		public CArray<CName> ItemsPerLevel { get; set;}

		[RED("itemsPerLevelGiven", 2,0)] 		public CArray<CBool> ItemsPerLevelGiven { get; set;}

		[RED("playerTickTimerPhase")] 		public CInt32 PlayerTickTimerPhase { get; set;}

		[RED("evadeHeading")] 		public CFloat EvadeHeading { get; set;}

		[RED("vehicleCbtMgrAiming")] 		public CBool VehicleCbtMgrAiming { get; set;}

		[RED("specialHeavyChargeDuration")] 		public CFloat SpecialHeavyChargeDuration { get; set;}

		[RED("specialHeavyStartEngineTime")] 		public EngineTime SpecialHeavyStartEngineTime { get; set;}

		[RED("playedSpecialAttackMissingResourceSound")] 		public CBool PlayedSpecialAttackMissingResourceSound { get; set;}

		[RED("counterCollisionGroupNames", 2,0)] 		public CArray<CName> CounterCollisionGroupNames { get; set;}

		[RED("lastInstantKillTime")] 		public GameTime LastInstantKillTime { get; set;}

		[RED("noSaveLockCombatActionName")] 		public CString NoSaveLockCombatActionName { get; set;}

		[RED("noSaveLockCombatAction")] 		public CInt32 NoSaveLockCombatAction { get; set;}

		[RED("deathNoSaveLock")] 		public CInt32 DeathNoSaveLock { get; set;}

		[RED("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[RED("newGamePlusInitialized")] 		public CBool NewGamePlusInitialized { get; set;}

		[RED("BufferAllSteps")] 		public CBool BufferAllSteps { get; set;}

		[RED("BufferCombatAction")] 		public CEnum<EBufferActionType> BufferCombatAction { get; set;}

		[RED("BufferButtonStage")] 		public CEnum<EButtonStage> BufferButtonStage { get; set;}

		[RED("keepRequestingCriticalAnimStart")] 		public CBool KeepRequestingCriticalAnimStart { get; set;}

		[RED("currentCustomAction")] 		public CEnum<EPlayerExplorationAction> CurrentCustomAction { get; set;}

		[RED("substateManager")] 		public CHandle<CExplorationStateManager> SubstateManager { get; set;}

		[RED("isOnBoat")] 		public CBool IsOnBoat { get; set;}

		[RED("isInShallowWater")] 		public CBool IsInShallowWater { get; set;}

		[RED("medallion")] 		public CHandle<W3MedallionFX> Medallion { get; set;}

		[RED("lastMedallionEffect")] 		public CFloat LastMedallionEffect { get; set;}

		[RED("isInRunAnimation")] 		public CBool IsInRunAnimation { get; set;}

		[RED("interiorTracker")] 		public CHandle<CPlayerInteriorTracker> InteriorTracker { get; set;}

		[RED("m_SettlementBlockCanter")] 		public CInt32 M_SettlementBlockCanter { get; set;}

		[RED("fistFightMinigameEnabled")] 		public CBool FistFightMinigameEnabled { get; set;}

		[RED("isFFMinigameToTheDeath")] 		public CBool IsFFMinigameToTheDeath { get; set;}

		[RED("FFMinigameEndsithBS")] 		public CBool FFMinigameEndsithBS { get; set;}

		[RED("fistFightTeleportNode")] 		public CHandle<CNode> FistFightTeleportNode { get; set;}

		[RED("isStartingFistFightMinigame")] 		public CBool IsStartingFistFightMinigame { get; set;}

		[RED("GeraltMaxHealth")] 		public CFloat GeraltMaxHealth { get; set;}

		[RED("fistsItems", 2,0)] 		public CArray<SItemUniqueId> FistsItems { get; set;}

		[RED("gwintAiDifficulty")] 		public CEnum<EGwintDifficultyMode> GwintAiDifficulty { get; set;}

		[RED("gwintAiAggression")] 		public CEnum<EGwintAggressionMode> GwintAiAggression { get; set;}

		[RED("gwintMinigameState")] 		public CEnum<EMinigameState> GwintMinigameState { get; set;}

		[RED("currentlyMountedHorse")] 		public CHandle<CNewNPC> CurrentlyMountedHorse { get; set;}

		[RED("horseSummonTimeStamp")] 		public CFloat HorseSummonTimeStamp { get; set;}

		[RED("isHorseRacing")] 		public CBool IsHorseRacing { get; set;}

		[RED("horseCombatSlowMo")] 		public CBool HorseCombatSlowMo { get; set;}

		[RED("HudMessages", 2,0)] 		public CArray<CString> HudMessages { get; set;}

		[RED("fShowToLowStaminaIndication")] 		public CFloat FShowToLowStaminaIndication { get; set;}

		[RED("showTooLowAdrenaline")] 		public CBool ShowTooLowAdrenaline { get; set;}

		[RED("HAXE3Container")] 		public CHandle<W3Container> HAXE3Container { get; set;}

		[RED("HAXE3bAutoLoot")] 		public CBool HAXE3bAutoLoot { get; set;}

		[RED("bShowHud")] 		public CBool BShowHud { get; set;}

		[RED("dodgeFeedbackTarget")] 		public CHandle<CActor> DodgeFeedbackTarget { get; set;}

		[RED("displayedQuestsGUID", 2,0)] 		public CArray<CGUID> DisplayedQuestsGUID { get; set;}

		[RED("rewardsMultiplier", 2,0)] 		public CArray<SRewardMultiplier> RewardsMultiplier { get; set;}

		[RED("glossaryImageOverride", 2,0)] 		public CArray<SGlossaryImageOverride> GlossaryImageOverride { get; set;}

		[RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[RED("explorationInputContext")] 		public CName ExplorationInputContext { get; set;}

		[RED("combatInputContext")] 		public CName CombatInputContext { get; set;}

		[RED("combatFistsInputContext")] 		public CName CombatFistsInputContext { get; set;}

		[RED("isInsideInteraction")] 		public CBool IsInsideInteraction { get; set;}

		[RED("isInsideHorseInteraction")] 		public CBool IsInsideHorseInteraction { get; set;}

		[RED("horseInteractionSource")] 		public CHandle<CEntity> HorseInteractionSource { get; set;}

		[RED("nearbyLockedContainersNoKey", 2,0)] 		public CArray<CHandle<W3LockableEntity>> NearbyLockedContainersNoKey { get; set;}

		[RED("bMoveTargetChangeAllowed")] 		public CBool BMoveTargetChangeAllowed { get; set;}

		[RED("moveAdj")] 		public CHandle<CMovementAdjustor> MoveAdj { get; set;}

		[RED("defaultLocomotionController")] 		public CHandle<CR4LocomotionPlayerControllerScript> DefaultLocomotionController { get; set;}

		[RED("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[RED("actorToFollow")] 		public CHandle<CActor> ActorToFollow { get; set;}

		[RED("terrainPitch")] 		public CFloat TerrainPitch { get; set;}

		[RED("steepSlopeNormalPitch")] 		public CFloat SteepSlopeNormalPitch { get; set;}

		[RED("disableSprintTerrainPitch")] 		public CFloat DisableSprintTerrainPitch { get; set;}

		[RED("submergeDepth")] 		public CFloat SubmergeDepth { get; set;}

		[RED("m_useSelectedItemIfSpawned")] 		public CBool M_useSelectedItemIfSpawned { get; set;}

		[RED("navQuery")] 		public CHandle<CNavigationReachabilityQueryInterface> NavQuery { get; set;}

		[RED("rememberedCustomHead")] 		public CName RememberedCustomHead { get; set;}

		[RED("disableWeatherDisplay")] 		public CBool DisableWeatherDisplay { get; set;}

		[RED("proudWalk")] 		public CBool ProudWalk { get; set;}

		[RED("etherealCount")] 		public CInt32 EtherealCount { get; set;}

		[RED("injuredWalk")] 		public CBool InjuredWalk { get; set;}

		[RED("tiedWalk")] 		public CBool TiedWalk { get; set;}

		[RED("insideDiveAttackArea")] 		public CBool InsideDiveAttackArea { get; set;}

		[RED("diveAreaNumber")] 		public CInt32 DiveAreaNumber { get; set;}

		[RED("flyingBossCamera")] 		public CBool FlyingBossCamera { get; set;}

		[RED("upscaledTooltipState")] 		public CBool UpscaledTooltipState { get; set;}

		[RED("phantomWeaponMgr")] 		public CHandle<CPhantomWeaponManager> PhantomWeaponMgr { get; set;}

		[RED("delayBetweenIllusionOneliners")] 		public CFloat DelayBetweenIllusionOneliners { get; set;}

		[RED("battlecry_timeForNext")] 		public CFloat Battlecry_timeForNext { get; set;}

		[RED("battlecry_delayMin")] 		public CFloat Battlecry_delayMin { get; set;}

		[RED("battlecry_delayMax")] 		public CFloat Battlecry_delayMax { get; set;}

		[RED("battlecry_lastTry")] 		public CName Battlecry_lastTry { get; set;}

		[RED("previousWeather")] 		public CName PreviousWeather { get; set;}

		[RED("previousRainStrength")] 		public CFloat PreviousRainStrength { get; set;}

		[RED("receivedDamageInCombat")] 		public CBool ReceivedDamageInCombat { get; set;}

		[RED("prevDayNightIsNight")] 		public CBool PrevDayNightIsNight { get; set;}

		[RED("failedFundamentalsFirstAchievementCondition")] 		public CBool FailedFundamentalsFirstAchievementCondition { get; set;}

		[RED("spawnedTime")] 		public CFloat SpawnedTime { get; set;}

		[RED("currentMonsterHuntInvestigationArea")] 		public CHandle<W3MonsterHuntInvestigationArea> CurrentMonsterHuntInvestigationArea { get; set;}

		[RED("isPerformingPhaseChangeAnimation")] 		public CBool IsPerformingPhaseChangeAnimation { get; set;}

		[RED("playerMode")] 		public CHandle<W3PlayerMode> PlayerMode { get; set;}

		[RED("selectedItemId")] 		public SItemUniqueId SelectedItemId { get; set;}

		[RED("blockedRadialSlots", 2,0)] 		public CArray<SRadialSlotDef> BlockedRadialSlots { get; set;}

		[RED("enemyCollectionDist")] 		public CFloat EnemyCollectionDist { get; set;}

		[RED("findMoveTargetDistMin")] 		public CFloat FindMoveTargetDistMin { get; set;}

		[RED("findMoveTargetDistMax")] 		public CFloat FindMoveTargetDistMax { get; set;}

		[RED("findMoveTargetScaledFrame")] 		public CFloat FindMoveTargetScaledFrame { get; set;}

		[RED("interactDist")] 		public CFloat InteractDist { get; set;}

		[RED("bCanFindTarget")] 		public CBool BCanFindTarget { get; set;}

		[RED("bIsConfirmingEmptyTarget")] 		public CBool BIsConfirmingEmptyTarget { get; set;}

		[RED("displayTarget")] 		public CHandle<CGameplayEntity> DisplayTarget { get; set;}

		[RED("isShootingFriendly")] 		public CBool IsShootingFriendly { get; set;}

		[RED("currentSelectedTarget")] 		public CHandle<CActor> CurrentSelectedTarget { get; set;}

		[RED("selectedTargetToConfirm")] 		public CHandle<CActor> SelectedTargetToConfirm { get; set;}

		[RED("bConfirmTargetTimerIsEnabled")] 		public CBool BConfirmTargetTimerIsEnabled { get; set;}

		[RED("thrownEntityHandle")] 		public EntityHandle ThrownEntityHandle { get; set;}

		[RED("isThrowingItemWithAim")] 		public CBool IsThrowingItemWithAim { get; set;}

		[RED("isThrowingItem")] 		public CBool IsThrowingItem { get; set;}

		[RED("isThrowHoldPressed")] 		public CBool IsThrowHoldPressed { get; set;}

		[RED("isAimingCrossbow")] 		public CBool IsAimingCrossbow { get; set;}

		[RED("playerAiming")] 		public CHandle<PlayerAiming> PlayerAiming { get; set;}

		[RED("forceDismember")] 		public CBool ForceDismember { get; set;}

		[RED("forceDismemberName")] 		public CName ForceDismemberName { get; set;}

		[RED("forceDismemberChance")] 		public CInt32 ForceDismemberChance { get; set;}

		[RED("forceDismemberExplosion")] 		public CBool ForceDismemberExplosion { get; set;}

		[RED("finisherVictim")] 		public CHandle<CActor> FinisherVictim { get; set;}

		[RED("forceFinisher")] 		public CBool ForceFinisher { get; set;}

		[RED("forceFinisherAnimName")] 		public CName ForceFinisherAnimName { get; set;}

		[RED("forceFinisherChance")] 		public CInt32 ForceFinisherChance { get; set;}

		[RED("forcedStance")] 		public CBool ForcedStance { get; set;}

		[RED("m_WeaponFXCollisionGroupNames", 2,0)] 		public CArray<CName> M_WeaponFXCollisionGroupNames { get; set;}

		[RED("m_CollisionEffect")] 		public CHandle<CEntity> M_CollisionEffect { get; set;}

		[RED("m_LastWeaponTipPos")] 		public Vector M_LastWeaponTipPos { get; set;}

		[RED("m_CollisionFxTemplate")] 		public CHandle<CEntityTemplate> M_CollisionFxTemplate { get; set;}

		[RED("m_RefreshWeaponFXType")] 		public CBool M_RefreshWeaponFXType { get; set;}

		[RED("m_PlayWoodenFX")] 		public CBool M_PlayWoodenFX { get; set;}

		[RED("m_activePoster")] 		public CHandle<W3Poster> M_activePoster { get; set;}

		[RED("horseOnNavMesh")] 		public CBool HorseOnNavMesh { get; set;}

		[RED("testAdjustRequestedMovementDirection")] 		public CBool TestAdjustRequestedMovementDirection { get; set;}

		[RED("targeting")] 		public CHandle<CR4PlayerTargeting> Targeting { get; set;}

		[RED("targetingPrecalcs")] 		public SR4PlayerTargetingPrecalcs TargetingPrecalcs { get; set;}

		[RED("targetingIn")] 		public SR4PlayerTargetingIn TargetingIn { get; set;}

		[RED("targetingOut")] 		public SR4PlayerTargetingOut TargetingOut { get; set;}

		[RED("useNativeTargeting")] 		public CBool UseNativeTargeting { get; set;}

		[RED("visibleActors", 2,0)] 		public CArray<CHandle<CActor>> VisibleActors { get; set;}

		[RED("visibleActorsTime", 2,0)] 		public CArray<CFloat> VisibleActorsTime { get; set;}

		[RED("parryTarget")] 		public CHandle<CActor> ParryTarget { get; set;}

		[RED("ragdollTarget")] 		public CHandle<CActor> RagdollTarget { get; set;}

		[RED("playerActionEventListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventListeners { get; set;}

		[RED("playerActionEventBlockingListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventBlockingListeners { get; set;}

		[RED("playerActionSlotAnimName")] 		public CName PlayerActionSlotAnimName { get; set;}

		[RED("isHoldingDeadlySword")] 		public CBool IsHoldingDeadlySword { get; set;}

		[RED("reevaluateCurrentWeapon")] 		public CBool ReevaluateCurrentWeapon { get; set;}

		[RED("disableActionBlend")] 		public CBool DisableActionBlend { get; set;}

		[RED("slideNPC")] 		public CHandle<CNewNPC> SlideNPC { get; set;}

		[RED("minSlideDistance")] 		public CFloat MinSlideDistance { get; set;}

		[RED("maxSlideDistance")] 		public CFloat MaxSlideDistance { get; set;}

		[RED("slideTicket")] 		public SMovementAdjustmentRequestTicket SlideTicket { get; set;}

		[RED("gwintCardNumbersArray", 2,0)] 		public CArray<CInt32> GwintCardNumbersArray { get; set;}

		[RED("customCameraStack", 2,0)] 		public CArray<SCustomCameraParams> CustomCameraStack { get; set;}

		[RED("questCameraRequest")] 		public SQuestCameraRequest QuestCameraRequest { get; set;}

		[RED("cameraRequestTimeStamp")] 		public CFloat CameraRequestTimeStamp { get; set;}

		[RED("wasRunning")] 		public CBool WasRunning { get; set;}

		[RED("vel")] 		public CFloat Vel { get; set;}

		[RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		[RED("constDamper")] 		public CHandle<ConstDamper> ConstDamper { get; set;}

		[RED("rotMultVel")] 		public CFloat RotMultVel { get; set;}

		[RED("wasBRAxisPushed")] 		public CBool WasBRAxisPushed { get; set;}

		[RED("fovVel")] 		public CFloat FovVel { get; set;}

		[RED("sprintOffset")] 		public Vector SprintOffset { get; set;}

		[RED("previousOffset")] 		public CBool PreviousOffset { get; set;}

		[RED("previousRotationVelocity")] 		public CFloat PreviousRotationVelocity { get; set;}

		[RED("pivotRotationTimeStamp")] 		public CFloat PivotRotationTimeStamp { get; set;}

		[RED("disableManualCameraControlStack", 2,0)] 		public CArray<CName> DisableManualCameraControlStack { get; set;}

		[RED("customOrientationInfoStack", 2,0)] 		public CArray<SCustomOrientationInfo> CustomOrientationInfoStack { get; set;}

		[RED("isSnappedToNavMesh")] 		public CBool IsSnappedToNavMesh { get; set;}

		[RED("snapToNavMeshCachedFlag")] 		public CBool SnapToNavMeshCachedFlag { get; set;}

		[RED("navMeshSnapInfoStack", 2,0)] 		public CArray<CName> NavMeshSnapInfoStack { get; set;}

		[RED("beingWarnedBy", 2,0)] 		public CArray<CHandle<CActor>> BeingWarnedBy { get; set;}

		[RED("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[RED("hostileMonsters", 2,0)] 		public CArray<CHandle<CActor>> HostileMonsters { get; set;}

		[RED("canFindPathEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> CanFindPathEnemiesList { get; set;}

		[RED("disablecanFindPathEnemiesListUpdate")] 		public CBool DisablecanFindPathEnemiesListUpdate { get; set;}

		[RED("lastCanFindPathEnemy")] 		public CHandle<CActor> LastCanFindPathEnemy { get; set;}

		[RED("cachedMoveTarget")] 		public CHandle<CActor> CachedMoveTarget { get; set;}

		[RED("reachabilityTestId")] 		public CInt32 ReachabilityTestId { get; set;}

		[RED("reachabilityTestId2")] 		public CInt32 ReachabilityTestId2 { get; set;}

		[RED("finishableEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemiesList { get; set;}

		[RED("hostileEnemyToRemove")] 		public CHandle<CActor> HostileEnemyToRemove { get; set;}

		[RED("moveTargets", 2,0)] 		public CArray<CHandle<CActor>> MoveTargets { get; set;}

		[RED("enableStrafe")] 		public CBool EnableStrafe { get; set;}

		[RED("isInCombatReason")] 		public CInt32 IsInCombatReason { get; set;}

		[RED("canFindPathToEnemy")] 		public CBool CanFindPathToEnemy { get; set;}

		[RED("combatModeEnt")] 		public CHandle<CEntity> CombatModeEnt { get; set;}

		[RED("navDist")] 		public CFloat NavDist { get; set;}

		[RED("directDist")] 		public CFloat DirectDist { get; set;}

		[RED("reachableEnemyWasTooFar")] 		public CBool ReachableEnemyWasTooFar { get; set;}

		[RED("reachableEnemyWasTooFarTimeStamp")] 		public CFloat ReachableEnemyWasTooFarTimeStamp { get; set;}

		[RED("reachablilityFailed")] 		public CBool ReachablilityFailed { get; set;}

		[RED("reachablilityFailedTimeStamp")] 		public CFloat ReachablilityFailedTimeStamp { get; set;}

		[RED("isThreatened")] 		public CBool IsThreatened { get; set;}

		[RED("bConfirmDisplayTargetTimerEnabled")] 		public CBool BConfirmDisplayTargetTimerEnabled { get; set;}

		[RED("displayTargetToConfirm")] 		public CHandle<CGameplayEntity> DisplayTargetToConfirm { get; set;}

		[RED("currentSelectedDisplayTarget")] 		public CHandle<CGameplayEntity> CurrentSelectedDisplayTarget { get; set;}

		[RED("isDisplayTargetTargetable")] 		public CBool IsDisplayTargetTargetable { get; set;}

		[RED("radialSlots", 2,0)] 		public CArray<CName> RadialSlots { get; set;}

		[RED("combatModeColor")] 		public CColor CombatModeColor { get; set;}

		[RED("confirmCombatStanceTimeStamp")] 		public CFloat ConfirmCombatStanceTimeStamp { get; set;}

		[RED("isConfirmingCombatStance")] 		public CBool IsConfirmingCombatStance { get; set;}

		[RED("isInHolsterAnim")] 		public CBool IsInHolsterAnim { get; set;}

		[RED("dodgeTimerRunning")] 		public CBool DodgeTimerRunning { get; set;}

		[RED("forceCanAttackWhenNotInCombat")] 		public CInt32 ForceCanAttackWhenNotInCombat { get; set;}

		[RED("countDownToStart")] 		public CInt32 CountDownToStart { get; set;}

		[RED("inWaterTrigger")] 		public CBool InWaterTrigger { get; set;}

		[RED("isRotatingInPlace")] 		public CBool IsRotatingInPlace { get; set;}

		[RED("isInIdle")] 		public CBool IsInIdle { get; set;}

		[RED("isInGuardedState")] 		public CBool IsInGuardedState { get; set;}

		[RED("restoreUsableItem")] 		public CBool RestoreUsableItem { get; set;}

		[RED("holsterUsableItem")] 		public CBool HolsterUsableItem { get; set;}

		[RED("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[RED("finisherSaveLock")] 		public CInt32 FinisherSaveLock { get; set;}

		[RED("currentlyUsingItem")] 		public CBool CurrentlyUsingItem { get; set;}

		[RED("MOUNT_DISTANCE_CBT")] 		public CFloat MOUNT_DISTANCE_CBT { get; set;}

		[RED("MOUNT_ANGLE_CBT")] 		public CFloat MOUNT_ANGLE_CBT { get; set;}

		[RED("MOUNT_ANGLE_EXP")] 		public CFloat MOUNT_ANGLE_EXP { get; set;}

		[RED("m_bossTag")] 		public CName M_bossTag { get; set;}

		[RED("m_usingCoatOfArms")] 		public CBool M_usingCoatOfArms { get; set;}

		[RED("m_initialTimeOut")] 		public CFloat M_initialTimeOut { get; set;}

		[RED("m_currentTimeOut")] 		public CFloat M_currentTimeOut { get; set;}

		[RED("loopingCameraShakeAnimName")] 		public CName LoopingCameraShakeAnimName { get; set;}

		[RED("forcedFinisherVictim")] 		public CHandle<CActor> ForcedFinisherVictim { get; set;}

		public CR4Player(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Player(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}