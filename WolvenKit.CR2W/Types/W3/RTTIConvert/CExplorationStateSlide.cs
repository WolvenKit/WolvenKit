using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSlide : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("("subState")] 		public CEnum<ESlidingSubState> SubState { get; set;}

		[Ordinal(0)] [RED("("enableWallSlide")] 		public CBool EnableWallSlide { get; set;}

		[Ordinal(0)] [RED("("useSmothedCoefOnIdle")] 		public CBool UseSmothedCoefOnIdle { get; set;}

		[Ordinal(0)] [RED("("angleMinDefault")] 		public CFloat AngleMinDefault { get; set;}

		[Ordinal(0)] [RED("("anglefMax")] 		public CFloat AnglefMax { get; set;}

		[Ordinal(0)] [RED("("coefExtraToStop")] 		public CFloat CoefExtraToStop { get; set;}

		[Ordinal(0)] [RED("("slideCoefRelatedToInput")] 		public CBool SlideCoefRelatedToInput { get; set;}

		[Ordinal(0)] [RED("("dotToStartForward")] 		public CFloat DotToStartForward { get; set;}

		[Ordinal(0)] [RED("("coefToStartBackward")] 		public CFloat CoefToStartBackward { get; set;}

		[Ordinal(0)] [RED("("coefToStartCenter")] 		public CFloat CoefToStartCenter { get; set;}

		[Ordinal(0)] [RED("("coefToStartForward")] 		public CFloat CoefToStartForward { get; set;}

		[Ordinal(0)] [RED("("useWideTerrainCheckToEnter")] 		public CBool UseWideTerrainCheckToEnter { get; set;}

		[Ordinal(0)] [RED("("updateMaterials")] 		public CBool UpdateMaterials { get; set;}

		[Ordinal(0)] [RED("("materialParams", 2,0)] 		public CArray<SSlidingMaterialPresetParams> MaterialParams { get; set;}

		[Ordinal(0)] [RED("("materialNamesToPresets", 2,0)] 		public CArray<SSlidingMaterialNamesToPresets> MaterialNamesToPresets { get; set;}

		[Ordinal(0)] [RED("("materialParamsDefaultN")] 		public CName MaterialParamsDefaultN { get; set;}

		[Ordinal(0)] [RED("("materialDefault")] 		public CInt32 MaterialDefault { get; set;}

		[Ordinal(0)] [RED("("materialCurId")] 		public CInt32 MaterialCurId { get; set;}

		[Ordinal(0)] [RED("("materialNameCur")] 		public CName MaterialNameCur { get; set;}

		[Ordinal(0)] [RED("("minTimeToIdle")] 		public CFloat MinTimeToIdle { get; set;}

		[Ordinal(0)] [RED("("orientingInitial")] 		public CFloat OrientingInitial { get; set;}

		[Ordinal(0)] [RED("("initialImpulse")] 		public CFloat InitialImpulse { get; set;}

		[Ordinal(0)] [RED("("startedFromJump")] 		public CBool StartedFromJump { get; set;}

		[Ordinal(0)] [RED("("startedFromRoll")] 		public CBool StartedFromRoll { get; set;}

		[Ordinal(0)] [RED("("orientingSpeedMin")] 		public CFloat OrientingSpeedMin { get; set;}

		[Ordinal(0)] [RED("("orientingSpeedMax")] 		public CFloat OrientingSpeedMax { get; set;}

		[Ordinal(0)] [RED("("orientingMaxSlope")] 		public CFloat OrientingMaxSlope { get; set;}

		[Ordinal(0)] [RED("("timeToHardSlide")] 		public CFloat TimeToHardSlide { get; set;}

		[Ordinal(0)] [RED("("behGraphEventSlideHard")] 		public CName BehGraphEventSlideHard { get; set;}

		[Ordinal(0)] [RED("("requireSpeedToExit")] 		public CBool RequireSpeedToExit { get; set;}

		[Ordinal(0)] [RED("("speedToExitForward")] 		public CFloat SpeedToExitForward { get; set;}

		[Ordinal(0)] [RED("("speedToExitCenter")] 		public CFloat SpeedToExitCenter { get; set;}

		[Ordinal(0)] [RED("("speedToExitBackward")] 		public CFloat SpeedToExitBackward { get; set;}

		[Ordinal(0)] [RED("("exitingTimeMinSoft")] 		public CFloat ExitingTimeMinSoft { get; set;}

		[Ordinal(0)] [RED("("exitingTimeCur")] 		public CFloat ExitingTimeCur { get; set;}

		[Ordinal(0)] [RED("("exitingTimeTotal")] 		public CFloat ExitingTimeTotal { get; set;}

		[Ordinal(0)] [RED("("exitingTimeTotalInput")] 		public CFloat ExitingTimeTotalInput { get; set;}

		[Ordinal(0)] [RED("("stoppingFriction")] 		public CBool StoppingFriction { get; set;}

		[Ordinal(0)] [RED("("cooldownMax")] 		public CFloat CooldownMax { get; set;}

		[Ordinal(0)] [RED("("cooldownCur")] 		public CFloat CooldownCur { get; set;}

		[Ordinal(0)] [RED("("landCoolingDown")] 		public CBool LandCoolingDown { get; set;}

		[Ordinal(0)] [RED("("landCoolDownTime")] 		public CFloat LandCoolDownTime { get; set;}

		[Ordinal(0)] [RED("("fromJumpBehGraphEvent")] 		public CName FromJumpBehGraphEvent { get; set;}

		[Ordinal(0)] [RED("("fromRollBehGraphEvent")] 		public CName FromRollBehGraphEvent { get; set;}

		[Ordinal(0)] [RED("("jumpAllowed")] 		public CBool JumpAllowed { get; set;}

		[Ordinal(0)] [RED("("jumpCoolDownTime")] 		public CFloat JumpCoolDownTime { get; set;}

		[Ordinal(0)] [RED("("fallSpeedMaxConsidered")] 		public CFloat FallSpeedMaxConsidered { get; set;}

		[Ordinal(0)] [RED("("fallSpeedCoef")] 		public CFloat FallSpeedCoef { get; set;}

		[Ordinal(0)] [RED("("fallHorizImpulse")] 		public CFloat FallHorizImpulse { get; set;}

		[Ordinal(0)] [RED("("fallHorizImpulseCancel")] 		public CFloat FallHorizImpulseCancel { get; set;}

		[Ordinal(0)] [RED("("fallExtraVertImpulse")] 		public CFloat FallExtraVertImpulse { get; set;}

		[Ordinal(0)] [RED("("slidingPhysicsSpeed")] 		public CFloat SlidingPhysicsSpeed { get; set;}

		[Ordinal(0)] [RED("("movementParams")] 		public SSlidingMovementParams MovementParams { get; set;}

		[Ordinal(0)] [RED("("movementStoppingParams")] 		public SSlidingMovementParams MovementStoppingParams { get; set;}

		[Ordinal(0)] [RED("("usePhysics")] 		public CBool UsePhysics { get; set;}

		[Ordinal(0)] [RED("("slideDirectionDamped")] 		public Vector SlideDirectionDamped { get; set;}

		[Ordinal(0)] [RED("("smoothedDirBlendCoef")] 		public CFloat SmoothedDirBlendCoef { get; set;}

		[Ordinal(0)] [RED("("slideKills")] 		public CBool SlideKills { get; set;}

		[Ordinal(0)] [RED("("m_DeadB")] 		public CBool M_DeadB { get; set;}

		[Ordinal(0)] [RED("("toFallEnabled")] 		public CBool ToFallEnabled { get; set;}

		[Ordinal(0)] [RED("("toFallTimeCur")] 		public CFloat ToFallTimeCur { get; set;}

		[Ordinal(0)] [RED("("toConsiderFallTimeTotal")] 		public CFloat ToConsiderFallTimeTotal { get; set;}

		[Ordinal(0)] [RED("("toFallTimeTotal")] 		public CFloat ToFallTimeTotal { get; set;}

		[Ordinal(0)] [RED("("toFallSlopeCoefMin")] 		public CFloat ToFallSlopeCoefMin { get; set;}

		[Ordinal(0)] [RED("("toFallSlopeSpeedMin")] 		public CFloat ToFallSlopeSpeedMin { get; set;}

		[Ordinal(0)] [RED("("toFallSlopeCoef")] 		public CFloat ToFallSlopeCoef { get; set;}

		[Ordinal(0)] [RED("("toFallSpeedCoef")] 		public CFloat ToFallSpeedCoef { get; set;}

		[Ordinal(0)] [RED("("toFallRecoverCoef")] 		public CFloat ToFallRecoverCoef { get; set;}

		[Ordinal(0)] [RED("("toFallCameraLevel")] 		public CInt32 ToFallCameraLevel { get; set;}

		[Ordinal(0)] [RED("("cameraShakeState")] 		public CEnum<ESlideCameraShakeState> CameraShakeState { get; set;}

		[Ordinal(0)] [RED("("cameraAnimName")] 		public CName CameraAnimName { get; set;}

		[Ordinal(0)] [RED("("behTripToDeath")] 		public CName BehTripToDeath { get; set;}

		[Ordinal(0)] [RED("("behHeightVar")] 		public CName BehHeightVar { get; set;}

		[Ordinal(0)] [RED("("behInclinationVar")] 		public CName BehInclinationVar { get; set;}

		[Ordinal(0)] [RED("("behTurnVar")] 		public CName BehTurnVar { get; set;}

		[Ordinal(0)] [RED("("behAccelVar")] 		public CName BehAccelVar { get; set;}

		[Ordinal(0)] [RED("("behRightFootForwardVar")] 		public CName BehRightFootForwardVar { get; set;}

		[Ordinal(0)] [RED("("inclinationBlendSpeed")] 		public CFloat InclinationBlendSpeed { get; set;}

		[Ordinal(0)] [RED("("inclinationStart")] 		public CFloat InclinationStart { get; set;}

		[Ordinal(0)] [RED("("turnInclinationMax")] 		public CFloat TurnInclinationMax { get; set;}

		[Ordinal(0)] [RED("("turnInclinationBlend")] 		public CFloat TurnInclinationBlend { get; set;}

		[Ordinal(0)] [RED("("turnInclinationCur")] 		public CFloat TurnInclinationCur { get; set;}

		[Ordinal(0)] [RED("("inclinationEnterTimeMax")] 		public CFloat InclinationEnterTimeMax { get; set;}

		[Ordinal(0)] [RED("("inclinationEnterTimeCur")] 		public CFloat InclinationEnterTimeCur { get; set;}

		[Ordinal(0)] [RED("("inclination")] 		public CFloat Inclination { get; set;}

		[Ordinal(0)] [RED("("behForwardVar")] 		public CName BehForwardVar { get; set;}

		[Ordinal(0)] [RED("("behSlideRestart")] 		public CName BehSlideRestart { get; set;}

		[Ordinal(0)] [RED("("behSlideEnd")] 		public CName BehSlideEnd { get; set;}

		[Ordinal(0)] [RED("("behSlideEndRun")] 		public CName BehSlideEndRun { get; set;}

		[Ordinal(0)] [RED("("behSlideEndIdle")] 		public CName BehSlideEndIdle { get; set;}

		[Ordinal(0)] [RED("("boneToStickName")] 		public CName BoneToStickName { get; set;}

		[Ordinal(0)] [RED("("boneToStickId")] 		public CInt32 BoneToStickId { get; set;}

		[Ordinal(0)] [RED("("animEventHardSliding")] 		public CName AnimEventHardSliding { get; set;}

		[Ordinal(0)] [RED("("lockedOnHardSliding")] 		public CBool LockedOnHardSliding { get; set;}

		[Ordinal(0)] [RED("("particlesEnabled")] 		public CBool ParticlesEnabled { get; set;}

		[Ordinal(0)] [RED("("particlesName")] 		public CName ParticlesName { get; set;}

		[Ordinal(0)] [RED("("boneLeftFoot")] 		public CName BoneLeftFoot { get; set;}

		[Ordinal(0)] [RED("("boneRightFoot")] 		public CName BoneRightFoot { get; set;}

		[Ordinal(0)] [RED("("timeToRespawnParticlesCur")] 		public CFloat TimeToRespawnParticlesCur { get; set;}

		[Ordinal(0)] [RED("("timeToRespawnParticlesMax")] 		public CFloat TimeToRespawnParticlesMax { get; set;}

		public CExplorationStateSlide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSlide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}