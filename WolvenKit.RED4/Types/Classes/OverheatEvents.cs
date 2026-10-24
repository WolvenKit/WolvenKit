
namespace WolvenKit.RED4.Types
{
	public partial class OverheatEvents : WeaponEventsTransition
	{
		public OverheatEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
