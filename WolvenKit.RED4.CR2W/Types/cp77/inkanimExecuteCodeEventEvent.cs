using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		private CHandle<redEvent> _eventToExecute;

		[Ordinal(1)] 
		[RED("eventToExecute")] 
		public CHandle<redEvent> EventToExecute
		{
			get
			{
				if (_eventToExecute == null)
				{
					_eventToExecute = (CHandle<redEvent>) CR2WTypeManager.Create("handle:redEvent", "eventToExecute", cr2w, this);
				}
				return _eventToExecute;
			}
			set
			{
				if (_eventToExecute == value)
				{
					return;
				}
				_eventToExecute = value;
				PropertySet(this);
			}
		}

		public inkanimExecuteCodeEventEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
