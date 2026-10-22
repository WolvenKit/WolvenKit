
namespace WolvenKit.RED4.Types
{
	public partial class CycleRoundDecisions : WeaponTransition
	{
		public CycleRoundDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
