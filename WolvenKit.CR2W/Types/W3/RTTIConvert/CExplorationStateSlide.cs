using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSlide : CExplorationStateAbstract
	{
		[RED("enableWallSlide")] 		public CBool EnableWallSlide { get; set;}

		[RED("useSmothedCoefOnIdle")] 		public CBool UseSmothedCoefOnIdle { get; set;}

		[RED("angleMinDefault")] 		public CFloat AngleMinDefault { get; set;}

		[RED("anglefMax")] 		public CFloat AnglefMax { get; set;}

		[RED("coefExtraToStop")] 		public CFloat CoefExtraToStop { get; set;}

		[RED("slideCoefRelatedToInput")] 		public CBool SlideCoefRelatedToInput { get; set;}

		[RED("dotToStartForward")] 		public CFloat DotToStartForward { get; set;}

		[RED("coefToStartBackward")] 		public CFloat CoefToStartBackward { get; set;}

		[RED("coefToStartCenter")] 		public CFloat CoefToStartCenter { get; set;}

		[RED("coefToStartForward")] 		public CFloat CoefToStartForward { get; set;}

		[RED("useWideTerrainCheckToEnter")] 		public CBool UseWideTerrainCheckToEnter { get; set;}

		[RED("materialParams", 2,0)] 		public CArray<SSlidingMaterialPresetParams> MaterialParams { get; set;}

		[RED("materialNamesToPresets", 2,0)] 		public CArray<SSlidingMaterialNamesToPresets> MaterialNamesToPresets { get; set;}

		[RED("materialParamsDefaultN")] 		public CName MaterialParamsDefaultN { get; set;}

		[RED("minTimeToIdle")] 		public CFloat MinTimeToIdle { get; set;}

		[RED("orientingInitial")] 		public CFloat OrientingInitial { get; set;}

		[RED("initialImpulse")] 		public CFloat InitialImpulse { get; set;}

		[RED("orientingSpeedMin")] 		public CFloat OrientingSpeedMin { get; set;}

		[RED("orientingSpeedMax")] 		public CFloat OrientingSpeedMax { get; set;}

		[RED("orientingMaxSlope")] 		public CFloat OrientingMaxSlope { get; set;}

		[RED("timeToHardSlide")] 		public CFloat TimeToHardSlide { get; set;}

		[RED("behGraphEventSlideHard")] 		public CName BehGraphEventSlideHard { get; set;}

		[RED("requireSpeedToExit")] 		public CBool RequireSpeedToExit { get; set;}

		[RED("speedToExitForward")] 		public CFloat SpeedToExitForward { get; set;}

		[RED("speedToExitCenter")] 		public CFloat SpeedToExitCenter { get; set;}

		[RED("speedToExitBackward")] 		public CFloat SpeedToExitBackward { get; set;}

		[RED("exitingTimeMinSoft")] 		public CFloat ExitingTimeMinSoft { get; set;}

		[RED("exitingTimeTotal")] 		public CFloat ExitingTimeTotal { get; set;}

		[RED("exitingTimeTotalInput")] 		public CFloat ExitingTimeTotalInput { get; set;}

		[RED("cooldownMax")] 		public CFloat CooldownMax { get; set;}

		[RED("landCoolDownTime")] 		public CFloat LandCoolDownTime { get; set;}

		[RED("fromJumpBehGraphEvent")] 		public CName FromJumpBehGraphEvent { get; set;}

		[RED("fromRollBehGraphEvent")] 		public CName FromRollBehGraphEvent { get; set;}

		[RED("jumpAllowed")] 		public CBool JumpAllowed { get; set;}

		[RED("jumpCoolDownTime")] 		public CFloat JumpCoolDownTime { get; set;}

		[RED("fallSpeedMaxConsidered")] 		public CFloat FallSpeedMaxConsidered { get; set;}

		[RED("fallSpeedCoef")] 		public CFloat FallSpeedCoef { get; set;}

		[RED("fallHorizImpulse")] 		public CFloat FallHorizImpulse { get; set;}

		[RED("fallHorizImpulseCancel")] 		public CFloat FallHorizImpulseCancel { get; set;}

		[RED("fallExtraVertImpulse")] 		public CFloat FallExtraVertImpulse { get; set;}

		[RED("slidingPhysicsSpeed")] 		public CFloat SlidingPhysicsSpeed { get; set;}

		[RED("movementParams")] 		public SSlidingMovementParams MovementParams { get; set;}

		[RED("movementStoppingParams")] 		public SSlidingMovementParams MovementStoppingParams { get; set;}

		[RED("usePhysics")] 		public CBool UsePhysics { get; set;}

		[RED("smoothedDirBlendCoef")] 		public CFloat SmoothedDirBlendCoef { get; set;}

		[RED("slideKills")] 		public CBool SlideKills { get; set;}

		[RED("toFallEnabled")] 		public CBool ToFallEnabled { get; set;}

		[RED("toConsiderFallTimeTotal")] 		public CFloat ToConsiderFallTimeTotal { get; set;}

		[RED("toFallTimeTotal")] 		public CFloat ToFallTimeTotal { get; set;}

		[RED("toFallSlopeCoefMin")] 		public CFloat ToFallSlopeCoefMin { get; set;}

		[RED("toFallSlopeSpeedMin")] 		public CFloat ToFallSlopeSpeedMin { get; set;}

		[RED("toFallSlopeCoef")] 		public CFloat ToFallSlopeCoef { get; set;}

		[RED("toFallSpeedCoef")] 		public CFloat ToFallSpeedCoef { get; set;}

		[RED("toFallRecoverCoef")] 		public CFloat ToFallRecoverCoef { get; set;}

		[RED("toFallCameraLevel")] 		public CInt32 ToFallCameraLevel { get; set;}

		[RED("cameraAnimName")] 		public CName CameraAnimName { get; set;}

		[RED("behTripToDeath")] 		public CName BehTripToDeath { get; set;}

		[RED("behHeightVar")] 		public CName BehHeightVar { get; set;}

		[RED("behInclinationVar")] 		public CName BehInclinationVar { get; set;}

		[RED("behTurnVar")] 		public CName BehTurnVar { get; set;}

		[RED("behAccelVar")] 		public CName BehAccelVar { get; set;}

		[RED("behRightFootForwardVar")] 		public CName BehRightFootForwardVar { get; set;}

		[RED("inclinationBlendSpeed")] 		public CFloat InclinationBlendSpeed { get; set;}

		[RED("inclinationStart")] 		public CFloat InclinationStart { get; set;}

		[RED("turnInclinationMax")] 		public CFloat TurnInclinationMax { get; set;}

		[RED("turnInclinationBlend")] 		public CFloat TurnInclinationBlend { get; set;}

		[RED("turnInclinationCur")] 		public CFloat TurnInclinationCur { get; set;}

		[RED("inclinationEnterTimeMax")] 		public CFloat InclinationEnterTimeMax { get; set;}

		[RED("behForwardVar")] 		public CName BehForwardVar { get; set;}

		[RED("behSlideRestart")] 		public CName BehSlideRestart { get; set;}

		[RED("behSlideEnd")] 		public CName BehSlideEnd { get; set;}

		[RED("behSlideEndRun")] 		public CName BehSlideEndRun { get; set;}

		[RED("behSlideEndIdle")] 		public CName BehSlideEndIdle { get; set;}

		[RED("boneToStickName")] 		public CName BoneToStickName { get; set;}

		[RED("animEventHardSliding")] 		public CName AnimEventHardSliding { get; set;}

		[RED("particlesEnabled")] 		public CBool ParticlesEnabled { get; set;}

		[RED("particlesName")] 		public CName ParticlesName { get; set;}

		[RED("boneLeftFoot")] 		public CName BoneLeftFoot { get; set;}

		[RED("boneRightFoot")] 		public CName BoneRightFoot { get; set;}

		[RED("timeToRespawnParticlesMax")] 		public CFloat TimeToRespawnParticlesMax { get; set;}

		public CExplorationStateSlide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSlide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}