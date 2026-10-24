
namespace WolvenKit.RED4.Types
{
	public partial class QuickMeleeDecisions : WeaponTransition
	{
		public QuickMeleeDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
