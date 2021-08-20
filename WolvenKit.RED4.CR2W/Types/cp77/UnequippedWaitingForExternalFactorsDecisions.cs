using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequippedWaitingForExternalFactorsDecisions : EquipmentBaseDecisions
	{
		private gamestateMachineStateMachineInstanceData _stateMachineInstanceData;
		private wCHandle<EquipmentInitData> _stateMachineInitData;

		[Ordinal(0)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetProperty(ref _stateMachineInstanceData);
			set => SetProperty(ref _stateMachineInstanceData, value);
		}

		[Ordinal(1)] 
		[RED("stateMachineInitData")] 
		public wCHandle<EquipmentInitData> StateMachineInitData
		{
			get => GetProperty(ref _stateMachineInitData);
			set => SetProperty(ref _stateMachineInitData, value);
		}

		public UnequippedWaitingForExternalFactorsDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
