
namespace WolvenKit.RED4.Types
{
	public partial class BurstEvents : WeaponEventsTransition
	{
		public BurstEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
