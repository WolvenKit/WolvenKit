
namespace WolvenKit.RED4.Types
{
	public abstract partial class FinisherTransition : DefaultTransition
	{
		public FinisherTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
