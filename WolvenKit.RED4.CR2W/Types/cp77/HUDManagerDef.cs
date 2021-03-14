using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ShowHudHintMessege")] public gamebbScriptID_Bool ShowHudHintMessege { get; set; }
		[Ordinal(1)] [RED("HudHintMessegeContent")] public gamebbScriptID_String HudHintMessegeContent { get; set; }

		public HUDManagerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
