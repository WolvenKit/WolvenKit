using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CustomQuestNotificationDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("data")] public gamebbScriptID_Variant Data { get; set; }

		public UI_CustomQuestNotificationDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
