
namespace WolvenKit.RED4.Types
{
	public partial class SuperheroFallEvents : LocomotionAirEvents
	{
		public SuperheroFallEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
