using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("districtManager")] public CHandle<DistrictManager> DistrictManager { get; set; }
		[Ordinal(1)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(2)] [RED("preventionPreset")] public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset { get; set; }
		[Ordinal(3)] [RED("hiddenReaction")] public CBool HiddenReaction { get; set; }
		[Ordinal(4)] [RED("systemDisabled")] public CBool SystemDisabled { get; set; }
		[Ordinal(5)] [RED("systemLockSources")] public CArray<CName> SystemLockSources { get; set; }
		[Ordinal(6)] [RED("deescalationZeroLockExecution")] public CBool DeescalationZeroLockExecution { get; set; }
		[Ordinal(7)] [RED("heatStage")] public CEnum<EPreventionHeatStage> HeatStage { get; set; }
		[Ordinal(8)] [RED("playerIsInSecurityArea")] public CArray<gamePersistentID> PlayerIsInSecurityArea { get; set; }
		[Ordinal(9)] [RED("policeSecuritySystems")] public CArray<gamePersistentID> PoliceSecuritySystems { get; set; }
		[Ordinal(10)] [RED("policeman100SpawnHits")] public CInt32 Policeman100SpawnHits { get; set; }
		[Ordinal(11)] [RED("agentGroupsList")] public CArray<CHandle<PreventionAgents>> AgentGroupsList { get; set; }
		[Ordinal(12)] [RED("agentsWhoSeePlayer")] public CArray<entEntityID> AgentsWhoSeePlayer { get; set; }
		[Ordinal(13)] [RED("hitNPC")] public CArray<SHitNPC> HitNPC { get; set; }
		[Ordinal(14)] [RED("spawnedAgents")] public CArray<wCHandle<ScriptedPuppet>> SpawnedAgents { get; set; }
		[Ordinal(15)] [RED("lastCrimePoint")] public Vector4 LastCrimePoint { get; set; }
		[Ordinal(16)] [RED("DEBUG_lastCrimeDistance")] public CFloat DEBUG_lastCrimeDistance { get; set; }
		[Ordinal(17)] [RED("policemanRandPercent")] public CInt32 PolicemanRandPercent { get; set; }
		[Ordinal(18)] [RED("policemabProbabilityPercent")] public CInt32 PolicemabProbabilityPercent { get; set; }
		[Ordinal(19)] [RED("generalPercent")] public CFloat GeneralPercent { get; set; }
		[Ordinal(20)] [RED("partGeneralPercent")] public CFloat PartGeneralPercent { get; set; }
		[Ordinal(21)] [RED("newDamageValue")] public CFloat NewDamageValue { get; set; }
		[Ordinal(22)] [RED("gameTimeStampPrevious")] public CFloat GameTimeStampPrevious { get; set; }
		[Ordinal(23)] [RED("gameTimeStampLastPoliceRise")] public CFloat GameTimeStampLastPoliceRise { get; set; }
		[Ordinal(24)] [RED("gameTimeStampDeescalationZero")] public CFloat GameTimeStampDeescalationZero { get; set; }
		[Ordinal(25)] [RED("deescalationZeroDelayID")] public gameDelayID DeescalationZeroDelayID { get; set; }
		[Ordinal(26)] [RED("deescalationZeroCheck")] public CBool DeescalationZeroCheck { get; set; }
		[Ordinal(27)] [RED("policemenSpawnDelayID")] public gameDelayID PolicemenSpawnDelayID { get; set; }
		[Ordinal(28)] [RED("spawnDelayedEvt")] public CHandle<PreventionDelayedSpawnRequest> SpawnDelayedEvt { get; set; }
		[Ordinal(29)] [RED("preventionTickDelayID")] public gameDelayID PreventionTickDelayID { get; set; }
		[Ordinal(30)] [RED("preventionTickCheck")] public CBool PreventionTickCheck { get; set; }
		[Ordinal(31)] [RED("securityAreaResetDelayID")] public gameDelayID SecurityAreaResetDelayID { get; set; }
		[Ordinal(32)] [RED("securityAreaResetCheck")] public CBool SecurityAreaResetCheck { get; set; }
		[Ordinal(33)] [RED("Debug_PorcessReason")] public CEnum<EPreventionDebugProcessReason> Debug_PorcessReason { get; set; }
		[Ordinal(34)] [RED("Debug_PsychoLogicType")] public CEnum<EPreventionPsychoLogicType> Debug_PsychoLogicType { get; set; }
		[Ordinal(35)] [RED("currentPreventionPreset")] public TweakDBID CurrentPreventionPreset { get; set; }
		[Ordinal(36)] [RED("failsafePoliceRecordT1")] public TweakDBID FailsafePoliceRecordT1 { get; set; }
		[Ordinal(37)] [RED("failsafePoliceRecordT2")] public TweakDBID FailsafePoliceRecordT2 { get; set; }
		[Ordinal(38)] [RED("failsafePoliceRecordT3")] public TweakDBID FailsafePoliceRecordT3 { get; set; }
		[Ordinal(39)] [RED("blinkReasonsStack")] public CArray<CName> BlinkReasonsStack { get; set; }
		[Ordinal(40)] [RED("wantedBarBlackboard")] public wCHandle<gameIBlackboard> WantedBarBlackboard { get; set; }
		[Ordinal(41)] [RED("onPlayerChoiceCallID")] public CUInt32 OnPlayerChoiceCallID { get; set; }
		[Ordinal(42)] [RED("playerAttachedCallbackID")] public CUInt32 PlayerAttachedCallbackID { get; set; }
		[Ordinal(43)] [RED("playerDetachedCallbackID")] public CUInt32 PlayerDetachedCallbackID { get; set; }
		[Ordinal(44)] [RED("playerHLSID")] public CUInt32 PlayerHLSID { get; set; }
		[Ordinal(45)] [RED("playerVehicleStateID")] public CUInt32 PlayerVehicleStateID { get; set; }
		[Ordinal(46)] [RED("playerHLS")] public CEnum<gamePSMHighLevel> PlayerHLS { get; set; }
		[Ordinal(47)] [RED("playerVehicleState")] public CEnum<gamePSMVehicle> PlayerVehicleState { get; set; }
		[Ordinal(48)] [RED("vehicles")] public CArray<wCHandle<vehicleBaseObject>> Vehicles { get; set; }
		[Ordinal(49)] [RED("viewers")] public CArray<wCHandle<gameObject>> Viewers { get; set; }

		public PreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
