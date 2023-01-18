
namespace WolvenKit.RED4.Types
{
	public partial class LocomotionAirLowGravityEvents : LocomotionAirEvents
	{
		public LocomotionAirLowGravityEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
