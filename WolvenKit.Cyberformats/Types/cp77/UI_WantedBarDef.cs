using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_WantedBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("CurrentBounty")] public gamebbScriptID_Int32 CurrentBounty { get; set; }
		[Ordinal(1)] [RED("CurrentWantedLevel")] public gamebbScriptID_Int32 CurrentWantedLevel { get; set; }

		public UI_WantedBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
