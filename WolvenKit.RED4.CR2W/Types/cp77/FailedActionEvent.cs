using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FailedActionEvent : redEvent
	{
		private CHandle<gamedeviceAction> _action;
		private gamePersistentID _whoFailed;

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
		[RED("whoFailed")] 
		public gamePersistentID WhoFailed
		{
			get
			{
				if (_whoFailed == null)
				{
					_whoFailed = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "whoFailed", cr2w, this);
				}
				return _whoFailed;
			}
			set
			{
				if (_whoFailed == value)
				{
					return;
				}
				_whoFailed = value;
				PropertySet(this);
			}
		}

		public FailedActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
