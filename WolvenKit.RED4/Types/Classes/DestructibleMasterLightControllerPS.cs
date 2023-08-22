
namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterLightControllerPS : DestructibleMasterDeviceControllerPS
	{
		public DestructibleMasterLightControllerPS()
		{
			DeviceName = "LocKey#42165";
			TweakDBRecord = "Devices.ElectricLight";
			TweakDBDescriptionRecord = 142476847136;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
