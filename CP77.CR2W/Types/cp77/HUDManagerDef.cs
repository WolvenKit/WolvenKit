using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDManagerDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("HudHintMessegeContent")] public gamebbScriptID_String HudHintMessegeContent { get; set; }
		[Ordinal(1)]  [RED("ShowHudHintMessege")] public gamebbScriptID_Bool ShowHudHintMessege { get; set; }

		public HUDManagerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
