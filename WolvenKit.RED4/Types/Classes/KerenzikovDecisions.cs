using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KerenzikovDecisions : TimeDilationTransitions
	{
		[Ordinal(0)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatListener>>(value);
		}

		[Ordinal(1)] 
		[RED("activationGracePeriod")] 
		public CFloat ActivationGracePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public KerenzikovDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
