
namespace WolvenKit.RED4.Types
{
	public abstract partial class CoverActionTransition : LocomotionTransition
	{
		public CoverActionTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
