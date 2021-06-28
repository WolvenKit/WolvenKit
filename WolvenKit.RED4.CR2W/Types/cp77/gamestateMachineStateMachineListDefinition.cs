using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineListDefinition : IScriptable
	{
		private CArray<CHandle<gamestateMachineStateMachineDefinition>> _stateMachinesStorage;

		[Ordinal(0)] 
		[RED("stateMachinesStorage")] 
		public CArray<CHandle<gamestateMachineStateMachineDefinition>> StateMachinesStorage
		{
			get => GetProperty(ref _stateMachinesStorage);
			set => SetProperty(ref _stateMachinesStorage, value);
		}

		public gamestateMachineStateMachineListDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
