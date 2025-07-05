using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventResetStateMachine : redEvent
	{
		[Ordinal(0)] 
		[RED("stateMachineIdentifier")] 
		public gamestateMachineStateMachineIdentifier StateMachineIdentifier
		{
			get => GetPropertyValue<gamestateMachineStateMachineIdentifier>();
			set => SetPropertyValue<gamestateMachineStateMachineIdentifier>(value);
		}

		public gamestateMachineeventResetStateMachine()
		{
			StateMachineIdentifier = new gamestateMachineStateMachineIdentifier();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
