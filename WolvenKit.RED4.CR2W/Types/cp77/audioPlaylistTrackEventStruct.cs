using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistTrackEventStruct : CVariable
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

		public audioPlaylistTrackEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
