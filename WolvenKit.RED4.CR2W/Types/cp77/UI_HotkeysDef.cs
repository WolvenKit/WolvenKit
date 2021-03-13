using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HotkeysDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ModifiedHotkey")] public gamebbScriptID_Variant ModifiedHotkey { get; set; }

		public UI_HotkeysDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
