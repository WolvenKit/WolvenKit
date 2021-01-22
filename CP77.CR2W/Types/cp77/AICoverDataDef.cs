using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICoverDataDef : AIBlackboardDef
	{
		[Ordinal(0)]  [RED("commandCoverOverride")] public gamebbScriptID_Bool CommandCoverOverride { get; set; }
		[Ordinal(1)]  [RED("commandExposureMethods")] public gamebbScriptID_Variant CommandExposureMethods { get; set; }
		[Ordinal(2)]  [RED("currentCoverStance")] public gamebbScriptID_CName CurrentCoverStance { get; set; }
		[Ordinal(3)]  [RED("currentRing")] public gamebbScriptID_Variant CurrentRing { get; set; }
		[Ordinal(4)]  [RED("currentlyExposed")] public gamebbScriptID_Bool CurrentlyExposed { get; set; }
		[Ordinal(5)]  [RED("desiredCoverStance")] public gamebbScriptID_CName DesiredCoverStance { get; set; }
		[Ordinal(6)]  [RED("exposureMethod")] public gamebbScriptID_CName ExposureMethod { get; set; }
		[Ordinal(7)]  [RED("firstCoverEvaluationDone")] public gamebbScriptID_Bool FirstCoverEvaluationDone { get; set; }
		[Ordinal(8)]  [RED("lastCoverChangeThreshold")] public gamebbScriptID_Float LastCoverChangeThreshold { get; set; }
		[Ordinal(9)]  [RED("lastCoverPreset")] public gamebbScriptID_CName LastCoverPreset { get; set; }
		[Ordinal(10)]  [RED("lastCoverRing")] public gamebbScriptID_Variant LastCoverRing { get; set; }
		[Ordinal(11)]  [RED("lastDebugCoverPreset")] public gamebbScriptID_Int32 LastDebugCoverPreset { get; set; }
		[Ordinal(12)]  [RED("lastInitialCoverPreset")] public gamebbScriptID_CName LastInitialCoverPreset { get; set; }
		[Ordinal(13)]  [RED("lastVisibilityCheckTimestamp")] public gamebbScriptID_Float LastVisibilityCheckTimestamp { get; set; }

		public AICoverDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
