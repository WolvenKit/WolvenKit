
namespace WolvenKit.RED4.Types
{
	public partial class SlideFallEvents : LocomotionAirEvents
	{
		public SlideFallEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
