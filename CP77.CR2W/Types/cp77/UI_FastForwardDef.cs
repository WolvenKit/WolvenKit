using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_FastForwardDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("FastForwardActive")] public gamebbScriptID_Bool FastForwardActive { get; set; }
		[Ordinal(1)]  [RED("FastForwardAvailable")] public gamebbScriptID_Bool FastForwardAvailable { get; set; }

		public UI_FastForwardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
