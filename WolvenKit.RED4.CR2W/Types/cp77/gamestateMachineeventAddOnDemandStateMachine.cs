using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventAddOnDemandStateMachine : redEvent
	{
		private CName _stateMachineName;
		private gamestateMachineStateMachineInstanceData _instanceData;
		private CBool _tryHotSwap;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("stateMachineName")] 
		public CName StateMachineName
		{
			get => GetProperty(ref _stateMachineName);
			set => SetProperty(ref _stateMachineName, value);
		}

		[Ordinal(1)] 
		[RED("instanceData")] 
		public gamestateMachineStateMachineInstanceData InstanceData
		{
			get => GetProperty(ref _instanceData);
			set => SetProperty(ref _instanceData, value);
		}

		[Ordinal(2)] 
		[RED("tryHotSwap")] 
		public CBool TryHotSwap
		{
			get => GetProperty(ref _tryHotSwap);
			set => SetProperty(ref _tryHotSwap, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public gamestateMachineeventAddOnDemandStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
