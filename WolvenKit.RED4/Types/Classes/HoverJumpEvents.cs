
namespace WolvenKit.RED4.Types
{
	public partial class HoverJumpEvents : LocomotionAirEvents
	{
		public HoverJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
