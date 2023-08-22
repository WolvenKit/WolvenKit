
namespace WolvenKit.RED4.Types
{
	public partial class audioGenericEntitySettings : audioEntitySettings
	{
		public audioGenericEntitySettings()
		{
			CommonSettings = new audioCommonEntitySettings { StopAllSoundsOnDetach = true };
			ScanningSettings = new audioScanningSettings();
			AuxiliaryMetadata = new audioAuxiliaryMetadata();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
