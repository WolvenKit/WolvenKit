
namespace WolvenKit.RED4.Types
{
	public abstract partial class ZoomTransition : DefaultTransition
	{
		public ZoomTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
