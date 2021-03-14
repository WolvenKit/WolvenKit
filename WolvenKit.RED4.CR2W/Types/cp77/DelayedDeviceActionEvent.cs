using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedDeviceActionEvent : redEvent
	{
		private CHandle<ScriptableDeviceAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public DelayedDeviceActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
