using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FinisherAttackEvents : FinisherTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<FinisherInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<FinisherInitData>>();
			set => SetPropertyValue<CWeakHandle<FinisherInitData>>(value);
		}

		public FinisherAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
