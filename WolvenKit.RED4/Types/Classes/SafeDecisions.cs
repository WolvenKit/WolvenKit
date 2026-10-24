
namespace WolvenKit.RED4.Types
{
	public partial class SafeDecisions : WeaponTransition
	{
		public SafeDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
