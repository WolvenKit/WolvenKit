using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ChatBoxDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("TextList")] public gamebbScriptID_Variant TextList { get; set; }

		public UI_ChatBoxDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
