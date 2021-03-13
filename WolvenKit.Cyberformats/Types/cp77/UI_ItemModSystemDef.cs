using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ItemModSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ItemModSystemUpdated")] public gamebbScriptID_Variant ItemModSystemUpdated { get; set; }

		public UI_ItemModSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
