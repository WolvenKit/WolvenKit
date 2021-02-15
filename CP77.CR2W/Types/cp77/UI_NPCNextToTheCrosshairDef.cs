using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_NPCNextToTheCrosshairDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("NameplateData")] public gamebbScriptID_Variant NameplateData { get; set; }
		[Ordinal(1)] [RED("BuffsList")] public gamebbScriptID_Variant BuffsList { get; set; }
		[Ordinal(2)] [RED("DebuffsList")] public gamebbScriptID_Variant DebuffsList { get; set; }

		public UI_NPCNextToTheCrosshairDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
