
namespace WolvenKit.RED4.Types
{
	public partial class AirHoverEvents : LocomotionAirEvents
	{
		public AirHoverEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
