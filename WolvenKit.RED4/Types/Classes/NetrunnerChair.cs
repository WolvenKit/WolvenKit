
namespace WolvenKit.RED4.Types
{
	public partial class NetrunnerChair : InteractiveDevice
	{
		public NetrunnerChair()
		{
			ControllerTypeName = "NetrunnerChairController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
