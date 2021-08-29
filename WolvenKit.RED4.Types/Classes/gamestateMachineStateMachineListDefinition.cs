using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateMachineListDefinition : IScriptable
	{
		private CArray<CHandle<gamestateMachineStateMachineDefinition>> _stateMachinesStorage;

		[Ordinal(0)] 
		[RED("stateMachinesStorage")] 
		public CArray<CHandle<gamestateMachineStateMachineDefinition>> StateMachinesStorage
		{
			get => GetProperty(ref _stateMachinesStorage);
			set => SetProperty(ref _stateMachinesStorage, value);
		}
	}
}
