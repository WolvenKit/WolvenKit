using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateClimb : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("m_ClimbOracleO")] 		public CHandle<CExplorationClimbOracle> M_ClimbOracleO { get; set;}

		[Ordinal(0)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("climbTypes", 2,0)] 		public CArray<CClimbType> ClimbTypes { get; set;}

		[Ordinal(0)] [RED("climbCur")] 		public CClimbType ClimbCur { get; set;}

		[Ordinal(0)] [RED("heightMaxToRun")] 		public CFloat HeightMaxToRun { get; set;}

		[Ordinal(0)] [RED("platformHeightMinAir")] 		public CFloat PlatformHeightMinAir { get; set;}

		[Ordinal(0)] [RED("platformHeightMin")] 		public CFloat PlatformHeightMin { get; set;}

		[Ordinal(0)] [RED("climbPoint")] 		public Vector ClimbPoint { get; set;}

		[Ordinal(0)] [RED("wallNormal")] 		public Vector WallNormal { get; set;}

		[Ordinal(0)] [RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[Ordinal(0)] [RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[Ordinal(0)] [RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[Ordinal(0)] [RED("curPlayerStateType")] 		public CEnum<EClimbRequirementType> CurPlayerStateType { get; set;}

		[Ordinal(0)] [RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[Ordinal(0)] [RED("ended")] 		public CBool Ended { get; set;}

		[Ordinal(0)] [RED("canWalk")] 		public CBool CanWalk { get; set;}

		[Ordinal(0)] [RED("canRun")] 		public CBool CanRun { get; set;}

		[Ordinal(0)] [RED("canFall")] 		public CBool CanFall { get; set;}

		[Ordinal(0)] [RED("animDurationLimit")] 		public CFloat AnimDurationLimit { get; set;}

		[Ordinal(0)] [RED("slideDistMaxOnRun")] 		public CFloat SlideDistMaxOnRun { get; set;}

		[Ordinal(0)] [RED("autoClimb")] 		public CBool AutoClimb { get; set;}

		[Ordinal(0)] [RED("autoClimbOnAir")] 		public CBool AutoClimbOnAir { get; set;}

		[Ordinal(0)] [RED("inputAngleToEnter")] 		public CFloat InputAngleToEnter { get; set;}

		[Ordinal(0)] [RED("inputAngleToRun")] 		public CFloat InputAngleToRun { get; set;}

		[Ordinal(0)] [RED("inputAttemptsTop")] 		public CBool InputAttemptsTop { get; set;}

		[Ordinal(0)] [RED("inputDirection")] 		public Vector InputDirection { get; set;}

		[Ordinal(0)] [RED("inputAirHold")] 		public CBool InputAirHold { get; set;}

		[Ordinal(0)] [RED("inputAirTimeGap")] 		public CBool InputAirTimeGap { get; set;}

		[Ordinal(0)] [RED("inputTimeGapCheck")] 		public CFloat InputTimeGapCheck { get; set;}

		[Ordinal(0)] [RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[Ordinal(0)] [RED("adjustInitiallRotat")] 		public CFloat AdjustInitiallRotat { get; set;}

		[Ordinal(0)] [RED("adjustRotation")] 		public CFloat AdjustRotation { get; set;}

		[Ordinal(0)] [RED("adjustTranslation")] 		public Vector AdjustTranslation { get; set;}

		[Ordinal(0)] [RED("adjustInitialRotDone")] 		public CBool AdjustInitialRotDone { get; set;}

		[Ordinal(0)] [RED("adjustRotDone")] 		public CBool AdjustRotDone { get; set;}

		[Ordinal(0)] [RED("adjustTransDone")] 		public CBool AdjustTransDone { get; set;}

		[Ordinal(0)] [RED("adjustSpeedMax")] 		public CFloat AdjustSpeedMax { get; set;}

		[Ordinal(0)] [RED("adjustSpeedRequire")] 		public CBool AdjustSpeedRequire { get; set;}

		[Ordinal(0)] [RED("adjustSpeedEndTime")] 		public CFloat AdjustSpeedEndTime { get; set;}

		[Ordinal(0)] [RED("adjust2Dduration")] 		public CFloat Adjust2Dduration { get; set;}

		[Ordinal(0)] [RED("adjust2Speed")] 		public CFloat Adjust2Speed { get; set;}

		[Ordinal(0)] [RED("adjust2Translation")] 		public Vector Adjust2Translation { get; set;}

		[Ordinal(0)] [RED("heightToAdd")] 		public CFloat HeightToAdd { get; set;}

		[Ordinal(0)] [RED("pelvisTransMax")] 		public CFloat PelvisTransMax { get; set;}

		[Ordinal(0)] [RED("pelvisTransAllow")] 		public CBool PelvisTransAllow { get; set;}

		[Ordinal(0)] [RED("pelvisTransState")] 		public CEnum<EOutsideCapsuleState> PelvisTransState { get; set;}

		[Ordinal(0)] [RED("pelvisTranslationN")] 		public CName PelvisTranslationN { get; set;}

		[Ordinal(0)] [RED("pelvisTransCur")] 		public CFloat PelvisTransCur { get; set;}

		[Ordinal(0)] [RED("pelvisTransTarget")] 		public CFloat PelvisTransTarget { get; set;}

		[Ordinal(0)] [RED("pelvisTransSpeed")] 		public CFloat PelvisTransSpeed { get; set;}

		[Ordinal(0)] [RED("pelvisTransSpeedOut")] 		public CFloat PelvisTransSpeedOut { get; set;}

		[Ordinal(0)] [RED("behAnimAdjustInitRot")] 		public CName BehAnimAdjustInitRot { get; set;}

		[Ordinal(0)] [RED("behAnimAdjustRot")] 		public CName BehAnimAdjustRot { get; set;}

		[Ordinal(0)] [RED("behAnimAdjustTrans")] 		public CName BehAnimAdjustTrans { get; set;}

		[Ordinal(0)] [RED("behAnimEnded")] 		public CName BehAnimEnded { get; set;}

		[Ordinal(0)] [RED("behAnimCanWalk")] 		public CName BehAnimCanWalk { get; set;}

		[Ordinal(0)] [RED("behAnimCanRun")] 		public CName BehAnimCanRun { get; set;}

		[Ordinal(0)] [RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		[Ordinal(0)] [RED("behEnableIK")] 		public CName BehEnableIK { get; set;}

		[Ordinal(0)] [RED("behDisablePelvisTrans")] 		public CName BehDisablePelvisTrans { get; set;}

		[Ordinal(0)] [RED("behEnableHandsIK")] 		public CName BehEnableHandsIK { get; set;}

		[Ordinal(0)] [RED("behEnableHandLIK")] 		public CName BehEnableHandLIK { get; set;}

		[Ordinal(0)] [RED("behEnableHandRIK")] 		public CName BehEnableHandRIK { get; set;}

		[Ordinal(0)] [RED("behDisableHandsIK")] 		public CName BehDisableHandsIK { get; set;}

		[Ordinal(0)] [RED("behDisableHandLIK")] 		public CName BehDisableHandLIK { get; set;}

		[Ordinal(0)] [RED("behDisableHandRIK")] 		public CName BehDisableHandRIK { get; set;}

		[Ordinal(0)] [RED("behHeightTypeEnum")] 		public CName BehHeightTypeEnum { get; set;}

		[Ordinal(0)] [RED("behVaultTypeEnum")] 		public CName BehVaultTypeEnum { get; set;}

		[Ordinal(0)] [RED("behPlatformTypeEnum")] 		public CName BehPlatformTypeEnum { get; set;}

		[Ordinal(0)] [RED("behStateTypeEnum")] 		public CName BehStateTypeEnum { get; set;}

		[Ordinal(0)] [RED("behGoToRun")] 		public CName BehGoToRun { get; set;}

		[Ordinal(0)] [RED("behGoToWalk")] 		public CName BehGoToWalk { get; set;}

		[Ordinal(0)] [RED("behToRun")] 		public CName BehToRun { get; set;}

		[Ordinal(0)] [RED("behVarEnd")] 		public CName BehVarEnd { get; set;}

		[Ordinal(0)] [RED("behAnimSpeed")] 		public CName BehAnimSpeed { get; set;}

		[Ordinal(0)] [RED("continousHandIK")] 		public CBool ContinousHandIK { get; set;}

		[Ordinal(0)] [RED("handIKMinDistToEnable")] 		public CFloat HandIKMinDistToEnable { get; set;}

		[Ordinal(0)] [RED("handIKMaxDist")] 		public CFloat HandIKMaxDist { get; set;}

		[Ordinal(0)] [RED("handIKForwardOffset")] 		public CFloat HandIKForwardOffset { get; set;}

		[Ordinal(0)] [RED("handIKHalfMaxHeight")] 		public CFloat HandIKHalfMaxHeight { get; set;}

		[Ordinal(0)] [RED("handIKBlendSpeedIn")] 		public CFloat HandIKBlendSpeedIn { get; set;}

		[Ordinal(0)] [RED("handIKBlendSpeedOut")] 		public CFloat HandIKBlendSpeedOut { get; set;}

		[Ordinal(0)] [RED("handThickness")] 		public CFloat HandThickness { get; set;}

		[Ordinal(0)] [RED("boneRightHand")] 		public CName BoneRightHand { get; set;}

		[Ordinal(0)] [RED("boneLeftHand")] 		public CName BoneLeftHand { get; set;}

		[Ordinal(0)] [RED("boneIndexRightHand")] 		public CInt32 BoneIndexRightHand { get; set;}

		[Ordinal(0)] [RED("boneIndexLeftHand")] 		public CInt32 BoneIndexLeftHand { get; set;}

		[Ordinal(0)] [RED("rightHandOffset")] 		public CFloat RightHandOffset { get; set;}

		[Ordinal(0)] [RED("leftHandOffset")] 		public CFloat LeftHandOffset { get; set;}

		[Ordinal(0)] [RED("rightHandOffsetCur")] 		public CFloat RightHandOffsetCur { get; set;}

		[Ordinal(0)] [RED("leftHandOffsetCur")] 		public CFloat LeftHandOffsetCur { get; set;}

		[Ordinal(0)] [RED("handIKEnabled")] 		public CBool HandIKEnabled { get; set;}

		[Ordinal(0)] [RED("handIKEnabledLeft")] 		public CBool HandIKEnabledLeft { get; set;}

		[Ordinal(0)] [RED("handIKEnabledRight")] 		public CBool HandIKEnabledRight { get; set;}

		[Ordinal(0)] [RED("handIKqueuedL")] 		public CBool HandIKqueuedL { get; set;}

		[Ordinal(0)] [RED("handIKqueuedR")] 		public CBool HandIKqueuedR { get; set;}

		[Ordinal(0)] [RED("handIKLRayOrigin")] 		public Vector HandIKLRayOrigin { get; set;}

		[Ordinal(0)] [RED("handIKLRayEnd")] 		public Vector HandIKLRayEnd { get; set;}

		[Ordinal(0)] [RED("handIKLRayCollision")] 		public Vector HandIKLRayCollision { get; set;}

		[Ordinal(0)] [RED("handIKRRayOrigin")] 		public Vector HandIKRRayOrigin { get; set;}

		[Ordinal(0)] [RED("handIKRRayEnd")] 		public Vector HandIKRRayEnd { get; set;}

		[Ordinal(0)] [RED("handIKRRayCollision")] 		public Vector HandIKRRayCollision { get; set;}

		[Ordinal(0)] [RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[Ordinal(0)] [RED("cameraSetVault")] 		public CHandle<CCameraParametersSet> CameraSetVault { get; set;}

		[Ordinal(0)] [RED("cameraSetJump")] 		public CHandle<CCameraParametersSet> CameraSetJump { get; set;}

		[Ordinal(0)] [RED("updateCameraManual")] 		public CBool UpdateCameraManual { get; set;}

		[Ordinal(0)] [RED("updateCameraAnim")] 		public CBool UpdateCameraAnim { get; set;}

		[Ordinal(0)] [RED("camOriginalPosition")] 		public Vector CamOriginalPosition { get; set;}

		[Ordinal(0)] [RED("camOriginalRotation")] 		public EulerAngles CamOriginalRotation { get; set;}

		[Ordinal(0)] [RED("camCurRotation")] 		public EulerAngles CamCurRotation { get; set;}

		[Ordinal(0)] [RED("camOriginalOffset")] 		public Vector CamOriginalOffset { get; set;}

		[Ordinal(0)] [RED("camStart")] 		public CBool CamStart { get; set;}

		[Ordinal(0)] [RED("camFollowBoneID")] 		public CInt32 CamFollowBoneID { get; set;}

		[Ordinal(0)] [RED("camFollowBoneName")] 		public CName CamFollowBoneName { get; set;}

		[Ordinal(0)] [RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[Ordinal(0)] [RED("forceAirCollision")] 		public CBool ForceAirCollision { get; set;}

		[Ordinal(0)] [RED("forceJumpGrab")] 		public CBool ForceJumpGrab { get; set;}

		[Ordinal(0)] [RED("noAdjustor")] 		public CBool NoAdjustor { get; set;}

		[Ordinal(0)] [RED("noPelvisCorection")] 		public CBool NoPelvisCorection { get; set;}

		[Ordinal(0)] [RED("restoreUsableItemLAtEnd")] 		public CBool RestoreUsableItemLAtEnd { get; set;}

		public CExplorationStateClimb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateClimb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}