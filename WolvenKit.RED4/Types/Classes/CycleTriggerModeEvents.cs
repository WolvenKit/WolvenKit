
namespace WolvenKit.RED4.Types
{
	public partial class CycleTriggerModeEvents : WeaponEventsTransition
	{
		public CycleTriggerModeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
