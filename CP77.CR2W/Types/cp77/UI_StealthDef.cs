using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_StealthDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("CombatDebug")] public gamebbScriptID_Bool CombatDebug { get; set; }
		[Ordinal(1)]  [RED("numberOfCombatants")] public gamebbScriptID_Uint32 NumberOfCombatants { get; set; }

		public UI_StealthDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
