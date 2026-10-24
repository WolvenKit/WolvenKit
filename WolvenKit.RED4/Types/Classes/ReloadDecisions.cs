
namespace WolvenKit.RED4.Types
{
	public partial class ReloadDecisions : WeaponTransition
	{
		public ReloadDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
