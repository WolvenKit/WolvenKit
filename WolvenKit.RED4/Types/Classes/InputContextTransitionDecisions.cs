
namespace WolvenKit.RED4.Types
{
	public abstract partial class InputContextTransitionDecisions : InputContextTransition
	{
		public InputContextTransitionDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
