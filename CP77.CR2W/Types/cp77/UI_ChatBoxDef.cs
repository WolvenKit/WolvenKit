using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_ChatBoxDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("TextList")] public gamebbScriptID_Variant TextList { get; set; }

		public UI_ChatBoxDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
