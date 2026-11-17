
namespace WolvenKit.RED4.Types
{
	public partial class LadderControllerPS : ScriptableDeviceComponentPS
	{
		public LadderControllerPS()
		{
			DeviceName = "LocKey#2226";
			TweakDBRecord = "Devices.Ladder";
			TweakDBDescriptionRecord = "device_descriptions.Ladder";
			ShouldScannerShowStatus = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
