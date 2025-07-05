using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FinisherLeapToTargetDecisions : FinisherTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<FinisherInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<FinisherInitData>>();
			set => SetPropertyValue<CWeakHandle<FinisherInitData>>(value);
		}

		public FinisherLeapToTargetDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
