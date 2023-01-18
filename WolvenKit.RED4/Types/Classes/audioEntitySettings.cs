using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEntitySettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("commonSettings")] 
		public audioCommonEntitySettings CommonSettings
		{
			get => GetPropertyValue<audioCommonEntitySettings>();
			set => SetPropertyValue<audioCommonEntitySettings>(value);
		}

		[Ordinal(2)] 
		[RED("scanningSettings")] 
		public audioScanningSettings ScanningSettings
		{
			get => GetPropertyValue<audioScanningSettings>();
			set => SetPropertyValue<audioScanningSettings>(value);
		}

		[Ordinal(3)] 
		[RED("auxiliaryMetadata")] 
		public audioAuxiliaryMetadata AuxiliaryMetadata
		{
			get => GetPropertyValue<audioAuxiliaryMetadata>();
			set => SetPropertyValue<audioAuxiliaryMetadata>(value);
		}

		[Ordinal(4)] 
		[RED("emitterDecoratorMetadata")] 
		public CName EmitterDecoratorMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioEntitySettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
