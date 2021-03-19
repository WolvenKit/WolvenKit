using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventStopStateMachine : redEvent
	{
		private gamestateMachineStateMachineIdentifier _stateMachineIdentifier;

		[Ordinal(0)] 
		[RED("stateMachineIdentifier")] 
		public gamestateMachineStateMachineIdentifier StateMachineIdentifier
		{
			get => GetProperty(ref _stateMachineIdentifier);
			set => SetProperty(ref _stateMachineIdentifier, value);
		}

		public gamestateMachineeventStopStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
