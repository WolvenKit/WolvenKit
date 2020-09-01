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
		[Ordinal(1)] [RED("("subState")] 		public CEnum<ESlidingSubState> SubState { get; set;}

		[Ordinal(2)] [RED("("enableWallSlide")] 		public CBool EnableWallSlide { get; set;}

		[Ordinal(3)] [RED("("useSmothedCoefOnIdle")] 		public CBool UseSmothedCoefOnIdle { get; set;}

		[Ordinal(4)] [RED("("angleMinDefault")] 		public CFloat AngleMinDefault { get; set;}

		[Ordinal(5)] [RED("("anglefMax")] 		public CFloat AnglefMax { get; set;}

		[Ordinal(6)] [RED("("coefExtraToStop")] 		public CFloat CoefExtraToStop { get; set;}

		[Ordinal(7)] [RED("("slideCoefRelatedToInput")] 		public CBool SlideCoefRelatedToInput { get; set;}

		[Ordinal(8)] [RED("("dotToStartForward")] 		public CFloat DotToStartForward { get; set;}

		[Ordinal(9)] [RED("("coefToStartBackward")] 		public CFloat CoefToStartBackward { get; set;}

		[Ordinal(10)] [RED("("coefToStartCenter")] 		public CFloat CoefToStartCenter { get; set;}

		[Ordinal(11)] [RED("("coefToStartForward")] 		public CFloat CoefToStartForward { get; set;}

		[Ordinal(12)] [RED("("useWideTerrainCheckToEnter")] 		public CBool UseWideTerrainCheckToEnter { get; set;}

		[Ordinal(13)] [RED("("updateMaterials")] 		public CBool UpdateMaterials { get; set;}

		[Ordinal(14)] [RED("("materialParams", 2,0)] 		public CArray<SSlidingMaterialPresetParams> MaterialParams { get; set;}

		[Ordinal(15)] [RED("("materialNamesToPresets", 2,0)] 		public CArray<SSlidingMaterialNamesToPresets> MaterialNamesToPresets { get; set;}

		[Ordinal(16)] [RED("("materialParamsDefaultN")] 		public CName MaterialParamsDefaultN { get; set;}

		[Ordinal(17)] [RED("("materialDefault")] 		public CInt32 MaterialDefault { get; set;}

		[Ordinal(18)] [RED("("materialCurId")] 		public CInt32 MaterialCurId { get; set;}

		[Ordinal(19)] [RED("("materialNameCur")] 		public CName MaterialNameCur { get; set;}

		[Ordinal(20)] [RED("("minTimeToIdle")] 		public CFloat MinTimeToIdle { get; set;}

		[Ordinal(21)] [RED("("orientingInitial")] 		public CFloat OrientingInitial { get; set;}

		[Ordinal(22)] [RED("("initialImpulse")] 		public CFloat InitialImpulse { get; set;}

		[Ordinal(23)] [RED("("startedFromJump")] 		public CBool StartedFromJump { get; set;}

		[Ordinal(24)] [RED("("startedFromRoll")] 		public CBool StartedFromRoll { get; set;}

		[Ordinal(25)] [RED("("orientingSpeedMin")] 		public CFloat OrientingSpeedMin { get; set;}

		[Ordinal(26)] [RED("("orientingSpeedMax")] 		public CFloat OrientingSpeedMax { get; set;}

		[Ordinal(27)] [RED("("orientingMaxSlope")] 		public CFloat OrientingMaxSlope { get; set;}

		[Ordinal(28)] [RED("("timeToHardSlide")] 		public CFloat TimeToHardSlide { get; set;}

		[Ordinal(29)] [RED("("behGraphEventSlideHard")] 		public CName BehGraphEventSlideHard { get; set;}

		[Ordinal(30)] [RED("("requireSpeedToExit")] 		public CBool RequireSpeedToExit { get; set;}

		[Ordinal(31)] [RED("("speedToExitForward")] 		public CFloat SpeedToExitForward { get; set;}

		[Ordinal(32)] [RED("("speedToExitCenter")] 		public CFloat SpeedToExitCenter { get; set;}

		[Ordinal(33)] [RED("("speedToExitBackward")] 		public CFloat SpeedToExitBackward { get; set;}

		[Ordinal(34)] [RED("("exitingTimeMinSoft")] 		public CFloat ExitingTimeMinSoft { get; set;}

		[Ordinal(35)] [RED("("exitingTimeCur")] 		public CFloat ExitingTimeCur { get; set;}

		[Ordinal(36)] [RED("("exitingTimeTotal")] 		public CFloat ExitingTimeTotal { get; set;}

		[Ordinal(37)] [RED("("exitingTimeTotalInput")] 		public CFloat ExitingTimeTotalInput { get; set;}

		[Ordinal(38)] [RED("("stoppingFriction")] 		public CBool StoppingFriction { get; set;}

		[Ordinal(39)] [RED("("cooldownMax")] 		public CFloat CooldownMax { get; set;}

		[Ordinal(40)] [RED("("cooldownCur")] 		public CFloat CooldownCur { get; set;}

		[Ordinal(41)] [RED("("landCoolingDown")] 		public CBool LandCoolingDown { get; set;}

		[Ordinal(42)] [RED("("landCoolDownTime")] 		public CFloat LandCoolDownTime { get; set;}

		[Ordinal(43)] [RED("("fromJumpBehGraphEvent")] 		public CName FromJumpBehGraphEvent { get; set;}

		[Ordinal(44)] [RED("("fromRollBehGraphEvent")] 		public CName FromRollBehGraphEvent { get; set;}

		[Ordinal(45)] [RED("("jumpAllowed")] 		public CBool JumpAllowed { get; set;}

		[Ordinal(46)] [RED("("jumpCoolDownTime")] 		public CFloat JumpCoolDownTime { get; set;}

		[Ordinal(47)] [RED("("fallSpeedMaxConsidered")] 		public CFloat FallSpeedMaxConsidered { get; set;}

		[Ordinal(48)] [RED("("fallSpeedCoef")] 		public CFloat FallSpeedCoef { get; set;}

		[Ordinal(49)] [RED("("fallHorizImpulse")] 		public CFloat FallHorizImpulse { get; set;}

		[Ordinal(50)] [RED("("fallHorizImpulseCancel")] 		public CFloat FallHorizImpulseCancel { get; set;}

		[Ordinal(51)] [RED("("fallExtraVertImpulse")] 		public CFloat FallExtraVertImpulse { get; set;}

		[Ordinal(52)] [RED("("slidingPhysicsSpeed")] 		public CFloat SlidingPhysicsSpeed { get; set;}

		[Ordinal(53)] [RED("("movementParams")] 		public SSlidingMovementParams MovementParams { get; set;}

		[Ordinal(54)] [RED("("movementStoppingParams")] 		public SSlidingMovementParams MovementStoppingParams { get; set;}

		[Ordinal(55)] [RED("("usePhysics")] 		public CBool UsePhysics { get; set;}

		[Ordinal(56)] [RED("("slideDirectionDamped")] 		public Vector SlideDirectionDamped { get; set;}

		[Ordinal(57)] [RED("("smoothedDirBlendCoef")] 		public CFloat SmoothedDirBlendCoef { get; set;}

		[Ordinal(58)] [RED("("slideKills")] 		public CBool SlideKills { get; set;}

		[Ordinal(59)] [RED("("m_DeadB")] 		public CBool M_DeadB { get; set;}

		[Ordinal(60)] [RED("("toFallEnabled")] 		public CBool ToFallEnabled { get; set;}

		[Ordinal(61)] [RED("("toFallTimeCur")] 		public CFloat ToFallTimeCur { get; set;}

		[Ordinal(62)] [RED("("toConsiderFallTimeTotal")] 		public CFloat ToConsiderFallTimeTotal { get; set;}

		[Ordinal(63)] [RED("("toFallTimeTotal")] 		public CFloat ToFallTimeTotal { get; set;}

		[Ordinal(64)] [RED("("toFallSlopeCoefMin")] 		public CFloat ToFallSlopeCoefMin { get; set;}

		[Ordinal(65)] [RED("("toFallSlopeSpeedMin")] 		public CFloat ToFallSlopeSpeedMin { get; set;}

		[Ordinal(66)] [RED("("toFallSlopeCoef")] 		public CFloat ToFallSlopeCoef { get; set;}

		[Ordinal(67)] [RED("("toFallSpeedCoef")] 		public CFloat ToFallSpeedCoef { get; set;}

		[Ordinal(68)] [RED("("toFallRecoverCoef")] 		public CFloat ToFallRecoverCoef { get; set;}

		[Ordinal(69)] [RED("("toFallCameraLevel")] 		public CInt32 ToFallCameraLevel { get; set;}

		[Ordinal(70)] [RED("("cameraShakeState")] 		public CEnum<ESlideCameraShakeState> CameraShakeState { get; set;}

		[Ordinal(71)] [RED("("cameraAnimName")] 		public CName CameraAnimName { get; set;}

		[Ordinal(72)] [RED("("behTripToDeath")] 		public CName BehTripToDeath { get; set;}

		[Ordinal(73)] [RED("("behHeightVar")] 		public CName BehHeightVar { get; set;}

		[Ordinal(74)] [RED("("behInclinationVar")] 		public CName BehInclinationVar { get; set;}

		[Ordinal(75)] [RED("("behTurnVar")] 		public CName BehTurnVar { get; set;}

		[Ordinal(76)] [RED("("behAccelVar")] 		public CName BehAccelVar { get; set;}

		[Ordinal(77)] [RED("("behRightFootForwardVar")] 		public CName BehRightFootForwardVar { get; set;}

		[Ordinal(78)] [RED("("inclinationBlendSpeed")] 		public CFloat InclinationBlendSpeed { get; set;}

		[Ordinal(79)] [RED("("inclinationStart")] 		public CFloat InclinationStart { get; set;}

		[Ordinal(80)] [RED("("turnInclinationMax")] 		public CFloat TurnInclinationMax { get; set;}

		[Ordinal(81)] [RED("("turnInclinationBlend")] 		public CFloat TurnInclinationBlend { get; set;}

		[Ordinal(82)] [RED("("turnInclinationCur")] 		public CFloat TurnInclinationCur { get; set;}

		[Ordinal(83)] [RED("("inclinationEnterTimeMax")] 		public CFloat InclinationEnterTimeMax { get; set;}

		[Ordinal(84)] [RED("("inclinationEnterTimeCur")] 		public CFloat InclinationEnterTimeCur { get; set;}

		[Ordinal(85)] [RED("("inclination")] 		public CFloat Inclination { get; set;}

		[Ordinal(86)] [RED("("behForwardVar")] 		public CName BehForwardVar { get; set;}

		[Ordinal(87)] [RED("("behSlideRestart")] 		public CName BehSlideRestart { get; set;}

		[Ordinal(88)] [RED("("behSlideEnd")] 		public CName BehSlideEnd { get; set;}

		[Ordinal(89)] [RED("("behSlideEndRun")] 		public CName BehSlideEndRun { get; set;}

		[Ordinal(90)] [RED("("behSlideEndIdle")] 		public CName BehSlideEndIdle { get; set;}

		[Ordinal(91)] [RED("("boneToStickName")] 		public CName BoneToStickName { get; set;}

		[Ordinal(92)] [RED("("boneToStickId")] 		public CInt32 BoneToStickId { get; set;}

		[Ordinal(93)] [RED("("animEventHardSliding")] 		public CName AnimEventHardSliding { get; set;}

		[Ordinal(94)] [RED("("lockedOnHardSliding")] 		public CBool LockedOnHardSliding { get; set;}

		[Ordinal(95)] [RED("("particlesEnabled")] 		public CBool ParticlesEnabled { get; set;}

		[Ordinal(96)] [RED("("particlesName")] 		public CName ParticlesName { get; set;}

		[Ordinal(97)] [RED("("boneLeftFoot")] 		public CName BoneLeftFoot { get; set;}

		[Ordinal(98)] [RED("("boneRightFoot")] 		public CName BoneRightFoot { get; set;}

		[Ordinal(99)] [RED("("timeToRespawnParticlesCur")] 		public CFloat TimeToRespawnParticlesCur { get; set;}

		[Ordinal(100)] [RED("("timeToRespawnParticlesMax")] 		public CFloat TimeToRespawnParticlesMax { get; set;}

		public CExplorationStateSlide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSlide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}