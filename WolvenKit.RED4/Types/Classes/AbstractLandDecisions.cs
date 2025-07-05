
namespace WolvenKit.RED4.Types
{
	public abstract partial class AbstractLandDecisions : LocomotionGroundDecisions
	{
		public AbstractLandDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
