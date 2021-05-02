using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachineSnapshot : CVariable
	{
		private CName _stateMachineId;
		private CName _stateId;

		[Ordinal(0)] 
		[RED("stateMachineId")] 
		public CName StateMachineId
		{
			get => GetProperty(ref _stateMachineId);
			set => SetProperty(ref _stateMachineId, value);
		}

		[Ordinal(1)] 
		[RED("stateId")] 
		public CName StateId
		{
			get => GetProperty(ref _stateId);
			set => SetProperty(ref _stateId, value);
		}

		public gameMuppetStateMachineSnapshot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
