
namespace WolvenKit.RED4.Types
{
	public partial class ChargeReadyDecisions : WeaponTransition
	{
		public ChargeReadyDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
