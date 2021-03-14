using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_LevelUpDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("level")] public gamebbScriptID_Variant Level { get; set; }

		public UI_LevelUpDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
