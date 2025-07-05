
namespace WolvenKit.RED4.Types
{
	public partial class PersonnelSystemControllerPS : DeviceSystemBaseControllerPS
	{
		public PersonnelSystemControllerPS()
		{
			DeviceName = "BaseDeviceSystemControllerPS";
			TweakDBRecord = "Devices.PersonnelSystem";
			TweakDBDescriptionRecord = 154457407903;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
