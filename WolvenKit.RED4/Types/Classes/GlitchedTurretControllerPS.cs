
namespace WolvenKit.RED4.Types
{
	public partial class GlitchedTurretControllerPS : ScriptableDeviceComponentPS
	{
		public GlitchedTurretControllerPS()
		{
			DeviceName = "LocKey#121";
			TweakDBRecord = "Devices.SecurityTurret";
			TweakDBDescriptionRecord = 147741407213;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
