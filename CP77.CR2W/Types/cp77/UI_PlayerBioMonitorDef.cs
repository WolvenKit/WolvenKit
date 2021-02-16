using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_PlayerBioMonitorDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("PlayerStatsInfo")] public gamebbScriptID_Variant PlayerStatsInfo { get; set; }
		[Ordinal(1)] [RED("BuffsList")] public gamebbScriptID_Variant BuffsList { get; set; }
		[Ordinal(2)] [RED("DebuffsList")] public gamebbScriptID_Variant DebuffsList { get; set; }
		[Ordinal(3)] [RED("Cooldowns")] public gamebbScriptID_Variant Cooldowns { get; set; }
		[Ordinal(4)] [RED("AdrenalineBar")] public gamebbScriptID_Float AdrenalineBar { get; set; }
		[Ordinal(5)] [RED("CurrentNetrunnerCharges")] public gamebbScriptID_Int32 CurrentNetrunnerCharges { get; set; }
		[Ordinal(6)] [RED("NetworkChargesCapacity")] public gamebbScriptID_Int32 NetworkChargesCapacity { get; set; }
		[Ordinal(7)] [RED("NetworkName")] public gamebbScriptID_CName NetworkName { get; set; }
		[Ordinal(8)] [RED("MemoryPercent")] public gamebbScriptID_Float MemoryPercent { get; set; }

		public UI_PlayerBioMonitorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
