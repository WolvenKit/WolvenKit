using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistMetadata : audioAudioMetadata
	{
		private CUInt8 _broadcastChannel;
		private CArray<CName> _tracks;

		[Ordinal(1)] 
		[RED("broadcastChannel")] 
		public CUInt8 BroadcastChannel
		{
			get
			{
				if (_broadcastChannel == null)
				{
					_broadcastChannel = (CUInt8) CR2WTypeManager.Create("Uint8", "broadcastChannel", cr2w, this);
				}
				return _broadcastChannel;
			}
			set
			{
				if (_broadcastChannel == value)
				{
					return;
				}
				_broadcastChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tracks", cr2w, this);
				}
				return _tracks;
			}
			set
			{
				if (_tracks == value)
				{
					return;
				}
				_tracks = value;
				PropertySet(this);
			}
		}

		public audioPlaylistMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
