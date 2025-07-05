
namespace WolvenKit.RED4.Types
{
	public partial class DoubleJumpEvents : LocomotionAirEvents
	{
		public DoubleJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
