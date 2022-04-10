
namespace WolvenKit.RED4.Types
{
	public partial class DefaultTransition : gamestateMachineFunctor
	{
		public DefaultTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
