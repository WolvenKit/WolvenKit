using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReactionManagerComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("activeReaction")] 
		public CHandle<AIReactionData> ActiveReaction
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		[Ordinal(6)] 
		[RED("desiredReaction")] 
		public CHandle<AIReactionData> DesiredReaction
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		[Ordinal(7)] 
		[RED("stimuliCache")] 
		public CArray<CHandle<StimEventTaskData>> StimuliCache
		{
			get => GetPropertyValue<CArray<CHandle<StimEventTaskData>>>();
			set => SetPropertyValue<CArray<CHandle<StimEventTaskData>>>(value);
		}

		[Ordinal(8)] 
		[RED("reactionCache")] 
		public CArray<CHandle<AIReactionData>> ReactionCache
		{
			get => GetPropertyValue<CArray<CHandle<AIReactionData>>>();
			set => SetPropertyValue<CArray<CHandle<AIReactionData>>>(value);
		}

		[Ordinal(9)] 
		[RED("reactionPreset")] 
		public CHandle<gamedataReactionPreset_Record> ReactionPreset
		{
			get => GetPropertyValue<CHandle<gamedataReactionPreset_Record>>();
			set => SetPropertyValue<CHandle<gamedataReactionPreset_Record>>(value);
		}

		[Ordinal(10)] 
		[RED("puppetReactionBlackboard")] 
		public CHandle<gameIBlackboard> PuppetReactionBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("receivedStimType")] 
		public CEnum<gamedataStimType> ReceivedStimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(12)] 
		[RED("inCrowd")] 
		public CBool InCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("desiredFearPhase")] 
		public CInt32 DesiredFearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("previousFearPhase")] 
		public CInt32 PreviousFearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("NPCRadius")] 
		public CFloat NPCRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("bumpTriggerDistanceBufferMounted")] 
		public CFloat BumpTriggerDistanceBufferMounted
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("bumpTriggerDistanceBufferCrouched")] 
		public CFloat BumpTriggerDistanceBufferCrouched
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("delayReactionEventID")] 
		public gameDelayID DelayReactionEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(20)] 
		[RED("delay")] 
		public Vector2 Delay
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(21)] 
		[RED("delayDetectionEventID")] 
		public gameDelayID DelayDetectionEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(22)] 
		[RED("delayStimEventID")] 
		public gameDelayID DelayStimEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(23)] 
		[RED("resetReactionDataID")] 
		public gameDelayID ResetReactionDataID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(24)] 
		[RED("callingPoliceID")] 
		public gameDelayID CallingPoliceID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(25)] 
		[RED("lookatEvent")] 
		public CHandle<entLookAtAddEvent> LookatEvent
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(26)] 
		[RED("ignoreList")] 
		public CArray<entEntityID> IgnoreList
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(27)] 
		[RED("investigationList")] 
		public CArray<StimEventData> InvestigationList
		{
			get => GetPropertyValue<CArray<StimEventData>>();
			set => SetPropertyValue<CArray<StimEventData>>(value);
		}

		[Ordinal(28)] 
		[RED("pendingReaction")] 
		public CHandle<AIReactionData> PendingReaction
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		[Ordinal(29)] 
		[RED("ovefloodCooldown")] 
		public CFloat OvefloodCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}

		[Ordinal(31)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(32)] 
		[RED("aiRole")] 
		public CEnum<EAIRole> AiRole
		{
			get => GetPropertyValue<CEnum<EAIRole>>();
			set => SetPropertyValue<CEnum<EAIRole>>(value);
		}

		[Ordinal(33)] 
		[RED("pendingBehaviorCb")] 
		public CHandle<redCallbackObject> PendingBehaviorCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("inPendingBehavior")] 
		public CBool InPendingBehavior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("cacheSecuritySysOutput")] 
		public CHandle<SecuritySystemOutput> CacheSecuritySysOutput
		{
			get => GetPropertyValue<CHandle<SecuritySystemOutput>>();
			set => SetPropertyValue<CHandle<SecuritySystemOutput>>(value);
		}

		[Ordinal(36)] 
		[RED("environmentalHazards")] 
		public CArray<CHandle<senseStimuliEvent>> EnvironmentalHazards
		{
			get => GetPropertyValue<CArray<CHandle<senseStimuliEvent>>>();
			set => SetPropertyValue<CArray<CHandle<senseStimuliEvent>>>(value);
		}

		[Ordinal(37)] 
		[RED("environmentalHazardsDelayIDs")] 
		public CArray<gameDelayID> EnvironmentalHazardsDelayIDs
		{
			get => GetPropertyValue<CArray<gameDelayID>>();
			set => SetPropertyValue<CArray<gameDelayID>>(value);
		}

		[Ordinal(38)] 
		[RED("stolenVehicle")] 
		public CWeakHandle<vehicleBaseObject> StolenVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(39)] 
		[RED("isAlertedByDeadBody")] 
		public CBool IsAlertedByDeadBody
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("isInCrosswalk")] 
		public CBool IsInCrosswalk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("beignHijacked")] 
		public CBool BeignHijacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(43)] 
		[RED("presetName")] 
		public CName PresetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("updateByActive")] 
		public CBool UpdateByActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("personalities")] 
		public CArray<CEnum<gamedataStatType>> Personalities
		{
			get => GetPropertyValue<CArray<CEnum<gamedataStatType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataStatType>>>(value);
		}

		[Ordinal(46)] 
		[RED("workspotReactionPlayed")] 
		public CBool WorkspotReactionPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("inReactionSequence")] 
		public CBool InReactionSequence
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("playerProximity")] 
		public CBool PlayerProximity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("fearToIdleDistance")] 
		public Vector2 FearToIdleDistance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(50)] 
		[RED("exitWorkspotAim")] 
		public Vector2 ExitWorkspotAim
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(51)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("crowdAimingReactionDistance")] 
		public CFloat CrowdAimingReactionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("fearInPlaceAroundDistance")] 
		public CFloat FearInPlaceAroundDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("lookatRepeat")] 
		public CBool LookatRepeat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("disturbingComfortZoneInProgress")] 
		public CBool DisturbingComfortZoneInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("entereProximityRecently")] 
		public CInt32 EntereProximityRecently
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(58)] 
		[RED("comfortZoneTimestamp")] 
		public CFloat ComfortZoneTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("disturbComfortZoneEventId")] 
		public gameDelayID DisturbComfortZoneEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(60)] 
		[RED("checkComfortZoneEventId")] 
		public gameDelayID CheckComfortZoneEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(61)] 
		[RED("spreadingFearEventId")] 
		public gameDelayID SpreadingFearEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(62)] 
		[RED("proximityLookatEventId")] 
		public gameDelayID ProximityLookatEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(63)] 
		[RED("resetFacialEventId")] 
		public gameDelayID ResetFacialEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(64)] 
		[RED("exitWorkspotSequenceEventId")] 
		public gameDelayID ExitWorkspotSequenceEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(65)] 
		[RED("exitFearInVehicleEventId")] 
		public gameDelayID ExitFearInVehicleEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(66)] 
		[RED("fastWalk")] 
		public CBool FastWalk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("createThreshold")] 
		public CBool CreateThreshold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("initCrowd")] 
		public CBool InitCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("facialCooldown")] 
		public CFloat FacialCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(71)] 
		[RED("disturbComfortZoneAggressiveEventId")] 
		public gameDelayID DisturbComfortZoneAggressiveEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(72)] 
		[RED("backOffInProgress")] 
		public CBool BackOffInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("backOffTimestamp")] 
		public CFloat BackOffTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(74)] 
		[RED("crowdFearStage")] 
		public CEnum<gameFearStage> CrowdFearStage
		{
			get => GetPropertyValue<CEnum<gameFearStage>>();
			set => SetPropertyValue<CEnum<gameFearStage>>(value);
		}

		[Ordinal(75)] 
		[RED("fearLocomotionWrapper")] 
		public CBool FearLocomotionWrapper
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("successfulFearDeescalation")] 
		public CFloat SuccessfulFearDeescalation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("willingToCallPolice")] 
		public CBool WillingToCallPolice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("deadBodyInvestigators")] 
		public CArray<entEntityID> DeadBodyInvestigators
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(79)] 
		[RED("deadBodyStartingPosition")] 
		public Vector4 DeadBodyStartingPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(80)] 
		[RED("currentStimThresholdValue")] 
		public CInt32 CurrentStimThresholdValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(81)] 
		[RED("timeStampThreshold")] 
		public CFloat TimeStampThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(82)] 
		[RED("currentStealthStimThresholdValue")] 
		public CInt32 CurrentStealthStimThresholdValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(83)] 
		[RED("stealthTimeStampThreshold")] 
		public CFloat StealthTimeStampThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ReactionManagerComponent()
		{
			StimuliCache = new();
			ReactionCache = new();
			DesiredFearPhase = -1;
			NPCRadius = 0.300000F;
			BumpTriggerDistanceBufferMounted = 1.000000F;
			BumpTriggerDistanceBufferCrouched = -0.110000F;
			DelayReactionEventID = new();
			Delay = new();
			DelayDetectionEventID = new();
			DelayStimEventID = new();
			ResetReactionDataID = new();
			CallingPoliceID = new();
			IgnoreList = new();
			InvestigationList = new();
			OvefloodCooldown = 1.000000F;
			StanceState = Enums.gamedataNPCStanceState.Stand;
			HighLevelState = Enums.gamedataNPCHighLevelState.Relaxed;
			EnvironmentalHazards = new();
			EnvironmentalHazardsDelayIDs = new();
			Owner_id = new();
			Personalities = new();
			FearToIdleDistance = new();
			ExitWorkspotAim = new();
			DisturbComfortZoneEventId = new();
			CheckComfortZoneEventId = new();
			SpreadingFearEventId = new();
			ProximityLookatEventId = new();
			ResetFacialEventId = new();
			ExitWorkspotSequenceEventId = new();
			ExitFearInVehicleEventId = new();
			FastWalk = true;
			CreateThreshold = true;
			DisturbComfortZoneAggressiveEventId = new();
			DeadBodyInvestigators = new();
			DeadBodyStartingPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
