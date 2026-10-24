
namespace WolvenKit.RED4.Types
{
	public partial class VentilationEffectorControllerPS : ActivatedDeviceControllerPS
	{
		public VentilationEffectorControllerPS()
		{
			TweakDBRecord = "Devices.VentilationEffector";
			TweakDBDescriptionRecord = "device_descriptions.VentilationEffector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
