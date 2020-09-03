using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateClimb : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("m_ClimbOracleO")] 		public CHandle<CExplorationClimbOracle> M_ClimbOracleO { get; set;}

		[Ordinal(2)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(3)] [RED("climbTypes", 2,0)] 		public CArray<CClimbType> ClimbTypes { get; set;}

		[Ordinal(4)] [RED("climbCur")] 		public CClimbType ClimbCur { get; set;}

		[Ordinal(5)] [RED("heightMaxToRun")] 		public CFloat HeightMaxToRun { get; set;}

		[Ordinal(6)] [RED("platformHeightMinAir")] 		public CFloat PlatformHeightMinAir { get; set;}

		[Ordinal(7)] [RED("platformHeightMin")] 		public CFloat PlatformHeightMin { get; set;}

		[Ordinal(8)] [RED("climbPoint")] 		public Vector ClimbPoint { get; set;}

		[Ordinal(9)] [RED("wallNormal")] 		public Vector WallNormal { get; set;}

		[Ordinal(10)] [RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[Ordinal(11)] [RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[Ordinal(12)] [RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[Ordinal(13)] [RED("curPlayerStateType")] 		public CEnum<EClimbRequirementType> CurPlayerStateType { get; set;}

		[Ordinal(14)] [RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[Ordinal(15)] [RED("ended")] 		public CBool Ended { get; set;}

		[Ordinal(16)] [RED("canWalk")] 		public CBool CanWalk { get; set;}

		[Ordinal(17)] [RED("canRun")] 		public CBool CanRun { get; set;}

		[Ordinal(18)] [RED("canFall")] 		public CBool CanFall { get; set;}

		[Ordinal(19)] [RED("animDurationLimit")] 		public CFloat AnimDurationLimit { get; set;}

		[Ordinal(20)] [RED("slideDistMaxOnRun")] 		public CFloat SlideDistMaxOnRun { get; set;}

		[Ordinal(21)] [RED("autoClimb")] 		public CBool AutoClimb { get; set;}

		[Ordinal(22)] [RED("autoClimbOnAir")] 		public CBool AutoClimbOnAir { get; set;}

		[Ordinal(23)] [RED("inputAngleToEnter")] 		public CFloat InputAngleToEnter { get; set;}

		[Ordinal(24)] [RED("inputAngleToRun")] 		public CFloat InputAngleToRun { get; set;}

		[Ordinal(25)] [RED("inputAttemptsTop")] 		public CBool InputAttemptsTop { get; set;}

		[Ordinal(26)] [RED("inputDirection")] 		public Vector InputDirection { get; set;}

		[Ordinal(27)] [RED("inputAirHold")] 		public CBool InputAirHold { get; set;}

		[Ordinal(28)] [RED("inputAirTimeGap")] 		public CBool InputAirTimeGap { get; set;}

		[Ordinal(29)] [RED("inputTimeGapCheck")] 		public CFloat InputTimeGapCheck { get; set;}

		[Ordinal(30)] [RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[Ordinal(31)] [RED("adjustInitiallRotat")] 		public CFloat AdjustInitiallRotat { get; set;}

		[Ordinal(32)] [RED("adjustRotation")] 		public CFloat AdjustRotation { get; set;}

		[Ordinal(33)] [RED("adjustTranslation")] 		public Vector AdjustTranslation { get; set;}

		[Ordinal(34)] [RED("adjustInitialRotDone")] 		public CBool AdjustInitialRotDone { get; set;}

		[Ordinal(35)] [RED("adjustRotDone")] 		public CBool AdjustRotDone { get; set;}

		[Ordinal(36)] [RED("adjustTransDone")] 		public CBool AdjustTransDone { get; set;}

		[Ordinal(37)] [RED("adjustSpeedMax")] 		public CFloat AdjustSpeedMax { get; set;}

		[Ordinal(38)] [RED("adjustSpeedRequire")] 		public CBool AdjustSpeedRequire { get; set;}

		[Ordinal(39)] [RED("adjustSpeedEndTime")] 		public CFloat AdjustSpeedEndTime { get; set;}

		[Ordinal(40)] [RED("adjust2Dduration")] 		public CFloat Adjust2Dduration { get; set;}

		[Ordinal(41)] [RED("adjust2Speed")] 		public CFloat Adjust2Speed { get; set;}

		[Ordinal(42)] [RED("adjust2Translation")] 		public Vector Adjust2Translation { get; set;}

		[Ordinal(43)] [RED("heightToAdd")] 		public CFloat HeightToAdd { get; set;}

		[Ordinal(44)] [RED("pelvisTransMax")] 		public CFloat PelvisTransMax { get; set;}

		[Ordinal(45)] [RED("pelvisTransAllow")] 		public CBool PelvisTransAllow { get; set;}

		[Ordinal(46)] [RED("pelvisTransState")] 		public CEnum<EOutsideCapsuleState> PelvisTransState { get; set;}

		[Ordinal(47)] [RED("pelvisTranslationN")] 		public CName PelvisTranslationN { get; set;}

		[Ordinal(48)] [RED("pelvisTransCur")] 		public CFloat PelvisTransCur { get; set;}

		[Ordinal(49)] [RED("pelvisTransTarget")] 		public CFloat PelvisTransTarget { get; set;}

		[Ordinal(50)] [RED("pelvisTransSpeed")] 		public CFloat PelvisTransSpeed { get; set;}

		[Ordinal(51)] [RED("pelvisTransSpeedOut")] 		public CFloat PelvisTransSpeedOut { get; set;}

		[Ordinal(52)] [RED("behAnimAdjustInitRot")] 		public CName BehAnimAdjustInitRot { get; set;}

		[Ordinal(53)] [RED("behAnimAdjustRot")] 		public CName BehAnimAdjustRot { get; set;}

		[Ordinal(54)] [RED("behAnimAdjustTrans")] 		public CName BehAnimAdjustTrans { get; set;}

		[Ordinal(55)] [RED("behAnimEnded")] 		public CName BehAnimEnded { get; set;}

		[Ordinal(56)] [RED("behAnimCanWalk")] 		public CName BehAnimCanWalk { get; set;}

		[Ordinal(57)] [RED("behAnimCanRun")] 		public CName BehAnimCanRun { get; set;}

		[Ordinal(58)] [RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		[Ordinal(59)] [RED("behEnableIK")] 		public CName BehEnableIK { get; set;}

		[Ordinal(60)] [RED("behDisablePelvisTrans")] 		public CName BehDisablePelvisTrans { get; set;}

		[Ordinal(61)] [RED("behEnableHandsIK")] 		public CName BehEnableHandsIK { get; set;}

		[Ordinal(62)] [RED("behEnableHandLIK")] 		public CName BehEnableHandLIK { get; set;}

		[Ordinal(63)] [RED("behEnableHandRIK")] 		public CName BehEnableHandRIK { get; set;}

		[Ordinal(64)] [RED("behDisableHandsIK")] 		public CName BehDisableHandsIK { get; set;}

		[Ordinal(65)] [RED("behDisableHandLIK")] 		public CName BehDisableHandLIK { get; set;}

		[Ordinal(66)] [RED("behDisableHandRIK")] 		public CName BehDisableHandRIK { get; set;}

		[Ordinal(67)] [RED("behHeightTypeEnum")] 		public CName BehHeightTypeEnum { get; set;}

		[Ordinal(68)] [RED("behVaultTypeEnum")] 		public CName BehVaultTypeEnum { get; set;}

		[Ordinal(69)] [RED("behPlatformTypeEnum")] 		public CName BehPlatformTypeEnum { get; set;}

		[Ordinal(70)] [RED("behStateTypeEnum")] 		public CName BehStateTypeEnum { get; set;}

		[Ordinal(71)] [RED("behGoToRun")] 		public CName BehGoToRun { get; set;}

		[Ordinal(72)] [RED("behGoToWalk")] 		public CName BehGoToWalk { get; set;}

		[Ordinal(73)] [RED("behToRun")] 		public CName BehToRun { get; set;}

		[Ordinal(74)] [RED("behVarEnd")] 		public CName BehVarEnd { get; set;}

		[Ordinal(75)] [RED("behAnimSpeed")] 		public CName BehAnimSpeed { get; set;}

		[Ordinal(76)] [RED("continousHandIK")] 		public CBool ContinousHandIK { get; set;}

		[Ordinal(77)] [RED("handIKMinDistToEnable")] 		public CFloat HandIKMinDistToEnable { get; set;}

		[Ordinal(78)] [RED("handIKMaxDist")] 		public CFloat HandIKMaxDist { get; set;}

		[Ordinal(79)] [RED("handIKForwardOffset")] 		public CFloat HandIKForwardOffset { get; set;}

		[Ordinal(80)] [RED("handIKHalfMaxHeight")] 		public CFloat HandIKHalfMaxHeight { get; set;}

		[Ordinal(81)] [RED("handIKBlendSpeedIn")] 		public CFloat HandIKBlendSpeedIn { get; set;}

		[Ordinal(82)] [RED("handIKBlendSpeedOut")] 		public CFloat HandIKBlendSpeedOut { get; set;}

		[Ordinal(83)] [RED("handThickness")] 		public CFloat HandThickness { get; set;}

		[Ordinal(84)] [RED("boneRightHand")] 		public CName BoneRightHand { get; set;}

		[Ordinal(85)] [RED("boneLeftHand")] 		public CName BoneLeftHand { get; set;}

		[Ordinal(86)] [RED("boneIndexRightHand")] 		public CInt32 BoneIndexRightHand { get; set;}

		[Ordinal(87)] [RED("boneIndexLeftHand")] 		public CInt32 BoneIndexLeftHand { get; set;}

		[Ordinal(88)] [RED("rightHandOffset")] 		public CFloat RightHandOffset { get; set;}

		[Ordinal(89)] [RED("leftHandOffset")] 		public CFloat LeftHandOffset { get; set;}

		[Ordinal(90)] [RED("rightHandOffsetCur")] 		public CFloat RightHandOffsetCur { get; set;}

		[Ordinal(91)] [RED("leftHandOffsetCur")] 		public CFloat LeftHandOffsetCur { get; set;}

		[Ordinal(92)] [RED("handIKEnabled")] 		public CBool HandIKEnabled { get; set;}

		[Ordinal(93)] [RED("handIKEnabledLeft")] 		public CBool HandIKEnabledLeft { get; set;}

		[Ordinal(94)] [RED("handIKEnabledRight")] 		public CBool HandIKEnabledRight { get; set;}

		[Ordinal(95)] [RED("handIKqueuedL")] 		public CBool HandIKqueuedL { get; set;}

		[Ordinal(96)] [RED("handIKqueuedR")] 		public CBool HandIKqueuedR { get; set;}

		[Ordinal(97)] [RED("handIKLRayOrigin")] 		public Vector HandIKLRayOrigin { get; set;}

		[Ordinal(98)] [RED("handIKLRayEnd")] 		public Vector HandIKLRayEnd { get; set;}

		[Ordinal(99)] [RED("handIKLRayCollision")] 		public Vector HandIKLRayCollision { get; set;}

		[Ordinal(100)] [RED("handIKRRayOrigin")] 		public Vector HandIKRRayOrigin { get; set;}

		[Ordinal(101)] [RED("handIKRRayEnd")] 		public Vector HandIKRRayEnd { get; set;}

		[Ordinal(102)] [RED("handIKRRayCollision")] 		public Vector HandIKRRayCollision { get; set;}

		[Ordinal(103)] [RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[Ordinal(104)] [RED("cameraSetVault")] 		public CHandle<CCameraParametersSet> CameraSetVault { get; set;}

		[Ordinal(105)] [RED("cameraSetJump")] 		public CHandle<CCameraParametersSet> CameraSetJump { get; set;}

		[Ordinal(106)] [RED("updateCameraManual")] 		public CBool UpdateCameraManual { get; set;}

		[Ordinal(107)] [RED("updateCameraAnim")] 		public CBool UpdateCameraAnim { get; set;}

		[Ordinal(108)] [RED("camOriginalPosition")] 		public Vector CamOriginalPosition { get; set;}

		[Ordinal(109)] [RED("camOriginalRotation")] 		public EulerAngles CamOriginalRotation { get; set;}

		[Ordinal(110)] [RED("camCurRotation")] 		public EulerAngles CamCurRotation { get; set;}

		[Ordinal(111)] [RED("camOriginalOffset")] 		public Vector CamOriginalOffset { get; set;}

		[Ordinal(112)] [RED("camStart")] 		public CBool CamStart { get; set;}

		[Ordinal(113)] [RED("camFollowBoneID")] 		public CInt32 CamFollowBoneID { get; set;}

		[Ordinal(114)] [RED("camFollowBoneName")] 		public CName CamFollowBoneName { get; set;}

		[Ordinal(115)] [RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[Ordinal(116)] [RED("forceAirCollision")] 		public CBool ForceAirCollision { get; set;}

		[Ordinal(117)] [RED("forceJumpGrab")] 		public CBool ForceJumpGrab { get; set;}

		[Ordinal(118)] [RED("noAdjustor")] 		public CBool NoAdjustor { get; set;}

		[Ordinal(119)] [RED("noPelvisCorection")] 		public CBool NoPelvisCorection { get; set;}

		[Ordinal(120)] [RED("restoreUsableItemLAtEnd")] 		public CBool RestoreUsableItemLAtEnd { get; set;}

		public CExplorationStateClimb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateClimb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}