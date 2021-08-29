using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlaylistTrackEventStruct : RedBaseClass
	{
		private CName _playlistName;
		private CName _trackName;

		[Ordinal(0)] 
		[RED("playlistName")] 
		public CName PlaylistName
		{
			get => GetProperty(ref _playlistName);
			set => SetProperty(ref _playlistName, value);
		}

		[Ordinal(1)] 
		[RED("trackName")] 
		public CName TrackName
		{
			get => GetProperty(ref _trackName);
			set => SetProperty(ref _trackName, value);
		}
	}
}
