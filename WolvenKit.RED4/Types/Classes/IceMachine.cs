
namespace WolvenKit.RED4.Types
{
	public partial class IceMachine : VendingMachine
	{
		public IceMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
