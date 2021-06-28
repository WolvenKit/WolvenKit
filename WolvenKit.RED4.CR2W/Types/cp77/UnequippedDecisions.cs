using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequippedDecisions : EquipmentBaseDecisions
	{
		private gamestateMachineStateMachineInstanceData _stateMachineInstanceData;

		[Ordinal(0)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetProperty(ref _stateMachineInstanceData);
			set => SetProperty(ref _stateMachineInstanceData, value);
		}

		public UnequippedDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
