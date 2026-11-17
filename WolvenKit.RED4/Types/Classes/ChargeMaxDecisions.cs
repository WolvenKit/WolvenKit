
namespace WolvenKit.RED4.Types
{
	public partial class ChargeMaxDecisions : WeaponTransition
	{
		public ChargeMaxDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
