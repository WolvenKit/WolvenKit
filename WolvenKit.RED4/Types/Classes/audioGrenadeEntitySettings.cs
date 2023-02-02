using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGrenadeEntitySettings : audioEntitySettings
	{
		[Ordinal(6)] 
		[RED("explosionSound")] 
		public CName ExplosionSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioGrenadeEntitySettings()
		{
			CommonSettings = new() { StopAllSoundsOnDetach = true };
			ScanningSettings = new();
			AuxiliaryMetadata = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
