
namespace WolvenKit.RED4.Types
{
	public partial class WeaponTrainingControllerPS : ScriptableDeviceComponentPS
	{
		public WeaponTrainingControllerPS()
		{
			DeviceName = "LocKey#79367";
			ShouldScannerShowStatus = false;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
