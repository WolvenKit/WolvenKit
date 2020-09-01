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
		[Ordinal(0)] [RED("uselessProp")] 		public CEnum<EAsyncCheckResult> UselessProp { get; set;}

		[Ordinal(0)] [RED("horseWithInventory")] 		public EntityHandle HorseWithInventory { get; set;}

		[Ordinal(0)] [RED("pcGamePlayInitialized")] 		public CBool PcGamePlayInitialized { get; set;}

		[Ordinal(0)] [RED("pcMode")] 		public CBool PcMode { get; set;}

		[Ordinal(0)] [RED("weaponHolster")] 		public CHandle<WeaponHolster> WeaponHolster { get; set;}

		[Ordinal(0)] [RED("rangedWeapon")] 		public CHandle<Crossbow> RangedWeapon { get; set;}

		[Ordinal(0)] [RED("crossbowDontPopStateHack")] 		public CBool CrossbowDontPopStateHack { get; set;}

		[Ordinal(0)] [RED("hitReactTransScale")] 		public CFloat HitReactTransScale { get; set;}

		[Ordinal(0)] [RED("bIsCombatActionAllowed")] 		public CBool BIsCombatActionAllowed { get; set;}

		[Ordinal(0)] [RED("currentCombatAction")] 		public CEnum<EBufferActionType> CurrentCombatAction { get; set;}

		[Ordinal(0)] [RED("uninterruptedHitsCount")] 		public CInt32 UninterruptedHitsCount { get; set;}

		[Ordinal(0)] [RED("uninterruptedHitsCameraStarted")] 		public CBool UninterruptedHitsCameraStarted { get; set;}

		[Ordinal(0)] [RED("uninterruptedHitsCurrentCameraEffect")] 		public CName UninterruptedHitsCurrentCameraEffect { get; set;}

		[Ordinal(0)] [RED("counterTimestamps", 2,0)] 		public CArray<EngineTime> CounterTimestamps { get; set;}

		[Ordinal(0)] [RED("hitReactionEffect")] 		public CBool HitReactionEffect { get; set;}

		[Ordinal(0)] [RED("lookAtPosition")] 		public Vector LookAtPosition { get; set;}

		[Ordinal(0)] [RED("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[Ordinal(0)] [RED("customOrientationTarget")] 		public CEnum<EOrientationTarget> CustomOrientationTarget { get; set;}

		[Ordinal(0)] [RED("customOrientationStack", 2,0)] 		public CArray<SCustomOrientationParams> CustomOrientationStack { get; set;}

		[Ordinal(0)] [RED("delayOrientationChange")] 		public CBool DelayOrientationChange { get; set;}

		[Ordinal(0)] [RED("delayCameraOrientationChange")] 		public CBool DelayCameraOrientationChange { get; set;}

		[Ordinal(0)] [RED("actionType")] 		public CInt32 ActionType { get; set;}

		[Ordinal(0)] [RED("customOrientationStackIndex")] 		public CInt32 CustomOrientationStackIndex { get; set;}

		[Ordinal(0)] [RED("emptyMoveTargetTimer")] 		public CFloat EmptyMoveTargetTimer { get; set;}

		[Ordinal(0)] [RED("onlyOneEnemyLeft")] 		public CBool OnlyOneEnemyLeft { get; set;}

		[Ordinal(0)] [RED("isInFinisher")] 		public CBool IsInFinisher { get; set;}

		[Ordinal(0)] [RED("finisherTarget")] 		public CHandle<CGameplayEntity> FinisherTarget { get; set;}

		[Ordinal(0)] [RED("combatStance")] 		public CEnum<EPlayerCombatStance> CombatStance { get; set;}

		[Ordinal(0)] [RED("approachAttack")] 		public CInt32 ApproachAttack { get; set;}

		[Ordinal(0)] [RED("specialAttackCamera")] 		public CBool SpecialAttackCamera { get; set;}

		[Ordinal(0)] [RED("specialAttackTimeRatio")] 		public CFloat SpecialAttackTimeRatio { get; set;}

		[Ordinal(0)] [RED("itemsPerLevel", 2,0)] 		public CArray<CName> ItemsPerLevel { get; set;}

		[Ordinal(0)] [RED("itemsPerLevelGiven", 2,0)] 		public CArray<CBool> ItemsPerLevelGiven { get; set;}

		[Ordinal(0)] [RED("playerTickTimerPhase")] 		public CInt32 PlayerTickTimerPhase { get; set;}

		[Ordinal(0)] [RED("evadeHeading")] 		public CFloat EvadeHeading { get; set;}

		[Ordinal(0)] [RED("vehicleCbtMgrAiming")] 		public CBool VehicleCbtMgrAiming { get; set;}

		[Ordinal(0)] [RED("specialHeavyChargeDuration")] 		public CFloat SpecialHeavyChargeDuration { get; set;}

		[Ordinal(0)] [RED("specialHeavyStartEngineTime")] 		public EngineTime SpecialHeavyStartEngineTime { get; set;}

		[Ordinal(0)] [RED("playedSpecialAttackMissingResourceSound")] 		public CBool PlayedSpecialAttackMissingResourceSound { get; set;}

		[Ordinal(0)] [RED("counterCollisionGroupNames", 2,0)] 		public CArray<CName> CounterCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("lastInstantKillTime")] 		public GameTime LastInstantKillTime { get; set;}

		[Ordinal(0)] [RED("noSaveLockCombatActionName")] 		public CString NoSaveLockCombatActionName { get; set;}

		[Ordinal(0)] [RED("noSaveLockCombatAction")] 		public CInt32 NoSaveLockCombatAction { get; set;}

		[Ordinal(0)] [RED("deathNoSaveLock")] 		public CInt32 DeathNoSaveLock { get; set;}

		[Ordinal(0)] [RED("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[Ordinal(0)] [RED("newGamePlusInitialized")] 		public CBool NewGamePlusInitialized { get; set;}

		[Ordinal(0)] [RED("BufferAllSteps")] 		public CBool BufferAllSteps { get; set;}

		[Ordinal(0)] [RED("BufferCombatAction")] 		public CEnum<EBufferActionType> BufferCombatAction { get; set;}

		[Ordinal(0)] [RED("BufferButtonStage")] 		public CEnum<EButtonStage> BufferButtonStage { get; set;}

		[Ordinal(0)] [RED("keepRequestingCriticalAnimStart")] 		public CBool KeepRequestingCriticalAnimStart { get; set;}

		[Ordinal(0)] [RED("currentCustomAction")] 		public CEnum<EPlayerExplorationAction> CurrentCustomAction { get; set;}

		[Ordinal(0)] [RED("substateManager")] 		public CHandle<CExplorationStateManager> SubstateManager { get; set;}

		[Ordinal(0)] [RED("isOnBoat")] 		public CBool IsOnBoat { get; set;}

		[Ordinal(0)] [RED("isInShallowWater")] 		public CBool IsInShallowWater { get; set;}

		[Ordinal(0)] [RED("medallion")] 		public CHandle<W3MedallionFX> Medallion { get; set;}

		[Ordinal(0)] [RED("lastMedallionEffect")] 		public CFloat LastMedallionEffect { get; set;}

		[Ordinal(0)] [RED("isInRunAnimation")] 		public CBool IsInRunAnimation { get; set;}

		[Ordinal(0)] [RED("interiorTracker")] 		public CHandle<CPlayerInteriorTracker> InteriorTracker { get; set;}

		[Ordinal(0)] [RED("m_SettlementBlockCanter")] 		public CInt32 M_SettlementBlockCanter { get; set;}

		[Ordinal(0)] [RED("fistFightMinigameEnabled")] 		public CBool FistFightMinigameEnabled { get; set;}

		[Ordinal(0)] [RED("isFFMinigameToTheDeath")] 		public CBool IsFFMinigameToTheDeath { get; set;}

		[Ordinal(0)] [RED("FFMinigameEndsithBS")] 		public CBool FFMinigameEndsithBS { get; set;}

		[Ordinal(0)] [RED("fistFightTeleportNode")] 		public CHandle<CNode> FistFightTeleportNode { get; set;}

		[Ordinal(0)] [RED("isStartingFistFightMinigame")] 		public CBool IsStartingFistFightMinigame { get; set;}

		[Ordinal(0)] [RED("GeraltMaxHealth")] 		public CFloat GeraltMaxHealth { get; set;}

		[Ordinal(0)] [RED("fistsItems", 2,0)] 		public CArray<SItemUniqueId> FistsItems { get; set;}

		[Ordinal(0)] [RED("gwintAiDifficulty")] 		public CEnum<EGwintDifficultyMode> GwintAiDifficulty { get; set;}

		[Ordinal(0)] [RED("gwintAiAggression")] 		public CEnum<EGwintAggressionMode> GwintAiAggression { get; set;}

		[Ordinal(0)] [RED("gwintMinigameState")] 		public CEnum<EMinigameState> GwintMinigameState { get; set;}

		[Ordinal(0)] [RED("currentlyMountedHorse")] 		public CHandle<CNewNPC> CurrentlyMountedHorse { get; set;}

		[Ordinal(0)] [RED("horseSummonTimeStamp")] 		public CFloat HorseSummonTimeStamp { get; set;}

		[Ordinal(0)] [RED("isHorseRacing")] 		public CBool IsHorseRacing { get; set;}

		[Ordinal(0)] [RED("horseCombatSlowMo")] 		public CBool HorseCombatSlowMo { get; set;}

		[Ordinal(0)] [RED("HudMessages", 2,0)] 		public CArray<CString> HudMessages { get; set;}

		[Ordinal(0)] [RED("fShowToLowStaminaIndication")] 		public CFloat FShowToLowStaminaIndication { get; set;}

		[Ordinal(0)] [RED("showTooLowAdrenaline")] 		public CBool ShowTooLowAdrenaline { get; set;}

		[Ordinal(0)] [RED("HAXE3Container")] 		public CHandle<W3Container> HAXE3Container { get; set;}

		[Ordinal(0)] [RED("HAXE3bAutoLoot")] 		public CBool HAXE3bAutoLoot { get; set;}

		[Ordinal(0)] [RED("bShowHud")] 		public CBool BShowHud { get; set;}

		[Ordinal(0)] [RED("dodgeFeedbackTarget")] 		public CHandle<CActor> DodgeFeedbackTarget { get; set;}

		[Ordinal(0)] [RED("displayedQuestsGUID", 2,0)] 		public CArray<CGUID> DisplayedQuestsGUID { get; set;}

		[Ordinal(0)] [RED("rewardsMultiplier", 2,0)] 		public CArray<SRewardMultiplier> RewardsMultiplier { get; set;}

		[Ordinal(0)] [RED("glossaryImageOverride", 2,0)] 		public CArray<SGlossaryImageOverride> GlossaryImageOverride { get; set;}

		[Ordinal(0)] [RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[Ordinal(0)] [RED("explorationInputContext")] 		public CName ExplorationInputContext { get; set;}

		[Ordinal(0)] [RED("combatInputContext")] 		public CName CombatInputContext { get; set;}

		[Ordinal(0)] [RED("combatFistsInputContext")] 		public CName CombatFistsInputContext { get; set;}

		[Ordinal(0)] [RED("isInsideInteraction")] 		public CBool IsInsideInteraction { get; set;}

		[Ordinal(0)] [RED("isInsideHorseInteraction")] 		public CBool IsInsideHorseInteraction { get; set;}

		[Ordinal(0)] [RED("horseInteractionSource")] 		public CHandle<CEntity> HorseInteractionSource { get; set;}

		[Ordinal(0)] [RED("nearbyLockedContainersNoKey", 2,0)] 		public CArray<CHandle<W3LockableEntity>> NearbyLockedContainersNoKey { get; set;}

		[Ordinal(0)] [RED("bMoveTargetChangeAllowed")] 		public CBool BMoveTargetChangeAllowed { get; set;}

		[Ordinal(0)] [RED("moveAdj")] 		public CHandle<CMovementAdjustor> MoveAdj { get; set;}

		[Ordinal(0)] [RED("defaultLocomotionController")] 		public CHandle<CR4LocomotionPlayerControllerScript> DefaultLocomotionController { get; set;}

		[Ordinal(0)] [RED("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[Ordinal(0)] [RED("actorToFollow")] 		public CHandle<CActor> ActorToFollow { get; set;}

		[Ordinal(0)] [RED("terrainPitch")] 		public CFloat TerrainPitch { get; set;}

		[Ordinal(0)] [RED("steepSlopeNormalPitch")] 		public CFloat SteepSlopeNormalPitch { get; set;}

		[Ordinal(0)] [RED("disableSprintTerrainPitch")] 		public CFloat DisableSprintTerrainPitch { get; set;}

		[Ordinal(0)] [RED("submergeDepth")] 		public CFloat SubmergeDepth { get; set;}

		[Ordinal(0)] [RED("m_useSelectedItemIfSpawned")] 		public CBool M_useSelectedItemIfSpawned { get; set;}

		[Ordinal(0)] [RED("navQuery")] 		public CHandle<CNavigationReachabilityQueryInterface> NavQuery { get; set;}

		[Ordinal(0)] [RED("rememberedCustomHead")] 		public CName RememberedCustomHead { get; set;}

		[Ordinal(0)] [RED("disableWeatherDisplay")] 		public CBool DisableWeatherDisplay { get; set;}

		[Ordinal(0)] [RED("proudWalk")] 		public CBool ProudWalk { get; set;}

		[Ordinal(0)] [RED("etherealCount")] 		public CInt32 EtherealCount { get; set;}

		[Ordinal(0)] [RED("injuredWalk")] 		public CBool InjuredWalk { get; set;}

		[Ordinal(0)] [RED("tiedWalk")] 		public CBool TiedWalk { get; set;}

		[Ordinal(0)] [RED("insideDiveAttackArea")] 		public CBool InsideDiveAttackArea { get; set;}

		[Ordinal(0)] [RED("diveAreaNumber")] 		public CInt32 DiveAreaNumber { get; set;}

		[Ordinal(0)] [RED("flyingBossCamera")] 		public CBool FlyingBossCamera { get; set;}

		[Ordinal(0)] [RED("upscaledTooltipState")] 		public CBool UpscaledTooltipState { get; set;}

		[Ordinal(0)] [RED("phantomWeaponMgr")] 		public CHandle<CPhantomWeaponManager> PhantomWeaponMgr { get; set;}

		[Ordinal(0)] [RED("delayBetweenIllusionOneliners")] 		public CFloat DelayBetweenIllusionOneliners { get; set;}

		[Ordinal(0)] [RED("battlecry_timeForNext")] 		public CFloat Battlecry_timeForNext { get; set;}

		[Ordinal(0)] [RED("battlecry_delayMin")] 		public CFloat Battlecry_delayMin { get; set;}

		[Ordinal(0)] [RED("battlecry_delayMax")] 		public CFloat Battlecry_delayMax { get; set;}

		[Ordinal(0)] [RED("battlecry_lastTry")] 		public CName Battlecry_lastTry { get; set;}

		[Ordinal(0)] [RED("previousWeather")] 		public CName PreviousWeather { get; set;}

		[Ordinal(0)] [RED("previousRainStrength")] 		public CFloat PreviousRainStrength { get; set;}

		[Ordinal(0)] [RED("receivedDamageInCombat")] 		public CBool ReceivedDamageInCombat { get; set;}

		[Ordinal(0)] [RED("prevDayNightIsNight")] 		public CBool PrevDayNightIsNight { get; set;}

		[Ordinal(0)] [RED("failedFundamentalsFirstAchievementCondition")] 		public CBool FailedFundamentalsFirstAchievementCondition { get; set;}

		[Ordinal(0)] [RED("spawnedTime")] 		public CFloat SpawnedTime { get; set;}

		[Ordinal(0)] [RED("currentMonsterHuntInvestigationArea")] 		public CHandle<W3MonsterHuntInvestigationArea> CurrentMonsterHuntInvestigationArea { get; set;}

		[Ordinal(0)] [RED("isPerformingPhaseChangeAnimation")] 		public CBool IsPerformingPhaseChangeAnimation { get; set;}

		[Ordinal(0)] [RED("playerMode")] 		public CHandle<W3PlayerMode> PlayerMode { get; set;}

		[Ordinal(0)] [RED("selectedItemId")] 		public SItemUniqueId SelectedItemId { get; set;}

		[Ordinal(0)] [RED("blockedRadialSlots", 2,0)] 		public CArray<SRadialSlotDef> BlockedRadialSlots { get; set;}

		[Ordinal(0)] [RED("enemyCollectionDist")] 		public CFloat EnemyCollectionDist { get; set;}

		[Ordinal(0)] [RED("findMoveTargetDistMin")] 		public CFloat FindMoveTargetDistMin { get; set;}

		[Ordinal(0)] [RED("findMoveTargetDistMax")] 		public CFloat FindMoveTargetDistMax { get; set;}

		[Ordinal(0)] [RED("findMoveTargetScaledFrame")] 		public CFloat FindMoveTargetScaledFrame { get; set;}

		[Ordinal(0)] [RED("interactDist")] 		public CFloat InteractDist { get; set;}

		[Ordinal(0)] [RED("bCanFindTarget")] 		public CBool BCanFindTarget { get; set;}

		[Ordinal(0)] [RED("bIsConfirmingEmptyTarget")] 		public CBool BIsConfirmingEmptyTarget { get; set;}

		[Ordinal(0)] [RED("displayTarget")] 		public CHandle<CGameplayEntity> DisplayTarget { get; set;}

		[Ordinal(0)] [RED("isShootingFriendly")] 		public CBool IsShootingFriendly { get; set;}

		[Ordinal(0)] [RED("currentSelectedTarget")] 		public CHandle<CActor> CurrentSelectedTarget { get; set;}

		[Ordinal(0)] [RED("selectedTargetToConfirm")] 		public CHandle<CActor> SelectedTargetToConfirm { get; set;}

		[Ordinal(0)] [RED("bConfirmTargetTimerIsEnabled")] 		public CBool BConfirmTargetTimerIsEnabled { get; set;}

		[Ordinal(0)] [RED("thrownEntityHandle")] 		public EntityHandle ThrownEntityHandle { get; set;}

		[Ordinal(0)] [RED("isThrowingItemWithAim")] 		public CBool IsThrowingItemWithAim { get; set;}

		[Ordinal(0)] [RED("isThrowingItem")] 		public CBool IsThrowingItem { get; set;}

		[Ordinal(0)] [RED("isThrowHoldPressed")] 		public CBool IsThrowHoldPressed { get; set;}

		[Ordinal(0)] [RED("isAimingCrossbow")] 		public CBool IsAimingCrossbow { get; set;}

		[Ordinal(0)] [RED("playerAiming")] 		public CHandle<PlayerAiming> PlayerAiming { get; set;}

		[Ordinal(0)] [RED("forceDismember")] 		public CBool ForceDismember { get; set;}

		[Ordinal(0)] [RED("forceDismemberName")] 		public CName ForceDismemberName { get; set;}

		[Ordinal(0)] [RED("forceDismemberChance")] 		public CInt32 ForceDismemberChance { get; set;}

		[Ordinal(0)] [RED("forceDismemberExplosion")] 		public CBool ForceDismemberExplosion { get; set;}

		[Ordinal(0)] [RED("finisherVictim")] 		public CHandle<CActor> FinisherVictim { get; set;}

		[Ordinal(0)] [RED("forceFinisher")] 		public CBool ForceFinisher { get; set;}

		[Ordinal(0)] [RED("forceFinisherAnimName")] 		public CName ForceFinisherAnimName { get; set;}

		[Ordinal(0)] [RED("forceFinisherChance")] 		public CInt32 ForceFinisherChance { get; set;}

		[Ordinal(0)] [RED("forcedStance")] 		public CBool ForcedStance { get; set;}

		[Ordinal(0)] [RED("m_WeaponFXCollisionGroupNames", 2,0)] 		public CArray<CName> M_WeaponFXCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("m_CollisionEffect")] 		public CHandle<CEntity> M_CollisionEffect { get; set;}

		[Ordinal(0)] [RED("m_LastWeaponTipPos")] 		public Vector M_LastWeaponTipPos { get; set;}

		[Ordinal(0)] [RED("m_CollisionFxTemplate")] 		public CHandle<CEntityTemplate> M_CollisionFxTemplate { get; set;}

		[Ordinal(0)] [RED("m_RefreshWeaponFXType")] 		public CBool M_RefreshWeaponFXType { get; set;}

		[Ordinal(0)] [RED("m_PlayWoodenFX")] 		public CBool M_PlayWoodenFX { get; set;}

		[Ordinal(0)] [RED("m_activePoster")] 		public CHandle<W3Poster> M_activePoster { get; set;}

		[Ordinal(0)] [RED("horseOnNavMesh")] 		public CBool HorseOnNavMesh { get; set;}

		[Ordinal(0)] [RED("testAdjustRequestedMovementDirection")] 		public CBool TestAdjustRequestedMovementDirection { get; set;}

		[Ordinal(0)] [RED("targeting")] 		public CHandle<CR4PlayerTargeting> Targeting { get; set;}

		[Ordinal(0)] [RED("targetingPrecalcs")] 		public SR4PlayerTargetingPrecalcs TargetingPrecalcs { get; set;}

		[Ordinal(0)] [RED("targetingIn")] 		public SR4PlayerTargetingIn TargetingIn { get; set;}

		[Ordinal(0)] [RED("targetingOut")] 		public SR4PlayerTargetingOut TargetingOut { get; set;}

		[Ordinal(0)] [RED("useNativeTargeting")] 		public CBool UseNativeTargeting { get; set;}

		[Ordinal(0)] [RED("visibleActors", 2,0)] 		public CArray<CHandle<CActor>> VisibleActors { get; set;}

		[Ordinal(0)] [RED("visibleActorsTime", 2,0)] 		public CArray<CFloat> VisibleActorsTime { get; set;}

		[Ordinal(0)] [RED("parryTarget")] 		public CHandle<CActor> ParryTarget { get; set;}

		[Ordinal(0)] [RED("ragdollTarget")] 		public CHandle<CActor> RagdollTarget { get; set;}

		[Ordinal(0)] [RED("playerActionEventListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventListeners { get; set;}

		[Ordinal(0)] [RED("playerActionEventBlockingListeners", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PlayerActionEventBlockingListeners { get; set;}

		[Ordinal(0)] [RED("playerActionSlotAnimName")] 		public CName PlayerActionSlotAnimName { get; set;}

		[Ordinal(0)] [RED("isHoldingDeadlySword")] 		public CBool IsHoldingDeadlySword { get; set;}

		[Ordinal(0)] [RED("reevaluateCurrentWeapon")] 		public CBool ReevaluateCurrentWeapon { get; set;}

		[Ordinal(0)] [RED("disableActionBlend")] 		public CBool DisableActionBlend { get; set;}

		[Ordinal(0)] [RED("slideNPC")] 		public CHandle<CNewNPC> SlideNPC { get; set;}

		[Ordinal(0)] [RED("minSlideDistance")] 		public CFloat MinSlideDistance { get; set;}

		[Ordinal(0)] [RED("maxSlideDistance")] 		public CFloat MaxSlideDistance { get; set;}

		[Ordinal(0)] [RED("slideTicket")] 		public SMovementAdjustmentRequestTicket SlideTicket { get; set;}

		[Ordinal(0)] [RED("gwintCardNumbersArray", 2,0)] 		public CArray<CInt32> GwintCardNumbersArray { get; set;}

		[Ordinal(0)] [RED("customCameraStack", 2,0)] 		public CArray<SCustomCameraParams> CustomCameraStack { get; set;}

		[Ordinal(0)] [RED("questCameraRequest")] 		public SQuestCameraRequest QuestCameraRequest { get; set;}

		[Ordinal(0)] [RED("cameraRequestTimeStamp")] 		public CFloat CameraRequestTimeStamp { get; set;}

		[Ordinal(0)] [RED("wasRunning")] 		public CBool WasRunning { get; set;}

		[Ordinal(0)] [RED("vel")] 		public CFloat Vel { get; set;}

		[Ordinal(0)] [RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		[Ordinal(0)] [RED("constDamper")] 		public CHandle<ConstDamper> ConstDamper { get; set;}

		[Ordinal(0)] [RED("rotMultVel")] 		public CFloat RotMultVel { get; set;}

		[Ordinal(0)] [RED("wasBRAxisPushed")] 		public CBool WasBRAxisPushed { get; set;}

		[Ordinal(0)] [RED("fovVel")] 		public CFloat FovVel { get; set;}

		[Ordinal(0)] [RED("sprintOffset")] 		public Vector SprintOffset { get; set;}

		[Ordinal(0)] [RED("previousOffset")] 		public CBool PreviousOffset { get; set;}

		[Ordinal(0)] [RED("previousRotationVelocity")] 		public CFloat PreviousRotationVelocity { get; set;}

		[Ordinal(0)] [RED("pivotRotationTimeStamp")] 		public CFloat PivotRotationTimeStamp { get; set;}

		[Ordinal(0)] [RED("disableManualCameraControlStack", 2,0)] 		public CArray<CName> DisableManualCameraControlStack { get; set;}

		[Ordinal(0)] [RED("customOrientationInfoStack", 2,0)] 		public CArray<SCustomOrientationInfo> CustomOrientationInfoStack { get; set;}

		[Ordinal(0)] [RED("isSnappedToNavMesh")] 		public CBool IsSnappedToNavMesh { get; set;}

		[Ordinal(0)] [RED("snapToNavMeshCachedFlag")] 		public CBool SnapToNavMeshCachedFlag { get; set;}

		[Ordinal(0)] [RED("navMeshSnapInfoStack", 2,0)] 		public CArray<CName> NavMeshSnapInfoStack { get; set;}

		[Ordinal(0)] [RED("beingWarnedBy", 2,0)] 		public CArray<CHandle<CActor>> BeingWarnedBy { get; set;}

		[Ordinal(0)] [RED("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[Ordinal(0)] [RED("hostileMonsters", 2,0)] 		public CArray<CHandle<CActor>> HostileMonsters { get; set;}

		[Ordinal(0)] [RED("canFindPathEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> CanFindPathEnemiesList { get; set;}

		[Ordinal(0)] [RED("disablecanFindPathEnemiesListUpdate")] 		public CBool DisablecanFindPathEnemiesListUpdate { get; set;}

		[Ordinal(0)] [RED("lastCanFindPathEnemy")] 		public CHandle<CActor> LastCanFindPathEnemy { get; set;}

		[Ordinal(0)] [RED("cachedMoveTarget")] 		public CHandle<CActor> CachedMoveTarget { get; set;}

		[Ordinal(0)] [RED("reachabilityTestId")] 		public CInt32 ReachabilityTestId { get; set;}

		[Ordinal(0)] [RED("reachabilityTestId2")] 		public CInt32 ReachabilityTestId2 { get; set;}

		[Ordinal(0)] [RED("finishableEnemiesList", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemiesList { get; set;}

		[Ordinal(0)] [RED("hostileEnemyToRemove")] 		public CHandle<CActor> HostileEnemyToRemove { get; set;}

		[Ordinal(0)] [RED("moveTargets", 2,0)] 		public CArray<CHandle<CActor>> MoveTargets { get; set;}

		[Ordinal(0)] [RED("enableStrafe")] 		public CBool EnableStrafe { get; set;}

		[Ordinal(0)] [RED("isInCombatReason")] 		public CInt32 IsInCombatReason { get; set;}

		[Ordinal(0)] [RED("canFindPathToEnemy")] 		public CBool CanFindPathToEnemy { get; set;}

		[Ordinal(0)] [RED("combatModeEnt")] 		public CHandle<CEntity> CombatModeEnt { get; set;}

		[Ordinal(0)] [RED("navDist")] 		public CFloat NavDist { get; set;}

		[Ordinal(0)] [RED("directDist")] 		public CFloat DirectDist { get; set;}

		[Ordinal(0)] [RED("reachableEnemyWasTooFar")] 		public CBool ReachableEnemyWasTooFar { get; set;}

		[Ordinal(0)] [RED("reachableEnemyWasTooFarTimeStamp")] 		public CFloat ReachableEnemyWasTooFarTimeStamp { get; set;}

		[Ordinal(0)] [RED("reachablilityFailed")] 		public CBool ReachablilityFailed { get; set;}

		[Ordinal(0)] [RED("reachablilityFailedTimeStamp")] 		public CFloat ReachablilityFailedTimeStamp { get; set;}

		[Ordinal(0)] [RED("isThreatened")] 		public CBool IsThreatened { get; set;}

		[Ordinal(0)] [RED("bConfirmDisplayTargetTimerEnabled")] 		public CBool BConfirmDisplayTargetTimerEnabled { get; set;}

		[Ordinal(0)] [RED("displayTargetToConfirm")] 		public CHandle<CGameplayEntity> DisplayTargetToConfirm { get; set;}

		[Ordinal(0)] [RED("currentSelectedDisplayTarget")] 		public CHandle<CGameplayEntity> CurrentSelectedDisplayTarget { get; set;}

		[Ordinal(0)] [RED("isDisplayTargetTargetable")] 		public CBool IsDisplayTargetTargetable { get; set;}

		[Ordinal(0)] [RED("radialSlots", 2,0)] 		public CArray<CName> RadialSlots { get; set;}

		[Ordinal(0)] [RED("combatModeColor")] 		public CColor CombatModeColor { get; set;}

		[Ordinal(0)] [RED("confirmCombatStanceTimeStamp")] 		public CFloat ConfirmCombatStanceTimeStamp { get; set;}

		[Ordinal(0)] [RED("isConfirmingCombatStance")] 		public CBool IsConfirmingCombatStance { get; set;}

		[Ordinal(0)] [RED("isInHolsterAnim")] 		public CBool IsInHolsterAnim { get; set;}

		[Ordinal(0)] [RED("dodgeTimerRunning")] 		public CBool DodgeTimerRunning { get; set;}

		[Ordinal(0)] [RED("forceCanAttackWhenNotInCombat")] 		public CInt32 ForceCanAttackWhenNotInCombat { get; set;}

		[Ordinal(0)] [RED("countDownToStart")] 		public CInt32 CountDownToStart { get; set;}

		[Ordinal(0)] [RED("inWaterTrigger")] 		public CBool InWaterTrigger { get; set;}

		[Ordinal(0)] [RED("isRotatingInPlace")] 		public CBool IsRotatingInPlace { get; set;}

		[Ordinal(0)] [RED("isInIdle")] 		public CBool IsInIdle { get; set;}

		[Ordinal(0)] [RED("isInGuardedState")] 		public CBool IsInGuardedState { get; set;}

		[Ordinal(0)] [RED("restoreUsableItem")] 		public CBool RestoreUsableItem { get; set;}

		[Ordinal(0)] [RED("holsterUsableItem")] 		public CBool HolsterUsableItem { get; set;}

		[Ordinal(0)] [RED("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[Ordinal(0)] [RED("finisherSaveLock")] 		public CInt32 FinisherSaveLock { get; set;}

		[Ordinal(0)] [RED("currentlyUsingItem")] 		public CBool CurrentlyUsingItem { get; set;}

		[Ordinal(0)] [RED("MOUNT_DISTANCE_CBT")] 		public CFloat MOUNT_DISTANCE_CBT { get; set;}

		[Ordinal(0)] [RED("MOUNT_ANGLE_CBT")] 		public CFloat MOUNT_ANGLE_CBT { get; set;}

		[Ordinal(0)] [RED("MOUNT_ANGLE_EXP")] 		public CFloat MOUNT_ANGLE_EXP { get; set;}

		[Ordinal(0)] [RED("m_bossTag")] 		public CName M_bossTag { get; set;}

		[Ordinal(0)] [RED("m_usingCoatOfArms")] 		public CBool M_usingCoatOfArms { get; set;}

		[Ordinal(0)] [RED("m_initialTimeOut")] 		public CFloat M_initialTimeOut { get; set;}

		[Ordinal(0)] [RED("m_currentTimeOut")] 		public CFloat M_currentTimeOut { get; set;}

		[Ordinal(0)] [RED("loopingCameraShakeAnimName")] 		public CName LoopingCameraShakeAnimName { get; set;}

		[Ordinal(0)] [RED("forcedFinisherVictim")] 		public CHandle<CActor> ForcedFinisherVictim { get; set;}

		public CR4Player(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Player(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}