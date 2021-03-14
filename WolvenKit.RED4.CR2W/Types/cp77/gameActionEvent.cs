using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionEvent : AIAIEvent
	{
		private CName _eventAction;
		private CHandle<gameActionInternalEvent> _internalEvent;

		[Ordinal(2)] 
		[RED("eventAction")] 
		public CName EventAction
		{
			get
			{
				if (_eventAction == null)
				{
					_eventAction = (CName) CR2WTypeManager.Create("CName", "eventAction", cr2w, this);
				}
				return _eventAction;
			}
			set
			{
				if (_eventAction == value)
				{
					return;
				}
				_eventAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("internalEvent")] 
		public CHandle<gameActionInternalEvent> InternalEvent
		{
			get
			{
				if (_internalEvent == null)
				{
					_internalEvent = (CHandle<gameActionInternalEvent>) CR2WTypeManager.Create("handle:gameActionInternalEvent", "internalEvent", cr2w, this);
				}
				return _internalEvent;
			}
			set
			{
				if (_internalEvent == value)
				{
					return;
				}
				_internalEvent = value;
				PropertySet(this);
			}
		}

		public gameActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
