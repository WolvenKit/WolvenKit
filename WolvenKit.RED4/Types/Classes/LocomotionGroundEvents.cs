
namespace WolvenKit.RED4.Types
{
	public abstract partial class LocomotionGroundEvents : LocomotionEventsTransition
	{
		public LocomotionGroundEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
