
namespace WolvenKit.RED4.Types
{
	public partial class ShootEvents : WeaponEventsTransition
	{
		public ShootEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
