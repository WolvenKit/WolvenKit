using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_CraftingDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("lastCommand")] public gamebbScriptID_Variant LastCommand { get; set; }
		[Ordinal(1)]  [RED("lastIngredients")] public gamebbScriptID_Variant LastIngredients { get; set; }
		[Ordinal(2)]  [RED("lastItem")] public gamebbScriptID_Variant LastItem { get; set; }

		public UI_CraftingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
