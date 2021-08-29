using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRadioStationSongEventStruct : RedBaseClass
	{
		private CName _radioStationName;
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(1)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetProperty(ref _radioSongName);
			set => SetProperty(ref _radioSongName, value);
		}
	}
}
