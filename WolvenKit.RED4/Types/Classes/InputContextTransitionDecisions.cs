
namespace WolvenKit.RED4.Types
{
	public abstract partial class InputContextTransitionDecisions : DefaultTransition
	{
		public InputContextTransitionDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
