
namespace WolvenKit.RED4.Types
{
	public partial class PickUpDecisions : CanTransitionToThrowDecisions
	{
		public PickUpDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
