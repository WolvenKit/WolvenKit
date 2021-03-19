using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerComponent : gameScriptableComponent
	{
		private CHandle<AIReactionData> _activeReaction;
		private CHandle<AIReactionData> _desiredReaction;
		private CArray<CHandle<senseStimuliEvent>> _stimuliCache;
		private CArray<CHandle<AIReactionData>> _reactionCache;
		private CHandle<gamedataReactionPreset_Record> _reactionPreset;
		private CHandle<gameIBlackboard> _puppetReactionBlackboard;
		private CEnum<gamedataStimType> _receivedStimType;
		private CBool _inCrowd;
		private CBool _inTrafficLane;
		private CInt32 _desiredFearPhase;
		private CInt32 _previousFearPhase;
		private CFloat _nPCRadius;
		private CFloat _bumpTriggerDistanceBufferMounted;
		private CFloat _bumpTriggerDistanceBufferCrouched;
		private gameDelayID _delayReactionEventID;
		private Vector2 _delay;
		private gameDelayID _delayDetectionEventID;
		private gameDelayID _delayStimEventID;
		private gameDelayID _resetReactionDataID;
		private gameDelayID _callingPoliceID;
		private CHandle<entLookAtAddEvent> _lookatEvent;
		private CArray<entEntityID> _ignoreList;
		private CArray<StimEventData> _investigationList;
		private CHandle<AIReactionData> _pendingReaction;
		private CFloat _ovefloodCooldown;
		private CEnum<gamedataNPCStanceState> _stanceState;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CEnum<EAIRole> _aiRole;
		private CUInt32 _pendingBehaviorCb;
		private CBool _inPendingBehavior;
		private CHandle<SecuritySystemOutput> _cacheSecuritySysOutput;
		private CArray<CHandle<senseStimuliEvent>> _environmentalHazards;
		private CArray<gameDelayID> _environmentalHazardsDelayIDs;
		private wCHandle<vehicleBaseObject> _stolenVehicle;
		private CBool _isAlertedByDeadBody;
		private CBool _isInCrosswalk;
		private entEntityID _owner_id;
		private CName _presetName;
		private CBool _inProcess;
		private CBool _updateByActive;
		private CArray<CEnum<gamedataStatType>> _personalities;
		private CBool _workspotReactionPlayed;
		private CBool _inReactionSequence;
		private CBool _playerProximity;
		private Vector2 _fearToIdleDistance;
		private Vector2 _exitWorkspotAim;
		private CInt32 _bumpedRecently;
		private CFloat _bumpTimestamp;
		private CBool _bumpReactionInProgress;
		private CFloat _crowdAimingReactionDistance;
		private CFloat _fearInPlaceAroundDistance;
		private CBool _lookatRepeat;
		private CBool _disturbingComfortZoneInProgress;
		private CInt32 _entereProximityRecently;
		private CFloat _comfortZoneTimestamp;
		private gameDelayID _disturbComfortZoneEventId;
		private gameDelayID _checkComfortZoneEventId;
		private gameDelayID _spreadingFearEventId;
		private gameDelayID _proximityLookatEventId;
		private gameDelayID _resetFacialEventId;
		private gameDelayID _exitWorkspotSequenceEventId;
		private CBool _fastWalk;
		private CBool _createThreshold;
		private CBool _initialized;
		private CBool _initCrowd;
		private CFloat _facialCooldown;
		private gameDelayID _disturbComfortZoneAggressiveEventId;
		private CBool _backOffInProgress;
		private CFloat _backOffTimestamp;
		private CEnum<gameFearStage> _crowdFearStage;
		private CBool _fearLocomotionWrapper;
		private CFloat _successfulFearDeescalation;
		private CBool _willingToCallPolice;
		private CArray<entEntityID> _deadBodyInvestigators;
		private Vector4 _deadBodyStartingPosition;
		private CInt32 _currentStimThresholdValue;
		private CFloat _timeStampThreshold;
		private CInt32 _currentStealthStimThresholdValue;
		private CFloat _stealthTimeStampThreshold;

		[Ordinal(5)] 
		[RED("activeReaction")] 
		public CHandle<AIReactionData> ActiveReaction
		{
			get => GetProperty(ref _activeReaction);
			set => SetProperty(ref _activeReaction, value);
		}

		[Ordinal(6)] 
		[RED("desiredReaction")] 
		public CHandle<AIReactionData> DesiredReaction
		{
			get => GetProperty(ref _desiredReaction);
			set => SetProperty(ref _desiredReaction, value);
		}

		[Ordinal(7)] 
		[RED("stimuliCache")] 
		public CArray<CHandle<senseStimuliEvent>> StimuliCache
		{
			get => GetProperty(ref _stimuliCache);
			set => SetProperty(ref _stimuliCache, value);
		}

		[Ordinal(8)] 
		[RED("reactionCache")] 
		public CArray<CHandle<AIReactionData>> ReactionCache
		{
			get => GetProperty(ref _reactionCache);
			set => SetProperty(ref _reactionCache, value);
		}

		[Ordinal(9)] 
		[RED("reactionPreset")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPreset
		{
			get => GetProperty(ref _reactionPreset);
			set => SetProperty(ref _reactionPreset, value);
		}

		[Ordinal(10)] 
		[RED("puppetReactionBlackboard")] 
		public CHandle<gameIBlackboard> PuppetReactionBlackboard
		{
			get => GetProperty(ref _puppetReactionBlackboard);
			set => SetProperty(ref _puppetReactionBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("receivedStimType")] 
		public CEnum<gamedataStimType> ReceivedStimType
		{
			get => GetProperty(ref _receivedStimType);
			set => SetProperty(ref _receivedStimType, value);
		}

		[Ordinal(12)] 
		[RED("inCrowd")] 
		public CBool InCrowd
		{
			get => GetProperty(ref _inCrowd);
			set => SetProperty(ref _inCrowd, value);
		}

		[Ordinal(13)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetProperty(ref _inTrafficLane);
			set => SetProperty(ref _inTrafficLane, value);
		}

		[Ordinal(14)] 
		[RED("desiredFearPhase")] 
		public CInt32 DesiredFearPhase
		{
			get => GetProperty(ref _desiredFearPhase);
			set => SetProperty(ref _desiredFearPhase, value);
		}

		[Ordinal(15)] 
		[RED("previousFearPhase")] 
		public CInt32 PreviousFearPhase
		{
			get => GetProperty(ref _previousFearPhase);
			set => SetProperty(ref _previousFearPhase, value);
		}

		[Ordinal(16)] 
		[RED("NPCRadius")] 
		public CFloat NPCRadius
		{
			get => GetProperty(ref _nPCRadius);
			set => SetProperty(ref _nPCRadius, value);
		}

		[Ordinal(17)] 
		[RED("bumpTriggerDistanceBufferMounted")] 
		public CFloat BumpTriggerDistanceBufferMounted
		{
			get => GetProperty(ref _bumpTriggerDistanceBufferMounted);
			set => SetProperty(ref _bumpTriggerDistanceBufferMounted, value);
		}

		[Ordinal(18)] 
		[RED("bumpTriggerDistanceBufferCrouched")] 
		public CFloat BumpTriggerDistanceBufferCrouched
		{
			get => GetProperty(ref _bumpTriggerDistanceBufferCrouched);
			set => SetProperty(ref _bumpTriggerDistanceBufferCrouched, value);
		}

		[Ordinal(19)] 
		[RED("delayReactionEventID")] 
		public gameDelayID DelayReactionEventID
		{
			get => GetProperty(ref _delayReactionEventID);
			set => SetProperty(ref _delayReactionEventID, value);
		}

		[Ordinal(20)] 
		[RED("delay")] 
		public Vector2 Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(21)] 
		[RED("delayDetectionEventID")] 
		public gameDelayID DelayDetectionEventID
		{
			get => GetProperty(ref _delayDetectionEventID);
			set => SetProperty(ref _delayDetectionEventID, value);
		}

		[Ordinal(22)] 
		[RED("delayStimEventID")] 
		public gameDelayID DelayStimEventID
		{
			get => GetProperty(ref _delayStimEventID);
			set => SetProperty(ref _delayStimEventID, value);
		}

		[Ordinal(23)] 
		[RED("resetReactionDataID")] 
		public gameDelayID ResetReactionDataID
		{
			get => GetProperty(ref _resetReactionDataID);
			set => SetProperty(ref _resetReactionDataID, value);
		}

		[Ordinal(24)] 
		[RED("callingPoliceID")] 
		public gameDelayID CallingPoliceID
		{
			get => GetProperty(ref _callingPoliceID);
			set => SetProperty(ref _callingPoliceID, value);
		}

		[Ordinal(25)] 
		[RED("lookatEvent")] 
		public CHandle<entLookAtAddEvent> LookatEvent
		{
			get => GetProperty(ref _lookatEvent);
			set => SetProperty(ref _lookatEvent, value);
		}

		[Ordinal(26)] 
		[RED("ignoreList")] 
		public CArray<entEntityID> IgnoreList
		{
			get => GetProperty(ref _ignoreList);
			set => SetProperty(ref _ignoreList, value);
		}

		[Ordinal(27)] 
		[RED("investigationList")] 
		public CArray<StimEventData> InvestigationList
		{
			get => GetProperty(ref _investigationList);
			set => SetProperty(ref _investigationList, value);
		}

		[Ordinal(28)] 
		[RED("pendingReaction")] 
		public CHandle<AIReactionData> PendingReaction
		{
			get => GetProperty(ref _pendingReaction);
			set => SetProperty(ref _pendingReaction, value);
		}

		[Ordinal(29)] 
		[RED("ovefloodCooldown")] 
		public CFloat OvefloodCooldown
		{
			get => GetProperty(ref _ovefloodCooldown);
			set => SetProperty(ref _ovefloodCooldown, value);
		}

		[Ordinal(30)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get => GetProperty(ref _stanceState);
			set => SetProperty(ref _stanceState, value);
		}

		[Ordinal(31)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(32)] 
		[RED("aiRole")] 
		public CEnum<EAIRole> AiRole
		{
			get => GetProperty(ref _aiRole);
			set => SetProperty(ref _aiRole, value);
		}

		[Ordinal(33)] 
		[RED("pendingBehaviorCb")] 
		public CUInt32 PendingBehaviorCb
		{
			get => GetProperty(ref _pendingBehaviorCb);
			set => SetProperty(ref _pendingBehaviorCb, value);
		}

		[Ordinal(34)] 
		[RED("inPendingBehavior")] 
		public CBool InPendingBehavior
		{
			get => GetProperty(ref _inPendingBehavior);
			set => SetProperty(ref _inPendingBehavior, value);
		}

		[Ordinal(35)] 
		[RED("cacheSecuritySysOutput")] 
		public CHandle<SecuritySystemOutput> CacheSecuritySysOutput
		{
			get => GetProperty(ref _cacheSecuritySysOutput);
			set => SetProperty(ref _cacheSecuritySysOutput, value);
		}

		[Ordinal(36)] 
		[RED("environmentalHazards")] 
		public CArray<CHandle<senseStimuliEvent>> EnvironmentalHazards
		{
			get => GetProperty(ref _environmentalHazards);
			set => SetProperty(ref _environmentalHazards, value);
		}

		[Ordinal(37)] 
		[RED("environmentalHazardsDelayIDs")] 
		public CArray<gameDelayID> EnvironmentalHazardsDelayIDs
		{
			get => GetProperty(ref _environmentalHazardsDelayIDs);
			set => SetProperty(ref _environmentalHazardsDelayIDs, value);
		}

		[Ordinal(38)] 
		[RED("stolenVehicle")] 
		public wCHandle<vehicleBaseObject> StolenVehicle
		{
			get => GetProperty(ref _stolenVehicle);
			set => SetProperty(ref _stolenVehicle, value);
		}

		[Ordinal(39)] 
		[RED("isAlertedByDeadBody")] 
		public CBool IsAlertedByDeadBody
		{
			get => GetProperty(ref _isAlertedByDeadBody);
			set => SetProperty(ref _isAlertedByDeadBody, value);
		}

		[Ordinal(40)] 
		[RED("isInCrosswalk")] 
		public CBool IsInCrosswalk
		{
			get => GetProperty(ref _isInCrosswalk);
			set => SetProperty(ref _isInCrosswalk, value);
		}

		[Ordinal(41)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetProperty(ref _owner_id);
			set => SetProperty(ref _owner_id, value);
		}

		[Ordinal(42)] 
		[RED("presetName")] 
		public CName PresetName
		{
			get => GetProperty(ref _presetName);
			set => SetProperty(ref _presetName, value);
		}

		[Ordinal(43)] 
		[RED("inProcess")] 
		public CBool InProcess
		{
			get => GetProperty(ref _inProcess);
			set => SetProperty(ref _inProcess, value);
		}

		[Ordinal(44)] 
		[RED("updateByActive")] 
		public CBool UpdateByActive
		{
			get => GetProperty(ref _updateByActive);
			set => SetProperty(ref _updateByActive, value);
		}

		[Ordinal(45)] 
		[RED("personalities")] 
		public CArray<CEnum<gamedataStatType>> Personalities
		{
			get => GetProperty(ref _personalities);
			set => SetProperty(ref _personalities, value);
		}

		[Ordinal(46)] 
		[RED("workspotReactionPlayed")] 
		public CBool WorkspotReactionPlayed
		{
			get => GetProperty(ref _workspotReactionPlayed);
			set => SetProperty(ref _workspotReactionPlayed, value);
		}

		[Ordinal(47)] 
		[RED("inReactionSequence")] 
		public CBool InReactionSequence
		{
			get => GetProperty(ref _inReactionSequence);
			set => SetProperty(ref _inReactionSequence, value);
		}

		[Ordinal(48)] 
		[RED("playerProximity")] 
		public CBool PlayerProximity
		{
			get => GetProperty(ref _playerProximity);
			set => SetProperty(ref _playerProximity, value);
		}

		[Ordinal(49)] 
		[RED("fearToIdleDistance")] 
		public Vector2 FearToIdleDistance
		{
			get => GetProperty(ref _fearToIdleDistance);
			set => SetProperty(ref _fearToIdleDistance, value);
		}

		[Ordinal(50)] 
		[RED("exitWorkspotAim")] 
		public Vector2 ExitWorkspotAim
		{
			get => GetProperty(ref _exitWorkspotAim);
			set => SetProperty(ref _exitWorkspotAim, value);
		}

		[Ordinal(51)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get => GetProperty(ref _bumpedRecently);
			set => SetProperty(ref _bumpedRecently, value);
		}

		[Ordinal(52)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get => GetProperty(ref _bumpTimestamp);
			set => SetProperty(ref _bumpTimestamp, value);
		}

		[Ordinal(53)] 
		[RED("bumpReactionInProgress")] 
		public CBool BumpReactionInProgress
		{
			get => GetProperty(ref _bumpReactionInProgress);
			set => SetProperty(ref _bumpReactionInProgress, value);
		}

		[Ordinal(54)] 
		[RED("crowdAimingReactionDistance")] 
		public CFloat CrowdAimingReactionDistance
		{
			get => GetProperty(ref _crowdAimingReactionDistance);
			set => SetProperty(ref _crowdAimingReactionDistance, value);
		}

		[Ordinal(55)] 
		[RED("fearInPlaceAroundDistance")] 
		public CFloat FearInPlaceAroundDistance
		{
			get => GetProperty(ref _fearInPlaceAroundDistance);
			set => SetProperty(ref _fearInPlaceAroundDistance, value);
		}

		[Ordinal(56)] 
		[RED("lookatRepeat")] 
		public CBool LookatRepeat
		{
			get => GetProperty(ref _lookatRepeat);
			set => SetProperty(ref _lookatRepeat, value);
		}

		[Ordinal(57)] 
		[RED("disturbingComfortZoneInProgress")] 
		public CBool DisturbingComfortZoneInProgress
		{
			get => GetProperty(ref _disturbingComfortZoneInProgress);
			set => SetProperty(ref _disturbingComfortZoneInProgress, value);
		}

		[Ordinal(58)] 
		[RED("entereProximityRecently")] 
		public CInt32 EntereProximityRecently
		{
			get => GetProperty(ref _entereProximityRecently);
			set => SetProperty(ref _entereProximityRecently, value);
		}

		[Ordinal(59)] 
		[RED("comfortZoneTimestamp")] 
		public CFloat ComfortZoneTimestamp
		{
			get => GetProperty(ref _comfortZoneTimestamp);
			set => SetProperty(ref _comfortZoneTimestamp, value);
		}

		[Ordinal(60)] 
		[RED("disturbComfortZoneEventId")] 
		public gameDelayID DisturbComfortZoneEventId
		{
			get => GetProperty(ref _disturbComfortZoneEventId);
			set => SetProperty(ref _disturbComfortZoneEventId, value);
		}

		[Ordinal(61)] 
		[RED("checkComfortZoneEventId")] 
		public gameDelayID CheckComfortZoneEventId
		{
			get => GetProperty(ref _checkComfortZoneEventId);
			set => SetProperty(ref _checkComfortZoneEventId, value);
		}

		[Ordinal(62)] 
		[RED("spreadingFearEventId")] 
		public gameDelayID SpreadingFearEventId
		{
			get => GetProperty(ref _spreadingFearEventId);
			set => SetProperty(ref _spreadingFearEventId, value);
		}

		[Ordinal(63)] 
		[RED("proximityLookatEventId")] 
		public gameDelayID ProximityLookatEventId
		{
			get => GetProperty(ref _proximityLookatEventId);
			set => SetProperty(ref _proximityLookatEventId, value);
		}

		[Ordinal(64)] 
		[RED("resetFacialEventId")] 
		public gameDelayID ResetFacialEventId
		{
			get => GetProperty(ref _resetFacialEventId);
			set => SetProperty(ref _resetFacialEventId, value);
		}

		[Ordinal(65)] 
		[RED("exitWorkspotSequenceEventId")] 
		public gameDelayID ExitWorkspotSequenceEventId
		{
			get => GetProperty(ref _exitWorkspotSequenceEventId);
			set => SetProperty(ref _exitWorkspotSequenceEventId, value);
		}

		[Ordinal(66)] 
		[RED("fastWalk")] 
		public CBool FastWalk
		{
			get => GetProperty(ref _fastWalk);
			set => SetProperty(ref _fastWalk, value);
		}

		[Ordinal(67)] 
		[RED("createThreshold")] 
		public CBool CreateThreshold
		{
			get => GetProperty(ref _createThreshold);
			set => SetProperty(ref _createThreshold, value);
		}

		[Ordinal(68)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(69)] 
		[RED("initCrowd")] 
		public CBool InitCrowd
		{
			get => GetProperty(ref _initCrowd);
			set => SetProperty(ref _initCrowd, value);
		}

		[Ordinal(70)] 
		[RED("facialCooldown")] 
		public CFloat FacialCooldown
		{
			get => GetProperty(ref _facialCooldown);
			set => SetProperty(ref _facialCooldown, value);
		}

		[Ordinal(71)] 
		[RED("disturbComfortZoneAggressiveEventId")] 
		public gameDelayID DisturbComfortZoneAggressiveEventId
		{
			get => GetProperty(ref _disturbComfortZoneAggressiveEventId);
			set => SetProperty(ref _disturbComfortZoneAggressiveEventId, value);
		}

		[Ordinal(72)] 
		[RED("backOffInProgress")] 
		public CBool BackOffInProgress
		{
			get => GetProperty(ref _backOffInProgress);
			set => SetProperty(ref _backOffInProgress, value);
		}

		[Ordinal(73)] 
		[RED("backOffTimestamp")] 
		public CFloat BackOffTimestamp
		{
			get => GetProperty(ref _backOffTimestamp);
			set => SetProperty(ref _backOffTimestamp, value);
		}

		[Ordinal(74)] 
		[RED("crowdFearStage")] 
		public CEnum<gameFearStage> CrowdFearStage
		{
			get => GetProperty(ref _crowdFearStage);
			set => SetProperty(ref _crowdFearStage, value);
		}

		[Ordinal(75)] 
		[RED("fearLocomotionWrapper")] 
		public CBool FearLocomotionWrapper
		{
			get => GetProperty(ref _fearLocomotionWrapper);
			set => SetProperty(ref _fearLocomotionWrapper, value);
		}

		[Ordinal(76)] 
		[RED("successfulFearDeescalation")] 
		public CFloat SuccessfulFearDeescalation
		{
			get => GetProperty(ref _successfulFearDeescalation);
			set => SetProperty(ref _successfulFearDeescalation, value);
		}

		[Ordinal(77)] 
		[RED("willingToCallPolice")] 
		public CBool WillingToCallPolice
		{
			get => GetProperty(ref _willingToCallPolice);
			set => SetProperty(ref _willingToCallPolice, value);
		}

		[Ordinal(78)] 
		[RED("deadBodyInvestigators")] 
		public CArray<entEntityID> DeadBodyInvestigators
		{
			get => GetProperty(ref _deadBodyInvestigators);
			set => SetProperty(ref _deadBodyInvestigators, value);
		}

		[Ordinal(79)] 
		[RED("deadBodyStartingPosition")] 
		public Vector4 DeadBodyStartingPosition
		{
			get => GetProperty(ref _deadBodyStartingPosition);
			set => SetProperty(ref _deadBodyStartingPosition, value);
		}

		[Ordinal(80)] 
		[RED("currentStimThresholdValue")] 
		public CInt32 CurrentStimThresholdValue
		{
			get => GetProperty(ref _currentStimThresholdValue);
			set => SetProperty(ref _currentStimThresholdValue, value);
		}

		[Ordinal(81)] 
		[RED("timeStampThreshold")] 
		public CFloat TimeStampThreshold
		{
			get => GetProperty(ref _timeStampThreshold);
			set => SetProperty(ref _timeStampThreshold, value);
		}

		[Ordinal(82)] 
		[RED("currentStealthStimThresholdValue")] 
		public CInt32 CurrentStealthStimThresholdValue
		{
			get => GetProperty(ref _currentStealthStimThresholdValue);
			set => SetProperty(ref _currentStealthStimThresholdValue, value);
		}

		[Ordinal(83)] 
		[RED("stealthTimeStampThreshold")] 
		public CFloat StealthTimeStampThreshold
		{
			get => GetProperty(ref _stealthTimeStampThreshold);
			set => SetProperty(ref _stealthTimeStampThreshold, value);
		}

		public ReactionManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
