
namespace WolvenKit.RED4.Types
{
	public partial class FullAutoEvents : WeaponEventsTransition
	{
		public FullAutoEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
