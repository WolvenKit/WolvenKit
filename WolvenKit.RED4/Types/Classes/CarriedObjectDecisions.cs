
namespace WolvenKit.RED4.Types
{
	public abstract partial class CarriedObjectDecisions : CarriedObjectTransition
	{
		public CarriedObjectDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
