using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(105)]  [RED("level_0")] public CArray<SecurityAccessLevelEntry> Level_0 { get; set; }
		[Ordinal(106)]  [RED("level_1")] public CArray<SecurityAccessLevelEntry> Level_1 { get; set; }
		[Ordinal(107)]  [RED("level_2")] public CArray<SecurityAccessLevelEntry> Level_2 { get; set; }
		[Ordinal(108)]  [RED("level_3")] public CArray<SecurityAccessLevelEntry> Level_3 { get; set; }
		[Ordinal(109)]  [RED("level_4")] public CArray<SecurityAccessLevelEntry> Level_4 { get; set; }
		[Ordinal(110)]  [RED("allowSecuritySystemToDisableItself")] public CBool AllowSecuritySystemToDisableItself { get; set; }
		[Ordinal(111)]  [RED("attitudeGroup")] public TweakDBID AttitudeGroup { get; set; }
		[Ordinal(112)]  [RED("suppressAbilityToModifyAttitude")] public CBool SuppressAbilityToModifyAttitude { get; set; }
		[Ordinal(113)]  [RED("attitudeChangeMode")] public CEnum<EShouldChangeAttitude> AttitudeChangeMode { get; set; }
		[Ordinal(114)]  [RED("performAutomaticResetAfter")] public Time PerformAutomaticResetAfter { get; set; }
		[Ordinal(115)]  [RED("hideAreasOnMinimap")] public CBool HideAreasOnMinimap { get; set; }
		[Ordinal(116)]  [RED("isUnderStrictQuestControl")] public CBool IsUnderStrictQuestControl { get; set; }
		[Ordinal(117)]  [RED("securitySystemState")] public CEnum<ESecuritySystemState> SecuritySystemState { get; set; }
		[Ordinal(118)]  [RED("agentsRegistry")] public CHandle<AgentRegistry> AgentsRegistry { get; set; }
		[Ordinal(119)]  [RED("securitySystem")] public CHandle<SecuritySystemControllerPS> SecuritySystem { get; set; }
		[Ordinal(120)]  [RED("latestOutputEngineTime")] public CFloat LatestOutputEngineTime { get; set; }
		[Ordinal(121)]  [RED("updateInterval")] public CFloat UpdateInterval { get; set; }
		[Ordinal(122)]  [RED("restartDuration")] public CInt32 RestartDuration { get; set; }
		[Ordinal(123)]  [RED("protectedEntityIDs")] public CArray<entEntityID> ProtectedEntityIDs { get; set; }
		[Ordinal(124)]  [RED("entitiesRemainingAtGate")] public CArray<entEntityID> EntitiesRemainingAtGate { get; set; }
		[Ordinal(125)]  [RED("blacklist")] public CArray<CHandle<BlacklistEntry>> Blacklist { get; set; }
		[Ordinal(126)]  [RED("currentReprimandID")] public CInt32 CurrentReprimandID { get; set; }
		[Ordinal(127)]  [RED("blacklistDelayValid")] public CBool BlacklistDelayValid { get; set; }
		[Ordinal(128)]  [RED("blacklistDelayID")] public gameDelayID BlacklistDelayID { get; set; }
		[Ordinal(129)]  [RED("maxGlobalWarningsCount")] public CInt32 MaxGlobalWarningsCount { get; set; }
		[Ordinal(130)]  [RED("delayIDValid")] public CBool DelayIDValid { get; set; }
		[Ordinal(131)]  [RED("deescalationEventID")] public gameDelayID DeescalationEventID { get; set; }
		[Ordinal(132)]  [RED("outputsSend")] public CInt32 OutputsSend { get; set; }
		[Ordinal(133)]  [RED("inputsReceived")] public CInt32 InputsReceived { get; set; }

		public SecuritySystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
