using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RewireEvent : redEvent
	{
		private entEntityID _ownerID;
		private entEntityID _activatorID;
		private CWeakHandle<gameObject> _executor;
		private CEnum<EDrillMachineRewireState> _state;
		private CBool _sucess;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("activatorID")] 
		public entEntityID ActivatorID
		{
			get => GetProperty(ref _activatorID);
			set => SetProperty(ref _activatorID, value);
		}

		[Ordinal(2)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<EDrillMachineRewireState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(4)] 
		[RED("sucess")] 
		public CBool Sucess
		{
			get => GetProperty(ref _sucess);
			set => SetProperty(ref _sucess, value);
		}
	}
}
