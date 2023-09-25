
namespace WolvenKit.RED4.Types
{
	public partial class FallEvents : LocomotionAirEvents
	{
		public FallEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
