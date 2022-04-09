using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehiclePartSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("minAcousticsIsolationFactorValue")] 
		public CFloat MinAcousticsIsolationFactorValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("partSettings")] 
		public CArray<audioVehiclePartSettingsMapItem> PartSettings
		{
			get => GetPropertyValue<CArray<audioVehiclePartSettingsMapItem>>();
			set => SetPropertyValue<CArray<audioVehiclePartSettingsMapItem>>(value);
		}

		public audioVehiclePartSettingsMap()
		{
			MinAcousticsIsolationFactorValue = 0.200000F;
			PartSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
