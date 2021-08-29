using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventAddOnDemandStateMachine : redEvent
	{
		private CName _stateMachineName;
		private gamestateMachineStateMachineInstanceData _instanceData;
		private CBool _tryHotSwap;
		private CWeakHandle<gameObject> _owner;

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
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
