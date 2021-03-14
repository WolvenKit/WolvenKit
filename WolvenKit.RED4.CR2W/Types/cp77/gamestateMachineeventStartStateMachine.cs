using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventStartStateMachine : redEvent
	{
		private gamestateMachineStateMachineIdentifier _stateMachineIdentifier;

		[Ordinal(0)] 
		[RED("stateMachineIdentifier")] 
		public gamestateMachineStateMachineIdentifier StateMachineIdentifier
		{
			get
			{
				if (_stateMachineIdentifier == null)
				{
					_stateMachineIdentifier = (gamestateMachineStateMachineIdentifier) CR2WTypeManager.Create("gamestateMachineStateMachineIdentifier", "stateMachineIdentifier", cr2w, this);
				}
				return _stateMachineIdentifier;
			}
			set
			{
				if (_stateMachineIdentifier == value)
				{
					return;
				}
				_stateMachineIdentifier = value;
				PropertySet(this);
			}
		}

		public gamestateMachineeventStartStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
