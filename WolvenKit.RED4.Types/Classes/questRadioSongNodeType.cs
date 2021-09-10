using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
