using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
	{
		private CArray<SecurityAccessLevelEntry> _level_0;
		private CArray<SecurityAccessLevelEntry> _level_1;
		private CArray<SecurityAccessLevelEntry> _level_2;
		private CArray<SecurityAccessLevelEntry> _level_3;
		private CArray<SecurityAccessLevelEntry> _level_4;
		private CBool _allowSecuritySystemToDisableItself;
		private TweakDBID _attitudeGroup;
		private CBool _suppressAbilityToModifyAttitude;
		private CEnum<EShouldChangeAttitude> _attitudeChangeMode;
		private Time _performAutomaticResetAfter;
		private CBool _hideAreasOnMinimap;
		private CBool _isUnderStrictQuestControl;
		private CEnum<ESecuritySystemState> _securitySystemState;
		private CHandle<AgentRegistry> _agentsRegistry;
		private CHandle<SecuritySystemControllerPS> _securitySystem;
		private CFloat _latestOutputEngineTime;
		private CFloat _updateInterval;
		private CInt32 _restartDuration;
		private CArray<entEntityID> _protectedEntityIDs;
		private CArray<entEntityID> _entitiesRemainingAtGate;
		private CArray<CHandle<BlacklistEntry>> _blacklist;
		private CInt32 _currentReprimandID;
		private CBool _blacklistDelayValid;
		private gameDelayID _blacklistDelayID;
		private CInt32 _maxGlobalWarningsCount;
		private CBool _delayIDValid;
		private gameDelayID _deescalationEventID;
		private CInt32 _outputsSend;
		private CInt32 _inputsReceived;

		[Ordinal(105)] 
		[RED("level_0")] 
		public CArray<SecurityAccessLevelEntry> Level_0
		{
			get
			{
				if (_level_0 == null)
				{
					_level_0 = (CArray<SecurityAccessLevelEntry>) CR2WTypeManager.Create("array:SecurityAccessLevelEntry", "level_0", cr2w, this);
				}
				return _level_0;
			}
			set
			{
				if (_level_0 == value)
				{
					return;
				}
				_level_0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("level_1")] 
		public CArray<SecurityAccessLevelEntry> Level_1
		{
			get
			{
				if (_level_1 == null)
				{
					_level_1 = (CArray<SecurityAccessLevelEntry>) CR2WTypeManager.Create("array:SecurityAccessLevelEntry", "level_1", cr2w, this);
				}
				return _level_1;
			}
			set
			{
				if (_level_1 == value)
				{
					return;
				}
				_level_1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("level_2")] 
		public CArray<SecurityAccessLevelEntry> Level_2
		{
			get
			{
				if (_level_2 == null)
				{
					_level_2 = (CArray<SecurityAccessLevelEntry>) CR2WTypeManager.Create("array:SecurityAccessLevelEntry", "level_2", cr2w, this);
				}
				return _level_2;
			}
			set
			{
				if (_level_2 == value)
				{
					return;
				}
				_level_2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("level_3")] 
		public CArray<SecurityAccessLevelEntry> Level_3
		{
			get
			{
				if (_level_3 == null)
				{
					_level_3 = (CArray<SecurityAccessLevelEntry>) CR2WTypeManager.Create("array:SecurityAccessLevelEntry", "level_3", cr2w, this);
				}
				return _level_3;
			}
			set
			{
				if (_level_3 == value)
				{
					return;
				}
				_level_3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("level_4")] 
		public CArray<SecurityAccessLevelEntry> Level_4
		{
			get
			{
				if (_level_4 == null)
				{
					_level_4 = (CArray<SecurityAccessLevelEntry>) CR2WTypeManager.Create("array:SecurityAccessLevelEntry", "level_4", cr2w, this);
				}
				return _level_4;
			}
			set
			{
				if (_level_4 == value)
				{
					return;
				}
				_level_4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("allowSecuritySystemToDisableItself")] 
		public CBool AllowSecuritySystemToDisableItself
		{
			get
			{
				if (_allowSecuritySystemToDisableItself == null)
				{
					_allowSecuritySystemToDisableItself = (CBool) CR2WTypeManager.Create("Bool", "allowSecuritySystemToDisableItself", cr2w, this);
				}
				return _allowSecuritySystemToDisableItself;
			}
			set
			{
				if (_allowSecuritySystemToDisableItself == value)
				{
					return;
				}
				_allowSecuritySystemToDisableItself = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("attitudeGroup")] 
		public TweakDBID AttitudeGroup
		{
			get
			{
				if (_attitudeGroup == null)
				{
					_attitudeGroup = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attitudeGroup", cr2w, this);
				}
				return _attitudeGroup;
			}
			set
			{
				if (_attitudeGroup == value)
				{
					return;
				}
				_attitudeGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("suppressAbilityToModifyAttitude")] 
		public CBool SuppressAbilityToModifyAttitude
		{
			get
			{
				if (_suppressAbilityToModifyAttitude == null)
				{
					_suppressAbilityToModifyAttitude = (CBool) CR2WTypeManager.Create("Bool", "suppressAbilityToModifyAttitude", cr2w, this);
				}
				return _suppressAbilityToModifyAttitude;
			}
			set
			{
				if (_suppressAbilityToModifyAttitude == value)
				{
					return;
				}
				_suppressAbilityToModifyAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("attitudeChangeMode")] 
		public CEnum<EShouldChangeAttitude> AttitudeChangeMode
		{
			get
			{
				if (_attitudeChangeMode == null)
				{
					_attitudeChangeMode = (CEnum<EShouldChangeAttitude>) CR2WTypeManager.Create("EShouldChangeAttitude", "attitudeChangeMode", cr2w, this);
				}
				return _attitudeChangeMode;
			}
			set
			{
				if (_attitudeChangeMode == value)
				{
					return;
				}
				_attitudeChangeMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("performAutomaticResetAfter")] 
		public Time PerformAutomaticResetAfter
		{
			get
			{
				if (_performAutomaticResetAfter == null)
				{
					_performAutomaticResetAfter = (Time) CR2WTypeManager.Create("Time", "performAutomaticResetAfter", cr2w, this);
				}
				return _performAutomaticResetAfter;
			}
			set
			{
				if (_performAutomaticResetAfter == value)
				{
					return;
				}
				_performAutomaticResetAfter = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("hideAreasOnMinimap")] 
		public CBool HideAreasOnMinimap
		{
			get
			{
				if (_hideAreasOnMinimap == null)
				{
					_hideAreasOnMinimap = (CBool) CR2WTypeManager.Create("Bool", "hideAreasOnMinimap", cr2w, this);
				}
				return _hideAreasOnMinimap;
			}
			set
			{
				if (_hideAreasOnMinimap == value)
				{
					return;
				}
				_hideAreasOnMinimap = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("isUnderStrictQuestControl")] 
		public CBool IsUnderStrictQuestControl
		{
			get
			{
				if (_isUnderStrictQuestControl == null)
				{
					_isUnderStrictQuestControl = (CBool) CR2WTypeManager.Create("Bool", "isUnderStrictQuestControl", cr2w, this);
				}
				return _isUnderStrictQuestControl;
			}
			set
			{
				if (_isUnderStrictQuestControl == value)
				{
					return;
				}
				_isUnderStrictQuestControl = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("securitySystemState")] 
		public CEnum<ESecuritySystemState> SecuritySystemState
		{
			get
			{
				if (_securitySystemState == null)
				{
					_securitySystemState = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "securitySystemState", cr2w, this);
				}
				return _securitySystemState;
			}
			set
			{
				if (_securitySystemState == value)
				{
					return;
				}
				_securitySystemState = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("agentsRegistry")] 
		public CHandle<AgentRegistry> AgentsRegistry
		{
			get
			{
				if (_agentsRegistry == null)
				{
					_agentsRegistry = (CHandle<AgentRegistry>) CR2WTypeManager.Create("handle:AgentRegistry", "agentsRegistry", cr2w, this);
				}
				return _agentsRegistry;
			}
			set
			{
				if (_agentsRegistry == value)
				{
					return;
				}
				_agentsRegistry = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("securitySystem")] 
		public CHandle<SecuritySystemControllerPS> SecuritySystem
		{
			get
			{
				if (_securitySystem == null)
				{
					_securitySystem = (CHandle<SecuritySystemControllerPS>) CR2WTypeManager.Create("handle:SecuritySystemControllerPS", "securitySystem", cr2w, this);
				}
				return _securitySystem;
			}
			set
			{
				if (_securitySystem == value)
				{
					return;
				}
				_securitySystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("latestOutputEngineTime")] 
		public CFloat LatestOutputEngineTime
		{
			get
			{
				if (_latestOutputEngineTime == null)
				{
					_latestOutputEngineTime = (CFloat) CR2WTypeManager.Create("Float", "latestOutputEngineTime", cr2w, this);
				}
				return _latestOutputEngineTime;
			}
			set
			{
				if (_latestOutputEngineTime == value)
				{
					return;
				}
				_latestOutputEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("updateInterval")] 
		public CFloat UpdateInterval
		{
			get
			{
				if (_updateInterval == null)
				{
					_updateInterval = (CFloat) CR2WTypeManager.Create("Float", "updateInterval", cr2w, this);
				}
				return _updateInterval;
			}
			set
			{
				if (_updateInterval == value)
				{
					return;
				}
				_updateInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get
			{
				if (_restartDuration == null)
				{
					_restartDuration = (CInt32) CR2WTypeManager.Create("Int32", "restartDuration", cr2w, this);
				}
				return _restartDuration;
			}
			set
			{
				if (_restartDuration == value)
				{
					return;
				}
				_restartDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("protectedEntityIDs")] 
		public CArray<entEntityID> ProtectedEntityIDs
		{
			get
			{
				if (_protectedEntityIDs == null)
				{
					_protectedEntityIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "protectedEntityIDs", cr2w, this);
				}
				return _protectedEntityIDs;
			}
			set
			{
				if (_protectedEntityIDs == value)
				{
					return;
				}
				_protectedEntityIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("entitiesRemainingAtGate")] 
		public CArray<entEntityID> EntitiesRemainingAtGate
		{
			get
			{
				if (_entitiesRemainingAtGate == null)
				{
					_entitiesRemainingAtGate = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "entitiesRemainingAtGate", cr2w, this);
				}
				return _entitiesRemainingAtGate;
			}
			set
			{
				if (_entitiesRemainingAtGate == value)
				{
					return;
				}
				_entitiesRemainingAtGate = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("blacklist")] 
		public CArray<CHandle<BlacklistEntry>> Blacklist
		{
			get
			{
				if (_blacklist == null)
				{
					_blacklist = (CArray<CHandle<BlacklistEntry>>) CR2WTypeManager.Create("array:handle:BlacklistEntry", "blacklist", cr2w, this);
				}
				return _blacklist;
			}
			set
			{
				if (_blacklist == value)
				{
					return;
				}
				_blacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("currentReprimandID")] 
		public CInt32 CurrentReprimandID
		{
			get
			{
				if (_currentReprimandID == null)
				{
					_currentReprimandID = (CInt32) CR2WTypeManager.Create("Int32", "currentReprimandID", cr2w, this);
				}
				return _currentReprimandID;
			}
			set
			{
				if (_currentReprimandID == value)
				{
					return;
				}
				_currentReprimandID = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("blacklistDelayValid")] 
		public CBool BlacklistDelayValid
		{
			get
			{
				if (_blacklistDelayValid == null)
				{
					_blacklistDelayValid = (CBool) CR2WTypeManager.Create("Bool", "blacklistDelayValid", cr2w, this);
				}
				return _blacklistDelayValid;
			}
			set
			{
				if (_blacklistDelayValid == value)
				{
					return;
				}
				_blacklistDelayValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("blacklistDelayID")] 
		public gameDelayID BlacklistDelayID
		{
			get
			{
				if (_blacklistDelayID == null)
				{
					_blacklistDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "blacklistDelayID", cr2w, this);
				}
				return _blacklistDelayID;
			}
			set
			{
				if (_blacklistDelayID == value)
				{
					return;
				}
				_blacklistDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("maxGlobalWarningsCount")] 
		public CInt32 MaxGlobalWarningsCount
		{
			get
			{
				if (_maxGlobalWarningsCount == null)
				{
					_maxGlobalWarningsCount = (CInt32) CR2WTypeManager.Create("Int32", "maxGlobalWarningsCount", cr2w, this);
				}
				return _maxGlobalWarningsCount;
			}
			set
			{
				if (_maxGlobalWarningsCount == value)
				{
					return;
				}
				_maxGlobalWarningsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("delayIDValid")] 
		public CBool DelayIDValid
		{
			get
			{
				if (_delayIDValid == null)
				{
					_delayIDValid = (CBool) CR2WTypeManager.Create("Bool", "delayIDValid", cr2w, this);
				}
				return _delayIDValid;
			}
			set
			{
				if (_delayIDValid == value)
				{
					return;
				}
				_delayIDValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("deescalationEventID")] 
		public gameDelayID DeescalationEventID
		{
			get
			{
				if (_deescalationEventID == null)
				{
					_deescalationEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "deescalationEventID", cr2w, this);
				}
				return _deescalationEventID;
			}
			set
			{
				if (_deescalationEventID == value)
				{
					return;
				}
				_deescalationEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("outputsSend")] 
		public CInt32 OutputsSend
		{
			get
			{
				if (_outputsSend == null)
				{
					_outputsSend = (CInt32) CR2WTypeManager.Create("Int32", "outputsSend", cr2w, this);
				}
				return _outputsSend;
			}
			set
			{
				if (_outputsSend == value)
				{
					return;
				}
				_outputsSend = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("inputsReceived")] 
		public CInt32 InputsReceived
		{
			get
			{
				if (_inputsReceived == null)
				{
					_inputsReceived = (CInt32) CR2WTypeManager.Create("Int32", "inputsReceived", cr2w, this);
				}
				return _inputsReceived;
			}
			set
			{
				if (_inputsReceived == value)
				{
					return;
				}
				_inputsReceived = value;
				PropertySet(this);
			}
		}

		public SecuritySystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
