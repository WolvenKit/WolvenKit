
namespace WolvenKit.RED4.Types
{
	public partial class ChargeMaxEvents : ChargeEventsAbstract
	{
		public ChargeMaxEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
