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
			get
			{
				if (_activityLogHide == null)
				{
					_activityLogHide = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "activityLogHide", cr2w, this);
				}
				return _activityLogHide;
			}
			set
			{
				if (_activityLogHide == value)
				{
					return;
				}
				_activityLogHide = value;
				PropertySet(this);
			}
		}

		public UI_ActivityLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
