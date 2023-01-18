using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlaylistTrackNode : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("playlistEvents")] 
		public CArray<audioPlaylistTrackEventStruct> PlaylistEvents
		{
			get => GetPropertyValue<CArray<audioPlaylistTrackEventStruct>>();
			set => SetPropertyValue<CArray<audioPlaylistTrackEventStruct>>(value);
		}

		public questPlaylistTrackNode()
		{
			PlaylistEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
