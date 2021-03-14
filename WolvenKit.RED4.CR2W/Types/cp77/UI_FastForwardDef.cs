using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_FastForwardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("FastForwardAvailable")] public gamebbScriptID_Bool FastForwardAvailable { get; set; }
		[Ordinal(1)] [RED("FastForwardActive")] public gamebbScriptID_Bool FastForwardActive { get; set; }

		public UI_FastForwardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
