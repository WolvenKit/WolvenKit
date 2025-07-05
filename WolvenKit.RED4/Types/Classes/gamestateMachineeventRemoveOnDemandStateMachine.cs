using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventRemoveOnDemandStateMachine : redEvent
	{
		[Ordinal(0)] 
		[RED("stateMachineIdentifier")] 
		public gamestateMachineStateMachineIdentifier StateMachineIdentifier
		{
			get => GetPropertyValue<gamestateMachineStateMachineIdentifier>();
			set => SetPropertyValue<gamestateMachineStateMachineIdentifier>(value);
		}

		public gamestateMachineeventRemoveOnDemandStateMachine()
		{
			StateMachineIdentifier = new gamestateMachineStateMachineIdentifier();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
