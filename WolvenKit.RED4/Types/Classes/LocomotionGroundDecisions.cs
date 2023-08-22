
namespace WolvenKit.RED4.Types
{
	public abstract partial class LocomotionGroundDecisions : LocomotionTransition
	{
		public LocomotionGroundDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
