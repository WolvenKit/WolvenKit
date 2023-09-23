using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("districtManager")] 
		public CHandle<DistrictManager> DistrictManager
		{
			get => GetPropertyValue<CHandle<DistrictManager>>();
			set => SetPropertyValue<CHandle<DistrictManager>>(value);
		}

		[Ordinal(1)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetPropertyValue<CHandle<PoliceAgentRegistry>>();
			set => SetPropertyValue<CHandle<PoliceAgentRegistry>>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreSecurityAreasByQuest")] 
		public CBool IgnoreSecurityAreasByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("forceEternalGreyStars")] 
		public CBool ForceEternalGreyStars
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("blockOnFootSpawnByQuest")] 
		public CBool BlockOnFootSpawnByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("blockVehicleSpawnByQuest")] 
		public CBool BlockVehicleSpawnByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("blockReconDroneSpawnByQuest")] 
		public CBool BlockReconDroneSpawnByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("crimeScoreMultiplierByQuest")] 
		public CFloat CrimeScoreMultiplierByQuest
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("preventionQuestEventSources")] 
		public CArray<CName> PreventionQuestEventSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(9)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(10)] 
		[RED("systemEnabled")] 
		public CBool SystemEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(12)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>(value);
		}

		[Ordinal(13)] 
		[RED("preventionDataMatrix")] 
		public CWeakHandle<gamedataPreventionHeatDataMatrix_Record> PreventionDataMatrix
		{
			get => GetPropertyValue<CWeakHandle<gamedataPreventionHeatDataMatrix_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataPreventionHeatDataMatrix_Record>>(value);
		}

		[Ordinal(14)] 
		[RED("preventionDataTable")] 
		public CWeakHandle<gamedataPreventionHeatTable_Record> PreventionDataTable
		{
			get => GetPropertyValue<CWeakHandle<gamedataPreventionHeatTable_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataPreventionHeatTable_Record>>(value);
		}

		[Ordinal(15)] 
		[RED("systemLocked")] 
		public CBool SystemLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("nodeEventSources")] 
		public CArray<CName> NodeEventSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(17)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(18)] 
		[RED("heatChangeReason")] 
		public CString HeatChangeReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("ignoreSecurityAreas")] 
		public CBool IgnoreSecurityAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(21)] 
		[RED("playerIsInPreventionFreeArea")] 
		public CBool PlayerIsInPreventionFreeArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(23)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get => GetPropertyValue<CArray<CHandle<PreventionAgents>>>();
			set => SetPropertyValue<CArray<CHandle<PreventionAgents>>>(value);
		}

		[Ordinal(24)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(25)] 
		[RED("lastKnownVehicle")] 
		public CWeakHandle<vehicleBaseObject> LastKnownVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(26)] 
		[RED("districtMultiplier")] 
		public CFloat DistrictMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("shouldForceStarStateUIToActive")] 
		public CBool ShouldForceStarStateUIToActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("lastAttackTime")] 
		public CFloat LastAttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("lastAttackTargetIDs")] 
		public CArray<entEntityID> LastAttackTargetIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(30)] 
		[RED("viewers")] 
		public CArray<CWeakHandle<gameObject>> Viewers
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(31)] 
		[RED("hasViewers")] 
		public CBool HasViewers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("starState")] 
		public CEnum<EStarState> StarState
		{
			get => GetPropertyValue<CEnum<EStarState>>();
			set => SetPropertyValue<CEnum<EStarState>>(value);
		}

		[Ordinal(33)] 
		[RED("starStateUIChanged")] 
		public CBool StarStateUIChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isPlayerMounted")] 
		public CBool IsPlayerMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("policeKnowsPlayerLocation")] 
		public CBool PoliceKnowsPlayerLocation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isInitialSearchState")] 
		public CBool IsInitialSearchState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("heatLevelChanged")] 
		public CBool HeatLevelChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("playerCrossedBufferDistance")] 
		public CBool PlayerCrossedBufferDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("crimescoreTimerDelayID")] 
		public gameDelayID CrimescoreTimerDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(40)] 
		[RED("starStateBufferTimerDelayID")] 
		public gameDelayID StarStateBufferTimerDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(41)] 
		[RED("beliefAccuracyTimerDelayID")] 
		public gameDelayID BeliefAccuracyTimerDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(42)] 
		[RED("blinkingStatusDelayID")] 
		public gameDelayID BlinkingStatusDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(43)] 
		[RED("searchingStatusDelayID")] 
		public gameDelayID SearchingStatusDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(44)] 
		[RED("transitionToGreyStateDelayID")] 
		public gameDelayID TransitionToGreyStateDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(45)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(46)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(47)] 
		[RED("inputlockDelayID")] 
		public gameDelayID InputlockDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(48)] 
		[RED("freeAreaResetDelayID")] 
		public gameDelayID FreeAreaResetDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(49)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("hadOngoingSpawnRequest")] 
		public CBool HadOngoingSpawnRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("totalCrimeScore")] 
		public CFloat TotalCrimeScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("canSpawnFallbackEarly")] 
		public CBool CanSpawnFallbackEarly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(54)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(55)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(56)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(57)] 
		[RED("wantedBarBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBarBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(58)] 
		[RED("onPlayerChoiceCallID")] 
		public CHandle<redCallbackObject> OnPlayerChoiceCallID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(59)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(60)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(61)] 
		[RED("playerHLSID")] 
		public CHandle<redCallbackObject> PlayerHLSID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(62)] 
		[RED("playerVehicleStateID")] 
		public CHandle<redCallbackObject> PlayerVehicleStateID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(63)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get => GetPropertyValue<CEnum<gamePSMHighLevel>>();
			set => SetPropertyValue<CEnum<gamePSMHighLevel>>(value);
		}

		[Ordinal(64)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(65)] 
		[RED("unhandledInputsReceived")] 
		public CInt32 UnhandledInputsReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(66)] 
		[RED("preventionUnitKilledDuringLock")] 
		public CBool PreventionUnitKilledDuringLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("previousHitTargetID")] 
		public entEntityID PreviousHitTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(68)] 
		[RED("previousHitAttackTime")] 
		public CFloat PreviousHitAttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("reconPhaseEnabled")] 
		public CBool ReconPhaseEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("reconDeployed")] 
		public CBool ReconDeployed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("reconDestroyed")] 
		public CBool ReconDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("minHeatLevel")] 
		public CEnum<EPreventionHeatStage> MinHeatLevel
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(73)] 
		[RED("maxHeatLevel")] 
		public CEnum<EPreventionHeatStage> MaxHeatLevel
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(74)] 
		[RED("defaultHeatLevels")] 
		public CBool DefaultHeatLevels
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("vehicleSpawnBlockSide")] 
		public CEnum<EVehicleSpawnBlockSide> VehicleSpawnBlockSide
		{
			get => GetPropertyValue<CEnum<EVehicleSpawnBlockSide>>();
			set => SetPropertyValue<CEnum<EVehicleSpawnBlockSide>>(value);
		}

		[Ordinal(76)] 
		[RED("damageToPlayerMultiplier")] 
		public CFloat DamageToPlayerMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("chaseMultiplier")] 
		public CFloat ChaseMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(78)] 
		[RED("policeChaseBlackboard")] 
		public CWeakHandle<gameIBlackboard> PoliceChaseBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(79)] 
		[RED("blockShootingFromVehicle")] 
		public CBool BlockShootingFromVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("Debug_ProcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_ProcessReason
		{
			get => GetPropertyValue<CEnum<EPreventionDebugProcessReason>>();
			set => SetPropertyValue<CEnum<EPreventionDebugProcessReason>>(value);
		}

		[Ordinal(81)] 
		[RED("Debug_LastAttackType")] 
		public CEnum<gamedataAttackType> Debug_LastAttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(82)] 
		[RED("Debug_LastDamageDealt")] 
		public CFloat Debug_LastDamageDealt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(83)] 
		[RED("Debug_LastCrimeDistance")] 
		public CFloat Debug_LastCrimeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(84)] 
		[RED("Debug_lastAVRequestedSpawnPosition")] 
		public Vector3 Debug_lastAVRequestedSpawnPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(85)] 
		[RED("temp_const_false")] 
		public CBool Temp_const_false
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(86)] 
		[RED("preventionTickCaller")] 
		public CHandle<IntervalCaller> PreventionTickCaller
		{
			get => GetPropertyValue<CHandle<IntervalCaller>>();
			set => SetPropertyValue<CHandle<IntervalCaller>>(value);
		}

		[Ordinal(87)] 
		[RED("roadblockadeRespawnTickCaller")] 
		public CHandle<IntervalCaller> RoadblockadeRespawnTickCaller
		{
			get => GetPropertyValue<CHandle<IntervalCaller>>();
			set => SetPropertyValue<CHandle<IntervalCaller>>(value);
		}

		[Ordinal(88)] 
		[RED("maxtacTicketID")] 
		public CUInt32 MaxtacTicketID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(89)] 
		[RED("avSpawnPointList")] 
		public CArray<Vector3> AvSpawnPointList
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(90)] 
		[RED("maxAllowedDistanceToPlayer")] 
		public CFloat MaxAllowedDistanceToPlayer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(91)] 
		[RED("lastAVRequestedSpawnPositionsArray")] 
		public CArray<Vector4> LastAVRequestedSpawnPositionsArray
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(92)] 
		[RED("shouldPreventionUnitsStartRetreating")] 
		public CBool ShouldPreventionUnitsStartRetreating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("numberOfMaxtacSquadsSpawned")] 
		public CInt32 NumberOfMaxtacSquadsSpawned
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(94)] 
		[RED("maxtacTroopBeingAliveTimeStamp")] 
		public CFloat MaxtacTroopBeingAliveTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(95)] 
		[RED("vehicleSpawnTickCaller")] 
		public CHandle<IntervalCaller> VehicleSpawnTickCaller
		{
			get => GetPropertyValue<CHandle<IntervalCaller>>();
			set => SetPropertyValue<CHandle<IntervalCaller>>(value);
		}

		[Ordinal(96)] 
		[RED("ressuplyVehicleTicketCaller")] 
		public CHandle<IntervalCaller> RessuplyVehicleTicketCaller
		{
			get => GetPropertyValue<CHandle<IntervalCaller>>();
			set => SetPropertyValue<CHandle<IntervalCaller>>(value);
		}

		[Ordinal(97)] 
		[RED("isVehicleDelayOver")] 
		public CBool IsVehicleDelayOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("currentVehicleTicketCount")] 
		public CInt32 CurrentVehicleTicketCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(99)] 
		[RED("failedVehicleSpawnAttempts")] 
		public CInt32 FailedVehicleSpawnAttempts
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(100)] 
		[RED("codeRedReinforcement")] 
		public CBool CodeRedReinforcement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("lastStarChangeTimeStamp")] 
		public CFloat LastStarChangeTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(102)] 
		[RED("firstStarTimeStamp")] 
		public CFloat FirstStarTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(103)] 
		[RED("setCallRejectionIncrement")] 
		public CBool SetCallRejectionIncrement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
