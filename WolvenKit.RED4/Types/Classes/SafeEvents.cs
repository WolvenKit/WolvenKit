
namespace WolvenKit.RED4.Types
{
	public partial class SafeEvents : WeaponEventsTransition
	{
		public SafeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
