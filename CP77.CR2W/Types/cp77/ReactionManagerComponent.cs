using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("NPCRadius")] public CFloat NPCRadius { get; set; }
		[Ordinal(1)]  [RED("activeReaction")] public CHandle<AIReactionData> ActiveReaction { get; set; }
		[Ordinal(2)]  [RED("aiRole")] public CEnum<EAIRole> AiRole { get; set; }
		[Ordinal(3)]  [RED("backOffInProgress")] public CBool BackOffInProgress { get; set; }
		[Ordinal(4)]  [RED("backOffTimestamp")] public CFloat BackOffTimestamp { get; set; }
		[Ordinal(5)]  [RED("bumpReactionInProgress")] public CBool BumpReactionInProgress { get; set; }
		[Ordinal(6)]  [RED("bumpTimestamp")] public CFloat BumpTimestamp { get; set; }
		[Ordinal(7)]  [RED("bumpTriggerDistanceBufferCrouched")] public CFloat BumpTriggerDistanceBufferCrouched { get; set; }
		[Ordinal(8)]  [RED("bumpTriggerDistanceBufferMounted")] public CFloat BumpTriggerDistanceBufferMounted { get; set; }
		[Ordinal(9)]  [RED("bumpedRecently")] public CInt32 BumpedRecently { get; set; }
		[Ordinal(10)]  [RED("cacheSecuritySysOutput")] public CHandle<SecuritySystemOutput> CacheSecuritySysOutput { get; set; }
		[Ordinal(11)]  [RED("callingPoliceID")] public gameDelayID CallingPoliceID { get; set; }
		[Ordinal(12)]  [RED("checkComfortZoneEventId")] public gameDelayID CheckComfortZoneEventId { get; set; }
		[Ordinal(13)]  [RED("comfortZoneTimestamp")] public CFloat ComfortZoneTimestamp { get; set; }
		[Ordinal(14)]  [RED("createThreshold")] public CBool CreateThreshold { get; set; }
		[Ordinal(15)]  [RED("crowdAimingReactionDistance")] public CFloat CrowdAimingReactionDistance { get; set; }
		[Ordinal(16)]  [RED("crowdFearStage")] public CEnum<gameFearStage> CrowdFearStage { get; set; }
		[Ordinal(17)]  [RED("currentStealthStimThresholdValue")] public CInt32 CurrentStealthStimThresholdValue { get; set; }
		[Ordinal(18)]  [RED("currentStimThresholdValue")] public CInt32 CurrentStimThresholdValue { get; set; }
		[Ordinal(19)]  [RED("deadBodyInvestigators")] public CArray<entEntityID> DeadBodyInvestigators { get; set; }
		[Ordinal(20)]  [RED("deadBodyStartingPosition")] public Vector4 DeadBodyStartingPosition { get; set; }
		[Ordinal(21)]  [RED("delay")] public Vector2 Delay { get; set; }
		[Ordinal(22)]  [RED("delayDetectionEventID")] public gameDelayID DelayDetectionEventID { get; set; }
		[Ordinal(23)]  [RED("delayReactionEventID")] public gameDelayID DelayReactionEventID { get; set; }
		[Ordinal(24)]  [RED("delayStimEventID")] public gameDelayID DelayStimEventID { get; set; }
		[Ordinal(25)]  [RED("desiredFearPhase")] public CInt32 DesiredFearPhase { get; set; }
		[Ordinal(26)]  [RED("desiredReaction")] public CHandle<AIReactionData> DesiredReaction { get; set; }
		[Ordinal(27)]  [RED("disturbComfortZoneAggressiveEventId")] public gameDelayID DisturbComfortZoneAggressiveEventId { get; set; }
		[Ordinal(28)]  [RED("disturbComfortZoneEventId")] public gameDelayID DisturbComfortZoneEventId { get; set; }
		[Ordinal(29)]  [RED("disturbingComfortZoneInProgress")] public CBool DisturbingComfortZoneInProgress { get; set; }
		[Ordinal(30)]  [RED("entereProximityRecently")] public CInt32 EntereProximityRecently { get; set; }
		[Ordinal(31)]  [RED("environmentalHazards")] public CArray<CHandle<senseStimuliEvent>> EnvironmentalHazards { get; set; }
		[Ordinal(32)]  [RED("environmentalHazardsDelayIDs")] public CArray<gameDelayID> EnvironmentalHazardsDelayIDs { get; set; }
		[Ordinal(33)]  [RED("exitWorkspotAim")] public Vector2 ExitWorkspotAim { get; set; }
		[Ordinal(34)]  [RED("exitWorkspotSequenceEventId")] public gameDelayID ExitWorkspotSequenceEventId { get; set; }
		[Ordinal(35)]  [RED("facialCooldown")] public CFloat FacialCooldown { get; set; }
		[Ordinal(36)]  [RED("fastWalk")] public CBool FastWalk { get; set; }
		[Ordinal(37)]  [RED("fearInPlaceAroundDistance")] public CFloat FearInPlaceAroundDistance { get; set; }
		[Ordinal(38)]  [RED("fearLocomotionWrapper")] public CBool FearLocomotionWrapper { get; set; }
		[Ordinal(39)]  [RED("fearToIdleDistance")] public Vector2 FearToIdleDistance { get; set; }
		[Ordinal(40)]  [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(41)]  [RED("ignoreList")] public CArray<entEntityID> IgnoreList { get; set; }
		[Ordinal(42)]  [RED("inCrowd")] public CBool InCrowd { get; set; }
		[Ordinal(43)]  [RED("inPendingBehavior")] public CBool InPendingBehavior { get; set; }
		[Ordinal(44)]  [RED("inProcess")] public CBool InProcess { get; set; }
		[Ordinal(45)]  [RED("inReactionSequence")] public CBool InReactionSequence { get; set; }
		[Ordinal(46)]  [RED("inTrafficLane")] public CBool InTrafficLane { get; set; }
		[Ordinal(47)]  [RED("initCrowd")] public CBool InitCrowd { get; set; }
		[Ordinal(48)]  [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(49)]  [RED("investigationList")] public CArray<StimEventData> InvestigationList { get; set; }
		[Ordinal(50)]  [RED("isAlertedByDeadBody")] public CBool IsAlertedByDeadBody { get; set; }
		[Ordinal(51)]  [RED("isInCrosswalk")] public CBool IsInCrosswalk { get; set; }
		[Ordinal(52)]  [RED("lookatEvent")] public CHandle<entLookAtAddEvent> LookatEvent { get; set; }
		[Ordinal(53)]  [RED("lookatRepeat")] public CBool LookatRepeat { get; set; }
		[Ordinal(54)]  [RED("ovefloodCooldown")] public CFloat OvefloodCooldown { get; set; }
		[Ordinal(55)]  [RED("owner_id")] public entEntityID Owner_id { get; set; }
		[Ordinal(56)]  [RED("pendingBehaviorCb")] public CUInt32 PendingBehaviorCb { get; set; }
		[Ordinal(57)]  [RED("pendingReaction")] public CHandle<AIReactionData> PendingReaction { get; set; }
		[Ordinal(58)]  [RED("personalities")] public CArray<CEnum<gamedataStatType>> Personalities { get; set; }
		[Ordinal(59)]  [RED("playerProximity")] public CBool PlayerProximity { get; set; }
		[Ordinal(60)]  [RED("presetName")] public CName PresetName { get; set; }
		[Ordinal(61)]  [RED("previousFearPhase")] public CInt32 PreviousFearPhase { get; set; }
		[Ordinal(62)]  [RED("proximityLookatEventId")] public gameDelayID ProximityLookatEventId { get; set; }
		[Ordinal(63)]  [RED("puppetReactionBlackboard")] public CHandle<gameIBlackboard> PuppetReactionBlackboard { get; set; }
		[Ordinal(64)]  [RED("reactionCache")] public CArray<CHandle<AIReactionData>> ReactionCache { get; set; }
		[Ordinal(65)]  [RED("reactionPreset")] public CHandle<gamedataReactionPreset_Record> ReactionPreset { get; set; }
		[Ordinal(66)]  [RED("receivedStimType")] public CEnum<gamedataStimType> ReceivedStimType { get; set; }
		[Ordinal(67)]  [RED("resetFacialEventId")] public gameDelayID ResetFacialEventId { get; set; }
		[Ordinal(68)]  [RED("resetReactionDataID")] public gameDelayID ResetReactionDataID { get; set; }
		[Ordinal(69)]  [RED("spreadingFearEventId")] public gameDelayID SpreadingFearEventId { get; set; }
		[Ordinal(70)]  [RED("stanceState")] public CEnum<gamedataNPCStanceState> StanceState { get; set; }
		[Ordinal(71)]  [RED("stealthTimeStampThreshold")] public CFloat StealthTimeStampThreshold { get; set; }
		[Ordinal(72)]  [RED("stimuliCache")] public CArray<CHandle<senseStimuliEvent>> StimuliCache { get; set; }
		[Ordinal(73)]  [RED("stolenVehicle")] public wCHandle<vehicleBaseObject> StolenVehicle { get; set; }
		[Ordinal(74)]  [RED("successfulFearDeescalation")] public CFloat SuccessfulFearDeescalation { get; set; }
		[Ordinal(75)]  [RED("timeStampThreshold")] public CFloat TimeStampThreshold { get; set; }
		[Ordinal(76)]  [RED("updateByActive")] public CBool UpdateByActive { get; set; }
		[Ordinal(77)]  [RED("willingToCallPolice")] public CBool WillingToCallPolice { get; set; }
		[Ordinal(78)]  [RED("workspotReactionPlayed")] public CBool WorkspotReactionPlayed { get; set; }

		public ReactionManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
