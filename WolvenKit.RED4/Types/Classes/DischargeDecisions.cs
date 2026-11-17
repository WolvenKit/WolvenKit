
namespace WolvenKit.RED4.Types
{
	public partial class DischargeDecisions : WeaponTransition
	{
		public DischargeDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
