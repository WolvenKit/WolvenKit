
namespace WolvenKit.RED4.Types
{
	public partial class PersonnelSystemControllerPS : DeviceSystemBaseControllerPS
	{
		public PersonnelSystemControllerPS()
		{
			DeviceName = "BaseDeviceSystemControllerPS";
			TweakDBRecord = "Devices.PersonnelSystem";
			TweakDBDescriptionRecord = "device_descriptions.PersonnelSystem";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
