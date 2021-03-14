using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardAction : redEvent
	{
		private gamePersistentID _requester;
		private CHandle<ScriptableDeviceAction> _actionToForward;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get
			{
				if (_actionToForward == null)
				{
					_actionToForward = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "actionToForward", cr2w, this);
				}
				return _actionToForward;
			}
			set
			{
				if (_actionToForward == value)
				{
					return;
				}
				_actionToForward = value;
				PropertySet(this);
			}
		}

		public ForwardAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
