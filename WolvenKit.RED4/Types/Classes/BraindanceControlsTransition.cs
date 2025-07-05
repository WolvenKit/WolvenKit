
namespace WolvenKit.RED4.Types
{
	public abstract partial class BraindanceControlsTransition : DefaultTransition
	{
		public BraindanceControlsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
