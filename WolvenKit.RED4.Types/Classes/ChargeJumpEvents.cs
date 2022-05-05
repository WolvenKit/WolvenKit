
namespace WolvenKit.RED4.Types
{
	public partial class ChargeJumpEvents : LocomotionAirEvents
	{
		public ChargeJumpEvents()
		{
			UpdateInputToggles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
