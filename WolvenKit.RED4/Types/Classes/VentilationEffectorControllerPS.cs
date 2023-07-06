
namespace WolvenKit.RED4.Types
{
	public partial class VentilationEffectorControllerPS : ActivatedDeviceControllerPS
	{
		public VentilationEffectorControllerPS()
		{
			TweakDBRecord = "Devices.VentilationEffector";
			TweakDBDescriptionRecord = 169996443522;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
