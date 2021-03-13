using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_BriefingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("BriefingToOpen")] public gamebbScriptID_String BriefingToOpen { get; set; }
		[Ordinal(1)] [RED("BriefingSize")] public gamebbScriptID_Variant BriefingSize { get; set; }
		[Ordinal(2)] [RED("BriefingAlignment")] public gamebbScriptID_Variant BriefingAlignment { get; set; }

		public UI_BriefingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
