using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		private CArray<wCHandle<gamedeviceAction>> _actions;
		private CHandle<ResolveActionData> _actionData;

		[Ordinal(26)] 
		[RED("actions")] 
		public CArray<wCHandle<gamedeviceAction>> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<wCHandle<gamedeviceAction>>) CR2WTypeManager.Create("array:whandle:gamedeviceAction", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get
			{
				if (_actionData == null)
				{
					_actionData = (CHandle<ResolveActionData>) CR2WTypeManager.Create("handle:ResolveActionData", "actionData", cr2w, this);
				}
				return _actionData;
			}
			set
			{
				if (_actionData == value)
				{
					return;
				}
				_actionData = value;
				PropertySet(this);
			}
		}

		public DeviceActionWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
