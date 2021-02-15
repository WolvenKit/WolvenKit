using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_HudTooltipDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ItemId")] public gamebbScriptID_Variant ItemId { get; set; }
		[Ordinal(1)] [RED("ShowTooltip")] public gamebbScriptID_Bool ShowTooltip { get; set; }

		public UI_HudTooltipDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
