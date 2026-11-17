
namespace WolvenKit.RED4.Types
{
	public partial class NoAmmoEvents : WeaponEventsTransition
	{
		public NoAmmoEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
