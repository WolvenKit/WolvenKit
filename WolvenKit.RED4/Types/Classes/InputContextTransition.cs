
namespace WolvenKit.RED4.Types
{
	public abstract partial class InputContextTransition : DefaultTransition
	{
		public InputContextTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
