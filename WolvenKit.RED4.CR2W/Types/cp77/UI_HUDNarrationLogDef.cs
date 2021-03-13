using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDNarrationLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("LastEvent")] public gamebbScriptID_Variant LastEvent { get; set; }

		public UI_HUDNarrationLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
