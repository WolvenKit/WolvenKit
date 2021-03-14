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
			get
			{
				if (_playlistName == null)
				{
					_playlistName = (CName) CR2WTypeManager.Create("CName", "playlistName", cr2w, this);
				}
				return _playlistName;
			}
			set
			{
				if (_playlistName == value)
				{
					return;
				}
				_playlistName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trackName")] 
		public CName TrackName
		{
			get
			{
				if (_trackName == null)
				{
					_trackName = (CName) CR2WTypeManager.Create("CName", "trackName", cr2w, this);
				}
				return _trackName;
			}
			set
			{
				if (_trackName == value)
				{
					return;
				}
				_trackName = value;
				PropertySet(this);
			}
		}

		public audioPlaylistTrackEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
