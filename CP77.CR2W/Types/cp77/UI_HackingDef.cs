using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_HackingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ammoIndicator")] public gamebbScriptID_Bool AmmoIndicator { get; set; }

		public UI_HackingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
