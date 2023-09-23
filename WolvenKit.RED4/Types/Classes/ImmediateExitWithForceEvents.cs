using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ImmediateExitWithForceEvents : ExitingEventsBase
	{
		[Ordinal(4)] 
		[RED("exitForce")] 
		public gamestateMachineResultVector ExitForce
		{
			get => GetPropertyValue<gamestateMachineResultVector>();
			set => SetPropertyValue<gamestateMachineResultVector>(value);
		}

		[Ordinal(5)] 
		[RED("bikeForce")] 
		public gamestateMachineResultVector BikeForce
		{
			get => GetPropertyValue<gamestateMachineResultVector>();
			set => SetPropertyValue<gamestateMachineResultVector>(value);
		}

		[Ordinal(6)] 
		[RED("knockOverBike")] 
		public CHandle<KnockOverBikeEvent> KnockOverBike
		{
			get => GetPropertyValue<CHandle<KnockOverBikeEvent>>();
			set => SetPropertyValue<CHandle<KnockOverBikeEvent>>(value);
		}

		public ImmediateExitWithForceEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
