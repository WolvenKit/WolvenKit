using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendActionEventTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<gameActionEvent> _event;

		[Ordinal(1)] 
		[RED("event")] 
		public CHandle<gameActionEvent> Event
		{
			get
			{
				if (_event == null)
				{
					_event = (CHandle<gameActionEvent>) CR2WTypeManager.Create("handle:gameActionEvent", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSendActionEventTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
