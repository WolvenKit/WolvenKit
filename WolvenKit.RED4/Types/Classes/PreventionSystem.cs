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
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("hiddenReaction")] 
		public CBool HiddenReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("systemDisabled")] 
		public CBool SystemDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("deescalationZeroLockExecution")] 
		public CBool DeescalationZeroLockExecution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(8)] 
		[RED("tempForcedheatStage")] 
		public CEnum<EPreventionHeatStage> TempForcedheatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(9)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(10)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(11)] 
		[RED("policeman100SpawnHits")] 
		public CInt32 Policeman100SpawnHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get => GetPropertyValue<CArray<CHandle<PreventionAgents>>>();
			set => SetPropertyValue<CArray<CHandle<PreventionAgents>>>(value);
		}

		[Ordinal(13)] 
		[RED("agentsWhoSeePlayer")] 
		public CArray<entEntityID> AgentsWhoSeePlayer
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(14)] 
		[RED("hitNPC")] 
		public CArray<SHitNPC> HitNPC
		{
			get => GetPropertyValue<CArray<SHitNPC>>();
			set => SetPropertyValue<CArray<SHitNPC>>(value);
		}

		[Ordinal(15)] 
		[RED("spawnedAgents")] 
		public CArray<CWeakHandle<ScriptedPuppet>> SpawnedAgents
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(16)] 
		[RED("lastCrimePoint")] 
		public Vector4 LastCrimePoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(17)] 
		[RED("lastBodyPosition")] 
		public Vector4 LastBodyPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(18)] 
		[RED("DEBUG_lastCrimeDistance")] 
		public CFloat DEBUG_lastCrimeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("policemanRandPercent")] 
		public CInt32 PolicemanRandPercent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("policemabProbabilityPercent")] 
		public CInt32 PolicemabProbabilityPercent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("generalPercent")] 
		public CFloat GeneralPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("partGeneralPercent")] 
		public CFloat PartGeneralPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("newDamageValue")] 
		public CFloat NewDamageValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("gameTimeStampPrevious")] 
		public CFloat GameTimeStampPrevious
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("gameTimeStampLastPoliceRise")] 
		public CFloat GameTimeStampLastPoliceRise
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("gameTimeStampDeescalationZero")] 
		public CFloat GameTimeStampDeescalationZero
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("deescalationZeroDelayID")] 
		public gameDelayID DeescalationZeroDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(28)] 
		[RED("blinkingStatusDelayID")] 
		public gameDelayID BlinkingStatusDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(29)] 
		[RED("deescalationZeroCheck")] 
		public CBool DeescalationZeroCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("blinkingStatusDeescalationCheck")] 
		public CBool BlinkingStatusDeescalationCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("vehicleSpawnDelayID")] 
		public gameDelayID VehicleSpawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(32)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(33)] 
		[RED("preventionTickDelayID")] 
		public gameDelayID PreventionTickDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(34)] 
		[RED("preventionTickCheck")] 
		public CBool PreventionTickCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(36)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("hadOngoingSpawnRequest")] 
		public CBool HadOngoingSpawnRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("Debug_PorcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_PorcessReason
		{
			get => GetPropertyValue<CEnum<EPreventionDebugProcessReason>>();
			set => SetPropertyValue<CEnum<EPreventionDebugProcessReason>>(value);
		}

		[Ordinal(39)] 
		[RED("Debug_PsychoLogicType")] 
		public CEnum<EPreventionPsychoLogicType> Debug_PsychoLogicType
		{
			get => GetPropertyValue<CEnum<EPreventionPsychoLogicType>>();
			set => SetPropertyValue<CEnum<EPreventionPsychoLogicType>>(value);
		}

		[Ordinal(40)] 
		[RED("currentPreventionPreset")] 
		public TweakDBID CurrentPreventionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(41)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(42)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(43)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(44)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(45)] 
		[RED("wantedBarBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBarBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(46)] 
		[RED("onPlayerChoiceCallID")] 
		public CHandle<redCallbackObject> OnPlayerChoiceCallID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(48)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(49)] 
		[RED("playerHLSID")] 
		public CHandle<redCallbackObject> PlayerHLSID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("playerVehicleStateID")] 
		public CHandle<redCallbackObject> PlayerVehicleStateID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(51)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get => GetPropertyValue<CEnum<gamePSMHighLevel>>();
			set => SetPropertyValue<CEnum<gamePSMHighLevel>>(value);
		}

		[Ordinal(52)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(53)] 
		[RED("currentStageFallbackUnitSpawned")] 
		public CBool CurrentStageFallbackUnitSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("unhandledInputsReceived")] 
		public CInt32 UnhandledInputsReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(55)] 
		[RED("inputlockDelayID")] 
		public gameDelayID InputlockDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(56)] 
		[RED("preventionUnitKilledDuringLock")] 
		public CBool PreventionUnitKilledDuringLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("reconDeployed")] 
		public CBool ReconDeployed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("reconDestroyed")] 
		public CBool ReconDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("isHidingFromPolice")] 
		public CBool IsHidingFromPolice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("vehicles")] 
		public CArray<CWeakHandle<vehicleBaseObject>> Vehicles
		{
			get => GetPropertyValue<CArray<CWeakHandle<vehicleBaseObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<vehicleBaseObject>>>(value);
		}

		[Ordinal(61)] 
		[RED("viewers")] 
		public CArray<CWeakHandle<gameObject>> Viewers
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(62)] 
		[RED("hasViewers")] 
		public CBool HasViewers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionSystem()
		{
			SystemLockSources = new();
			TempForcedheatStage = Enums.EPreventionHeatStage.Invalid;
			PlayerIsInSecurityArea = new();
			PoliceSecuritySystems = new();
			AgentGroupsList = new();
			AgentsWhoSeePlayer = new();
			HitNPC = new();
			SpawnedAgents = new();
			LastCrimePoint = new Vector4();
			LastBodyPosition = new Vector4();
			DeescalationZeroDelayID = new gameDelayID();
			BlinkingStatusDelayID = new gameDelayID();
			VehicleSpawnDelayID = new gameDelayID();
			PolicemenSpawnDelayID = new gameDelayID();
			PreventionTickDelayID = new gameDelayID();
			SecurityAreaResetDelayID = new gameDelayID();
			BlinkReasonsStack = new();
			InputlockDelayID = new gameDelayID();
			Vehicles = new();
			Viewers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
