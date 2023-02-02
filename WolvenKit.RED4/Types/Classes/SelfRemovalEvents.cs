using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SelfRemovalEvents : gamestateMachineFunctor
	{
		[Ordinal(0)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetPropertyValue<gamestateMachineStateMachineInstanceData>();
			set => SetPropertyValue<gamestateMachineStateMachineInstanceData>(value);
		}

		public SelfRemovalEvents()
		{
			StateMachineInstanceData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
