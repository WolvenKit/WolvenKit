using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorStateOperations : DeviceOperations
	{
		private CArray<SDoorStateOperationData> _doorStateOperations;
		private CBool _wasStateCached;
		private CEnum<EDoorStatus> _cachedState;

		[Ordinal(2)] 
		[RED("doorStateOperations")] 
		public CArray<SDoorStateOperationData> DoorStateOperations_
		{
			get => GetProperty(ref _doorStateOperations);
			set => SetProperty(ref _doorStateOperations, value);
		}

		[Ordinal(3)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetProperty(ref _wasStateCached);
			set => SetProperty(ref _wasStateCached, value);
		}

		[Ordinal(4)] 
		[RED("cachedState")] 
		public CEnum<EDoorStatus> CachedState
		{
			get => GetProperty(ref _cachedState);
			set => SetProperty(ref _cachedState, value);
		}
	}
}
