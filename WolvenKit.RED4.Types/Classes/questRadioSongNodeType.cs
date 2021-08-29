using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRadioSongNodeType : questIAudioNodeType
	{
		private CArray<audioRadioStationSongEventStruct> _radioStationEvents;

		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<audioRadioStationSongEventStruct> RadioStationEvents
		{
			get => GetProperty(ref _radioStationEvents);
			set => SetProperty(ref _radioStationEvents, value);
		}
	}
}
