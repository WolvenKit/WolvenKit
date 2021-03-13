using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDButtonHintDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ActionsData")] public gamebbScriptID_Variant ActionsData { get; set; }

		public UI_HUDButtonHintDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
