
namespace WolvenKit.RED4.Types
{
	public partial class LadderJumpEvents : LocomotionAirEvents
	{
		public LadderJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
