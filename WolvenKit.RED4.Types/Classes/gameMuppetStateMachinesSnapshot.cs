using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetStateMachinesSnapshot : RedBaseClass
	{
		private CArray<gameMuppetStateMachineSnapshot> _stateMachines;

		[Ordinal(0)] 
		[RED("stateMachines")] 
		public CArray<gameMuppetStateMachineSnapshot> StateMachines
		{
			get => GetProperty(ref _stateMachines);
			set => SetProperty(ref _stateMachines, value);
		}
	}
}
