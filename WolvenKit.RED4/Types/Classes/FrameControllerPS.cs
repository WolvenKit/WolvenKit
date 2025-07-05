
namespace WolvenKit.RED4.Types
{
	public partial class FrameControllerPS : ScriptableDeviceComponentPS
	{
		public FrameControllerPS()
		{
			DeviceName = "Frame";
			HasUICameraZoom = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
