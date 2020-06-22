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
		[RED("npcVoicesetCooldown")] 		public CFloat NpcVoicesetCooldown { get; set;}

		[RED("presenceInterestPoint")] 		public CPtr<CInterestPoint> PresenceInterestPoint { get; set;}

		[RED("slowMovementInterestPoint")] 		public CPtr<CInterestPoint> SlowMovementInterestPoint { get; set;}

		[RED("fastMovementInterestPoint")] 		public CPtr<CInterestPoint> FastMovementInterestPoint { get; set;}

		[RED("weaponDrawnInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawnInterestPoint { get; set;}

		[RED("weaponDrawMomentInterestPoint")] 		public CPtr<CInterestPoint> WeaponDrawMomentInterestPoint { get; set;}

		[RED("visionInterestPoint")] 		public CPtr<CInterestPoint> VisionInterestPoint { get; set;}

		[RED("isMovable")] 		public CBool IsMovable { get; set;}

		[RED("enemyUpscaling")] 		public CBool EnemyUpscaling { get; set;}

		[RED("_DEBUGDisplayRadiusMinimapIcons")] 		public CBool _DEBUGDisplayRadiusMinimapIcons { get; set;}

		[RED("debug_BIsInputAllowedLocks", 2,0)] 		public CArray<CName> Debug_BIsInputAllowedLocks { get; set;}

		[RED("ENTER_SWIMMING_WATER_LEVEL")] 		public CFloat ENTER_SWIMMING_WATER_LEVEL { get; set;}

		[RED("useSprintingCameraAnim")] 		public CBool UseSprintingCameraAnim { get; set;}

		[RED("oTCameraOffset")] 		public CFloat OTCameraOffset { get; set;}

		[RED("oTCameraPitchOffset")] 		public CFloat OTCameraPitchOffset { get; set;}

		[RED("bIsRollAllowed")] 		public CBool BIsRollAllowed { get; set;}

		[RED("bIsInCombatAction")] 		public CBool BIsInCombatAction { get; set;}

		[RED("bIsInCombatActionFriendly")] 		public CBool BIsInCombatActionFriendly { get; set;}

		[RED("bIsInputAllowed")] 		public CBool BIsInputAllowed { get; set;}

		[RED("bIsFirstAttackInCombo")] 		public CBool BIsFirstAttackInCombo { get; set;}

		[RED("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[RED("FarZoneDistMax")] 		public CFloat FarZoneDistMax { get; set;}

		[RED("DangerZoneDistMax")] 		public CFloat DangerZoneDistMax { get; set;}

		[RED("commentaryCooldown")] 		public CFloat CommentaryCooldown { get; set;}

		[RED("commentaryLastTime")] 		public EngineTime CommentaryLastTime { get; set;}

		[RED("canPlaySpecificVoiceset")] 		public CBool CanPlaySpecificVoiceset { get; set;}

		[RED("isHorseMounted")] 		public CBool IsHorseMounted { get; set;}

		[RED("isCompanionFollowing")] 		public CBool IsCompanionFollowing { get; set;}

		[RED("bStartScreenIsOpened")] 		public CBool BStartScreenIsOpened { get; set;}

		[RED("bEndScreenIsOpened")] 		public CBool BEndScreenIsOpened { get; set;}

		[RED("fStartScreenFadeDuration")] 		public CFloat FStartScreenFadeDuration { get; set;}

		[RED("bStartScreenEndWithBlackScreen")] 		public CBool BStartScreenEndWithBlackScreen { get; set;}

		[RED("fStartScreenFadeInDuration")] 		public CFloat FStartScreenFadeInDuration { get; set;}

		[RED("DEATH_SCREEN_OPEN_DELAY")] 		public CFloat DEATH_SCREEN_OPEN_DELAY { get; set;}

		[RED("bLAxisReleased")] 		public CBool BLAxisReleased { get; set;}

		[RED("bRAxisReleased")] 		public CBool BRAxisReleased { get; set;}

		[RED("bUITakesInput")] 		public CBool BUITakesInput { get; set;}

		[RED("inputHandler")] 		public CHandle<CPlayerInput> InputHandler { get; set;}

		[RED("sprintActionPressed")] 		public CBool SprintActionPressed { get; set;}

		[RED("inputModuleNeededToRun")] 		public CFloat InputModuleNeededToRun { get; set;}

		[RED("bInteractionPressed")] 		public CBool BInteractionPressed { get; set;}

		[RED("rawPlayerSpeed")] 		public CFloat RawPlayerSpeed { get; set;}

		[RED("rawPlayerAngle")] 		public CFloat RawPlayerAngle { get; set;}

		[RED("rawPlayerHeading")] 		public CFloat RawPlayerHeading { get; set;}

		[RED("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[RED("cachedCombatActionHeading")] 		public CFloat CachedCombatActionHeading { get; set;}

		[RED("canResetCachedCombatActionHeading")] 		public CBool CanResetCachedCombatActionHeading { get; set;}

		[RED("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[RED("rawCameraHeading")] 		public CFloat RawCameraHeading { get; set;}

		[RED("isSprinting")] 		public CBool IsSprinting { get; set;}

		[RED("isRunning")] 		public CBool IsRunning { get; set;}

		[RED("isWalking")] 		public CBool IsWalking { get; set;}

		[RED("playerMoveType")] 		public CEnum<EPlayerMoveType> PlayerMoveType { get; set;}

		[RED("sprintingTime")] 		public CFloat SprintingTime { get; set;}

		[RED("walkToggle")] 		public CBool WalkToggle { get; set;}

		[RED("sprintToggle")] 		public CBool SprintToggle { get; set;}

		[RED("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[RED("nonActorTarget")] 		public CHandle<CGameplayEntity> NonActorTarget { get; set;}

		[RED("tempLookAtTarget")] 		public CHandle<CGameplayEntity> TempLookAtTarget { get; set;}

		[RED("lockTargetSelectionHeading")] 		public CFloat LockTargetSelectionHeading { get; set;}

		[RED("rawLeftJoyRot")] 		public CFloat RawLeftJoyRot { get; set;}

		[RED("rawRightJoyRot")] 		public CFloat RawRightJoyRot { get; set;}

		[RED("rawLeftJoyVec")] 		public Vector RawLeftJoyVec { get; set;}

		[RED("rawRightJoyVec")] 		public Vector RawRightJoyVec { get; set;}

		[RED("prevRawLeftJoyVec")] 		public Vector PrevRawLeftJoyVec { get; set;}

		[RED("prevRawRightJoyVec")] 		public Vector PrevRawRightJoyVec { get; set;}

		[RED("lastValidLeftJoyVec")] 		public Vector LastValidLeftJoyVec { get; set;}

		[RED("lastValidRightJoyVec")] 		public Vector LastValidRightJoyVec { get; set;}

		[RED("allowStopRunCheck")] 		public CBool AllowStopRunCheck { get; set;}

		[RED("moveTargetDampValue")] 		public CFloat MoveTargetDampValue { get; set;}

		[RED("interiorCamera")] 		public CBool InteriorCamera { get; set;}

		[RED("movementLockType")] 		public CEnum<EPlayerMovementLockType> MovementLockType { get; set;}

		[RED("scriptedCombatCamera")] 		public CBool ScriptedCombatCamera { get; set;}

		[RED("modifyPlayerSpeed")] 		public CBool ModifyPlayerSpeed { get; set;}

		[RED("autoCameraCenterToggle")] 		public CBool AutoCameraCenterToggle { get; set;}

		[RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[RED("equipmentSlotHistory", 2,0)] 		public CArray<SItemUniqueId> EquipmentSlotHistory { get; set;}

		[RED("currentTrackedQuestSystemObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestSystemObjectives { get; set;}

		[RED("currentTrackedQuestObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> CurrentTrackedQuestObjectives { get; set;}

		[RED("currentTrackedQuestGUID")] 		public CGUID CurrentTrackedQuestGUID { get; set;}

		[RED("HAXNewObjTable", 2,0)] 		public CArray<CGUID> HAXNewObjTable { get; set;}

		[RED("handAimPitch")] 		public CFloat HandAimPitch { get; set;}

		[RED("vehicleCachedSign")] 		public CEnum<ESignType> VehicleCachedSign { get; set;}

		[RED("softLockDist")] 		public CFloat SoftLockDist { get; set;}

		[RED("softLockFrameSize")] 		public CFloat SoftLockFrameSize { get; set;}

		[RED("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[RED("softLockDistVehicle")] 		public CFloat SoftLockDistVehicle { get; set;}

		[RED("bBIsLockedToTarget")] 		public CBool BBIsLockedToTarget { get; set;}

		[RED("bActorIsLockedToTarget")] 		public CBool BActorIsLockedToTarget { get; set;}

		[RED("bIsHardLockedTotarget")] 		public CBool BIsHardLockedTotarget { get; set;}

		[RED("terrTypeOne")] 		public CEnum<ETerrainType> TerrTypeOne { get; set;}

		[RED("terrTypeTwo")] 		public CEnum<ETerrainType> TerrTypeTwo { get; set;}

		[RED("terrModifier")] 		public CFloat TerrModifier { get; set;}

		[RED("prevTerrType")] 		public CEnum<ETerrainType> PrevTerrType { get; set;}

		[RED("currentlyUsedItem")] 		public CHandle<W3UsableItem> CurrentlyUsedItem { get; set;}

		[RED("currentlyEquipedItem")] 		public SItemUniqueId CurrentlyEquipedItem { get; set;}

		[RED("currentlyUsedItemL")] 		public CHandle<W3UsableItem> CurrentlyUsedItemL { get; set;}

		[RED("currentlyEquipedItemL")] 		public SItemUniqueId CurrentlyEquipedItemL { get; set;}

		[RED("isUsableItemBlocked")] 		public CBool IsUsableItemBlocked { get; set;}

		[RED("isUsableItemLtransitionAllowed")] 		public CBool IsUsableItemLtransitionAllowed { get; set;}

		[RED("playerActionToRestore")] 		public CEnum<EPlayerActionToRestore> PlayerActionToRestore { get; set;}

		[RED("teleportedOnBoatToOtherHUB")] 		public CBool TeleportedOnBoatToOtherHUB { get; set;}

		[RED("isAdaptiveBalance")] 		public CBool IsAdaptiveBalance { get; set;}

		[RED("modbootstrap")] 		public CHandle<CModBootstrap> Modbootstrap { get; set;}

		[RED("inputHeadingReady")] 		public CBool InputHeadingReady { get; set;}

		[RED("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[RED("bRAxisReleasedLastFrame")] 		public CBool BRAxisReleasedLastFrame { get; set;}

		[RED("selectTargetTime")] 		public CFloat SelectTargetTime { get; set;}

		[RED("swipeMouseTimeStamp")] 		public CFloat SwipeMouseTimeStamp { get; set;}

		[RED("swipeMouseDir")] 		public Vector SwipeMouseDir { get; set;}

		[RED("swipeMouseDist")] 		public CFloat SwipeMouseDist { get; set;}

		[RED("enableSwipeCheck")] 		public CBool EnableSwipeCheck { get; set;}

		[RED("lAxisReleasedAfterCounter")] 		public CBool LAxisReleasedAfterCounter { get; set;}

		[RED("lAxisReleaseCounterEnabled")] 		public CBool LAxisReleaseCounterEnabled { get; set;}

		[RED("lAxisReleasedAfterCounterNoCA")] 		public CBool LAxisReleasedAfterCounterNoCA { get; set;}

		[RED("lAxisReleaseCounterEnabledNoCA")] 		public CBool LAxisReleaseCounterEnabledNoCA { get; set;}

		[RED("sprintButtonPressedTimestamp")] 		public CFloat SprintButtonPressedTimestamp { get; set;}

		[RED("sprintingCamera")] 		public CBool SprintingCamera { get; set;}

		[RED("runningCamera")] 		public CBool RunningCamera { get; set;}

		[RED("disableSprintingTimerEnabled")] 		public CBool DisableSprintingTimerEnabled { get; set;}

		[RED("illusionMedallion", 2,0)] 		public CArray<SItemUniqueId> IllusionMedallion { get; set;}

		[RED("csNormallyStoppedBuff")] 		public CBool CsNormallyStoppedBuff { get; set;}

		public CPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}