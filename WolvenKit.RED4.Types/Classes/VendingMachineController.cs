
namespace WolvenKit.RED4.Types
{
	public partial class VendingMachineController : ScriptableDeviceComponent
	{
		public VendingMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
