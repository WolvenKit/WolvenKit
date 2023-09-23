
namespace WolvenKit.RED4.Types
{
	public partial class CarryDecisions : CanTransitionToThrowDecisions
	{
		public CarryDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
