using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlaylistTrackNode : questIAudioNodeType
	{
		private CArray<audioPlaylistTrackEventStruct> _playlistEvents;

		[Ordinal(0)] 
		[RED("playlistEvents")] 
		public CArray<audioPlaylistTrackEventStruct> PlaylistEvents
		{
			get => GetProperty(ref _playlistEvents);
			set => SetProperty(ref _playlistEvents, value);
		}

		public questPlaylistTrackNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
