
namespace WolvenKit.RED4.Types
{
	public partial class PublicSafeToReadyEvents : WeaponEventsTransition
	{
		public PublicSafeToReadyEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
