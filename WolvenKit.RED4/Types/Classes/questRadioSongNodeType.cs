using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRadioSongNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<audioRadioStationSongEventStruct> RadioStationEvents
		{
			get => GetPropertyValue<CArray<audioRadioStationSongEventStruct>>();
			set => SetPropertyValue<CArray<audioRadioStationSongEventStruct>>(value);
		}

		public questRadioSongNodeType()
		{
			RadioStationEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
