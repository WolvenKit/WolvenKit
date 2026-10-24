
namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterLightControllerPS : DestructibleMasterDeviceControllerPS
	{
		public DestructibleMasterLightControllerPS()
		{
			DeviceName = "LocKey#42165";
			TweakDBRecord = "Devices.ElectricLight";
			TweakDBDescriptionRecord = "device_descriptions.ElectricLight";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
