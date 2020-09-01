using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HorseComponentStateExploration : CScriptableState
	{
		[Ordinal(0)] [RED("("parentActor")] 		public CHandle<CActor> ParentActor { get; set;}

		[Ordinal(0)] [RED("("isStopping")] 		public CBool IsStopping { get; set;}

		[Ordinal(0)] [RED("("isSlowlyStopping")] 		public CBool IsSlowlyStopping { get; set;}

		[Ordinal(0)] [RED("("destSpeed")] 		public CFloat DestSpeed { get; set;}

		[Ordinal(0)] [RED("("currSpeed")] 		public CFloat CurrSpeed { get; set;}

		[Ordinal(0)] [RED("("staminaCooldown")] 		public CFloat StaminaCooldown { get; set;}

		[Ordinal(0)] [RED("("staminaCooldownTimer")] 		public CFloat StaminaCooldownTimer { get; set;}

		[Ordinal(0)] [RED("("staminaBreak")] 		public CBool StaminaBreak { get; set;}

		[Ordinal(0)] [RED("("speedImpulseTimestamp")] 		public CFloat SpeedImpulseTimestamp { get; set;}

		[Ordinal(0)] [RED("("dismountRequest")] 		public CBool DismountRequest { get; set;}

		[Ordinal(0)] [RED("("roadFollowBlock")] 		public CFloat RoadFollowBlock { get; set;}

		[Ordinal(0)] [RED("("speedLocks", 2,0)] 		public CArray<CName> SpeedLocks { get; set;}

		[Ordinal(0)] [RED("("speedRestriction")] 		public CFloat SpeedRestriction { get; set;}

		[Ordinal(0)] [RED("("useSimpleStaminaManagement")] 		public CBool UseSimpleStaminaManagement { get; set;}

		[Ordinal(0)] [RED("("inclinationCheckCollisionGroups", 2,0)] 		public CArray<CName> InclinationCheckCollisionGroups { get; set;}

		[Ordinal(0)] [RED("("waterCheckCollisionGroups", 2,0)] 		public CArray<CName> WaterCheckCollisionGroups { get; set;}

		[Ordinal(0)] [RED("("threatSum")] 		public CFloat ThreatSum { get; set;}

		[Ordinal(0)] [RED("("triedDoubleTap")] 		public CBool TriedDoubleTap { get; set;}

		[Ordinal(0)] [RED("("mac")] 		public CHandle<CMovingAgentComponent> Mac { get; set;}

		[Ordinal(0)] [RED("("isFollowingRoad")] 		public CBool IsFollowingRoad { get; set;}

		[Ordinal(0)] [RED("("shouldGoToCanterAfterStop")] 		public CBool ShouldGoToCanterAfterStop { get; set;}

		[Ordinal(0)] [RED("("grassCollider")] 		public CHandle<CComponent> GrassCollider { get; set;}

		[Ordinal(0)] [RED("("currSpeedSound")] 		public CFloat CurrSpeedSound { get; set;}

		[Ordinal(0)] [RED("("desiredSpeedSound")] 		public CFloat DesiredSpeedSound { get; set;}

		[Ordinal(0)] [RED("("jumpStartPos")] 		public Vector JumpStartPos { get; set;}

		[Ordinal(0)] [RED("("jumpEndPos")] 		public Vector JumpEndPos { get; set;}

		[Ordinal(0)] [RED("("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[Ordinal(0)] [RED("("MIN_SPEED")] 		public CFloat MIN_SPEED { get; set;}

		[Ordinal(0)] [RED("("SLOW_SPEED")] 		public CFloat SLOW_SPEED { get; set;}

		[Ordinal(0)] [RED("("WALK_SPEED")] 		public CFloat WALK_SPEED { get; set;}

		[Ordinal(0)] [RED("("TROT_SPEED")] 		public CFloat TROT_SPEED { get; set;}

		[Ordinal(0)] [RED("("GALLOP_SPEED")] 		public CFloat GALLOP_SPEED { get; set;}

		[Ordinal(0)] [RED("("CANTER_SPEED")] 		public CFloat CANTER_SPEED { get; set;}

		[Ordinal(0)] [RED("("threatApplicationTimestamp")] 		public CFloat ThreatApplicationTimestamp { get; set;}

		[Ordinal(0)] [RED("("dismountFinishedTimeStamp")] 		public CFloat DismountFinishedTimeStamp { get; set;}

		[Ordinal(0)] [RED("("timeAfterDismountFinished")] 		public CFloat TimeAfterDismountFinished { get; set;}

		[Ordinal(0)] [RED("("cachedCombatAction")] 		public CEnum<EVehicleCombatAction> CachedCombatAction { get; set;}

		[Ordinal(0)] [RED("("stopRequest")] 		public CBool StopRequest { get; set;}

		[Ordinal(0)] [RED("("isRefusingToGo")] 		public CBool IsRefusingToGo { get; set;}

		[Ordinal(0)] [RED("("collisionAnimTimestamp")] 		public CFloat CollisionAnimTimestamp { get; set;}

		[Ordinal(0)] [RED("("collsionAnimCooldown")] 		public CFloat CollsionAnimCooldown { get; set;}

		[Ordinal(0)] [RED("("prediction")] 		public CHandle<CHorsePrediction> Prediction { get; set;}

		[Ordinal(0)] [RED("("INPUTMAG_TROT")] 		public CFloat INPUTMAG_TROT { get; set;}

		[Ordinal(0)] [RED("("INPUTMAG_WALK")] 		public CFloat INPUTMAG_WALK { get; set;}

		[Ordinal(0)] [RED("("HEADING_WT")] 		public CFloat HEADING_WT { get; set;}

		[Ordinal(0)] [RED("("INPUT_WT")] 		public CFloat INPUT_WT { get; set;}

		[Ordinal(0)] [RED("("NAVDATA_RADIUS")] 		public CFloat NAVDATA_RADIUS { get; set;}

		[Ordinal(0)] [RED("("NAVDATA_LENGTH_MOD_TROT")] 		public CFloat NAVDATA_LENGTH_MOD_TROT { get; set;}

		[Ordinal(0)] [RED("("NAVDATA_LENGTH_MOD_GALLOP")] 		public CFloat NAVDATA_LENGTH_MOD_GALLOP { get; set;}

		[Ordinal(0)] [RED("("NAVDATA_LENGTH_MOD_CANTER")] 		public CFloat NAVDATA_LENGTH_MOD_CANTER { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_MAX_ANGLE")] 		public CFloat INCLINATION_MAX_ANGLE { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_BASE_DIST")] 		public CFloat INCLINATION_BASE_DIST { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_TESTS_COUNT_TROT")] 		public CInt32 INCLINATION_TESTS_COUNT_TROT { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_TESTS_COUNT_GALLOP")] 		public CInt32 INCLINATION_TESTS_COUNT_GALLOP { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_TESTS_COUNT_CANTER")] 		public CInt32 INCLINATION_TESTS_COUNT_CANTER { get; set;}

		[Ordinal(0)] [RED("("INCLINATION_Z_OFFSET")] 		public CFloat INCLINATION_Z_OFFSET { get; set;}

		[Ordinal(0)] [RED("("WATER_MAX_DEPTH")] 		public CFloat WATER_MAX_DEPTH { get; set;}

		[Ordinal(0)] [RED("("WATER_DIST_TROT")] 		public CFloat WATER_DIST_TROT { get; set;}

		[Ordinal(0)] [RED("("WATER_DIST_GALLOP")] 		public CFloat WATER_DIST_GALLOP { get; set;}

		[Ordinal(0)] [RED("("WATER_DIST_CANTER")] 		public CFloat WATER_DIST_CANTER { get; set;}

		[Ordinal(0)] [RED("("NAVTEST_RADIUS")] 		public CFloat NAVTEST_RADIUS { get; set;}

		[Ordinal(0)] [RED("("rl")] 		public CFloat Rl { get; set;}

		[Ordinal(0)] [RED("("fb")] 		public CFloat Fb { get; set;}

		[Ordinal(0)] [RED("("startSlidingTimeStamp")] 		public CFloat StartSlidingTimeStamp { get; set;}

		[Ordinal(0)] [RED("("notSlidingTimeStamp")] 		public CFloat NotSlidingTimeStamp { get; set;}

		[Ordinal(0)] [RED("("SLIDING_MINSLIDINGCOEF")] 		public CFloat SLIDING_MINSLIDINGCOEF { get; set;}

		[Ordinal(0)] [RED("("SLIDING_MAXSLIDINTIME")] 		public CFloat SLIDING_MAXSLIDINTIME { get; set;}

		[Ordinal(0)] [RED("("SLIDING_MAXROTATIONSPEED")] 		public CFloat SLIDING_MAXROTATIONSPEED { get; set;}

		[Ordinal(0)] [RED("("requestJump")] 		public CBool RequestJump { get; set;}

		[Ordinal(0)] [RED("("isInJumpAnim")] 		public CBool IsInJumpAnim { get; set;}

		[Ordinal(0)] [RED("("startTestingLanding")] 		public CBool StartTestingLanding { get; set;}

		[Ordinal(0)] [RED("("maintainSpeedTimer")] 		public CFloat MaintainSpeedTimer { get; set;}

		[Ordinal(0)] [RED("("speedTimeoutValue")] 		public CFloat SpeedTimeoutValue { get; set;}

		[Ordinal(0)] [RED("("accelerateTimestamp")] 		public CFloat AccelerateTimestamp { get; set;}

		[Ordinal(0)] [RED("("DOUBLE_TAP_WINDOW")] 		public CFloat DOUBLE_TAP_WINDOW { get; set;}

		[Ordinal(0)] [RED("("jumpPressTimestamp")] 		public CFloat JumpPressTimestamp { get; set;}

		[Ordinal(0)] [RED("("voicsetTimeStamp")] 		public CFloat VoicsetTimeStamp { get; set;}

		[Ordinal(0)] [RED("("voicsetFasterTimeStamp")] 		public CFloat VoicsetFasterTimeStamp { get; set;}

		[Ordinal(0)] [RED("("voicsetSlowerTimeSTamp")] 		public CFloat VoicsetSlowerTimeSTamp { get; set;}

		[Ordinal(0)] [RED("("VOICESET_COOLDOWN")] 		public CFloat VOICESET_COOLDOWN { get; set;}

		[Ordinal(0)] [RED("("VOICESET_FASTER_COOLDOWN")] 		public CFloat VOICESET_FASTER_COOLDOWN { get; set;}

		[Ordinal(0)] [RED("("VOICESET_SLOWER_COOLDOWN")] 		public CFloat VOICESET_SLOWER_COOLDOWN { get; set;}

		public W3HorseComponentStateExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseComponentStateExploration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}