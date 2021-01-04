using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_HudButtonHelpDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("button1_Icon")] public gamebbScriptID_CName Button1_Icon { get; set; }
		[Ordinal(1)]  [RED("button1_Text")] public gamebbScriptID_String Button1_Text { get; set; }
		[Ordinal(2)]  [RED("button2_Icon")] public gamebbScriptID_CName Button2_Icon { get; set; }
		[Ordinal(3)]  [RED("button2_Text")] public gamebbScriptID_String Button2_Text { get; set; }
		[Ordinal(4)]  [RED("button3_Icon")] public gamebbScriptID_CName Button3_Icon { get; set; }
		[Ordinal(5)]  [RED("button3_Text")] public gamebbScriptID_String Button3_Text { get; set; }

		public UI_HudButtonHelpDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
