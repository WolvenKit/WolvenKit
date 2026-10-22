
namespace WolvenKit.RED4.Types
{
	public partial class DoorSystemControllerPS : BaseNetworkSystemControllerPS
	{
		public DoorSystemControllerPS()
		{
			TweakDBRecord = "Devices.DoorSystem";
			TweakDBDescriptionRecord = "device_descriptions.DoorSystem";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
