using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEntitySettings : audioAudioMetadata
	{
		private audioCommonEntitySettings _commonSettings;
		private audioScanningSettings _scanningSettings;
		private audioAuxiliaryMetadata _auxiliaryMetadata;
		private CName _emitterDecoratorMetadata;
		private CBool _preferSoundComponentPosition;

		[Ordinal(1)] 
		[RED("commonSettings")] 
		public audioCommonEntitySettings CommonSettings
		{
			get => GetProperty(ref _commonSettings);
			set => SetProperty(ref _commonSettings, value);
		}

		[Ordinal(2)] 
		[RED("scanningSettings")] 
		public audioScanningSettings ScanningSettings
		{
			get => GetProperty(ref _scanningSettings);
			set => SetProperty(ref _scanningSettings, value);
		}

		[Ordinal(3)] 
		[RED("auxiliaryMetadata")] 
		public audioAuxiliaryMetadata AuxiliaryMetadata
		{
			get => GetProperty(ref _auxiliaryMetadata);
			set => SetProperty(ref _auxiliaryMetadata, value);
		}

		[Ordinal(4)] 
		[RED("emitterDecoratorMetadata")] 
		public CName EmitterDecoratorMetadata
		{
			get => GetProperty(ref _emitterDecoratorMetadata);
			set => SetProperty(ref _emitterDecoratorMetadata, value);
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get => GetProperty(ref _preferSoundComponentPosition);
			set => SetProperty(ref _preferSoundComponentPosition, value);
		}
	}
}
