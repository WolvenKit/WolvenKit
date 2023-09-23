using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RewireEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("activatorID")] 
		public entEntityID ActivatorID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<EDrillMachineRewireState> State
		{
			get => GetPropertyValue<CEnum<EDrillMachineRewireState>>();
			set => SetPropertyValue<CEnum<EDrillMachineRewireState>>(value);
		}

		[Ordinal(4)] 
		[RED("sucess")] 
		public CBool Sucess
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RewireEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
