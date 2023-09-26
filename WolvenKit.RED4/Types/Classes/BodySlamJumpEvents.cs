
namespace WolvenKit.RED4.Types
{
	public partial class BodySlamJumpEvents : LocomotionAirEvents
	{
		public BodySlamJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
