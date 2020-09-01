using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayer : CActor
	{
		[Ordinal(1)] [RED("("npcVoicesetCooldown")] 		public CFloat NpcVoicesetCooldown { get; set;}

		[Ordinal(2)] [RED("("presenceInterestPoint")] 		public CPtr<CInterestPoint> PresenceInterestPoint { get; set;}

		[Ordinal(3)] [RED("("slowMovementInterestPoint")] 		public CPtr<CInterestPoint> SlowMovementInterestPoint { get; set;}

		[Ordinal(4)] [RED("("fastMovementInterestPoint")] 		public CPtr<CInterestPoint> FastMovementInterestPoint { get; set;}

		[Ordinal(5)] [RED("("weaponDrawnInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawnInterestPoint { get; set;}

		[Ordinal(6)] [RED("("weaponDrawMomentInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawMomentInterestPoint { get; set;}

		[Ordinal(7)] [RED("("visionInterestPoint")] 		public CPtr<CInterestPoint> VisionInterestPoint { get; set;}

		[Ordinal(8)] [RED("("isMovable")] 		public CBool IsMovable { get; set;}

		[Ordinal(9)] [RED("("enemyUpscaling")] 		public CBool EnemyUpscaling { get; set;}

		[Ordinal(10)] [RED("("_DEBUGDisplayRadiusMinimapIcons")] 		public CBool _DEBUGDisplayRadiusMinimapIcons { get; set;}

		[Ordinal(11)] [RED("("debug_BIsInputAllowedLocks", 2,0)] 		public CArray<CName> Debug_BIsInputAllowedLocks { get; set;}

		[Ordinal(12)] [RED("("ENTER_SWIMMING_WATER_LEVEL")] 		public CFloat ENTER_SWIMMING_WATER_LEVEL { get; set;}

		[Ordinal(13)] [RED("("useSprintingCameraAnim")] 		public CBool UseSprintingCameraAnim { get; set;}

		[Ordinal(14)] [RED("("oTCameraOffset")] 		public CFloat OTCameraOffset { get; set;}

		[Ordinal(15)] [RED("("oTCameraPitchOffset")] 		public CFloat OTCameraPitchOffset { get; set;}

		[Ordinal(16)] [RED("("bIsRollAllowed")] 		public CBool BIsRollAllowed { get; set;}

		[Ordinal(17)] [RED("("bIsInCombatAction")] 		public CBool BIsInCombatAction { get; set;}

		[Ordinal(18)] [RED("("bIsInCombatActionFriendly")] 		public CBool BIsInCombatActionFriendly { get; set;}

		[Ordinal(19)] [RED("("bIsInputAllowed")] 		public CBool BIsInputAllowed { get; set;}

		[Ordinal(20)] [RED("("bIsFirstAttackInCombo")] 		public CBool BIsFirstAttackInCombo { get; set;}

		[Ordinal(21)] [RED("("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[Ordinal(22)] [RED("("FarZoneDistMax")] 		public CFloat FarZoneDistMax { get; set;}

		[Ordinal(23)] [RED("("DangerZoneDistMax")] 		public CFloat DangerZoneDistMax { get; set;}

		[Ordinal(24)] [RED("("commentaryCooldown")] 		public CFloat CommentaryCooldown { get; set;}

		[Ordinal(25)] [RED("("commentaryLastTime")] 		public EngineTime CommentaryLastTime { get; set;}

		[Ordinal(26)] [RED("("canPlaySpecificVoiceset")] 		public CBool CanPlaySpecificVoiceset { get; set;}

		[Ordinal(27)] [RED("("isHorseMounted")] 		public CBool IsHorseMounted { get; set;}

		[Ordinal(28)] [RED("("isCompanionFollowing")] 		public CBool IsCompanionFollowing { get; set;}

		[Ordinal(29)] [RED("("bStartScreenIsOpened")] 		public CBool BStartScreenIsOpened { get; set;}

		[Ordinal(30)] [RED("("bEndScreenIsOpened")] 		public CBool BEndScreenIsOpened { get; set;}

		[Ordinal(31)] [RED("("fStartScreenFadeDuration")] 		public CFloat FStartScreenFadeDuration { get; set;}

		[Ordinal(32)] [RED("("bStartScreenEndWithBlackScreen")] 		public CBool BStartScreenEndWithBlackScreen { get; set;}

		[Ordinal(33)] [RED("("fStartScreenFadeInDuration")] 		public CFloat FStartScreenFadeInDuration { get; set;}

		[Ordinal(34)] [RED("("DEATH_SCREEN_OPEN_DELAY")] 		public CFloat DEATH_SCREEN_OPEN_DELAY { get; set;}

		[Ordinal(35)] [RED("("bLAxisReleased")] 		public CBool BLAxisReleased { get; set;}

		[Ordinal(36)] [RED("("bRAxisReleased")] 		public CBool BRAxisReleased { get; set;}

		[Ordinal(37)] [RED("("bUITakesInput")] 		public CBool BUITakesInput { get; set;}

		[Ordinal(38)] [RED("("inputHandler")] 		public CHandle<CPlayerInput> InputHandler { get; set;}

		[Ordinal(39)] [RED("("sprintActionPressed")] 		public CBool SprintActionPressed { get; set;}

		[Ordinal(40)] [RED("("inputModuleNeededToRun")] 		public CFloat InputModuleNeededToRun { get; set;}

		[Ordinal(41)] [RED("("bInteractionPressed")] 		public CBool BInteractionPressed { get; set;}

		[Ordinal(42)] [RED("("rawPlayerSpeed")] 		public CFloat RawPlayerSpeed { get; set;}

		[Ordinal(43)] [RED("("rawPlayerAngle")] 		public CFloat RawPlayerAngle { get; set;}

		[Ordinal(44)] [RED("("rawPlayerHeading")] 		public CFloat RawPlayerHeading { get; set;}

		[Ordinal(45)] [RED("("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[Ordinal(46)] [RED("("cachedCombatActionHeading")] 		public CFloat CachedCombatActionHeading { get; set;}

		[Ordinal(47)] [RED("("canResetCachedCombatActionHeading")] 		public CBool CanResetCachedCombatActionHeading { get; set;}

		[Ordinal(48)] [RED("("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[Ordinal(49)] [RED("("rawCameraHeading")] 		public CFloat RawCameraHeading { get; set;}

		[Ordinal(50)] [RED("("isSprinting")] 		public CBool IsSprinting { get; set;}

		[Ordinal(51)] [RED("("isRunning")] 		public CBool IsRunning { get; set;}

		[Ordinal(52)] [RED("("isWalking")] 		public CBool IsWalking { get; set;}

		[Ordinal(53)] [RED("("playerMoveType")] 		public CEnum<EPlayerMoveType> PlayerMoveType { get; set;}

		[Ordinal(54)] [RED("("sprintingTime")] 		public CFloat SprintingTime { get; set;}

		[Ordinal(55)] [RED("("walkToggle")] 		public CBool WalkToggle { get; set;}

		[Ordinal(56)] [RED("("sprintToggle")] 		public CBool SprintToggle { get; set;}

		[Ordinal(57)] [RED("("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[Ordinal(58)] [RED("("nonActorTarget")] 		public CHandle<CGameplayEntity> NonActorTarget { get; set;}

		[Ordinal(59)] [RED("("tempLookAtTarget")] 		public CHandle<CGameplayEntity> TempLookAtTarget { get; set;}

		[Ordinal(60)] [RED("("lockTargetSelectionHeading")] 		public CFloat LockTargetSelectionHeading { get; set;}

		[Ordinal(61)] [RED("("rawLeftJoyRot")] 		public CFloat RawLeftJoyRot { get; set;}

		[Ordinal(62)] [RED("("rawRightJoyRot")] 		public CFloat RawRightJoyRot { get; set;}

		[Ordinal(63)] [RED("("rawLeftJoyVec")] 		public Vector RawLeftJoyVec { get; set;}

		[Ordinal(64)] [RED("("rawRightJoyVec")] 		public Vector RawRightJoyVec { get; set;}

		[Ordinal(65)] [RED("("prevRawLeftJoyVec")] 		public Vector PrevRawLeftJoyVec { get; set;}

		[Ordinal(66)] [RED("("prevRawRightJoyVec")] 		public Vector PrevRawRightJoyVec { get; set;}

		[Ordinal(67)] [RED("("lastValidLeftJoyVec")] 		public Vector LastValidLeftJoyVec { get; set;}

		[Ordinal(68)] [RED("("lastValidRightJoyVec")] 		public Vector LastValidRightJoyVec { get; set;}

		[Ordinal(69)] [RED("("allowStopRunCheck")] 		public CBool AllowStopRunCheck { get; set;}

		[Ordinal(70)] [RED("("moveTargetDampValue")] 		public CFloat MoveTargetDampValue { get; set;}

		[Ordinal(71)] [RED("("interiorCamera")] 		public CBool InteriorCamera { get; set;}

		[Ordinal(72)] [RED("("movementLockType")] 		public CEnum<EPlayerMovementLockType> MovementLockType { get; set;}

		[Ordinal(73)] [RED("("scriptedCombatCamera")] 		public CBool ScriptedCombatCamera { get; set;}

		[Ordinal(74)] [RED("("modifyPlayerSpeed")] 		public CBool ModifyPlayerSpeed { get; set;}

		[Ordinal(75)] [RED("("autoCameraCenterToggle")] 		public CBool AutoCameraCenterToggle { get; set;}

		[Ordinal(76)] [RED("("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(77)] [RED("("equipmentSlotHistory", 2,0)] 		public CArray<SItemUniqueId> EquipmentSlotHistory { get; set;}

		[Ordinal(78)] [RED("("currentTrackedQuestSystemObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestSystemObjectives { get; set;}

		[Ordinal(79)] [RED("("currentTrackedQuestObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestObjectives { get; set;}

		[Ordinal(80)] [RED("("currentTrackedQuestGUID")] 		public CGUID CurrentTrackedQuestGUID { get; set;}

		[Ordinal(81)] [RED("("HAXNewObjTable", 2,0)] 		public CArray<CGUID> HAXNewObjTable { get; set;}

		[Ordinal(82)] [RED("("handAimPitch")] 		public CFloat HandAimPitch { get; set;}

		[Ordinal(83)] [RED("("vehicleCachedSign")] 		public CEnum<ESignType> VehicleCachedSign { get; set;}

		[Ordinal(84)] [RED("("softLockDist")] 		public CFloat SoftLockDist { get; set;}

		[Ordinal(85)] [RED("("softLockFrameSize")] 		public CFloat SoftLockFrameSize { get; set;}

		[Ordinal(86)] [RED("("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[Ordinal(87)] [RED("("softLockDistVehicle")] 		public CFloat SoftLockDistVehicle { get; set;}

		[Ordinal(88)] [RED("("bBIsLockedToTarget")] 		public CBool BBIsLockedToTarget { get; set;}

		[Ordinal(89)] [RED("("bActorIsLockedToTarget")] 		public CBool BActorIsLockedToTarget { get; set;}

		[Ordinal(90)] [RED("("bIsHardLockedTotarget")] 		public CBool BIsHardLockedTotarget { get; set;}

		[Ordinal(91)] [RED("("terrTypeOne")] 		public CEnum<ETerrainType> TerrTypeOne { get; set;}

		[Ordinal(92)] [RED("("terrTypeTwo")] 		public CEnum<ETerrainType> TerrTypeTwo { get; set;}

		[Ordinal(93)] [RED("("terrModifier")] 		public CFloat TerrModifier { get; set;}

		[Ordinal(94)] [RED("("prevTerrType")] 		public CEnum<ETerrainType> PrevTerrType { get; set;}

		[Ordinal(95)] [RED("("currentlyUsedItem")] 		public CHandle<W3UsableItem> CurrentlyUsedItem { get; set;}

		[Ordinal(96)] [RED("("currentlyEquipedItem")] 		public SItemUniqueId CurrentlyEquipedItem { get; set;}

		[Ordinal(97)] [RED("("currentlyUsedItemL")] 		public CHandle<W3UsableItem> CurrentlyUsedItemL { get; set;}

		[Ordinal(98)] [RED("("currentlyEquipedItemL")] 		public SItemUniqueId CurrentlyEquipedItemL { get; set;}

		[Ordinal(99)] [RED("("isUsableItemBlocked")] 		public CBool IsUsableItemBlocked { get; set;}

		[Ordinal(100)] [RED("("isUsableItemLtransitionAllowed")] 		public CBool IsUsableItemLtransitionAllowed { get; set;}

		[Ordinal(101)] [RED("("playerActionToRestore")] 		public CEnum<EPlayerActionToRestore> PlayerActionToRestore { get; set;}

		[Ordinal(102)] [RED("("teleportedOnBoatToOtherHUB")] 		public CBool TeleportedOnBoatToOtherHUB { get; set;}

		[Ordinal(103)] [RED("("isAdaptiveBalance")] 		public CBool IsAdaptiveBalance { get; set;}

		[Ordinal(104)] [RED("("modbootstrap")] 		public CHandle<CModBootstrap> Modbootstrap { get; set;}

		[Ordinal(105)] [RED("("inputHeadingReady")] 		public CBool InputHeadingReady { get; set;}

		[Ordinal(106)] [RED("("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[Ordinal(107)] [RED("("bRAxisReleasedLastFrame")] 		public CBool BRAxisReleasedLastFrame { get; set;}

		[Ordinal(108)] [RED("("selectTargetTime")] 		public CFloat SelectTargetTime { get; set;}

		[Ordinal(109)] [RED("("swipeMouseTimeStamp")] 		public CFloat SwipeMouseTimeStamp { get; set;}

		[Ordinal(110)] [RED("("swipeMouseDir")] 		public Vector SwipeMouseDir { get; set;}

		[Ordinal(111)] [RED("("swipeMouseDist")] 		public CFloat SwipeMouseDist { get; set;}

		[Ordinal(112)] [RED("("enableSwipeCheck")] 		public CBool EnableSwipeCheck { get; set;}

		[Ordinal(113)] [RED("("lAxisReleasedAfterCounter")] 		public CBool LAxisReleasedAfterCounter { get; set;}

		[Ordinal(114)] [RED("("lAxisReleaseCounterEnabled")] 		public CBool LAxisReleaseCounterEnabled { get; set;}

		[Ordinal(115)] [RED("("lAxisReleasedAfterCounterNoCA")] 		public CBool LAxisReleasedAfterCounterNoCA { get; set;}

		[Ordinal(116)] [RED("("lAxisReleaseCounterEnabledNoCA")] 		public CBool LAxisReleaseCounterEnabledNoCA { get; set;}

		[Ordinal(117)] [RED("("sprintButtonPressedTimestamp")] 		public CFloat SprintButtonPressedTimestamp { get; set;}

		[Ordinal(118)] [RED("("sprintingCamera")] 		public CBool SprintingCamera { get; set;}

		[Ordinal(119)] [RED("("runningCamera")] 		public CBool RunningCamera { get; set;}

		[Ordinal(120)] [RED("("disableSprintingTimerEnabled")] 		public CBool DisableSprintingTimerEnabled { get; set;}

		[Ordinal(121)] [RED("("illusionMedallion", 2,0)] 		public CArray<SItemUniqueId> IllusionMedallion { get; set;}

		[Ordinal(122)] [RED("("csNormallyStoppedBuff")] 		public CBool CsNormallyStoppedBuff { get; set;}

		public CPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}