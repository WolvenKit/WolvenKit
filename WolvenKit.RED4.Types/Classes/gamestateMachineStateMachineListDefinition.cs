using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateMachineListDefinition : IScriptable
	{
		[Ordinal(0)] 
		[RED("stateMachinesStorage")] 
		public CArray<CHandle<gamestateMachineStateMachineDefinition>> StateMachinesStorage
		{
			get => GetPropertyValue<CArray<CHandle<gamestateMachineStateMachineDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gamestateMachineStateMachineDefinition>>>(value);
		}

		public gamestateMachineStateMachineListDefinition()
		{
			StateMachinesStorage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
