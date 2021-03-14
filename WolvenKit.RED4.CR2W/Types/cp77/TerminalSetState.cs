using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalSetState : redEvent
	{
		private CEnum<gameinteractionsReactionState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameinteractionsReactionState>) CR2WTypeManager.Create("gameinteractionsReactionState", "state", cr2w, this);
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

		public TerminalSetState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
