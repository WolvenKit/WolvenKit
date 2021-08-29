using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlaylistTrackNode : questIAudioNodeType
	{
		private CArray<audioPlaylistTrackEventStruct> _playlistEvents;

		[Ordinal(0)] 
		[RED("playlistEvents")] 
		public CArray<audioPlaylistTrackEventStruct> PlaylistEvents
		{
			get => GetProperty(ref _playlistEvents);
			set => SetProperty(ref _playlistEvents, value);
		}
	}
}
