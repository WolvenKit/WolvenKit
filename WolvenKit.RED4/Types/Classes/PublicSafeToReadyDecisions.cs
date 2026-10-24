
namespace WolvenKit.RED4.Types
{
	public partial class PublicSafeToReadyDecisions : WeaponTransition
	{
		public PublicSafeToReadyDecisions()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
