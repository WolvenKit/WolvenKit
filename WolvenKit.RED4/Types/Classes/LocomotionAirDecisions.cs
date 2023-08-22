
namespace WolvenKit.RED4.Types
{
	public abstract partial class LocomotionAirDecisions : LocomotionTransition
	{
		public LocomotionAirDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
