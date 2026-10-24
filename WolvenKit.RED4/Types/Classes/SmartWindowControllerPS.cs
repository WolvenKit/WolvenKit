
namespace WolvenKit.RED4.Types
{
	public partial class SmartWindowControllerPS : ComputerControllerPS
	{
		public SmartWindowControllerPS()
		{
			DeviceName = "LocKey#110";
			TweakDBRecord = "Devices.SmartWindow";
			TweakDBDescriptionRecord = "device_descriptions.SmartWindow";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
