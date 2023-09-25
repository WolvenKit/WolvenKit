
namespace WolvenKit.RED4.Types
{
	public partial class JumpEvents : LocomotionAirEvents
	{
		public JumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
