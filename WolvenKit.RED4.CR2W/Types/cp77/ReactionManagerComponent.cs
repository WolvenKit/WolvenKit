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
			get
			{
				if (_activeReaction == null)
				{
					_activeReaction = (CHandle<AIReactionData>) CR2WTypeManager.Create("handle:AIReactionData", "activeReaction", cr2w, this);
				}
				return _activeReaction;
			}
			set
			{
				if (_activeReaction == value)
				{
					return;
				}
				_activeReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desiredReaction")] 
		public CHandle<AIReactionData> DesiredReaction
		{
			get
			{
				if (_desiredReaction == null)
				{
					_desiredReaction = (CHandle<AIReactionData>) CR2WTypeManager.Create("handle:AIReactionData", "desiredReaction", cr2w, this);
				}
				return _desiredReaction;
			}
			set
			{
				if (_desiredReaction == value)
				{
					return;
				}
				_desiredReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stimuliCache")] 
		public CArray<CHandle<senseStimuliEvent>> StimuliCache
		{
			get
			{
				if (_stimuliCache == null)
				{
					_stimuliCache = (CArray<CHandle<senseStimuliEvent>>) CR2WTypeManager.Create("array:handle:senseStimuliEvent", "stimuliCache", cr2w, this);
				}
				return _stimuliCache;
			}
			set
			{
				if (_stimuliCache == value)
				{
					return;
				}
				_stimuliCache = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("reactionCache")] 
		public CArray<CHandle<AIReactionData>> ReactionCache
		{
			get
			{
				if (_reactionCache == null)
				{
					_reactionCache = (CArray<CHandle<AIReactionData>>) CR2WTypeManager.Create("array:handle:AIReactionData", "reactionCache", cr2w, this);
				}
				return _reactionCache;
			}
			set
			{
				if (_reactionCache == value)
				{
					return;
				}
				_reactionCache = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("reactionPreset")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPreset
		{
			get
			{
				if (_reactionPreset == null)
				{
					_reactionPreset = (CHandle<gamedataReactionPreset_Record>) CR2WTypeManager.Create("handle:gamedataReactionPreset_Record", "reactionPreset", cr2w, this);
				}
				return _reactionPreset;
			}
			set
			{
				if (_reactionPreset == value)
				{
					return;
				}
				_reactionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("puppetReactionBlackboard")] 
		public CHandle<gameIBlackboard> PuppetReactionBlackboard
		{
			get
			{
				if (_puppetReactionBlackboard == null)
				{
					_puppetReactionBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "puppetReactionBlackboard", cr2w, this);
				}
				return _puppetReactionBlackboard;
			}
			set
			{
				if (_puppetReactionBlackboard == value)
				{
					return;
				}
				_puppetReactionBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("receivedStimType")] 
		public CEnum<gamedataStimType> ReceivedStimType
		{
			get
			{
				if (_receivedStimType == null)
				{
					_receivedStimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "receivedStimType", cr2w, this);
				}
				return _receivedStimType;
			}
			set
			{
				if (_receivedStimType == value)
				{
					return;
				}
				_receivedStimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inCrowd")] 
		public CBool InCrowd
		{
			get
			{
				if (_inCrowd == null)
				{
					_inCrowd = (CBool) CR2WTypeManager.Create("Bool", "inCrowd", cr2w, this);
				}
				return _inCrowd;
			}
			set
			{
				if (_inCrowd == value)
				{
					return;
				}
				_inCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get
			{
				if (_inTrafficLane == null)
				{
					_inTrafficLane = (CBool) CR2WTypeManager.Create("Bool", "inTrafficLane", cr2w, this);
				}
				return _inTrafficLane;
			}
			set
			{
				if (_inTrafficLane == value)
				{
					return;
				}
				_inTrafficLane = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("desiredFearPhase")] 
		public CInt32 DesiredFearPhase
		{
			get
			{
				if (_desiredFearPhase == null)
				{
					_desiredFearPhase = (CInt32) CR2WTypeManager.Create("Int32", "desiredFearPhase", cr2w, this);
				}
				return _desiredFearPhase;
			}
			set
			{
				if (_desiredFearPhase == value)
				{
					return;
				}
				_desiredFearPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("previousFearPhase")] 
		public CInt32 PreviousFearPhase
		{
			get
			{
				if (_previousFearPhase == null)
				{
					_previousFearPhase = (CInt32) CR2WTypeManager.Create("Int32", "previousFearPhase", cr2w, this);
				}
				return _previousFearPhase;
			}
			set
			{
				if (_previousFearPhase == value)
				{
					return;
				}
				_previousFearPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("NPCRadius")] 
		public CFloat NPCRadius
		{
			get
			{
				if (_nPCRadius == null)
				{
					_nPCRadius = (CFloat) CR2WTypeManager.Create("Float", "NPCRadius", cr2w, this);
				}
				return _nPCRadius;
			}
			set
			{
				if (_nPCRadius == value)
				{
					return;
				}
				_nPCRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bumpTriggerDistanceBufferMounted")] 
		public CFloat BumpTriggerDistanceBufferMounted
		{
			get
			{
				if (_bumpTriggerDistanceBufferMounted == null)
				{
					_bumpTriggerDistanceBufferMounted = (CFloat) CR2WTypeManager.Create("Float", "bumpTriggerDistanceBufferMounted", cr2w, this);
				}
				return _bumpTriggerDistanceBufferMounted;
			}
			set
			{
				if (_bumpTriggerDistanceBufferMounted == value)
				{
					return;
				}
				_bumpTriggerDistanceBufferMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bumpTriggerDistanceBufferCrouched")] 
		public CFloat BumpTriggerDistanceBufferCrouched
		{
			get
			{
				if (_bumpTriggerDistanceBufferCrouched == null)
				{
					_bumpTriggerDistanceBufferCrouched = (CFloat) CR2WTypeManager.Create("Float", "bumpTriggerDistanceBufferCrouched", cr2w, this);
				}
				return _bumpTriggerDistanceBufferCrouched;
			}
			set
			{
				if (_bumpTriggerDistanceBufferCrouched == value)
				{
					return;
				}
				_bumpTriggerDistanceBufferCrouched = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("delayReactionEventID")] 
		public gameDelayID DelayReactionEventID
		{
			get
			{
				if (_delayReactionEventID == null)
				{
					_delayReactionEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayReactionEventID", cr2w, this);
				}
				return _delayReactionEventID;
			}
			set
			{
				if (_delayReactionEventID == value)
				{
					return;
				}
				_delayReactionEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("delay")] 
		public Vector2 Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (Vector2) CR2WTypeManager.Create("Vector2", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("delayDetectionEventID")] 
		public gameDelayID DelayDetectionEventID
		{
			get
			{
				if (_delayDetectionEventID == null)
				{
					_delayDetectionEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayDetectionEventID", cr2w, this);
				}
				return _delayDetectionEventID;
			}
			set
			{
				if (_delayDetectionEventID == value)
				{
					return;
				}
				_delayDetectionEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("delayStimEventID")] 
		public gameDelayID DelayStimEventID
		{
			get
			{
				if (_delayStimEventID == null)
				{
					_delayStimEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayStimEventID", cr2w, this);
				}
				return _delayStimEventID;
			}
			set
			{
				if (_delayStimEventID == value)
				{
					return;
				}
				_delayStimEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("resetReactionDataID")] 
		public gameDelayID ResetReactionDataID
		{
			get
			{
				if (_resetReactionDataID == null)
				{
					_resetReactionDataID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetReactionDataID", cr2w, this);
				}
				return _resetReactionDataID;
			}
			set
			{
				if (_resetReactionDataID == value)
				{
					return;
				}
				_resetReactionDataID = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("callingPoliceID")] 
		public gameDelayID CallingPoliceID
		{
			get
			{
				if (_callingPoliceID == null)
				{
					_callingPoliceID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "callingPoliceID", cr2w, this);
				}
				return _callingPoliceID;
			}
			set
			{
				if (_callingPoliceID == value)
				{
					return;
				}
				_callingPoliceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("lookatEvent")] 
		public CHandle<entLookAtAddEvent> LookatEvent
		{
			get
			{
				if (_lookatEvent == null)
				{
					_lookatEvent = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "lookatEvent", cr2w, this);
				}
				return _lookatEvent;
			}
			set
			{
				if (_lookatEvent == value)
				{
					return;
				}
				_lookatEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("ignoreList")] 
		public CArray<entEntityID> IgnoreList
		{
			get
			{
				if (_ignoreList == null)
				{
					_ignoreList = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "ignoreList", cr2w, this);
				}
				return _ignoreList;
			}
			set
			{
				if (_ignoreList == value)
				{
					return;
				}
				_ignoreList = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("investigationList")] 
		public CArray<StimEventData> InvestigationList
		{
			get
			{
				if (_investigationList == null)
				{
					_investigationList = (CArray<StimEventData>) CR2WTypeManager.Create("array:StimEventData", "investigationList", cr2w, this);
				}
				return _investigationList;
			}
			set
			{
				if (_investigationList == value)
				{
					return;
				}
				_investigationList = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("pendingReaction")] 
		public CHandle<AIReactionData> PendingReaction
		{
			get
			{
				if (_pendingReaction == null)
				{
					_pendingReaction = (CHandle<AIReactionData>) CR2WTypeManager.Create("handle:AIReactionData", "pendingReaction", cr2w, this);
				}
				return _pendingReaction;
			}
			set
			{
				if (_pendingReaction == value)
				{
					return;
				}
				_pendingReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("ovefloodCooldown")] 
		public CFloat OvefloodCooldown
		{
			get
			{
				if (_ovefloodCooldown == null)
				{
					_ovefloodCooldown = (CFloat) CR2WTypeManager.Create("Float", "ovefloodCooldown", cr2w, this);
				}
				return _ovefloodCooldown;
			}
			set
			{
				if (_ovefloodCooldown == value)
				{
					return;
				}
				_ovefloodCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get
			{
				if (_stanceState == null)
				{
					_stanceState = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "stanceState", cr2w, this);
				}
				return _stanceState;
			}
			set
			{
				if (_stanceState == value)
				{
					return;
				}
				_stanceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("aiRole")] 
		public CEnum<EAIRole> AiRole
		{
			get
			{
				if (_aiRole == null)
				{
					_aiRole = (CEnum<EAIRole>) CR2WTypeManager.Create("EAIRole", "aiRole", cr2w, this);
				}
				return _aiRole;
			}
			set
			{
				if (_aiRole == value)
				{
					return;
				}
				_aiRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("pendingBehaviorCb")] 
		public CUInt32 PendingBehaviorCb
		{
			get
			{
				if (_pendingBehaviorCb == null)
				{
					_pendingBehaviorCb = (CUInt32) CR2WTypeManager.Create("Uint32", "pendingBehaviorCb", cr2w, this);
				}
				return _pendingBehaviorCb;
			}
			set
			{
				if (_pendingBehaviorCb == value)
				{
					return;
				}
				_pendingBehaviorCb = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("inPendingBehavior")] 
		public CBool InPendingBehavior
		{
			get
			{
				if (_inPendingBehavior == null)
				{
					_inPendingBehavior = (CBool) CR2WTypeManager.Create("Bool", "inPendingBehavior", cr2w, this);
				}
				return _inPendingBehavior;
			}
			set
			{
				if (_inPendingBehavior == value)
				{
					return;
				}
				_inPendingBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("cacheSecuritySysOutput")] 
		public CHandle<SecuritySystemOutput> CacheSecuritySysOutput
		{
			get
			{
				if (_cacheSecuritySysOutput == null)
				{
					_cacheSecuritySysOutput = (CHandle<SecuritySystemOutput>) CR2WTypeManager.Create("handle:SecuritySystemOutput", "cacheSecuritySysOutput", cr2w, this);
				}
				return _cacheSecuritySysOutput;
			}
			set
			{
				if (_cacheSecuritySysOutput == value)
				{
					return;
				}
				_cacheSecuritySysOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("environmentalHazards")] 
		public CArray<CHandle<senseStimuliEvent>> EnvironmentalHazards
		{
			get
			{
				if (_environmentalHazards == null)
				{
					_environmentalHazards = (CArray<CHandle<senseStimuliEvent>>) CR2WTypeManager.Create("array:handle:senseStimuliEvent", "environmentalHazards", cr2w, this);
				}
				return _environmentalHazards;
			}
			set
			{
				if (_environmentalHazards == value)
				{
					return;
				}
				_environmentalHazards = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("environmentalHazardsDelayIDs")] 
		public CArray<gameDelayID> EnvironmentalHazardsDelayIDs
		{
			get
			{
				if (_environmentalHazardsDelayIDs == null)
				{
					_environmentalHazardsDelayIDs = (CArray<gameDelayID>) CR2WTypeManager.Create("array:gameDelayID", "environmentalHazardsDelayIDs", cr2w, this);
				}
				return _environmentalHazardsDelayIDs;
			}
			set
			{
				if (_environmentalHazardsDelayIDs == value)
				{
					return;
				}
				_environmentalHazardsDelayIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("stolenVehicle")] 
		public wCHandle<vehicleBaseObject> StolenVehicle
		{
			get
			{
				if (_stolenVehicle == null)
				{
					_stolenVehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "stolenVehicle", cr2w, this);
				}
				return _stolenVehicle;
			}
			set
			{
				if (_stolenVehicle == value)
				{
					return;
				}
				_stolenVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("isAlertedByDeadBody")] 
		public CBool IsAlertedByDeadBody
		{
			get
			{
				if (_isAlertedByDeadBody == null)
				{
					_isAlertedByDeadBody = (CBool) CR2WTypeManager.Create("Bool", "isAlertedByDeadBody", cr2w, this);
				}
				return _isAlertedByDeadBody;
			}
			set
			{
				if (_isAlertedByDeadBody == value)
				{
					return;
				}
				_isAlertedByDeadBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("isInCrosswalk")] 
		public CBool IsInCrosswalk
		{
			get
			{
				if (_isInCrosswalk == null)
				{
					_isInCrosswalk = (CBool) CR2WTypeManager.Create("Bool", "isInCrosswalk", cr2w, this);
				}
				return _isInCrosswalk;
			}
			set
			{
				if (_isInCrosswalk == value)
				{
					return;
				}
				_isInCrosswalk = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get
			{
				if (_owner_id == null)
				{
					_owner_id = (entEntityID) CR2WTypeManager.Create("entEntityID", "owner_id", cr2w, this);
				}
				return _owner_id;
			}
			set
			{
				if (_owner_id == value)
				{
					return;
				}
				_owner_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("presetName")] 
		public CName PresetName
		{
			get
			{
				if (_presetName == null)
				{
					_presetName = (CName) CR2WTypeManager.Create("CName", "presetName", cr2w, this);
				}
				return _presetName;
			}
			set
			{
				if (_presetName == value)
				{
					return;
				}
				_presetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("inProcess")] 
		public CBool InProcess
		{
			get
			{
				if (_inProcess == null)
				{
					_inProcess = (CBool) CR2WTypeManager.Create("Bool", "inProcess", cr2w, this);
				}
				return _inProcess;
			}
			set
			{
				if (_inProcess == value)
				{
					return;
				}
				_inProcess = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("updateByActive")] 
		public CBool UpdateByActive
		{
			get
			{
				if (_updateByActive == null)
				{
					_updateByActive = (CBool) CR2WTypeManager.Create("Bool", "updateByActive", cr2w, this);
				}
				return _updateByActive;
			}
			set
			{
				if (_updateByActive == value)
				{
					return;
				}
				_updateByActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("personalities")] 
		public CArray<CEnum<gamedataStatType>> Personalities
		{
			get
			{
				if (_personalities == null)
				{
					_personalities = (CArray<CEnum<gamedataStatType>>) CR2WTypeManager.Create("array:gamedataStatType", "personalities", cr2w, this);
				}
				return _personalities;
			}
			set
			{
				if (_personalities == value)
				{
					return;
				}
				_personalities = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("workspotReactionPlayed")] 
		public CBool WorkspotReactionPlayed
		{
			get
			{
				if (_workspotReactionPlayed == null)
				{
					_workspotReactionPlayed = (CBool) CR2WTypeManager.Create("Bool", "workspotReactionPlayed", cr2w, this);
				}
				return _workspotReactionPlayed;
			}
			set
			{
				if (_workspotReactionPlayed == value)
				{
					return;
				}
				_workspotReactionPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("inReactionSequence")] 
		public CBool InReactionSequence
		{
			get
			{
				if (_inReactionSequence == null)
				{
					_inReactionSequence = (CBool) CR2WTypeManager.Create("Bool", "inReactionSequence", cr2w, this);
				}
				return _inReactionSequence;
			}
			set
			{
				if (_inReactionSequence == value)
				{
					return;
				}
				_inReactionSequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("playerProximity")] 
		public CBool PlayerProximity
		{
			get
			{
				if (_playerProximity == null)
				{
					_playerProximity = (CBool) CR2WTypeManager.Create("Bool", "playerProximity", cr2w, this);
				}
				return _playerProximity;
			}
			set
			{
				if (_playerProximity == value)
				{
					return;
				}
				_playerProximity = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("fearToIdleDistance")] 
		public Vector2 FearToIdleDistance
		{
			get
			{
				if (_fearToIdleDistance == null)
				{
					_fearToIdleDistance = (Vector2) CR2WTypeManager.Create("Vector2", "fearToIdleDistance", cr2w, this);
				}
				return _fearToIdleDistance;
			}
			set
			{
				if (_fearToIdleDistance == value)
				{
					return;
				}
				_fearToIdleDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("exitWorkspotAim")] 
		public Vector2 ExitWorkspotAim
		{
			get
			{
				if (_exitWorkspotAim == null)
				{
					_exitWorkspotAim = (Vector2) CR2WTypeManager.Create("Vector2", "exitWorkspotAim", cr2w, this);
				}
				return _exitWorkspotAim;
			}
			set
			{
				if (_exitWorkspotAim == value)
				{
					return;
				}
				_exitWorkspotAim = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get
			{
				if (_bumpedRecently == null)
				{
					_bumpedRecently = (CInt32) CR2WTypeManager.Create("Int32", "bumpedRecently", cr2w, this);
				}
				return _bumpedRecently;
			}
			set
			{
				if (_bumpedRecently == value)
				{
					return;
				}
				_bumpedRecently = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get
			{
				if (_bumpTimestamp == null)
				{
					_bumpTimestamp = (CFloat) CR2WTypeManager.Create("Float", "bumpTimestamp", cr2w, this);
				}
				return _bumpTimestamp;
			}
			set
			{
				if (_bumpTimestamp == value)
				{
					return;
				}
				_bumpTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("bumpReactionInProgress")] 
		public CBool BumpReactionInProgress
		{
			get
			{
				if (_bumpReactionInProgress == null)
				{
					_bumpReactionInProgress = (CBool) CR2WTypeManager.Create("Bool", "bumpReactionInProgress", cr2w, this);
				}
				return _bumpReactionInProgress;
			}
			set
			{
				if (_bumpReactionInProgress == value)
				{
					return;
				}
				_bumpReactionInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("crowdAimingReactionDistance")] 
		public CFloat CrowdAimingReactionDistance
		{
			get
			{
				if (_crowdAimingReactionDistance == null)
				{
					_crowdAimingReactionDistance = (CFloat) CR2WTypeManager.Create("Float", "crowdAimingReactionDistance", cr2w, this);
				}
				return _crowdAimingReactionDistance;
			}
			set
			{
				if (_crowdAimingReactionDistance == value)
				{
					return;
				}
				_crowdAimingReactionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("fearInPlaceAroundDistance")] 
		public CFloat FearInPlaceAroundDistance
		{
			get
			{
				if (_fearInPlaceAroundDistance == null)
				{
					_fearInPlaceAroundDistance = (CFloat) CR2WTypeManager.Create("Float", "fearInPlaceAroundDistance", cr2w, this);
				}
				return _fearInPlaceAroundDistance;
			}
			set
			{
				if (_fearInPlaceAroundDistance == value)
				{
					return;
				}
				_fearInPlaceAroundDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("lookatRepeat")] 
		public CBool LookatRepeat
		{
			get
			{
				if (_lookatRepeat == null)
				{
					_lookatRepeat = (CBool) CR2WTypeManager.Create("Bool", "lookatRepeat", cr2w, this);
				}
				return _lookatRepeat;
			}
			set
			{
				if (_lookatRepeat == value)
				{
					return;
				}
				_lookatRepeat = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("disturbingComfortZoneInProgress")] 
		public CBool DisturbingComfortZoneInProgress
		{
			get
			{
				if (_disturbingComfortZoneInProgress == null)
				{
					_disturbingComfortZoneInProgress = (CBool) CR2WTypeManager.Create("Bool", "disturbingComfortZoneInProgress", cr2w, this);
				}
				return _disturbingComfortZoneInProgress;
			}
			set
			{
				if (_disturbingComfortZoneInProgress == value)
				{
					return;
				}
				_disturbingComfortZoneInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("entereProximityRecently")] 
		public CInt32 EntereProximityRecently
		{
			get
			{
				if (_entereProximityRecently == null)
				{
					_entereProximityRecently = (CInt32) CR2WTypeManager.Create("Int32", "entereProximityRecently", cr2w, this);
				}
				return _entereProximityRecently;
			}
			set
			{
				if (_entereProximityRecently == value)
				{
					return;
				}
				_entereProximityRecently = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("comfortZoneTimestamp")] 
		public CFloat ComfortZoneTimestamp
		{
			get
			{
				if (_comfortZoneTimestamp == null)
				{
					_comfortZoneTimestamp = (CFloat) CR2WTypeManager.Create("Float", "comfortZoneTimestamp", cr2w, this);
				}
				return _comfortZoneTimestamp;
			}
			set
			{
				if (_comfortZoneTimestamp == value)
				{
					return;
				}
				_comfortZoneTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("disturbComfortZoneEventId")] 
		public gameDelayID DisturbComfortZoneEventId
		{
			get
			{
				if (_disturbComfortZoneEventId == null)
				{
					_disturbComfortZoneEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "disturbComfortZoneEventId", cr2w, this);
				}
				return _disturbComfortZoneEventId;
			}
			set
			{
				if (_disturbComfortZoneEventId == value)
				{
					return;
				}
				_disturbComfortZoneEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("checkComfortZoneEventId")] 
		public gameDelayID CheckComfortZoneEventId
		{
			get
			{
				if (_checkComfortZoneEventId == null)
				{
					_checkComfortZoneEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "checkComfortZoneEventId", cr2w, this);
				}
				return _checkComfortZoneEventId;
			}
			set
			{
				if (_checkComfortZoneEventId == value)
				{
					return;
				}
				_checkComfortZoneEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("spreadingFearEventId")] 
		public gameDelayID SpreadingFearEventId
		{
			get
			{
				if (_spreadingFearEventId == null)
				{
					_spreadingFearEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "spreadingFearEventId", cr2w, this);
				}
				return _spreadingFearEventId;
			}
			set
			{
				if (_spreadingFearEventId == value)
				{
					return;
				}
				_spreadingFearEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("proximityLookatEventId")] 
		public gameDelayID ProximityLookatEventId
		{
			get
			{
				if (_proximityLookatEventId == null)
				{
					_proximityLookatEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "proximityLookatEventId", cr2w, this);
				}
				return _proximityLookatEventId;
			}
			set
			{
				if (_proximityLookatEventId == value)
				{
					return;
				}
				_proximityLookatEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("resetFacialEventId")] 
		public gameDelayID ResetFacialEventId
		{
			get
			{
				if (_resetFacialEventId == null)
				{
					_resetFacialEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetFacialEventId", cr2w, this);
				}
				return _resetFacialEventId;
			}
			set
			{
				if (_resetFacialEventId == value)
				{
					return;
				}
				_resetFacialEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("exitWorkspotSequenceEventId")] 
		public gameDelayID ExitWorkspotSequenceEventId
		{
			get
			{
				if (_exitWorkspotSequenceEventId == null)
				{
					_exitWorkspotSequenceEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "exitWorkspotSequenceEventId", cr2w, this);
				}
				return _exitWorkspotSequenceEventId;
			}
			set
			{
				if (_exitWorkspotSequenceEventId == value)
				{
					return;
				}
				_exitWorkspotSequenceEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("fastWalk")] 
		public CBool FastWalk
		{
			get
			{
				if (_fastWalk == null)
				{
					_fastWalk = (CBool) CR2WTypeManager.Create("Bool", "fastWalk", cr2w, this);
				}
				return _fastWalk;
			}
			set
			{
				if (_fastWalk == value)
				{
					return;
				}
				_fastWalk = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("createThreshold")] 
		public CBool CreateThreshold
		{
			get
			{
				if (_createThreshold == null)
				{
					_createThreshold = (CBool) CR2WTypeManager.Create("Bool", "createThreshold", cr2w, this);
				}
				return _createThreshold;
			}
			set
			{
				if (_createThreshold == value)
				{
					return;
				}
				_createThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CBool) CR2WTypeManager.Create("Bool", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("initCrowd")] 
		public CBool InitCrowd
		{
			get
			{
				if (_initCrowd == null)
				{
					_initCrowd = (CBool) CR2WTypeManager.Create("Bool", "initCrowd", cr2w, this);
				}
				return _initCrowd;
			}
			set
			{
				if (_initCrowd == value)
				{
					return;
				}
				_initCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("facialCooldown")] 
		public CFloat FacialCooldown
		{
			get
			{
				if (_facialCooldown == null)
				{
					_facialCooldown = (CFloat) CR2WTypeManager.Create("Float", "facialCooldown", cr2w, this);
				}
				return _facialCooldown;
			}
			set
			{
				if (_facialCooldown == value)
				{
					return;
				}
				_facialCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("disturbComfortZoneAggressiveEventId")] 
		public gameDelayID DisturbComfortZoneAggressiveEventId
		{
			get
			{
				if (_disturbComfortZoneAggressiveEventId == null)
				{
					_disturbComfortZoneAggressiveEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "disturbComfortZoneAggressiveEventId", cr2w, this);
				}
				return _disturbComfortZoneAggressiveEventId;
			}
			set
			{
				if (_disturbComfortZoneAggressiveEventId == value)
				{
					return;
				}
				_disturbComfortZoneAggressiveEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("backOffInProgress")] 
		public CBool BackOffInProgress
		{
			get
			{
				if (_backOffInProgress == null)
				{
					_backOffInProgress = (CBool) CR2WTypeManager.Create("Bool", "backOffInProgress", cr2w, this);
				}
				return _backOffInProgress;
			}
			set
			{
				if (_backOffInProgress == value)
				{
					return;
				}
				_backOffInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("backOffTimestamp")] 
		public CFloat BackOffTimestamp
		{
			get
			{
				if (_backOffTimestamp == null)
				{
					_backOffTimestamp = (CFloat) CR2WTypeManager.Create("Float", "backOffTimestamp", cr2w, this);
				}
				return _backOffTimestamp;
			}
			set
			{
				if (_backOffTimestamp == value)
				{
					return;
				}
				_backOffTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("crowdFearStage")] 
		public CEnum<gameFearStage> CrowdFearStage
		{
			get
			{
				if (_crowdFearStage == null)
				{
					_crowdFearStage = (CEnum<gameFearStage>) CR2WTypeManager.Create("gameFearStage", "crowdFearStage", cr2w, this);
				}
				return _crowdFearStage;
			}
			set
			{
				if (_crowdFearStage == value)
				{
					return;
				}
				_crowdFearStage = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("fearLocomotionWrapper")] 
		public CBool FearLocomotionWrapper
		{
			get
			{
				if (_fearLocomotionWrapper == null)
				{
					_fearLocomotionWrapper = (CBool) CR2WTypeManager.Create("Bool", "fearLocomotionWrapper", cr2w, this);
				}
				return _fearLocomotionWrapper;
			}
			set
			{
				if (_fearLocomotionWrapper == value)
				{
					return;
				}
				_fearLocomotionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("successfulFearDeescalation")] 
		public CFloat SuccessfulFearDeescalation
		{
			get
			{
				if (_successfulFearDeescalation == null)
				{
					_successfulFearDeescalation = (CFloat) CR2WTypeManager.Create("Float", "successfulFearDeescalation", cr2w, this);
				}
				return _successfulFearDeescalation;
			}
			set
			{
				if (_successfulFearDeescalation == value)
				{
					return;
				}
				_successfulFearDeescalation = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("willingToCallPolice")] 
		public CBool WillingToCallPolice
		{
			get
			{
				if (_willingToCallPolice == null)
				{
					_willingToCallPolice = (CBool) CR2WTypeManager.Create("Bool", "willingToCallPolice", cr2w, this);
				}
				return _willingToCallPolice;
			}
			set
			{
				if (_willingToCallPolice == value)
				{
					return;
				}
				_willingToCallPolice = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("deadBodyInvestigators")] 
		public CArray<entEntityID> DeadBodyInvestigators
		{
			get
			{
				if (_deadBodyInvestigators == null)
				{
					_deadBodyInvestigators = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "deadBodyInvestigators", cr2w, this);
				}
				return _deadBodyInvestigators;
			}
			set
			{
				if (_deadBodyInvestigators == value)
				{
					return;
				}
				_deadBodyInvestigators = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("deadBodyStartingPosition")] 
		public Vector4 DeadBodyStartingPosition
		{
			get
			{
				if (_deadBodyStartingPosition == null)
				{
					_deadBodyStartingPosition = (Vector4) CR2WTypeManager.Create("Vector4", "deadBodyStartingPosition", cr2w, this);
				}
				return _deadBodyStartingPosition;
			}
			set
			{
				if (_deadBodyStartingPosition == value)
				{
					return;
				}
				_deadBodyStartingPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("currentStimThresholdValue")] 
		public CInt32 CurrentStimThresholdValue
		{
			get
			{
				if (_currentStimThresholdValue == null)
				{
					_currentStimThresholdValue = (CInt32) CR2WTypeManager.Create("Int32", "currentStimThresholdValue", cr2w, this);
				}
				return _currentStimThresholdValue;
			}
			set
			{
				if (_currentStimThresholdValue == value)
				{
					return;
				}
				_currentStimThresholdValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("timeStampThreshold")] 
		public CFloat TimeStampThreshold
		{
			get
			{
				if (_timeStampThreshold == null)
				{
					_timeStampThreshold = (CFloat) CR2WTypeManager.Create("Float", "timeStampThreshold", cr2w, this);
				}
				return _timeStampThreshold;
			}
			set
			{
				if (_timeStampThreshold == value)
				{
					return;
				}
				_timeStampThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("currentStealthStimThresholdValue")] 
		public CInt32 CurrentStealthStimThresholdValue
		{
			get
			{
				if (_currentStealthStimThresholdValue == null)
				{
					_currentStealthStimThresholdValue = (CInt32) CR2WTypeManager.Create("Int32", "currentStealthStimThresholdValue", cr2w, this);
				}
				return _currentStealthStimThresholdValue;
			}
			set
			{
				if (_currentStealthStimThresholdValue == value)
				{
					return;
				}
				_currentStealthStimThresholdValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("stealthTimeStampThreshold")] 
		public CFloat StealthTimeStampThreshold
		{
			get
			{
				if (_stealthTimeStampThreshold == null)
				{
					_stealthTimeStampThreshold = (CFloat) CR2WTypeManager.Create("Float", "stealthTimeStampThreshold", cr2w, this);
				}
				return _stealthTimeStampThreshold;
			}
			set
			{
				if (_stealthTimeStampThreshold == value)
				{
					return;
				}
				_stealthTimeStampThreshold = value;
				PropertySet(this);
			}
		}

		public ReactionManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
