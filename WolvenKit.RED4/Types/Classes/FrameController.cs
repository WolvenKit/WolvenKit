
namespace WolvenKit.RED4.Types
{
	public partial class FrameController : ScriptableDeviceComponent
	{
		public FrameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
