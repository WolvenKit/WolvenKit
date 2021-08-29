using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventRemoveOnDemandStateMachine : redEvent
	{
		private gamestateMachineStateMachineIdentifier _stateMachineIdentifier;

		[Ordinal(0)] 
		[RED("stateMachineIdentifier")] 
		public gamestateMachineStateMachineIdentifier StateMachineIdentifier
		{
			get => GetProperty(ref _stateMachineIdentifier);
			set => SetProperty(ref _stateMachineIdentifier, value);
		}
	}
}
