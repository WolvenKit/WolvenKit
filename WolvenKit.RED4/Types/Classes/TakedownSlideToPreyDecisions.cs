using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TakedownSlideToPreyDecisions : LocomotionTakedownDecisions
	{
		[Ordinal(3)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<LocomotionTakedownInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>();
			set => SetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>(value);
		}

		public TakedownSlideToPreyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
