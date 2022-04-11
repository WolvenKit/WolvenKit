using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LocomotionTakedownEvents : LocomotionEventsTransition
	{
		[Ordinal(6)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<LocomotionTakedownInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>();
			set => SetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>(value);
		}

		public LocomotionTakedownEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
