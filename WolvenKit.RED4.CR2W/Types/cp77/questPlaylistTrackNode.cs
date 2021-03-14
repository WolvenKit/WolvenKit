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
			get
			{
				if (_playlistEvents == null)
				{
					_playlistEvents = (CArray<audioPlaylistTrackEventStruct>) CR2WTypeManager.Create("array:audioPlaylistTrackEventStruct", "playlistEvents", cr2w, this);
				}
				return _playlistEvents;
			}
			set
			{
				if (_playlistEvents == value)
				{
					return;
				}
				_playlistEvents = value;
				PropertySet(this);
			}
		}

		public questPlaylistTrackNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
