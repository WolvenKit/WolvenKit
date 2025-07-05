using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioStationSongEventStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioRadioStationSongEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
