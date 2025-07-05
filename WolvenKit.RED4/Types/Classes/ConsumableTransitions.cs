
namespace WolvenKit.RED4.Types
{
	public abstract partial class ConsumableTransitions : DefaultTransition
	{
		public ConsumableTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
