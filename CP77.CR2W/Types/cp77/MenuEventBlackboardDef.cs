using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MenuEventBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("MenuEventToTrigger")] public gamebbScriptID_CName MenuEventToTrigger { get; set; }

		public MenuEventBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
