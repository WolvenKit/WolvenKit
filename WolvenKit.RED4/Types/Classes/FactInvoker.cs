
namespace WolvenKit.RED4.Types
{
	public partial class FactInvoker : InteractiveMasterDevice
	{
		public FactInvoker()
		{
			ControllerTypeName = "FactInvokerController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
