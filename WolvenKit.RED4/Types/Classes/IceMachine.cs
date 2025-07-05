
namespace WolvenKit.RED4.Types
{
	public partial class IceMachine : VendingMachine
	{
		public IceMachine()
		{
			ControllerTypeName = "IceMachineController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
