using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayPrereqEvent : redEvent
	{
		private CHandle<GameTimePrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<GameTimePrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CHandle<GameTimePrereqState>) CR2WTypeManager.Create("handle:GameTimePrereqState", "state", cr2w, this);
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

		public DelayPrereqEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
