using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDManagerDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ShowHudHintMessege")] public gamebbScriptID_Bool ShowHudHintMessege { get; set; }
		[Ordinal(1)]  [RED("HudHintMessegeContent")] public gamebbScriptID_String HudHintMessegeContent { get; set; }

		public HUDManagerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
