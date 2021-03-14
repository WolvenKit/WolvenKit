using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActivityLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("activityLogHide")] public gamebbScriptID_Bool ActivityLogHide { get; set; }

		public UI_ActivityLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
