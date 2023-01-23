using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrappleStruggleDecisions : LocomotionTakedownDecisions
	{
		[Ordinal(3)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<LocomotionTakedownInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>();
			set => SetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>(value);
		}

		public GrappleStruggleDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
