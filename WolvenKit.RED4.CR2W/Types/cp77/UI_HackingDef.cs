using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HackingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ammoIndicator")] public gamebbScriptID_Bool AmmoIndicator { get; set; }

		public UI_HackingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
