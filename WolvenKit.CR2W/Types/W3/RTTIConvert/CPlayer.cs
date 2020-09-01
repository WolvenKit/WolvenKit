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
		[Ordinal(0)] [RED("("npcVoicesetCooldown")] 		public CFloat NpcVoicesetCooldown { get; set;}

		[Ordinal(0)] [RED("("presenceInterestPoint")] 		public CPtr<CInterestPoint> PresenceInterestPoint { get; set;}

		[Ordinal(0)] [RED("("slowMovementInterestPoint")] 		public CPtr<CInterestPoint> SlowMovementInterestPoint { get; set;}

		[Ordinal(0)] [RED("("fastMovementInterestPoint")] 		public CPtr<CInterestPoint> FastMovementInterestPoint { get; set;}

		[Ordinal(0)] [RED("("weaponDrawnInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawnInterestPoint { get; set;}

		[Ordinal(0)] [RED("("weaponDrawMomentInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawMomentInterestPoint { get; set;}

		[Ordinal(0)] [RED("("visionInterestPoint")] 		public CPtr<CInterestPoint> VisionInterestPoint { get; set;}

		[Ordinal(0)] [RED("("isMovable")] 		public CBool IsMovable { get; set;}

		[Ordinal(0)] [RED("("enemyUpscaling")] 		public CBool EnemyUpscaling { get; set;}

		[Ordinal(0)] [RED("("_DEBUGDisplayRadiusMinimapIcons")] 		public CBool _DEBUGDisplayRadiusMinimapIcons { get; set;}

		[Ordinal(0)] [RED("("debug_BIsInputAllowedLocks", 2,0)] 		public CArray<CName> Debug_BIsInputAllowedLocks { get; set;}

		[Ordinal(0)] [RED("("ENTER_SWIMMING_WATER_LEVEL")] 		public CFloat ENTER_SWIMMING_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("("useSprintingCameraAnim")] 		public CBool UseSprintingCameraAnim { get; set;}

		[Ordinal(0)] [RED("("oTCameraOffset")] 		public CFloat OTCameraOffset { get; set;}

		[Ordinal(0)] [RED("("oTCameraPitchOffset")] 		public CFloat OTCameraPitchOffset { get; set;}

		[Ordinal(0)] [RED("("bIsRollAllowed")] 		public CBool BIsRollAllowed { get; set;}

		[Ordinal(0)] [RED("("bIsInCombatAction")] 		public CBool BIsInCombatAction { get; set;}

		[Ordinal(0)] [RED("("bIsInCombatActionFriendly")] 		public CBool BIsInCombatActionFriendly { get; set;}

		[Ordinal(0)] [RED("("bIsInputAllowed")] 		public CBool BIsInputAllowed { get; set;}

		[Ordinal(0)] [RED("("bIsFirstAttackInCombo")] 		public CBool BIsFirstAttackInCombo { get; set;}

		[Ordinal(0)] [RED("("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[Ordinal(0)] [RED("("FarZoneDistMax")] 		public CFloat FarZoneDistMax { get; set;}

		[Ordinal(0)] [RED("("DangerZoneDistMax")] 		public CFloat DangerZoneDistMax { get; set;}

		[Ordinal(0)] [RED("("commentaryCooldown")] 		public CFloat CommentaryCooldown { get; set;}

		[Ordinal(0)] [RED("("commentaryLastTime")] 		public EngineTime CommentaryLastTime { get; set;}

		[Ordinal(0)] [RED("("canPlaySpecificVoiceset")] 		public CBool CanPlaySpecificVoiceset { get; set;}

		[Ordinal(0)] [RED("("isHorseMounted")] 		public CBool IsHorseMounted { get; set;}

		[Ordinal(0)] [RED("("isCompanionFollowing")] 		public CBool IsCompanionFollowing { get; set;}

		[Ordinal(0)] [RED("("bStartScreenIsOpened")] 		public CBool BStartScreenIsOpened { get; set;}

		[Ordinal(0)] [RED("("bEndScreenIsOpened")] 		public CBool BEndScreenIsOpened { get; set;}

		[Ordinal(0)] [RED("("fStartScreenFadeDuration")] 		public CFloat FStartScreenFadeDuration { get; set;}

		[Ordinal(0)] [RED("("bStartScreenEndWithBlackScreen")] 		public CBool BStartScreenEndWithBlackScreen { get; set;}

		[Ordinal(0)] [RED("("fStartScreenFadeInDuration")] 		public CFloat FStartScreenFadeInDuration { get; set;}

		[Ordinal(0)] [RED("("DEATH_SCREEN_OPEN_DELAY")] 		public CFloat DEATH_SCREEN_OPEN_DELAY { get; set;}

		[Ordinal(0)] [RED("("bLAxisReleased")] 		public CBool BLAxisReleased { get; set;}

		[Ordinal(0)] [RED("("bRAxisReleased")] 		public CBool BRAxisReleased { get; set;}

		[Ordinal(0)] [RED("("bUITakesInput")] 		public CBool BUITakesInput { get; set;}

		[Ordinal(0)] [RED("("inputHandler")] 		public CHandle<CPlayerInput> InputHandler { get; set;}

		[Ordinal(0)] [RED("("sprintActionPressed")] 		public CBool SprintActionPressed { get; set;}

		[Ordinal(0)] [RED("("inputModuleNeededToRun")] 		public CFloat InputModuleNeededToRun { get; set;}

		[Ordinal(0)] [RED("("bInteractionPressed")] 		public CBool BInteractionPressed { get; set;}

		[Ordinal(0)] [RED("("rawPlayerSpeed")] 		public CFloat RawPlayerSpeed { get; set;}

		[Ordinal(0)] [RED("("rawPlayerAngle")] 		public CFloat RawPlayerAngle { get; set;}

		[Ordinal(0)] [RED("("rawPlayerHeading")] 		public CFloat RawPlayerHeading { get; set;}

		[Ordinal(0)] [RED("("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[Ordinal(0)] [RED("("cachedCombatActionHeading")] 		public CFloat CachedCombatActionHeading { get; set;}

		[Ordinal(0)] [RED("("canResetCachedCombatActionHeading")] 		public CBool CanResetCachedCombatActionHeading { get; set;}

		[Ordinal(0)] [RED("("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[Ordinal(0)] [RED("("rawCameraHeading")] 		public CFloat RawCameraHeading { get; set;}

		[Ordinal(0)] [RED("("isSprinting")] 		public CBool IsSprinting { get; set;}

		[Ordinal(0)] [RED("("isRunning")] 		public CBool IsRunning { get; set;}

		[Ordinal(0)] [RED("("isWalking")] 		public CBool IsWalking { get; set;}

		[Ordinal(0)] [RED("("playerMoveType")] 		public CEnum<EPlayerMoveType> PlayerMoveType { get; set;}

		[Ordinal(0)] [RED("("sprintingTime")] 		public CFloat SprintingTime { get; set;}

		[Ordinal(0)] [RED("("walkToggle")] 		public CBool WalkToggle { get; set;}

		[Ordinal(0)] [RED("("sprintToggle")] 		public CBool SprintToggle { get; set;}

		[Ordinal(0)] [RED("("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[Ordinal(0)] [RED("("nonActorTarget")] 		public CHandle<CGameplayEntity> NonActorTarget { get; set;}

		[Ordinal(0)] [RED("("tempLookAtTarget")] 		public CHandle<CGameplayEntity> TempLookAtTarget { get; set;}

		[Ordinal(0)] [RED("("lockTargetSelectionHeading")] 		public CFloat LockTargetSelectionHeading { get; set;}

		[Ordinal(0)] [RED("("rawLeftJoyRot")] 		public CFloat RawLeftJoyRot { get; set;}

		[Ordinal(0)] [RED("("rawRightJoyRot")] 		public CFloat RawRightJoyRot { get; set;}

		[Ordinal(0)] [RED("("rawLeftJoyVec")] 		public Vector RawLeftJoyVec { get; set;}

		[Ordinal(0)] [RED("("rawRightJoyVec")] 		public Vector RawRightJoyVec { get; set;}

		[Ordinal(0)] [RED("("prevRawLeftJoyVec")] 		public Vector PrevRawLeftJoyVec { get; set;}

		[Ordinal(0)] [RED("("prevRawRightJoyVec")] 		public Vector PrevRawRightJoyVec { get; set;}

		[Ordinal(0)] [RED("("lastValidLeftJoyVec")] 		public Vector LastValidLeftJoyVec { get; set;}

		[Ordinal(0)] [RED("("lastValidRightJoyVec")] 		public Vector LastValidRightJoyVec { get; set;}

		[Ordinal(0)] [RED("("allowStopRunCheck")] 		public CBool AllowStopRunCheck { get; set;}

		[Ordinal(0)] [RED("("moveTargetDampValue")] 		public CFloat MoveTargetDampValue { get; set;}

		[Ordinal(0)] [RED("("interiorCamera")] 		public CBool InteriorCamera { get; set;}

		[Ordinal(0)] [RED("("movementLockType")] 		public CEnum<EPlayerMovementLockType> MovementLockType { get; set;}

		[Ordinal(0)] [RED("("scriptedCombatCamera")] 		public CBool ScriptedCombatCamera { get; set;}

		[Ordinal(0)] [RED("("modifyPlayerSpeed")] 		public CBool ModifyPlayerSpeed { get; set;}

		[Ordinal(0)] [RED("("autoCameraCenterToggle")] 		public CBool AutoCameraCenterToggle { get; set;}

		[Ordinal(0)] [RED("("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(0)] [RED("("equipmentSlotHistory", 2,0)] 		public CArray<SItemUniqueId> EquipmentSlotHistory { get; set;}

		[Ordinal(0)] [RED("("currentTrackedQuestSystemObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestSystemObjectives { get; set;}

		[Ordinal(0)] [RED("("currentTrackedQuestObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestObjectives { get; set;}

		[Ordinal(0)] [RED("("currentTrackedQuestGUID")] 		public CGUID CurrentTrackedQuestGUID { get; set;}

		[Ordinal(0)] [RED("("HAXNewObjTable", 2,0)] 		public CArray<CGUID> HAXNewObjTable { get; set;}

		[Ordinal(0)] [RED("("handAimPitch")] 		public CFloat HandAimPitch { get; set;}

		[Ordinal(0)] [RED("("vehicleCachedSign")] 		public CEnum<ESignType> VehicleCachedSign { get; set;}

		[Ordinal(0)] [RED("("softLockDist")] 		public CFloat SoftLockDist { get; set;}

		[Ordinal(0)] [RED("("softLockFrameSize")] 		public CFloat SoftLockFrameSize { get; set;}

		[Ordinal(0)] [RED("("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[Ordinal(0)] [RED("("softLockDistVehicle")] 		public CFloat SoftLockDistVehicle { get; set;}

		[Ordinal(0)] [RED("("bBIsLockedToTarget")] 		public CBool BBIsLockedToTarget { get; set;}

		[Ordinal(0)] [RED("("bActorIsLockedToTarget")] 		public CBool BActorIsLockedToTarget { get; set;}

		[Ordinal(0)] [RED("("bIsHardLockedTotarget")] 		public CBool BIsHardLockedTotarget { get; set;}

		[Ordinal(0)] [RED("("terrTypeOne")] 		public CEnum<ETerrainType> TerrTypeOne { get; set;}

		[Ordinal(0)] [RED("("terrTypeTwo")] 		public CEnum<ETerrainType> TerrTypeTwo { get; set;}

		[Ordinal(0)] [RED("("terrModifier")] 		public CFloat TerrModifier { get; set;}

		[Ordinal(0)] [RED("("prevTerrType")] 		public CEnum<ETerrainType> PrevTerrType { get; set;}

		[Ordinal(0)] [RED("("currentlyUsedItem")] 		public CHandle<W3UsableItem> CurrentlyUsedItem { get; set;}

		[Ordinal(0)] [RED("("currentlyEquipedItem")] 		public SItemUniqueId CurrentlyEquipedItem { get; set;}

		[Ordinal(0)] [RED("("currentlyUsedItemL")] 		public CHandle<W3UsableItem> CurrentlyUsedItemL { get; set;}

		[Ordinal(0)] [RED("("currentlyEquipedItemL")] 		public SItemUniqueId CurrentlyEquipedItemL { get; set;}

		[Ordinal(0)] [RED("("isUsableItemBlocked")] 		public CBool IsUsableItemBlocked { get; set;}

		[Ordinal(0)] [RED("("isUsableItemLtransitionAllowed")] 		public CBool IsUsableItemLtransitionAllowed { get; set;}

		[Ordinal(0)] [RED("("playerActionToRestore")] 		public CEnum<EPlayerActionToRestore> PlayerActionToRestore { get; set;}

		[Ordinal(0)] [RED("("teleportedOnBoatToOtherHUB")] 		public CBool TeleportedOnBoatToOtherHUB { get; set;}

		[Ordinal(0)] [RED("("isAdaptiveBalance")] 		public CBool IsAdaptiveBalance { get; set;}

		[Ordinal(0)] [RED("("modbootstrap")] 		public CHandle<CModBootstrap> Modbootstrap { get; set;}

		[Ordinal(0)] [RED("("inputHeadingReady")] 		public CBool InputHeadingReady { get; set;}

		[Ordinal(0)] [RED("("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[Ordinal(0)] [RED("("bRAxisReleasedLastFrame")] 		public CBool BRAxisReleasedLastFrame { get; set;}

		[Ordinal(0)] [RED("("selectTargetTime")] 		public CFloat SelectTargetTime { get; set;}

		[Ordinal(0)] [RED("("swipeMouseTimeStamp")] 		public CFloat SwipeMouseTimeStamp { get; set;}

		[Ordinal(0)] [RED("("swipeMouseDir")] 		public Vector SwipeMouseDir { get; set;}

		[Ordinal(0)] [RED("("swipeMouseDist")] 		public CFloat SwipeMouseDist { get; set;}

		[Ordinal(0)] [RED("("enableSwipeCheck")] 		public CBool EnableSwipeCheck { get; set;}

		[Ordinal(0)] [RED("("lAxisReleasedAfterCounter")] 		public CBool LAxisReleasedAfterCounter { get; set;}

		[Ordinal(0)] [RED("("lAxisReleaseCounterEnabled")] 		public CBool LAxisReleaseCounterEnabled { get; set;}

		[Ordinal(0)] [RED("("lAxisReleasedAfterCounterNoCA")] 		public CBool LAxisReleasedAfterCounterNoCA { get; set;}

		[Ordinal(0)] [RED("("lAxisReleaseCounterEnabledNoCA")] 		public CBool LAxisReleaseCounterEnabledNoCA { get; set;}

		[Ordinal(0)] [RED("("sprintButtonPressedTimestamp")] 		public CFloat SprintButtonPressedTimestamp { get; set;}

		[Ordinal(0)] [RED("("sprintingCamera")] 		public CBool SprintingCamera { get; set;}

		[Ordinal(0)] [RED("("runningCamera")] 		public CBool RunningCamera { get; set;}

		[Ordinal(0)] [RED("("disableSprintingTimerEnabled")] 		public CBool DisableSprintingTimerEnabled { get; set;}

		[Ordinal(0)] [RED("("illusionMedallion", 2,0)] 		public CArray<SItemUniqueId> IllusionMedallion { get; set;}

		[Ordinal(0)] [RED("("csNormallyStoppedBuff")] 		public CBool CsNormallyStoppedBuff { get; set;}

		public CPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}