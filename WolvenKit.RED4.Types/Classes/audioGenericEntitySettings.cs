
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericEntitySettings : audioEntitySettings
	{

		public audioGenericEntitySettings()
		{
			CommonSettings = new() { StopAllSoundsOnDetach = true };
			ScanningSettings = new();
			AuxiliaryMetadata = new();
		}
	}
}
