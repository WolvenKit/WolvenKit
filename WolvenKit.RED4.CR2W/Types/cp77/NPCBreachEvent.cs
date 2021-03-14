using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCBreachEvent : redEvent
	{
		private CEnum<gameuiHackingMinigameState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameuiHackingMinigameState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameuiHackingMinigameState>) CR2WTypeManager.Create("gameuiHackingMinigameState", "state", cr2w, this);
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

		public NPCBreachEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
