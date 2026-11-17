
namespace WolvenKit.RED4.Types
{
	public partial class NotReadyEvents : WeaponEventsTransition
	{
		public NotReadyEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
