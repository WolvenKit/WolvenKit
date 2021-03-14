using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTickableEvent : redEvent
	{
		private CEnum<gameTickableEventState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameTickableEventState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameTickableEventState>) CR2WTypeManager.Create("gameTickableEventState", "state", cr2w, this);
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

		public gameTickableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
