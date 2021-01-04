using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HackingMinigameDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ActivePrograms")] public gamebbScriptID_Variant ActivePrograms { get; set; }
		[Ordinal(1)]  [RED("ActiveTraps")] public gamebbScriptID_Variant ActiveTraps { get; set; }
		[Ordinal(2)]  [RED("Entity")] public gamebbScriptID_Variant Entity { get; set; }
		[Ordinal(3)]  [RED("IsJournalTarget")] public gamebbScriptID_Bool IsJournalTarget { get; set; }
		[Ordinal(4)]  [RED("MinigameDefaults")] public gamebbScriptID_Variant MinigameDefaults { get; set; }
		[Ordinal(5)]  [RED("NextMinigameData")] public gamebbScriptID_Variant NextMinigameData { get; set; }
		[Ordinal(6)]  [RED("PlayerPrograms")] public gamebbScriptID_Variant PlayerPrograms { get; set; }
		[Ordinal(7)]  [RED("SkipSummaryScreen")] public gamebbScriptID_Bool SkipSummaryScreen { get; set; }
		[Ordinal(8)]  [RED("State")] public gamebbScriptID_Int32 State { get; set; }

		public HackingMinigameDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
