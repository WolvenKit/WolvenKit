
namespace WolvenKit.RED4.Types
{
	public partial class ExitLightControllerPS : ScriptableDeviceComponentPS
	{
		public ExitLightControllerPS()
		{
			DeviceName = "Exit Light";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
