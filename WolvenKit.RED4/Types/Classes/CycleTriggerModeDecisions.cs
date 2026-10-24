
namespace WolvenKit.RED4.Types
{
	public partial class CycleTriggerModeDecisions : WeaponTransition
	{
		public CycleTriggerModeDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
