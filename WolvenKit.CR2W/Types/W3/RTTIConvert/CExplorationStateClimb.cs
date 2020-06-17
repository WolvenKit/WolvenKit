using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateClimb : CExplorationStateAbstract
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("climbTypes", 2,0)] 		public CArray<CClimbType> ClimbTypes { get; set;}

		[RED("heightMaxToRun")] 		public CFloat HeightMaxToRun { get; set;}

		[RED("platformHeightMinAir")] 		public CFloat PlatformHeightMinAir { get; set;}

		[RED("platformHeightMin")] 		public CFloat PlatformHeightMin { get; set;}

		[RED("animDurationLimit")] 		public CFloat AnimDurationLimit { get; set;}

		[RED("slideDistMaxOnRun")] 		public CFloat SlideDistMaxOnRun { get; set;}

		[RED("autoClimb")] 		public CBool AutoClimb { get; set;}

		[RED("autoClimbOnAir")] 		public CBool AutoClimbOnAir { get; set;}

		[RED("inputAngleToEnter")] 		public CFloat InputAngleToEnter { get; set;}

		[RED("inputAngleToRun")] 		public CFloat InputAngleToRun { get; set;}

		[RED("inputAirHold")] 		public CBool InputAirHold { get; set;}

		[RED("inputAirTimeGap")] 		public CBool InputAirTimeGap { get; set;}

		[RED("inputTimeGapCheck")] 		public CFloat InputTimeGapCheck { get; set;}

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

		[RED("cameraSetVault")] 		public CHandle<CCameraParametersSet> CameraSetVault { get; set;}

		[RED("cameraSetJump")] 		public CHandle<CCameraParametersSet> CameraSetJump { get; set;}

		[RED("updateCameraManual")] 		public CBool UpdateCameraManual { get; set;}

		[RED("updateCameraAnim")] 		public CBool UpdateCameraAnim { get; set;}

		[RED("camFollowBoneName")] 		public CName CamFollowBoneName { get; set;}

		[RED("forceAirCollision")] 		public CBool ForceAirCollision { get; set;}

		[RED("forceJumpGrab")] 		public CBool ForceJumpGrab { get; set;}

		[RED("noAdjustor")] 		public CBool NoAdjustor { get; set;}

		[RED("noPelvisCorection")] 		public CBool NoPelvisCorection { get; set;}

		public CExplorationStateClimb(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateClimb(cr2w);

	}
}