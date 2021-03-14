using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetInspectStateEvent : redEvent
	{
		private CEnum<questObjectInspectEventType> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questObjectInspectEventType> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<questObjectInspectEventType>) CR2WTypeManager.Create("questObjectInspectEventType", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public SetInspectStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
