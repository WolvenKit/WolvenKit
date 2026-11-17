
namespace WolvenKit.RED4.Types
{
	public partial class GlitchedTurretControllerPS : ScriptableDeviceComponentPS
	{
		public GlitchedTurretControllerPS()
		{
			DeviceName = "LocKey#121";
			TweakDBRecord = "Devices.SecurityTurret";
			TweakDBDescriptionRecord = "device_descriptions.SecurityTurret";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
