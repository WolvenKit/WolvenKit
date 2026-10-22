
namespace WolvenKit.RED4.Types
{
	public abstract partial class ShootTransition : DefaultTransition
	{
		public ShootTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
