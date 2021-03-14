using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIActionEvent : redEvent
	{
		private CHandle<gamedeviceAction> _action;
		private wCHandle<gameObject> _executor;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<gamedeviceAction>) CR2WTypeManager.Create("handle:gamedeviceAction", "action", cr2w, this);
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

		[Ordinal(1)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get
			{
				if (_executor == null)
				{
					_executor = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "executor", cr2w, this);
				}
				return _executor;
			}
			set
			{
				if (_executor == value)
				{
					return;
				}
				_executor = value;
				PropertySet(this);
			}
		}

		public UIActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
