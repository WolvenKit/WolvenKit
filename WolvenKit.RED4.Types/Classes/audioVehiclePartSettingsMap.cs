using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehiclePartSettingsMap : audioAudioMetadata
	{
		private CFloat _minAcousticsIsolationFactorValue;
		private CArray<audioVehiclePartSettingsMapItem> _partSettings;

		[Ordinal(1)] 
		[RED("minAcousticsIsolationFactorValue")] 
		public CFloat MinAcousticsIsolationFactorValue
		{
			get => GetProperty(ref _minAcousticsIsolationFactorValue);
			set => SetProperty(ref _minAcousticsIsolationFactorValue, value);
		}

		[Ordinal(2)] 
		[RED("partSettings")] 
		public CArray<audioVehiclePartSettingsMapItem> PartSettings
		{
			get => GetProperty(ref _partSettings);
			set => SetProperty(ref _partSettings, value);
		}
	}
}
