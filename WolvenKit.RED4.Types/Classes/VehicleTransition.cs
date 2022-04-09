using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<VehicleTransitionInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<VehicleTransitionInitData>>();
			set => SetPropertyValue<CWeakHandle<VehicleTransitionInitData>>(value);
		}

		public VehicleTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
