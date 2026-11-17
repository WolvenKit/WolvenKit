
namespace WolvenKit.RED4.Types
{
	public partial class SemiAutoEvents : WeaponEventsTransition
	{
		public SemiAutoEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
