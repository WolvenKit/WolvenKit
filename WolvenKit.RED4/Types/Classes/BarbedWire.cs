
namespace WolvenKit.RED4.Types
{
	public partial class BarbedWire : ActivatedDeviceTrap
	{
		public BarbedWire()
		{
			ControllerTypeName = "BarbedWireController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
