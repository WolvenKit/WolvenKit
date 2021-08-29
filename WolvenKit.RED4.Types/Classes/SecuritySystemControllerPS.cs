using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
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

		[Ordinal(106)] 
		[RED("level_0")] 
		public CArray<SecurityAccessLevelEntry> Level_0
		{
			get => GetProperty(ref _level_0);
			set => SetProperty(ref _level_0, value);
		}

		[Ordinal(107)] 
		[RED("level_1")] 
		public CArray<SecurityAccessLevelEntry> Level_1
		{
			get => GetProperty(ref _level_1);
			set => SetProperty(ref _level_1, value);
		}

		[Ordinal(108)] 
		[RED("level_2")] 
		public CArray<SecurityAccessLevelEntry> Level_2
		{
			get => GetProperty(ref _level_2);
			set => SetProperty(ref _level_2, value);
		}

		[Ordinal(109)] 
		[RED("level_3")] 
		public CArray<SecurityAccessLevelEntry> Level_3
		{
			get => GetProperty(ref _level_3);
			set => SetProperty(ref _level_3, value);
		}

		[Ordinal(110)] 
		[RED("level_4")] 
		public CArray<SecurityAccessLevelEntry> Level_4
		{
			get => GetProperty(ref _level_4);
			set => SetProperty(ref _level_4, value);
		}

		[Ordinal(111)] 
		[RED("allowSecuritySystemToDisableItself")] 
		public CBool AllowSecuritySystemToDisableItself
		{
			get => GetProperty(ref _allowSecuritySystemToDisableItself);
			set => SetProperty(ref _allowSecuritySystemToDisableItself, value);
		}

		[Ordinal(112)] 
		[RED("attitudeGroup")] 
		public TweakDBID AttitudeGroup
		{
			get => GetProperty(ref _attitudeGroup);
			set => SetProperty(ref _attitudeGroup, value);
		}

		[Ordinal(113)] 
		[RED("suppressAbilityToModifyAttitude")] 
		public CBool SuppressAbilityToModifyAttitude
		{
			get => GetProperty(ref _suppressAbilityToModifyAttitude);
			set => SetProperty(ref _suppressAbilityToModifyAttitude, value);
		}

		[Ordinal(114)] 
		[RED("attitudeChangeMode")] 
		public CEnum<EShouldChangeAttitude> AttitudeChangeMode
		{
			get => GetProperty(ref _attitudeChangeMode);
			set => SetProperty(ref _attitudeChangeMode, value);
		}

		[Ordinal(115)] 
		[RED("performAutomaticResetAfter")] 
		public Time PerformAutomaticResetAfter
		{
			get => GetProperty(ref _performAutomaticResetAfter);
			set => SetProperty(ref _performAutomaticResetAfter, value);
		}

		[Ordinal(116)] 
		[RED("hideAreasOnMinimap")] 
		public CBool HideAreasOnMinimap
		{
			get => GetProperty(ref _hideAreasOnMinimap);
			set => SetProperty(ref _hideAreasOnMinimap, value);
		}

		[Ordinal(117)] 
		[RED("isUnderStrictQuestControl")] 
		public CBool IsUnderStrictQuestControl
		{
			get => GetProperty(ref _isUnderStrictQuestControl);
			set => SetProperty(ref _isUnderStrictQuestControl, value);
		}

		[Ordinal(118)] 
		[RED("securitySystemState")] 
		public CEnum<ESecuritySystemState> SecuritySystemState
		{
			get => GetProperty(ref _securitySystemState);
			set => SetProperty(ref _securitySystemState, value);
		}

		[Ordinal(119)] 
		[RED("agentsRegistry")] 
		public CHandle<AgentRegistry> AgentsRegistry
		{
			get => GetProperty(ref _agentsRegistry);
			set => SetProperty(ref _agentsRegistry, value);
		}

		[Ordinal(120)] 
		[RED("securitySystem")] 
		public CHandle<SecuritySystemControllerPS> SecuritySystem
		{
			get => GetProperty(ref _securitySystem);
			set => SetProperty(ref _securitySystem, value);
		}

		[Ordinal(121)] 
		[RED("latestOutputEngineTime")] 
		public CFloat LatestOutputEngineTime
		{
			get => GetProperty(ref _latestOutputEngineTime);
			set => SetProperty(ref _latestOutputEngineTime, value);
		}

		[Ordinal(122)] 
		[RED("updateInterval")] 
		public CFloat UpdateInterval
		{
			get => GetProperty(ref _updateInterval);
			set => SetProperty(ref _updateInterval, value);
		}

		[Ordinal(123)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetProperty(ref _restartDuration);
			set => SetProperty(ref _restartDuration, value);
		}

		[Ordinal(124)] 
		[RED("protectedEntityIDs")] 
		public CArray<entEntityID> ProtectedEntityIDs
		{
			get => GetProperty(ref _protectedEntityIDs);
			set => SetProperty(ref _protectedEntityIDs, value);
		}

		[Ordinal(125)] 
		[RED("entitiesRemainingAtGate")] 
		public CArray<entEntityID> EntitiesRemainingAtGate
		{
			get => GetProperty(ref _entitiesRemainingAtGate);
			set => SetProperty(ref _entitiesRemainingAtGate, value);
		}

		[Ordinal(126)] 
		[RED("blacklist")] 
		public CArray<CHandle<BlacklistEntry>> Blacklist
		{
			get => GetProperty(ref _blacklist);
			set => SetProperty(ref _blacklist, value);
		}

		[Ordinal(127)] 
		[RED("currentReprimandID")] 
		public CInt32 CurrentReprimandID
		{
			get => GetProperty(ref _currentReprimandID);
			set => SetProperty(ref _currentReprimandID, value);
		}

		[Ordinal(128)] 
		[RED("blacklistDelayValid")] 
		public CBool BlacklistDelayValid
		{
			get => GetProperty(ref _blacklistDelayValid);
			set => SetProperty(ref _blacklistDelayValid, value);
		}

		[Ordinal(129)] 
		[RED("blacklistDelayID")] 
		public gameDelayID BlacklistDelayID
		{
			get => GetProperty(ref _blacklistDelayID);
			set => SetProperty(ref _blacklistDelayID, value);
		}

		[Ordinal(130)] 
		[RED("maxGlobalWarningsCount")] 
		public CInt32 MaxGlobalWarningsCount
		{
			get => GetProperty(ref _maxGlobalWarningsCount);
			set => SetProperty(ref _maxGlobalWarningsCount, value);
		}

		[Ordinal(131)] 
		[RED("delayIDValid")] 
		public CBool DelayIDValid
		{
			get => GetProperty(ref _delayIDValid);
			set => SetProperty(ref _delayIDValid, value);
		}

		[Ordinal(132)] 
		[RED("deescalationEventID")] 
		public gameDelayID DeescalationEventID
		{
			get => GetProperty(ref _deescalationEventID);
			set => SetProperty(ref _deescalationEventID, value);
		}

		[Ordinal(133)] 
		[RED("outputsSend")] 
		public CInt32 OutputsSend
		{
			get => GetProperty(ref _outputsSend);
			set => SetProperty(ref _outputsSend, value);
		}

		[Ordinal(134)] 
		[RED("inputsReceived")] 
		public CInt32 InputsReceived
		{
			get => GetProperty(ref _inputsReceived);
			set => SetProperty(ref _inputsReceived, value);
		}
	}
}
