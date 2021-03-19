using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActivityLogDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _activityLogHide;

		[Ordinal(0)] 
		[RED("activityLogHide")] 
		public gamebbScriptID_Bool ActivityLogHide
		{
			get => GetProperty(ref _activityLogHide);
			set => SetProperty(ref _activityLogHide, value);
		}

		public UI_ActivityLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
