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
		[RED("m_ClimbOracleO")] 		public CHandle<CExplorationClimbOracle> M_ClimbOracleO { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("climbTypes", 2,0)] 		public CArray<CClimbType> ClimbTypes { get; set;}

		[RED("climbCur")] 		public CClimbType ClimbCur { get; set;}

		[RED("heightMaxToRun")] 		public CFloat HeightMaxToRun { get; set;}

		[RED("platformHeightMinAir")] 		public CFloat PlatformHeightMinAir { get; set;}

		[RED("platformHeightMin")] 		public CFloat PlatformHeightMin { get; set;}

		[RED("climbPoint")] 		public Vector ClimbPoint { get; set;}

		[RED("wallNormal")] 		public Vector WallNormal { get; set;}

		[RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[RED("curPlayerStateType")] 		public CEnum<EClimbRequirementType> CurPlayerStateType { get; set;}

		[RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[RED("ended")] 		public CBool Ended { get; set;}

		[RED("canWalk")] 		public CBool CanWalk { get; set;}

		[RED("canRun")] 		public CBool CanRun { get; set;}

		[RED("canFall")] 		public CBool CanFall { get; set;}

		[RED("animDurationLimit")] 		public CFloat AnimDurationLimit { get; set;}

		[RED("slideDistMaxOnRun")] 		public CFloat SlideDistMaxOnRun { get; set;}

		[RED("autoClimb")] 		public CBool AutoClimb { get; set;}

		[RED("autoClimbOnAir")] 		public CBool AutoClimbOnAir { get; set;}

		[RED("inputAngleToEnter")] 		public CFloat InputAngleToEnter { get; set;}

		[RED("inputAngleToRun")] 		public CFloat InputAngleToRun { get; set;}

		[RED("inputAttemptsTop")] 		public CBool InputAttemptsTop { get; set;}

		[RED("inputDirection")] 		public Vector InputDirection { get; set;}

		[RED("inputAirHold")] 		public CBool InputAirHold { get; set;}

		[RED("inputAirTimeGap")] 		public CBool InputAirTimeGap { get; set;}

		[RED("inputTimeGapCheck")] 		public CFloat InputTimeGapCheck { get; set;}

		[RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[RED("adjustInitiallRotat")] 		public CFloat AdjustInitiallRotat { get; set;}

		[RED("adjustRotation")] 		public CFloat AdjustRotation { get; set;}

		[RED("adjustTranslation")] 		public Vector AdjustTranslation { get; set;}

		[RED("adjustInitialRotDone")] 		public CBool AdjustInitialRotDone { get; set;}

		[RED("adjustRotDone")] 		public CBool AdjustRotDone { get; set;}

		[RED("adjustTransDone")] 		public CBool AdjustTransDone { get; set;}

		[RED("adjustSpeedMax")] 		public CFloat AdjustSpeedMax { get; set;}

		[RED("adjustSpeedRequire")] 		public CBool AdjustSpeedRequire { get; set;}

		[RED("adjustSpeedEndTime")] 		public CFloat AdjustSpeedEndTime { get; set;}

		[RED("adjust2Dduration")] 		public CFloat Adjust2Dduration { get; set;}

		[RED("adjust2Speed")] 		public CFloat Adjust2Speed { get; set;}

		[RED("adjust2Translation")] 		public Vector Adjust2Translation { get; set;}

		[RED("heightToAdd")] 		public CFloat HeightToAdd { get; set;}

		[RED("pelvisTransMax")] 		public CFloat PelvisTransMax { get; set;}

		[RED("pelvisTransAllow")] 		public CBool PelvisTransAllow { get; set;}

		[RED("pelvisTransState")] 		public CEnum<EOutsideCapsuleState> PelvisTransState { get; set;}

		[RED("pelvisTranslationN")] 		public CName PelvisTranslationN { get; set;}

		[RED("pelvisTransCur")] 		public CFloat PelvisTransCur { get; set;}

		[RED("pelvisTransTarget")] 		public CFloat PelvisTransTarget { get; set;}

		[RED("pelvisTransSpeed")] 		public CFloat PelvisTransSpeed { get; set;}

		[RED("pelvisTransSpeedOut")] 		public CFloat PelvisTransSpeedOut { get; set;}

		[RED("behAnimAdjustInitRot")] 		public CName BehAnimAdjustInitRot { get; set;}

		[RED("behAnimAdjustRot")] 		public CName BehAnimAdjustRot { get; set;}

		[RED("behAnimAdjustTrans")] 		public CName BehAnimAdjustTrans { get; set;}

		[RED("behAnimEnded")] 		public CName BehAnimEnded { get; set;}

		[RED("behAnimCanWalk")] 		public CName BehAnimCanWalk { get; set;}

		[RED("behAnimCanRun")] 		public CName BehAnimCanRun { get; set;}

		[RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		[RED("behEnableIK")] 		public CName BehEnableIK { get; set;}

		[RED("behDisablePelvisTrans")] 		public CName BehDisablePelvisTrans { get; set;}

		[RED("behEnableHandsIK")] 		public CName BehEnableHandsIK { get; set;}

		[RED("behEnableHandLIK")] 		public CName BehEnableHandLIK { get; set;}

		[RED("behEnableHandRIK")] 		public CName BehEnableHandRIK { get; set;}

		[RED("behDisableHandsIK")] 		public CName BehDisableHandsIK { get; set;}

		[RED("behDisableHandLIK")] 		public CName BehDisableHandLIK { get; set;}

		[RED("behDisableHandRIK")] 		public CName BehDisableHandRIK { get; set;}

		[RED("behHeightTypeEnum")] 		public CName BehHeightTypeEnum { get; set;}

		[RED("behVaultTypeEnum")] 		public CName BehVaultTypeEnum { get; set;}

		[RED("behPlatformTypeEnum")] 		public CName BehPlatformTypeEnum { get; set;}

		[RED("behStateTypeEnum")] 		public CName BehStateTypeEnum { get; set;}

		[RED("behGoToRun")] 		public CName BehGoToRun { get; set;}

		[RED("behGoToWalk")] 		public CName BehGoToWalk { get; set;}

		[RED("behToRun")] 		public CName BehToRun { get; set;}

		[RED("behVarEnd")] 		public CName BehVarEnd { get; set;}

		[RED("behAnimSpeed")] 		public CName BehAnimSpeed { get; set;}

		[RED("continousHandIK")] 		public CBool ContinousHandIK { get; set;}

		[RED("handIKMinDistToEnable")] 		public CFloat HandIKMinDistToEnable { get; set;}

		[RED("handIKMaxDist")] 		public CFloat HandIKMaxDist { get; set;}

		[RED("handIKForwardOffset")] 		public CFloat HandIKForwardOffset { get; set;}

		[RED("handIKHalfMaxHeight")] 		public CFloat HandIKHalfMaxHeight { get; set;}

		[RED("handIKBlendSpeedIn")] 		public CFloat HandIKBlendSpeedIn { get; set;}

		[RED("handIKBlendSpeedOut")] 		public CFloat HandIKBlendSpeedOut { get; set;}

		[RED("handThickness")] 		public CFloat HandThickness { get; set;}

		[RED("boneRightHand")] 		public CName BoneRightHand { get; set;}

		[RED("boneLeftHand")] 		public CName BoneLeftHand { get; set;}

		[RED("boneIndexRightHand")] 		public CInt32 BoneIndexRightHand { get; set;}

		[RED("boneIndexLeftHand")] 		public CInt32 BoneIndexLeftHand { get; set;}

		[RED("rightHandOffset")] 		public CFloat RightHandOffset { get; set;}

		[RED("leftHandOffset")] 		public CFloat LeftHandOffset { get; set;}

		[RED("rightHandOffsetCur")] 		public CFloat RightHandOffsetCur { get; set;}

		[RED("leftHandOffsetCur")] 		public CFloat LeftHandOffsetCur { get; set;}

		[RED("handIKEnabled")] 		public CBool HandIKEnabled { get; set;}

		[RED("handIKEnabledLeft")] 		public CBool HandIKEnabledLeft { get; set;}

		[RED("handIKEnabledRight")] 		public CBool HandIKEnabledRight { get; set;}

		[RED("handIKqueuedL")] 		public CBool HandIKqueuedL { get; set;}

		[RED("handIKqueuedR")] 		public CBool HandIKqueuedR { get; set;}

		[RED("handIKLRayOrigin")] 		public Vector HandIKLRayOrigin { get; set;}

		[RED("handIKLRayEnd")] 		public Vector HandIKLRayEnd { get; set;}

		[RED("handIKLRayCollision")] 		public Vector HandIKLRayCollision { get; set;}

		[RED("handIKRRayOrigin")] 		public Vector HandIKRRayOrigin { get; set;}

		[RED("handIKRRayEnd")] 		public Vector HandIKRRayEnd { get; set;}

		[RED("handIKRRayCollision")] 		public Vector HandIKRRayCollision { get; set;}

		[RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[RED("cameraSetVault")] 		public CHandle<CCameraParametersSet> CameraSetVault { get; set;}

		[RED("cameraSetJump")] 		public CHandle<CCameraParametersSet> CameraSetJump { get; set;}

		[RED("updateCameraManual")] 		public CBool UpdateCameraManual { get; set;}

		[RED("updateCameraAnim")] 		public CBool UpdateCameraAnim { get; set;}

		[RED("camOriginalPosition")] 		public Vector CamOriginalPosition { get; set;}

		[RED("camOriginalRotation")] 		public EulerAngles CamOriginalRotation { get; set;}

		[RED("camCurRotation")] 		public EulerAngles CamCurRotation { get; set;}

		[RED("camOriginalOffset")] 		public Vector CamOriginalOffset { get; set;}

		[RED("camStart")] 		public CBool CamStart { get; set;}

		[RED("camFollowBoneID")] 		public CInt32 CamFollowBoneID { get; set;}

		[RED("camFollowBoneName")] 		public CName CamFollowBoneName { get; set;}

		[RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[RED("forceAirCollision")] 		public CBool ForceAirCollision { get; set;}

		[RED("forceJumpGrab")] 		public CBool ForceJumpGrab { get; set;}

		[RED("noAdjustor")] 		public CBool NoAdjustor { get; set;}

		[RED("noPelvisCorection")] 		public CBool NoPelvisCorection { get; set;}

		[RED("restoreUsableItemLAtEnd")] 		public CBool RestoreUsableItemLAtEnd { get; set;}

		public CExplorationStateClimb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateClimb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}