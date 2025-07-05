
namespace WolvenKit.RED4.Types
{
	public abstract partial class CarriedObjectTransition : DefaultTransition
	{
		public CarriedObjectTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
