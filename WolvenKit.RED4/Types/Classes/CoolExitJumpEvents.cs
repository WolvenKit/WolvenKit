
namespace WolvenKit.RED4.Types
{
	public partial class CoolExitJumpEvents : LocomotionAirEvents
	{
		public CoolExitJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
