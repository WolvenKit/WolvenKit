
namespace WolvenKit.RED4.Types
{
	public partial class audioGenericEntitySettings : audioEntitySettings
	{
		public audioGenericEntitySettings()
		{
			CommonSettings = new() { StopAllSoundsOnDetach = true };
			ScanningSettings = new();
			AuxiliaryMetadata = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
