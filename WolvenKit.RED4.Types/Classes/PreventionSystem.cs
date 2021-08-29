using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionSystem : gameScriptableSystem
	{
		private CHandle<DistrictManager> _districtManager;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<gamedataDistrictPreventionData_Record> _preventionPreset;
		private CBool _hiddenReaction;
		private CBool _systemDisabled;
		private CArray<CName> _systemLockSources;
		private CBool _deescalationZeroLockExecution;
		private CEnum<EPreventionHeatStage> _heatStage;
		private CArray<gamePersistentID> _playerIsInSecurityArea;
		private CArray<gamePersistentID> _policeSecuritySystems;
		private CInt32 _policeman100SpawnHits;
		private CArray<CHandle<PreventionAgents>> _agentGroupsList;
		private CArray<entEntityID> _agentsWhoSeePlayer;
		private CArray<SHitNPC> _hitNPC;
		private CArray<CWeakHandle<ScriptedPuppet>> _spawnedAgents;
		private Vector4 _lastCrimePoint;
		private Vector4 _lastBodyPosition;
		private CFloat _dEBUG_lastCrimeDistance;
		private CInt32 _policemanRandPercent;
		private CInt32 _policemabProbabilityPercent;
		private CFloat _generalPercent;
		private CFloat _partGeneralPercent;
		private CFloat _newDamageValue;
		private CFloat _gameTimeStampPrevious;
		private CFloat _gameTimeStampLastPoliceRise;
		private CFloat _gameTimeStampDeescalationZero;
		private gameDelayID _deescalationZeroDelayID;
		private CBool _deescalationZeroCheck;
		private gameDelayID _policemenSpawnDelayID;
		private gameDelayID _preventionTickDelayID;
		private CBool _preventionTickCheck;
		private gameDelayID _securityAreaResetDelayID;
		private CBool _securityAreaResetCheck;
		private CBool _hadOngoingSpawnRequest;
		private CEnum<EPreventionDebugProcessReason> _debug_PorcessReason;
		private CEnum<EPreventionPsychoLogicType> _debug_PsychoLogicType;
		private TweakDBID _currentPreventionPreset;
		private TweakDBID _failsafePoliceRecordT1;
		private TweakDBID _failsafePoliceRecordT2;
		private TweakDBID _failsafePoliceRecordT3;
		private CArray<CName> _blinkReasonsStack;
		private CWeakHandle<gameIBlackboard> _wantedBarBlackboard;
		private CHandle<redCallbackObject> _onPlayerChoiceCallID;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CHandle<redCallbackObject> _playerHLSID;
		private CHandle<redCallbackObject> _playerVehicleStateID;
		private CEnum<gamePSMHighLevel> _playerHLS;
		private CEnum<gamePSMVehicle> _playerVehicleState;
		private CBool _currentStageFallbackUnitSpawned;
		private CInt32 _unhandledInputsReceived;
		private gameDelayID _inputlockDelayID;
		private CBool _preventionUnitKilledDuringLock;
		private CBool _reconDeployed;
		private CArray<CWeakHandle<vehicleBaseObject>> _vehicles;
		private CArray<CWeakHandle<gameObject>> _viewers;
		private CBool _hasViewers;

		[Ordinal(0)] 
		[RED("districtManager")] 
		public CHandle<DistrictManager> DistrictManager
		{
			get => GetProperty(ref _districtManager);
			set => SetProperty(ref _districtManager, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetProperty(ref _preventionPreset);
			set => SetProperty(ref _preventionPreset, value);
		}

		[Ordinal(3)] 
		[RED("hiddenReaction")] 
		public CBool HiddenReaction
		{
			get => GetProperty(ref _hiddenReaction);
			set => SetProperty(ref _hiddenReaction, value);
		}

		[Ordinal(4)] 
		[RED("systemDisabled")] 
		public CBool SystemDisabled
		{
			get => GetProperty(ref _systemDisabled);
			set => SetProperty(ref _systemDisabled, value);
		}

		[Ordinal(5)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get => GetProperty(ref _systemLockSources);
			set => SetProperty(ref _systemLockSources, value);
		}

		[Ordinal(6)] 
		[RED("deescalationZeroLockExecution")] 
		public CBool DeescalationZeroLockExecution
		{
			get => GetProperty(ref _deescalationZeroLockExecution);
			set => SetProperty(ref _deescalationZeroLockExecution, value);
		}

		[Ordinal(7)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetProperty(ref _heatStage);
			set => SetProperty(ref _heatStage, value);
		}

		[Ordinal(8)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get => GetProperty(ref _playerIsInSecurityArea);
			set => SetProperty(ref _playerIsInSecurityArea, value);
		}

		[Ordinal(9)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get => GetProperty(ref _policeSecuritySystems);
			set => SetProperty(ref _policeSecuritySystems, value);
		}

		[Ordinal(10)] 
		[RED("policeman100SpawnHits")] 
		public CInt32 Policeman100SpawnHits
		{
			get => GetProperty(ref _policeman100SpawnHits);
			set => SetProperty(ref _policeman100SpawnHits, value);
		}

		[Ordinal(11)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get => GetProperty(ref _agentGroupsList);
			set => SetProperty(ref _agentGroupsList, value);
		}

		[Ordinal(12)] 
		[RED("agentsWhoSeePlayer")] 
		public CArray<entEntityID> AgentsWhoSeePlayer
		{
			get => GetProperty(ref _agentsWhoSeePlayer);
			set => SetProperty(ref _agentsWhoSeePlayer, value);
		}

		[Ordinal(13)] 
		[RED("hitNPC")] 
		public CArray<SHitNPC> HitNPC
		{
			get => GetProperty(ref _hitNPC);
			set => SetProperty(ref _hitNPC, value);
		}

		[Ordinal(14)] 
		[RED("spawnedAgents")] 
		public CArray<CWeakHandle<ScriptedPuppet>> SpawnedAgents
		{
			get => GetProperty(ref _spawnedAgents);
			set => SetProperty(ref _spawnedAgents, value);
		}

		[Ordinal(15)] 
		[RED("lastCrimePoint")] 
		public Vector4 LastCrimePoint
		{
			get => GetProperty(ref _lastCrimePoint);
			set => SetProperty(ref _lastCrimePoint, value);
		}

		[Ordinal(16)] 
		[RED("lastBodyPosition")] 
		public Vector4 LastBodyPosition
		{
			get => GetProperty(ref _lastBodyPosition);
			set => SetProperty(ref _lastBodyPosition, value);
		}

		[Ordinal(17)] 
		[RED("DEBUG_lastCrimeDistance")] 
		public CFloat DEBUG_lastCrimeDistance
		{
			get => GetProperty(ref _dEBUG_lastCrimeDistance);
			set => SetProperty(ref _dEBUG_lastCrimeDistance, value);
		}

		[Ordinal(18)] 
		[RED("policemanRandPercent")] 
		public CInt32 PolicemanRandPercent
		{
			get => GetProperty(ref _policemanRandPercent);
			set => SetProperty(ref _policemanRandPercent, value);
		}

		[Ordinal(19)] 
		[RED("policemabProbabilityPercent")] 
		public CInt32 PolicemabProbabilityPercent
		{
			get => GetProperty(ref _policemabProbabilityPercent);
			set => SetProperty(ref _policemabProbabilityPercent, value);
		}

		[Ordinal(20)] 
		[RED("generalPercent")] 
		public CFloat GeneralPercent
		{
			get => GetProperty(ref _generalPercent);
			set => SetProperty(ref _generalPercent, value);
		}

		[Ordinal(21)] 
		[RED("partGeneralPercent")] 
		public CFloat PartGeneralPercent
		{
			get => GetProperty(ref _partGeneralPercent);
			set => SetProperty(ref _partGeneralPercent, value);
		}

		[Ordinal(22)] 
		[RED("newDamageValue")] 
		public CFloat NewDamageValue
		{
			get => GetProperty(ref _newDamageValue);
			set => SetProperty(ref _newDamageValue, value);
		}

		[Ordinal(23)] 
		[RED("gameTimeStampPrevious")] 
		public CFloat GameTimeStampPrevious
		{
			get => GetProperty(ref _gameTimeStampPrevious);
			set => SetProperty(ref _gameTimeStampPrevious, value);
		}

		[Ordinal(24)] 
		[RED("gameTimeStampLastPoliceRise")] 
		public CFloat GameTimeStampLastPoliceRise
		{
			get => GetProperty(ref _gameTimeStampLastPoliceRise);
			set => SetProperty(ref _gameTimeStampLastPoliceRise, value);
		}

		[Ordinal(25)] 
		[RED("gameTimeStampDeescalationZero")] 
		public CFloat GameTimeStampDeescalationZero
		{
			get => GetProperty(ref _gameTimeStampDeescalationZero);
			set => SetProperty(ref _gameTimeStampDeescalationZero, value);
		}

		[Ordinal(26)] 
		[RED("deescalationZeroDelayID")] 
		public gameDelayID DeescalationZeroDelayID
		{
			get => GetProperty(ref _deescalationZeroDelayID);
			set => SetProperty(ref _deescalationZeroDelayID, value);
		}

		[Ordinal(27)] 
		[RED("deescalationZeroCheck")] 
		public CBool DeescalationZeroCheck
		{
			get => GetProperty(ref _deescalationZeroCheck);
			set => SetProperty(ref _deescalationZeroCheck, value);
		}

		[Ordinal(28)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get => GetProperty(ref _policemenSpawnDelayID);
			set => SetProperty(ref _policemenSpawnDelayID, value);
		}

		[Ordinal(29)] 
		[RED("preventionTickDelayID")] 
		public gameDelayID PreventionTickDelayID
		{
			get => GetProperty(ref _preventionTickDelayID);
			set => SetProperty(ref _preventionTickDelayID, value);
		}

		[Ordinal(30)] 
		[RED("preventionTickCheck")] 
		public CBool PreventionTickCheck
		{
			get => GetProperty(ref _preventionTickCheck);
			set => SetProperty(ref _preventionTickCheck, value);
		}

		[Ordinal(31)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get => GetProperty(ref _securityAreaResetDelayID);
			set => SetProperty(ref _securityAreaResetDelayID, value);
		}

		[Ordinal(32)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get => GetProperty(ref _securityAreaResetCheck);
			set => SetProperty(ref _securityAreaResetCheck, value);
		}

		[Ordinal(33)] 
		[RED("hadOngoingSpawnRequest")] 
		public CBool HadOngoingSpawnRequest
		{
			get => GetProperty(ref _hadOngoingSpawnRequest);
			set => SetProperty(ref _hadOngoingSpawnRequest, value);
		}

		[Ordinal(34)] 
		[RED("Debug_PorcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_PorcessReason
		{
			get => GetProperty(ref _debug_PorcessReason);
			set => SetProperty(ref _debug_PorcessReason, value);
		}

		[Ordinal(35)] 
		[RED("Debug_PsychoLogicType")] 
		public CEnum<EPreventionPsychoLogicType> Debug_PsychoLogicType
		{
			get => GetProperty(ref _debug_PsychoLogicType);
			set => SetProperty(ref _debug_PsychoLogicType, value);
		}

		[Ordinal(36)] 
		[RED("currentPreventionPreset")] 
		public TweakDBID CurrentPreventionPreset
		{
			get => GetProperty(ref _currentPreventionPreset);
			set => SetProperty(ref _currentPreventionPreset, value);
		}

		[Ordinal(37)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get => GetProperty(ref _failsafePoliceRecordT1);
			set => SetProperty(ref _failsafePoliceRecordT1, value);
		}

		[Ordinal(38)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get => GetProperty(ref _failsafePoliceRecordT2);
			set => SetProperty(ref _failsafePoliceRecordT2, value);
		}

		[Ordinal(39)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get => GetProperty(ref _failsafePoliceRecordT3);
			set => SetProperty(ref _failsafePoliceRecordT3, value);
		}

		[Ordinal(40)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get => GetProperty(ref _blinkReasonsStack);
			set => SetProperty(ref _blinkReasonsStack, value);
		}

		[Ordinal(41)] 
		[RED("wantedBarBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBarBlackboard
		{
			get => GetProperty(ref _wantedBarBlackboard);
			set => SetProperty(ref _wantedBarBlackboard, value);
		}

		[Ordinal(42)] 
		[RED("onPlayerChoiceCallID")] 
		public CHandle<redCallbackObject> OnPlayerChoiceCallID
		{
			get => GetProperty(ref _onPlayerChoiceCallID);
			set => SetProperty(ref _onPlayerChoiceCallID, value);
		}

		[Ordinal(43)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(44)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(45)] 
		[RED("playerHLSID")] 
		public CHandle<redCallbackObject> PlayerHLSID
		{
			get => GetProperty(ref _playerHLSID);
			set => SetProperty(ref _playerHLSID, value);
		}

		[Ordinal(46)] 
		[RED("playerVehicleStateID")] 
		public CHandle<redCallbackObject> PlayerVehicleStateID
		{
			get => GetProperty(ref _playerVehicleStateID);
			set => SetProperty(ref _playerVehicleStateID, value);
		}

		[Ordinal(47)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get => GetProperty(ref _playerHLS);
			set => SetProperty(ref _playerHLS, value);
		}

		[Ordinal(48)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get => GetProperty(ref _playerVehicleState);
			set => SetProperty(ref _playerVehicleState, value);
		}

		[Ordinal(49)] 
		[RED("currentStageFallbackUnitSpawned")] 
		public CBool CurrentStageFallbackUnitSpawned
		{
			get => GetProperty(ref _currentStageFallbackUnitSpawned);
			set => SetProperty(ref _currentStageFallbackUnitSpawned, value);
		}

		[Ordinal(50)] 
		[RED("unhandledInputsReceived")] 
		public CInt32 UnhandledInputsReceived
		{
			get => GetProperty(ref _unhandledInputsReceived);
			set => SetProperty(ref _unhandledInputsReceived, value);
		}

		[Ordinal(51)] 
		[RED("inputlockDelayID")] 
		public gameDelayID InputlockDelayID
		{
			get => GetProperty(ref _inputlockDelayID);
			set => SetProperty(ref _inputlockDelayID, value);
		}

		[Ordinal(52)] 
		[RED("preventionUnitKilledDuringLock")] 
		public CBool PreventionUnitKilledDuringLock
		{
			get => GetProperty(ref _preventionUnitKilledDuringLock);
			set => SetProperty(ref _preventionUnitKilledDuringLock, value);
		}

		[Ordinal(53)] 
		[RED("reconDeployed")] 
		public CBool ReconDeployed
		{
			get => GetProperty(ref _reconDeployed);
			set => SetProperty(ref _reconDeployed, value);
		}

		[Ordinal(54)] 
		[RED("vehicles")] 
		public CArray<CWeakHandle<vehicleBaseObject>> Vehicles
		{
			get => GetProperty(ref _vehicles);
			set => SetProperty(ref _vehicles, value);
		}

		[Ordinal(55)] 
		[RED("viewers")] 
		public CArray<CWeakHandle<gameObject>> Viewers
		{
			get => GetProperty(ref _viewers);
			set => SetProperty(ref _viewers, value);
		}

		[Ordinal(56)] 
		[RED("hasViewers")] 
		public CBool HasViewers
		{
			get => GetProperty(ref _hasViewers);
			set => SetProperty(ref _hasViewers, value);
		}
	}
}
