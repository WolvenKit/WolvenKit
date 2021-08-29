using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlaylistTrackChanged_ConditionType : questISystemConditionType
	{
		private CName _playlistName;

		[Ordinal(0)] 
		[RED("playlistName")] 
		public CName PlaylistName
		{
			get => GetProperty(ref _playlistName);
			set => SetProperty(ref _playlistName, value);
		}
	}
}
