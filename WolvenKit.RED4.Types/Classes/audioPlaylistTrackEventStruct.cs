using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPlaylistTrackEventStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playlistName")] 
		public CName PlaylistName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("trackName")] 
		public CName TrackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioPlaylistTrackEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
