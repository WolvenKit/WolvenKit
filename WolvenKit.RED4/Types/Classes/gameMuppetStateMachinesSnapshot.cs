using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetStateMachinesSnapshot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateMachines")] 
		public CArray<gameMuppetStateMachineSnapshot> StateMachines
		{
			get => GetPropertyValue<CArray<gameMuppetStateMachineSnapshot>>();
			set => SetPropertyValue<CArray<gameMuppetStateMachineSnapshot>>(value);
		}

		public gameMuppetStateMachinesSnapshot()
		{
			StateMachines = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
