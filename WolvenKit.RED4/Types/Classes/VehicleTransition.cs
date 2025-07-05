using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class VehicleTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<VehicleTransitionInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<VehicleTransitionInitData>>();
			set => SetPropertyValue<CWeakHandle<VehicleTransitionInitData>>(value);
		}

		[Ordinal(1)] 
		[RED("exitSlot")] 
		public CName ExitSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public VehicleTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
