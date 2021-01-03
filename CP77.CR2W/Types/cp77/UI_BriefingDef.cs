using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_BriefingDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("BriefingAlignment")] public gamebbScriptID_Variant BriefingAlignment { get; set; }
		[Ordinal(1)]  [RED("BriefingSize")] public gamebbScriptID_Variant BriefingSize { get; set; }
		[Ordinal(2)]  [RED("BriefingToOpen")] public gamebbScriptID_String BriefingToOpen { get; set; }

		public UI_BriefingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
