using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionDieState : gameActionReplicatedState
	{
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<moveComponent> _movingAgent;
		private CWeakHandle<entRagdollComponent> _ragdollComponent;
		private CWeakHandle<entSlotComponent> _slotComponent;

		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("movingAgent")] 
		public CWeakHandle<moveComponent> MovingAgent
		{
			get => GetProperty(ref _movingAgent);
			set => SetProperty(ref _movingAgent, value);
		}

		[Ordinal(7)] 
		[RED("ragdollComponent")] 
		public CWeakHandle<entRagdollComponent> RagdollComponent
		{
			get => GetProperty(ref _ragdollComponent);
			set => SetProperty(ref _ragdollComponent, value);
		}

		[Ordinal(8)] 
		[RED("slotComponent")] 
		public CWeakHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}
	}
}
