using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NotificationsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("WarningMessage")] public gamebbScriptID_Variant WarningMessage { get; set; }
		[Ordinal(1)] [RED("OnscreenMessage")] public gamebbScriptID_Variant OnscreenMessage { get; set; }

		public UI_NotificationsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
