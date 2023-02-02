using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionDieState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("movingAgent")] 
		public CWeakHandle<moveComponent> MovingAgent
		{
			get => GetPropertyValue<CWeakHandle<moveComponent>>();
			set => SetPropertyValue<CWeakHandle<moveComponent>>(value);
		}

		[Ordinal(7)] 
		[RED("ragdollComponent")] 
		public CWeakHandle<entRagdollComponent> RagdollComponent
		{
			get => GetPropertyValue<CWeakHandle<entRagdollComponent>>();
			set => SetPropertyValue<CWeakHandle<entRagdollComponent>>(value);
		}

		[Ordinal(8)] 
		[RED("slotComponent")] 
		public CWeakHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CWeakHandle<entSlotComponent>>();
			set => SetPropertyValue<CWeakHandle<entSlotComponent>>(value);
		}

		public gameActionDieState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
