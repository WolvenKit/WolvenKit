using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioBulletImpactSettings : audioEntitySettings
	{
		[Ordinal(6)] 
		[RED("lowImpactSound")] 
		public CName LowImpactSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("medImpactSound")] 
		public CName MedImpactSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("hiImpactSound")] 
		public CName HiImpactSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("critImpactSound")] 
		public CName CritImpactSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("npcImpactSound")] 
		public CName NpcImpactSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("mediumDamageDistance")] 
		public CFloat MediumDamageDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("highDamageDistance")] 
		public CFloat HighDamageDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioBulletImpactSettings()
		{
			CommonSettings = new audioCommonEntitySettings { StopAllSoundsOnDetach = true };
			ScanningSettings = new audioScanningSettings();
			AuxiliaryMetadata = new audioAuxiliaryMetadata();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
