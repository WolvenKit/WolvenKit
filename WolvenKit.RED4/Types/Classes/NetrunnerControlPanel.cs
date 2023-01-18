
namespace WolvenKit.RED4.Types
{
	public partial class NetrunnerControlPanel : BasicDistractionDevice
	{
		public NetrunnerControlPanel()
		{
			ControllerTypeName = "NetrunnerControlPanelController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
