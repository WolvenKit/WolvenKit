using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
	{
		[Ordinal(0)]  [RED("agentsRegistry")] public CHandle<AgentRegistry> AgentsRegistry { get; set; }
		[Ordinal(1)]  [RED("allowSecuritySystemToDisableItself")] public CBool AllowSecuritySystemToDisableItself { get; set; }
		[Ordinal(2)]  [RED("attitudeChangeMode")] public CEnum<EShouldChangeAttitude> AttitudeChangeMode { get; set; }
		[Ordinal(3)]  [RED("attitudeGroup")] public TweakDBID AttitudeGroup { get; set; }
		[Ordinal(4)]  [RED("blacklist")] public CArray<CHandle<BlacklistEntry>> Blacklist { get; set; }
		[Ordinal(5)]  [RED("blacklistDelayID")] public gameDelayID BlacklistDelayID { get; set; }
		[Ordinal(6)]  [RED("blacklistDelayValid")] public CBool BlacklistDelayValid { get; set; }
		[Ordinal(7)]  [RED("currentReprimandID")] public CInt32 CurrentReprimandID { get; set; }
		[Ordinal(8)]  [RED("deescalationEventID")] public gameDelayID DeescalationEventID { get; set; }
		[Ordinal(9)]  [RED("delayIDValid")] public CBool DelayIDValid { get; set; }
		[Ordinal(10)]  [RED("entitiesRemainingAtGate")] public CArray<entEntityID> EntitiesRemainingAtGate { get; set; }
		[Ordinal(11)]  [RED("hideAreasOnMinimap")] public CBool HideAreasOnMinimap { get; set; }
		[Ordinal(12)]  [RED("inputsReceived")] public CInt32 InputsReceived { get; set; }
		[Ordinal(13)]  [RED("isUnderStrictQuestControl")] public CBool IsUnderStrictQuestControl { get; set; }
		[Ordinal(14)]  [RED("latestOutputEngineTime")] public CFloat LatestOutputEngineTime { get; set; }
		[Ordinal(15)]  [RED("level_0")] public CArray<SecurityAccessLevelEntry> Level_0 { get; set; }
		[Ordinal(16)]  [RED("level_1")] public CArray<SecurityAccessLevelEntry> Level_1 { get; set; }
		[Ordinal(17)]  [RED("level_2")] public CArray<SecurityAccessLevelEntry> Level_2 { get; set; }
		[Ordinal(18)]  [RED("level_3")] public CArray<SecurityAccessLevelEntry> Level_3 { get; set; }
		[Ordinal(19)]  [RED("level_4")] public CArray<SecurityAccessLevelEntry> Level_4 { get; set; }
		[Ordinal(20)]  [RED("maxGlobalWarningsCount")] public CInt32 MaxGlobalWarningsCount { get; set; }
		[Ordinal(21)]  [RED("outputsSend")] public CInt32 OutputsSend { get; set; }
		[Ordinal(22)]  [RED("performAutomaticResetAfter")] public Time PerformAutomaticResetAfter { get; set; }
		[Ordinal(23)]  [RED("protectedEntityIDs")] public CArray<entEntityID> ProtectedEntityIDs { get; set; }
		[Ordinal(24)]  [RED("restartDuration")] public CInt32 RestartDuration { get; set; }
		[Ordinal(25)]  [RED("securitySystem")] public CHandle<SecuritySystemControllerPS> SecuritySystem { get; set; }
		[Ordinal(26)]  [RED("securitySystemState")] public CEnum<ESecuritySystemState> SecuritySystemState { get; set; }
		[Ordinal(27)]  [RED("suppressAbilityToModifyAttitude")] public CBool SuppressAbilityToModifyAttitude { get; set; }
		[Ordinal(28)]  [RED("updateInterval")] public CFloat UpdateInterval { get; set; }

		public SecuritySystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
