using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendSpiderbotToPerformActionEvent : redEvent
	{
		private wCHandle<gameObject> _executor;

		[Ordinal(0)] 
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

		public SendSpiderbotToPerformActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
