
namespace WolvenKit.RED4.Types
{
	public partial class Mainframe : BaseAnimatedDevice
	{
		public Mainframe()
		{
			ControllerTypeName = "MainframeController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
