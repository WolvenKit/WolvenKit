using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(106)] 
		[RED("level_0")] 
		public CArray<SecurityAccessLevelEntry> Level_0
		{
			get => GetPropertyValue<CArray<SecurityAccessLevelEntry>>();
			set => SetPropertyValue<CArray<SecurityAccessLevelEntry>>(value);
		}

		[Ordinal(107)] 
		[RED("level_1")] 
		public CArray<SecurityAccessLevelEntry> Level_1
		{
			get => GetPropertyValue<CArray<SecurityAccessLevelEntry>>();
			set => SetPropertyValue<CArray<SecurityAccessLevelEntry>>(value);
		}

		[Ordinal(108)] 
		[RED("level_2")] 
		public CArray<SecurityAccessLevelEntry> Level_2
		{
			get => GetPropertyValue<CArray<SecurityAccessLevelEntry>>();
			set => SetPropertyValue<CArray<SecurityAccessLevelEntry>>(value);
		}

		[Ordinal(109)] 
		[RED("level_3")] 
		public CArray<SecurityAccessLevelEntry> Level_3
		{
			get => GetPropertyValue<CArray<SecurityAccessLevelEntry>>();
			set => SetPropertyValue<CArray<SecurityAccessLevelEntry>>(value);
		}

		[Ordinal(110)] 
		[RED("level_4")] 
		public CArray<SecurityAccessLevelEntry> Level_4
		{
			get => GetPropertyValue<CArray<SecurityAccessLevelEntry>>();
			set => SetPropertyValue<CArray<SecurityAccessLevelEntry>>(value);
		}

		[Ordinal(111)] 
		[RED("allowSecuritySystemToDisableItself")] 
		public CBool AllowSecuritySystemToDisableItself
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("attitudeGroup")] 
		public TweakDBID AttitudeGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("suppressAbilityToModifyAttitude")] 
		public CBool SuppressAbilityToModifyAttitude
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("attitudeChangeMode")] 
		public CEnum<EShouldChangeAttitude> AttitudeChangeMode
		{
			get => GetPropertyValue<CEnum<EShouldChangeAttitude>>();
			set => SetPropertyValue<CEnum<EShouldChangeAttitude>>(value);
		}

		[Ordinal(115)] 
		[RED("performAutomaticResetAfter")] 
		public Time PerformAutomaticResetAfter
		{
			get => GetPropertyValue<Time>();
			set => SetPropertyValue<Time>(value);
		}

		[Ordinal(116)] 
		[RED("hideAreasOnMinimap")] 
		public CBool HideAreasOnMinimap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("isUnderStrictQuestControl")] 
		public CBool IsUnderStrictQuestControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("securitySystemState")] 
		public CEnum<ESecuritySystemState> SecuritySystemState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		[Ordinal(119)] 
		[RED("agentsRegistry")] 
		public CHandle<AgentRegistry> AgentsRegistry
		{
			get => GetPropertyValue<CHandle<AgentRegistry>>();
			set => SetPropertyValue<CHandle<AgentRegistry>>(value);
		}

		[Ordinal(120)] 
		[RED("securitySystem")] 
		public CHandle<SecuritySystemControllerPS> SecuritySystem
		{
			get => GetPropertyValue<CHandle<SecuritySystemControllerPS>>();
			set => SetPropertyValue<CHandle<SecuritySystemControllerPS>>(value);
		}

		[Ordinal(121)] 
		[RED("latestOutputEngineTime")] 
		public CFloat LatestOutputEngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(122)] 
		[RED("updateInterval")] 
		public CFloat UpdateInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(123)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(124)] 
		[RED("protectedEntityIDs")] 
		public CArray<entEntityID> ProtectedEntityIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(125)] 
		[RED("entitiesRemainingAtGate")] 
		public CArray<entEntityID> EntitiesRemainingAtGate
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(126)] 
		[RED("blacklist")] 
		public CArray<CHandle<BlacklistEntry>> Blacklist
		{
			get => GetPropertyValue<CArray<CHandle<BlacklistEntry>>>();
			set => SetPropertyValue<CArray<CHandle<BlacklistEntry>>>(value);
		}

		[Ordinal(127)] 
		[RED("currentReprimandID")] 
		public CInt32 CurrentReprimandID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(128)] 
		[RED("blacklistDelayValid")] 
		public CBool BlacklistDelayValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(129)] 
		[RED("blacklistDelayID")] 
		public gameDelayID BlacklistDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(130)] 
		[RED("maxGlobalWarningsCount")] 
		public CInt32 MaxGlobalWarningsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(131)] 
		[RED("delayIDValid")] 
		public CBool DelayIDValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("deescalationEventID")] 
		public gameDelayID DeescalationEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(133)] 
		[RED("outputsSend")] 
		public CInt32 OutputsSend
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(134)] 
		[RED("inputsReceived")] 
		public CInt32 InputsReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SecuritySystemControllerPS()
		{
			RevealDevicesGrid = false;
			DeviceName = "LocKey#50988";
			TweakDBRecord = 96691730947;
			TweakDBDescriptionRecord = 147752589635;
			Level_0 = new();
			Level_1 = new();
			Level_2 = new();
			Level_3 = new();
			Level_4 = new();
			AllowSecuritySystemToDisableItself = true;
			PerformAutomaticResetAfter = new();
			SecuritySystemState = Enums.ESecuritySystemState.SAFE;
			UpdateInterval = 1.000000F;
			RestartDuration = 60;
			ProtectedEntityIDs = new();
			EntitiesRemainingAtGate = new();
			Blacklist = new();
			BlacklistDelayID = new();
			MaxGlobalWarningsCount = 4;
			DeescalationEventID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
