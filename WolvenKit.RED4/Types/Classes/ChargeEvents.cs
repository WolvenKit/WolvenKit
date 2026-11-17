
namespace WolvenKit.RED4.Types
{
	public partial class ChargeEvents : ChargeEventsAbstract
	{
		public ChargeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
