
namespace WolvenKit.RED4.Types
{
	public abstract partial class TurretTransition : DefaultTransition
	{
		public TurretTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
