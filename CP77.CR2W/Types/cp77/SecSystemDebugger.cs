using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecSystemDebugger : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("lastInstruction")] public CEnum<EReprimandInstructions> LastInstruction { get; set; }
		[Ordinal(1)]  [RED("instructionSet")] public CBool InstructionSet { get; set; }
		[Ordinal(2)]  [RED("lastInstructionTime")] public CFloat LastInstructionTime { get; set; }
		[Ordinal(3)]  [RED("lastInput")] public CEnum<ESecurityNotificationType> LastInput { get; set; }
		[Ordinal(4)]  [RED("inputSet")] public CBool InputSet { get; set; }
		[Ordinal(5)]  [RED("lastInputTime")] public CFloat LastInputTime { get; set; }
		[Ordinal(6)]  [RED("lastUpdateTime")] public CFloat LastUpdateTime { get; set; }
		[Ordinal(7)]  [RED("realTimeCallbackID")] public gameDelayID RealTimeCallbackID { get; set; }
		[Ordinal(8)]  [RED("realTimeCallback")] public CBool RealTimeCallback { get; set; }
		[Ordinal(9)]  [RED("realTime")] public CFloat RealTime { get; set; }
		[Ordinal(10)]  [RED("callstack")] public CArray<CName> Callstack { get; set; }
		[Ordinal(11)]  [RED("ids")] public CArray<CUInt32> Ids { get; set; }
		[Ordinal(12)]  [RED("background")] public CUInt32 Background { get; set; }
		[Ordinal(13)]  [RED("sysName")] public CUInt32 SysName { get; set; }
		[Ordinal(14)]  [RED("sysState")] public CUInt32 SysState { get; set; }
		[Ordinal(15)]  [RED("mostDangerousArea")] public CUInt32 MostDangerousArea { get; set; }
		[Ordinal(16)]  [RED("blacklistReason")] public CUInt32 BlacklistReason { get; set; }
		[Ordinal(17)]  [RED("blacklistCount")] public CUInt32 BlacklistCount { get; set; }
		[Ordinal(18)]  [RED("reprimand")] public CUInt32 Reprimand { get; set; }
		[Ordinal(19)]  [RED("repInstruction")] public CUInt32 RepInstruction { get; set; }
		[Ordinal(20)]  [RED("reprimandID")] public CUInt32 ReprimandID { get; set; }
		[Ordinal(21)]  [RED("input")] public CUInt32 Input { get; set; }
		[Ordinal(22)]  [RED("regTime")] public CUInt32 RegTime { get; set; }
		[Ordinal(23)]  [RED("inputTime")] public CUInt32 InputTime { get; set; }
		[Ordinal(24)]  [RED("instructionTime")] public CUInt32 InstructionTime { get; set; }
		[Ordinal(25)]  [RED("actualTime")] public CUInt32 ActualTime { get; set; }
		[Ordinal(26)]  [RED("system")] public CHandle<SecuritySystemControllerPS> System { get; set; }
		[Ordinal(27)]  [RED("refreshTime")] public CFloat RefreshTime { get; set; }

		public SecSystemDebugger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
