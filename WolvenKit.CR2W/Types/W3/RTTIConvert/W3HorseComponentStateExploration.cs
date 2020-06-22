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
		[RED("parentActor")] 		public CHandle<CActor> ParentActor { get; set;}

		[RED("isStopping")] 		public CBool IsStopping { get; set;}

		[RED("isSlowlyStopping")] 		public CBool IsSlowlyStopping { get; set;}

		[RED("destSpeed")] 		public CFloat DestSpeed { get; set;}

		[RED("currSpeed")] 		public CFloat CurrSpeed { get; set;}

		[RED("staminaCooldown")] 		public CFloat StaminaCooldown { get; set;}

		[RED("staminaCooldownTimer")] 		public CFloat StaminaCooldownTimer { get; set;}

		[RED("staminaBreak")] 		public CBool StaminaBreak { get; set;}

		[RED("speedImpulseTimestamp")] 		public CFloat SpeedImpulseTimestamp { get; set;}

		[RED("dismountRequest")] 		public CBool DismountRequest { get; set;}

		[RED("roadFollowBlock")] 		public CFloat RoadFollowBlock { get; set;}

		[RED("speedLocks", 2,0)] 		public CArray<CName> SpeedLocks { get; set;}

		[RED("speedRestriction")] 		public CFloat SpeedRestriction { get; set;}

		[RED("useSimpleStaminaManagement")] 		public CBool UseSimpleStaminaManagement { get; set;}

		[RED("inclinationCheckCollisionGroups", 2,0)] 		public CArray<CName> InclinationCheckCollisionGroups { get; set;}

		[RED("waterCheckCollisionGroups", 2,0)] 		public CArray<CName> WaterCheckCollisionGroups { get; set;}

		[RED("threatSum")] 		public CFloat ThreatSum { get; set;}

		[RED("triedDoubleTap")] 		public CBool TriedDoubleTap { get; set;}

		[RED("mac")] 		public CHandle<CMovingAgentComponent> Mac { get; set;}

		[RED("isFollowingRoad")] 		public CBool IsFollowingRoad { get; set;}

		[RED("shouldGoToCanterAfterStop")] 		public CBool ShouldGoToCanterAfterStop { get; set;}

		[RED("grassCollider")] 		public CHandle<CComponent> GrassCollider { get; set;}

		[RED("currSpeedSound")] 		public CFloat CurrSpeedSound { get; set;}

		[RED("desiredSpeedSound")] 		public CFloat DesiredSpeedSound { get; set;}

		[RED("jumpStartPos")] 		public Vector JumpStartPos { get; set;}

		[RED("jumpEndPos")] 		public Vector JumpEndPos { get; set;}

		[RED("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[RED("MIN_SPEED")] 		public CFloat MIN_SPEED { get; set;}

		[RED("SLOW_SPEED")] 		public CFloat SLOW_SPEED { get; set;}

		[RED("WALK_SPEED")] 		public CFloat WALK_SPEED { get; set;}

		[RED("TROT_SPEED")] 		public CFloat TROT_SPEED { get; set;}

		[RED("GALLOP_SPEED")] 		public CFloat GALLOP_SPEED { get; set;}

		[RED("CANTER_SPEED")] 		public CFloat CANTER_SPEED { get; set;}

		[RED("threatApplicationTimestamp")] 		public CFloat ThreatApplicationTimestamp { get; set;}

		[RED("dismountFinishedTimeStamp")] 		public CFloat DismountFinishedTimeStamp { get; set;}

		[RED("timeAfterDismountFinished")] 		public CFloat TimeAfterDismountFinished { get; set;}

		[RED("cachedCombatAction")] 		public CEnum<EVehicleCombatAction> CachedCombatAction { get; set;}

		[RED("stopRequest")] 		public CBool StopRequest { get; set;}

		[RED("isRefusingToGo")] 		public CBool IsRefusingToGo { get; set;}

		[RED("collisionAnimTimestamp")] 		public CFloat CollisionAnimTimestamp { get; set;}

		[RED("collsionAnimCooldown")] 		public CFloat CollsionAnimCooldown { get; set;}

		[RED("prediction")] 		public CHandle<CHorsePrediction> Prediction { get; set;}

		[RED("INPUTMAG_TROT")] 		public CFloat INPUTMAG_TROT { get; set;}

		[RED("INPUTMAG_WALK")] 		public CFloat INPUTMAG_WALK { get; set;}

		[RED("HEADING_WT")] 		public CFloat HEADING_WT { get; set;}

		[RED("INPUT_WT")] 		public CFloat INPUT_WT { get; set;}

		[RED("NAVDATA_RADIUS")] 		public CFloat NAVDATA_RADIUS { get; set;}

		[RED("NAVDATA_LENGTH_MOD_TROT")] 		public CFloat NAVDATA_LENGTH_MOD_TROT { get; set;}

		[RED("NAVDATA_LENGTH_MOD_GALLOP")] 		public CFloat NAVDATA_LENGTH_MOD_GALLOP { get; set;}

		[RED("NAVDATA_LENGTH_MOD_CANTER")] 		public CFloat NAVDATA_LENGTH_MOD_CANTER { get; set;}

		[RED("INCLINATION_MAX_ANGLE")] 		public CFloat INCLINATION_MAX_ANGLE { get; set;}

		[RED("INCLINATION_BASE_DIST")] 		public CFloat INCLINATION_BASE_DIST { get; set;}

		[RED("INCLINATION_TESTS_COUNT_TROT")] 		public CInt32 INCLINATION_TESTS_COUNT_TROT { get; set;}

		[RED("INCLINATION_TESTS_COUNT_GALLOP")] 		public CInt32 INCLINATION_TESTS_COUNT_GALLOP { get; set;}

		[RED("INCLINATION_TESTS_COUNT_CANTER")] 		public CInt32 INCLINATION_TESTS_COUNT_CANTER { get; set;}

		[RED("INCLINATION_Z_OFFSET")] 		public CFloat INCLINATION_Z_OFFSET { get; set;}

		[RED("WATER_MAX_DEPTH")] 		public CFloat WATER_MAX_DEPTH { get; set;}

		[RED("WATER_DIST_TROT")] 		public CFloat WATER_DIST_TROT { get; set;}

		[RED("WATER_DIST_GALLOP")] 		public CFloat WATER_DIST_GALLOP { get; set;}

		[RED("WATER_DIST_CANTER")] 		public CFloat WATER_DIST_CANTER { get; set;}

		[RED("NAVTEST_RADIUS")] 		public CFloat NAVTEST_RADIUS { get; set;}

		[RED("rl")] 		public CFloat Rl { get; set;}

		[RED("fb")] 		public CFloat Fb { get; set;}

		[RED("startSlidingTimeStamp")] 		public CFloat StartSlidingTimeStamp { get; set;}

		[RED("notSlidingTimeStamp")] 		public CFloat NotSlidingTimeStamp { get; set;}

		[RED("SLIDING_MINSLIDINGCOEF")] 		public CFloat SLIDING_MINSLIDINGCOEF { get; set;}

		[RED("SLIDING_MAXSLIDINTIME")] 		public CFloat SLIDING_MAXSLIDINTIME { get; set;}

		[RED("SLIDING_MAXROTATIONSPEED")] 		public CFloat SLIDING_MAXROTATIONSPEED { get; set;}

		[RED("requestJump")] 		public CBool RequestJump { get; set;}

		[RED("isInJumpAnim")] 		public CBool IsInJumpAnim { get; set;}

		[RED("startTestingLanding")] 		public CBool StartTestingLanding { get; set;}

		[RED("maintainSpeedTimer")] 		public CFloat MaintainSpeedTimer { get; set;}

		[RED("speedTimeoutValue")] 		public CFloat SpeedTimeoutValue { get; set;}

		[RED("accelerateTimestamp")] 		public CFloat AccelerateTimestamp { get; set;}

		[RED("DOUBLE_TAP_WINDOW")] 		public CFloat DOUBLE_TAP_WINDOW { get; set;}

		[RED("jumpPressTimestamp")] 		public CFloat JumpPressTimestamp { get; set;}

		[RED("voicsetTimeStamp")] 		public CFloat VoicsetTimeStamp { get; set;}

		[RED("voicsetFasterTimeStamp")] 		public CFloat VoicsetFasterTimeStamp { get; set;}

		[RED("voicsetSlowerTimeSTamp")] 		public CFloat VoicsetSlowerTimeSTamp { get; set;}

		[RED("VOICESET_COOLDOWN")] 		public CFloat VOICESET_COOLDOWN { get; set;}

		[RED("VOICESET_FASTER_COOLDOWN")] 		public CFloat VOICESET_FASTER_COOLDOWN { get; set;}

		[RED("VOICESET_SLOWER_COOLDOWN")] 		public CFloat VOICESET_SLOWER_COOLDOWN { get; set;}

		public W3HorseComponentStateExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseComponentStateExploration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}