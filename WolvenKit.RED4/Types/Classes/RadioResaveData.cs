using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get => GetPropertyValue<MediaResaveData>();
			set => SetPropertyValue<MediaResaveData>(value);
		}

		[Ordinal(1)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetPropertyValue<CArray<RadioStationsMap>>();
			set => SetPropertyValue<CArray<RadioStationsMap>>(value);
		}

		public RadioResaveData()
		{
			MediaResaveData = new() { MediaDeviceData = new() };
			Stations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
