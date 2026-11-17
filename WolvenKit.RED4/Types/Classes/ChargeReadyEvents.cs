
namespace WolvenKit.RED4.Types
{
	public partial class ChargeReadyEvents : ChargeEventsAbstract
	{
		public ChargeReadyEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
