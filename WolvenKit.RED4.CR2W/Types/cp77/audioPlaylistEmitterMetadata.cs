using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistEmitterMetadata : audioEmitterMetadata
	{
		private CName _receiverType;
		private CName _playlistMetadataName;

		[Ordinal(1)] 
		[RED("receiverType")] 
		public CName ReceiverType
		{
			get
			{
				if (_receiverType == null)
				{
					_receiverType = (CName) CR2WTypeManager.Create("CName", "receiverType", cr2w, this);
				}
				return _receiverType;
			}
			set
			{
				if (_receiverType == value)
				{
					return;
				}
				_receiverType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playlistMetadataName")] 
		public CName PlaylistMetadataName
		{
			get
			{
				if (_playlistMetadataName == null)
				{
					_playlistMetadataName = (CName) CR2WTypeManager.Create("CName", "playlistMetadataName", cr2w, this);
				}
				return _playlistMetadataName;
			}
			set
			{
				if (_playlistMetadataName == value)
				{
					return;
				}
				_playlistMetadataName = value;
				PropertySet(this);
			}
		}

		public audioPlaylistEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
