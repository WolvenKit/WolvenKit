
namespace WolvenKit.RED4.Types
{
	public partial class BurstDecisions : WeaponTransition
	{
		public BurstDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
