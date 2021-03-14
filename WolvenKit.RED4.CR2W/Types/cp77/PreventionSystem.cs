using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSystem : gameScriptableSystem
	{
		private CHandle<DistrictManager> _districtManager;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gamedataDistrictPreventionData_Record> _preventionPreset;
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
		private CArray<wCHandle<ScriptedPuppet>> _spawnedAgents;
		private Vector4 _lastCrimePoint;
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
		private CHandle<PreventionDelayedSpawnRequest> _spawnDelayedEvt;
		private gameDelayID _preventionTickDelayID;
		private CBool _preventionTickCheck;
		private gameDelayID _securityAreaResetDelayID;
		private CBool _securityAreaResetCheck;
		private CEnum<EPreventionDebugProcessReason> _debug_PorcessReason;
		private CEnum<EPreventionPsychoLogicType> _debug_PsychoLogicType;
		private TweakDBID _currentPreventionPreset;
		private TweakDBID _failsafePoliceRecordT1;
		private TweakDBID _failsafePoliceRecordT2;
		private TweakDBID _failsafePoliceRecordT3;
		private CArray<CName> _blinkReasonsStack;
		private wCHandle<gameIBlackboard> _wantedBarBlackboard;
		private CUInt32 _onPlayerChoiceCallID;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CUInt32 _playerHLSID;
		private CUInt32 _playerVehicleStateID;
		private CEnum<gamePSMHighLevel> _playerHLS;
		private CEnum<gamePSMVehicle> _playerVehicleState;
		private CArray<wCHandle<vehicleBaseObject>> _vehicles;
		private CArray<wCHandle<gameObject>> _viewers;

		[Ordinal(0)] 
		[RED("districtManager")] 
		public CHandle<DistrictManager> DistrictManager
		{
			get
			{
				if (_districtManager == null)
				{
					_districtManager = (CHandle<DistrictManager>) CR2WTypeManager.Create("handle:DistrictManager", "districtManager", cr2w, this);
				}
				return _districtManager;
			}
			set
			{
				if (_districtManager == value)
				{
					return;
				}
				_districtManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("preventionPreset")] 
		public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get
			{
				if (_preventionPreset == null)
				{
					_preventionPreset = (wCHandle<gamedataDistrictPreventionData_Record>) CR2WTypeManager.Create("whandle:gamedataDistrictPreventionData_Record", "preventionPreset", cr2w, this);
				}
				return _preventionPreset;
			}
			set
			{
				if (_preventionPreset == value)
				{
					return;
				}
				_preventionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hiddenReaction")] 
		public CBool HiddenReaction
		{
			get
			{
				if (_hiddenReaction == null)
				{
					_hiddenReaction = (CBool) CR2WTypeManager.Create("Bool", "hiddenReaction", cr2w, this);
				}
				return _hiddenReaction;
			}
			set
			{
				if (_hiddenReaction == value)
				{
					return;
				}
				_hiddenReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("systemDisabled")] 
		public CBool SystemDisabled
		{
			get
			{
				if (_systemDisabled == null)
				{
					_systemDisabled = (CBool) CR2WTypeManager.Create("Bool", "systemDisabled", cr2w, this);
				}
				return _systemDisabled;
			}
			set
			{
				if (_systemDisabled == value)
				{
					return;
				}
				_systemDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get
			{
				if (_systemLockSources == null)
				{
					_systemLockSources = (CArray<CName>) CR2WTypeManager.Create("array:CName", "systemLockSources", cr2w, this);
				}
				return _systemLockSources;
			}
			set
			{
				if (_systemLockSources == value)
				{
					return;
				}
				_systemLockSources = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("deescalationZeroLockExecution")] 
		public CBool DeescalationZeroLockExecution
		{
			get
			{
				if (_deescalationZeroLockExecution == null)
				{
					_deescalationZeroLockExecution = (CBool) CR2WTypeManager.Create("Bool", "deescalationZeroLockExecution", cr2w, this);
				}
				return _deescalationZeroLockExecution;
			}
			set
			{
				if (_deescalationZeroLockExecution == value)
				{
					return;
				}
				_deescalationZeroLockExecution = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get
			{
				if (_heatStage == null)
				{
					_heatStage = (CEnum<EPreventionHeatStage>) CR2WTypeManager.Create("EPreventionHeatStage", "heatStage", cr2w, this);
				}
				return _heatStage;
			}
			set
			{
				if (_heatStage == value)
				{
					return;
				}
				_heatStage = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get
			{
				if (_playerIsInSecurityArea == null)
				{
					_playerIsInSecurityArea = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "playerIsInSecurityArea", cr2w, this);
				}
				return _playerIsInSecurityArea;
			}
			set
			{
				if (_playerIsInSecurityArea == value)
				{
					return;
				}
				_playerIsInSecurityArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get
			{
				if (_policeSecuritySystems == null)
				{
					_policeSecuritySystems = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "policeSecuritySystems", cr2w, this);
				}
				return _policeSecuritySystems;
			}
			set
			{
				if (_policeSecuritySystems == value)
				{
					return;
				}
				_policeSecuritySystems = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("policeman100SpawnHits")] 
		public CInt32 Policeman100SpawnHits
		{
			get
			{
				if (_policeman100SpawnHits == null)
				{
					_policeman100SpawnHits = (CInt32) CR2WTypeManager.Create("Int32", "policeman100SpawnHits", cr2w, this);
				}
				return _policeman100SpawnHits;
			}
			set
			{
				if (_policeman100SpawnHits == value)
				{
					return;
				}
				_policeman100SpawnHits = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get
			{
				if (_agentGroupsList == null)
				{
					_agentGroupsList = (CArray<CHandle<PreventionAgents>>) CR2WTypeManager.Create("array:handle:PreventionAgents", "agentGroupsList", cr2w, this);
				}
				return _agentGroupsList;
			}
			set
			{
				if (_agentGroupsList == value)
				{
					return;
				}
				_agentGroupsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("agentsWhoSeePlayer")] 
		public CArray<entEntityID> AgentsWhoSeePlayer
		{
			get
			{
				if (_agentsWhoSeePlayer == null)
				{
					_agentsWhoSeePlayer = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "agentsWhoSeePlayer", cr2w, this);
				}
				return _agentsWhoSeePlayer;
			}
			set
			{
				if (_agentsWhoSeePlayer == value)
				{
					return;
				}
				_agentsWhoSeePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hitNPC")] 
		public CArray<SHitNPC> HitNPC
		{
			get
			{
				if (_hitNPC == null)
				{
					_hitNPC = (CArray<SHitNPC>) CR2WTypeManager.Create("array:SHitNPC", "hitNPC", cr2w, this);
				}
				return _hitNPC;
			}
			set
			{
				if (_hitNPC == value)
				{
					return;
				}
				_hitNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("spawnedAgents")] 
		public CArray<wCHandle<ScriptedPuppet>> SpawnedAgents
		{
			get
			{
				if (_spawnedAgents == null)
				{
					_spawnedAgents = (CArray<wCHandle<ScriptedPuppet>>) CR2WTypeManager.Create("array:whandle:ScriptedPuppet", "spawnedAgents", cr2w, this);
				}
				return _spawnedAgents;
			}
			set
			{
				if (_spawnedAgents == value)
				{
					return;
				}
				_spawnedAgents = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lastCrimePoint")] 
		public Vector4 LastCrimePoint
		{
			get
			{
				if (_lastCrimePoint == null)
				{
					_lastCrimePoint = (Vector4) CR2WTypeManager.Create("Vector4", "lastCrimePoint", cr2w, this);
				}
				return _lastCrimePoint;
			}
			set
			{
				if (_lastCrimePoint == value)
				{
					return;
				}
				_lastCrimePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("DEBUG_lastCrimeDistance")] 
		public CFloat DEBUG_lastCrimeDistance
		{
			get
			{
				if (_dEBUG_lastCrimeDistance == null)
				{
					_dEBUG_lastCrimeDistance = (CFloat) CR2WTypeManager.Create("Float", "DEBUG_lastCrimeDistance", cr2w, this);
				}
				return _dEBUG_lastCrimeDistance;
			}
			set
			{
				if (_dEBUG_lastCrimeDistance == value)
				{
					return;
				}
				_dEBUG_lastCrimeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("policemanRandPercent")] 
		public CInt32 PolicemanRandPercent
		{
			get
			{
				if (_policemanRandPercent == null)
				{
					_policemanRandPercent = (CInt32) CR2WTypeManager.Create("Int32", "policemanRandPercent", cr2w, this);
				}
				return _policemanRandPercent;
			}
			set
			{
				if (_policemanRandPercent == value)
				{
					return;
				}
				_policemanRandPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("policemabProbabilityPercent")] 
		public CInt32 PolicemabProbabilityPercent
		{
			get
			{
				if (_policemabProbabilityPercent == null)
				{
					_policemabProbabilityPercent = (CInt32) CR2WTypeManager.Create("Int32", "policemabProbabilityPercent", cr2w, this);
				}
				return _policemabProbabilityPercent;
			}
			set
			{
				if (_policemabProbabilityPercent == value)
				{
					return;
				}
				_policemabProbabilityPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("generalPercent")] 
		public CFloat GeneralPercent
		{
			get
			{
				if (_generalPercent == null)
				{
					_generalPercent = (CFloat) CR2WTypeManager.Create("Float", "generalPercent", cr2w, this);
				}
				return _generalPercent;
			}
			set
			{
				if (_generalPercent == value)
				{
					return;
				}
				_generalPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("partGeneralPercent")] 
		public CFloat PartGeneralPercent
		{
			get
			{
				if (_partGeneralPercent == null)
				{
					_partGeneralPercent = (CFloat) CR2WTypeManager.Create("Float", "partGeneralPercent", cr2w, this);
				}
				return _partGeneralPercent;
			}
			set
			{
				if (_partGeneralPercent == value)
				{
					return;
				}
				_partGeneralPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("newDamageValue")] 
		public CFloat NewDamageValue
		{
			get
			{
				if (_newDamageValue == null)
				{
					_newDamageValue = (CFloat) CR2WTypeManager.Create("Float", "newDamageValue", cr2w, this);
				}
				return _newDamageValue;
			}
			set
			{
				if (_newDamageValue == value)
				{
					return;
				}
				_newDamageValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("gameTimeStampPrevious")] 
		public CFloat GameTimeStampPrevious
		{
			get
			{
				if (_gameTimeStampPrevious == null)
				{
					_gameTimeStampPrevious = (CFloat) CR2WTypeManager.Create("Float", "gameTimeStampPrevious", cr2w, this);
				}
				return _gameTimeStampPrevious;
			}
			set
			{
				if (_gameTimeStampPrevious == value)
				{
					return;
				}
				_gameTimeStampPrevious = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("gameTimeStampLastPoliceRise")] 
		public CFloat GameTimeStampLastPoliceRise
		{
			get
			{
				if (_gameTimeStampLastPoliceRise == null)
				{
					_gameTimeStampLastPoliceRise = (CFloat) CR2WTypeManager.Create("Float", "gameTimeStampLastPoliceRise", cr2w, this);
				}
				return _gameTimeStampLastPoliceRise;
			}
			set
			{
				if (_gameTimeStampLastPoliceRise == value)
				{
					return;
				}
				_gameTimeStampLastPoliceRise = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("gameTimeStampDeescalationZero")] 
		public CFloat GameTimeStampDeescalationZero
		{
			get
			{
				if (_gameTimeStampDeescalationZero == null)
				{
					_gameTimeStampDeescalationZero = (CFloat) CR2WTypeManager.Create("Float", "gameTimeStampDeescalationZero", cr2w, this);
				}
				return _gameTimeStampDeescalationZero;
			}
			set
			{
				if (_gameTimeStampDeescalationZero == value)
				{
					return;
				}
				_gameTimeStampDeescalationZero = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("deescalationZeroDelayID")] 
		public gameDelayID DeescalationZeroDelayID
		{
			get
			{
				if (_deescalationZeroDelayID == null)
				{
					_deescalationZeroDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "deescalationZeroDelayID", cr2w, this);
				}
				return _deescalationZeroDelayID;
			}
			set
			{
				if (_deescalationZeroDelayID == value)
				{
					return;
				}
				_deescalationZeroDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("deescalationZeroCheck")] 
		public CBool DeescalationZeroCheck
		{
			get
			{
				if (_deescalationZeroCheck == null)
				{
					_deescalationZeroCheck = (CBool) CR2WTypeManager.Create("Bool", "deescalationZeroCheck", cr2w, this);
				}
				return _deescalationZeroCheck;
			}
			set
			{
				if (_deescalationZeroCheck == value)
				{
					return;
				}
				_deescalationZeroCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get
			{
				if (_policemenSpawnDelayID == null)
				{
					_policemenSpawnDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "policemenSpawnDelayID", cr2w, this);
				}
				return _policemenSpawnDelayID;
			}
			set
			{
				if (_policemenSpawnDelayID == value)
				{
					return;
				}
				_policemenSpawnDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("spawnDelayedEvt")] 
		public CHandle<PreventionDelayedSpawnRequest> SpawnDelayedEvt
		{
			get
			{
				if (_spawnDelayedEvt == null)
				{
					_spawnDelayedEvt = (CHandle<PreventionDelayedSpawnRequest>) CR2WTypeManager.Create("handle:PreventionDelayedSpawnRequest", "spawnDelayedEvt", cr2w, this);
				}
				return _spawnDelayedEvt;
			}
			set
			{
				if (_spawnDelayedEvt == value)
				{
					return;
				}
				_spawnDelayedEvt = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("preventionTickDelayID")] 
		public gameDelayID PreventionTickDelayID
		{
			get
			{
				if (_preventionTickDelayID == null)
				{
					_preventionTickDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "preventionTickDelayID", cr2w, this);
				}
				return _preventionTickDelayID;
			}
			set
			{
				if (_preventionTickDelayID == value)
				{
					return;
				}
				_preventionTickDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("preventionTickCheck")] 
		public CBool PreventionTickCheck
		{
			get
			{
				if (_preventionTickCheck == null)
				{
					_preventionTickCheck = (CBool) CR2WTypeManager.Create("Bool", "preventionTickCheck", cr2w, this);
				}
				return _preventionTickCheck;
			}
			set
			{
				if (_preventionTickCheck == value)
				{
					return;
				}
				_preventionTickCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get
			{
				if (_securityAreaResetDelayID == null)
				{
					_securityAreaResetDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "securityAreaResetDelayID", cr2w, this);
				}
				return _securityAreaResetDelayID;
			}
			set
			{
				if (_securityAreaResetDelayID == value)
				{
					return;
				}
				_securityAreaResetDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get
			{
				if (_securityAreaResetCheck == null)
				{
					_securityAreaResetCheck = (CBool) CR2WTypeManager.Create("Bool", "securityAreaResetCheck", cr2w, this);
				}
				return _securityAreaResetCheck;
			}
			set
			{
				if (_securityAreaResetCheck == value)
				{
					return;
				}
				_securityAreaResetCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("Debug_PorcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_PorcessReason
		{
			get
			{
				if (_debug_PorcessReason == null)
				{
					_debug_PorcessReason = (CEnum<EPreventionDebugProcessReason>) CR2WTypeManager.Create("EPreventionDebugProcessReason", "Debug_PorcessReason", cr2w, this);
				}
				return _debug_PorcessReason;
			}
			set
			{
				if (_debug_PorcessReason == value)
				{
					return;
				}
				_debug_PorcessReason = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("Debug_PsychoLogicType")] 
		public CEnum<EPreventionPsychoLogicType> Debug_PsychoLogicType
		{
			get
			{
				if (_debug_PsychoLogicType == null)
				{
					_debug_PsychoLogicType = (CEnum<EPreventionPsychoLogicType>) CR2WTypeManager.Create("EPreventionPsychoLogicType", "Debug_PsychoLogicType", cr2w, this);
				}
				return _debug_PsychoLogicType;
			}
			set
			{
				if (_debug_PsychoLogicType == value)
				{
					return;
				}
				_debug_PsychoLogicType = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("currentPreventionPreset")] 
		public TweakDBID CurrentPreventionPreset
		{
			get
			{
				if (_currentPreventionPreset == null)
				{
					_currentPreventionPreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "currentPreventionPreset", cr2w, this);
				}
				return _currentPreventionPreset;
			}
			set
			{
				if (_currentPreventionPreset == value)
				{
					return;
				}
				_currentPreventionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get
			{
				if (_failsafePoliceRecordT1 == null)
				{
					_failsafePoliceRecordT1 = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "failsafePoliceRecordT1", cr2w, this);
				}
				return _failsafePoliceRecordT1;
			}
			set
			{
				if (_failsafePoliceRecordT1 == value)
				{
					return;
				}
				_failsafePoliceRecordT1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get
			{
				if (_failsafePoliceRecordT2 == null)
				{
					_failsafePoliceRecordT2 = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "failsafePoliceRecordT2", cr2w, this);
				}
				return _failsafePoliceRecordT2;
			}
			set
			{
				if (_failsafePoliceRecordT2 == value)
				{
					return;
				}
				_failsafePoliceRecordT2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get
			{
				if (_failsafePoliceRecordT3 == null)
				{
					_failsafePoliceRecordT3 = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "failsafePoliceRecordT3", cr2w, this);
				}
				return _failsafePoliceRecordT3;
			}
			set
			{
				if (_failsafePoliceRecordT3 == value)
				{
					return;
				}
				_failsafePoliceRecordT3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get
			{
				if (_blinkReasonsStack == null)
				{
					_blinkReasonsStack = (CArray<CName>) CR2WTypeManager.Create("array:CName", "blinkReasonsStack", cr2w, this);
				}
				return _blinkReasonsStack;
			}
			set
			{
				if (_blinkReasonsStack == value)
				{
					return;
				}
				_blinkReasonsStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("wantedBarBlackboard")] 
		public wCHandle<gameIBlackboard> WantedBarBlackboard
		{
			get
			{
				if (_wantedBarBlackboard == null)
				{
					_wantedBarBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "wantedBarBlackboard", cr2w, this);
				}
				return _wantedBarBlackboard;
			}
			set
			{
				if (_wantedBarBlackboard == value)
				{
					return;
				}
				_wantedBarBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("onPlayerChoiceCallID")] 
		public CUInt32 OnPlayerChoiceCallID
		{
			get
			{
				if (_onPlayerChoiceCallID == null)
				{
					_onPlayerChoiceCallID = (CUInt32) CR2WTypeManager.Create("Uint32", "onPlayerChoiceCallID", cr2w, this);
				}
				return _onPlayerChoiceCallID;
			}
			set
			{
				if (_onPlayerChoiceCallID == value)
				{
					return;
				}
				_onPlayerChoiceCallID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get
			{
				if (_playerAttachedCallbackID == null)
				{
					_playerAttachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerAttachedCallbackID", cr2w, this);
				}
				return _playerAttachedCallbackID;
			}
			set
			{
				if (_playerAttachedCallbackID == value)
				{
					return;
				}
				_playerAttachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get
			{
				if (_playerDetachedCallbackID == null)
				{
					_playerDetachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerDetachedCallbackID", cr2w, this);
				}
				return _playerDetachedCallbackID;
			}
			set
			{
				if (_playerDetachedCallbackID == value)
				{
					return;
				}
				_playerDetachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("playerHLSID")] 
		public CUInt32 PlayerHLSID
		{
			get
			{
				if (_playerHLSID == null)
				{
					_playerHLSID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerHLSID", cr2w, this);
				}
				return _playerHLSID;
			}
			set
			{
				if (_playerHLSID == value)
				{
					return;
				}
				_playerHLSID = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("playerVehicleStateID")] 
		public CUInt32 PlayerVehicleStateID
		{
			get
			{
				if (_playerVehicleStateID == null)
				{
					_playerVehicleStateID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerVehicleStateID", cr2w, this);
				}
				return _playerVehicleStateID;
			}
			set
			{
				if (_playerVehicleStateID == value)
				{
					return;
				}
				_playerVehicleStateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get
			{
				if (_playerHLS == null)
				{
					_playerHLS = (CEnum<gamePSMHighLevel>) CR2WTypeManager.Create("gamePSMHighLevel", "playerHLS", cr2w, this);
				}
				return _playerHLS;
			}
			set
			{
				if (_playerHLS == value)
				{
					return;
				}
				_playerHLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get
			{
				if (_playerVehicleState == null)
				{
					_playerVehicleState = (CEnum<gamePSMVehicle>) CR2WTypeManager.Create("gamePSMVehicle", "playerVehicleState", cr2w, this);
				}
				return _playerVehicleState;
			}
			set
			{
				if (_playerVehicleState == value)
				{
					return;
				}
				_playerVehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("vehicles")] 
		public CArray<wCHandle<vehicleBaseObject>> Vehicles
		{
			get
			{
				if (_vehicles == null)
				{
					_vehicles = (CArray<wCHandle<vehicleBaseObject>>) CR2WTypeManager.Create("array:whandle:vehicleBaseObject", "vehicles", cr2w, this);
				}
				return _vehicles;
			}
			set
			{
				if (_vehicles == value)
				{
					return;
				}
				_vehicles = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("viewers")] 
		public CArray<wCHandle<gameObject>> Viewers
		{
			get
			{
				if (_viewers == null)
				{
					_viewers = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "viewers", cr2w, this);
				}
				return _viewers;
			}
			set
			{
				if (_viewers == value)
				{
					return;
				}
				_viewers = value;
				PropertySet(this);
			}
		}

		public PreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
